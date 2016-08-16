using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq.Hlsl
{
    public class FunctionExpression
        : IRightHandShaderExpression
    {
        public FunctionExpression(IntrinsicFunction function, params IRightHandShaderExpression[] arguments)
        {
            this.Function = function;
            this.Arguments = arguments;
            this.ShaderType = GetReturnType(function, arguments);
        }

        public IntrinsicFunction Function
        {
            get;
            private set;
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
            return string.Format("{0}({1})", GetFunctionName(this.Function), string.Join(", ", this.Arguments.Select(info.Format)));
        }

        public static string GetFunctionName(IntrinsicFunction function)
        {
            switch (function)
            {
                case IntrinsicFunction.Multiply:
                    return "mul";
                default:
                    throw new NotSupportedException();
            }
        }

        private static ShaderType GetReturnType(IntrinsicFunction function, IRightHandShaderExpression[] arguments)
        {
            switch (function)
            {
                case IntrinsicFunction.Multiply:
                    return arguments.First().ShaderType;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
