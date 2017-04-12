using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class StructDefinition
    {
        public string Name;
        public bool IsInterop;
        public MethodDefinition Constructor;
        public List<MemberDefinition> Members;
    }
}
