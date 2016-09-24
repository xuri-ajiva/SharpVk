using SharpVk.Generator.Emit;
using SharpVk.VkXml;
using System.Collections.Generic;
using System.Linq;

using static SharpVk.Generator.Emit.AccessModifier;
using static SharpVk.Generator.Emit.ExpressionBuilder;
using static SharpVk.Generator.Emit.MemberModifier;

namespace SharpVk.Generator.Generators
{
    public class ClassGenerator
        : ModelGenerator
    {
        public override void Run(TypeSet types, FileGenerator fileGenerator)
        {
            fileGenerator.Run(null, "Classes", types.Classes.Select(x => new ClassTypeGenerator(x)));
        }
    }

    public class ClassTypeGenerator
        : TypeGenerator
    {
        private readonly TypeSet.VkClass @class;

        public override IEnumerable<string> RequiredNamespaces
        {
            get
            {
                return new[] { "System" };
            }
        }

        public override string Name => this.@class.Name;

        public override bool IsStruct => true;

        public ClassTypeGenerator(TypeSet.VkClass @class)
        {
            this.@class = @class;
        }

        public override void Run(TypeBuilder builder)
        {
            foreach (var member in this.@class.Properties)
            {
                builder.EmitProperty(member.TypeName, member.Name, Public);
            }

            string interopTypeName = $"Interop.{this.@class.Name}";
            string interopPointerName = interopTypeName + "*";

            if (!this.@class.IsOutput)
            {
                builder.EmitMethod(interopTypeName, "Pack", body =>
                {
                    const string resultVariableName = "result";

                    body.EmitVariableDeclaration(interopTypeName, resultVariableName, Default(interopTypeName));

                    foreach(var statement in this.@class.MarshalToStatements)
                    {
                        body.EmitStatement(statement);
                    }

                    body.EmitReturn(Variable(resultVariableName));
                }, null, Internal, Unsafe);

                builder.EmitMethod(interopPointerName, "MarshalTo", body =>
                  {
                      body.EmitReturn(Cast(interopPointerName, Call(StaticCall("Interop.HeapUtil", "AllocateAndMarshal", Call(This, "Pack")), "ToPointer")));
                  }, null, Internal, Unsafe);
            }
            else
            {
                builder.EmitMethod(this.@class.Name, "MarshalFrom", body =>
                {
                    const string resultVariableName = "result";

                    body.EmitVariableDeclaration(this.@class.Name, resultVariableName, New(this.@class.Name));

                    foreach (var statement in this.@class.MarshalFromStatements)
                    {
                        body.EmitStatement(statement);
                    }

                    body.EmitReturn(Variable(resultVariableName));
                }, parameters =>
                {
                    parameters.EmitParam(interopPointerName, "value");
                }, Internal, Static | Unsafe);
            }
        }
    }
}