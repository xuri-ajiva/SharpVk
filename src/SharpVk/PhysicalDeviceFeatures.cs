using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct PhysicalDeviceFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceFeatures(Bool32 robustBufferAccess, Bool32 fullDrawIndexUint32, Bool32 imageCubeArray, Bool32 independentBlend, Bool32 geometryShader, Bool32 tessellationShader, Bool32 sampleRateShading, Bool32 dualSourceBlend, Bool32 logicOp, Bool32 multiDrawIndirect, Bool32 drawIndirectFirstInstance, Bool32 depthClamp, Bool32 depthBiasClamp, Bool32 fillModeNonSolid, Bool32 depthBounds, Bool32 wideLines, Bool32 largePoints, Bool32 alphaToOne, Bool32 multiViewport, Bool32 samplerAnisotropy, Bool32 textureCompressionETC2, Bool32 texturecompressionastcLdr, Bool32 textureCompressionBC, Bool32 occlusionQueryPrecise, Bool32 pipelineStatisticsQuery, Bool32 vertexPipelineStoresAndAtomics, Bool32 fragmentStoresAndAtomics, Bool32 shaderTessellationAndGeometryPointSize, Bool32 shaderImageGatherExtended, Bool32 shaderStorageImageExtendedFormats, Bool32 shaderStorageImageMultisample, Bool32 shaderStorageImageReadWithoutFormat, Bool32 shaderStorageImageWriteWithoutFormat, Bool32 shaderUniformBufferArrayDynamicIndexing, Bool32 shaderSampledImageArrayDynamicIndexing, Bool32 shaderStorageBufferArrayDynamicIndexing, Bool32 shaderStorageImageArrayDynamicIndexing, Bool32 shaderClipDistance, Bool32 shaderCullDistance, Bool32 shaderFloat64, Bool32 shaderInt64, Bool32 shaderInt16, Bool32 shaderResourceResidency, Bool32 shaderResourceMinLod, Bool32 sparseBinding, Bool32 sparseResidencyBuffer, Bool32 sparseResidencyImage2D, Bool32 sparseResidencyImage3D, Bool32 sparseResidency2Samples, Bool32 sparseResidency4Samples, Bool32 sparseResidency8Samples, Bool32 sparseResidency16Samples, Bool32 sparseResidencyAliased, Bool32 variableMultisampleRate, Bool32 inheritedQueries)
        {
            this.RobustBufferAccess = robustBufferAccess;
            this.FullDrawIndexUint32 = fullDrawIndexUint32;
            this.ImageCubeArray = imageCubeArray;
            this.IndependentBlend = independentBlend;
            this.GeometryShader = geometryShader;
            this.TessellationShader = tessellationShader;
            this.SampleRateShading = sampleRateShading;
            this.DualSourceBlend = dualSourceBlend;
            this.LogicOp = logicOp;
            this.MultiDrawIndirect = multiDrawIndirect;
            this.DrawIndirectFirstInstance = drawIndirectFirstInstance;
            this.DepthClamp = depthClamp;
            this.DepthBiasClamp = depthBiasClamp;
            this.FillModeNonSolid = fillModeNonSolid;
            this.DepthBounds = depthBounds;
            this.WideLines = wideLines;
            this.LargePoints = largePoints;
            this.AlphaToOne = alphaToOne;
            this.MultiViewport = multiViewport;
            this.SamplerAnisotropy = samplerAnisotropy;
            this.TextureCompressionETC2 = textureCompressionETC2;
            this.TexturecompressionastcLdr = texturecompressionastcLdr;
            this.TextureCompressionBC = textureCompressionBC;
            this.OcclusionQueryPrecise = occlusionQueryPrecise;
            this.PipelineStatisticsQuery = pipelineStatisticsQuery;
            this.VertexPipelineStoresAndAtomics = vertexPipelineStoresAndAtomics;
            this.FragmentStoresAndAtomics = fragmentStoresAndAtomics;
            this.ShaderTessellationAndGeometryPointSize = shaderTessellationAndGeometryPointSize;
            this.ShaderImageGatherExtended = shaderImageGatherExtended;
            this.ShaderStorageImageExtendedFormats = shaderStorageImageExtendedFormats;
            this.ShaderStorageImageMultisample = shaderStorageImageMultisample;
            this.ShaderStorageImageReadWithoutFormat = shaderStorageImageReadWithoutFormat;
            this.ShaderStorageImageWriteWithoutFormat = shaderStorageImageWriteWithoutFormat;
            this.ShaderUniformBufferArrayDynamicIndexing = shaderUniformBufferArrayDynamicIndexing;
            this.ShaderSampledImageArrayDynamicIndexing = shaderSampledImageArrayDynamicIndexing;
            this.ShaderStorageBufferArrayDynamicIndexing = shaderStorageBufferArrayDynamicIndexing;
            this.ShaderStorageImageArrayDynamicIndexing = shaderStorageImageArrayDynamicIndexing;
            this.ShaderClipDistance = shaderClipDistance;
            this.ShaderCullDistance = shaderCullDistance;
            this.ShaderFloat64 = shaderFloat64;
            this.ShaderInt64 = shaderInt64;
            this.ShaderInt16 = shaderInt16;
            this.ShaderResourceResidency = shaderResourceResidency;
            this.ShaderResourceMinLod = shaderResourceMinLod;
            this.SparseBinding = sparseBinding;
            this.SparseResidencyBuffer = sparseResidencyBuffer;
            this.SparseResidencyImage2D = sparseResidencyImage2D;
            this.SparseResidencyImage3D = sparseResidencyImage3D;
            this.SparseResidency2Samples = sparseResidency2Samples;
            this.SparseResidency4Samples = sparseResidency4Samples;
            this.SparseResidency8Samples = sparseResidency8Samples;
            this.SparseResidency16Samples = sparseResidency16Samples;
            this.SparseResidencyAliased = sparseResidencyAliased;
            this.VariableMultisampleRate = variableMultisampleRate;
            this.InheritedQueries = inheritedQueries;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 RobustBufferAccess; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 FullDrawIndexUint32; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ImageCubeArray; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IndependentBlend; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 GeometryShader; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TessellationShader; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SampleRateShading; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DualSourceBlend; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 LogicOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 MultiDrawIndirect; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DrawIndirectFirstInstance; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthClamp; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthBiasClamp; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 FillModeNonSolid; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 DepthBounds; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 WideLines; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 LargePoints; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 AlphaToOne; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 MultiViewport; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SamplerAnisotropy; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TextureCompressionETC2; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TexturecompressionastcLdr; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TextureCompressionBC; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 OcclusionQueryPrecise; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 PipelineStatisticsQuery; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 VertexPipelineStoresAndAtomics; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 FragmentStoresAndAtomics; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderTessellationAndGeometryPointSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderImageGatherExtended; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageImageExtendedFormats; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageImageMultisample; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageImageReadWithoutFormat; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageImageWriteWithoutFormat; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderUniformBufferArrayDynamicIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderSampledImageArrayDynamicIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageBufferArrayDynamicIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderStorageImageArrayDynamicIndexing; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderClipDistance; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderCullDistance; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderFloat64; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderInt64; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderInt16; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderResourceResidency; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderResourceMinLod; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseBinding; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidencyBuffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidencyImage2D; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidencyImage3D; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidency2Samples; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidency4Samples; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidency8Samples; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidency16Samples; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 SparseResidencyAliased; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 VariableMultisampleRate; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 InheritedQueries; 
    }
}
