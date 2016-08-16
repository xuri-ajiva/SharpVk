using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq.Hlsl
{
    public class VertexShader
        : IVertexShader
    {
        public VertexShader(params IAssignStatement[] statements)
        {
            this.Statements = statements;
        }

        public IEnumerable<IAssignStatement> Statements
        {
            get;
            private set;
        }
    }
}
