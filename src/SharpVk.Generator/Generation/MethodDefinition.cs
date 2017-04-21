using SharpVk.Emit;
using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class MethodDefinition
    {
        public string ReturnType;
        public string Name;
        public bool IsUnsafe;
        public bool IsStatic;
        public List<ParamActionDefinition> ParamActions;
        public List<Action> MemberActions;
    }
}
