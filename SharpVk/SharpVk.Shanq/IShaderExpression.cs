using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.Shanq
{
    public interface IShaderExpression
        : IShaderPart
    {
        IEnumerable<IShaderExpression> Expressions { get; }

        bool IsTrivial { get; }
    }
}
