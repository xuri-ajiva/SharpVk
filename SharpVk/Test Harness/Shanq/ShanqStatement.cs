using SharpVk.Spirv;
using System;
using System.Linq;

namespace SharpVk.Shanq
{
    internal class ShanqStatement
    {
        public ShanqStatement(Op op, params ShanqOperand[] operands)
        {
            this.Op = op;
            this.Operands = operands;
        }

        public Op Op
        {
            get;
            private set;
        }

        public ShanqOperand[] Operands
        {
            get;
            private set;
        }

        public override bool Equals(object obj)
        {
            var other = obj as ShanqStatement;

            if (!object.ReferenceEquals(other, null)
                    && this.Op == other.Op
                    && this.Operands.Length == other.Operands.Length)
            {
                for (int index = 0; index < this.Operands.Length; index++)
                {
                    if (this.Operands[index].Int32 != other.Operands[index].Int32)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            if (!this.Operands.Any())
            {
                return this.Op.GetHashCode();
            }
            else
            {
                return this.Op.GetHashCode()
                        ^ this.Operands.Select(x => x.GetHashCode())
                                        .Aggregate((x, y) => x ^ y);
            }
        }

        public static bool operator ==(ShanqStatement left, ShanqStatement right)
        {
            if (object.ReferenceEquals(left, null))
            {
                return object.ReferenceEquals(right, null);
            }
            else
            {
                return left.Equals(right);
            }
        }

        public static bool operator !=(ShanqStatement left, ShanqStatement right)
        {
            return !(left == right);
        }
    }
}
