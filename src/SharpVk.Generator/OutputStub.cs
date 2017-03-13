using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System;
using System.Collections.Generic;

namespace SharpVk.Generator
{
    public class OutputStub
        : IOutput
    {
        private readonly Dictionary<string, TypeDeclaration> types;

        public OutputStub(Dictionary<string, TypeDeclaration> types)
        {
            this.types = types;
        }

        public void Run()
        {
            foreach (var typeDecl in this.types)
            {
                Console.WriteLine($"{typeDecl.Key} {typeDecl.Value.Name} {typeDecl.Value.Data.Category} {typeDecl.Value.RequiresMarshalling}");
            }
        }
    }
}
