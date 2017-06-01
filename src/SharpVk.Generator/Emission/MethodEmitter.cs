using SharpVk.Emit;
using SharpVk.Generator.Generation;
using System;
using System.Collections.Generic;
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
                                        method.IsPublic ? Public : Internal,
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
                    EmitActions(body, method.MemberActions);
                }

                if (IsNotNullOrVoid(method.ReturnType))
                {
                    body.EmitReturn(Variable("result"));
                }
            };
        }

        private static void EmitActions(CodeBlockBuilder body, List<MethodAction> actions)
        {
            foreach (var action in actions.OfType<DeclarationAction>())
            {
                body.EmitVariableDeclaration(action.MemberType, action.MemberName, Default(action.MemberType));
            }

            foreach (var action in actions)
            {
                if (action is AssignAction assignAction)
                {
                    if (assignAction.IsLoop)
                    {
                        body.EmitIfBlock(assignAction.NullCheckExpression,
                            ifBlock =>
                            {
                                ifBlock.EmitVariableDeclaration("var", "fieldPointer", Cast(assignAction.MemberType + "*", Call(StaticCall("Interop.HeapUtil", $"AllocateAndClear<{assignAction.MemberType}>", assignAction.LengthExpression), "ToPointer")));

                                ifBlock.EmitForLoop(init => init.EmitVariableDeclaration("int", assignAction.IndexName, Literal(0)),
                                                    LessThan(Variable(assignAction.IndexName), assignAction.LengthExpression),
                                                    after => after.EmitStatement(assignAction.IndexName + "++"),
                                                    loop =>
                                                    {
                                                        EmitMarshalAction(loop, assignAction, Index(Variable("fieldPointer"), Variable(assignAction.IndexName)));
                                                    });

                                ifBlock.EmitAssignment(assignAction.TargetExpression, Variable("fieldPointer"));
                            },
                            elseBlock =>
                            {
                                elseBlock.EmitAssignment(assignAction.TargetExpression, Null);
                            });
                    }
                    else
                    {
                        EmitMarshalAction(body, assignAction, assignAction.TargetExpression);
                    }
                }
                else if (action is InvokeAction invokeAction)
                {
                    var paramNames = (invokeAction.Parameters ?? Enumerable.Empty<Action<ExpressionBuilder>>().ToArray());

                    body.EmitStaticCall(invokeAction.TypeName, invokeAction.MethodName, paramNames);
                }
                else if(action is OptionalAction optionalAction)
                {
                    body.EmitIfBlock(optionalAction.NullCheckExpression, ifBlock => EmitActions(ifBlock, optionalAction.Actions));
                }
            }
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
