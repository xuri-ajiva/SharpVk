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

        [NodeType(ExpressionType.Negate)]
        private ResultId VisitNegate(UnaryExpression expression)
        {
            if (GetElementType(expression.Type) != typeof(float))
            {
                throw new NotSupportedException();
            }

            return VisitUnary(expression, Op.OpFNegate);
        }

        [NodeType(ExpressionType.Add)]
        private ResultId VisitAdd(BinaryExpression expression)
        {
            Op additionOp = SelectByType(expression.Type, Op.OpFAdd, Op.OpIAdd);

            return VisitBinary(expression, additionOp);
        }

        [NodeType(ExpressionType.Subtract)]
        private ResultId VisitSubtract(BinaryExpression expression)
        {
            Op subtractionOp = SelectByType(expression.Type, Op.OpFSub, Op.OpISub);

            return VisitBinary(expression, subtractionOp);
        }

        [NodeType(ExpressionType.Multiply)]
        private ResultId VisitMultiply(BinaryExpression expression)
        {
            Op multiplicationOp;

            if (IsVectorType(expression.Left.Type) && !IsVectorType(expression.Right.Type))
            {
                if (!IsFloatingPoint(GetVectorElementType(expression.Left.Type))
                        || !IsFloatingPoint(expression.Right.Type))
                {
                    throw new NotSupportedException();
                }

                multiplicationOp = Op.OpVectorTimesScalar;
            }
            else
            {
                multiplicationOp = SelectByType(expression.Type, Op.OpFMul, Op.OpIMul);
            }

            return VisitBinary(expression, multiplicationOp);
        }

        [NodeType(ExpressionType.Modulo)]
        private ResultId VisitModulo(BinaryExpression expression)
        {
            Op moduloOp = SelectByType(expression.Type, Op.OpFMod, Op.OpSMod, Op.OpUMod);

            return VisitBinary(expression, moduloOp);
        }

        [NodeType(ExpressionType.Divide)]
        private ResultId VisitDivide(BinaryExpression expression)
        {
            Op divisionOp = SelectByType(expression.Type, Op.OpFDiv, Op.OpSDiv, Op.OpUDiv);

            return VisitBinary(expression, divisionOp);
        }

        private ResultId VisitUnary(UnaryExpression expression, Op unaryOp)
        {
            ResultId resultTypeId = this.Visit(Expression.Constant(expression.Method.ReturnType));

            ResultId operand = this.Visit(expression.Operand);
            ResultId result = this.file.GetNextResultId();

            this.file.AddFunctionStatement(result, unaryOp, resultTypeId, operand);

            return result;
        }

        private ResultId VisitBinary(BinaryExpression expression, Op binaryOp)
        {
            ResultId resultTypeId = this.Visit(Expression.Constant(expression.Method.ReturnType));

            ResultId left = this.Visit(expression.Left);
            ResultId right = this.Visit(expression.Right);
            ResultId result = this.file.GetNextResultId();

            this.file.AddFunctionStatement(result, binaryOp, resultTypeId, left, right);

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

                    switch (fieldInfo.Name)
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
                else if (value.BaseType.IsGenericType && value.BaseType.GetGenericTypeDefinition() == typeof(Pointer<>))
                {
                    StorageClass storage = (StorageClass)value.GetProperty("Storage").GetValue(null);
                    ResultId typeId = this.Visit(Expression.Constant(value.GetGenericArguments()[0]));

                    statement = new SpirvStatement(Op.OpTypePointer, storage, typeId);
                }
                else if (IsTupleType(value))
                {
                    var fieldTypes = value.GetGenericArguments();

                    var fieldTypeIds = fieldTypes.Select(x => (object)this.Visit(Expression.Constant(x))).ToArray();

                    statement = new SpirvStatement(Op.OpTypeStruct, fieldTypeIds);
                }
                else if (value == typeof(float))
                {
                    statement = new SpirvStatement(Op.OpTypeFloat, 32);
                }
                else if (value == typeof(int))
                {
                    statement = new SpirvStatement(Op.OpTypeInt, 32, 1);
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
                statement = new SpirvStatement(Op.OpConstant, typeOperand, expression.Value);
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

        private static Op SelectByType(Type type, Op floatingPointOp, Op integerOp)
        {
            return SelectByType(type, floatingPointOp, integerOp, integerOp);
        }

        private static Op SelectByType(Type type, Op floatingPointOp, Op signedIntegerOp, Op unsignedIntegerOp)
        {
            type = GetElementType(type);

            if (IsFloatingPoint(type))
            {
                return floatingPointOp;
            }
            else if (IsSignedInteger(type))
            {
                return signedIntegerOp;
            }
            else if (IsUnsignedInteger(type))
            {
                return unsignedIntegerOp;
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        private static bool IsFloatingPoint(Type type)
        {
            return type == typeof(float) || type == typeof(double);
        }

        private static bool IsInteger(Type type)
        {
            return IsSignedInteger(type) || IsUnsignedInteger(type);
        }

        private static bool IsSignedInteger(Type type)
        {
            return type == typeof(sbyte)
                    || type == typeof(short)
                    || type == typeof(int)
                    || type == typeof(long);
        }

        private static bool IsUnsignedInteger(Type type)
        {
            return type == typeof(byte)
                    || type == typeof(ushort)
                    || type == typeof(uint)
                    || type == typeof(ulong);
        }

        private bool IsTupleType(Type value)
        {
            Type tupleInterface = typeof(Tuple).Assembly.GetType("System.ITuple");

            return value.GetInterfaces().Contains(tupleInterface);
        }

        private static Type GetElementType(Type type)
        {
            if (type.IsPrimitive)
            {
                return type;
            }
            else if (IsVectorType(type))
            {
                return GetVectorElementType(type);
            }
            else
            {
                throw new NotSupportedException();
            }
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

        private static bool IsVectorType(Type type)
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
