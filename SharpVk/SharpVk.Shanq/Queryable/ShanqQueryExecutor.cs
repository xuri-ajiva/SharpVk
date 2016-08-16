using Remotion.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq.Queryable
{
    public class ShanqQueryExecutor
            : IQueryExecutor
    {
        public string Result
        {
            get;
            private set;
        }

        public IEnumerable<T> ExecuteCollection<T>(QueryModel queryModel)
        {
            var resultType = typeof(T);

            var inputType = queryModel.MainFromClause.ItemType;

            var inputStructure = new DataStructure()
            {
                Fields = inputType
                            .GetFields()
                            .Select(ShanqUtil.Map)
                            .ToArray()
            };

            var builder = new HlslExpressionBuilder();

            var visitor = new ShanqExpressionVisitor(builder);

            if (ShanqUtil.IsPrimitiveType(resultType))
            {
                var outputDataField = new DataField("SV_POSITION", 0, ShanqUtil.Map(resultType));

                visitor.Visit(queryModel.SelectClause.Selector);

                var outputAssignment = builder.Assign(builder.OutputData(outputDataField), visitor.ResultExpression);

                var shader = builder.VertexShader(outputAssignment);

                this.Result = builder.Format(shader, new[] { inputStructure }, new DataStructure() { Fields = new[] { outputDataField } });
            }
            else
            {
                var initExpression = (MemberInitExpression)queryModel.SelectClause.Selector;

                var outputStructure = new DataStructure()
                {
                    Fields = resultType
                                .GetFields()
                                .Select(ShanqUtil.Map)
                                .ToArray()
                };

                var assignments = new List<IAssignStatement>();

                foreach (MemberAssignment binding in initExpression.Bindings)
                {
                    visitor.Visit(binding.Expression);

                    var outputAssignment = builder.Assign(builder.OutputData(ShanqUtil.Map((FieldInfo)binding.Member)), visitor.ResultExpression);

                    assignments.Add(outputAssignment);
                }

                var shader = builder.VertexShader(assignments.ToArray());

                this.Result = builder.Format(shader, new[] { inputStructure }, outputStructure);
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
