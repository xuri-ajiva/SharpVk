using System;
using System.Linq;

namespace SharpVk.Spirv
{
    public class SpirvStatement
    {
        public SpirvStatement(Op op, params object[] operands)
        {
            this.Op = op;
            this.Operands = operands;
        }

        public Op Op
        {
            get;
            private set;
        }

        public object[] Operands
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return this.Op + this.Operands.Select(x => " " + FormatOperand(x)).Aggregate("", (x, y) => x + y);
        }

        private string FormatOperand(object operand)
        {
            if (operand.GetType() == typeof(string))
            {
                return $"\"{operand}\"";
            }
            else
            {
                return operand.ToString();
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as SpirvStatement;

            if (!object.ReferenceEquals(other, null)
                    && this.Op == other.Op
                    && this.Operands.Length == other.Operands.Length)
            {
                for (int index = 0; index < this.Operands.Length; index++)
                {
                    if (!this.Operands[index].Equals(other.Operands[index]))
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

        public static bool operator ==(SpirvStatement left, SpirvStatement right)
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

        public static bool operator !=(SpirvStatement left, SpirvStatement right)
        {
            return !(left == right);
        }
    }
}
