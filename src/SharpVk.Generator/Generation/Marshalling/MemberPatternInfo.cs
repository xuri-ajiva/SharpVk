namespace SharpVk.Generator.Generation.Marshalling
{
    public class MemberPatternInfo
    {
        public StructDefinition PublicStruct;
        public StructDefinition InteropStruct;
        public MethodDefinition MarshalTo;
        public MethodDefinition MarshalFrom;
    }
}