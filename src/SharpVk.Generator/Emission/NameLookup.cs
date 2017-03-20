using SharpVk.Generator.Generation;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Emission
{
    public class NameLookup
    {
        private readonly Dictionary<string, string> nameMapping;

        public NameLookup(IEnumerable<TypeNameMapping> nameMappings)
        {
            this.nameMapping = nameMappings.ToDictionary(x => x.VkName, x => x.OutputName);
        }

        public string Lookup(string vkName)
        {
            return this.nameMapping[vkName];
        }
    }
}
