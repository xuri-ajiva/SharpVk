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

        public ShanqFactory(ExecutionModel model, Stream outputStream, IVectorTypeLibrary vectorLibrary)
        {
            this.executor = new ShanqQueryExecutor(model, outputStream, vectorLibrary);
        }

        public IQueryable<T> GetBinding<T>()
        {
            return new ShanqQueryable<T>(QueryableOrigin.Binding, QueryParser.CreateDefault(), this.executor);
        }

        public IQueryable<T> GetInput<T>()
        {
            return new ShanqQueryable<T>(QueryableOrigin.Input, QueryParser.CreateDefault(), this.executor);
        }
    }

    public static class ShanqShader
    {
        public static void Create<TOutput>(ExecutionModel model, Stream outputStream, IVectorTypeLibrary vectorLibrary, Func<IShanqFactory, IQueryable<TOutput>> shaderFunction)
        {
            var factory = new ShanqFactory(model, outputStream, vectorLibrary);

            shaderFunction(factory).ToArray();
        }

        public static void CreateFragment<TOutput>(Stream outputStream, IVectorTypeLibrary vectorLibrary, Func<IShanqFactory, IQueryable<TOutput>> shaderFunction)
        {
            Create(ExecutionModel.Fragment, outputStream, vectorLibrary, shaderFunction);
        }

        public static ShaderModule CreateVertexModule<TOutput>(Device device, IVectorTypeLibrary vectorLibrary, Func<IShanqFactory, IQueryable<TOutput>> shaderFunction)
        {
            return CreateModule(device, vectorLibrary, ExecutionModel.Vertex, shaderFunction);
        }

        public static ShaderModule CreateFragmentModule<TOutput>(Device device, IVectorTypeLibrary vectorLibrary, Func<IShanqFactory, IQueryable<TOutput>> shaderFunction)
        {
            return CreateModule(device, vectorLibrary, ExecutionModel.Fragment, shaderFunction);
        }

        private static ShaderModule CreateModule<TOutput>(Device device, IVectorTypeLibrary vectorLibrary, ExecutionModel model, Func<IShanqFactory, IQueryable<TOutput>> shaderFunction)
        {
            var shaderStream = new MemoryStream();

            Create(model, shaderStream, vectorLibrary, shaderFunction);

            int shaderLength = (int)shaderStream.Length;

            var shaderBytes = shaderStream.GetBuffer();

            var shaderData = LoadShaderData(shaderBytes, shaderLength);

            return device.CreateShaderModule(shaderLength, shaderData);
        }

        private static uint[] LoadShaderData(byte[] shaderBytes, int codeSize)
        {
            var shaderData = new uint[(int)Math.Ceiling(codeSize / 4f)];

            System.Buffer.BlockCopy(shaderBytes, 0, shaderData, 0, codeSize);

            return shaderData;
        }
    }
}
