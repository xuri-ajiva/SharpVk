using System.Collections.Generic;
using SharpVk.VkXml;
using System.Linq;
using System;
using SharpVk.Generator.Emit;

namespace SharpVk.Generator.Generators
{
    public class InteropHandleGenerator
        : ModelGenerator
    {
        public void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Run("Interop", "Handles", types.Handles.Select(x => new InteropHandleClassGenerator(x)));
        }
    }

    public class InteropHandleClassGenerator
        : ClassGenerator
    {
        private readonly TypeSet.VkHandle handle;

        public override IEnumerable<string> RequiredNamespaces
        {
            get
            {
                return new[] { "System" };
            }
        }

        public override string Name
        {
            get
            {
                return this.handle.Name;
            }
        }

        public override string Modifiers
        {
            get
            {
                return "";
            }
        }

        public override bool IsStruct
        {
            get
            {
                return true;
            }
        }

        public InteropHandleClassGenerator(TypeSet.VkHandle handle)
        {
            this.handle = handle;
        }

        public override void Run(TypeBuilder builder)
        {
            string internalHandleType = this.handle.IsDispatch
                                            ? "IntPtr"
                                            : "ulong";

            //writer.WriteLine($"internal {internalHandleType} handle;");
            //writer.WriteLine();
            //writer.WriteLine("/// <summary>");
            //writer.WriteLine($"/// Returns a value representing a null {this.handle.Name} handle.");
            //writer.WriteLine("/// </summary>");
            //writer.WriteLine($"public static {this.handle.Name} Null");
            //writer.WriteLine("{");
            //writer.IncreaseIndent();
            //writer.WriteLine("get");
            //writer.WriteLine("{");
            //writer.IncreaseIndent();
            //writer.WriteLine($"return new {this.handle.Name}");
            //writer.WriteLine("{");
            //writer.IncreaseIndent();
            //writer.WriteLine($"handle = default({internalHandleType})");
            //writer.DecreaseIndent();
            //writer.WriteLine("};");
            //writer.DecreaseIndent();
            //writer.WriteLine("}");
            //writer.DecreaseIndent();
            //writer.WriteLine("}");
        }
    }
}
