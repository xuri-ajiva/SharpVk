using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq.Hlsl
{
    public class CreateVectorExpression
        : IRightHandShaderExpression
    {
        public CreateVectorExpression(ShaderType vectorType, params IRightHandShaderExpression[] arguments)
        {
            this.ShaderType = vectorType;
            this.Arguments = arguments;
        }

        public IEnumerable<IRightHandShaderExpression> Arguments
        {
            get;
            private set;
        }

        public ShaderType ShaderType
        {
            get;
            private set;
        }

        public IEnumerable<IShaderExpression> Expressions
        {
            get
            {
                return this.Arguments;
            }
        }

        public bool IsTrivial
        {
            get
            {
                return false;
            }
        }

        public string Format(IShaderFormatInfo info)
        {
            return string.Format("{0}({1})", this.ShaderType.TypeToken, string.Join(", ", this.Arguments.Select(info.Format)));
        }
    }
}
