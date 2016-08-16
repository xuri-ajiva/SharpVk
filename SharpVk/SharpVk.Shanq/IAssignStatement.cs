using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.Shanq
{
    public interface IAssignStatement
        : IShaderStatement
    {
        ILeftHandShaderExpression Target
        {
            get;
        }

        IRightHandShaderExpression Source
        {
            get;
        }
    }
}
