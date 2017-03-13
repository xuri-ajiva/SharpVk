using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Elements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Collation
{
    public class CollationStage
        : IStage
    {
        private IServiceProvider provider;

        public CollationStage(IServiceProvider provider)
        {
            this.provider = provider;
        }

        public void Configure(IServiceCollection services)
        {
            //var collationServices = new ServiceCollection();

            //void AddElementSet<T>()
            //    where T: SpecElement
            //{
            //    var elements = this.provider.GetServices<T>();

            //    collationServices.AddSingleton(elements.ToDictionary(x => x.VkName, x => x));
            //}

            //AddElementSet<TypeElement>();
            //AddElementSet<EnumElement>();
            //AddElementSet<CommandElement>();

            //var collationProvider = collationServices.BuildServiceProvider();

            this.provider.CreateInstance<TypeCollator>().CollateTo(services);
        }
    }
}
