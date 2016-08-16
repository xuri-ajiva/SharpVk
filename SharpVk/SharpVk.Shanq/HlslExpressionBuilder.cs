using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpVk.Shanq.Hlsl;

namespace SharpVk.Shanq
{
    public class HlslExpressionBuilder
    {
        public ILeftHandShaderExpression MemberReference(ILeftHandShaderExpression valueExpression, string memberName, ShaderType type)
        {
            return new MemberReferenceExpression(valueExpression, memberName, type);
        }

        public IRightHandShaderExpression MemberReference(IRightHandShaderExpression valueExpression, string memberName, ShaderType type)
        {
            return new MemberReferenceExpression(valueExpression, memberName, type);
        }

        public IRightHandShaderExpression InputData(DataField dataField)
        {
            return new InputDataExpression(dataField);
        }

        public IRightHandShaderExpression InputData(string semantic, int index, ShaderType type)
        {
            return this.InputData(new DataField(semantic, index, type));
        }

        public ILeftHandShaderExpression OutputData(DataField dataField)
        {
            return new OutputDataExpression(dataField);
        }

        public ILeftHandShaderExpression OutputData(string semantic, int index, ShaderType type)
        {
            return this.OutputData(new DataField(semantic, index, type));
        }

        public IRightHandShaderExpression Multiply(IRightHandShaderExpression left, IRightHandShaderExpression right)
        {
            return new FunctionExpression(IntrinsicFunction.Multiply, left, right);
        }

        public IRightHandShaderExpression InputStructure()
        {
            return new InputStructureReferenceExpression();
        }

        public IRightHandShaderExpression Constant(float value)
        {
            return new ConstantExpression(value);
        }

        public IRightHandShaderExpression CreateVector(ShaderType vectorType, params IRightHandShaderExpression[] arguments)
        {
            return new CreateVectorExpression(vectorType, arguments);
        }

        public IRightHandShaderExpression CreateFloat4(params IRightHandShaderExpression[] arguments)
        {
            return new CreateVectorExpression(ShaderType.Float4, arguments);
        }

        public IRightHandShaderExpression CreateFloat3(params IRightHandShaderExpression[] arguments)
        {
            return new CreateVectorExpression(ShaderType.Float3, arguments);
        }

        public IRightHandShaderExpression CreateFloat2(params IRightHandShaderExpression[] arguments)
        {
            return new CreateVectorExpression(ShaderType.Float2, arguments);
        }

        public IAssignStatement Assign(ILeftHandShaderExpression target, IRightHandShaderExpression source)
        {
            return new AssignStatement(target, source);
        }

        public IVertexShader VertexShader(params IAssignStatement[] statements)
        {
            return new VertexShader(statements);
        }

        public IRightHandShaderExpression Cast(ShaderType type, IRightHandShaderExpression value)
        {
            return new CastExpression(type, value);
        }


        public string Format(IRightHandShaderExpression expression, IEnumerable<DataStructure> inputs)
        {
            var info = new ShaderFormatInfo(inputs, new DataStructure());

            return string.Format("return {0};", expression.Format(info));
        }

        public string Format(IVertexShader vertexShader, IEnumerable<DataStructure> inputs, DataStructure output)
        {
            var info = new ShaderFormatInfo(inputs, output);

            var shaderBuilder = new StringBuilder();

            string outputStructureName = info.GetStructureName(DataStructureType.Output);
            string inputStructureName = info.GetStructureName(DataStructureType.Input);

            foreach (var input in inputs)
            {
                if (input.Index.HasValue)
                {
                    shaderBuilder.AppendFormat("cbuffer {0} : register(b{1})", info.GetStructureName(DataStructureType.Input, input.Index), input.Index);
                }
                else
                {
                    shaderBuilder.AppendFormat("struct ShaderInput");
                }

                FormatStructureBody(info, shaderBuilder, input, DataStructureType.Input);
            }

            shaderBuilder.AppendFormat("struct ShaderOutput");
            FormatStructureBody(info, shaderBuilder, output, DataStructureType.Output);

            shaderBuilder.AppendFormat("ShaderOutput Shader(ShaderInput {0})", inputStructureName);
            shaderBuilder.AppendLine();
            shaderBuilder.AppendLine("{");
            shaderBuilder.AppendFormat("    ShaderOutput {0};", outputStructureName);
            shaderBuilder.AppendLine();
            shaderBuilder.AppendLine();

            shaderBuilder.AppendLine(string.Join("\n", vertexShader.Statements.Select(x => "    " + info.Format(x))));
            shaderBuilder.AppendLine();

            shaderBuilder.AppendFormat("    return {0};", outputStructureName);
            shaderBuilder.AppendLine();
            shaderBuilder.AppendLine("}");

            return shaderBuilder.ToString();
        }

        private static void FormatStructureBody(ShaderFormatInfo info, StringBuilder shaderBuilder, DataStructure input, DataStructureType dataStructureType)
        {
            shaderBuilder.AppendLine();
            shaderBuilder.AppendLine("{");
            foreach (var dataField in input.Fields)
            {
                shaderBuilder.AppendFormat("    {0} {1}    : {2}{3};", dataField.Type.TypeToken, info.GetStructureFieldName(dataStructureType, dataField), dataField.Semantic, dataField.Index);
                shaderBuilder.AppendLine();
            }
            shaderBuilder.AppendLine("};");
            shaderBuilder.AppendLine();
        }

        private class ShaderFormatInfo
            : IShaderFormatInfo
        {
            private struct DataFieldMapping
            {
                public int FieldIndex;
                public int? DataStructureIndex;
            }

            private Dictionary<DataField, DataFieldMapping> inputFields = new Dictionary<DataField, DataFieldMapping>();
            private Dictionary<DataField, DataFieldMapping> outputFields = new Dictionary<DataField, DataFieldMapping>();

            public ShaderFormatInfo(IEnumerable<DataStructure> inputs, DataStructure output)
            {
                int inputFieldCounter = 0;

                foreach (var input in inputs)
                {
                    foreach (var dataField in input.Fields)
                    {
                        inputFields.Add(dataField, new DataFieldMapping() { FieldIndex = ++inputFieldCounter, DataStructureIndex = input.Index });
                    }
                }

                int outputFieldCounter = 0;

                if (output.Fields != null)
                {
                    foreach (var dataField in output.Fields)
                    {
                        outputFields.Add(dataField, new DataFieldMapping() { FieldIndex = ++outputFieldCounter });
                    }
                }
            }

            public string Format(IShaderExpression expression)
            {
                return expression.Format(this);
            }

            public string Format(IShaderStatement statement)
            {
                return statement.Format(this);
            }

            public string GetStructureField(DataStructureType dataStructure, DataField inputData)
            {
                DataFieldMapping fieldMapping;
                string fieldName = GetStructureFieldName(dataStructure, inputData, out fieldMapping);

                if (fieldMapping.DataStructureIndex.HasValue)
                {
                    return fieldName;
                }
                else
                {
                    string structureName = this.GetStructureName(dataStructure);

                    return string.Format("{0}.{1}", structureName, fieldName);
                }
            }

            public string GetStructureFieldName(DataStructureType dataStructure, DataField inputData)
            {
                DataFieldMapping fieldMapping;

                return this.GetStructureFieldName(dataStructure, inputData, out fieldMapping);
            }

            private string GetStructureFieldName(DataStructureType dataStructure, DataField inputData, out DataFieldMapping fieldMapping)
            {
                switch (dataStructure)
                {
                    case DataStructureType.Input:
                        if (!this.inputFields.TryGetValue(inputData, out fieldMapping))
                        {
                            throw new Exception("Undeclared input semantic: " + inputData.Semantic);
                        }
                        break;
                    case DataStructureType.Output:
                        if (!this.outputFields.TryGetValue(inputData, out fieldMapping))
                        {
                            throw new Exception("Undeclared output semantic: " + inputData.Semantic);
                        }
                        break;
                    default:
                        throw new NotSupportedException();
                }

                return "Field" + fieldMapping.FieldIndex;
            }

            public string GetStructureName(DataStructureType dataStructure, int? dataStructureIndex = null)
            {
                switch (dataStructure)
                {
                    case DataStructureType.Input:
                        if (dataStructureIndex.HasValue)
                        {
                            return "buffer" + dataStructureIndex;
                        }
                        else
                        {
                            return "input";
                        }
                    case DataStructureType.Output:
                        return "output";
                    default:
                        throw new NotSupportedException();
                }
            }
        }
    }
}
