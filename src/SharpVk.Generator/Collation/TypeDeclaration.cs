using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Collation
{
    public class TypeDeclaration
    {
        public string VkName;
        public string Name;
        public TypePattern Pattern;
        public List<MemberDeclaration> Members;

        public bool RequiresMarshalling => this.Pattern.RequiresMarshalling() || this.Members.Any(x => x.RequiresMarshalling);
    }
}
