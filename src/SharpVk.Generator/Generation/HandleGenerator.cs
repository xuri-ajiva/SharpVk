using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class HandleGenerator
        : IWorker
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NameLookup nameLookup;
        private readonly Dictionary<string, IEnumerable<CommandDeclaration>> commands;

        public HandleGenerator(Dictionary<string, TypeDeclaration> typeData, NameLookup nameLookup, IEnumerable<CommandDeclaration> commands)
        {
            this.typeData = typeData;
            this.nameLookup = nameLookup;
            this.commands = commands.GroupBy(x => x.HandleTypeName).ToDictionary(x => x.Key, x => x.AsEnumerable());
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var typePair in this.typeData.Where(x => x.Value.Pattern == TypePattern.Handle))
            {
                var type = typePair.Value;

                var commands = this.commands.ContainsKey(typePair.Key)
                                        ? this.commands[typePair.Key]
                                            .Where(x => x.Extension == null)
                                            .Select(x => new MethodDefinition
                                            {
                                                Name = x.Name,
                                                ReturnType = this.nameLookup.Lookup(x.ReturnType)
                                            }).ToList()
                                        : new List<MethodDefinition>();

                services.AddSingleton(new HandleDefinition
                {
                    Name = type.Name,
                    Namespace = type.Extension != null ? new[] { type.Extension } : null,
                    IsDispatch = type.Type != "VK_DEFINE_NON_DISPATCHABLE_HANDLE",
                    Commands = commands
                });
            }
        }
    }
}
