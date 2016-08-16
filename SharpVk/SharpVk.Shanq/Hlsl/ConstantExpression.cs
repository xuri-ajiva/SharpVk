using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.Shanq.Hlsl
{
    public class ConstantExpression
        : IRightHandShaderExpression
    {
        public ConstantExpression(float value)
        {
            this.ShaderType = ShaderType.Float;
            this.ValueString = string.Format("{0:0.0##########}f", value);
        }

        public string ValueString
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
                return null;
            }
        }

        public bool IsTrivial
        {
            get
            {
                return true;
            }
        }

        public string Format(IShaderFormatInfo info)
        {
            return this.ValueString;
        }
    }
}
