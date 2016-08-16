using Remotion.Linq;
using Remotion.Linq.Parsing.Structure;
using System.Linq;
using System.Linq.Expressions;

namespace SharpVk.Shanq.Queryable
{
    public class ShanqQueryable<T>
        : QueryableBase<T>, IShanqQueryable
    {
        private ShanqQueryExecutor executor;

        public ShanqQueryable(IQueryProvider provider, Expression expression)
            : base(provider, expression)
        {
            this.executor = (ShanqQueryExecutor)((QueryProviderBase)provider).Executor;
        }

        public ShanqQueryable(IQueryParser queryParser, IQueryExecutor executor)
            : base(new DefaultQueryProvider(typeof(ShanqQueryable<>), queryParser, executor))
        {
            this.executor = (ShanqQueryExecutor)executor;
        }

        public string Format()
        {
            this.ToArray();

            return this.executor.Result;
        }
    }

    public static class Queryable
    {

        public static IQueryable<T> Create<T>()
        {
            return new ShanqQueryable<T>(QueryParser.CreateDefault(), new ShanqQueryExecutor());
        }
    }
}
