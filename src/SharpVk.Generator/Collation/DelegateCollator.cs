using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Collation
{
    public class DelegateCollator
        : IWorker
    {
        private readonly IEnumerable<TypeElement> delegateTypes;

        public DelegateCollator(IEnumerable<TypeElement> types)
        {
            this.delegateTypes = types.Where(x => x.Category == TypeCategory.funcpointer);
        }

        public void Execute(IServiceCollection services)
        {
            foreach (var @delegate in this.delegateTypes)
            {
                services.AddSingleton(new DelegateDeclaration
                {
                    VkName = @delegate.VkName,
                    ReturnType = @delegate.Type
                });
            }
        }
    }
}
