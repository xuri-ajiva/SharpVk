using GlmSharp;
using Remotion.Linq.Clauses.Expressions;
using SharpVk.Spirv;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace SharpVk.Shanq
{
    internal class ShanqExpressionVisitor
    {
        private Dictionary<ExpressionType, Func<Expression, ResultId>> expressionVisitors = new Dictionary<ExpressionType, Func<Expression, ResultId>>();
        private Dictionary<SpirvStatement, ResultId> expressionResults = new Dictionary<SpirvStatement, ResultId>();
        private readonly SpirvFile file;
        private Dictionary<FieldInfo, ResultId> inputMappings = new Dictionary<FieldInfo, ResultId>();

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

        public void AddInputMapping(FieldInfo field, ResultId resultId)
        {
            this.inputMappings.Add(field, resultId);
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

        [NodeType(ExpressionType.Add)]
        private ResultId VisitAdd(BinaryExpression expression)
        {
            ResultId floatTypeId = this.Visit(Expression.Constant(typeof(float)));
            ResultId resultTypeId = this.Visit(Expression.Constant(expression.Left.Type));

            ResultId left = this.Visit(expression.Left);
            ResultId right = this.Visit(expression.Right);
            ResultId result = this.file.GetNextResultId();
            
            this.file.AddFunctionStatement(result, Op.OpFAdd, resultTypeId, left, right);

            return result;
        }


        [NodeType(ExpressionType.Divide)]
        private ResultId VisitDivide(BinaryExpression expression)
        {
            ResultId constantOne = this.Visit(Expression.Constant(1f));
            ResultId floatTypeId = this.Visit(Expression.Constant(typeof(float)));
            ResultId resultTypeId = this.Visit(Expression.Constant(expression.Left.Type));

            ResultId left = this.Visit(expression.Left);
            ResultId right = this.Visit(expression.Right);

            ResultId factorId = this.file.GetNextResultId();
            ResultId result = this.file.GetNextResultId();

            this.file.AddFunctionStatement(factorId, Op.OpFDiv, floatTypeId, constantOne, right);
            this.file.AddFunctionStatement(result, Op.OpVectorTimesScalar, resultTypeId, left, factorId);

            return result;
        }

        [NodeType(ExpressionType.MemberAccess)]
        private ResultId VisitMemberAccess(MemberExpression expression)
        {
            if (expression.Expression is QuerySourceReferenceExpression)
            {
                var fieldInfo = (FieldInfo)expression.Member;

                ResultId fieldId = this.inputMappings[fieldInfo];

                ResultId typeId = this.Visit(Expression.Constant(fieldInfo.FieldType));

                ResultId accessId = this.file.GetNextResultId();

                this.file.AddFunctionStatement(accessId, Op.OpLoad, typeId, fieldId);

                return accessId;
            }
            else
            {
                var targetType = expression.Expression.Type;

                if (IsVectorType(targetType))
                {
                    var fieldInfo = (FieldInfo)expression.Member;

                    int fieldIndex;

                    switch(fieldInfo.Name)
                    {
                        case "x":
                            fieldIndex = 0;
                            break;
                        case "y":
                            fieldIndex = 1;
                            break;
                        case "z":
                            fieldIndex = 2;
                            break;
                        case "w":
                            fieldIndex = 3;
                            break;
                        default:
                            throw new Exception($"Unsupported field: {fieldInfo.Name}");
                    }

                    ResultId targetId = this.Visit(expression.Expression);

                    ResultId typeId = this.Visit(Expression.Constant(fieldInfo.FieldType));

                    ResultId accessId = this.file.GetNextResultId();

                    this.file.AddFunctionStatement(accessId, Op.OpCompositeExtract, typeId, targetId, fieldIndex);

                    return accessId;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        [NodeType(ExpressionType.New)]
        private ResultId VisitNew(NewExpression expression)
        {
            SpirvStatement statement;

            if (IsVectorType(expression.Type))
            {
                var operands = new[] { this.Visit(Expression.Constant(expression.Type)) }
                                    .Concat(this.ExpandNewArguments(expression.Arguments));

                statement = new SpirvStatement(Op.OpCompositeConstruct, operands.Cast<object>().ToArray());
            }
            else
            {
                throw new NotImplementedException();
            }

            ResultId resultId = this.file.GetNextResultId();

            this.file.AddFunctionStatement(resultId, statement);

            return resultId;
        }

        private IEnumerable<ResultId> ExpandNewArguments(IEnumerable<Expression> arguments)
        {
            foreach (var argument in arguments)
            {
                ResultId argumentId = this.Visit(argument);

                if (IsVectorType(argument.Type))
                {
                    ResultId typeId = this.Visit(Expression.Constant(GetVectorElementType(argument.Type)));

                    for (int index = 0; index < GetVectorLength(argument.Type); index++)
                    {
                        ResultId fieldId = this.file.GetNextResultId();

                        this.file.AddFunctionStatement(fieldId, Op.OpCompositeExtract, typeId, argumentId, index);

                        yield return fieldId;
                    }
                }
                else
                {
                    yield return argumentId;
                }
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
                    Type elementType = GetVectorElementType(value);
                    int length = GetVectorLength(value);

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
                else if (value.IsGenericType && value.BaseType.GetGenericTypeDefinition() == typeof(Pointer<>))
                {
                    StorageClass storage = (StorageClass)value.GetProperty("Storage").GetValue(null);
                    ResultId typeId = this.Visit(Expression.Constant(value.GetGenericArguments()[0]));

                    statement = new SpirvStatement(Op.OpTypePointer, storage, typeId);
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

        private static Type GetVectorElementType(Type value)
        {
            return value.GetField("x").FieldType;
        }

        private static int GetVectorLength(Type value)
        {
            return ((IEnumerable)value.GetProperty("Zero")
                                .GetValue(null))
                                .OfType<object>()
                                .Count();
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
