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
                                    var modifiers = MemberModifier.None;

                                    if (method.IsUnsafe)
                                    {
                                        modifiers |= MemberModifier.Unsafe;
                                    }

                                    if (method.IsStatic)
                                    {
                                        modifiers |= MemberModifier.Static;
                                    }

                                    typeBuilder.EmitMethod(method.ReturnType ?? "void",
                                                                method.Name,
                                                                BuildBody(method),
                                                                BuildParams(method),
                                                                method.IsUnsafe ? Internal : Public,
                                                                modifiers);
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
                if (method.ReturnType != null)
                {
                    body.EmitVariableDeclaration(method.ReturnType, "result", Default(method.ReturnType));
                }

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
                        if (action.IsLoop)
                        {
                            body.EmitIfBlock(action.NullCheckExpression,
                                ifBlock =>
                                {
                                    ifBlock.EmitVariableDeclaration("var", "fieldPointer", Cast(action.MemberType + "*", Call(StaticCall("Interop.HeapUtil", $"AllocateAndClear<{action.MemberType}>", action.LengthExpression), "ToPointer")));

                                    ifBlock.EmitForLoop(init => init.EmitVariableDeclaration("int", action.IndexName, Literal(0)),
                                                        LessThan(Variable(action.IndexName), action.LengthExpression),
                                                        after => after.EmitStatement(action.IndexName + "++"),
                                                        loop =>
                                                        {
                                                            EmitMarshalAction(loop, action, Index(Variable("fieldPointer"), Variable(action.IndexName)));
                                                        });

                                    ifBlock.EmitAssignment(action.TargetExpression, Variable("fieldPointer"));
                                },
                                elseBlock =>
                                {
                                    elseBlock.EmitAssignment(action.TargetExpression, Null);
                                });
                        }
                        else
                        {
                            EmitMarshalAction(body, action, action.TargetExpression);
                        }
                    }
                }

                if (method.ReturnType != null)
                {
                    body.EmitReturn(Variable("result"));
                }
            };
        }

        public static void EmitMarshalAction(CodeBlockBuilder codeBlock, Generation.Action action, Action<ExpressionBuilder> targetExpression)
        {
            switch (action.Type)
            {
                case MemberActionType.Assign:
                    codeBlock.EmitAssignment(targetExpression, action.ValueExpression);
                    break;
                case MemberActionType.AllocAndAssign:
                    codeBlock.EmitAssignment(targetExpression,
                                        Cast(action.MemberType + "*", StaticCall("Interop.HeapUtil", $"Allocate<{action.MemberType}>")));
                    codeBlock.EmitAssignment(Deref(targetExpression), action.ValueExpression);
                    break;
                case MemberActionType.MarshalToAddressOf:
                    codeBlock.EmitCall(action.ValueExpression, "MarshalTo", AddressOf(targetExpression));
                    break;
                case MemberActionType.MarshalTo:
                    codeBlock.EmitAssignment(targetExpression,
                                        Cast(action.MemberType + "*", StaticCall("Interop.HeapUtil", $"Allocate<{action.MemberType}>")));
                    codeBlock.EmitCall(action.ValueExpression, "MarshalTo", targetExpression);
                    break;
                case MemberActionType.MarshalFrom:
                    codeBlock.EmitAssignment(targetExpression,
                                        StaticCall(action.MemberType, "MarshalFrom", action.ValueExpression));
                    break;
                case MemberActionType.MarshalFromAddressOf:
                    codeBlock.EmitAssignment(targetExpression,
                                        StaticCall(action.MemberType, "MarshalFrom", AddressOf(action.ValueExpression)));
                    break;
            }
        }
    }
}
