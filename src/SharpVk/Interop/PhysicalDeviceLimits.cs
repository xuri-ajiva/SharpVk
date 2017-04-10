using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceLimits
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceLimits(uint maxImageDimension1D, uint maxImageDimension2D, uint maxImageDimension3D, uint maxImageDimensionCube, uint maxImageArrayLayers, uint maxTexelBufferElements, uint maxUniformBufferRange, uint maxStorageBufferRange, uint maxPushConstantsSize, uint maxMemoryAllocationCount, uint maxSamplerAllocationCount, DeviceSize bufferImageGranularity, DeviceSize sparseAddressSpaceSize, uint maxBoundDescriptorSets, uint maxPerStageDescriptorSamplers, uint maxPerStageDescriptorUniformBuffers, uint maxPerStageDescriptorStorageBuffers, uint maxPerStageDescriptorSampledImages, uint maxPerStageDescriptorStorageImages, uint maxPerStageDescriptorInputAttachments, uint maxPerStageResources, uint maxDescriptorSetSamplers, uint maxDescriptorSetUniformBuffers, uint maxDescriptorSetUniformBuffersDynamic, uint maxDescriptorSetStorageBuffers, uint maxDescriptorSetStorageBuffersDynamic, uint maxDescriptorSetSampledImages, uint maxDescriptorSetStorageImages, uint maxDescriptorSetInputAttachments, uint maxVertexInputAttributes, uint maxVertexInputBindings, uint maxVertexInputAttributeOffset, uint maxVertexInputBindingStride, uint maxVertexOutputComponents, uint maxTessellationGenerationLevel, uint maxTessellationPatchSize, uint maxTessellationControlPerVertexInputComponents, uint maxTessellationControlPerVertexOutputComponents, uint maxTessellationControlPerPatchOutputComponents, uint maxTessellationControlTotalOutputComponents, uint maxTessellationEvaluationInputComponents, uint maxTessellationEvaluationOutputComponents, uint maxGeometryShaderInvocations, uint maxGeometryInputComponents, uint maxGeometryOutputComponents, uint maxGeometryOutputVertices, uint maxGeometryTotalOutputComponents, uint maxFragmentInputComponents, uint maxFragmentOutputAttachments, uint maxFragmentDualSourceAttachments, uint maxFragmentCombinedOutputResources, uint maxComputeSharedMemorySize, uint maxComputeWorkGroupCount, uint maxComputeWorkGroupInvocations, uint maxComputeWorkGroupSize, uint subPixelPrecisionBits, uint subTexelPrecisionBits, uint mipmapPrecisionBits, uint maxDrawIndexedIndexValue, uint maxDrawIndirectCount, float maxSamplerLodBias, float maxSamplerAnisotropy, uint maxViewports, uint maxViewportDimensions, float viewportBoundsRange, uint viewportSubPixelBits, HostSize minMemoryMapAlignment, DeviceSize minTexelBufferOffsetAlignment, DeviceSize minUniformBufferOffsetAlignment, DeviceSize minStorageBufferOffsetAlignment, int minTexelOffset, uint maxTexelOffset, int minTexelGatherOffset, uint maxTexelGatherOffset, float minInterpolationOffset, float maxInterpolationOffset, uint subPixelInterpolationOffsetBits, uint maxFramebufferWidth, uint maxFramebufferHeight, uint maxFramebufferLayers, SampleCountFlags framebufferColorSampleCounts, SampleCountFlags framebufferDepthSampleCounts, SampleCountFlags framebufferStencilSampleCounts, SampleCountFlags framebufferNoAttachmentsSampleCounts, uint maxColorAttachments, SampleCountFlags sampledImageColorSampleCounts, SampleCountFlags sampledImageIntegerSampleCounts, SampleCountFlags sampledImageDepthSampleCounts, SampleCountFlags sampledImageStencilSampleCounts, SampleCountFlags storageImageSampleCounts, uint maxSampleMaskWords, Bool32 timestampComputeAndGraphics, float timestampPeriod, uint maxClipDistances, uint maxCullDistances, uint maxCombinedClipAndCullDistances, uint discreteQueuePriorities, float pointSizeRange, float lineWidthRange, float pointSizeGranularity, float lineWidthGranularity, Bool32 strictLines, Bool32 standardSampleLocations, DeviceSize optimalBufferCopyOffsetAlignment, DeviceSize optimalBufferCopyRowPitchAlignment, DeviceSize nonCoherentAtomSize)
        {
            this.MaxImageDimension1D = maxImageDimension1D;
            this.MaxImageDimension2D = maxImageDimension2D;
            this.MaxImageDimension3D = maxImageDimension3D;
            this.MaxImageDimensionCube = maxImageDimensionCube;
            this.MaxImageArrayLayers = maxImageArrayLayers;
            this.MaxTexelBufferElements = maxTexelBufferElements;
            this.MaxUniformBufferRange = maxUniformBufferRange;
            this.MaxStorageBufferRange = maxStorageBufferRange;
            this.MaxPushConstantsSize = maxPushConstantsSize;
            this.MaxMemoryAllocationCount = maxMemoryAllocationCount;
            this.MaxSamplerAllocationCount = maxSamplerAllocationCount;
            this.BufferImageGranularity = bufferImageGranularity;
            this.SparseAddressSpaceSize = sparseAddressSpaceSize;
            this.MaxBoundDescriptorSets = maxBoundDescriptorSets;
            this.MaxPerStageDescriptorSamplers = maxPerStageDescriptorSamplers;
            this.MaxPerStageDescriptorUniformBuffers = maxPerStageDescriptorUniformBuffers;
            this.MaxPerStageDescriptorStorageBuffers = maxPerStageDescriptorStorageBuffers;
            this.MaxPerStageDescriptorSampledImages = maxPerStageDescriptorSampledImages;
            this.MaxPerStageDescriptorStorageImages = maxPerStageDescriptorStorageImages;
            this.MaxPerStageDescriptorInputAttachments = maxPerStageDescriptorInputAttachments;
            this.MaxPerStageResources = maxPerStageResources;
            this.MaxDescriptorSetSamplers = maxDescriptorSetSamplers;
            this.MaxDescriptorSetUniformBuffers = maxDescriptorSetUniformBuffers;
            this.MaxDescriptorSetUniformBuffersDynamic = maxDescriptorSetUniformBuffersDynamic;
            this.MaxDescriptorSetStorageBuffers = maxDescriptorSetStorageBuffers;
            this.MaxDescriptorSetStorageBuffersDynamic = maxDescriptorSetStorageBuffersDynamic;
            this.MaxDescriptorSetSampledImages = maxDescriptorSetSampledImages;
            this.MaxDescriptorSetStorageImages = maxDescriptorSetStorageImages;
            this.MaxDescriptorSetInputAttachments = maxDescriptorSetInputAttachments;
            this.MaxVertexInputAttributes = maxVertexInputAttributes;
            this.MaxVertexInputBindings = maxVertexInputBindings;
            this.MaxVertexInputAttributeOffset = maxVertexInputAttributeOffset;
            this.MaxVertexInputBindingStride = maxVertexInputBindingStride;
            this.MaxVertexOutputComponents = maxVertexOutputComponents;
            this.MaxTessellationGenerationLevel = maxTessellationGenerationLevel;
            this.MaxTessellationPatchSize = maxTessellationPatchSize;
            this.MaxTessellationControlPerVertexInputComponents = maxTessellationControlPerVertexInputComponents;
            this.MaxTessellationControlPerVertexOutputComponents = maxTessellationControlPerVertexOutputComponents;
            this.MaxTessellationControlPerPatchOutputComponents = maxTessellationControlPerPatchOutputComponents;
            this.MaxTessellationControlTotalOutputComponents = maxTessellationControlTotalOutputComponents;
            this.MaxTessellationEvaluationInputComponents = maxTessellationEvaluationInputComponents;
            this.MaxTessellationEvaluationOutputComponents = maxTessellationEvaluationOutputComponents;
            this.MaxGeometryShaderInvocations = maxGeometryShaderInvocations;
            this.MaxGeometryInputComponents = maxGeometryInputComponents;
            this.MaxGeometryOutputComponents = maxGeometryOutputComponents;
            this.MaxGeometryOutputVertices = maxGeometryOutputVertices;
            this.MaxGeometryTotalOutputComponents = maxGeometryTotalOutputComponents;
            this.MaxFragmentInputComponents = maxFragmentInputComponents;
            this.MaxFragmentOutputAttachments = maxFragmentOutputAttachments;
            this.MaxFragmentDualSourceAttachments = maxFragmentDualSourceAttachments;
            this.MaxFragmentCombinedOutputResources = maxFragmentCombinedOutputResources;
            this.MaxComputeSharedMemorySize = maxComputeSharedMemorySize;
            this.MaxComputeWorkGroupCount = maxComputeWorkGroupCount;
            this.MaxComputeWorkGroupInvocations = maxComputeWorkGroupInvocations;
            this.MaxComputeWorkGroupSize = maxComputeWorkGroupSize;
            this.SubPixelPrecisionBits = subPixelPrecisionBits;
            this.SubTexelPrecisionBits = subTexelPrecisionBits;
            this.MipmapPrecisionBits = mipmapPrecisionBits;
            this.MaxDrawIndexedIndexValue = maxDrawIndexedIndexValue;
            this.MaxDrawIndirectCount = maxDrawIndirectCount;
            this.MaxSamplerLodBias = maxSamplerLodBias;
            this.MaxSamplerAnisotropy = maxSamplerAnisotropy;
            this.MaxViewports = maxViewports;
            this.MaxViewportDimensions = maxViewportDimensions;
            this.ViewportBoundsRange = viewportBoundsRange;
            this.ViewportSubPixelBits = viewportSubPixelBits;
            this.MinMemoryMapAlignment = minMemoryMapAlignment;
            this.MinTexelBufferOffsetAlignment = minTexelBufferOffsetAlignment;
            this.MinUniformBufferOffsetAlignment = minUniformBufferOffsetAlignment;
            this.MinStorageBufferOffsetAlignment = minStorageBufferOffsetAlignment;
            this.MinTexelOffset = minTexelOffset;
            this.MaxTexelOffset = maxTexelOffset;
            this.MinTexelGatherOffset = minTexelGatherOffset;
            this.MaxTexelGatherOffset = maxTexelGatherOffset;
            this.MinInterpolationOffset = minInterpolationOffset;
            this.MaxInterpolationOffset = maxInterpolationOffset;
            this.SubPixelInterpolationOffsetBits = subPixelInterpolationOffsetBits;
            this.MaxFramebufferWidth = maxFramebufferWidth;
            this.MaxFramebufferHeight = maxFramebufferHeight;
            this.MaxFramebufferLayers = maxFramebufferLayers;
            this.FramebufferColorSampleCounts = framebufferColorSampleCounts;
            this.FramebufferDepthSampleCounts = framebufferDepthSampleCounts;
            this.FramebufferStencilSampleCounts = framebufferStencilSampleCounts;
            this.FramebufferNoAttachmentsSampleCounts = framebufferNoAttachmentsSampleCounts;
            this.MaxColorAttachments = maxColorAttachments;
            this.SampledImageColorSampleCounts = sampledImageColorSampleCounts;
            this.SampledImageIntegerSampleCounts = sampledImageIntegerSampleCounts;
            this.SampledImageDepthSampleCounts = sampledImageDepthSampleCounts;
            this.SampledImageStencilSampleCounts = sampledImageStencilSampleCounts;
            this.StorageImageSampleCounts = storageImageSampleCounts;
            this.MaxSampleMaskWords = maxSampleMaskWords;
            this.TimestampComputeAndGraphics = timestampComputeAndGraphics;
            this.TimestampPeriod = timestampPeriod;
            this.MaxClipDistances = maxClipDistances;
            this.MaxCullDistances = maxCullDistances;
            this.MaxCombinedClipAndCullDistances = maxCombinedClipAndCullDistances;
            this.DiscreteQueuePriorities = discreteQueuePriorities;
            this.PointSizeRange = pointSizeRange;
            this.LineWidthRange = lineWidthRange;
            this.PointSizeGranularity = pointSizeGranularity;
            this.LineWidthGranularity = lineWidthGranularity;
            this.StrictLines = strictLines;
            this.StandardSampleLocations = standardSampleLocations;
            this.OptimalBufferCopyOffsetAlignment = optimalBufferCopyOffsetAlignment;
            this.OptimalBufferCopyRowPitchAlignment = optimalBufferCopyRowPitchAlignment;
            this.NonCoherentAtomSize = nonCoherentAtomSize;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageDimension1D; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageDimension2D; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageDimension3D; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageDimensionCube; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageArrayLayers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTexelBufferElements; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxUniformBufferRange; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxStorageBufferRange; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPushConstantsSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMemoryAllocationCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSamplerAllocationCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize BufferImageGranularity; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize SparseAddressSpaceSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxBoundDescriptorSets; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorSamplers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUniformBuffers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorStorageBuffers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorSampledImages; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorStorageImages; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorInputAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageResources; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetSamplers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUniformBuffers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUniformBuffersDynamic; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetStorageBuffers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetStorageBuffersDynamic; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetSampledImages; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetStorageImages; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetInputAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVertexInputAttributes; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVertexInputBindings; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVertexInputAttributeOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVertexInputBindingStride; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVertexOutputComponents; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationGenerationLevel; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationPatchSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationControlPerVertexInputComponents; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationControlPerVertexOutputComponents; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationControlPerPatchOutputComponents; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationControlTotalOutputComponents; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationEvaluationInputComponents; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationEvaluationOutputComponents; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxGeometryShaderInvocations; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxGeometryInputComponents; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxGeometryOutputComponents; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxGeometryOutputVertices; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxGeometryTotalOutputComponents; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFragmentInputComponents; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFragmentOutputAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFragmentDualSourceAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFragmentCombinedOutputResources; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxComputeSharedMemorySize; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxComputeWorkGroupCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxComputeWorkGroupInvocations; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxComputeWorkGroupSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SubPixelPrecisionBits; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SubTexelPrecisionBits; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MipmapPrecisionBits; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDrawIndexedIndexValue; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDrawIndirectCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxSamplerLodBias; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxSamplerAnisotropy; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxViewports; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxViewportDimensions; 
        
        /// <summary>
        /// 
        /// </summary>
        public float ViewportBoundsRange; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ViewportSubPixelBits; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize MinMemoryMapAlignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize MinTexelBufferOffsetAlignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize MinUniformBufferOffsetAlignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize MinStorageBufferOffsetAlignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public int MinTexelOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTexelOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public int MinTexelGatherOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTexelGatherOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MinInterpolationOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxInterpolationOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SubPixelInterpolationOffsetBits; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFramebufferWidth; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFramebufferHeight; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFramebufferLayers; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags FramebufferColorSampleCounts; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags FramebufferDepthSampleCounts; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags FramebufferStencilSampleCounts; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags FramebufferNoAttachmentsSampleCounts; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxColorAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags SampledImageColorSampleCounts; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags SampledImageIntegerSampleCounts; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags SampledImageDepthSampleCounts; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags SampledImageStencilSampleCounts; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags StorageImageSampleCounts; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSampleMaskWords; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TimestampComputeAndGraphics; 
        
        /// <summary>
        /// 
        /// </summary>
        public float TimestampPeriod; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxClipDistances; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxCullDistances; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxCombinedClipAndCullDistances; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DiscreteQueuePriorities; 
        
        /// <summary>
        /// 
        /// </summary>
        public float PointSizeRange; 
        
        /// <summary>
        /// 
        /// </summary>
        public float LineWidthRange; 
        
        /// <summary>
        /// 
        /// </summary>
        public float PointSizeGranularity; 
        
        /// <summary>
        /// 
        /// </summary>
        public float LineWidthGranularity; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 StrictLines; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 StandardSampleLocations; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize OptimalBufferCopyOffsetAlignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize OptimalBufferCopyRowPitchAlignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize NonCoherentAtomSize; 
    }
}
