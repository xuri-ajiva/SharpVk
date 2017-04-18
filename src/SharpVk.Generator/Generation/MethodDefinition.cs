using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class MethodDefinition
    {
        public string Name;
        public bool IsUnsafe;
        public List<ParamActionDefinition> ParamActions;
        public List<Action> MemberActions;
    }
}
