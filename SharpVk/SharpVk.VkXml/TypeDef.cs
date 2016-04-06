using System.Collections.Generic;
using System.Xml.Linq;

namespace SharpVk.VkXml
{
    public class TypeDef
    {
        public Category Category;
        public string Name;
        public XElement Xml;
        public string Requires;
        public readonly List<MemberInfo> Members = new List<MemberInfo>();
        public bool IsPrimitive;
        public bool IsReturnedOnly;
        public bool IsSimpleStruct;
        public readonly List<TypeDef> Parents = new List<TypeDef>();

        public class MemberInfo
        {
            public TypeDef Type;
            public string VkName;
            public string Name;
            public IEnumerable<string> Len;
            public int PointerCount;
            public int Size;
        }
    }
}