using SharpVk.Generator.Collation;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class ArrayMemberPattern
        : IMemberPatternRule
    {
        public bool Apply(MemberDeclaration member, StructDefinition publicStruct, Action<Action> addAction)
        {
            if (member.Dimensions != null)
            {
                if(member.Dimensions.Length == 1)
                {
                    switch(member.Dimensions[0].Type)
                    {
                        case LenType.NullTerminated:
                            //memberDesc.PublicTypeName = "string";

                            //newClass.MarshalToStatements.Add(string.Format("pointer->{0} = Interop.HeapUtil.MarshalTo(this.{0});", memberName));
                            //newClass.MarshalFromStatements.Add(string.Format("result.{0} = Interop.HeapUtil.MarshalFrom(value->{0});", memberName));
                            break;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
