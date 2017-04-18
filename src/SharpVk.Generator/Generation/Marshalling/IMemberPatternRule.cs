using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public interface IMemberPatternRule
        : IRule<MemberDeclaration, StructDefinition, Action<Action>>
    {
    }
}
