using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator
{
    public class OutputStub
        : IOutputWorker
    {
        private readonly Dictionary<string, TypeDeclaration> types;
        private readonly IEnumerable<CommandDeclaration> commands;

        public OutputStub(Dictionary<string, TypeDeclaration> types, IEnumerable<CommandDeclaration> commands)
        {
            this.types = types;
            this.commands = commands;
        }

        public void Execute()
        {
            //foreach (var typeDecl in this.types)
            //{
            //    Console.WriteLine($"{typeDecl.Key} {typeDecl.Value.Name} {typeDecl.Value.Data.Category} {typeDecl.Value.RequiresMarshalling}");

            //    foreach (var memberDecl in typeDecl.Value.Members)
            //    {
            //        Console.WriteLine($"\t{memberDecl.Name}");
            //    }
            //}

            foreach (var commandDecl in this.commands
                                                .OrderBy(x=>x.HandleTypeName)
                                                .ThenBy(x => x.VkName))
            {
                Console.WriteLine($"{commandDecl.VkName} => {this.types[commandDecl.HandleTypeName].Name}.{commandDecl.Name}");
            }
        }
    }
}
