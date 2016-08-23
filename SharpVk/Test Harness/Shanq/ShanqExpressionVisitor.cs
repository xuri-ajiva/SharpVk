using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using GlmSharp;
using SharpVk.Spirv;
using System.Collections;

namespace SharpVk.Shanq
{
    internal class ShanqExpressionVisitor
    {
        private Dictionary<ExpressionType, Func<Expression, ResultId>> expressionVisitors = new Dictionary<ExpressionType, Func<Expression, ResultId>>();
        private Dictionary<SpirvStatement, ResultId> expressionResults = new Dictionary<SpirvStatement, ResultId>();
        private readonly SpirvFile file;

        public ShanqExpressionVisitor(SpirvFile file)
        {
            var visitMethods = this.GetType()
                                    .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                                    .Where(method => method.GetCustomAttribute<NodeTypeAttribute>() != null);

            foreach (var method in visitMethods)
            {
                var attribute = method.GetCustomAttribute<NodeTypeAttribute>();

                this.expressionVisitors.Add(attribute.NodeType, x => (ResultId)method.Invoke(this, new object[] { x }));
            }

            this.file = file;
        }

        public ResultId Visit(Expression expression)
        {
            Func<Expression, ResultId> visit;

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
        private ResultId VisitConstant(ConstantExpression expression)
        {
            SpirvStatement statement;

            if (IsVectorType(expression.Type))
            {
                var operands = new object[] { expression.Type }
                                    .Concat(((IEnumerable)expression.Value).OfType<object>())
                                    .Select(x => (object)this.Visit(Expression.Constant(x)));

                statement = new SpirvStatement(Op.OpConstantComposite, operands.ToArray());
            }
            else if (typeof(Type).IsAssignableFrom(expression.Type))
            {
                Type value = (Type)expression.Value;

                if (IsVectorType(value))
                {
                    Type elementType = value.GetField("x").FieldType;

                    int length = ((IEnumerable)value.GetProperty("Zero", BindingFlags.Public | BindingFlags.Static)
                                        .GetValue(null))
                                        .OfType<object>()
                                        .Count();

                    ResultId elementTypeId = this.Visit(Expression.Constant(elementType));

                    statement = new SpirvStatement(Op.OpTypeVector, elementTypeId, length);
                }
                else if (typeof(Delegate).IsAssignableFrom(value))
                {
                    var returnType = value.GetMethod("Invoke").ReturnType;

                    ResultId returnTypeId = this.Visit(Expression.Constant(returnType));

                    if (value.GetMethod("Invoke").GetParameters().Length > 0)
                    {
                        throw new NotImplementedException();
                    }

                    statement = new SpirvStatement(Op.OpTypeFunction, returnTypeId);
                }
                else if (value == typeof(float))
                {
                    statement = new SpirvStatement(Op.OpTypeFloat, 32);
                }
                else if (value == typeof(void))
                {
                    statement = new SpirvStatement(Op.OpTypeVoid);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                ResultId typeOperand = this.Visit(Expression.Constant(expression.Type));
                statement = new SpirvStatement(Op.OpConstant, typeOperand, (float)expression.Value);
            }

            ResultId resultId;

            if (!this.expressionResults.TryGetValue(statement, out resultId))
            {
                resultId = this.file.GetNextResultId();

                this.expressionResults.Add(statement, resultId);

                this.file.AddGlobalStatement(resultId, statement);
            }

            return resultId;
        }

        private bool IsVectorType(Type type)
        {
            return type.Assembly == typeof(vec3).Assembly
                && type.Name.Contains("vec");
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
