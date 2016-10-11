using SharpVk.Generator.Emit;
using SharpVk.VkXml;
using System;
using System.Collections.Generic;
using System.Linq;
using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generators
{
    public class VkHandleGenerator
        : ModelGenerator
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Generate("Interop", "Handles", fileBuilder =>
            {
                fileBuilder.EmitUsing("System");

                fileBuilder.EmitNamespace("SharpVk.Interop", namespaceBuilder =>
                {
                    foreach (var handle in types.Handles)
                    {
                        namespaceBuilder.EmitType(TypeKind.Struct, handle.Name, typeBuilder =>
                        {
                            const string handleFieldName = "handle";

                            string internalHandleType = handle.IsDispatch
                                                            ? "UIntPtr"
                                                            : "ulong";

                            typeBuilder.EmitField(internalHandleType, handleFieldName, Internal);

                            typeBuilder.EmitProperty(handle.Name, "Null", Public, MemberModifier.Static, getBuilder =>
                            {
                                getBuilder.EmitReturn(MemberInit(handle.Name, member =>
                                {
                                    member.EmitMember(handleFieldName, Default(internalHandleType));
                                }));
                            }, summary: new[] { $"A read-only property that returns a null {handle.Name} handle." });

                            typeBuilder.EmitMethod("ulong", "ToUInt64", methodbody =>
                            {
                                if (handle.IsDispatch)
                                {
                                    methodbody.EmitReturn(Call(Member(This, "handle"), "ToUInt64"));
                                }
                                else
                                {
                                    methodbody.EmitReturn(Member(This, "handle"));
                                }
                            }, null, Public, summary: new[] { "Returns the marshalled value of this handle as an unsigned 64-bit integer." });
                        }, Public, summary: handle.Comment);
                    }
                });
            });

            fileGenerator.Generate(null, "Handles", fileBuilder =>
            {
                fileBuilder.EmitUsing("System");

                fileBuilder.EmitNamespace("SharpVk", namespaceBuilder =>
                {
                    foreach (var handle in types.Handles)
                    {
                        var interfaces = new List<string>();

                        if (handle.IsDisposable)
                        {
                            interfaces.Add("IDisposable");
                        }

                        if (handle.IsProcLookup)
                        {
                            interfaces.Add("IProcLookup");
                        }

                        namespaceBuilder.EmitType(TypeKind.Class, handle.Name, typeBuilder =>
                        {
                            string interopTypeName = "Interop." + handle.Name;
                            typeBuilder.EmitField(interopTypeName, "handle", Internal, MemberModifier.Readonly);
                            typeBuilder.EmitField("CommandCache", "commandCache", Internal, MemberModifier.Readonly);

                            var parameters = new List<Action<ParameterBuilder>>
                            {
                                x => x.EmitParam(interopTypeName, "handle")
                            };

                            var ctorStatements = new List<Action<CodeBlockBuilder>>
                            {
                                x => x.EmitAssignment(Member(This, "handle"), Variable("handle"))
                            };

                            if (handle.ParentHandle != null)
                            {
                                typeBuilder.EmitField(handle.ParentHandle, "parent", methodModifers: MemberModifier.Readonly);

                                typeBuilder.EmitProperty("AllocationCallbacks?", "Allocator", Internal, getter: getBuilder =>
                                {
                                    getBuilder.EmitReturn(Member(Member(This, "parent"), "Allocator"));
                                });

                                parameters.Add(x => x.EmitParam(handle.ParentHandle, "parent"));

                                ctorStatements.Add(x => x.EmitAssignment(Member(This, "parent"), Variable("parent")));

                                if (handle.AssociatedHandle != null)
                                {
                                    typeBuilder.EmitField(handle.AssociatedHandle, "associated", methodModifers: MemberModifier.Readonly);

                                    parameters.Add(x => x.EmitParam(handle.AssociatedHandle, "associated"));

                                    ctorStatements.Add(x => x.EmitAssignment(Member(This, "associated"), Variable("associated")));
                                }
                            }
                            else
                            {
                                typeBuilder.EmitField("AllocationCallbacks?", "allocator", methodModifers: MemberModifier.Readonly);

                                typeBuilder.EmitProperty("AllocationCallbacks?", "Allocator", Internal, getter: getBuilder =>
                                {
                                    getBuilder.EmitReturn(Member(This, "allocator"));
                                });

                                parameters.Add(x => x.EmitParam("AllocationCallbacks?", "allocator"));

                                ctorStatements.Add(x => x.EmitAssignment(Member(This, "allocator"), Variable("allocator")));
                            }

                            var commandCacheAssignment = Variable("commandCache");

                            if (handle.IsProcLookup)
                            {
                                var parentCache = handle.ParentHandle != null
                                                    ? Member(Variable("parent"), "commandCache")
                                                    : Null;

                                commandCacheAssignment = New("CommandCache", This, Literal(handle.ProcCacheType), parentCache);
                            }
                            else
                            {
                                parameters.Add(x => x.EmitParam("CommandCache", "commandCache"));
                            }

                            ctorStatements.Add(x => x.EmitAssignment(Member(This, "commandCache"), commandCacheAssignment));

                            typeBuilder.EmitConstructor(body =>
                            {
                                foreach (var statement in ctorStatements)
                                {
                                    statement(body);
                                }
                            },
                            paramsBuilder =>
                            {
                                foreach (var param in parameters)
                                {
                                    param(paramsBuilder);
                                }
                            }, Internal);

                            foreach (var method in handle.Methods)
                            {
                                var methodModifiers = method.IsStatic
                                                        ? MemberModifier.Static
                                                        : MemberModifier.None;

                                typeBuilder.EmitMethod(method.ReturnTypeName, method.Name, body =>
                                {
                                    body.EmitUnsafeBlock(unsafeBlock =>
                                    {
                                        unsafeBlock.EmitTry(tryBlock =>
                                        {
                                            Func<IEnumerable<Action<ExpressionBuilder>>, Action<ExpressionBuilder>> commandExpression = commandParameters =>
                                            {
                                                return StaticCall("Interop.Commands", method.CommandName, commandParameters.ToArray());
                                            };

                                            if (method.ShouldGetFromCache)
                                            {
                                                string delegateTypeName = "Interop." + method.CacheLookupName;

                                                tryBlock.EmitVariableDeclaration("var", "commandDelegate",
                                                            Call(Member(This, "commandCache"), $"GetCommandDelegate<{delegateTypeName}>", Literal(method.CacheLookupName), Literal(method.CacheLookupType)));

                                                commandExpression = commandParameters =>
                                                {
                                                    return DelegateCall(Variable("commandDelegate"), commandParameters.ToArray());
                                                };
                                            }

                                            if (method.ReturnTypeName != "void")
                                            {
                                                tryBlock.EmitVariableDeclaration(method.ReturnTypeName, "result", Default(method.ReturnTypeName));
                                            }

                                            if (method.HasVkResult)
                                            {
                                                tryBlock.EmitVariableDeclaration("Result", "commandResult");
                                            }

                                            foreach (var statement in method.MarshalToStatements)
                                            {
                                                tryBlock.EmitStatement(statement);
                                            }

                                            if (method.IsDoubleInvoke)
                                            {
                                                EmitInvokeCommand(tryBlock, method, commandExpression, x => x.PreInvokeArgumentName ?? x.ArgumentName);

                                                foreach (var statement in method.MarshalMidStatements)
                                                {
                                                    tryBlock.EmitStatement(statement);
                                                }
                                            }

                                            EmitInvokeCommand(tryBlock, method, commandExpression, x => x.ArgumentName);

                                            foreach (var statement in method.MarshalFromStatements)
                                            {
                                                tryBlock.EmitStatement(statement);
                                            }

                                            if (method.ReturnTypeName != "void")
                                            {
                                                tryBlock.EmitReturn(Variable("result"));
                                            }
                                        },
                                        finallyBlock => finallyBlock.EmitStaticCall("Interop.HeapUtil", "FreeLog"));
                                    });
                                },
                                paramsBuilder =>
                                {
                                    foreach (var parameter in method.Parameters.Where(x => x.Name != null))
                                    {
                                        paramsBuilder.EmitParam(parameter.TypeName, parameter.Name);
                                    }
                                }, Public, methodModifiers, summary: method.Comment);
                            }

                            typeBuilder.EmitMethod(interopTypeName, "Pack", body =>
                            {
                                body.EmitReturn(Member(This, "handle"));
                            }, null, Internal);

                            typeBuilder.EmitProperty(interopTypeName,
                                                        "RawHandle",
                                                        Member(This, "handle"),
                                                        Public,
                                                        summary: new[] { $"The interop handle for this {handle.Name}." });

                            if (handle.IsDisposable)
                            {
                                typeBuilder.EmitMethod("void", "Dispose", body =>
                                {
                                    body.EmitCall(This, "Destroy");
                                }, null, Public, summary: new[] { "Releases the unmanaged resources associated with this instance and destroys the underlying Vulkan handle." });
                            }
                        }, Public, interfaces, summary: handle.Comment);
                    }
                });
            });
        }

        private static void EmitInvokeCommand(CodeBlockBuilder tryBlock, TypeSet.VkHandleMethod method, Func<IEnumerable<Action<ExpressionBuilder>>, Action<ExpressionBuilder>> commandExpression, Func<TypeSet.VkMethodParam, string> argumentNameSelector)
        {
            foreach (var fixedArgument in method.Parameters.Where(x => !string.IsNullOrEmpty(x.FixedName)))
            {
                tryBlock.EmitStatement($"fixed({fixedArgument.FixedType} {fixedArgument.FixedName} = {fixedArgument.Name})");
            }

            var arguments = method.Parameters.Select(argumentNameSelector).Select(Variable);

            if (method.HasVkResult)
            {
                tryBlock.EmitAssignment(Variable("commandResult"), commandExpression(arguments));
            }
            else if (method.IsPassthroughResult)
            {
                tryBlock.EmitAssignment(Variable("result"), commandExpression(arguments));
            }
            else
            {
                tryBlock.EmitCallExpression(commandExpression(arguments));
            }

            if (method.HasVkResult)
            {
                tryBlock.EmitIfBlock(StaticCall("SharpVkException", "IsError", Variable("commandResult")), ifBlock =>
                {
                    ifBlock.EmitThrow(StaticCall("SharpVkException", "Create", Variable("commandResult")));
                });
            }
        }
    }
}