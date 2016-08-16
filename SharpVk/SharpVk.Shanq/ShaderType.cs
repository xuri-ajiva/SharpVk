using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.Shanq
{
    public struct ShaderType
        : IEquatable<ShaderType>
    {
        public ShaderType(Type dataType, string typeToken = null)
            : this(dataType, typeToken, 1)
        {
        }

        public ShaderType(Type dataType, params int[] dimensions)
            : this(dataType, null, dimensions)
        {
        }

        public ShaderType(Type dataType, string typeToken, params int[] dimensions)
            : this()
        {
            this.DataType = dataType;
            this.TypeToken = typeToken ?? GenerateTypeToken(dataType, dimensions);
            this.Dimensions = dimensions;
        }

        public Type DataType
        {
            get;
            private set;
        }

        public string TypeToken
        {
            get;
            private set;
        }

        public int[] Dimensions
        {
            get;
            private set;
        }

        public bool Equals(ShaderType other)
        {
            return this == other;
        }

        public static bool operator ==(ShaderType left, ShaderType right)
        {
            if (left.DataType == right.DataType
                && left.TypeToken == right.TypeToken
                && left.Dimensions.Length == right.Dimensions.Length)
            {
                for (int index = 0; index < left.Dimensions.Length; index++)
                {
                    if (left.Dimensions[index] != right.Dimensions[index])
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(ShaderType left, ShaderType right)
        {
            if (left.DataType == right.DataType
                && left.TypeToken == right.TypeToken
                && left.Dimensions.Length == right.Dimensions.Length)
            {
                for (int index = 0; index < left.Dimensions.Length; index++)
                {
                    if (left.Dimensions[index] != right.Dimensions[index])
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.TypeToken;
        }

        public override bool Equals(object obj)
        {
            return obj is ShaderType
                && this == (ShaderType)obj;
        }

        public override int GetHashCode()
        {
            return this.DataType.GetHashCode()
                    ^ this.TypeToken.GetHashCode()
                    ^ this.Dimensions.Length;
        }

        public static string GenerateTypeToken(Type dataType, int[] dimensions)
        {
            if (dimensions.Rank > 1 || dimensions[0] > 1)
            {
                string typeName = GetTypeName(dataType);
                string vector = string.Join("x", dimensions);

                return typeName + vector;
            }
            else
            {
                return GetTypeName(dataType);
            }
        }

        private static string GetTypeName(Type dataType)
        {
            return new Microsoft.CSharp.CSharpCodeProvider().GetTypeOutput(new System.CodeDom.CodeTypeReference(dataType));
        }

        public static class ShaderMatrix
        {
        }

        public readonly static ShaderType Float = new ShaderType(typeof(float));
        public readonly static ShaderType Float2 = new ShaderType(typeof(float), 2);
        public readonly static ShaderType Float3 = new ShaderType(typeof(float), 3);
        public readonly static ShaderType Float4 = new ShaderType(typeof(float), 4);
        public readonly static ShaderType Float3x3 = new ShaderType(typeof(float), 3, 3);
        public readonly static ShaderType Float4x4 = new ShaderType(typeof(float), 4, 4);
        public readonly static ShaderType Matrix = new ShaderType(typeof(ShaderMatrix), "matrix");
    }
}
