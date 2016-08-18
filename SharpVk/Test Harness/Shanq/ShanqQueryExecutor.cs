using Remotion.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SharpVk.Shanq
{
    public class ShanqQueryExecutor
        : IQueryExecutor
    {
        public IEnumerable<T> ExecuteCollection<T>(QueryModel queryModel)
        {
            var expressionVisitor = new ShanqExpressionVisitor();

            var constantSelector = queryModel.SelectClause.Selector as ConstantExpression;

            var resultType = typeof(T);

            if (constantSelector != null)
            {
                foreach(var field in resultType.GetFields())
                {
                    var fieldValue = field.GetValue(constantSelector.Value);

                    expressionVisitor.Visit(Expression.Constant(fieldValue, field.FieldType));
                }
            }

            return Enumerable.Empty<T>();
        }

        public T ExecuteScalar<T>(QueryModel queryModel)
        {
            throw new NotImplementedException();
        }

        public T ExecuteSingle<T>(QueryModel queryModel, bool returnDefaultWhenEmpty)
        {
            throw new NotImplementedException();
        }
    }
}
