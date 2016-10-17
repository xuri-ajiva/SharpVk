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

        public ShanqQueryable(QueryableOrigin origin, IQueryParser queryParser, IQueryExecutor executor)
            : base(new DefaultQueryProvider(typeof(ShanqQueryable<>), queryParser, executor))
        {
            this.Origin = origin;
            this.executor = (ShanqQueryExecutor)executor;
        }

        public QueryableOrigin Origin
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
    }
}
