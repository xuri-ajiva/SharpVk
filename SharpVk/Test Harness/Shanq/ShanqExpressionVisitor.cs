using System;
using System.Linq.Expressions;
using Remotion.Linq.Parsing;
using System.Collections.Generic;

namespace SharpVk.Shanq
{
    internal class ShanqExpressionVisitor
    {
        private Dictionary<ExpressionType, Action<Expression>> expressionVisitors = new Dictionary<ExpressionType, Action<Expression>>();

        public ShanqExpressionVisitor()
        {

        }

        public void Visit(Expression expression)
        {
            Action<Expression> visit;

            if(!this.expressionVisitors.TryGetValue(expression.NodeType, out visit))
            {

            }
        }

        [NodeType(ExpressionType.Constant)]
        private void Visit(ConstantExpression expression)
        {
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
