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
        public List<MemberInfo> Members = new List<MemberInfo>();

        public class MemberInfo
        {
            public TypeDef Type;
            public string Name;
            public int PointerCount;
        }
    }
}