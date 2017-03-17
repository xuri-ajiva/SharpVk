using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class PInvokeGenerator
    {
        private readonly IEnumerable<CommandDeclaration> commands;
        private readonly Dictionary<string, TypeDeclaration> typeData;

        public PInvokeGenerator(IEnumerable<CommandDeclaration> commands, Dictionary<string, TypeDeclaration> typeData)
        {
            this.commands = commands;
            this.typeData = typeData;
        }

        public void GenerateTo(IServiceCollection services)
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
