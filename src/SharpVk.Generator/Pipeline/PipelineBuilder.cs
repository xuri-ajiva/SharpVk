using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Pipeline
{
    public class PipelineBuilder
    {
        private List<Tuple<Type, Type>> stages = new List<Tuple<Type, Type>>();

        private PipelineBuilder(Type initialStage)
        {
            this.AddStage(null, initialStage);
        }

        public static PipelineBuilder Create<T>()
            where T : IStage
        {
            return new PipelineBuilder(typeof(T));
        }

        public PipelineBuilder Extend<T>()
            where T : IStage
        {
            this.AddStage(null, typeof(T));

            return this;
        }

        public PipelineBuilder Extend<TSetup, TStage>()
            where TSetup : IStage
            where TStage : IStage
        {
            this.AddStage(typeof(TSetup), typeof(TStage));

            return this;
        }

        private void AddStage(Type setup, Type stage)
        {
            this.stages.Add(Tuple.Create<Type, Type>(setup, stage));
        }

        public Pipeline Build<T>()
            where T : IOutput
        {
            return new Pipeline(this.stages, typeof(T));
        }
    }
}
