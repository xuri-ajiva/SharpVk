using Remotion.Linq.Parsing.Structure;
using SharpVk.Spirv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpVk.Shanq
{
    public static class ShanqShader<TInput>
    {
        public static void CreateFragment<TOutput>(Stream outputStream, Func<IQueryable<TInput>, IQueryable<TOutput>> shaderFunction)
        {
            Create(ExecutionModel.Fragment, outputStream, shaderFunction);
        }

        public static void Create<TOutput>(ExecutionModel model, Stream outputStream, Func<IQueryable<TInput>, IQueryable<TOutput>> shaderFunction)
        {
            var queryable = new ShanqQueryable<TInput>(QueryParser.CreateDefault(), new ShanqQueryExecutor(model, outputStream));

            shaderFunction(queryable).ToArray();
        }

        public static ShaderModule CreateVertexModule<TOutput>(Device device, Func<IQueryable<TInput>, IQueryable<TOutput>> shaderFunction)
        {
            return CreateModule(device, ExecutionModel.Vertex, shaderFunction);
        }

        public static ShaderModule CreateFragmentModule<TOutput>(Device device, Func<IQueryable<TInput>, IQueryable<TOutput>> shaderFunction)
        {
            return CreateModule(device, ExecutionModel.Fragment, shaderFunction);
        }

        private static ShaderModule CreateModule<TOutput>(Device device, ExecutionModel model, Func<IQueryable<TInput>, IQueryable<TOutput>> shaderFunction)
        {
            var shaderStream = new MemoryStream();

            Create(model, shaderStream, shaderFunction);

            int shaderLength = (int)shaderStream.Length;

            var shaderBytes = shaderStream.GetBuffer();

            var shaderData = LoadShaderData(shaderBytes, shaderLength);

            return device.CreateShaderModule(new ShaderModuleCreateInfo
            {
                Code = shaderData,
                CodeSize = shaderLength
            });
        }

        private static uint[] LoadShaderData(byte[] shaderBytes, int codeSize)
        {
            var shaderData = new uint[(int)Math.Ceiling(codeSize / 4f)];

            System.Buffer.BlockCopy(shaderBytes, 0, shaderData, 0, codeSize);

            return shaderData;
        }
    }
}
