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

            foreach (var type in typeData.Values.Where(x => x.RequiresInterop))
            {
            }

            return result;
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

        private static string GetNameForElement(SpecParser.ParsedElement element)
        {
            return element.NameParts?.Select(CapitaliseFirst)
                                    ?.Aggregate(new StringBuilder(), (builder, value) => builder.Append(value))
                                    ?.ToString()
                                    ?? element.VkName;
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