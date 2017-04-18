using SharpVk.Emit;
using SharpVk.Generator.Generation;
using SharpVk.Generator.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
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

                if (@struct.Namespace?.Any() ?? false)
                {
                    path = string.Join("\\", @struct.Namespace);
                    @namespace += "." + string.Join(".", @struct.Namespace);
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
                                typeBuilder.EmitConstructor(BuildBody(@struct.Constructor), BuildParams(@struct.Constructor), Public);
                            }

                            if (@struct.Fields != null)
                            {
                                foreach (var member in @struct.Fields)
                                {
                                    typeBuilder.EmitField(member.Type,
                                                            member.Name,
                                                            member.IsPrivate ? Private : Public,
                                                            summary: member.Comment);
                                }
                            }

                            if (@struct.Properties != null)
                            {
                                foreach (var member in @struct.Properties)
                                {
                                    typeBuilder.EmitProperty(member.Type,
                                                            member.Name,
                                                            Public,
                                                            getter: member.IsPrivate ? Private : Public,
                                                            setter: member.IsPrivate ? Private : Public,
                                                            summary: member.Comment);
                                }
                            }

                            if (@struct.Methods != null)
                            {
                                foreach (var method in @struct.Methods)
                                {
                                    typeBuilder.EmitMethod("void",
                                                                method.Name,
                                                                BuildBody(method),
                                                                BuildParams(method),
                                                                method.IsUnsafe ? Internal : Public,
                                                                method.IsUnsafe ? MemberModifier.Unsafe : MemberModifier.None);
                                }
                            }
                        }, Public, null, @struct.IsUnsafe ? Unsafe : None);
                    });
                });
            }
        }

        private static Action<ParameterBuilder> BuildParams(MethodDefinition method)
        {
            return parameters =>
            {
                foreach (var action in method.ParamActions)
                {
                    parameters.EmitParam(action.Param.Type, action.Param.Name);
                }
            };
        }

        private static Action<CodeBlockBuilder> BuildBody(MethodDefinition method)
        {
            return body =>
            {
                if (method.ParamActions != null)
                {
                    foreach (var action in method.ParamActions)
                    {
                        if (action.MemberName != null)
                        {
                            body.EmitAssignment(Member(This, action.MemberName), Variable(action.Param.Name));
                        }
                    }
                }

                if (method.MemberActions != null)
                {
                    foreach (var action in method.MemberActions)
                    {
                        var targetExpression = DerefMember(Variable(action.ParamName), action.ParamFieldName);

                        switch (action.Type)
                        {
                            case MemberActionType.AssignToDeref:
                                body.EmitAssignment(targetExpression, action.ValueExpression);
                                break;
                            case MemberActionType.AllocAndAssign:
                                body.EmitAssignment(DerefMember(Variable(action.ParamName), action.ParamFieldName),
                                                    Cast(action.MemberType + "*", StaticCall("Interop.HeapUtil", $"Allocate<{action.MemberType}>")));
                                body.EmitAssignment(Deref(DerefMember(Variable(action.ParamName), action.ParamFieldName)),
                                                    action.ValueExpression);
                                break;
                            case MemberActionType.MarshalToAddressOf:
                                targetExpression = AddressOf(targetExpression);
                                goto case MemberActionType.MarshalTo;
                            case MemberActionType.MarshalTo:
                                body.EmitCall(action.ValueExpression, "MarshalTo", targetExpression);
                                break;
                        }
                    }
                }
            };
        }
    }
}
