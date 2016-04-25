using System;
using System.Collections.Generic;
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

        private static readonly string[] digitsSuffix = new[] { "flags", "type", "bits" };

        public TypeSet Generate(SpecParser.ParsedSpec spec)
        {
            var typeData = GetTypeData(spec);

            var result = new TypeSet();

            SetPrimitiveTypeNames(typeData);

            GenerateConstants(spec, result);

            GenerateEnumerations(spec, typeData, result);

            GenerateUnions(typeData, result);

            GenerateNonInteropStructs(typeData, result);

            foreach (var type in typeData.Values.Where(x => x.RequiresInterop))
            {
            }

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
            }

            return result;
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
                if (type.Data.Category == TypeCategory.None)
                {
                    type.Name = primitiveTypes[type.Data.VkName];
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

        private static string GetMemberTypeName(SpecParser.ParsedMember member)
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

        private static string JoinNameParts(IEnumerable<string> parts)
        {
            return parts.Select(CapitaliseFirst)
                        .Aggregate(new StringBuilder(), (builder, value) => builder.Append(value))
                        .ToString();
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
    }
}