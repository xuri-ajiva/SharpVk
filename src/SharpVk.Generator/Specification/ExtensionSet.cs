using System;
using System.Collections.Generic;

namespace SharpVk.Generator.Specification
{
    public class ExtensionSet
    {
        private IVkXmlCache xmlCache;
        private Lazy<IEnumerable<string>> knownExtensions;

        public ExtensionSet(IVkXmlCache xmlCache)
        {
            this.xmlCache = xmlCache;

            this.knownExtensions = new Lazy<IEnumerable<string>>(this.GetKnownExtensions);
        }

        private IEnumerable<string> GetKnownExtensions()
        {
            var result = new List<string>();

            foreach (var vkExtension in this.xmlCache.GetVkXml()
                                                        .Element("registry")
                                                        .Element("extensions")
                                                        .Elements("extension"))
            {
                string name = vkExtension.Attribute("name").Value;

                var nameParts = name.Split('_');

                string extensionSuffix = nameParts[1].ToLower();

                if (!result.Contains(extensionSuffix))
                {
                    result.Add(extensionSuffix);
                }
            }

            return result;
        }

        public IEnumerable<string> KnownExtensions => this.knownExtensions.Value;
    }
}
