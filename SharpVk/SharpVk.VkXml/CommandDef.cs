using System.Collections.Generic;

namespace SharpVk.VkXml
{
    public class CommandDef
    {
        public string Name;
        public TypeDef Type;
        public List<ParamDef> Params = new List<ParamDef>();

        public class ParamDef
        {
            public string Name;
            public TypeDef Type;
            public int PointerCount;
        }
    }
}
