using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class DelegateGenerator
        : IWorker
    {
        private readonly IEnumerable<DelegateDeclaration> delegates;
        private readonly Dictionary<string, TypeDeclaration> typeData;
        private readonly NamespaceMap namespaceMap;

        public DelegateGenerator(IEnumerable<DelegateDeclaration> delegates, Dictionary<string, TypeDeclaration> typeData, NamespaceMap namespaceMap)
        {
            this.delegates = delegates;
            this.typeData = typeData;
            this.namespaceMap = namespaceMap;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var @delegate in delegates)
            {
                var type = this.typeData[@delegate.VkName];

                services.AddSingleton(new DelegateDefinition
                {
                    Name = type.Name,
                    Namespace = type.Extension != null ? this.namespaceMap.Map(type.Extension).ToArray() : null,
                    ReturnType = this.typeData[@delegate.ReturnType].Name
                });

                //services.AddSingleton(new TypeNameMapping
                //{
                //    VkName = @delegate.VkName,
                //    OutputName = type.Name
                //});
            }
        }
    }
}
