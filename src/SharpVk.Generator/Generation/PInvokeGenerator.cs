using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class PInvokeGenerator
        : IWorker
    {
        private readonly IEnumerable<CommandDeclaration> commands;
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;

        public PInvokeGenerator(IEnumerable<CommandDeclaration> commands, Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup)
        {
            this.commands = commands;
            this.typeData = typeData;
            this.nameLookup = nameLookup;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var command in commands)
            {
                services.AddSingleton(new PInvokeDefinition
                {
                    Name = command.VkName,
                    ReturnType = this.typeData[command.ReturnType].Name,
                    Parameters = command.Params.Select(x => new ParamDefinition
                    {
                        Name = x.Name,
                        Type = this.nameLookup.Lookup(x.Type, true)
                    }).ToList()
                });
            }
        }
    }
}
