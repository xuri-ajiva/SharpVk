using SharpVk.Generator.Emit;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generators
{
    public abstract class TypeGenerator
    {
        public virtual IEnumerable<string> RequiredNamespaces
        {
            get
            {
                return Enumerable.Empty<string>();
            }
        }

        public abstract string Name
        {
            get;
        }

        public virtual IEnumerable<string> Modifiers => new string[] { };

        public virtual IEnumerable<string> Attributes => new string[] { };

        public virtual bool IsStruct => false;
        
        public abstract void Run(TypeBuilder builder);
    }
}