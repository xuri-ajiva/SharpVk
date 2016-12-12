using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SharpVk.VkXml
{
    public class TypeGenerator
    {
        private static readonly Dictionary<string, string> primitiveTypes = new Dictionary<string, string>()
        {
            {"void", "void"},
            {"char", "char"},
            {"float", "float"},
            {"uint8_t", "byte"},
            {"uint32_t", "uint"},
            {"DWORD", "uint"},
            {"uint64_t", "ulong"},
            {"int32_t", "int"},
            {"size_t", "Size"},
            {"HINSTANCE", "IntPtr" },
            {"HWND", "IntPtr" },
            {"HANDLE", "IntPtr" },
            {"SECURITY_ATTRIBUTES", "SECURITY_ATTRIBUTES" },
            {"ANativeWindow", "IntPtr" },
            {"Display", "IntPtr" },
            {"VisualID", "IntPtr" },
            {"Window", "IntPtr" },
            {"MirConnection", "IntPtr" },
            {"MirSurface", "IntPtr" },
            {"wl_display", "IntPtr" },
            {"wl_surface", "IntPtr" },
            {"xcb_connection_t", "IntPtr" },
            {"xcb_visualid_t", "IntPtr" },
            {"xcb_window_t", "IntPtr" }
        };

        private static readonly string[] keywords = new[]
        {
            "object",
            "event"
        };

        private static readonly string[] digitsSuffix = new[] { "flags", "flag", "type", "bits", "bit" };

        public TypeSet Generate(SpecParser.ParsedSpec spec)
        {
            var typeData = GetTypeData(spec);

            var result = new TypeSet();

            SetPrimitiveTypeNames(typeData);

            GenerateConstants(spec, result);

            GenerateExceptions(spec, result);

            var enumLookup = GenerateEnumerations(spec, typeData, result);

            GenerateDelegates(spec, typeData, result);

            GenerateUnions(typeData, result);

            GenerateNonInteropStructs(typeData, result);

            var classLookup = GenerateClasses(spec, typeData, result, enumLookup);

            var handleLookup = GenerateHandles(spec, typeData, result);

            GenerateCommands(spec, typeData, handleLookup, classLookup, result);

            return result;
        }

        private void GenerateDelegates(SpecParser.ParsedSpec spec, Dictionary<string, TypeDesc> typeData, TypeSet result)
        {
            foreach (var delegateType in typeData.Values.Where(x => x.Data.Category == TypeCategory.funcpointer))
            {
                string returnType = typeData[delegateType.Data.Type].Name;

                if (delegateType.Data.IsTypePointer)
                {
                    returnType = "IntPtr";
                }

                var newDelegate = new TypeSet.VkCommand
                {
                    Name = delegateType.Name,
                    Comment = delegateType.Data.Comment ?? new List<string> { "-" },
                    ReturnTypeName = returnType
                };

                foreach (var member in delegateType.Data.Members)
                {
                    var nameParts = member.NameParts.AsEnumerable();

                    if (member.PointerType.IsPointer() && nameParts.First() == "p")
                    {
                        nameParts = nameParts.Skip(1);
                    }

                    string paramName = JoinNameParts(nameParts, true);

                    if (keywords.Contains(paramName))
                    {
                        paramName = "@" + paramName;
                    }

                    var paramType = typeData[member.Type];

                    string paramTypeName = paramType.Name;

                    if (member.PointerType.IsPointer())
                    {
                        switch (paramTypeName)
                        {
                            case "void":
                                paramTypeName = "IntPtr";
                                break;
                            case "char":
                                paramTypeName = "string";
                                break;
                        }
                    }

                    newDelegate.Parameters.Add(new TypeSet.VkCommandParameter
                    {
                        Name = paramName,
                        TypeName = paramTypeName
                    });
                }

                result.Delegates.Add(newDelegate);
            }
        }

        private static void GenerateCommands(SpecParser.ParsedSpec spec, Dictionary<string, TypeDesc> typeData, Dictionary<string, TypeSet.VkHandle> handleLookup, Dictionary<string, TypeSet.VkClass> classLookup, TypeSet result)
        {
            foreach (var command in spec.Commands.Values)
            {
                string commandName = command.VkName;

                var newCommand = new TypeSet.VkCommand
                {
                    Name = commandName,
                    Comment = new List<string> { "-" },
                    ReturnTypeName = typeData[command.Type].Name
                };

                var handleParams = command.Params.TakeWhile((x, index) =>
                {
                    var paramTypeData = typeData[x.Type].Data;

                    if (paramTypeData.Category != TypeCategory.handle)
                    {
                        return false;
                    }
                    else
                    {
                        if (index == 0)
                        {
                            return true;
                        }
                        else
                        {
                            var paramHandle = handleLookup[x.Type];
                            var previousParamHandle = handleLookup[command.Params[index - 1].Type];

                            //HACK Ignore the IsOptional check for Destroy methods until
                            // command duplication (across parent & optional child handle)
                            // is working
                            return (!x.IsOptional || command.Verb == "destroy")
                                    && (previousParamHandle.Name == paramHandle.ParentHandle
                                        || previousParamHandle.Name == paramHandle.AssociatedHandle);
                        }
                    }
                });

                var handleTypeName = handleParams.Any()
                                        ? handleParams.Last().Type
                                        : handleLookup.ContainsKey(command.Params.Last().Type)
                                            ? command.Params.Last().Type
                                            : "VkInstance";

                var handleType = typeData[handleTypeName];

                var handle = handleLookup[handleTypeName];

                var lastParam = command.Params.Last();

                bool lastParamIsArray = lastParam.PointerType == PointerType.Pointer
                                            && lastParam.Dimensions != null
                                            && lastParam.Dimensions.Any(x => x.Type != SpecParser.LenType.NullTerminated);

                bool lastParamLenFieldByRef = lastParamIsArray
                                                && lastParam.Dimensions[0].Value is SpecParser.ParsedExpressionToken
                                                && command.Params.Single(x => x.VkName == ((SpecParser.ParsedExpressionToken)lastParam.Dimensions[0].Value).Value).PointerType == PointerType.Pointer;

                bool lastParamReturns = lastParam.PointerType == PointerType.Pointer
                                            && (typeData[lastParam.Type].Data.IsReturnedOnly
                                                || typeData[lastParam.Type].Data.Category != TypeCategory.@struct
                                                || lastParamLenFieldByRef
                                                || command.Verb == "get")
                                            && (command.Type == "VkResult" || command.Type == "void");

                if (lastParamReturns && classLookup.ContainsKey(lastParam.Type))
                {
                    classLookup[lastParam.Type].IsOutput = true;
                }

                bool enumeratePattern = command.Verb == "enumerate" || (lastParamIsArray && lastParamLenFieldByRef);

                var methodNameParts = command.NameParts;

                int verbPrefixLength = 1;

                if (methodNameParts.First() != command.Verb)
                {
                    verbPrefixLength = 0;
                }

                if (handleType.Data.NameParts
                            .Zip(methodNameParts.Skip(verbPrefixLength), Tuple.Create)
                            .All(x => x.Item1 == x.Item2))
                {
                    methodNameParts = methodNameParts.Take(verbPrefixLength).Concat(methodNameParts.Skip(handleType.Data.NameParts.Count() + verbPrefixLength)).ToArray();
                }
                else if (handleTypeName == "VkCommandBuffer" && methodNameParts.First() == "cmd")
                {
                    methodNameParts = methodNameParts.Skip(1).ToArray();
                }

                var newMethod = new TypeSet.VkHandleMethod
                {
                    Name = JoinNameParts(methodNameParts),
                    Comment = command.Comment ?? new List<string> { "-" },
                    ReturnTypeName = "void",
                    CommandName = commandName,
                    CacheLookupName = string.IsNullOrEmpty(command.ExtensionType) ? "" : command.VkName,
                    CacheLookupType = command.ExtensionType
                };

                if (!handleParams.Any())
                {
                    Debug.Assert(lastParamReturns);

                    newMethod.IsStatic = true;
                }
                else
                {
                    if (handleParams.Count() > 1)
                    {
                        if (handleLookup[handleParams.First().Type].Name == handle.AssociatedHandle)
                        {
                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                ArgumentName = "this.associated.handle"
                            });
                        }
                        else
                        {
                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                ArgumentName = "this.parent.handle"
                            });
                        }
                    }

                    newMethod.Parameters.Add(new TypeSet.VkMethodParam
                    {
                        ArgumentName = "this.handle"
                    });
                }

                int parameterIndex = 0;

                var paramNameLookup = command.Params.ToDictionary(x => x.VkName, x =>
                {
                    if (x.NameParts != null)
                    {
                        var nameParts = x.NameParts.AsEnumerable();
                        int pointerCount = x.PointerType.GetPointerCount();

                        if (pointerCount > 0 && nameParts.First() == new string('p', pointerCount))
                        {
                            nameParts = nameParts.Skip(1);
                        }
                        return JoinNameParts(nameParts, true);
                    }
                    else
                    {
                        return x.VkName;
                    }
                });

                var lenParamMapping = new Dictionary<string, string>();

                foreach (var parameter in command.Params)
                {
                    if (parameter.Dimensions?.Count() > 0
                            && parameter.Dimensions[0].Type == SpecParser.LenType.Expression
                            && parameter.Dimensions[0].Value is SpecParser.ParsedExpressionToken)
                    {
                        string lenParam = ((SpecParser.ParsedExpressionToken)parameter.Dimensions[0].Value).Value;

                        if (!lenParamMapping.ContainsKey(lenParam) || parameter.PointerType != PointerType.Pointer)
                        {
                            lenParamMapping[lenParam] = paramNameLookup[parameter.VkName];
                        }
                    }
                }

                var parsedExpressionBuilder = new ParsedExpressionBuilder(paramNameLookup, command.Params, lenParamMapping, typeData);

                foreach (var parameter in command.Params)
                {

                    string paramName = paramNameLookup[parameter.VkName];
                    var paramType = typeData[GetMemberTypeName(parameter)];

                    string marshalledName = "marshalled" + CapitaliseFirst(paramName);

                    if (keywords.Contains(paramName))
                    {
                        paramName = "@" + paramName;
                    }

                    newCommand.Parameters.Add(new TypeSet.VkCommandParameter
                    {
                        Name = paramName,
                        TypeName = ApplyPointerType(parameter, paramType)
                    });

                    if (parameterIndex >= handleParams.Count())
                    {
                        if (lastParamReturns && parameterIndex == command.Params.Count() - 2 && enumeratePattern)
                        {
                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                ArgumentName = "&" + paramName
                            });

                            newMethod.MarshalToStatements.Add(string.Format("{0} {1};", paramType.Name, paramName));
                        }
                        else if (lastParamReturns && parameterIndex == command.Params.Count() - 1)
                        {
                            if (enumeratePattern)
                            {
                                bool requiresMarshalling = paramType.RequiresInterop || paramType.Data.Category == TypeCategory.handle;

                                string paramTypeName = paramType.Name == "void"
                                                        ? "byte"
                                                        : paramType.Name;

                                newMethod.Parameters.Add(new TypeSet.VkMethodParam
                                {
                                    PreInvokeArgumentName = "null",
                                    ArgumentName = marshalledName,
                                    TypeName = paramTypeName
                                });

                                newMethod.ReturnTypeName = paramTypeName + "[]";
                                newMethod.IsDoubleInvoke = true;

                                string interopTypeName = requiresMarshalling
                                                            ? "Interop." + paramTypeName
                                                            : paramTypeName;

                                newMethod.MarshalToStatements.Add(string.Format("{0}* {1} = null;", interopTypeName, marshalledName));

                                if (parameter.Dimensions[0].Value != null)
                                {
                                    string lenExpression = parsedExpressionBuilder.Build(parameter.Dimensions[0].Value);

                                    string allocateType = paramType.Data.Category == TypeCategory.@enum || paramType.Data.Category == TypeCategory.bitmask
                                                            ? "int"
                                                            : interopTypeName;

                                    newMethod.MarshalMidStatements.Add($"{marshalledName} = ({interopTypeName}*)Interop.HeapUtil.Allocate<{allocateType}>((uint){lenExpression});");

                                    newMethod.MarshalFromStatements.Add(string.Format("result = new {0}[(uint){1}];", paramTypeName, lenExpression));

                                    newMethod.MarshalFromStatements.Add(string.Format("for(int index = 0; index < (uint){0}; index++)", lenExpression));
                                    newMethod.MarshalFromStatements.Add("{");
                                    if (paramType.RequiresInterop)
                                    {
                                        newMethod.MarshalFromStatements.Add($"\tresult[index] = {paramTypeName}.MarshalFrom(&{marshalledName}[index]);");
                                    }
                                    else if (paramType.Data.Category == TypeCategory.handle)
                                    {
                                        string parentArgument = "";

                                        if (paramType.Data.Parent != null)
                                        {
                                            if (handleLookup[paramType.Data.Parent].Name == handle.AssociatedHandle)
                                            {
                                                parentArgument = ", this.associated";
                                            }
                                            else
                                            {
                                                parentArgument = ", this";
                                            }
                                        }
                                        else
                                        {
                                            parentArgument = ", this.Allocator";
                                        }

                                        newMethod.MarshalFromStatements.Add($"\tresult[index] = new {paramTypeName}({marshalledName}[index]{parentArgument}, this.commandCache);");
                                    }
                                    else
                                    {
                                        newMethod.MarshalFromStatements.Add(string.Format("\tresult[index] = {0}[index];", marshalledName));
                                    }
                                    newMethod.MarshalFromStatements.Add("}");
                                }
                            }
                            else
                            {
                                string argumentName;

                                newMethod.ReturnTypeName = paramType.Name;

                                if (paramType.Data.Category == TypeCategory.handle)
                                {
                                    string parentArgument = "";
                                    string commandCacheArgument = ", this.commandCache";

                                    if (handleLookup[paramType.Data.VkName].IsProcLookup)
                                    {
                                        commandCacheArgument = "";
                                    }

                                    if (paramType.Data.Parent != null)
                                    {
                                        var parentHandle = handleLookup[paramType.Data.Parent];

                                        if (handle == parentHandle)
                                        {
                                            parentArgument = ", this";
                                        }
                                        else if (handle.ParentHandle == parentHandle.Name)
                                        {
                                            parentArgument = ", this.parent";
                                        }
                                        else
                                        {
                                            // If the containing handle (or its parent) is not the parent of the handle
                                            // being returned, assume that the first param after all handles is a
                                            // CreateInfo containing a field with the parent handle to assign.
                                            // Also include a reference to the containing handle, as it will be the
                                            // associated handle for this instance.

                                            var createInfoParam = command.Params.Skip(handleParams.Count()).FirstOrDefault(x => typeData[x.Type].Name.EndsWith(CapitaliseFirst(command.Verb) + "Info"));

                                            if (createInfoParam != null)
                                            {
                                                var createInfoType = typeData[GetMemberTypeName(createInfoParam)];

                                                var parentHandleMember = createInfoType.Data.Members.First(x => x.Type == paramType.Data.Parent);

                                                string createInfoParamName = paramNameLookup[createInfoParam.VkName];

                                                if (createInfoParam.Dimensions != null && createInfoParam.Dimensions.Length > 0)
                                                {
                                                    createInfoParamName += "[index]";
                                                }

                                                parentArgument = $", {createInfoParamName}.{GetNameForElement(parentHandleMember)}";

                                                if (handleLookup[paramType.Data.VkName].AssociatedHandle != null)
                                                {
                                                    parentArgument += ", this";
                                                }
                                            }
                                            else
                                            {
                                                throw new NotImplementedException();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        parentArgument = ", allocator";
                                    }

                                    if (parameter.Dimensions != null)
                                    {
                                        argumentName = marshalledName;

                                        newMethod.ReturnTypeName = paramType.Name + "[]";

                                        string lenExpression = parsedExpressionBuilder.Build(parameter.Dimensions[0].Value);

                                        string allocateType = paramType.Data.Category == TypeCategory.@enum || paramType.Data.Category == TypeCategory.bitmask
                                                                ? "int"
                                                                : "Interop." + paramType.Name;

                                        newMethod.MarshalToStatements.Add($"Interop.{paramType.Name}* {marshalledName} = (Interop.{paramType.Name}*)Interop.HeapUtil.Allocate<{allocateType}>({lenExpression});");

                                        newMethod.MarshalFromStatements.Add(string.Format("result = new {0}[(uint){1}];", paramType.Name, lenExpression));

                                        newMethod.MarshalFromStatements.Add(string.Format("for(int index = 0; index < (uint){0}; index++)", lenExpression));
                                        newMethod.MarshalFromStatements.Add("{");
                                        newMethod.MarshalFromStatements.Add($"\tresult[index] = new {paramType.Name}({marshalledName}[index]{parentArgument}{commandCacheArgument});");
                                        newMethod.MarshalFromStatements.Add("}");
                                    }
                                    else
                                    {
                                        argumentName = "&" + marshalledName;

                                        newMethod.MarshalToStatements.Add(string.Format("Interop.{0} {1};", paramType.Name, marshalledName));
                                        newMethod.MarshalFromStatements.Add($"result = new {paramType.Name}({marshalledName}{parentArgument}{commandCacheArgument});");
                                    }
                                }
                                else if (paramType.RequiresInterop)
                                {
                                    argumentName = "&" + marshalledName;
                                    newMethod.MarshalToStatements.Add(string.Format("Interop.{0} {1};", paramType.Name, marshalledName));
                                    newMethod.MarshalFromStatements.Add(string.Format("result = {0}.MarshalFrom(&{1});", paramType.Name, marshalledName));
                                }
                                else
                                {
                                    argumentName = "&result";
                                }

                                newMethod.Parameters.Add(new TypeSet.VkMethodParam
                                {
                                    ArgumentName = argumentName,
                                    TypeName = paramType.Name
                                });
                            }
                        }
                        else if (lenParamMapping.ContainsKey(parameter.VkName))
                        {
                            var mapping = lenParamMapping[parameter.VkName];

                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                ArgumentName = $"({paramType.Name})({mapping}.Length)"
                            });
                        }
                        else if (parameter.Dimensions?.Length > 0)
                        {
                            if (parameter.Dimensions[0].Type == SpecParser.LenType.NullTerminated)
                            {
                                newMethod.MarshalToStatements.Add($"char* {marshalledName} = Interop.HeapUtil.MarshalTo({paramName});");

                                newMethod.Parameters.Add(new TypeSet.VkMethodParam
                                {
                                    Name = paramName,
                                    ArgumentName = marshalledName,
                                    TypeName = "string"
                                });
                            }
                            else
                            {
                                string fixedName = null;
                                string fixedType = null;
                                string paramTypeName = (paramType.Name == "void" ? "byte" : paramType.Name);
                                string handleName = paramName + "Handle";
                                bool requiresInterop = paramType.RequiresInterop || paramType.Data.Category == TypeCategory.handle;
                                string interopTypeName = paramTypeName;
                                string argumentName = marshalledName;
                                bool isDoubleMarshalled = parameter.PointerType == PointerType.DoubleConstPointer;
                                string doubleMarshalledName = "double" + CapitaliseFirst(marshalledName);

                                if (requiresInterop)
                                {
                                    interopTypeName = "Interop." + interopTypeName;
                                }
                                else
                                {
                                    newMethod.MarshalToStatements.Add($"GCHandle {handleName} = default(GCHandle);");
                                }

                                newMethod.MarshalToStatements.Add($"{interopTypeName}* {marshalledName} = null;");
                                if (isDoubleMarshalled)
                                {
                                    newMethod.MarshalToStatements.Add($"{interopTypeName}** {doubleMarshalledName} = null;");
                                    argumentName = doubleMarshalledName;
                                }
                                newMethod.MarshalToStatements.Add($"if ({paramName}.Contents != ProxyContents.Null)");
                                newMethod.MarshalToStatements.Add("{");
                                if (requiresInterop)
                                {
                                    newMethod.MarshalToStatements.Add($"    {interopTypeName}* arrayPointer = stackalloc {interopTypeName}[{paramName}.Length];");
                                    newMethod.MarshalToStatements.Add($"    if({paramName}.Contents == ProxyContents.Single)");
                                    newMethod.MarshalToStatements.Add("    {");
                                    newMethod.MarshalToStatements.Add($"        *arrayPointer = {paramName}.GetSingleValue().Pack();");
                                    newMethod.MarshalToStatements.Add("    }");
                                    newMethod.MarshalToStatements.Add("    else");
                                    newMethod.MarshalToStatements.Add("    {");
                                    newMethod.MarshalToStatements.Add($"        var arrayValue  = {paramName}.GetArrayValue();");
                                    newMethod.MarshalToStatements.Add($"        for (int index = 0; index < {paramName}.Length; index++)");
                                    newMethod.MarshalToStatements.Add("        {");
                                    newMethod.MarshalToStatements.Add($"            arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();");
                                    newMethod.MarshalToStatements.Add("        }");
                                    newMethod.MarshalToStatements.Add("    }");
                                    newMethod.MarshalToStatements.Add($"    {marshalledName} = arrayPointer;");
                                    newMethod.MarshalToStatements.Add("}");
                                }
                                else
                                {
                                    newMethod.MarshalToStatements.Add($"    if({paramName}.Contents == ProxyContents.Single)");
                                    newMethod.MarshalToStatements.Add("    {");
                                    newMethod.MarshalToStatements.Add($"        {interopTypeName}* dataPointer = stackalloc {interopTypeName}[1];");
                                    newMethod.MarshalToStatements.Add($"        *dataPointer = {paramName}.GetSingleValue();");
                                    newMethod.MarshalToStatements.Add($"        {marshalledName} = dataPointer;");
                                    if (isDoubleMarshalled)
                                    {
                                        newMethod.MarshalToStatements.Add($"        {doubleMarshalledName} = &{marshalledName};");
                                    }
                                    newMethod.MarshalToStatements.Add("    }");
                                    newMethod.MarshalToStatements.Add("    else");
                                    newMethod.MarshalToStatements.Add("    {");
                                    newMethod.MarshalToStatements.Add($"        var arrayValue = {paramName}.GetArrayValue();");
                                    newMethod.MarshalToStatements.Add($"        {handleName} = GCHandle.Alloc(arrayValue.Array);");
                                    newMethod.MarshalToStatements.Add($"        {marshalledName} = ({interopTypeName}*)({handleName}.AddrOfPinnedObject() + (int)(MemUtil.SizeOf<{interopTypeName}>() * arrayValue.Offset)).ToPointer();");
                                    if (isDoubleMarshalled)
                                    {
                                        newMethod.MarshalToStatements.Add($"        {interopTypeName}** dataPointer = stackalloc {interopTypeName}*[{paramName}.Length];");
                                        newMethod.MarshalToStatements.Add($"        {doubleMarshalledName} = dataPointer;");
                                        newMethod.MarshalToStatements.Add($"        for (int marshalIndex = 0; marshalIndex < {paramName}.Length; marshalIndex++)");
                                        newMethod.MarshalToStatements.Add("        {");
                                        newMethod.MarshalToStatements.Add($"            {doubleMarshalledName}[marshalIndex] = &{marshalledName}[marshalIndex];");
                                        newMethod.MarshalToStatements.Add("        }");
                                    }
                                    newMethod.MarshalToStatements.Add("    }");
                                    newMethod.MarshalToStatements.Add("}");
                                }
                                newMethod.MarshalToStatements.Add($"else");
                                newMethod.MarshalToStatements.Add("{");
                                newMethod.MarshalToStatements.Add($"    {marshalledName} = null;");
                                newMethod.MarshalToStatements.Add("}");

                                if (!requiresInterop)
                                {
                                    newMethod.MarshalFromStatements.Add($"if ({handleName}.IsAllocated) {handleName}.Free();");
                                }

                                newMethod.Parameters.Add(new TypeSet.VkMethodParam
                                {
                                    Name = paramName,
                                    ArgumentName = argumentName,
                                    TypeName = $"ArrayProxy<{paramTypeName}>",
                                    FixedName = fixedName,
                                    FixedType = fixedType
                                });
                            }
                        }
                        else if (paramType.Data.Category == TypeCategory.handle)
                        {
                            string argumentName = paramType.RequiresInterop
                                                    ? $"&{marshalledName}"
                                                    : marshalledName;

                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                Name = paramName,
                                ArgumentName = marshalledName,
                                TypeName = paramType.Name
                            });

                            if (parameter.IsOptional)
                            {
                                newMethod.MarshalToStatements.Add($"Interop.{paramType.Name} {marshalledName} = {paramName}?.Pack() ?? Interop.{paramType.Name}.Null;");
                            }
                            else
                            {
                                newMethod.MarshalToStatements.Add($"Interop.{paramType.Name} {marshalledName} = {paramName}.Pack();");
                            }
                        }
                        else if (paramType.RequiresInterop)
                        {
                            string publicParamName = paramName;
                            string paramSource = paramName;

                            if (paramName == "allocator" && handleParams.Count() > 0)
                            {
                                publicParamName = null;
                                if (handle.ParentHandle != null)
                                {
                                    paramSource = "this.parent.Allocator";
                                }
                                else
                                {
                                    paramSource = "this.allocator";
                                }
                            }

                            newMethod.MarshalToStatements.Add(string.Format("Interop.{0} {1};", paramType.Name, marshalledName));
                            string paramTypeName = paramType.Name;
                            string argumentName = "&" + marshalledName;

                            if (parameter.IsOptional)
                            {
                                newMethod.MarshalToStatements.Add(string.Format("if({1} != null) {0} = {1}.Value.Pack();", marshalledName, paramSource));

                                paramTypeName += "?";

                                if (publicParamName != null)
                                {
                                    publicParamName += " = null";
                                }

                                argumentName = $"{paramSource} == null ? null : " + argumentName;
                            }
                            else
                            {
                                newMethod.MarshalToStatements.Add(string.Format("{0} = {1}.Pack();", marshalledName, paramSource));
                            }

                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                Name = publicParamName,
                                ArgumentName = argumentName,
                                TypeName = paramTypeName
                            });
                        }
                        else if (parameter.Type == "void" && parameter.PointerType == PointerType.DoublePointer)
                        {
                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                Name = paramName,
                                ArgumentName = "&" + marshalledName,
                                TypeName = "ref IntPtr"
                            });

                            newMethod.MarshalToStatements.Add($"void* {marshalledName};");
                            newMethod.MarshalFromStatements.Add($"{paramName} = new IntPtr({marshalledName});");
                        }
                        else if (parameter.PointerType.IsPointer())
                        {
                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                Name = paramName,
                                ArgumentName = "&" + paramName,
                                TypeName = paramType.Name
                            });
                        }
                        else
                        {
                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                Name = paramName,
                                ArgumentName = paramName,
                                TypeName = paramType.Name
                            });
                        }
                    }

                    parameterIndex++;
                }

                if (command.Type.StartsWith("PFN"))
                {
                    //HACK Expose the interop delegates until proper marshalling is implemented
                    //newMethod.ReturnTypeName = "Interop." + typeData[command.Type].Name;
                    newMethod.ReturnTypeName = "IntPtr";
                    newCommand.ReturnTypeName = "IntPtr";
                    newMethod.IsPassthroughResult = true;
                }
                else if (command.Type == "VkBool32")
                {
                    newMethod.ReturnTypeName = "bool";
                    newMethod.IsPassthroughResult = true;
                }

                newMethod.HasVkResult = command.Type == "VkResult";

                result.Commands.Add(newCommand);

                result.Delegates.Add(newCommand);

                handle.Methods.Add(newMethod);
            }
        }

        private static string GetFormattedTypeName(Dictionary<string, TypeDesc> typeData, SpecParser.ParsedElement element)
        {
            return typeData[GetMemberTypeName(element)].Name;
        }

        private static Dictionary<string, TypeSet.VkHandle> GenerateHandles(SpecParser.ParsedSpec spec, Dictionary<string, TypeDesc> typeData, TypeSet result)
        {
            var handleLookup = new Dictionary<string, TypeSet.VkHandle>();

            foreach (var type in typeData.Values.Where(x => x.Data.Category == TypeCategory.handle))
            {
                bool isDispatch = type.Data.Type != "VK_DEFINE_NON_DISPATCHABLE_HANDLE";

                var newHandle = new TypeSet.VkHandle
                {
                    Name = type.Name,
                    IsDispatch = isDispatch,
                    Comment = type.Data.Comment ?? new List<string> { "-" }
                };

                if (type.Data.Parent != null)
                {
                    newHandle.ParentHandle = typeData[type.Data.Parent].Name;
                }

                result.Handles.Add(newHandle);
                handleLookup.Add(type.Data.VkName, newHandle);
            }

            foreach (var command in spec.Commands.Values)
            {
                if (command.Verb == "create")
                {
                    var handle = handleLookup[command.Params.Last().Type];

                    if (typeData[command.Params.First().Type].Data.Category == TypeCategory.handle)
                    {
                        var associatedHandle = handleLookup[command.Params.First().Type];

                        if (handle.ParentHandle != associatedHandle.Name)
                        {
                            handle.AssociatedHandle = associatedHandle.Name;
                        }
                    }
                }
                else if (command.Verb == "destroy")
                {
                    var handle = handleLookup[command.Params.AsEnumerable().Reverse().Skip(1).First().Type];

                    handle.IsDisposable = true;
                }
                else if (command.Verb == "get" && command.NameParts.ElementAt(2) == "proc" && command.NameParts.ElementAt(3) == "addr")
                {
                    var handle = handleLookup[command.Params.First().Type];

                    handle.ProcCacheType = command.NameParts.ElementAt(1);
                }
            }

            return handleLookup;
        }

        private static Dictionary<string, TypeSet.VkClass> GenerateClasses(SpecParser.ParsedSpec spec, Dictionary<string, TypeDesc> typeData, TypeSet result, Dictionary<string, TypeSet.VkEnumerationField> enumLookup)
        {
            var classLookup = new Dictionary<string, TypeSet.VkClass>();

            foreach (var type in typeData.Values.Where(x => x.RequiresInterop))
            {
                var newStruct = new TypeSet.VkStruct
                {
                    Name = type.Name
                };

                var newClass = new TypeSet.VkClass
                {
                    Name = type.Name,
                    Comment = type.Data.Comment ?? new List<string> { "-" },
                    IsOutput = type.Data.IsReturnedOnly
                };

                classLookup.Add(type.Data.VkName, newClass);

                var lenMembers = new Dictionary<string, string>();
                var members = new Dictionary<string, MemberDesc>();

                var memberNameLookup = type.Data.Members.ToDictionary(x => x.VkName, x => JoinNameParts(x.NameParts));

                var expressionBuilder = new ParsedExpressionBuilder(memberNameLookup, type.Data.Members, null, typeData);

                foreach (var member in type.Data.Members)
                {
                    var memberType = typeData[GetMemberTypeName(member)];
                    string memberName = memberNameLookup[member.VkName];

                    var memberDesc = new MemberDesc
                    {
                        Name = memberName,
                        Comment = member.Comment ?? new List<string> { "-" },
                        Repetitions = 1,
                        InteropNameSuffix = "",
                        InteropTypeName = ApplyPointerType(member, memberType),
                        PublicTypeName = memberType.Name
                    };

                    bool isPointer = member.PointerType.IsPointer();

                    if (member.Values != null)
                    {
                        //HACK The only use of values currently is the
                        // enumeration binding for sType

                        memberDesc.IsInteropOnly = true;

                        var enumerationType = typeData[member.Type];
                        var enumerationField = enumLookup[member.Values];

                        newClass.MarshalToStatements.Add($"result.{memberName} = {enumerationType.Name}.{enumerationField.Name};");
                    }
                    else if (member.Dimensions != null)
                    {
                        if (member.Dimensions.Length > 1)
                        {
                            //HACK Assume that 2-dimensional arrays are string[] with a simple len field
                            Debug.Assert(member.Type == "char");

                            memberDesc.PublicTypeName = "string[]";

                            var lenToken = ((SpecParser.ParsedExpressionToken)member.Dimensions[0].Value).Value;
                            string lenMember = memberNameLookup[lenToken];

                            if (!lenMembers.ContainsKey(lenMember) || !member.IsOptional)
                            {
                                lenMembers[lenToken] = $"this.{memberName}?.Length ?? 0";
                            }

                            newClass.MarshalToStatements.Add(string.Format("result.{0} = this.{0} == null ? null : Interop.HeapUtil.MarshalTo(this.{0});", memberName));
                        }
                        else
                        {
                            switch (member.Dimensions[0].Type)
                            {
                                case SpecParser.LenType.NullTerminated:
                                    memberDesc.PublicTypeName = "string";

                                    newClass.MarshalToStatements.Add(string.Format("result.{0} = Interop.HeapUtil.MarshalTo(this.{0});", memberName));
                                    newClass.MarshalFromStatements.Add(string.Format("result.{0} = Interop.HeapUtil.MarshalFrom(value->{0});", memberName));
                                    break;
                                case SpecParser.LenType.Expression:

                                    var lenToken = member.Dimensions[0].Value as SpecParser.ParsedExpressionToken;

                                    if (isPointer && memberDesc.PublicTypeName == "void")
                                    {
                                        memberDesc.PublicTypeName = "byte";
                                    }

                                    memberDesc.PublicTypeName += "[]";

                                    if (memberType.RequiresInterop || memberType.Data.Category == TypeCategory.handle)
                                    {
                                        newClass.MarshalToStatements.Add("");
                                        newClass.MarshalToStatements.Add($"//{memberName}");
                                        newClass.MarshalToStatements.Add($"if (this.{memberName} != null)");
                                        newClass.MarshalToStatements.Add("{");
                                        newClass.MarshalToStatements.Add($"    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.{memberType.Name}>();");
                                        newClass.MarshalToStatements.Add($"    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.{memberType.Name}>(this.{memberName}.Length);");
                                        newClass.MarshalToStatements.Add($"    for (int index = 0; index < this.{memberName}.Length; index++)");
                                        newClass.MarshalToStatements.Add("    {");
                                        newClass.MarshalToStatements.Add($"        System.Runtime.InteropServices.Marshal.StructureToPtr(this.{memberName}[index].Pack(), pointer + (size * index), false);");
                                        newClass.MarshalToStatements.Add("    }");
                                        newClass.MarshalToStatements.Add($"    result.{memberName} = (Interop.{memberType.Name}*)pointer.ToPointer();");
                                        newClass.MarshalToStatements.Add("}");
                                        newClass.MarshalToStatements.Add("else");
                                        newClass.MarshalToStatements.Add("{");
                                        newClass.MarshalToStatements.Add($"    result.{memberName} = null;");
                                        newClass.MarshalToStatements.Add("}");
                                    }
                                    else if (memberType.Data.Category == TypeCategory.bitmask || memberType.Data.Category == TypeCategory.@enum || memberType.Data.Category == TypeCategory.@struct)
                                    {
                                        string allocateType = memberType.Data.Category == TypeCategory.@struct
                                                                ? memberType.Name
                                                                : "int";

                                        newClass.MarshalToStatements.Add("");
                                        newClass.MarshalToStatements.Add($"//{memberName}");
                                        newClass.MarshalToStatements.Add($"if (this.{memberName} != null)");
                                        newClass.MarshalToStatements.Add("{");
                                        newClass.MarshalToStatements.Add($"    result.{memberName} = ({memberType.Name}*)Interop.HeapUtil.Allocate<{allocateType}>(this.{memberName}.Length).ToPointer();");
                                        newClass.MarshalToStatements.Add($"    for (int index = 0; index < this.{memberName}.Length; index++)");
                                        newClass.MarshalToStatements.Add("    {");
                                        newClass.MarshalToStatements.Add($"        result.{memberName}[index] = this.{memberName}[index];");
                                        newClass.MarshalToStatements.Add("    }");
                                        newClass.MarshalToStatements.Add("}");
                                        newClass.MarshalToStatements.Add("else");
                                        newClass.MarshalToStatements.Add("{");
                                        newClass.MarshalToStatements.Add($"    result.{memberName} = null;");
                                        newClass.MarshalToStatements.Add("}");
                                    }
                                    else if (memberType.Data.Category == TypeCategory.basetype || memberType.Data.Category == TypeCategory.union)
                                    {
                                        string lenExpression = lenToken != null
                                            ? $"this.{memberName}.Length"
                                            : expressionBuilder.Build(member.Dimensions[0].Value);
                                        newClass.MarshalToStatements.Add("");
                                        newClass.MarshalToStatements.Add($"//{memberName}");
                                        newClass.MarshalToStatements.Add($"if (this.{memberName} != null && {lenExpression} > 0)");
                                        newClass.MarshalToStatements.Add("{");
                                        newClass.MarshalToStatements.Add($"    int length = (int)({lenExpression});");
                                        newClass.MarshalToStatements.Add($"    result.{memberName} = ({memberType.Name}*)Interop.HeapUtil.Allocate<{memberType.Name}>(length).ToPointer();");
                                        newClass.MarshalToStatements.Add($"    for (int index = 0; index < length; index++)");
                                        newClass.MarshalToStatements.Add("    {");
                                        newClass.MarshalToStatements.Add($"        result.{memberName}[index] = this.{memberName}[index];");
                                        newClass.MarshalToStatements.Add("    }");
                                        newClass.MarshalToStatements.Add("}");
                                        newClass.MarshalToStatements.Add("else");
                                        newClass.MarshalToStatements.Add("{");
                                        newClass.MarshalToStatements.Add($"    result.{memberName} = null;");
                                        newClass.MarshalToStatements.Add("}");
                                    }
                                    else
                                    {
                                        newClass.MarshalToStatements.Add(string.Format("result.{0} = this.{0} == null ? null : Interop.HeapUtil.MarshalTo(this.{0});", memberName));
                                    }

                                    if (lenToken != null)
                                    {
                                        string lenTokenName = ((SpecParser.ParsedExpressionToken)member.Dimensions[0].Value).Value;

                                        if (!lenMembers.ContainsKey(lenTokenName) || !member.IsOptional)
                                        {
                                            string lenMember = memberNameLookup[lenToken.Value];

                                            lenMembers[lenTokenName] = $"this.{memberName}?.Length ?? 0";
                                        }
                                    }

                                    break;
                            }
                        }
                    }
                    else if (member.VkName == "pNext")
                    {
                        // These fields are not to be exposed to the public API
                        // as they are either not supported or have pre-defined
                        // values

                        memberDesc.IsInteropOnly = true;
                    }
                    else if (isPointer && memberDesc.PublicTypeName == "void")
                    {
                        memberDesc.PublicTypeName = "IntPtr";

                        newClass.MarshalToStatements.Add(string.Format("result.{0} = this.{0}.ToPointer();", memberDesc.Name));
                        newClass.MarshalFromStatements.Add(string.Format("result.{0} = new IntPtr(value->{0});", memberDesc.Name));
                    }
                    else if (memberType.Data.Category == TypeCategory.handle)
                    {
                        if (member.PointerType.IsPointer())
                        {
                            newClass.MarshalToStatements.Add($"result.{memberDesc.Name} = this.{memberDesc.Name} == null ? null : (Interop.{memberDesc.InteropTypeName})Interop.HeapUtil.AllocateAndMarshal(this.{memberDesc.Name}.Pack());");
                        }
                        else
                        {
                            newClass.MarshalToStatements.Add($"result.{memberDesc.Name} = this.{memberDesc.Name}?.Pack() ?? Interop.{memberDesc.InteropTypeName}.Null;");
                        }
                    }
                    else if (isPointer && memberType.RequiresInterop)
                    {
                        newClass.MarshalToStatements.Add(string.Format("result.{0} = this.{0} == null ? null : this.{0}.Value.MarshalTo();", memberDesc.Name));

                        memberDesc.PublicTypeName += "?";
                    }
                    else if (isPointer)
                    {
                        newClass.MarshalToStatements.Add(string.Format("result.{0} = ({1}*)Interop.HeapUtil.AllocateAndMarshal(this.{0});", memberDesc.Name, memberType.Name));
                    }
                    else if (memberType.RequiresInterop)
                    {
                        newClass.MarshalToStatements.Add(string.Format("result.{0} = this.{0}.Pack();", memberDesc.Name));
                        newClass.MarshalFromStatements.Add(string.Format("result.{0} = {1}.MarshalFrom(&value->{0});", memberDesc.Name, memberDesc.PublicTypeName));
                    }
                    else if (member.FixedLength.Type != SpecParser.FixedLengthType.None)
                    {
                        string fixedLengthValue = member.FixedLength.Value;

                        if (member.FixedLength.Type == SpecParser.FixedLengthType.EnumReference)
                        {
                            fixedLengthValue = "Constants." + GetNameForElement(spec.Constants[member.FixedLength.Value]);
                        }

                        if (member.Type == "char")
                        {
                            memberDesc.PublicTypeName = "string";

                            newClass.MarshalFromStatements.Add(string.Format("result.{0} = System.Text.Encoding.UTF8.GetString(Interop.HeapUtil.MarshalFrom(value->{0}, {1}, true));", memberDesc.Name, fixedLengthValue));
                        }
                        else if (memberDesc.Name.EndsWith("UUID"))
                        {
                            memberDesc.PublicTypeName = "Guid";

                            newClass.MarshalFromStatements.Add(string.Format("result.{0} = new Guid(Interop.HeapUtil.MarshalFrom(value->{0}, {1}));", memberDesc.Name, fixedLengthValue));
                        }
                        else
                        {
                            string marshalToPointerExpression = $"result.{memberDesc.Name}";

                            if (memberType.IsPrimitive)
                            {
                                newClass.MarshalFromStatements.Add(string.Format("result.{0} = Interop.HeapUtil.MarshalFrom(value->{0}, {1});", memberDesc.Name, fixedLengthValue));
                            }
                            else
                            {
                                string pointerVarName = memberDesc.Name + "Pointer";

                                marshalToPointerExpression = "&" + marshalToPointerExpression;

                                //HACK There's no len attribute for fixed-length
                                // fields, so work out what the len field name
                                // should be

                                string lenMember = memberDesc.Name.TrimEnd('s') + "Count";

                                newClass.MarshalFromStatements.Add(string.Format("result.{2} = new {0}[value->{1}];", memberDesc.PublicTypeName, lenMember, memberDesc.Name));
                                newClass.MarshalFromStatements.Add(string.Format("{0}* {1} = &value->{2};", memberDesc.PublicTypeName, pointerVarName, memberDesc.Name));
                                newClass.MarshalFromStatements.Add(string.Format("for (int index = 0; index < value->{0}; index++)", lenMember));
                                newClass.MarshalFromStatements.Add(string.Format("{{"));
                                newClass.MarshalFromStatements.Add(string.Format("    result.{1}[index] = *{0};", pointerVarName, memberDesc.Name));
                                newClass.MarshalFromStatements.Add(string.Format("    {0}++;", pointerVarName));
                                newClass.MarshalFromStatements.Add(string.Format("}}"));
                            }

                            newClass.MarshalToStatements.Add($"Validate.CheckLength(this.{memberDesc.Name}, {member.FixedLength.Value}, \"{memberDesc.Name}\");");
                            newClass.MarshalToStatements.Add($"MemUtil.WriteToPtr((IntPtr)({marshalToPointerExpression}), this.{memberDesc.Name}, 0, {member.FixedLength.Value});");

                            memberDesc.PublicTypeName += "[]";
                        }

                        if (memberType.IsPrimitive)
                        {
                            if (memberDesc.InteropTypeName == "fixed char")
                            {
                                memberDesc.InteropTypeName = "fixed byte";
                            }

                            switch (member.FixedLength.Type)
                            {
                                case SpecParser.FixedLengthType.EnumReference:
                                    memberDesc.InteropNameSuffix = "[Constants." + GetNameForElement(spec.Constants[member.FixedLength.Value]) + "]";
                                    break;
                                case SpecParser.FixedLengthType.IntegerLiteral:
                                    memberDesc.InteropNameSuffix = "[" + member.FixedLength.Value + "]";
                                    break;
                            }
                        }
                        else
                        {
                            string repetitionValue = "1";

                            switch (member.FixedLength.Type)
                            {
                                case SpecParser.FixedLengthType.EnumReference:
                                    repetitionValue = spec.Constants[member.FixedLength.Value].Value;
                                    break;
                                case SpecParser.FixedLengthType.IntegerLiteral:
                                    repetitionValue = member.FixedLength.Value;
                                    break;
                            }

                            memberDesc.Repetitions = int.Parse(repetitionValue);

                            //HACK There's no len attribute for fixed-length
                            // fields, so work out what the len field name
                            // should be

                            string lenMember = member.VkName.TrimEnd('s') + "Count";

                            if (memberNameLookup.ContainsKey(lenMember) && !lenMembers.ContainsKey(lenMember))
                            {
                                lenMembers.Add(lenMember, null);
                            }
                        }
                    }
                    else if (memberDesc.Name.EndsWith("Version") && memberDesc.PublicTypeName == "uint")
                    {
                        memberDesc.PublicTypeName = "Version";
                        newClass.MarshalToStatements.Add($"result.{memberName} = (uint)this.{memberName};");
                        newClass.MarshalFromStatements.Add($"result.{memberName} = value->{memberName};");
                    }
                    else if (memberType.Data.Category == TypeCategory.funcpointer)
                    {
                        memberDesc.InteropTypeName = "IntPtr";
                        //HACK Expose the interop delegates until proper marshalling is implemented
                        memberDesc.PublicTypeName = "Interop." + memberDesc.PublicTypeName;
                        newClass.MarshalToStatements.Add($"result.{memberName} = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.{memberName});");
                    }
                    else
                    {
                        memberDesc.IsSimpleMarshal = true;
                    }

                    if (memberDesc.PublicTypeName == "DeviceSize")
                    {
                        memberDesc.PublicTypeName = "ulong";
                    }

                    for (int repetitionIndex = 0; repetitionIndex < memberDesc.Repetitions; repetitionIndex++)
                    {
                        string name = memberDesc.Name + memberDesc.InteropNameSuffix;

                        if (repetitionIndex > 0)
                        {
                            name += "_" + repetitionIndex;
                        }

                        newStruct.Members.Add(new TypeSet.VkStructMember
                        {
                            Name = name,
                            TypeName = memberDesc.InteropTypeName,
                            IsPrivate = repetitionIndex > 0
                        });
                    }

                    members.Add(member.VkName, memberDesc);
                }

                foreach (var memberName in lenMembers.Keys)
                {
                    //HACK VkDescriptorSetLayoutBinding.descriptorCount is a
                    // special case, as the value can be non-zero when the
                    // only referencing array member (pImmutableSamplers) is
                    // null.

                    if (type.Data.VkName == "VkDescriptorSetLayoutBinding" && memberName == "descriptorCount")
                    {
                        newClass.MarshalToStatements.Add($"result.{memberNameLookup[memberName]} = (uint)(this.ImmutableSamplers?.Length ?? (int)this.{memberNameLookup[memberName]});");
                    }
                    //HACK Map VkWriteDescriptorSet to access length of any non-null array field
                    else if (type.Data.VkName == "VkWriteDescriptorSet" && memberName == "descriptorCount")
                    {
                        members[memberName].IsInteropOnly = true;

                        newClass.MarshalToStatements.Add($"result.{memberNameLookup[memberName]} = (uint)(this.ImageInfo?.Length ?? this.BufferInfo?.Length ?? this.TexelBufferView?.Length ?? 0);");
                    }
                    else
                    {
                        members[memberName].IsInteropOnly = true;

                        newClass.MarshalToStatements.Add($"result.{memberNameLookup[memberName]} = ({members[memberName].InteropTypeName})({lenMembers[memberName]});");
                    }
                }

                foreach (var member in members.Values.Where(x => !x.IsInteropOnly))
                {
                    newClass.Properties.Add(new TypeSet.VkClassProperty
                    {
                        Name = member.Name,
                        Comment = member.Comment,
                        TypeName = member.PublicTypeName
                    });

                    if (member.IsSimpleMarshal)
                    {
                        newClass.MarshalToStatements.Add(string.Format("result.{0} = this.{0};", member.Name));
                        newClass.MarshalFromStatements.Add(string.Format("result.{0} = value->{0};", member.Name));
                    }
                }

                result.InteropStructs.Add(newStruct);
                result.Classes.Add(newClass);
            }

            return classLookup;
        }

        private static void GenerateUnions(Dictionary<string, TypeDesc> typeData, TypeSet result)
        {
            foreach (var type in typeData.Values.Where(x => x.Data.Category == TypeCategory.union))
            {
                var newStruct = new TypeSet.VkStruct
                {
                    Name = type.Name,
                    Comment = type.Data.Comment ?? new List<string> { "-" }
                };

                foreach (var member in type.Data.Members)
                {
                    string name = JoinNameParts(member.NameParts, true);
                    var comment = member.Comment ?? new List<string> { "-" };
                    string typeName = typeData[GetMemberTypeName(member)].Name;

                    switch (member.FixedLength.Type)
                    {
                        case SpecParser.FixedLengthType.None:
                            newStruct.Members.Add(new TypeSet.VkStructMember
                            {
                                Name = name,
                                Comment = comment,
                                TypeName = typeName,
                                FieldOffset = "0"
                            });
                            break;
                        case SpecParser.FixedLengthType.EnumReference:
                            throw new NotSupportedException("Fixed-length arrays with named lengths are not currently supported in Unions.");
                        case SpecParser.FixedLengthType.IntegerLiteral:
                            int length = int.Parse(member.FixedLength.Value);

                            newStruct.Members.Add(new TypeSet.VkStructMember
                            {
                                Name = name,
                                Comment = comment,
                                TypeName = typeName,
                                FieldOffset = "0",
                                FixedSize = length
                            });

                            break;
                    }
                }

                result.Unions.Add(newStruct);
            }
        }

        private static void SetPrimitiveTypeNames(Dictionary<string, TypeDesc> typeData)
        {
            foreach (var type in typeData.Values)
            {
                switch (type.Data.Category)
                {
                    case TypeCategory.None:
                        type.Name = primitiveTypes[type.Data.VkName];
                        break;
                    case TypeCategory.funcpointer:
                        type.Name += "Delegate";
                        break;
                }
            }
        }

        private static void GenerateNonInteropStructs(Dictionary<string, TypeDesc> typeData, TypeSet result)
        {
            foreach (var type in typeData.Values.Where(x => !x.RequiresInterop && x.Data.Category == TypeCategory.@struct))
            {
                var newStruct = new TypeSet.VkStruct
                {
                    Name = type.Name,
                    Comment = type.Data.Comment ?? new List<string> { "-" }
                };

                foreach (var member in type.Data.Members)
                {
                    newStruct.Members.Add(new TypeSet.VkStructMember
                    {
                        Name = JoinNameParts(member.NameParts),
                        Comment = member.Comment ?? new List<string> { "-" },
                        TypeName = typeData[GetMemberTypeName(member)].Name
                    });
                }

                result.Structs.Add(newStruct);
            }
        }

        private static string GetMemberTypeName(SpecParser.ParsedElement member)
        {
            string memberTypeName = member.TypeWithoutExtension ?? member.Type;

            if (memberTypeName.EndsWith("Bits"))
            {
                // Some struct members incorrectly reference the
                // "*FlagBits" enum name, rather than the "Flags"
                // type name. Quietly fix that here.

                memberTypeName = memberTypeName.Replace("FlagBits", "Flags");
            }

            if (member.TypeExtension != null)
            {
                memberTypeName += member.TypeExtension.ToUpperInvariant();
            }

            return memberTypeName;
        }

        private static string ApplyPointerType(SpecParser.ParsedPointerElement member, TypeDesc memberType)
        {
            if (member.PointerType.IsPointer())
            {
                return memberType.Name + new string('*', member.PointerType.GetPointerCount());
            }
            else if (member.FixedLength.Type != SpecParser.FixedLengthType.None && memberType.IsPrimitive)
            {
                return "fixed " + memberType.Name;
            }
            else
            {
                return memberType.Name;
            }
        }

        private static Dictionary<string, TypeSet.VkEnumerationField> GenerateEnumerations(SpecParser.ParsedSpec spec, Dictionary<string, TypeDesc> typeData, TypeSet result)
        {
            var resultLookup = new Dictionary<string, TypeSet.VkEnumerationField>();

            var enumerationTypes = typeData.Values.Where(x => x.Data.Category == TypeCategory.@enum).ToDictionary(x => x.Data.VkName);

            foreach (var type in typeData.Values.Where(x => x.Data.Category == TypeCategory.bitmask))
            {

                var newEnumeration = new TypeSet.VkEnumeration
                {
                    Name = type.Name,
                    Comment = type.Data.Comment ?? new List<string> { "-" },
                    IsFlags = true
                };

                if (type.Data.Requires != null)
                {
                    enumerationTypes.Remove(type.Data.Requires);

                    var enumeration = spec.Enumerations[type.Data.Requires];

                    newEnumeration.Comment = enumeration.Comment ?? newEnumeration.Comment;

                    // Add a zero-valued None field for bitmasks (if not already defined)
                    // so API users don't have to typecast zero when no flags are required
                    if (!enumeration.Fields.Values.Any(x => x.Value == "0" && !x.IsBitmask))
                    {
                        PopulateNoneField(newEnumeration);
                    }

                    PopulateFields(newEnumeration, enumeration, resultLookup);
                }
                else
                {
                    PopulateNoneField(newEnumeration);
                }

                result.Enumerations.Add(newEnumeration);
            }

            foreach (var type in enumerationTypes.Values)
            {
                var enumeration = spec.Enumerations[type.Data.VkName];

                var newEnumeration = new TypeSet.VkEnumeration
                {
                    Name = type.Name,
                    Comment = enumeration.Comment ?? new List<string> { "-" }
                };

                PopulateFields(newEnumeration, enumeration, resultLookup);

                result.Enumerations.Add(newEnumeration);
            }

            return resultLookup;
        }

        private static void PopulateNoneField(TypeSet.VkEnumeration newEnumeration)
        {
            newEnumeration.Fields.Add(new TypeSet.VkEnumerationField
            {
                Name = "None",
                Comment = new List<string> { "-" },
                Value = "0"
            });
        }

        private static void PopulateFields(TypeSet.VkEnumeration newEnumeration, SpecParser.ParsedEnum enumeration, Dictionary<string, TypeSet.VkEnumerationField> resultLookup)
        {
            string digitsPrefix = JoinNameParts(enumeration.NameParts.TakeWhile(x => !digitsSuffix.Contains(x)));

            foreach (var field in enumeration.Fields.Values)
            {
                string fieldName = GetNameForElement(field, field.IsBitmask ? 1 : 0);

                if (!char.IsLetter(fieldName[0]))
                {
                    fieldName = digitsPrefix + fieldName;
                }

                var newField = new TypeSet.VkEnumerationField
                {
                    Name = fieldName,
                    Comment = field.Comment ?? new List<string> { "-" },
                    Value = field.IsBitmask ? "1 << " + field.Value : field.Value
                };

                newEnumeration.Fields.Add(newField);

                resultLookup.Add(field.VkName, newField);
            }
        }

        private static void GenerateConstants(SpecParser.ParsedSpec spec, TypeSet result)
        {
            foreach (var constant in spec.Constants.Values)
            {
                Type type;
                string explicitType = null;
                string value = constant.Value;
                bool isStaticReadonly = false;

                string name = GetNameForElement(constant);

                if (value.StartsWith("VK_MAKE_VERSION"))
                {
                    type = null;
                    explicitType = "Version";
                    isStaticReadonly = true;
                    value = "new Version" + value.Substring(15);
                }
                else if (char.IsLetter(value[0]))
                {
                    // Looks like some extension enums are used for type name
                    // mapping - not sure what this is supposed to do yet, so
                    // skip them for now.
                    Console.WriteLine($"Skipping constant {constant.VkName} with value {value}");
                    continue;
                }
                else if (value.StartsWith("\""))
                {
                    type = typeof(string);
                }
                else
                {
                    string typeSuffix = new string(value.Reverse()
                                                        .TakeWhile(char.IsLetter)
                                                        .Reverse()
                                                        .ToArray());

                    switch (typeSuffix.ToLower())
                    {
                        case "f":
                            type = typeof(float);
                            break;
                        case "u":
                            type = typeof(uint);
                            break;
                        case "ul":
                            type = typeof(ulong);
                            break;
                        default:
                            type = (name.StartsWith("Max") || name.EndsWith("Size")) ? typeof(int) : typeof(uint);
                            break;
                    }
                }

                result.Constants.Add(new TypeSet.VkConstant
                {
                    Name = name,
                    Type = type,
                    ExplicitType = explicitType,
                    SubGroupName = constant.ConstantSubGroup == null ? null : JoinNameParts(constant.ConstantSubGroup),
                    IsStaticReadonly = isStaticReadonly,
                    Value = value
                });
            }
        }

        private static void GenerateExceptions(SpecParser.ParsedSpec spec, TypeSet result)
        {
            var resultEnum = spec.Enumerations["VkResult"];

            string enumName = GetNameForElement(resultEnum);

            foreach (var error in resultEnum.Fields.Values
                                        .Where(x => int.Parse(x.Value) < 0))
            {
                string errorFieldName = GetNameForElement(error);

                result.Exceptions.Add(new TypeSet.VkConstant
                {
                    Name = JoinNameParts(error.NameParts.Skip(1)) + "Exception",
                    Type = typeof(int),
                    Value = $"{enumName}.{errorFieldName}",
                    Comment = error.Comment ?? new List<string> { "-" }
                });
            }
        }

        private static Dictionary<string, TypeDesc> GetTypeData(SpecParser.ParsedSpec spec)
        {
            var typeData = spec.Types.Values.ToDictionary(x => x.VkName, x => new TypeDesc
            {
                Data = x,
                Name = GetNameForElement(x),
                RequiresInterop = RequiresInterop(spec, x),
                IsPrimitive = x.Category == TypeCategory.basetype
                                || x.Category == TypeCategory.None
            });

            bool newInteropTypes = true;

            while (newInteropTypes)
            {
                newInteropTypes = false;

                foreach (var type in typeData.Values)
                {
                    if (!type.RequiresInterop
                            && type.Data.Members.Any(x => typeData[x.Type].RequiresInterop))
                    {
                        type.RequiresInterop = true;

                        newInteropTypes = true;
                    }
                }
            }

            return typeData;
        }

        private static bool RequiresInterop(SpecParser.ParsedSpec spec, SpecParser.ParsedType type)
        {
            return type.Category == TypeCategory.@struct
                && type.Members.Any(y =>
                    y.FixedLength.Type != SpecParser.FixedLengthType.None
                        || (y.PointerType != PointerType.Value
                            && y.PointerType != PointerType.ConstValue
                            || spec.Types[y.Type].Category == TypeCategory.handle));
        }

        internal static string GetNameForElement(SpecParser.ParsedElement element, int trimFromEnd = 0)
        {
            if (element.NameParts == null)
            {
                return element.VkName;
            }
            else
            {
                return JoinNameParts(element.NameParts.Take(element.NameParts.Length - trimFromEnd));
            }
        }

        private static string JoinNameParts(IEnumerable<string> parts, bool isCamelCase = false)
        {
            return parts.Select(ExpandAbbreviations)
                        .Select((value, index) => CapitaliseNamePart(value, index, isCamelCase))
                        .Aggregate(new StringBuilder(), (builder, value) => builder.Append(value))
                        .ToString();
        }

        private static string CapitaliseNamePart(string value, int index, bool isCamelCase)
        {
            if (IsComponentSet(value))
            {
                value = value.ToUpper();
            }
            else
            {
                value = GetSpecialCasing(value);
            }

            return (isCamelCase && index == 0) ? LowerCaseFirst(value) : CapitaliseFirst(value);
        }

        private static bool IsComponentSet(string value)
        {
            var componentLetters = new[] { 'r', 'g', 'b', 'a', 'x' };

            if (!componentLetters.Contains(value[0]) || value.Length < 2)
            {
                return false;
            }

            bool lastCharacterWasComponent = true;

            for (int index = 1; index < value.Length; index++)
            {
                if (char.IsDigit(value[index]))
                {
                    lastCharacterWasComponent = false;
                }
                else if (componentLetters.Contains(value[index]) && !lastCharacterWasComponent)
                {
                    lastCharacterWasComponent = true;
                }
                else
                {
                    return false;
                }
            }

            return !lastCharacterWasComponent;
        }

        private static string GetSpecialCasing(string value)
        {
            switch (value)
            {
                case "unorm":
                    return "UNorm";
                case "snorm":
                    return "SNorm";
                case "uscaled":
                    return "UScaled";
                case "sscaled":
                    return "SScaled";
                case "uint":
                    return "UInt";
                case "uint16":
                    return "UInt16";
                case "uint32":
                    return "UInt32";
                case "sint":
                    return "SInt";
                case "sfloat":
                    return "SFloat";
                case "d3d11":
                    return "D3D11";
            }

            return value;
        }

        private static string ExpandAbbreviations(string value)
        {
            switch (value)
            {
                case "src":
                    return "source";
                case "dst":
                    return "destination";
                case "cmd":
                    return "command";
                case "proc":
                    return "procedure";
                case "addr":
                    return "address";
                default:
                    return value;
            }
        }

        private static string LowerCaseFirst(string value)
        {
            var charArray = value.ToCharArray();

            charArray[0] = char.ToLower(charArray[0]);

            return new string(charArray);
        }

        private static string CapitaliseFirst(string value)
        {
            var charArray = value.ToCharArray();

            charArray[0] = char.ToUpper(charArray[0]);

            return new string(charArray);
        }

        internal class TypeDesc
        {
            public SpecParser.ParsedType Data;
            public bool RequiresInterop;
            public bool IsPrimitive;
            public string Name;
        }

        private class MemberDesc
        {
            public string Name;
            public string InteropNameSuffix;
            public int Repetitions;
            public bool IsInteropOnly;
            public bool IsSimpleMarshal;
            public string InteropTypeName;
            public string PublicTypeName;
            public List<string> MarshalStatements = new List<string>();
            public List<string> Comment;
        }
    }
}