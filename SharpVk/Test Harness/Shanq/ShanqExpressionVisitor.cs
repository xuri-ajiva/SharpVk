using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using GlmSharp;
using SharpVk.Spirv;

namespace SharpVk.Shanq
{
    internal class ShanqExpressionVisitor
    {
        private Dictionary<ExpressionType, Func<Expression, int>> expressionVisitors = new Dictionary<ExpressionType, Func<Expression, int>>();
        private Dictionary<ShanqStatement, int> expressionResults = new Dictionary<ShanqStatement, int>();
        private int nextResultId = 0;

        public ShanqExpressionVisitor()
        {
            var visitMethods = this.GetType()
                                    .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                                    .Where(method => method.GetCustomAttribute<NodeTypeAttribute>() != null);

            foreach (var method in visitMethods)
            {
                var attribute = method.GetCustomAttribute<NodeTypeAttribute>();

                this.expressionVisitors.Add(attribute.NodeType, x => (int)method.Invoke(this, new object[] { x }));
            }
        }

        public int Visit(Expression expression)
        {
            Func<Expression, int> visit;

            if (!this.expressionVisitors.TryGetValue(expression.NodeType, out visit))
            {
                throw new NotImplementedException();
            }
            else
            {
                return visit(expression);
            }
        }

        [NodeType(ExpressionType.Constant)]
        private int VisitConstant(ConstantExpression expression)
        {
            ShanqStatement statement = null;

            if (expression.Type == typeof(vec4))
            {
                vec4 value = (vec4)expression.Value;

                var operands = new object[] { typeof(float), value.x, value.y, value.z, value.w }
                                    .Select(x => (ShanqOperand)this.Visit(Expression.Constant(x)));

                statement = new ShanqStatement(Op.OpConstantComposite, operands.ToArray());
            }
            else if (typeof(Type).IsAssignableFrom(expression.Type))
            {
                statement = new ShanqStatement(Op.OpTypeFloat);
            }
            else
            {
                statement = new ShanqStatement(Op.OpConstant, (float)expression.Value);
            }

            int resultId;

            if (!this.expressionResults.TryGetValue(statement, out resultId))
            {
                resultId = ++this.nextResultId;

                this.expressionResults.Add(statement, resultId);
            }

            return resultId;
        }

        private class NodeTypeAttribute
            : Attribute
        {
            public NodeTypeAttribute(ExpressionType nodeType)
            {
                this.NodeType = nodeType;
            }

            public ExpressionType NodeType
            {
                get;
                private set;
            }
        }
    }
}
