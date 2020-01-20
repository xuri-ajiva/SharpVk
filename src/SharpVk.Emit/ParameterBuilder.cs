using System;
using System.Collections.Generic;
using System.IO;

namespace SharpVk.Emit
{
    public class ParameterBuilder
    {
        private List<string> parameters = new List<string>();

        public void EmitParam(string type, string name, bool isOut = false, Action<ExpressionBuilder> defaultValue = null)
        {
            var writer = new StringWriter();
            var defaultExpression = new ExpressionBuilder(new IndentedTextWriter(writer));
            defaultValue?.Invoke(defaultExpression);

            this.parameters.Add($"{(isOut ? "out " : "")}{type} {name}{(defaultValue != null ? " = " + writer.ToString() : "")}");
        }

        public override string ToString()
        {
            return string.Join(", ", this.parameters);
        }

        public static string Apply(Action<ParameterBuilder> parametersAction)
        {
            var builder = new ParameterBuilder();

            parametersAction(builder);

            return builder.ToString();
        }
    }
}