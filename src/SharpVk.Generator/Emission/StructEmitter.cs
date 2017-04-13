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
        private readonly FileBuilderFactory builderFactory;

        public StructEmitter(IEnumerable<StructDefinition> structs, FileBuilderFactory builderFactory)
        {
            this.structs = structs;
            this.builderFactory = builderFactory;
        }

        public void Execute()
        {
            foreach (var @struct in this.structs)
            {
                string path = null;
                string @namespace = "SharpVk";

                if (@struct.IsInterop)
                {
                    path = "Interop";
                    @namespace += ".Interop";
                }

                this.builderFactory.Generate(@struct.Name, path, fileBuilder =>
                {
                    fileBuilder.EmitUsing("System");

                    fileBuilder.EmitNamespace(@namespace, namespaceBuilder =>
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, @struct.Name, typeBuilder =>
                        {
                            if (@struct.Constructor != null)
                            {
                                typeBuilder.EmitConstructor(body =>
                                {
                                    foreach (var action in @struct.Constructor.Params)
                                    {
                                        body.EmitAssignment(Member(This, action.MemberName), Variable(action.Param.Name));
                                    }
                                },
                                parameters =>
                                {
                                    foreach (var action in @struct.Constructor.Params)
                                    {
                                        parameters.EmitParam(action.Param.Type, action.Param.Name);
                                    }
                                }, Public);
                            }

                            foreach (var member in @struct.Members)
                            {
                                typeBuilder.EmitField(member.Type,
                                                        member.Name,
                                                        member.IsPrivate ? Private : Public,
                                                        summary: member.Comment);
                            }
                        }, Public, null, @struct.IsInterop ? Unsafe : None);
                    });
                });
            }
        }
    }
}
