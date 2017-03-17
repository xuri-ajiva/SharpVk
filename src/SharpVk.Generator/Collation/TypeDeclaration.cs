using System.Collections.Generic;

namespace SharpVk.Generator.Collation
{
    public class TypeDeclaration
    {
        public string VkName;
        public string Name;
        public bool RequiresMarshalling;
        public bool IsPrimitive;
        public TypeCategory Category;
        public List<MemberDeclaration> Members;
    }
}
