using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation
{
    public class ParamDefinition
    {
        public string Name;
        public string Type;
        public Action<ExpressionBuilder> DefaultValue;
    }
}
