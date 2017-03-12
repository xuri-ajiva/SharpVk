namespace SharpVk.Generator.Specification.Elements
{
    public class MemberElement
        : SpecElement
    {
        public bool IsOptional;
        public FixedLengthDeclaration FixedLength;
        public ParsedLen[] Dimensions;
        public PointerType PointerType;
        public string Values;
    }
}
