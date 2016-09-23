using System.Collections.Generic;
using SharpVk.VkXml;
using System.Linq;
using System;
using SharpVk.Generator.Emit;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.MemberModifier;
using System.Linq.Expressions;

namespace SharpVk.Generator.Generators
{
    public class InteropCommandsGenerator
        : ModelGenerator
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
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

        public override IEnumerable<string> Modifiers => new[] { "static", "unsafe" };

        public InteropCommandsClassGenerator(TypeSet types)
        {
            this.types = types;
        }

        public override void Run(TypeBuilder builder)
        {
            builder.EmitField("string", "VulkanDll", Public, Const, expr => expr.EmitLiteral("vulkan-1.dll"));

            foreach (var command in this.types.Commands)
            {
                builder.EmitMethod("void", command.Name, null, paramsBuilder =>
                    {
                        foreach(var param in command.Parameters)
                        {
                            paramsBuilder.EmitParam(param.TypeName, param.Name);
                        }
                    }, Public, Static, new[] { "DllImport(VulkanDll)" });
            }
        }
    }
}