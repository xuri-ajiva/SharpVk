using SharpVk.Emit;
using SharpVk.Generator.Generation;
using System;
using System.Linq;

using static SharpVk.Emit.AccessModifier;
using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Emission
{
    public class MethodEmitter
    {
        public void EmitConstructor(TypeBuilder typeBuilder, MethodDefinition constructor)
        {
            typeBuilder.EmitConstructor(BuildBody(constructor), BuildParams(constructor), Public);
        }

        public void Emit(TypeBuilder typeBuilder, MethodDefinition method)
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

            Func<MethodDefinition, Action<CodeBlockBuilder>> bodyFunc = BuildBody;

            if (method.AllocatesUnmanagedMemory)
            {
                bodyFunc = x => body => body.EmitTry(BuildBody(x), finallyBlock =>
                     {
                         finallyBlock.EmitStaticCall("Interop.HeapUtil", "FreeAll");
                     });
            }

            typeBuilder.EmitMethod(method.ReturnType ?? "void",
                                        method.Name,
                                        bodyFunc(method),
                                        BuildParams(method),
                                        method.IsUnsafe ? Internal : Public,
                                        modifiers);
        }

        private static Action<ParameterBuilder> BuildParams(MethodDefinition method)
        {
            return parameters =>
            {
                if (method.ParamActions != null)
                {
                    foreach (var action in method.ParamActions)
                    {
                        parameters.EmitParam(action.Param.Type, action.Param.Name);
                    }
                }
            };
        }

        private static Action<CodeBlockBuilder> BuildBody(MethodDefinition method)
        {
            return body =>
            {
                if (IsNotNullOrVoid(method.ReturnType))
                {
                    body.EmitVariableDeclaration(method.ReturnType, "result", Default(method.ReturnType));
                }

                if (method.ParamActions != null)
                {
                    foreach (var action in method.ParamActions.Where(x => x.MemberName != null))
                    {
                        body.EmitAssignment(Member(This, action.MemberName), Variable(action.Param.Name));
                    }
                }

                if (method.MemberActions != null)
                {
                    foreach (var action in method.MemberActions.OfType<DeclarationAction>())
                    {
                        body.EmitVariableDeclaration(action.MemberType, action.MemberName, Default(action.MemberType));
                    }

                    foreach (var action in method.MemberActions.OfType<AssignAction>())
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

                if (IsNotNullOrVoid(method.ReturnType))
                {
                    body.EmitReturn(Variable("result"));
                }
            };
        }

        public static void EmitMarshalAction(CodeBlockBuilder codeBlock, Generation.AssignAction action, Action<ExpressionBuilder> targetExpression)
        {
            switch (action.Type)
            {
                case AssignActionType.Assign:
                    codeBlock.EmitAssignment(targetExpression, action.ValueExpression);
                    break;
                case AssignActionType.AllocAndAssign:
                    codeBlock.EmitAssignment(targetExpression,
                                        Cast(action.MemberType + "*", StaticCall("Interop.HeapUtil", $"Allocate<{action.MemberType}>")));
                    codeBlock.EmitAssignment(Deref(targetExpression), action.ValueExpression);
                    break;
                case AssignActionType.MarshalToAddressOf:
                    codeBlock.EmitCall(action.ValueExpression, "MarshalTo", AddressOf(targetExpression));
                    break;
                case AssignActionType.MarshalTo:
                    codeBlock.EmitAssignment(targetExpression,
                                        Cast(action.MemberType + "*", StaticCall("Interop.HeapUtil", $"Allocate<{action.MemberType}>")));
                    codeBlock.EmitCall(action.ValueExpression, "MarshalTo", targetExpression);
                    break;
                case AssignActionType.MarshalFrom:
                    codeBlock.EmitAssignment(targetExpression,
                                        StaticCall(action.MemberType, "MarshalFrom", action.ValueExpression));
                    break;
                case AssignActionType.MarshalFromAddressOf:
                    codeBlock.EmitAssignment(targetExpression,
                                        StaticCall(action.MemberType, "MarshalFrom", AddressOf(action.ValueExpression)));
                    break;
            }
        }

        private static bool IsNotNullOrVoid(string type)
        {
            return type != null
                    && type != "void";
        }
    }
}
