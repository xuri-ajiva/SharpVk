using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.Shanq.Hlsl
{
    public class AssignStatement
        : IAssignStatement
    {
        public AssignStatement(ILeftHandShaderExpression target, IRightHandShaderExpression source)
        {
            this.Target = target;
            this.Source = source;
        }

        public ILeftHandShaderExpression Target
        {
            get;
            private set;
        }

        public IRightHandShaderExpression Source
        {
            get;
            private set;
        }

        public string Format(IShaderFormatInfo info)
        {
            return string.Format("{0} = {1};",
                                    this.Target.Format(info),
                                    this.Source.Format(info));
        }
    }
}