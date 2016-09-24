using SharpVk.Generator.Emit;
using SharpVk.VkXml;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Generator.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generators
{
    public class InteropHandleGenerator
        : ModelGenerator
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Run("Interop", "Handles", types.Handles.Select(x => new InteropHandleClassGenerator(x)));
        }
    }

    public class InteropHandleClassGenerator
        : TypeGenerator
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
            const string handleFieldName = "handle";

            string internalHandleType = this.handle.IsDispatch
                                            ? "IntPtr"
                                            : "ulong";

            builder.EmitField(internalHandleType, handleFieldName, AccessModifier.Internal);

            builder.EmitProperty(this.handle.Name, "Null", AccessModifier.Public, MemberModifier.Static, getBuilder =>
            {
                getBuilder.EmitReturn(MemberInit(this.handle.Name, member =>
                    {
                        member.EmitMember(handleFieldName, Default(internalHandleType));
                    }));
            });
        }
    }
}