using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using SharpVk.Generator.Pipeline;
using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class DelegateGenerator
        : IWorker
    {
        private readonly IEnumerable<DelegateDeclaration> delegates;
        private readonly Dictionary<string, TypeDeclaration> typeData;

        public DelegateGenerator(IEnumerable<DelegateDeclaration> delegates, Dictionary<string, TypeDeclaration> typeData)
        {
            this.delegates = delegates;
            this.typeData = typeData;
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var @delegate in delegates)
            {
                var type = this.typeData[@delegate.VkName];
                string extension = type.Extension?.FirstToUpper();

                services.AddSingleton(new DelegateDefinition
                {
                    Name = type.Name,
                    Namespace = extension != null ? new[] { extension } : null,
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
