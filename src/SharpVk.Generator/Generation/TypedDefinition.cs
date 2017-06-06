using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation
{
    public struct TypedDefinition
    {
        public string Name;
        public string Type;
        public Action<ExpressionBuilder> DefaultValue;
        public int? Repeats;
    }
}
