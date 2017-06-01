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

        public HandleGenerator(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, IEnumerable<CommandDeclaration> commands, IEnumerable<IMarshalValueRule> marshallingRules, IEnumerable<IMemberPatternRule> memberPatternRules)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.commands = commands.GroupBy(x => x.HandleTypeName).ToDictionary(x => x.Key, x => x.AsEnumerable());
            this.marshallingRules = marshallingRules;
            this.memberPatternRules = memberPatternRules;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var typePair in this.typeData.Where(x => x.Value.Pattern == TypePattern.Handle))
            {
                var type = typePair.Value;

                var commands = this.commands.ContainsKey(typePair.Key)
                                        ? this.commands[typePair.Key]
                                            .Where(x => x.Extension == null)
                                            .Select(GenerateCommand).ToList()
                                        : new List<MethodDefinition>();

                services.AddSingleton(new HandleDefinition
                {
                    Name = type.Name,
                    Namespace = type.Extension != null ? new[] { type.Extension } : null,
                    IsDispatch = type.Type != "VK_DEFINE_NON_DISPATCHABLE_HANDLE",
                    Commands = commands
                });
            }
        }

        private MethodDefinition GenerateCommand(CommandDeclaration command)
        {
            var newMethod = new MethodDefinition
            {
                Name = command.Name,
                ReturnType = "void",
                IsPublic = true,
                IsUnsafe = true,
                AllocatesUnmanagedMemory = true
            };

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
            var marshalToActions = new List<MethodAction>();

            var marshalledValues = new List<Action<ExpressionBuilder>>();

            foreach (var parameter in command.Params)
            {
                var newParam = this.GenerateParameter(command, newMethod, parameter, parameterIndex, enumeratePattern, lastParamReturns, marshalFromActions, marshalToActions, marshalledValues);

                if (newParam != null)
                {
                    newMethod.ParamActions.Add(newParam);
                }

                parameterIndex++;
            }

            newMethod.MemberActions.AddRange(marshalToActions);

            newMethod.MemberActions.Add(new InvokeAction
            {
                TypeName = "Interop.Commands",
                MethodName = command.VkName,
                Parameters = marshalledValues.ToArray()
            });

            newMethod.MemberActions.AddRange(marshalFromActions);

            return newMethod;
        }

        private ParamActionDefinition GenerateParameter(CommandDeclaration command, MethodDefinition newMethod, ParamDeclaration parameter, int parameterIndex, bool enumeratePattern, bool lastParamReturns, List<MethodAction> marshalFromActions, List<MethodAction> marshalToActions, List<Action<ExpressionBuilder>> marshalledValues)
        {
            string paramName = parameter.Name;
            var paramType = typeData[parameter.Type.VkName];

            string GetMarshalledName(string baseName)
            {
                return "marshalled" + baseName.TrimStart('@').FirstToUpper();
            }

            ParamActionDefinition result = null;

            if (parameterIndex >= command.HandleParamsCount)
            {
                if (lastParamReturns && parameterIndex == command.Params.Count() - 2 && enumeratePattern)
                {
                    //result.ArgumentName = "&" + paramName;

                    newMethod.MemberActions.Add(new DeclarationAction
                    {
                        MemberType = paramType.Name,
                        MemberName = paramName
                    });

                    marshalledValues.Add(AddressOf(Variable(paramName)));
                }
                else if (lastParamReturns && parameterIndex == command.Params.Count() - 1)
                {
                    var patternInfo = new MemberPatternInfo();

                    var effectiveParam = new ParamDeclaration
                    {
                        Name = parameter.Name,
                        Type = parameter.Type.Deref(),
                        Dimensions = parameter.Dimensions,
                        VkName = parameter.VkName
                    };

                    this.memberPatternRules.ApplyFirst(command.Params, effectiveParam, patternInfo);

                    string marshalledName = GetMarshalledName(patternInfo.Interop.Name);

                    marshalToActions.Add(new DeclarationAction
                    {
                        MemberType = patternInfo.InteropFullType,//.Substring(0, patternInfo.InteropFullType.Length - 1),
                        MemberName = marshalledName
                    });

                    marshalFromActions.AddRange(patternInfo.MarshalFrom.Select(action => action(targetName => Variable("result"), valueName => Variable(GetMarshalledName(valueName)))));

                    marshalledValues.Add(AddressOf(Variable(marshalledName)));

                    newMethod.ReturnType = patternInfo.Public.Value.Type;
                }
                else
                {
                    var patternInfo = new MemberPatternInfo();

                    this.memberPatternRules.ApplyFirst(command.Params, parameter, patternInfo);

                    var actionList = marshalToActions;

                    Func<string, Action<ExpressionBuilder>> getValue = valueName => Variable(valueName);

                    bool isOptional = parameter.IsOptional && paramType.Pattern == TypePattern.MarshalledStruct;

                    if (isOptional)
                    {
                        var optionalBlock = new OptionalAction
                        {
                            NullCheckExpression = IsNotEqual(Variable(paramName), Null)
                        };

                        marshalToActions.Add(optionalBlock);

                        actionList = optionalBlock.Actions;

                        getValue = valueName => Member(Variable(valueName), "Value");
                    }

                    if (patternInfo.MarshalTo.Any())
                    {
                        string marshalledName = GetMarshalledName(patternInfo.Interop.Name);

                        marshalToActions.Add(new DeclarationAction
                        {
                            MemberType = patternInfo.InteropFullType,
                            MemberName = marshalledName
                        });

                        marshalledValues.Add(Variable(marshalledName));

                        actionList.AddRange(patternInfo.MarshalTo.Select(action => action(targetName => Variable(GetMarshalledName(targetName)), getValue)));
                    }

                    if (patternInfo.Public.HasValue)
                    {
                        result = new ParamActionDefinition
                        {
                            Param = new ParamDefinition
                            {
                                Name = patternInfo.Public.Value.Name,
                                Type = patternInfo.Public.Value.Type + (isOptional ? "?" : "")
                            }
                        };
                    }
                }
            }
            else if (parameter.Type.VkName == command.HandleTypeName)
            {
                marshalledValues.Add(Member(This, "handle"));
            }
            else
            {
                marshalledValues.Add(Default("Interop." + paramType.Name));
            }

            return result;
        }
    }
}
