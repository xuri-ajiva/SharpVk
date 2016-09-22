using System.Collections.Generic;
using SharpVk.VkXml;
using System.Linq;
using SharpVk.Generator.Emit;

namespace SharpVk.Generator.Generators
{
    public class InteropCommandsGenerator
        : ModelGenerator
    {
        public void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Run("Interop", "Commands", new[] { new InteropCommandsClassGenerator(types) });
        }
    }

    public class InteropCommandsClassGenerator
        : ClassGenerator
    {
        private readonly TypeSet types;

        public override IEnumerable<string> RequiredNamespaces
        {
            get
            {
                return new[] { "System", "System.Runtime.InteropServices" };
            }
        }

        public InteropCommandsClassGenerator(TypeSet types)
        {
            this.types = types;
        }

        public override void Run(TypeBuilder builder)
        {
            foreach (var type in this.types.Commands)
            {
                builder.EmitMethod("void", type.Name, null, null, AccessModifier.Public, MemberModifier.Static, new[] { "DllImport" });
            }
        }
    }
}
