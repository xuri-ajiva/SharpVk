using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Specification
{
    public class EnumElementReader
    {
        private readonly IVkXmlCache xmlCache;
        private readonly NameParser nameParser;

        public EnumElementReader(IVkXmlCache xmlCache, NameParser nameParser)
        {
            this.xmlCache = xmlCache;
            this.nameParser = nameParser;
        }

        public void ReadTo(IServiceCollection target)
        {
            foreach (var vkEnum in this.xmlCache.GetVkXml().Element("registry").Elements("enums"))
            {
                string name = vkEnum.Attribute("name").Value;
                string type = vkEnum.Attribute("type")?.Value;

                string extension = null;
                string[] nameParts = name == "API Constants"
                                        ? new[] { name }
                                        : this.nameParser.GetNameParts(name, out extension);

                var newEnum = new EnumElement
                {
                    VkName = name,
                    Type = type,
                    NameParts = nameParts,
                    Extension = extension
                };

                foreach (var vkField in vkEnum.Elements("enum"))
                {
                    string fieldName = vkField.Attribute("name").Value;
                    bool isBitmask = true;
                    string value = vkField.Attribute("bitpos")?.Value;
                    string comment = SimpleParser.NormaliseComment(vkField.Attribute("comment")?.Value);

                    if (value == null)
                    {
                        isBitmask = false;
                        value = vkField.Attribute("value").Value;

                        // Special case for mapping C "unsigned long long"
                        // (64-bit unsigned integer) to C# UInt64
                        if (value == "(~0ULL)")
                        {
                            value = "(~0UL)";
                        }

                        value = value.Trim('(', ')');
                    }

                    IEnumerable<string> fieldNameParts = this.nameParser.ParseEnumField(fieldName, nameParts);

                    newEnum.Fields.Add(fieldName, new EnumField
                    {
                        VkName = fieldName,
                        NameParts = fieldNameParts.ToArray(),
                        IsBitmask = isBitmask,
                        Value = value,
                        Comment = comment != null ? new List<string> { comment } : null
                    });
                }

                target.AddSingleton(newEnum);
            }
        }
    }
}
