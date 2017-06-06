using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class EnumDefinition
    {
        public string Name;
        public string[] Namespace;
        public bool IsFlags;
        public List<FieldDefinition> Fields;
    }
}
