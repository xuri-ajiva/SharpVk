using SharpVk.Emit;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Rules;
using System;
using System.Collections.Generic;

namespace SharpVk.Generator.Generation.Marshalling
{
    public interface IMemberPatternRule
        : IRule<IEnumerable<ITypedDeclaration>, ITypedDeclaration, Func<string, Action<ExpressionBuilder>>, MemberPatternInfo>
    {
    }
}
