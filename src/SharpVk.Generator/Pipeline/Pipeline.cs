using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Pipeline
{
    public class Pipeline
    {
        private readonly IEnumerable<Type> stages;

        internal Pipeline(IEnumerable<Type> stages)
        {
            this.stages = stages;
        }

        public void Run()
        {
            var services = new ServiceCollection();

            var initial = this.stages.First();

            var stage = (IStage)Activator.CreateInstance(initial);

            stage.Configure(services);

            foreach (var stageType in this.stages.Skip(1).Take(this.stages.Count() - 2))
            {
                var setup = (IStage)Activator.CreateInstance(stageType);

                setup.Configure(services);

                var stageProvider = services.BuildServiceProvider();

                services = new ServiceCollection();

                foreach (var worker in stageProvider.GetServices<IWorker>())
                {
                    worker.Execute(services);
                }
            }

            var outputStage = (IStage)Activator.CreateInstance(this.stages.Last());

            outputStage.Configure(services);

            var outputProvider = services.BuildServiceProvider();

            var outputs = outputProvider.GetServices<IOutputWorker>();

            foreach (var output in outputs)
            {
                output.Execute();
            }
        }
    }
}
