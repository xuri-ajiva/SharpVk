using Remotion.Linq.Clauses.Expressions;
using Remotion.Linq.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;

namespace SharpVk.Shanq.Queryable
{
    public class ShanqExpressionVisitor
        : ThrowingExpressionVisitor
    {
        public List<IShaderStatement> Preamble = new List<IShaderStatement>();
        private HlslExpressionBuilder builder;

        public IRightHandShaderExpression ResultExpression
        {
            get;
            private set;
        }

        public ShanqExpressionVisitor(HlslExpressionBuilder builder)
        {
            this.builder = builder;
        }

        protected override Exception CreateUnhandledItemException<T>(T unhandledItem, string visitMethod)
        {
            throw new NotImplementedException(string.Format("Visit method not implemented for {0}.", visitMethod));
        }

        protected override Expression VisitMethodCall(MethodCallExpression expression)
        {
            Func<IEnumerable<IRightHandShaderExpression>, HlslExpressionBuilder, IRightHandShaderExpression> mapping;

            if (!ShanqUtil.MethodCallMappings.TryGetValue(expression.Method, out mapping))
            {
                throw new NotSupportedException();
            }

            this.ResultExpression = mapping(expression.Arguments.Select(this.VisitSubExpression), this.builder);

            return expression;
        }

        protected override Expression VisitNew(NewExpression expression)
        {
            if (ShanqUtil.IsPrimitiveType(expression.Type))
            {
                var arguments = expression.Arguments.Select(this.VisitSubExpression).ToArray();

                var createMethods = new Dictionary<Type, Func<IRightHandShaderExpression[], IRightHandShaderExpression>>
                {
                    { typeof(Vector4), this.builder.CreateFloat4 },
                    { typeof(Vector3), this.builder.CreateFloat3 },
                    { typeof(Vector2), this.builder.CreateFloat2 }
                };

                if (createMethods.ContainsKey(expression.Type))
                {
                    this.ResultExpression = createMethods[expression.Type](arguments);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                throw new NotSupportedException();
            }

            return expression;
        }

        protected override Expression VisitBinary(BinaryExpression expression)
        {
            var left = this.VisitSubExpression(expression.Left);
            var right = this.VisitSubExpression(expression.Right);

            switch (expression.NodeType)
            {
                case ExpressionType.Multiply:
                    this.ResultExpression = this.builder.Multiply(right, left);
                    break;
                default:
                    throw new NotImplementedException();
            }

            return expression;
        }

        protected override Expression VisitMember(MemberExpression expression)
        {
            if (expression.Expression.GetType() == typeof(QuerySourceReferenceExpression))
            {
                this.ResultExpression = this.builder.InputData(ShanqUtil.Map((FieldInfo)expression.Member));
            }
            else
            {
                this.ResultExpression = this.builder.MemberReference(this.VisitSubExpression(expression.Expression), expression.Member.Name, ShanqUtil.Map(expression.Type));
            }

            return expression;
        }

        private IRightHandShaderExpression VisitSubExpression(Expression expression)
        {
            var subVisitor = new ShanqExpressionVisitor(this.builder);

            subVisitor.Visit(expression);

            return subVisitor.ResultExpression;
        }

        protected override Expression VisitConstant(ConstantExpression expression)
        {
            this.ResultExpression = builder.Constant((float)expression.Value);

            return expression;
        }
    }
}
