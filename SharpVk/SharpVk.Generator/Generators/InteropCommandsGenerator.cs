using System.Collections.Generic;
using SharpVk.VkXml;
using System.Linq;

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

        public override void Run(IndentedTextWriter writer)
        {
            writer.WriteLine("public static class Commands");
            writer.WriteLine("{");
            writer.IncreaseIndent();
            foreach (var type in this.types.Commands)
            {
                writer.WriteLine("[DllImport]");
                writer.WriteLine($"public static void {type.Name}();");
                if (type != this.types.Commands.Last())
                {
                    writer.WriteLine();
                }
            }
            writer.DecreaseIndent();
            writer.WriteLine("}");
        }
    }
}
