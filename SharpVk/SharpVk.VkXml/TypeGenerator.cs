using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.VkXml
{
    public class TypeGenerator
    {
        public TypeSet Generate(SpecParser.ParsedSpec spec)
        {
            var typeData = GetTypeData(spec);

            var result = new TypeSet();

            GenerateConstants(spec, result);

            GenerateEnumerations(spec, typeData, result);

            foreach (var type in typeData.Values.Where(x => x.RequiresInterop))
            {
            }

            return result;
        }

        private static void GenerateEnumerations(SpecParser.ParsedSpec spec, Dictionary<string, TypeDesc> typeData, TypeSet result)
        {
            var enumerationTypes = typeData.Values.Where(x => x.Data.Category == TypeCategory.@enum).ToDictionary(x => x.Data.VkName);

            foreach (var type in typeData.Values.Where(x => x.Data.Category == TypeCategory.bitmask))
            {
                if (type.Data.Requires != null)
                {
                    enumerationTypes.Remove(type.Data.Requires);

                    var newEnumeration = new TypeSet.VkEnumeration
                    {
                        Name = type.Name,
                        IsFlags = true
                    };

                    var enumeration = spec.Enumerations[type.Data.Requires];
                    
                    // Add a zero-valued None field for bitmasks (if not already defined)
                    // so API users don't have to typecast zero when no flags are required
                    if (!enumeration.Fields.Values.Any(x => x.Value == "0" && !x.IsBitmask))
                    {
                        newEnumeration.Fields.Add(new TypeSet.VkEnumerationField
                        {
                            Name = "None",
                            Value = "0"
                        });
                    }

                    PopulateFields(newEnumeration, enumeration);

                    result.Enumerations.Add(newEnumeration);
                }
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

        private static readonly string[] digitsSuffix = new[] { "flags", "type", "bits" };

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
                RequiresInterop = x.Members.Any(y => y.FixedLength.Type != SpecParser.FixedLengthType.None
                                                            || (y.PointerType != PointerType.Value && y.PointerType != PointerType.ConstValue))
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