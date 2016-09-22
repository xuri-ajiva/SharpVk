using SharpVk.Generator.Emit;
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

        public abstract string Name
        {
            get;
        }

        public abstract string Modifiers
        {
            get;
        }

        public virtual bool IsStruct
        {
            get
            {
                return false;
            }
        }
        
        public abstract void Run(TypeBuilder builder);
    }
}