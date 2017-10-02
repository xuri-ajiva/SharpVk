using System;
using System.Numerics;

namespace SharpVk.Shanq.Numerics
{
    public class VectorTypeLibrary
        : IVectorTypeLibrary
    {
        public readonly static VectorTypeLibrary Instance = new VectorTypeLibrary();

        public Type GetMatrixRowType(Type value)
        {
            return typeof(float);
        }

        public Type GetVectorElementType(Type value)
        {
            return typeof(float);
        }

        public int GetVectorLength(Type value)
        {
            if (value == typeof(Vector2))
            {
                return 2;
            }
            else if (value == typeof(Vector3))
            {
                return 3;
            }
            else if (value == typeof(Vector4))
            {
                return 4;
            }
            else
            {
                throw new ArgumentException("Invalid vector type.", "value");
            }
        }

        public int[] GetMatrixDimensions(Type value)
        {
            if (value == typeof(Matrix3x2))
            {
                return new int[] { 3, 2 };
            }
            else if (value == typeof(Matrix4x4))
            {
                return new int[] { 4, 4 };
            }
            else
            {
                throw new ArgumentException("Invalid vector type.", "value");
            }
        }

        public bool IsVectorType(Type type)
        {
            return type == typeof(Vector2)
                    || type == typeof(Vector3)
                    || type == typeof(Vector4);
        }

        public bool IsMatrixType(Type type)
        {
            return type == typeof(Matrix3x2)
                    || type == typeof(Matrix4x4);
        }
    }
}
