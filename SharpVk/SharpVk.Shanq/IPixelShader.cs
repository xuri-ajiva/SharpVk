using System.Collections.Generic;

namespace SharpVk.Shanq
{
    public interface IPixelShader
    {
        IEnumerable<IAssignStatement> Statements
        {
            get;
        }
    }
}