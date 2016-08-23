using Remotion.Linq;
using SharpVk.Spirv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace SharpVk.Shanq
{
    public class ShanqQueryExecutor
        : IQueryExecutor
    {
        public IEnumerable<T> ExecuteCollection<T>(QueryModel queryModel)
        {
            var sink = new ConsoleSink();

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

            var resultType = typeof(T);

            foreach (var field in resultType.GetFields())
            {
                var typeId = expressionVisitor.Visit(Expression.Constant(field.FieldType));
                //HACK This should be compared for repetitions
                ResultId outputPointerId = file.GetNextResultId();
                ResultId outputVariableId = file.GetNextResultId();

                file.AddGlobalStatement(outputPointerId, Op.OpTypePointer, StorageClass.Output, typeId);
                file.AddGlobalStatement(outputVariableId, Op.OpVariable, outputPointerId, StorageClass.Output);

                fieldMapping.Add(field, outputVariableId);
            }

            file.AddHeaderStatement(Op.OpEntryPoint, new object[] { ExecutionModel.Fragment, entryPointerFunctionId, "main" }.Concat(fieldMapping.Select(x => x.Value).Distinct().Cast<object>()).ToArray());
            file.AddHeaderStatement(Op.OpExecutionMode, entryPointerFunctionId, ExecutionMode.OriginUpperLeft);

            foreach(var mapping in fieldMapping)
            {
                var attribute = mapping.Key.GetCustomAttribute<LocationAttribute>();

                file.AddHeaderStatement(Op.OpDecorate, mapping.Value, Decoration.Location, attribute.LocationIndex);
            }

            var constantSelector = queryModel.SelectClause.Selector as ConstantExpression;

            if (constantSelector != null)
            {
                foreach (var field in resultType.GetFields())
                {
                    var fieldValue = field.GetValue(constantSelector.Value);

                    ResultId valueId = expressionVisitor.Visit(Expression.Constant(fieldValue, field.FieldType));

                    file.AddFunctionStatement(Op.OpStore, fieldMapping[field], valueId);
                }
            }

            file.AddFunctionStatement(Op.OpReturn);
            file.AddFunctionStatement(Op.OpFunctionEnd);

            foreach (var entry in file.Entries)
            {
                sink.AddStatement(entry.ResultId, entry.Statement);
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
