using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class PInvokeGenerator
        : IWorker
    {
        private readonly IEnumerable<CommandDeclaration> commands;
        private readonly Dictionary<string, TypeDeclaration> typeData;

        public PInvokeGenerator(IEnumerable<CommandDeclaration> commands, Dictionary<string, TypeDeclaration> typeData)
        {
            this.commands = commands;
            this.typeData = typeData;
        }

        public void Execute(IServiceCollection services)
        {
            foreach(var command in commands)
            {
                services.AddSingleton(new PInvokeDefinition
                {
                    Name = command.VkName,
                    ReturnType = this.typeData[command.ReturnType].Name
                });
            }
        }
    }
}
