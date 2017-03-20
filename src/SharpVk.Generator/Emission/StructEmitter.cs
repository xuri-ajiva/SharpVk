using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Emission
{
    public class StructEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<StructDefinition> structs;
        private readonly NameLookup nameLookup;

        public StructEmitter(IEnumerable<StructDefinition> structs, NameLookup nameLookup)
        {
            this.structs = structs;
            this.nameLookup = nameLookup;
        }

        public void Execute()
        {
            foreach (var @struct in this.structs)
            {
                using (var fileBuilder = new FileBuilder("..\\SharpVk", $"{@struct.Name}.cs"))
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, @struct.Name, typeBuilder =>
                        {
                            typeBuilder.EmitConstructor(body =>
                            {
                                foreach (var member in @struct.Members)
                                {
                                    string paramName = char.ToLower(member.Name[0]) + member.Name.Substring(1);

                                    body.EmitAssignment(Member(This, member.Name), Variable(paramName));
                                }
                            },
                            parameters =>
                            {
                                foreach (var member in @struct.Members)
                                {
                                    string paramName = char.ToLower(member.Name[0]) + member.Name.Substring(1);

                                    parameters.EmitParam(this.nameLookup.Lookup(member.Type.VkName), paramName);
                                }
                            }, Public);

                            foreach (var member in @struct.Members)
                            {
                                typeBuilder.EmitField(this.nameLookup.Lookup(member.Type.VkName),
                                                        member.Name,
                                                        member.IsPrivate ? Private : Public,
                                                        summary: member.Comment);
                            }
                        }, Public);
                    });
                }
            }
        }
    }
}
