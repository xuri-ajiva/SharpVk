using System;
using System.Linq;

namespace SharpVk.Shanq.GlmSharp
{
    public static class DeviceExtensions
    {
        public static ShaderModule CreateVertexModule<TOutput>(this Device device, Func<IShanqFactory, IQueryable<TOutput>> shaderFunction)
        {
            return ShanqShader.CreateVertexModule(device, VectorTypeLibrary.Instance, shaderFunction);
        }

        public static ShaderModule CreateFragmentModule<TOutput>(this Device device, IVectorTypeLibrary vectorLibrary, Func<IShanqFactory, IQueryable<TOutput>> shaderFunction)
        {
            return ShanqShader.CreateFragmentModule(device, VectorTypeLibrary.Instance, shaderFunction);
        }
    }
}
