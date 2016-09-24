using SharpVk.Generator.Emit;
using SharpVk.VkXml;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Generator.Emit.AccessModifier;

namespace SharpVk.Generator.Generators
{
    public class InteropStructGenerator
        : ModelGenerator
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Run("Interop", "Structs", types.InteropStructs.Select(x => new InteropStructClassGenerator(x)));
        }
    }

    public class InteropStructClassGenerator
        : TypeGenerator
    {
        private readonly TypeSet.VkStruct @struct;

        public override IEnumerable<string> RequiredNamespaces
        {
            get
            {
                return new[] { "System", "System.Runtime.InteropServices" };
            }
        }

        public override string Name => this.@struct.Name;

        public override IEnumerable<string> Modifiers => new[] { "unsafe" };

        public override bool IsStruct => true;

        public override IEnumerable<string> Attributes => new[] { "StructLayout(LayoutKind.Sequential)" };

        public InteropStructClassGenerator(TypeSet.VkStruct @struct)
        {
            this.@struct = @struct;
        }

        public override void Run(TypeBuilder builder)
        {
            foreach (var member in this.@struct.Members)
            {
                builder.EmitField(member.TypeName, member.Name, member.IsPrivate ? Private : Public);
            }
        }
    }
}