using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public interface IMemberPatternRule
        : IRule<TypeDeclaration, MemberDeclaration, StructDefinition, Action<Action>>
    {
    }
}
