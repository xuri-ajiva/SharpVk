using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generators
{
    public abstract class ClassGenerator
    {
        public virtual IEnumerable<string> RequiredNamespaces
        {
            get
            {
                return Enumerable.Empty<string>();
            }
        }

        public abstract void Run(IndentedTextWriter writer);
    }
}