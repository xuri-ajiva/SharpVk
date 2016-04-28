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
            {"size_t", "UIntPtr"}
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

            GenerateEnumerations(spec, typeData, result);

            GenerateUnions(typeData, result);

            GenerateNonInteropStructs(typeData, result);

            GenerateClasses(typeData, result);

            var handleLookup = GenerateHandles(typeData, result);

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

                var handleParams = command.Params.TakeWhile(x => typeData[x.Type].Data.Category == TypeCategory.handle);

                var lastParam = command.Params.Last();

                bool lastParamReturns = false;

                if (typeData[lastParam.Type].Data.Category == TypeCategory.handle && lastParam.PointerType == PointerType.Pointer)
                {
                    lastParamReturns = true;
                }

                var handle = handleParams.Any()
                                ? handleLookup[handleParams.Last().Type]
                                : handleLookup[command.Params.Last().Type];

                var newMethod = new TypeSet.VkHandleMethod
                {
                    Name = JoinNameParts(command.NameParts),
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
                        newMethod.Parameters.Add(new TypeSet.VkMethodParam
                        {
                            ParamType = TypeSet.VkMethodParamType.ParentHandle
                        });
                    }

                    newMethod.Parameters.Add(new TypeSet.VkMethodParam
                    {
                        ParamType = TypeSet.VkMethodParamType.ThisHandle
                    });
                }

                int parameterIndex = 0;

                foreach (var parameter in command.Params)
                {
                    var nameParts = parameter.NameParts.AsEnumerable();
                    int pointerCount = parameter.PointerType.GetPointerCount();

                    if (pointerCount > 0)
                    {
                        nameParts = nameParts.Skip(1);
                    }

                    string paramName = JoinNameParts(nameParts, true);
                    var paramType = typeData[GetMemberTypeName(parameter)];

                    string marshalledName = "marshalled" + CapitaliseFirst(paramName);

                    if (keywords.Contains(paramName))
                    {
                        paramName = "@" + paramName;
                    }

                    string interopTypeName = ApplyPointerType(parameter, paramType.Name);

                    newCommand.Parameters.Add(new TypeSet.VkCommandParameter
                    {
                        Name = paramName,
                        TypeName = interopTypeName
                    });

                    if (parameterIndex >= handleParams.Count())
                    {
                        Console.WriteLine(paramName);

                        if (lastParamReturns && parameterIndex == command.Params.Count() - 1)
                        {
                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                ArgumentName = "&" + marshalledName,
                                TypeName = paramType.Name,
                                ParamType = TypeSet.VkMethodParamType.Result
                            });

                            newMethod.ReturnTypeName = paramType.Name;

                            newMethod.MarshalToStatements.Add(string.Format("Interop.{0} {1};", paramType.Name, marshalledName));
                            newMethod.MarshalFromStatements.Add(string.Format("result = new {0}({1});", paramType.Name, marshalledName));
                        }
                        else if(paramType.RequiresInterop)
                        {
                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                Name = paramName,
                                ArgumentName = string.Format("{1} == null ? null : &{0}", marshalledName, paramName),
                                TypeName = paramType.Name,
                                ParamType = TypeSet.VkMethodParamType.Passthrough
                            });

                            newMethod.MarshalToStatements.Add(string.Format("Interop.{0} {1};", paramType.Name, marshalledName));
                            newMethod.MarshalToStatements.Add(string.Format("if({1} != null) {0} = {1}.Pack();", marshalledName, paramName));
                        }
                        else
                        {
                            newMethod.Parameters.Add(new TypeSet.VkMethodParam
                            {
                                Name = paramName,
                                ArgumentName = paramName,
                                TypeName = paramType.Name,
                                ParamType = TypeSet.VkMethodParamType.Passthrough
                            });
                        }
                    }

                    parameterIndex++;
                }

                result.Commands.Add(newCommand);

                handle.Methods.Add(newMethod);
            }
        }


        private static string GetFormattedTypeName(Dictionary<string, TypeDesc> typeData, SpecParser.ParsedElement element)
        {
            return typeData[GetMemberTypeName(element)].Name;
        }

        private static Dictionary<string, TypeSet.VkHandle> GenerateHandles(Dictionary<string, TypeDesc> typeData, TypeSet result)
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

            return handleLookup;
        }

        private static void GenerateClasses(Dictionary<string, TypeDesc> typeData, TypeSet result)
        {
            foreach (var type in typeData.Values.Where(x => x.RequiresInterop))
            {
                var newStruct = new TypeSet.VkStruct
                {
                    Name = type.Name
                };

                var newClass = new TypeSet.VkClass
                {
                    Name = type.Name
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
                        InteropTypeName = ApplyPointerType(member, memberType.Name),
                        PublicTypeName = memberType.Name
                    };

                    bool isPointer = member.PointerType.IsPointer();

                    if (member.Dimensions != null)
                    {
                        if (member.Dimensions.Length > 1)
                        {
                            // Assume that 2-dimensional arrays are string[]
                            Debug.Assert(member.Type == "char");

                            memberDesc.PublicTypeName = "string[]";

                            var lenMember = member.Dimensions[0].Value;

                            lenMembers.Add(lenMember);

                            newClass.MarshalStatements.Add(string.Format("result.{0} = this.{1} == null ? 0 : (uint)this.{1}.Length;", memberNameLookup[lenMember], memberDesc.Name));
                            newClass.MarshalStatements.Add(string.Format("result.{0} = this.{0} == null ? null : Interop.HeapUtil.MarshalTo(this.{0});", memberDesc.Name));
                        }
                        else
                        {
                            switch (member.Dimensions[0].Type)
                            {
                                case SpecParser.LenType.NullTerminated:
                                    memberDesc.PublicTypeName = "string";

                                    newClass.MarshalStatements.Add(string.Format("result.{0} = Interop.HeapUtil.MarshalTo(this.{0});", memberDesc.Name));
                                    break;
                                case SpecParser.LenType.Expression:

                                    if (isPointer && memberDesc.PublicTypeName == "void")
                                    {
                                        memberDesc.PublicTypeName = "IntPtr";
                                    }
                                    else
                                    {
                                        memberDesc.PublicTypeName += "[]";
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
                        memberDesc.IsInteropOnly = true;

                        if (member.VkName == "sType")
                        {
                            newClass.MarshalStatements.Add(string.Format("result.SType = StructureType.{0};", type.Name));
                        }
                    }
                    else if (isPointer && memberDesc.PublicTypeName == "void")
                    {
                        memberDesc.PublicTypeName = "IntPtr";

                        newClass.MarshalStatements.Add(string.Format("result.{0} = this.{0}.ToPointer();", memberDesc.Name));
                    }
                    else if (memberType.Data.Category == TypeCategory.handle || isPointer)
                    {
                        string nullString = isPointer ? "null" : string.Format("Interop.{0}.Null", memberDesc.InteropTypeName);

                        newClass.MarshalStatements.Add(string.Format("result.{0} = this.{0} == null ? {1} : this.{0}.MarshalTo();", memberDesc.Name, nullString));
                    }
                    else if (memberType.RequiresInterop)
                    {
                    }
                    else if (memberDesc.Name.EndsWith("Version") && memberDesc.PublicTypeName == "uint")
                    {
                        memberDesc.PublicTypeName = "Version";
                        memberDesc.IsSimpleMarshal = true;
                    }
                    else if (memberDesc.PublicTypeName == "DeviceSize")
                    {
                        memberDesc.PublicTypeName = "ulong";
                        memberDesc.IsSimpleMarshal = true;
                    }
                    else
                    {
                        memberDesc.IsSimpleMarshal = true;
                    }

                    newStruct.Members.Add(new TypeSet.VkStructMember
                    {
                        Name = memberDesc.Name,
                        TypeName = memberDesc.InteropTypeName
                    });

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
                        newClass.MarshalStatements.Add(string.Format("result.{0} = this.{0};", member.Name));
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
            string memberTypeName = member.Type;

            if (memberTypeName.EndsWith("Bits"))
            {
                // Some struct members incorrectly reference the
                // "*FlagBits" enum name, rather than the "Flags"
                // type name. Quietly fix that here.

                memberTypeName = memberTypeName.Replace("FlagBits", "Flags");
            }

            return memberTypeName;
        }

        private static string ApplyPointerType(SpecParser.ParsedPointerElement member, string memberTypeName)
        {
            return memberTypeName + new string('*', member.PointerType.GetPointerCount());
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

        private static Dictionary<string, TypeDesc> GetTypeData(SpecParser.ParsedSpec spec)
        {
            var typeData = spec.Types.Values.ToDictionary(x => x.VkName, x => new TypeDesc
            {
                Data = x,
                Name = GetNameForElement(x),
                RequiresInterop = RequiresInterop(spec, x)
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
            public string Name;
        }

        private class MemberDesc
        {
            public string Name;
            public bool IsInteropOnly;
            public bool IsSimpleMarshal;
            public string InteropTypeName;
            public string PublicTypeName;
            public List<string> MarshalStatements = new List<string>();
        }
    }
}