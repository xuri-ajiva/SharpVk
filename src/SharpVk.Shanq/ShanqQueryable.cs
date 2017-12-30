using Remotion.Linq;
using Remotion.Linq.Parsing.Structure;
using System.Linq;
using System.Linq.Expressions;

namespace SharpVk.Shanq
{
    internal class ShanqQueryable<T>
        : QueryableBase<T>, IShanqQueryable
    {
        private ShanqQueryExecutor executor;

        public ShanqQueryable(IQueryProvider provider, Expression expression)
            : base(provider, expression)
        {
            this.executor = (ShanqQueryExecutor)((QueryProviderBase)provider).Executor;
        }

        public ShanqQueryable(QueryableOrigin origin, IQueryParser queryParser, IQueryExecutor executor, int binding = 0, int descriptorSet = 0)
            : base(new DefaultQueryProvider(typeof(ShanqQueryable<>), queryParser, executor))
        {
            this.Origin = origin;
            this.Binding = binding;
            this.DescriptorSet = descriptorSet;
            this.executor = (ShanqQueryExecutor)executor;
        }

        public QueryableOrigin Origin
        {
            get;
            private set;
        }

        public int Binding
        {
            get;
            private set;
        }

        public int DescriptorSet
        {
            get;
            private set;
        }
    }

    internal interface IShanqQueryable
    {
        QueryableOrigin Origin
        {
            get;
        }

        int Binding
        {
            get;
        }

        int DescriptorSet
        {
            get;
        }
    }
}
