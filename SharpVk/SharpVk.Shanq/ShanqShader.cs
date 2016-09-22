using Remotion.Linq.Parsing.Structure;
using SharpVk.Spirv;
using System;
using System.IO;
using System.Linq;

namespace SharpVk.Shanq
{
    public interface IShanqFactory
    {
        IQueryable<T> GetInput<T>();

        IQueryable<T> GetBinding<T>();
    }

    internal class ShanqFactory
        : IShanqFactory
    {
        private readonly ShanqQueryExecutor executor;

        public ShanqFactory(ExecutionModel model, Stream outputStream)
        {
            this.executor = new ShanqQueryExecutor(model, outputStream);
        }

        public IQueryable<T> GetBinding<T>()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetInput<T>()
        {
            return new ShanqQueryable<T>(QueryParser.CreateDefault(), this.executor);
        }
    }

    public static class ShanqShader
    {
        public static void Create<TOutput>(ExecutionModel model, Stream outputStream, Func<IShanqFactory, IQueryable<TOutput>> shaderFunction)
        {
            var factory = new ShanqFactory(model, outputStream);

            shaderFunction(factory).ToArray();
        }

        public static void CreateFragment<TOutput>(Stream outputStream, Func<IShanqFactory, IQueryable<TOutput>> shaderFunction)
        {
            Create(ExecutionModel.Fragment, outputStream, shaderFunction);
        }

        public static ShaderModule CreateVertexModule<TOutput>(Device device, Func<IShanqFactory, IQueryable<TOutput>> shaderFunction)
        {
            return CreateModule(device, ExecutionModel.Vertex, shaderFunction);
        }

        public static ShaderModule CreateFragmentModule<TOutput>(Device device, Func<IShanqFactory, IQueryable<TOutput>> shaderFunction)
        {
            return CreateModule(device, ExecutionModel.Fragment, shaderFunction);
        }

        private static ShaderModule CreateModule<TOutput>(Device device, ExecutionModel model, Func<IShanqFactory, IQueryable<TOutput>> shaderFunction)
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
