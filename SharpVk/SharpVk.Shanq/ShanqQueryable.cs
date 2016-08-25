using Remotion.Linq;
using Remotion.Linq.Parsing.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq
{
    public class ShanqQueryable<T>
        : QueryableBase<T>
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
    }
}
