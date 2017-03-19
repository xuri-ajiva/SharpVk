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

            var initial = this.stages.First();

            var stage = (IStage)Activator.CreateInstance(initial);

            stage.Configure(services);

            foreach (var stageType in this.stages.Skip(1))
            {
                var setup = (IStage)Activator.CreateInstance(stageType);

                setup.Configure(services);

                var stageProvider = services.BuildServiceProvider();

                services = new ServiceCollection();

                foreach(var worker in stageProvider.GetServices<IWorker>())
                {
                    worker.Execute(services);
                }

                stage.Configure(services);
                services.AddSingleton<IServiceCollection>(services);
            }

            var provider = services.BuildServiceProvider();

            var output = (IOutput)ActivatorUtilities.CreateInstance(provider, this.output);

            output.Run();
        }
    }
}
