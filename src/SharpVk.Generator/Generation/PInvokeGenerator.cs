using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class PInvokeGenerator
    {
        private readonly IEnumerable<CommandDeclaration> commands;

        public PInvokeGenerator(IEnumerable<CommandDeclaration> commands)
        {
            this.commands = commands;
        }

        public void GenerateTo(IServiceCollection services)
        {
            foreach(var command in commands)
            {
                services.AddSingleton(new PInvokeDefinition
                {
                    Name = command.VkName
                });
            }
        }
    }
}
