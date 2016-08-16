using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq.Hlsl
{
    public class CastExpression
        : IRightHandShaderExpression
    {
        public CastExpression(ShaderType type, IRightHandShaderExpression expression)
        {
            this.ShaderType = type;
            this.Expression = expression;
        }

        public ShaderType ShaderType
        {
            get;
            private set;
        }

        public IRightHandShaderExpression Expression
        {
            get;
            private set;
        }

        public IEnumerable<IShaderExpression> Expressions
        {
            get
            {
                return new[] { this.Expression };
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
            return string.Format("({0})({1})",
                                    this.ShaderType.TypeToken,
                                    info.Format(this.Expression));
        }
    }
}
