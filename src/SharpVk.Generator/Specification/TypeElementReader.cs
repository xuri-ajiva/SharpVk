using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.Generator.Specification
{
    public class TypeElementReader
    {
        private readonly IVkXmlCache xmlCache;

        public TypeElementReader(IVkXmlCache xmlCache)
        {
            this.xmlCache = xmlCache;
        }

        public void ReadTo(IServiceCollection target)
        {
            foreach (var vkType in this.xmlCache.GetVkXml().Element("registry").Element("types").Elements("type"))
            {
                string name = vkType.Attribute("name")?.Value ?? vkType.Element("name").Value;
                var categoryAttribute = vkType.Attribute("category");
                TypeCategory category = categoryAttribute == null
                                                            ? TypeCategory.None
                                                            : (TypeCategory)Enum.Parse(typeof(TypeCategory), categoryAttribute.Value);
                string requires = vkType.Attribute("requires")?.Value;
                string parent = vkType.Attribute("parent")?.Value;
                string returnedOnly = vkType.Attribute("returnedonly")?.Value;
                bool isReturnedOnly = returnedOnly != null
                                        ? bool.Parse(returnedOnly)
                                        : false;
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

                target.AddSingleton(newType);
            }
        }
    }
}
