using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;

namespace SharpVk.Generator.Generation.Marshalling
{
    public interface IMemberPatternRule
        : IRule<TypeDeclaration, MemberDeclaration, MemberPatternInfo>
    {
    }
}
