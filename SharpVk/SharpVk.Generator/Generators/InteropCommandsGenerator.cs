using System.Collections.Generic;
using SharpVk.VkXml;
using System.Linq;
using System;
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

        public override string Name
        {
            get
            {
                return "Commands";
            }
        }

        public override string Modifiers
        {
            get
            {
                return "static unsafe";
            }
        }

        public InteropCommandsClassGenerator(TypeSet types)
        {
            this.types = types;
        }

        public override void Run(TypeBuilder builder)
        {
            //writer.WriteLine(@"public const string VulkanDll = ""vulkan-1.dll"";");

            builder.EmitField("string", "VulkanDll", AccessModifier.Public, MemberModifier.Const);

            foreach (var command in this.types.Commands)
            {
                builder.EmitMethod("void", command.Name, null, null, AccessModifier.Public, MemberModifier.Static, new[] { "DllImport(VulkanDll)" });
            }
        }
    }
}
