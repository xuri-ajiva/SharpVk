namespace SharpVk.Generator.Specification.Elements
{
    public class ChildElement
        : SpecElement
    {
        public bool IsOptional;
        public FixedLengthDeclaration FixedLength;
        public ParsedLen[] Dimensions;
        public PointerType PointerType;
    }
}
