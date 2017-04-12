using SharpVk.Generator.Collation;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class NameLookup
    {
        private readonly Dictionary<string, string> nameMapping;
        private readonly Dictionary<string, TypeDeclaration> typeData;

        public NameLookup(IEnumerable<TypeNameMapping> nameMappings, Dictionary<string, TypeDeclaration> typeData)
        {
            this.nameMapping = nameMappings.GroupBy(x => x.VkName)
                                            .Select(x => x.OrderByDescending(y => y.Priority).First())
                                            .ToDictionary(x => x.VkName, x => x.OutputName);
            this.typeData = typeData;
        }

        public string Lookup(string vkName)
        {
            return this.nameMapping[vkName];
        }

        public string Lookup(TypeReference type, bool isInterop)
        {
            if (isInterop && typeData[type.VkName].Pattern == TypePattern.Delegate)
            {
                return "IntPtr";
            }

            var baseName = this.nameMapping[type.VkName];

            return baseName + new string('*', type.PointerType.GetPointerCount());
        }
    }
}
