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
            {"uint64_t", "ulong"},
            {"int32_t", "int"},
            {"size_t", "UIntPtr"},
            {"HINSTANCE", "IntPtr" },
            {"HWND", "IntPtr" }
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

            GenerateEnumerations(spec, typeData, result);

            GenerateUnions(typeData, result);

            GenerateNonInteropStructs(typeData, result);

            GenerateClasses(spec, typeData, result);

            var handleLookup = GenerateHandles(spec, typeData, result);

            GenerateCommands(spec, typeData, handleLookup, result);

            return result;
        }

        private static void GenerateCommands(SpecParser.ParsedSpec spec, Dictionary<string, TypeDesc> typeData, Dictionary<string, TypeSet.VkHandle> handleLookup, TypeSet result)
        {
            foreach (var command in spec.Commands.Values)
            {
                string commandName = command.VkName;

                var newCommand = new TypeSet.VkCommand
                {
                    Name = commandName,
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

                            return previousParamHandle.Name == paramHandle.ParentHandle
                                    || previousParamHandle.Name == paramHandle.AssociatedHandle;
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

                bool lastParamReturns = lastParam.PointerType == PointerType.Pointer;
                bool lastParamIsArray = lastParamReturns
                                            && lastParam.Dimensions != null
                                            && lastParam.Dimensions.Any(x => x.Type != SpecParser.LenType.NullTerminated);
                bool enumeratePattern = command.Verb == "enumerate" || lastParamIsArray;

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

                var newMethod = new TypeSet.VkHandleMethod
                {
                    Name = JoinNameParts(methodNameParts),
                    ReturnTypeName = "void",
                    CommandName = commandName
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
                    var nameParts = x.NameParts.AsEnumerable();
                    int pointerCount = x.PointerType.GetPointerCount();

                    if (pointerCount > 0)
                    {
                        nameParts = nameParts.Skip(1);
                    }
                    return JoinNameParts(nameParts, true);
                });

                var lenParamMapping = new Dictionary<string, string>();

                foreach (var parameter in command.Params)
                {
                    if (parameter.Dimensions?.Count() > 0 && parameter.Dimensions[0].Type == SpecParser.LenType.Expression)
                    {
                        lenParamMapping[parameter.Dimensions[0].Value] = paramNameLookup[parameter.VkName];
                    }
                }

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
                                    string lenParam = paramNameLookup[parameter.Dimensions[0].Value];

                                    newMethod.MarshalMidStatements.Add(string.Format("{1} = ({0}*)Interop.HeapUtil.Allocate<{0}>((uint){2});", interopTypeName, marshalledName, lenParam));

                                    newMethod.MarshalFromStatements.Add(string.Format("result = new {0}[(uint){1}];", paramTypeName, lenParam));

                                    newMethod.MarshalFromStatements.Add(string.Format("for(int index = 0; index < (uint){0}; index++)", lenParam));
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

                                        newMethod.MarshalFromStatements.Add($"\tresult[index] = new {paramTypeName}({marshalledName}[index]{parentArgument});"); //, paramTypeName, marshalledName, paramType.Data.Parent != null ? ", this" : ""));
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

                                    if (paramType.Data.Parent != null)
                                    {
                                        var parentHandle = handleLookup[paramType.Data.Parent];

                                        if (handle != parentHandle)
                                        {
                                            // If the containing handle is not the parent of the handle being returned,
                                            // assume that the first param after all handles is a CreateInfo containing
                                            // a field with the parent handle to assign.
                                            // Also include a reference to the containing handle, as it will be the
                                            // associated handle for this instance.

                                            var createInfoParam = command.Params.Skip(handleParams.Count()).First();
                                            var createInfoType = typeData[GetMemberTypeName(createInfoParam)];

                                            var parentHandleMember = createInfoType.Data.Members.First(x => x.Type == paramType.Data.Parent);

                                            parentArgument = $", {paramNameLookup[createInfoParam.VkName]}.{GetNameForElement(parentHandleMember)}, this";
                                        }
                                        else
                                        {
                                            parentArgument = ", this";
                                        }
                                    }

                                    argumentName = "&" + marshalledName;
                                    newMethod.MarshalToStatements.Add(string.Format("Interop.{0} {1};", paramType.Name, marshalledName));
                                    newMethod.MarshalFromStatements.Add(string.Format("result = new {0}({1}{2});", paramType.Name, marshalledName, parentArgument));
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
                                ArgumentName = $"({paramType.Name}){mapping}.Length"
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

                                if (paramType.RequiresInterop || paramType.Data.Category == TypeCategory.handle)
                                {
                                    newMethod.MarshalToStatements.Add($"Interop.{paramType.Name}* {marshalledName};");
                                    newMethod.MarshalToStatements.Add($"if ({paramName} != null)");
                                    newMethod.MarshalToStatements.Add("{");
                                    newMethod.MarshalToStatements.Add($"    {marshalledName} = (Interop.{paramType.Name}*)Interop.HeapUtil.Allocate<Interop.{paramType.Name}>({paramName}.Length);");
                                    newMethod.MarshalToStatements.Add($"    for (int index = 0; index < {paramName}.Length; index++)");
                                    newMethod.MarshalToStatements.Add("    {");
                                    newMethod.MarshalToStatements.Add($"        {marshalledName}[index] = {paramName}[index].Pack();");
                                    newMethod.MarshalToStatements.Add("    }");
                                    newMethod.MarshalToStatements.Add("}");
                                    newMethod.MarshalToStatements.Add($"else");
                                    newMethod.MarshalToStatements.Add("{");
                                    newMethod.MarshalToStatements.Add($"    {marshalledName} = null;");
                                    newMethod.MarshalToStatements.Add("}");
                                }
                                else
                                {
                                    fixedName = marshalledName;
                                    fixedType = paramTypeName + "*";
                                }

                                newMethod.Parameters.Add(new TypeSet.VkMethodParam
                                {
                                    Name = paramName,
                                    ArgumentName = marshalledName,
                                    TypeName = paramTypeName + "[]",
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

                            newMethod.MarshalToStatements.Add($"Interop.{paramType.Name} {marshalledName} = {paramName}?.Pack() ?? Interop.{paramType.Name}.Null;");
                        }
                        else if (paramType.RequiresInterop)
                        {
                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                Name = paramName,
                                ArgumentName = $"{paramName} == null ? null : &{marshalledName}",
                                TypeName = paramType.Name
                            });

                            newMethod.MarshalToStatements.Add(string.Format("Interop.{0} {1};", paramType.Name, marshalledName));
                            newMethod.MarshalToStatements.Add(string.Format("if({1} != null) {0} = {1}.Pack();", marshalledName, paramName));
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

                if (command.Type == "PFN_vkVoidFunction")
                {
                    newMethod.ReturnTypeName = "IntPtr";
                    newMethod.IsPassthroughResult = true;
                }

                newMethod.HasVkResult = command.Type == "VkResult";

                result.Commands.Add(newCommand);

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
                var newHandle = new TypeSet.VkHandle
                {
                    Name = type.Name
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
            }

            return handleLookup;
        }

        private static void GenerateClasses(SpecParser.ParsedSpec spec, Dictionary<string, TypeDesc> typeData, TypeSet result)
        {
            foreach (var type in typeData.Values.Where(x => x.RequiresInterop))
            {
                var newStruct = new TypeSet.VkStruct
                {
                    Name = type.Name
                };

                var newClass = new TypeSet.VkClass
                {
                    Name = type.Name,
                    IsOutput = type.Data.IsReturnedOnly
                };

                var lenMembers = new List<string>();
                var members = new Dictionary<string, MemberDesc>();

                var memberNameLookup = type.Data.Members.ToDictionary(x => x.VkName, x => JoinNameParts(x.NameParts));

                foreach (var member in type.Data.Members)
                {
                    var memberType = typeData[GetMemberTypeName(member)];
                    string memberName = memberNameLookup[member.VkName];

                    var memberDesc = new MemberDesc
                    {
                        Name = memberName,
                        Repetitions = 1,
                        InteropNameSuffix = "",
                        InteropTypeName = ApplyPointerType(member, memberType),
                        PublicTypeName = memberType.Name
                    };

                    bool isPointer = member.PointerType.IsPointer();

                    if (member.Dimensions != null)
                    {
                        if (member.Dimensions.Length > 1)
                        {
                            //HACK Assume that 2-dimensional arrays are string[]
                            Debug.Assert(member.Type == "char");

                            memberDesc.PublicTypeName = "string[]";

                            var lenMember = member.Dimensions[0].Value;

                            lenMembers.Add(lenMember);

                            newClass.MarshalToStatements.Add(string.Format("result.{0} = (uint)(this.{1}?.Length ?? 0);", memberNameLookup[lenMember], memberName));
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

                                    if (isPointer && memberDesc.PublicTypeName == "void")
                                    {
                                        memberDesc.PublicTypeName = "IntPtr";
                                    }
                                    else
                                    {
                                        memberDesc.PublicTypeName += "[]";

                                        //HACL Ignore unparsed len fields temporarily
                                        if (member.Dimensions[0].Value != null)
                                        {
                                            newClass.MarshalToStatements.Add(string.Format("result.{0} = (uint)(this.{1}?.Length ?? 0);", memberNameLookup[member.Dimensions[0].Value], memberName));
                                        }

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
                                        else if (memberType.Data.Category == TypeCategory.bitmask || memberType.Data.Category == TypeCategory.@enum)
                                        {
                                            newClass.MarshalToStatements.Add("");
                                            newClass.MarshalToStatements.Add($"//{memberName}");
                                            newClass.MarshalToStatements.Add($"if (this.{memberName} != null)");
                                            newClass.MarshalToStatements.Add("{");
                                            newClass.MarshalToStatements.Add($"    result.{memberName} = ({memberType.Name}*)Interop.HeapUtil.Allocate<uint>(this.{memberName}.Length).ToPointer();");
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
                                        else
                                        {
                                            newClass.MarshalToStatements.Add(string.Format("result.{0} = this.{0} == null ? null : Interop.HeapUtil.MarshalTo(this.{0});", memberName));
                                        }
                                    }

                                    if (member.Dimensions[0].Value != null)
                                    {
                                        lenMembers.Add(member.Dimensions[0].Value);
                                    }

                                    break;
                            }
                        }
                    }
                    else if (member.VkName == "sType"
                                || member.VkName == "pNext"
                                || memberType.Data.Category == TypeCategory.funcpointer)
                    {
                        // These fields are not to be exposed to the public API
                        // as they are either not supported or have pre-defined
                        // values

                        memberDesc.IsInteropOnly = true;

                        if (member.VkName == "sType")
                        {
                            newClass.MarshalToStatements.Add(string.Format("result.SType = StructureType.{0};", type.Name));
                        }
                    }
                    else if (isPointer && memberDesc.PublicTypeName == "void")
                    {
                        memberDesc.PublicTypeName = "IntPtr";

                        newClass.MarshalToStatements.Add(string.Format("result.{0} = this.{0}.ToPointer();", memberDesc.Name));
                        newClass.MarshalFromStatements.Add(string.Format("result.{0} = new IntPtr(value->{0});", memberDesc.Name));
                    }
                    else if (memberType.Data.Category == TypeCategory.handle)
                    {
                        newClass.MarshalToStatements.Add(string.Format("result.{0} = this.{0}?.Pack() ?? Interop.{1}.Null;", memberDesc.Name, memberDesc.InteropTypeName));
                    }
                    else if (isPointer && memberType.RequiresInterop)
                    {
                        newClass.MarshalToStatements.Add(string.Format("result.{0} = this.{0} == null ? null : this.{0}.MarshalTo();", memberDesc.Name));
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
                            fixedLengthValue = "(int)Constants." + GetNameForElement(spec.Constants[member.FixedLength.Value]);
                        }

                        if (member.Type == "char")
                        {
                            memberDesc.PublicTypeName = "string";

                            newClass.MarshalFromStatements.Add(string.Format("result.{0} = System.Text.Encoding.UTF8.GetString(Interop.HeapUtil.MarshalFrom(value->{0}, {1})).TrimEnd((char)0);", memberDesc.Name, fixedLengthValue));
                        }
                        else if (memberDesc.Name.EndsWith("UUID"))
                        {
                            memberDesc.PublicTypeName = "Guid";

                            newClass.MarshalFromStatements.Add(string.Format("result.{0} = new Guid(Interop.HeapUtil.MarshalFrom(value->{0}, {1}));", memberDesc.Name, fixedLengthValue));
                        }
                        else
                        {
                            if (memberType.IsPrimitive)
                            {
                                newClass.MarshalFromStatements.Add(string.Format("result.{0} = Interop.HeapUtil.MarshalFrom(value->{0}, {1});", memberDesc.Name, fixedLengthValue));
                            }
                            else
                            {
                                string pointerVarName = memberDesc.Name + "Pointer";

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
                                    memberDesc.InteropNameSuffix = "[(int)Constants." + GetNameForElement(spec.Constants[member.FixedLength.Value]) + "]";
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

                            if (memberNameLookup.ContainsKey(lenMember))
                            {
                                lenMembers.Add(lenMember);
                            }
                        }
                    }
                    else
                    {
                        memberDesc.IsSimpleMarshal = true;
                    }

                    if (memberDesc.Name.EndsWith("Version") && memberDesc.PublicTypeName == "uint")
                    {
                        memberDesc.PublicTypeName = "Version";
                    }
                    else if (memberDesc.PublicTypeName == "DeviceSize")
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

                foreach (var memberName in lenMembers)
                {
                    members[memberName].IsInteropOnly = true;
                }

                foreach (var member in members.Values.Where(x => !x.IsInteropOnly))
                {
                    newClass.Properties.Add(new TypeSet.VkClassProperty
                    {
                        Name = member.Name,
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
        }

        private static void GenerateUnions(Dictionary<string, TypeDesc> typeData, TypeSet result)
        {
            foreach (var type in typeData.Values.Where(x => x.Data.Category == TypeCategory.union))
            {
                var newStruct = new TypeSet.VkStruct
                {
                    Name = type.Name
                };

                foreach (var member in type.Data.Members)
                {
                    switch (member.FixedLength.Type)
                    {
                        case SpecParser.FixedLengthType.None:
                            newStruct.Members.Add(new TypeSet.VkStructMember
                            {
                                Name = JoinNameParts(member.NameParts),
                                TypeName = typeData[GetMemberTypeName(member)].Name,
                                FieldOffset = "0"
                            });
                            break;
                        case SpecParser.FixedLengthType.EnumReference:
                            throw new NotSupportedException("Fixed-length arrays with named lengths are not currently supported in Unions.");
                        case SpecParser.FixedLengthType.IntegerLiteral:
                            int length = int.Parse(member.FixedLength.Value);

                            for (int index = 0; index < length; index++)
                            {
                                var nameParts = member.NameParts.Concat(new[] { "_", index.ToString() });
                                string typeName = typeData[GetMemberTypeName(member)].Name;

                                newStruct.Members.Add(new TypeSet.VkStructMember
                                {
                                    Name = JoinNameParts(nameParts),
                                    TypeName = typeName,
                                    FieldOffset = string.Format("sizeof({0}) * {1}", typeName, index)
                                });
                            }

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
                        type.Name = "IntPtr";
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
                    Name = type.Name
                };

                foreach (var member in type.Data.Members)
                {
                    newStruct.Members.Add(new TypeSet.VkStructMember
                    {
                        Name = JoinNameParts(member.NameParts),
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

        private static void GenerateEnumerations(SpecParser.ParsedSpec spec, Dictionary<string, TypeDesc> typeData, TypeSet result)
        {
            var enumerationTypes = typeData.Values.Where(x => x.Data.Category == TypeCategory.@enum).ToDictionary(x => x.Data.VkName);

            foreach (var type in typeData.Values.Where(x => x.Data.Category == TypeCategory.bitmask))
            {

                var newEnumeration = new TypeSet.VkEnumeration
                {
                    Name = type.Name,
                    IsFlags = true
                };

                if (type.Data.Requires != null)
                {
                    enumerationTypes.Remove(type.Data.Requires);

                    var enumeration = spec.Enumerations[type.Data.Requires];

                    // Add a zero-valued None field for bitmasks (if not already defined)
                    // so API users don't have to typecast zero when no flags are required
                    if (!enumeration.Fields.Values.Any(x => x.Value == "0" && !x.IsBitmask))
                    {
                        PopulateNoneField(newEnumeration);
                    }

                    PopulateFields(newEnumeration, enumeration);
                }
                else
                {
                    PopulateNoneField(newEnumeration);
                }

                result.Enumerations.Add(newEnumeration);
            }

            foreach (var type in enumerationTypes.Values)
            {
                var newEnumeration = new TypeSet.VkEnumeration
                {
                    Name = type.Name
                };

                var enumeration = spec.Enumerations[type.Data.VkName];

                PopulateFields(newEnumeration, enumeration);

                result.Enumerations.Add(newEnumeration);
            }
        }

        private static void PopulateNoneField(TypeSet.VkEnumeration newEnumeration)
        {
            newEnumeration.Fields.Add(new TypeSet.VkEnumerationField
            {
                Name = "None",
                Value = "0"
            });
        }

        private static void PopulateFields(TypeSet.VkEnumeration newEnumeration, SpecParser.ParsedEnum enumeration)
        {
            string digitsPrefix = JoinNameParts(enumeration.NameParts.TakeWhile(x => !digitsSuffix.Contains(x)));

            foreach (var field in enumeration.Fields.Values)
            {
                string fieldName = GetNameForElement(field, field.IsBitmask ? 1 : 0);

                if (!char.IsLetter(fieldName[0]))
                {
                    fieldName = digitsPrefix + fieldName;
                }

                newEnumeration.Fields.Add(new TypeSet.VkEnumerationField
                {
                    Name = fieldName,
                    Value = field.IsBitmask ? "1 << " + field.Value : field.Value
                });
            }
        }

        private static void GenerateConstants(SpecParser.ParsedSpec spec, TypeSet result)
        {
            foreach (var constant in spec.Constants.Values)
            {
                Type type;

                string typeSuffix = new string(constant.Value.Reverse()
                                                                .TakeWhile(char.IsLetter)
                                                                .Reverse()
                                                                .ToArray());

                switch (typeSuffix.ToLower())
                {
                    case "f":
                        type = typeof(float);
                        break;
                    case "u":
                    default:
                        type = typeof(uint);
                        break;
                    case "ul":
                        type = typeof(ulong);
                        break;
                }

                result.Constants.Add(new TypeSet.VkConstant
                {
                    Name = GetNameForElement(constant),
                    Type = type,
                    Value = constant.Value
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
                    Value = $"{enumName}.{errorFieldName}"
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

        private static string GetNameForElement(SpecParser.ParsedElement element, int trimFromEnd = 0)
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

        private static string JoinNameParts(IEnumerable<string> parts, bool camelCase = false)
        {
            return parts.Select(ExpandAbbreviations)
                        .Select((x, y) => (camelCase && y == 0) ? x : CapitaliseFirst(x))
                        .Aggregate(new StringBuilder(), (builder, value) => builder.Append(value))
                        .ToString();
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
                default:
                    return value;
            }
        }

        private static string CapitaliseFirst(string value)
        {
            var charArray = value.ToCharArray();

            charArray[0] = char.ToUpper(charArray[0]);

            return new string(charArray);
        }

        private class TypeDesc
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
        }
    }
}