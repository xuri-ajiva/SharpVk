using System.Collections.Generic;

namespace SharpVk.Shanq
{
    public interface IVertexShader
    {
        IEnumerable<IAssignStatement> Statements
        {
            get;
        }
    }
}