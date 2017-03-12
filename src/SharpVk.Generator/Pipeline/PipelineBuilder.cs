using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Pipeline
{
    public class PipelineBuilder
    {
        private List<Type> stages = new List<Type>();

        private PipelineBuilder(Type initialStage)
        {
            this.stages.Add(initialStage);
        }

        public static PipelineBuilder Create<T>()
            where T : IStage
        {
            return new PipelineBuilder(typeof(T));
        }

        public PipelineBuilder Extend<T>()
            where T : IStage
        {
            this.stages.Add(typeof(T));

            return this;
        }

        public Pipeline Build<T>()
            where T : IOutput
        {
            return new Pipeline(this.stages, typeof(T));
        }
    }
}
