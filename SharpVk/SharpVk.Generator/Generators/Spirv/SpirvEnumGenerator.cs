using SharpVk.SpirvJson;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generators.Spirv
{
    public class SpirvEnumGenerator
        : ModelGenerator<SpirvModel>
    {
        public override void Run(SpirvModel model, FileGenerator fileGenerator)
        {
            fileGenerator.Generate("Spirv", "Enums", fileBuilder =>
            {
                fileBuilder.EmitNamespace("SharpVk.Spirv", namespaceBuilder =>
                {
                    foreach (var enumeration in model.Spv.Enum)
                    {
                        namespaceBuilder.EmitEnum(enumeration.Name, enumBuilder =>
                        {
                            bool isBit = enumeration.Type == "Bit";

                            if (isBit)
                            {
                                enumBuilder.EmitField("None", Literal(0));
                            }

                            foreach (var value in enumeration.Values)
                            {
                                var fieldValue = Literal(value.Value);

                                if(isBit)
                                {
                                    fieldValue = ShiftLeft(Literal(1), fieldValue);
                                }

                                enumBuilder.EmitField(value.Key, fieldValue);
                            }
                        }, Public);
                    }
                });
            });
        }
    }
}
