// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PhysicalDeviceLimits
    {
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
        public fixed uint MaxComputeWorkGroupCount[3]; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxComputeWorkGroupInvocations; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed uint MaxComputeWorkGroupSize[3]; 
        
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
        public fixed uint MaxViewportDimensions[2]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed float ViewportBoundsRange[2]; 
        
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
        public fixed float PointSizeRange[2]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed float LineWidthRange[2]; 
        
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
