using SharpVk.Generator.Emit;
using SharpVk.VkXml;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generators
{
    public class VkExceptionGenerator
        : ModelGenerator
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Generate(null, "Exceptions", builder =>
            {
                builder.EmitUsing("System");

                builder.EmitNamespace("SharpVk", namespaceBuilder =>
                {
                    namespaceBuilder.EmitType(TypeKind.Class,
                                                "SharpVkException",
                                                typeBuilder =>
                                                {
                                                    typeBuilder.EmitConstructor(methodBody =>
                                                                                {
                                                                                },
                                                                                parameters => parameters.EmitParam("string", "message"),
                                                                                Protected,
                                                                                baseArguments: new[] { Variable("message") },
                                                                                summary: new[] { "Creates a new instance of the <see cref=\"SharpVk.SharpVkException\"/> class ." },
                                                                                docs: docs => docs.EmitParam("message", "The message that describes the error."));

                                                    typeBuilder.EmitMethod("bool",
                                                                            "IsError",
                                                                            methodBody => methodBody.EmitReturn(LessThan(Cast("int", Variable("resultCode")), Literal(0))),
                                                                            parameters => parameters.EmitParam("Result", "resultCode"),
                                                                            Public,
                                                                            MemberModifier.Static,
                                                                            summary: new[] { "Returns a value indicating whether the given Vulkan result code represents an error." });

                                                    typeBuilder.EmitMethod("SharpVkException",
                                                                            "Create",
                                                                            methodBody =>
                                                                            {
                                                                                methodBody.EmitIfBlock(Not(StaticCall("SharpVkException", "IsError", Variable("resultCode"))),
                                                                                                        ifBlock => ifBlock.EmitReturn(Null));

                                                                                methodBody.EmitSwitchBlock(Variable("resultCode"),
                                                                                                            caseBuilder =>
                                                                                                            {
                                                                                                                foreach (var exception in types.Exceptions)
                                                                                                                {
                                                                                                                    caseBuilder.EmitCase(AsIs(exception.Value),
                                                                                                                                            caseBlock => caseBlock.EmitReturn(New(exception.Name)));
                                                                                                                }
                                                                                                            });

                                                                                methodBody.EmitReturn(New("UnknownSharpVkException", Variable("resultCode")));
                                                                            },
                                                                            parameters => parameters.EmitParam("Result", "resultCode"),
                                                                            Public,
                                                                            MemberModifier.Static,
                                                                            summary: new[] { "Creates and returns a new, specifically-typed exception that represents the given result code." });

                                                    typeBuilder.EmitProperty("Result",
                                                                                "ResultCode",
                                                                                accessModifier: Public,
                                                                                methodModifers: MemberModifier.Abstract,
                                                                                getter: Public,
                                                                                summary: new[] { "The Vulkan result code represented by this exception." });
                                                },
                                                Public,
                                                new[] { "Exception" },
                                                TypeModifier.Abstract,
                                                summary: new[] { "The base type for exceptions thrown by the SharpVK library." });

                    namespaceBuilder.EmitType(TypeKind.Class,
                                                    "UnknownSharpVkException",
                                                    typeBuilder =>
                                                    {
                                                        typeBuilder.EmitField("Result", "resultCode");

                                                        typeBuilder.EmitConstructor(methodBody =>
                                                                                    {
                                                                                        methodBody.EmitAssignment(Member(This, "resultCode"), Variable("resultCode"));
                                                                                    },
                                                                                    parameters => parameters.EmitParam("Result", "resultCode"),
                                                                                    Internal,
                                                                                    baseArguments: new[] { AsIs("$\"An unknown exception as been thrown by the Vulkan API: {resultCode}\"") });

                                                        typeBuilder.EmitProperty("Result",
                                                                                    "ResultCode",
                                                                                    Member(This, "resultCode"),
                                                                                    Public,
                                                                                    MemberModifier.Override,
                                                                                    new[] { "The Vulkan result code represented by this exception." });
                                                    },
                                                    Public,
                                                    new[] { "SharpVkException" },
                                                    summary: new[] { "An exception representing a result code not recognised by the SharpVk library." });

                    foreach (var exception in types.Exceptions)
                    {
                        namespaceBuilder.EmitType(TypeKind.Class,
                                                    exception.Name,
                                                    typeBuilder =>
                                                    {
                                                        string exceptionMessage = exception.Comment[0];

                                                        if(exceptionMessage == "-")
                                                        {
                                                            exceptionMessage = exception.Name;
                                                        }

                                                        typeBuilder.EmitConstructor(methodBody =>
                                                                                    {
                                                                                    },
                                                                                    null,
                                                                                    Internal,
                                                                                    baseArguments: new[] { Literal(exceptionMessage) });

                                                        typeBuilder.EmitProperty("Result",
                                                                                    "ResultCode",
                                                                                    AsIs(exception.Value),
                                                                                    Public,
                                                                                    MemberModifier.Override,
                                                                                    new[] { "The Vulkan result code represented by this exception." });
                                                    },
                                                    Public,
                                                    new[] { "SharpVkException" },
                                                    summary: exception.Comment);
                    }
                });
            });
        }
    }
}
