using System.Collections.Generic;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class MemberPatternInfo
    {
        public TypedDefinition? Public;
        public TypedDefinition Interop;
        public List<Action> MarshalTo;
        public List<Action> MarshalFrom;
    }
}