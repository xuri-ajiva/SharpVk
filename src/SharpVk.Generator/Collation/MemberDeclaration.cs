namespace SharpVk.Generator.Collation
{
    public class MemberDeclaration
    {
        public string Name;
        public TypeReference Type;

        public bool RequiresMarshalling => this.Type.PointerType.IsPointer() || this.Type.FixedLength.Type != FixedLengthType.None;
    }
}
