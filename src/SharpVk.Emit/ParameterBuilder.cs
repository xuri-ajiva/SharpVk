using System;
using System.Collections.Generic;

namespace SharpVk.Emit
{
    public class ParameterBuilder
    {
        private List<string> parameters = new List<string>();

        public void EmitParam(string type, string name)
        {
            this.parameters.Add($"{type} {name}");
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