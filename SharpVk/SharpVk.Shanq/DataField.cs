using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq
{
    public struct DataField
        : IEquatable<DataField>
    {
        public DataField(string semantic, int index, ShaderType type)
            : this()
        {
            this.Semantic = semantic;
            this.Index = index;
            this.Type = type;
        }

        public string Semantic
        {
            get;
            private set;
        }

        public int Index
        {
            get;
            private set;
        }

        public ShaderType Type
        {
            get;
            private set;
        }

        public bool Equals(DataField other)
        {
            return this.Semantic == other.Semantic
                && this.Index == other.Index
                && this.Type == other.Type;
        }
    }
}
