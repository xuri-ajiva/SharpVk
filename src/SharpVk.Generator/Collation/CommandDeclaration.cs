using System.Collections.Generic;

namespace SharpVk.Generator.Collation
{
    public class CommandDeclaration
    {
        public string VkName;
        public string Name;
        public string Extension;
        public string HandleTypeName;
        public string ReturnType;
        public List<ParamDeclaration> Params;
    }
}
