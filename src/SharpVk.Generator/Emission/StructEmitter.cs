using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.ExpressionBuilder;
using static SharpVk.Emit.TypeModifier;

namespace SharpVk.Generator.Emission
{
    public class StructEmitter
        : IOutputWorker
    {
        private readonly IEnumerable<StructDefinition> structs;

        public StructEmitter(IEnumerable<StructDefinition> structs)
        {
            this.structs = structs;
        }

        public void Execute()
        {
            foreach (var @struct in this.structs)
            {
                var path = "..\\SharpVk";
                var @namespace = "SharpVk";

                if (@struct.IsInterop)
                {
                    path += "\\Interop";
                    @namespace += ".Interop";
                }

                using (var fileBuilder = new FileBuilder(path, $"{@struct.Name}.cs"))
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace(@namespace, namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, @struct.Name, typeBuilder =>
                        {
                            typeBuilder.EmitConstructor(body =>
                            {
                                foreach (var member in @struct.Members)
                                {
                                    body.EmitAssignment(Member(This, member.Name), Variable(member.ParamName));
                                }
                            },
                            parameters =>
                            {
                                foreach (var member in @struct.Members)
                                {
                                    parameters.EmitParam(member.Type, member.ParamName);
                                }
                            }, Public);

                            foreach (var member in @struct.Members)
                            {
                                typeBuilder.EmitField(member.Type,
                                                        member.Name,
                                                        member.IsPrivate ? Private : Public,
                                                        summary: member.Comment);
                            }
                        }, Public, null, @struct.IsInterop ? Unsafe : None);
                    });
                }
            }
        }
    }
}
