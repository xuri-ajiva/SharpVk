using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;

namespace SharpVk.Shanq.Queryable
{
    public static class ShanqUtil
    {
        public static ShaderType Map(Type type)
        {
            if (type == typeof(float))
            {
                return ShaderType.Float;
            }
            else if (type == typeof(Vector2))
            {
                return ShaderType.Float2;
            }
            else if (type == typeof(Vector3))
            {
                return ShaderType.Float3;
            }
            else if (type == typeof(Vector4))
            {
                return ShaderType.Float4;
            }
            else if (type == typeof(Matrix4x4))
            {
                return ShaderType.Matrix;
            }

            throw new NotImplementedException();
        }

        public static DataField Map(FieldInfo field)
        {
            return new DataField(field.Name.ToUpperInvariant(), 0, ShanqUtil.Map(field.FieldType));
        }

        public static bool IsPrimitiveType(Type type)
        {
            return type == typeof(float)
                    || type == typeof(Vector2)
                    || type == typeof(Vector3)
                    || type == typeof(Vector4);
        }

        public static Dictionary<MethodInfo, Func<IEnumerable<IRightHandShaderExpression>, HlslExpressionBuilder, IRightHandShaderExpression>> MethodCallMappings = new Dictionary<MethodInfo, Func<IEnumerable<IRightHandShaderExpression>, HlslExpressionBuilder, IRightHandShaderExpression>>();
    }

}
