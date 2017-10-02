using GlmSharp;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace SharpVk.Shanq.GlmSharp
{
    public class VectorTypeLibrary
        : IVectorTypeLibrary
    {
        private readonly static Assembly glmSharpAssembly = typeof(mat4).Assembly;

        public readonly static VectorTypeLibrary Instance = new VectorTypeLibrary();

        public Type GetMatrixRowType(Type value)
        {
            return value.GetProperty("Row0").PropertyType;
        }

        public Type GetVectorElementType(Type value)
        {
            return value.GetField("x").FieldType;
        }

        public int GetVectorLength(Type value)
        {
            return ((IEnumerable)value.GetProperty("Zero")
                                .GetValue(null))
                                .OfType<object>()
                                .Count();
        }

        public int[] GetMatrixDimensions(Type value)
        {
            var identity = value.GetProperty("Identity")
                                .GetValue(null);

            var values = (float[,])value.GetProperty("Values")
                                        .GetValue(identity);

            return new[]
            {
                values.GetLength(0),
                values.GetLength(1)
            };
        }

        public bool IsVectorType(Type type)
        {
            return type.Assembly == glmSharpAssembly
                && type.Name.Contains("vec");
        }

        public bool IsMatrixType(Type type)
        {
            return type.Assembly == glmSharpAssembly
                && type.Name.Contains("mat");
        }
    }
}
