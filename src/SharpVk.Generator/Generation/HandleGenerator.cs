using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Generation.Marshalling;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Rules;
using System.Collections.Generic;
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
                IsUnsafe = true
            };

            var lastParam = command.Params.Last();

            bool lastParamIsArray = lastParam.Type.PointerType == PointerType.Pointer
                                        && lastParam.Dimensions != null
                                        && lastParam.Dimensions.Any(x => x.Type != LenType.NullTerminated);

            bool lastParamLenFieldByRef = lastParamIsArray
                                            && lastParam.Dimensions[0].Value is LenExpressionToken
                                            && command.Params.Single(x => x.VkName == ((LenExpressionToken)lastParam.Dimensions[0].Value).Value).Type.PointerType == PointerType.Pointer;

            bool lastParamReturns = lastParam.Type.PointerType == PointerType.Pointer
                                        && (typeData[lastParam.Type.VkName].IsOutputOnly
                                            || typeData[lastParam.Type.VkName].Pattern != TypePattern.MarshalledStruct
                                            || typeData[lastParam.Type.VkName].Pattern != TypePattern.NonMarshalledStruct
                                            || lastParamLenFieldByRef
                                            || command.Verb == "get")
                                        && (command.ReturnType == "VkResult" || command.ReturnType == "void");

            bool enumeratePattern = command.Verb == "enumerate" || (lastParamIsArray && lastParamLenFieldByRef);

            int parameterIndex = 0;

            newMethod.ParamActions = new List<ParamActionDefinition>();
            newMethod.MemberActions = new List<Action>();

            var marshalFromActions = new List<Action>();
            var marshalToActions = new List<Action>();

            foreach (var parameter in command.Params)
            {
                var newParam = this.GenerateParameter(command, newMethod, parameter, parameterIndex, enumeratePattern, lastParamReturns, marshalFromActions, marshalToActions);

                if (newParam != null)
                {
                    newMethod.ParamActions.Add(newParam);
                }

                parameterIndex++;
            }
            
            newMethod.MemberActions.AddRange(marshalToActions);

            return newMethod;
        }

        private ParamActionDefinition GenerateParameter(CommandDeclaration command, MethodDefinition newMethod, ParamDeclaration parameter, int parameterIndex, bool enumeratePattern, bool lastParamReturns, List<Action> marshalFromActions, List<Action> marshalToActions)
        {
            string paramName = parameter.Name;
            var paramType = typeData[parameter.Type.VkName];

            string marshalledName = "marshalled" + paramName.FirstToUpper();

            ParamActionDefinition result = null;

            if (parameterIndex >= command.HandleParamsCount)
            {
                if (lastParamReturns && parameterIndex == command.Params.Count() - 2 && enumeratePattern)
                {
                    //result.ArgumentName = "&" + paramName;

                    newMethod.MemberActions.Add(new AssignAction
                    {
                        MemberType = paramType.Name,
                        Type = AssignActionType.Declaration,
                        MemberName = paramName
                    });
                }
                else if (lastParamReturns && parameterIndex == command.Params.Count() - 1)
                {
                //    if (enumeratePattern)
                //    {
                //        bool requiresMarshalling = paramType.RequiresInterop || paramType.Pattern == TypePattern.Handle;

                //        string paramTypeName = paramType.Name == "void"
                //                                ? "byte"
                //                                : paramType.Name;

                //        newMethod.Parameters.Add(new TypeSet.VkMethodParam
                //        {
                //            PreInvokeArgumentName = "null",
                //            ArgumentName = marshalledName,
                //            TypeName = paramTypeName
                //        });

                //        newMethod.ReturnTypeName = paramTypeName + "[]";
                //        newMethod.IsDoubleInvoke = true;

                //        string interopTypeName = requiresMarshalling
                //                                    ? "Interop." + paramTypeName
                //                                    : paramTypeName;

                //        newMethod.MarshalToStatements.Add(string.Format("{0}* {1} = null;", interopTypeName, marshalledName));

                //        if (parameter.Dimensions[0].Value != null)
                //        {
                //            string lenExpression = parsedExpressionBuilder.Build(parameter.Dimensions[0].Value);

                //            string allocateType = paramType.Data.Category == TypeCategory.@enum || paramType.Data.Category == TypeCategory.bitmask
                //                                    ? "int"
                //                                    : interopTypeName;

                //            newMethod.MarshalMidStatements.Add($"{marshalledName} = ({interopTypeName}*)Interop.HeapUtil.Allocate<{allocateType}>((uint){lenExpression});");

                //            newMethod.MarshalFromStatements.Add(string.Format("result = new {0}[(uint){1}];", paramTypeName, lenExpression));

                //            newMethod.MarshalFromStatements.Add(string.Format("for(int index = 0; index < (uint){0}; index++)", lenExpression));
                //            newMethod.MarshalFromStatements.Add("{");
                //            if (paramType.RequiresInterop)
                //            {
                //                newMethod.MarshalFromStatements.Add($"\tresult[index] = {paramTypeName}.MarshalFrom(&{marshalledName}[index]);");
                //            }
                //            else if (paramType.Data.Category == TypeCategory.handle)
                //            {
                //                string parentArgument = "";

                //                if (paramType.Data.Parent != null)
                //                {
                //                    if (handleLookup[paramType.Data.Parent].Name == handle.AssociatedHandle)
                //                    {
                //                        parentArgument = ", this.associated";
                //                    }
                //                    else
                //                    {
                //                        parentArgument = ", this";
                //                    }
                //                }
                //                else
                //                {
                //                    parentArgument = ", this.Allocator";
                //                }

                //                newMethod.MarshalFromStatements.Add($"\tresult[index] = new {paramTypeName}({marshalledName}[index]{parentArgument}, this.commandCache);");
                //            }
                //            else
                //            {
                //                newMethod.MarshalFromStatements.Add(string.Format("\tresult[index] = {0}[index];", marshalledName));
                //            }
                //            newMethod.MarshalFromStatements.Add("}");
                //        }
                //    }
                //    else
                //    {
                //        string argumentName;

                //        newMethod.ReturnTypeName = paramType.Name;

                //        if (paramType.Data.Category == TypeCategory.handle)
                //        {
                //            string parentArgument = "";
                //            string commandCacheArgument = ", this.commandCache";

                //            if (handleLookup[paramType.Data.VkName].IsProcLookup)
                //            {
                //                commandCacheArgument = "";
                //            }

                //            if (paramType.Data.Parent != null)
                //            {
                //                var parentHandle = handleLookup[paramType.Data.Parent];

                //                if (handle == parentHandle)
                //                {
                //                    parentArgument = ", this";
                //                }
                //                else if (handle.ParentHandle == parentHandle.Name)
                //                {
                //                    parentArgument = ", this.parent";
                //                }
                //                else
                //                {
                //                    // If the containing handle (or its parent) is not the parent of the handle
                //                    // being returned, assume that the first param after all handles is a
                //                    // CreateInfo containing a field with the parent handle to assign.
                //                    // Also include a reference to the containing handle, as it will be the
                //                    // associated handle for this instance.

                //                    var createInfoParam = command.Params.Skip(handleParams.Count()).FirstOrDefault(x => typeData[x.Type].Name.EndsWith(CapitaliseFirst(command.Verb) + "Info"));

                //                    if (createInfoParam != null)
                //                    {
                //                        var createInfoType = typeData[GetMemberTypeName(createInfoParam)];

                //                        var parentHandleMember = createInfoType.Data.Members.First(x => x.Type == paramType.Data.Parent);

                //                        string createInfoParamName = paramNameLookup[createInfoParam.VkName];

                //                        if (createInfoParam.Dimensions != null && createInfoParam.Dimensions.Length > 0)
                //                        {
                //                            createInfoParamName += "[index]";
                //                        }

                //                        parentArgument = $", {createInfoParamName}.{GetNameForElement(parentHandleMember)}";

                //                        if (handleLookup[paramType.Data.VkName].AssociatedHandle != null)
                //                        {
                //                            parentArgument += ", this";
                //                        }
                //                    }
                //                    else
                //                    {
                //                        throw new NotImplementedException();
                //                    }
                //                }
                //            }
                //            else
                //            {
                //                if (handleType.Data.Parent != null)
                //                {
                //                    parentArgument = ", this.parent.Allocator";
                //                }
                //                else
                //                {
                //                    parentArgument = ", allocator";
                //                }
                //            }

                //            if (parameter.Dimensions != null)
                //            {
                //                argumentName = marshalledName;

                //                newMethod.ReturnTypeName = paramType.Name + "[]";

                //                string lenExpression = parsedExpressionBuilder.Build(parameter.Dimensions[0].Value);

                //                string allocateType = paramType.Data.Category == TypeCategory.@enum || paramType.Data.Category == TypeCategory.bitmask
                //                                        ? "int"
                //                                        : "Interop." + paramType.Name;

                //                newMethod.MarshalToStatements.Add($"Interop.{paramType.Name}* {marshalledName} = (Interop.{paramType.Name}*)Interop.HeapUtil.Allocate<{allocateType}>({lenExpression});");

                //                newMethod.MarshalFromStatements.Add(string.Format("result = new {0}[(uint){1}];", paramType.Name, lenExpression));

                //                newMethod.MarshalFromStatements.Add(string.Format("for(int index = 0; index < (uint){0}; index++)", lenExpression));
                //                newMethod.MarshalFromStatements.Add("{");
                //                newMethod.MarshalFromStatements.Add($"\tresult[index] = new {paramType.Name}({marshalledName}[index]{parentArgument}{commandCacheArgument});");
                //                newMethod.MarshalFromStatements.Add("}");
                //            }
                //            else
                //            {
                //                argumentName = "&" + marshalledName;

                //                newMethod.MarshalToStatements.Add(string.Format("Interop.{0} {1};", paramType.Name, marshalledName));
                //                newMethod.MarshalFromStatements.Add($"result = new {paramType.Name}({marshalledName}{parentArgument}{commandCacheArgument});");
                //            }
                //        }
                //        else if (paramType.RequiresInterop)
                //        {
                //            argumentName = "&" + marshalledName;
                //            newMethod.MarshalToStatements.Add(string.Format("Interop.{0} {1};", paramType.Name, marshalledName));
                //            newMethod.MarshalFromStatements.Add(string.Format("result = {0}.MarshalFrom(&{1});", paramType.Name, marshalledName));
                //        }
                //        else
                //        {
                //            argumentName = "&result";
                //        }

                //        result = new ParamActionDefinition
                //        {
                //            Param = new ParamDefinition
                //            {
                //                ArgumentName = argumentName,
                //                TypeName = paramType.Name
                //            }
                //        };
                //    }
                }
                //else if (lenParamMapping.ContainsKey(parameter.VkName))
                //{
                //    var mapping = lenParamMapping[parameter.VkName];

                //    newMethod.Parameters.Add(new TypeSet.VkMethodParam
                //    {
                //        ArgumentName = $"({paramType.Name})({mapping}.Length)"
                //    });
                //}
                //else if (parameter.Dimensions?.Length > 0)
                //{
                //    if (parameter.Dimensions[0].Type == SpecParser.LenType.NullTerminated)
                //    {
                //        newMethod.MarshalToStatements.Add($"char* {marshalledName} = Interop.HeapUtil.MarshalTo({paramName});");

                //        newMethod.Parameters.Add(new TypeSet.VkMethodParam
                //        {
                //            Name = paramName,
                //            ArgumentName = marshalledName,
                //            TypeName = "string"
                //        });
                //    }
                //    else
                //    {
                //        string fixedName = null;
                //        string fixedType = null;
                //        string paramTypeName = (paramType.Name == "void" ? "byte" : paramType.Name);
                //        string handleName = paramName + "Handle";
                //        bool requiresInterop = paramType.RequiresInterop || paramType.Data.Category == TypeCategory.handle;
                //        string interopTypeName = paramTypeName;
                //        string argumentName = marshalledName;
                //        bool isDoubleMarshalled = parameter.PointerType == PointerType.DoubleConstPointer;
                //        string doubleMarshalledName = "double" + CapitaliseFirst(marshalledName);

                //        if (requiresInterop)
                //        {
                //            interopTypeName = "Interop." + interopTypeName;
                //        }
                //        else
                //        {
                //            newMethod.MarshalToStatements.Add($"GCHandle {handleName} = default(GCHandle);");
                //        }

                //        newMethod.MarshalToStatements.Add($"{interopTypeName}* {marshalledName} = null;");
                //        if (isDoubleMarshalled)
                //        {
                //            newMethod.MarshalToStatements.Add($"{interopTypeName}** {doubleMarshalledName} = null;");
                //            argumentName = doubleMarshalledName;
                //        }
                //        newMethod.MarshalToStatements.Add($"if ({paramName}.Contents != ProxyContents.Null)");
                //        newMethod.MarshalToStatements.Add("{");
                //        if (requiresInterop)
                //        {
                //            newMethod.MarshalToStatements.Add($"    {interopTypeName}* arrayPointer = stackalloc {interopTypeName}[{paramName}.Length];");
                //            newMethod.MarshalToStatements.Add($"    if({paramName}.Contents == ProxyContents.Single)");
                //            newMethod.MarshalToStatements.Add("    {");
                //            newMethod.MarshalToStatements.Add($"        {paramName}.GetSingleValue().MarshalTo(arrayPointer);");
                //            newMethod.MarshalToStatements.Add("    }");
                //            newMethod.MarshalToStatements.Add("    else");
                //            newMethod.MarshalToStatements.Add("    {");
                //            newMethod.MarshalToStatements.Add($"        var arrayValue  = {paramName}.GetArrayValue();");
                //            newMethod.MarshalToStatements.Add($"        for (int index = 0; index < {paramName}.Length; index++)");
                //            newMethod.MarshalToStatements.Add("        {");
                //            newMethod.MarshalToStatements.Add($"            arrayValue.Array[arrayValue.Offset + index].MarshalTo(&arrayPointer[index]);");
                //            newMethod.MarshalToStatements.Add("        }");
                //            newMethod.MarshalToStatements.Add("    }");
                //            newMethod.MarshalToStatements.Add($"    {marshalledName} = arrayPointer;");
                //            newMethod.MarshalToStatements.Add("}");
                //        }
                //        else
                //        {
                //            newMethod.MarshalToStatements.Add($"    if({paramName}.Contents == ProxyContents.Single)");
                //            newMethod.MarshalToStatements.Add("    {");
                //            newMethod.MarshalToStatements.Add($"        {interopTypeName}* dataPointer = stackalloc {interopTypeName}[1];");
                //            newMethod.MarshalToStatements.Add($"        *dataPointer = {paramName}.GetSingleValue();");
                //            newMethod.MarshalToStatements.Add($"        {marshalledName} = dataPointer;");
                //            if (isDoubleMarshalled)
                //            {
                //                newMethod.MarshalToStatements.Add($"        {doubleMarshalledName} = &{marshalledName};");
                //            }
                //            newMethod.MarshalToStatements.Add("    }");
                //            newMethod.MarshalToStatements.Add("    else");
                //            newMethod.MarshalToStatements.Add("    {");
                //            newMethod.MarshalToStatements.Add($"        var arrayValue = {paramName}.GetArrayValue();");
                //            newMethod.MarshalToStatements.Add($"        {handleName} = GCHandle.Alloc(arrayValue.Array);");
                //            newMethod.MarshalToStatements.Add($"        {marshalledName} = ({interopTypeName}*)({handleName}.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<{interopTypeName}>() * arrayValue.Offset)).ToPointer();");
                //            if (isDoubleMarshalled)
                //            {
                //                newMethod.MarshalToStatements.Add($"        {interopTypeName}** dataPointer = stackalloc {interopTypeName}*[{paramName}.Length];");
                //                newMethod.MarshalToStatements.Add($"        {doubleMarshalledName} = dataPointer;");
                //                newMethod.MarshalToStatements.Add($"        for (int marshalIndex = 0; marshalIndex < {paramName}.Length; marshalIndex++)");
                //                newMethod.MarshalToStatements.Add("        {");
                //                newMethod.MarshalToStatements.Add($"            {doubleMarshalledName}[marshalIndex] = &{marshalledName}[marshalIndex];");
                //                newMethod.MarshalToStatements.Add("        }");
                //            }
                //            newMethod.MarshalToStatements.Add("    }");
                //            newMethod.MarshalToStatements.Add("}");
                //        }
                //        newMethod.MarshalToStatements.Add($"else");
                //        newMethod.MarshalToStatements.Add("{");
                //        newMethod.MarshalToStatements.Add($"    {marshalledName} = null;");
                //        newMethod.MarshalToStatements.Add("}");

                //        if (!requiresInterop)
                //        {
                //            newMethod.MarshalFromStatements.Add($"if ({handleName}.IsAllocated) {handleName}.Free();");
                //        }

                //        newMethod.Parameters.Add(new TypeSet.VkMethodParam
                //        {
                //            Name = paramName,
                //            ArgumentName = argumentName,
                //            TypeName = $"ArrayProxy<{paramTypeName}>",
                //            FixedName = fixedName,
                //            FixedType = fixedType
                //        });
                //    }
                //}
                //else if (paramType.Pattern == TypePattern.Handle)
                //{
                //    string argumentName = paramType.RequiresInterop
                //                            ? $"&{marshalledName}"
                //                            : marshalledName;

                //    newMethod.Parameters.Add(new TypeSet.VkMethodParam
                //    {
                //        Name = paramName,
                //        ArgumentName = marshalledName,
                //        TypeName = paramType.Name
                //    });

                //    newMethod.MarshalToStatements.Add($"Interop.{paramType.Name} {marshalledName} = default(Interop.{paramType.Name});");
                //    newMethod.MarshalToStatements.Add($"{paramName}?.MarshalTo(&{marshalledName});");
                //}
                //else if (paramType.RequiresInterop)
                //{
                //    string publicParamName = paramName;
                //    string paramSource = paramName;

                //    bool isAllocator = false;

                //    if (paramName == "allocator" && handleParams.Count() > 0)
                //    {
                //        isAllocator = true;
                //        publicParamName = null;
                //        if (handle.ParentHandle != null)
                //        {
                //            paramSource = "this.parent.Allocator";
                //        }
                //        else
                //        {
                //            paramSource = "this.allocator";
                //        }
                //    }

                //    newMethod.MarshalToStatements.Add(string.Format("Interop.{0} {1};", paramType.Name, marshalledName));
                //    string paramTypeName = paramType.Name;
                //    string argumentName = "&" + marshalledName;

                //    if (isAllocator || parameter.IsOptional)
                //    {
                //        newMethod.MarshalToStatements.Add(string.Format("{1}?.MarshalTo(&{0});", marshalledName, paramSource));

                //        paramTypeName += "?";

                //        if (publicParamName != null)
                //        {
                //            publicParamName += " = null";
                //        }

                //        argumentName = $"{paramSource} == null ? null : " + argumentName;
                //    }
                //    else
                //    {
                //        newMethod.MarshalToStatements.Add(string.Format("{1}.MarshalTo(&{0});", marshalledName, paramSource));
                //    }

                //    newMethod.Parameters.Add(new TypeSet.VkMethodParam
                //    {
                //        Name = publicParamName,
                //        ArgumentName = argumentName,
                //        TypeName = paramTypeName
                //    });
                //}
                //else if (parameter.Type.VkName == "void" && parameter.Type.PointerType == PointerType.DoublePointer)
                //{
                //    newMethod.Parameters.Add(new TypeSet.VkMethodParam
                //    {
                //        Name = paramName,
                //        ArgumentName = "&" + marshalledName,
                //        TypeName = "ref IntPtr"
                //    });

                //    newMethod.MarshalToStatements.Add($"void* {marshalledName};");
                //    newMethod.MarshalFromStatements.Add($"{paramName} = new IntPtr({marshalledName});");
                //}
                //else if (parameter.PointerType.IsPointer())
                //{
                //    newMethod.Parameters.Add(new TypeSet.VkMethodParam
                //    {
                //        Name = paramName,
                //        ArgumentName = "&" + paramName,
                //        TypeName = paramType.Name
                //    });
                //}
                else
                {
                    var patternInfo = new MemberPatternInfo()
                    {
                        MarshalFrom = marshalFromActions
                    };

                    this.memberPatternRules.ApplyFirst(command.Params, parameter, patternInfo);

                    string GetMarshalledName(string baseName)
                    {
                        return "marshalled" + baseName.TrimStart('@').FirstToUpper();
                    }

                    if (patternInfo.MarshalTo.Any())
                    {
                        marshalToActions.Add(new AssignAction
                        {
                            Type = AssignActionType.Declaration,
                            MemberType = patternInfo.InteropFullType,
                            MemberName = GetMarshalledName(patternInfo.Interop.Name)
                        });

                        marshalToActions.AddRange(patternInfo.MarshalTo.Select(action => action(targetName => Variable(GetMarshalledName(targetName)), valueName => Variable(valueName))));
                    }

                    if (patternInfo.Public.HasValue)
                    {
                        result = new ParamActionDefinition
                        {
                            Param = new ParamDefinition
                            {
                                Name = patternInfo.Public.Value.Name,
                                //ArgumentName = paramName,
                                Type = patternInfo.Public.Value.Type
                            }
                        };
                    }
                }
            }

            return result;
        }
    }
}
