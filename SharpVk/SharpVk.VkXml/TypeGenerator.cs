using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.VkXml
{
    public class TypeGenerator
    {
        public void Generate(SpecParser.ParsedSpec spec)
        {
            var typeData = GetTypeData(spec);

            foreach (var type in typeData.Values.Where(x => x.RequiresInterop))
            {
                Console.WriteLine(type.Name);
            }
        }

        private static Dictionary<string, TypeDesc> GetTypeData(SpecParser.ParsedSpec spec)
        {
            var typeData = spec.Types.Values.ToDictionary(x => x.VkName, x => new TypeDesc
            {
                Data = x,
                Name = x.NameParts?.Select(CapitaliseFirst)
                                    ?.Aggregate(new StringBuilder(), (builder, value) => builder.Append(value))
                                    ?.ToString()
                                    ?? x.VkName,
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