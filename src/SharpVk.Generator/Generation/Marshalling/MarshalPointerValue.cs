namespace SharpVk.Generator.Generation.Marshalling
{
    public class MarshalPointerValue
        : IMarshalValueRule
    {
        private readonly NameLookup nameLookup;

        public MarshalPointerValue(NameLookup nameLookup)
        {
            this.nameLookup = nameLookup;
        }

        public bool Apply(TypeReference type, out MarshalInfo info)
        {
            if (type.PointerType.IsPointer())
            {
                info = new MarshalInfo
                {
                    MemberType = this.nameLookup.Lookup(type, false),
                    InteropType = this.nameLookup.Lookup(type, false),
                    MarshalToActionType = MemberActionType.AllocAndAssign,
                    BuildMarshalToValueExpression = value => value,
                    BuildMarshalFromValueExpression = value => value
                };

                return true;
            }
            else
            {
                info = new MarshalInfo();

                return false;
            }
        }
    }
}
