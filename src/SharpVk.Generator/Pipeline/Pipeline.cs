using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Pipeline
{
    public class Pipeline
    {
        private readonly IEnumerable<Type> stages;
        private readonly Type output;

        internal Pipeline(IEnumerable<Type> stages, Type output)
        {
            this.stages = stages;
            this.output = output;
        }

        public void Run()
        {
            var services = new ServiceCollection();

            var stage = (IStage)Activator.CreateInstance(this.stages.First());

            stage.Configure(services);

            var provider = services.BuildServiceProvider();

            foreach(var stageType in this.stages.Skip(1))
            {
                services = new ServiceCollection();

                stage = (IStage)ActivatorUtilities.CreateInstance(provider, stageType);

                stage.Configure(services);

                provider = services.BuildServiceProvider();
            }

            var output = (IOutput)ActivatorUtilities.CreateInstance(provider, this.output);

            output.Run();
        }
    }
}
