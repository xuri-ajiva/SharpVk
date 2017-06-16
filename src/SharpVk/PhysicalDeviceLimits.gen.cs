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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceLimits
    {
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageDimension1D
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageDimension2D
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageDimension3D
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageDimensionCube
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTexelBufferElements
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxUniformBufferRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxStorageBufferRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPushConstantsSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMemoryAllocationCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSamplerAllocationCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize BufferImageGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize SparseAddressSpaceSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxBoundDescriptorSets
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorSampledImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorStorageImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageResources
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUniformBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetStorageBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetSampledImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetStorageImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVertexInputAttributes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVertexInputBindings
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVertexInputAttributeOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVertexInputBindingStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVertexOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationGenerationLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationPatchSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationControlPerVertexInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationControlPerVertexOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationControlPerPatchOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationControlTotalOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationEvaluationInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTessellationEvaluationOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxGeometryShaderInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxGeometryInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxGeometryOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxGeometryOutputVertices
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxGeometryTotalOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFragmentInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFragmentOutputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFragmentDualSourceAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFragmentCombinedOutputResources
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxComputeSharedMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxComputeWorkGroupInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SubPixelPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SubTexelPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MipmapPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDrawIndexedIndexValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDrawIndirectCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxSamplerLodBias
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxSamplerAnisotropy
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxViewports
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ViewportSubPixelBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize MinMemoryMapAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize MinTexelBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize MinUniformBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize MinStorageBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int MinTexelOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTexelOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int MinTexelGatherOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTexelGatherOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MinInterpolationOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxInterpolationOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SubPixelInterpolationOffsetBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFramebufferWidth
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFramebufferHeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFramebufferLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SampleCountFlags? FramebufferColorSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SampleCountFlags? FramebufferDepthSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SampleCountFlags? FramebufferStencilSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SampleCountFlags? FramebufferNoAttachmentsSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SampleCountFlags? SampledImageColorSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SampleCountFlags? SampledImageIntegerSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SampleCountFlags? SampledImageDepthSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SampleCountFlags? SampledImageStencilSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SampleCountFlags? StorageImageSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSampleMaskWords
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TimestampComputeAndGraphics
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float TimestampPeriod
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxClipDistances
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxCullDistances
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxCombinedClipAndCullDistances
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DiscreteQueuePriorities
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float PointSizeGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float LineWidthGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 StrictLines
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 StandardSampleLocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize OptimalBufferCopyOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize OptimalBufferCopyRowPitchAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize NonCoherentAtomSize
        {
            get;
            set;
        }
        
        internal static unsafe PhysicalDeviceLimits MarshalFrom(SharpVk.Interop.PhysicalDeviceLimits* pointer)
        {
            PhysicalDeviceLimits result = default(PhysicalDeviceLimits);
            result.MaxImageDimension1D = pointer->MaxImageDimension1D;
            result.MaxImageDimension2D = pointer->MaxImageDimension2D;
            result.MaxImageDimension3D = pointer->MaxImageDimension3D;
            result.MaxImageDimensionCube = pointer->MaxImageDimensionCube;
            result.MaxImageArrayLayers = pointer->MaxImageArrayLayers;
            result.MaxTexelBufferElements = pointer->MaxTexelBufferElements;
            result.MaxUniformBufferRange = pointer->MaxUniformBufferRange;
            result.MaxStorageBufferRange = pointer->MaxStorageBufferRange;
            result.MaxPushConstantsSize = pointer->MaxPushConstantsSize;
            result.MaxMemoryAllocationCount = pointer->MaxMemoryAllocationCount;
            result.MaxSamplerAllocationCount = pointer->MaxSamplerAllocationCount;
            result.BufferImageGranularity = pointer->BufferImageGranularity;
            result.SparseAddressSpaceSize = pointer->SparseAddressSpaceSize;
            result.MaxBoundDescriptorSets = pointer->MaxBoundDescriptorSets;
            result.MaxPerStageDescriptorSamplers = pointer->MaxPerStageDescriptorSamplers;
            result.MaxPerStageDescriptorUniformBuffers = pointer->MaxPerStageDescriptorUniformBuffers;
            result.MaxPerStageDescriptorStorageBuffers = pointer->MaxPerStageDescriptorStorageBuffers;
            result.MaxPerStageDescriptorSampledImages = pointer->MaxPerStageDescriptorSampledImages;
            result.MaxPerStageDescriptorStorageImages = pointer->MaxPerStageDescriptorStorageImages;
            result.MaxPerStageDescriptorInputAttachments = pointer->MaxPerStageDescriptorInputAttachments;
            result.MaxPerStageResources = pointer->MaxPerStageResources;
            result.MaxDescriptorSetSamplers = pointer->MaxDescriptorSetSamplers;
            result.MaxDescriptorSetUniformBuffers = pointer->MaxDescriptorSetUniformBuffers;
            result.MaxDescriptorSetUniformBuffersDynamic = pointer->MaxDescriptorSetUniformBuffersDynamic;
            result.MaxDescriptorSetStorageBuffers = pointer->MaxDescriptorSetStorageBuffers;
            result.MaxDescriptorSetStorageBuffersDynamic = pointer->MaxDescriptorSetStorageBuffersDynamic;
            result.MaxDescriptorSetSampledImages = pointer->MaxDescriptorSetSampledImages;
            result.MaxDescriptorSetStorageImages = pointer->MaxDescriptorSetStorageImages;
            result.MaxDescriptorSetInputAttachments = pointer->MaxDescriptorSetInputAttachments;
            result.MaxVertexInputAttributes = pointer->MaxVertexInputAttributes;
            result.MaxVertexInputBindings = pointer->MaxVertexInputBindings;
            result.MaxVertexInputAttributeOffset = pointer->MaxVertexInputAttributeOffset;
            result.MaxVertexInputBindingStride = pointer->MaxVertexInputBindingStride;
            result.MaxVertexOutputComponents = pointer->MaxVertexOutputComponents;
            result.MaxTessellationGenerationLevel = pointer->MaxTessellationGenerationLevel;
            result.MaxTessellationPatchSize = pointer->MaxTessellationPatchSize;
            result.MaxTessellationControlPerVertexInputComponents = pointer->MaxTessellationControlPerVertexInputComponents;
            result.MaxTessellationControlPerVertexOutputComponents = pointer->MaxTessellationControlPerVertexOutputComponents;
            result.MaxTessellationControlPerPatchOutputComponents = pointer->MaxTessellationControlPerPatchOutputComponents;
            result.MaxTessellationControlTotalOutputComponents = pointer->MaxTessellationControlTotalOutputComponents;
            result.MaxTessellationEvaluationInputComponents = pointer->MaxTessellationEvaluationInputComponents;
            result.MaxTessellationEvaluationOutputComponents = pointer->MaxTessellationEvaluationOutputComponents;
            result.MaxGeometryShaderInvocations = pointer->MaxGeometryShaderInvocations;
            result.MaxGeometryInputComponents = pointer->MaxGeometryInputComponents;
            result.MaxGeometryOutputComponents = pointer->MaxGeometryOutputComponents;
            result.MaxGeometryOutputVertices = pointer->MaxGeometryOutputVertices;
            result.MaxGeometryTotalOutputComponents = pointer->MaxGeometryTotalOutputComponents;
            result.MaxFragmentInputComponents = pointer->MaxFragmentInputComponents;
            result.MaxFragmentOutputAttachments = pointer->MaxFragmentOutputAttachments;
            result.MaxFragmentDualSourceAttachments = pointer->MaxFragmentDualSourceAttachments;
            result.MaxFragmentCombinedOutputResources = pointer->MaxFragmentCombinedOutputResources;
            result.MaxComputeSharedMemorySize = pointer->MaxComputeSharedMemorySize;
            result.MaxComputeWorkGroupInvocations = pointer->MaxComputeWorkGroupInvocations;
            result.SubPixelPrecisionBits = pointer->SubPixelPrecisionBits;
            result.SubTexelPrecisionBits = pointer->SubTexelPrecisionBits;
            result.MipmapPrecisionBits = pointer->MipmapPrecisionBits;
            result.MaxDrawIndexedIndexValue = pointer->MaxDrawIndexedIndexValue;
            result.MaxDrawIndirectCount = pointer->MaxDrawIndirectCount;
            result.MaxSamplerLodBias = pointer->MaxSamplerLodBias;
            result.MaxSamplerAnisotropy = pointer->MaxSamplerAnisotropy;
            result.MaxViewports = pointer->MaxViewports;
            result.ViewportSubPixelBits = pointer->ViewportSubPixelBits;
            result.MinMemoryMapAlignment = pointer->MinMemoryMapAlignment;
            result.MinTexelBufferOffsetAlignment = pointer->MinTexelBufferOffsetAlignment;
            result.MinUniformBufferOffsetAlignment = pointer->MinUniformBufferOffsetAlignment;
            result.MinStorageBufferOffsetAlignment = pointer->MinStorageBufferOffsetAlignment;
            result.MinTexelOffset = pointer->MinTexelOffset;
            result.MaxTexelOffset = pointer->MaxTexelOffset;
            result.MinTexelGatherOffset = pointer->MinTexelGatherOffset;
            result.MaxTexelGatherOffset = pointer->MaxTexelGatherOffset;
            result.MinInterpolationOffset = pointer->MinInterpolationOffset;
            result.MaxInterpolationOffset = pointer->MaxInterpolationOffset;
            result.SubPixelInterpolationOffsetBits = pointer->SubPixelInterpolationOffsetBits;
            result.MaxFramebufferWidth = pointer->MaxFramebufferWidth;
            result.MaxFramebufferHeight = pointer->MaxFramebufferHeight;
            result.MaxFramebufferLayers = pointer->MaxFramebufferLayers;
            result.FramebufferColorSampleCounts = pointer->FramebufferColorSampleCounts;
            result.FramebufferDepthSampleCounts = pointer->FramebufferDepthSampleCounts;
            result.FramebufferStencilSampleCounts = pointer->FramebufferStencilSampleCounts;
            result.FramebufferNoAttachmentsSampleCounts = pointer->FramebufferNoAttachmentsSampleCounts;
            result.MaxColorAttachments = pointer->MaxColorAttachments;
            result.SampledImageColorSampleCounts = pointer->SampledImageColorSampleCounts;
            result.SampledImageIntegerSampleCounts = pointer->SampledImageIntegerSampleCounts;
            result.SampledImageDepthSampleCounts = pointer->SampledImageDepthSampleCounts;
            result.SampledImageStencilSampleCounts = pointer->SampledImageStencilSampleCounts;
            result.StorageImageSampleCounts = pointer->StorageImageSampleCounts;
            result.MaxSampleMaskWords = pointer->MaxSampleMaskWords;
            result.TimestampComputeAndGraphics = pointer->TimestampComputeAndGraphics;
            result.TimestampPeriod = pointer->TimestampPeriod;
            result.MaxClipDistances = pointer->MaxClipDistances;
            result.MaxCullDistances = pointer->MaxCullDistances;
            result.MaxCombinedClipAndCullDistances = pointer->MaxCombinedClipAndCullDistances;
            result.DiscreteQueuePriorities = pointer->DiscreteQueuePriorities;
            result.PointSizeGranularity = pointer->PointSizeGranularity;
            result.LineWidthGranularity = pointer->LineWidthGranularity;
            result.StrictLines = pointer->StrictLines;
            result.StandardSampleLocations = pointer->StandardSampleLocations;
            result.OptimalBufferCopyOffsetAlignment = pointer->OptimalBufferCopyOffsetAlignment;
            result.OptimalBufferCopyRowPitchAlignment = pointer->OptimalBufferCopyRowPitchAlignment;
            result.NonCoherentAtomSize = pointer->NonCoherentAtomSize;
            return result;
        }
    }
}
