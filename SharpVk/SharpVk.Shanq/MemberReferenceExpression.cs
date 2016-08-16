using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq
{
    public class MemberReferenceExpression
        : ILeftHandShaderExpression, IRightHandShaderExpression
    {
        private IShaderExpression expression;
        private string memberName;

        public MemberReferenceExpression(IShaderExpression expression, string memberName, ShaderType type)
        {
            this.expression = expression;
            this.memberName = memberName;
            this.ShaderType = type;
        }

        public IEnumerable<IShaderExpression> Expressions
        {
            get
            {
                yield return this.expression;
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
            get;
            private set;
        }

        public string Format(IShaderFormatInfo info)
        {
            return string.Format("({0}).{1}", info.Format(this.expression), this.memberName);
        }
    }
}
