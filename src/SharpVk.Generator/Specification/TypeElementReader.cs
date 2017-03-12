using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Specification
{
    public class TypeElementReader
    {
        private readonly IVkXmlCache xmlCache;
        private readonly IEnumerable<ITypeExtensionRule> typeExtensions;

        public TypeElementReader(IVkXmlCache xmlCache, IEnumerable<ITypeExtensionRule> typeExtensions)
        {
            this.xmlCache = xmlCache;
            this.typeExtensions = typeExtensions;
        }

        public void ReadTo(IServiceCollection target)
        {
            foreach (var vkType in this.xmlCache.GetVkXml().Element("registry").Element("types").Elements("type"))
            {
                string name = vkType.Attribute("name")?.Value ?? vkType.Element("name").Value;
                Enum.TryParse(vkType.Attribute("category")?.Value, out TypeCategory category);
                string requires = vkType.Attribute("requires")?.Value;
                string parent = vkType.Attribute("parent")?.Value;
                bool.TryParse(vkType.Attribute("returnedonly")?.Value, out bool isReturnedOnly);
                bool isTypePointer = false;

                string type = vkType.Element("type")?.Value;

                if (type == "VK_MAKE_VERSION")
                {
                    type += vkType.Element("type").NextNode.ToString();
                }

                if (parent != null)
                {
                    parent = parent.Split(',').First();
                }

                var newType = new TypeElement
                {
                    VkName = name,
                    Category = category,
                    Requires = requires,
                    Parent = parent,
                    IsReturnedOnly = isReturnedOnly,
                    Type = type,
                    IsTypePointer = isTypePointer
                };

                var extension = this.typeExtensions.FirstOrDefault(x => x.CanApply(vkType, newType));

                extension?.Apply(vkType, newType, target);

                target.AddSingleton(newType);
            }
        }
    }
}
