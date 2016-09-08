using Remotion.Linq;
using SharpVk.Spirv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace SharpVk.Shanq
{
    public class ShanqQueryExecutor
        : IQueryExecutor
    {
        private readonly ExecutionModel model;
        private readonly Stream outputStream;

        public ShanqQueryExecutor(ExecutionModel model, Stream outputStream)
        {
            this.model = model;
            this.outputStream = outputStream;
        }

        public IEnumerable<T> ExecuteCollection<T>(QueryModel queryModel)
        {
            var file = new SpirvFile();

            file.AddHeaderStatement(Op.OpCapability, Capability.Shader);
            file.AddHeaderStatement(file.GetNextResultId(), Op.OpExtInstImport, "GLSL.std.450");
            file.AddHeaderStatement(Op.OpMemoryModel, AddressingModel.Logical, MemoryModel.GLSL450);

            var expressionVisitor = new ShanqExpressionVisitor(file);

            ResultId voidId = expressionVisitor.Visit(Expression.Constant(typeof(void)));
            ResultId actionId = expressionVisitor.Visit(Expression.Constant(typeof(Action)));

            ResultId entryPointerFunctionId = file.GetNextResultId();
            ResultId entryPointerLabelId = file.GetNextResultId();

            file.AddFunctionStatement(entryPointerFunctionId, Op.OpFunction, voidId, FunctionControl.None, actionId);
            file.AddFunctionStatement(entryPointerLabelId, Op.OpLabel);

            var fieldMapping = new Dictionary<FieldInfo, ResultId>();
            var builtinList = new Dictionary<FieldInfo, Tuple<ResultId, int>>();

            bool hasBuiltInOutput = false;

            var resultType = typeof(T);

            foreach (var field in resultType.GetFields())
            {
                if (field.GetCustomAttribute<LocationAttribute>() != null)
                {
                    var pointerType = typeof(OutputPointer<>).MakeGenericType(field.FieldType);
                    ResultId outputPointerId = expressionVisitor.Visit(Expression.Constant(pointerType));
                    ResultId outputVariableId = file.GetNextResultId();

                    file.AddGlobalStatement(outputVariableId, Op.OpVariable, outputPointerId, StorageClass.Output);

                    fieldMapping.Add(field, outputVariableId);
                }

                hasBuiltInOutput |= field.GetCustomAttribute<BuiltInAttribute>() != null;
            }

            var inputType = queryModel.MainFromClause.ItemType;

            foreach (var field in inputType.GetFields())
            {
                if (field.GetCustomAttribute<LocationAttribute>() != null)
                {
                    var pointerType = typeof(InputPointer<>).MakeGenericType(field.FieldType);
                    ResultId inputPointerId = expressionVisitor.Visit(Expression.Constant(pointerType));
                    ResultId inputVariableId = file.GetNextResultId();

                    file.AddGlobalStatement(inputVariableId, Op.OpVariable, inputPointerId, StorageClass.Input);

                    fieldMapping.Add(field, inputVariableId);

                    expressionVisitor.AddInputMapping(field, inputVariableId);
                }
            }

            if (hasBuiltInOutput)
            {
                var builtInFields = resultType.GetFields().Select(x => new { Field = x, BuiltIn = x.GetCustomAttribute<BuiltInAttribute>()?.BuiltIn })
                                                            .Where(x => x.BuiltIn != null);

                var structureType = GetTupleType(builtInFields.Count()).MakeGenericType(builtInFields.Select(x => x.Field.FieldType).ToArray());

                var structurePointerType = typeof(OutputPointer<>).MakeGenericType(structureType);
                ResultId structurePointerId = expressionVisitor.Visit(Expression.Constant(structurePointerType));
                
                file.AddAnnotationStatement(Op.OpDecorate, structurePointerId, Decoration.Block);

                foreach (var field in builtInFields.Select((x, y) => new { Index = y, Value = x.BuiltIn.Value }))
                {
                    file.AddAnnotationStatement(Op.OpMemberDecorate, structurePointerId, field.Index, Decoration.BuiltIn, field.Value);
                }
            }

            file.AddHeaderStatement(Op.OpEntryPoint, new object[] { this.model, entryPointerFunctionId, "main" }.Concat(fieldMapping.Select(x => x.Value).Distinct().Cast<object>()).ToArray());
            file.AddHeaderStatement(Op.OpExecutionMode, entryPointerFunctionId, ExecutionMode.OriginUpperLeft);

            foreach (var mapping in fieldMapping)
            {
                if (mapping.Key.GetCustomAttribute<LocationAttribute>() != null)
                {
                    var attribute = mapping.Key.GetCustomAttribute<LocationAttribute>();

                    file.AddAnnotationStatement(Op.OpDecorate, mapping.Value, Decoration.Location, attribute.LocationIndex);
                }
            }

            var selector = queryModel.SelectClause.Selector;

            switch (selector.NodeType)
            {
                case ExpressionType.Constant:
                    foreach (var field in resultType.GetFields())
                    {
                        var fieldValue = field.GetValue(((ConstantExpression)queryModel.SelectClause.Selector).Value);

                        ResultId valueId = expressionVisitor.Visit(Expression.Constant(fieldValue, field.FieldType));

                        file.AddFunctionStatement(Op.OpStore, fieldMapping[field], valueId);
                    }
                    break;
                case ExpressionType.MemberInit:
                    var initExpression = (MemberInitExpression)selector;

                    foreach (var binding in initExpression.Bindings)
                    {
                        var fieldValue = ((MemberAssignment)binding).Expression;

                        ResultId valueId = expressionVisitor.Visit(fieldValue);

                        var field = (FieldInfo)binding.Member;

                        if (fieldMapping.ContainsKey(field))
                        {
                            file.AddFunctionStatement(Op.OpStore, fieldMapping[field], valueId);
                        }
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }

            file.AddFunctionStatement(Op.OpReturn);
            file.AddFunctionStatement(Op.OpFunctionEnd);

            int bound = file.Entries.Select(x => x.ResultId)
                                        .Where(x => x.HasValue)
                                        .Max(x => x.Value.Id) + 1;

            var sink = new BinarySink(this.outputStream, bound);

            foreach (var entry in file.Entries)
            {
                sink.AddStatement(entry.ResultId, entry.Statement);
            }

            return Enumerable.Empty<T>();
        }

        private static Type GetTupleType(int count)
        {
            switch (count)
            {
                case 1:
                    return typeof(Tuple<>);
                case 2:
                    return typeof(Tuple<,>);
                case 3:
                    return typeof(Tuple<,,>);
                case 4:
                    return typeof(Tuple<,,,>);
                case 5:
                    return typeof(Tuple<,,,,>);
                case 6:
                    return typeof(Tuple<,,,,,>);
                case 7:
                    return typeof(Tuple<,,,,,,>);
                case 8:
                    return typeof(Tuple<,,,,,,,>);
                default:
                    throw new NotSupportedException();
            }
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
