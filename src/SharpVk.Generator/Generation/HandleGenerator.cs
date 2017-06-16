using Microsoft.Extensions.DependencyInjection;
using SharpVk.Emit;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Generation.Marshalling;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Rules;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation
{
    public class HandleGenerator
        : IWorker
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;
        private readonly Dictionary<string, IEnumerable<CommandDeclaration>> commands;
        private readonly IEnumerable<IMarshalValueRule> marshallingRules;
        private readonly IEnumerable<IMemberPatternRule> memberPatternRules;
        private readonly ParsedExpressionTokenCheck tokenCheck;
        private readonly NamespaceMap namespaceMap;

        public HandleGenerator(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, IEnumerable<CommandDeclaration> commands, IEnumerable<IMarshalValueRule> marshallingRules, IEnumerable<IMemberPatternRule> memberPatternRules, ParsedExpressionTokenCheck tokenCheck, NamespaceMap namespaceMap)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.commands = commands.GroupBy(x => x.HandleTypeName).ToDictionary(x => x.Key, x => x.AsEnumerable());
            this.marshallingRules = marshallingRules;
            this.memberPatternRules = memberPatternRules;
            this.tokenCheck = tokenCheck;
            this.namespaceMap = namespaceMap;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var typePair in this.typeData.Where(x => x.Value.Pattern == TypePattern.Handle))
            {
                var type = typePair.Value;

                var commands = this.commands.ContainsKey(typePair.Key)
                                        ? this.commands[typePair.Key]
                                            .Where(x => x.Extension == null)
                                            .Select(x => GenerateCommand(x, typePair.Key, typePair.Value)).ToList()
                                        : new List<MethodDefinition>();

                var parentType = type.Parent != null
                                        ? typeData[type.Parent]
                                        : null;

                services.AddSingleton(new HandleDefinition
                {
                    Name = type.Name,
                    Parent = parentType?.Name,
                    Namespace = type.Extension != null ? this.namespaceMap.Map(type.Extension).ToArray() : null,
                    ParentNamespace = parentType?.Extension != null ? this.namespaceMap.Map(parentType.Extension).ToArray() : null,
                    IsDispatch = type.Type != "VK_DEFINE_NON_DISPATCHABLE_HANDLE",
                    Commands = commands
                });
            }
        }

        private MethodDefinition GenerateCommand(CommandDeclaration command, string handleTypeName, TypeDeclaration handleType)
        {
            var newMethod = new MethodDefinition
            {
                Name = command.Name,
                ReturnType = "void",
                IsPublic = true,
                IsUnsafe = true,
                AllocatesUnmanagedMemory = true
            };

            var handleLookup = new Dictionary<string, Action<ExpressionBuilder>>
            {
                [handleTypeName] = Member(This, "handle")
            };

            if (handleType.Parent != null)
            {
                handleLookup.Add(handleType.Parent, Member(This, "parent"));
            }

            Action<ExpressionBuilder> GetHandle(string handleName)
            {
                if (!handleLookup.TryGetValue(handleName, out var result))
                {
                    return Default("Interop." + this.typeData[handleName].Name);
                }

                return result;
            }

            var lastParam = command.Params.Last();

            bool lastParamIsArray = lastParam.Type.PointerType == PointerType.Pointer
                                        && lastParam.Dimensions != null
                                        && lastParam.Dimensions.Any(x => x.Type != LenType.NullTerminated);

            bool lastParamLenFieldByRef = lastParamIsArray
                                            && lastParam.Dimensions[0].Value is LenExpressionToken
                                            && command.Params.Single(x => x.VkName == ((LenExpressionToken)lastParam.Dimensions[0].Value).Value).Type.PointerType == PointerType.Pointer;

            bool lastParamReturns = !lastParam.Type.PointerType.IsConst()
                                        && (typeData[lastParam.Type.VkName].IsOutputOnly
                                            || lastParam.Type.PointerType.GetPointerCount() == 2
                                            || typeData[lastParam.Type.VkName].Pattern != TypePattern.MarshalledStruct
                                            || typeData[lastParam.Type.VkName].Pattern != TypePattern.NonMarshalledStruct
                                            || lastParamLenFieldByRef
                                            || command.Verb == "get")
                                        && (command.ReturnType == "VkResult" || command.ReturnType == "void");

            if (command.HandleParamsCount == 0)
            {
                Debug.Assert(lastParamReturns);

                newMethod.IsStatic = true;
            }

            bool enumeratePattern = command.Verb == "enumerate" || (lastParamIsArray && lastParamLenFieldByRef);

            int parameterIndex = 0;

            newMethod.ParamActions = new List<ParamActionDefinition>();
            newMethod.MemberActions = new List<MethodAction>();

            var marshalFromActions = new List<MethodAction>();
            var marshalMidActions = new List<MethodAction>();
            var marshalToActions = new List<MethodAction>();

            var marshalledValues = new List<Action<ExpressionBuilder>>();

            foreach (var parameter in command.Params)
            {
                var newParams = this.GenerateParameter(command, newMethod, parameter, parameterIndex, enumeratePattern, lastParamIsArray, lastParamReturns, marshalFromActions, marshalMidActions, marshalToActions, marshalledValues, GetHandle);

                if (newParams != null)
                {
                    newMethod.ParamActions.AddRange(newParams);
                }

                parameterIndex++;
            }

            string returnType = null;

            if (command.ReturnType == "VkResult")
            {
                returnType = this.typeData["VkResult"].Name;
            }

            newMethod.MemberActions.AddRange(marshalToActions);

            newMethod.MemberActions.Add(new InvokeAction
            {
                TypeName = "Interop.Commands",
                MethodName = command.VkName,
                ReturnName = "methodResult",
                ReturnType = returnType,
                Parameters = marshalledValues.ToArray()
            });

            if (command.ReturnType == "VkResult")
            {
                newMethod.MemberActions.Add(new ValidateAction
                {
                    VariableName = "methodResult"
                });
            }

            if (enumeratePattern)
            {
                newMethod.MemberActions.AddRange(marshalMidActions);

                newMethod.MemberActions.Add(new InvokeAction
                {
                    TypeName = "Interop.Commands",
                    MethodName = command.VkName,
                    Parameters = marshalledValues.ToArray()
                });
            }

            newMethod.MemberActions.AddRange(marshalFromActions);

            return newMethod;
        }

        private IEnumerable<ParamActionDefinition> GenerateParameter(CommandDeclaration command, MethodDefinition newMethod, ParamDeclaration parameter, int parameterIndex, bool isEnumeratePattern, bool isLastParamArray, bool lastParamReturns, List<MethodAction> marshalFromActions, List<MethodAction> marshalMidActions, List<MethodAction> marshalToActions, List<Action<ExpressionBuilder>> marshalledValues, Func<string, Action<ExpressionBuilder>> getHandle)
        {
            string paramName = parameter.Name;
            var paramType = typeData[parameter.Type.VkName];

            string GetMarshalledName(string baseName)
            {
                return "marshalled" + baseName.TrimStart('@').FirstToUpper();
            }

            List<ParamActionDefinition> result = new List<ParamActionDefinition>();

            if (parameterIndex >= command.HandleParamsCount)
            {
                if (lastParamReturns && parameterIndex == command.Params.Count() - 2 && isEnumeratePattern)
                {
                    newMethod.MemberActions.Add(new DeclarationAction
                    {
                        MemberType = paramType.Name,
                        MemberName = paramName
                    });

                    marshalledValues.Add(AddressOf(Variable(paramName)));

                    var patternInfo = new MemberPatternInfo();

                    this.memberPatternRules.ApplyFirst(command.Params, command.Params.Last(), new MemberPatternContext(command.Verb, getHandle), patternInfo);

                    string marshalledName = GetMarshalledName(patternInfo.Interop.Name);

                    marshalMidActions.Add(new AssignAction
                    {
                        Type = AssignActionType.Alloc,
                        MemberType = patternInfo.InteropFullType.TrimEnd('*'),
                        TargetExpression = Variable(marshalledName),
                        LengthExpression = Cast("uint", Variable(paramName))
                    });
                }
                else if (lastParamReturns && parameterIndex == command.Params.Count() - 1)
                {
                    if (isLastParamArray)
                    {
                        var patternInfo = new MemberPatternInfo();

                        this.memberPatternRules.ApplyFirst(command.Params, parameter, new MemberPatternContext(command.Verb, getHandle), patternInfo);

                        string marshalledName = GetMarshalledName(patternInfo.Interop.Name);

                        marshalToActions.Add(new DeclarationAction
                        {
                            MemberType = patternInfo.InteropFullType,
                            MemberName = marshalledName
                        });

                        var newMarshalFrom = patternInfo.MarshalFrom.Select(action => action(targetName => Variable("result"), valueName => Variable(GetMarshalledName(valueName)))).ToArray();

                        if (!isEnumeratePattern)
                        {
                            var lengthExpression = newMarshalFrom.OfType<AssignAction>().First(x => x.IsLoop).LengthExpression;

                            marshalToActions.Add(new AssignAction
                            {
                                Type = AssignActionType.Alloc,
                                MemberType = patternInfo.InteropFullType.TrimEnd('*'),
                                TargetExpression = Variable(marshalledName),
                                LengthExpression = lengthExpression
                            });
                        }

                        marshalFromActions.AddRange(newMarshalFrom);

                        marshalledValues.Add(Variable(marshalledName));

                        newMethod.ReturnType = patternInfo.Public.Single().Type;
                    }
                    else
                    {
                        var patternInfo = new MemberPatternInfo();

                        var effectiveParam = new ParamDeclaration
                        {
                            Name = parameter.Name,
                            Type = parameter.Type.Deref(),
                            Dimensions = parameter.Dimensions,
                            VkName = parameter.VkName
                        };

                        this.memberPatternRules.ApplyFirst(command.Params, effectiveParam, new MemberPatternContext(command.Verb, getHandle), patternInfo);

                        string marshalledName = GetMarshalledName(patternInfo.Interop.Name);

                        marshalToActions.Add(new DeclarationAction
                        {
                            MemberType = patternInfo.InteropFullType,
                            MemberName = marshalledName
                        });

                        marshalFromActions.AddRange(patternInfo.MarshalFrom.Select(action => action(targetName => Variable("result"), valueName => Variable(GetMarshalledName(valueName)))));

                        marshalledValues.Add(AddressOf(Variable(marshalledName)));

                        newMethod.ReturnType = patternInfo.Public.Single().Type;
                    }
                }
                else
                {
                    var patternInfo = new MemberPatternInfo();

                    this.memberPatternRules.ApplyFirst(command.Params, parameter, new MemberPatternContext(command.Verb, getHandle), patternInfo);

                    var actionList = marshalToActions;

                    Func<string, Action<ExpressionBuilder>> getValue = valueName => Variable(valueName);

                    foreach (var publicMember in patternInfo.Public)
                    {
                        result.Add(new ParamActionDefinition
                        {
                            Param = new ParamDefinition
                            {
                                Name = publicMember.Name,
                                Type = publicMember.Type,
                                DefaultValue = publicMember.DefaultValue
                            }
                        });
                    }

                    if (patternInfo.MarshalTo.Any())
                    {
                        string marshalledName = patternInfo.Interop.Name;

                        if (patternInfo.Public.Any())
                        {
                            marshalledName = GetMarshalledName(patternInfo.Interop.Name);
                        }

                        var newMarshalToActions = patternInfo.MarshalTo.Select(action => action(targetName => Variable(marshalledName), getValue));

                        var lastParam = command.Params.Last();
                        bool isLenForLastParam = lastParamReturns && lastParam.Dimensions != null && lastParam.Dimensions.Any(dimension => dimension.Type == LenType.Expression && this.tokenCheck.Check(dimension.Value, parameter.VkName));

                        if (!isLenForLastParam && newMarshalToActions.Count() == 1 && newMarshalToActions.First() is AssignAction newAssignAction && newAssignAction.Type == AssignActionType.Assign && !newAssignAction.IsLoop)
                        {
                            marshalledValues.Add(newAssignAction.ValueExpression);
                        }
                        else
                        {
                            marshalToActions.Add(new DeclarationAction
                            {
                                MemberType = patternInfo.InteropFullType,
                                MemberName = marshalledName
                            });

                            marshalledValues.Add(Variable(marshalledName));

                            actionList.AddRange(newMarshalToActions);
                        }
                    }
                }
            }
            else
            {
                marshalledValues.Add(getHandle(parameter.Type.VkName));
            }

            return result;
        }
    }
}
