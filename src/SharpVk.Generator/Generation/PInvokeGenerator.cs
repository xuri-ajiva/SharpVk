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
        private readonly NamespaceMap namespaceMap;
        private readonly NameLookup nameLookup;

        public PInvokeGenerator(IEnumerable<CommandDeclaration> commands, NamespaceMap namespaceMap, NameLookup nameLookup)
        {
            this.commands = commands;
            this.namespaceMap = namespaceMap;
            this.nameLookup = nameLookup;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var command in commands)
            {
                if (command.Extension == null)
                {
                    services.AddSingleton(new PInvokeDefinition
                    {
                        Name = command.VkName,
                        ReturnType = this.nameLookup.Lookup(new TypeReference { VkName = command.ReturnType }, true),
                        Parameters = command.Params.Select(x => new ParamDefinition
                        {
                            Name = x.Name,
                            Type = this.nameLookup.Lookup(x.Type, true)
                        }).ToList()
                    });
                }

                services.AddSingleton(new DelegateDefinition
                {
                    Name = $"{command.HandleTypeName}{command.Name}Delegate",
                    Namespace = this.namespaceMap.Map(command.Extension).Prepend("Interop").ToArray(),
                    ReturnType = this.nameLookup.Lookup(new TypeReference { VkName = command.ReturnType }, true),
                    IsUnsafe = true,
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
