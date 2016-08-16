using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq
{
    public class InputStructureReferenceExpression
        : IRightHandShaderExpression
    {
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

        public ShaderType ShaderType
        {
            get
            {
                return new ShaderType(typeof(object), "ShaderInput");
            }
        }

        public string Format(IShaderFormatInfo info)
        {
            return "input";
        }
    }
}
