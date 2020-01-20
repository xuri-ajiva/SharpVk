// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2020
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
    public partial struct PhysicalDeviceVulkan12Properties
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.DriverId DriverID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string DriverName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string DriverInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ConformanceVersion ConformanceVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderFloatControlsIndependence DenormBehaviorIndependence
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderFloatControlsIndependence RoundingModeIndependence
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSignedZeroInfNanPreserveFloat16
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSignedZeroInfNanPreserveFloat32
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSignedZeroInfNanPreserveFloat64
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderDenormPreserveFloat16
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderDenormPreserveFloat32
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderDenormPreserveFloat64
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderDenormFlushToZeroFloat16
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderDenormFlushToZeroFloat32
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderDenormFlushToZeroFloat64
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderRoundingModeRTEFloat16
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderRoundingModeRTEFloat32
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderRoundingModeRTEFloat64
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderRoundingModeRTZFloat16
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderRoundingModeRTZFloat32
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderRoundingModeRTZFloat64
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxUpdateAfterBindDescriptorsInAllPools
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderUniformBufferArrayNonUniformIndexingNative
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSampledImageArrayNonUniformIndexingNative
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderStorageBufferArrayNonUniformIndexingNative
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderStorageImageArrayNonUniformIndexingNative
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderInputAttachmentArrayNonUniformIndexingNative
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool RobustBufferAccessUpdateAfterBind
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool QuadDivergentImplicitLod
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindSampledImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindStorageImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageUpdateAfterBindResources
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindSampledImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindStorageImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ResolveModeFlags SupportedDepthResolveModes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ResolveModeFlags SupportedStencilResolveModes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IndependentResolveNone
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IndependentResolve
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool FilterMinmaxSingleComponentFormats
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool FilterMinmaxImageComponentMapping
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxTimelineSemaphoreValueDifference
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SampleCountFlags? FramebufferIntegerColorSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.PhysicalDeviceVulkan12Properties* pointer)
        {
            pointer->Next = null;
            pointer->DriverID = this.DriverID;
            pointer->ConformanceVersion = this.ConformanceVersion;
            pointer->DenormBehaviorIndependence = this.DenormBehaviorIndependence;
            pointer->RoundingModeIndependence = this.RoundingModeIndependence;
            pointer->ShaderSignedZeroInfNanPreserveFloat16 = this.ShaderSignedZeroInfNanPreserveFloat16;
            pointer->ShaderSignedZeroInfNanPreserveFloat32 = this.ShaderSignedZeroInfNanPreserveFloat32;
            pointer->ShaderSignedZeroInfNanPreserveFloat64 = this.ShaderSignedZeroInfNanPreserveFloat64;
            pointer->ShaderDenormPreserveFloat16 = this.ShaderDenormPreserveFloat16;
            pointer->ShaderDenormPreserveFloat32 = this.ShaderDenormPreserveFloat32;
            pointer->ShaderDenormPreserveFloat64 = this.ShaderDenormPreserveFloat64;
            pointer->ShaderDenormFlushToZeroFloat16 = this.ShaderDenormFlushToZeroFloat16;
            pointer->ShaderDenormFlushToZeroFloat32 = this.ShaderDenormFlushToZeroFloat32;
            pointer->ShaderDenormFlushToZeroFloat64 = this.ShaderDenormFlushToZeroFloat64;
            pointer->ShaderRoundingModeRTEFloat16 = this.ShaderRoundingModeRTEFloat16;
            pointer->ShaderRoundingModeRTEFloat32 = this.ShaderRoundingModeRTEFloat32;
            pointer->ShaderRoundingModeRTEFloat64 = this.ShaderRoundingModeRTEFloat64;
            pointer->ShaderRoundingModeRTZFloat16 = this.ShaderRoundingModeRTZFloat16;
            pointer->ShaderRoundingModeRTZFloat32 = this.ShaderRoundingModeRTZFloat32;
            pointer->ShaderRoundingModeRTZFloat64 = this.ShaderRoundingModeRTZFloat64;
            pointer->MaxUpdateAfterBindDescriptorsInAllPools = this.MaxUpdateAfterBindDescriptorsInAllPools;
            pointer->ShaderUniformBufferArrayNonUniformIndexingNative = this.ShaderUniformBufferArrayNonUniformIndexingNative;
            pointer->ShaderSampledImageArrayNonUniformIndexingNative = this.ShaderSampledImageArrayNonUniformIndexingNative;
            pointer->ShaderStorageBufferArrayNonUniformIndexingNative = this.ShaderStorageBufferArrayNonUniformIndexingNative;
            pointer->ShaderStorageImageArrayNonUniformIndexingNative = this.ShaderStorageImageArrayNonUniformIndexingNative;
            pointer->ShaderInputAttachmentArrayNonUniformIndexingNative = this.ShaderInputAttachmentArrayNonUniformIndexingNative;
            pointer->RobustBufferAccessUpdateAfterBind = this.RobustBufferAccessUpdateAfterBind;
            pointer->QuadDivergentImplicitLod = this.QuadDivergentImplicitLod;
            pointer->MaxPerStageDescriptorUpdateAfterBindSamplers = this.MaxPerStageDescriptorUpdateAfterBindSamplers;
            pointer->MaxPerStageDescriptorUpdateAfterBindUniformBuffers = this.MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
            pointer->MaxPerStageDescriptorUpdateAfterBindStorageBuffers = this.MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
            pointer->MaxPerStageDescriptorUpdateAfterBindSampledImages = this.MaxPerStageDescriptorUpdateAfterBindSampledImages;
            pointer->MaxPerStageDescriptorUpdateAfterBindStorageImages = this.MaxPerStageDescriptorUpdateAfterBindStorageImages;
            pointer->MaxPerStageDescriptorUpdateAfterBindInputAttachments = this.MaxPerStageDescriptorUpdateAfterBindInputAttachments;
            pointer->MaxPerStageUpdateAfterBindResources = this.MaxPerStageUpdateAfterBindResources;
            pointer->MaxDescriptorSetUpdateAfterBindSamplers = this.MaxDescriptorSetUpdateAfterBindSamplers;
            pointer->MaxDescriptorSetUpdateAfterBindUniformBuffers = this.MaxDescriptorSetUpdateAfterBindUniformBuffers;
            pointer->MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic = this.MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
            pointer->MaxDescriptorSetUpdateAfterBindStorageBuffers = this.MaxDescriptorSetUpdateAfterBindStorageBuffers;
            pointer->MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic = this.MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
            pointer->MaxDescriptorSetUpdateAfterBindSampledImages = this.MaxDescriptorSetUpdateAfterBindSampledImages;
            pointer->MaxDescriptorSetUpdateAfterBindStorageImages = this.MaxDescriptorSetUpdateAfterBindStorageImages;
            pointer->MaxDescriptorSetUpdateAfterBindInputAttachments = this.MaxDescriptorSetUpdateAfterBindInputAttachments;
            pointer->SupportedDepthResolveModes = this.SupportedDepthResolveModes;
            pointer->SupportedStencilResolveModes = this.SupportedStencilResolveModes;
            pointer->IndependentResolveNone = this.IndependentResolveNone;
            pointer->IndependentResolve = this.IndependentResolve;
            pointer->FilterMinmaxSingleComponentFormats = this.FilterMinmaxSingleComponentFormats;
            pointer->FilterMinmaxImageComponentMapping = this.FilterMinmaxImageComponentMapping;
            pointer->MaxTimelineSemaphoreValueDifference = this.MaxTimelineSemaphoreValueDifference;
            if (this.FramebufferIntegerColorSampleCounts != null)
            {
                pointer->FramebufferIntegerColorSampleCounts = this.FramebufferIntegerColorSampleCounts.Value;
            }
            else
            {
                pointer->FramebufferIntegerColorSampleCounts = default(SharpVk.SampleCountFlags);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceVulkan12Properties MarshalFrom(SharpVk.Interop.PhysicalDeviceVulkan12Properties* pointer)
        {
            PhysicalDeviceVulkan12Properties result = default(PhysicalDeviceVulkan12Properties);
            result.DriverID = pointer->DriverID;
            result.DriverName = Interop.HeapUtil.MarshalStringFrom(pointer->DriverName, Constants.MaxDriverNameSize, true);
            result.DriverInfo = Interop.HeapUtil.MarshalStringFrom(pointer->DriverInfo, Constants.MaxDriverInfoSize, true);
            result.ConformanceVersion = pointer->ConformanceVersion;
            result.DenormBehaviorIndependence = pointer->DenormBehaviorIndependence;
            result.RoundingModeIndependence = pointer->RoundingModeIndependence;
            result.ShaderSignedZeroInfNanPreserveFloat16 = pointer->ShaderSignedZeroInfNanPreserveFloat16;
            result.ShaderSignedZeroInfNanPreserveFloat32 = pointer->ShaderSignedZeroInfNanPreserveFloat32;
            result.ShaderSignedZeroInfNanPreserveFloat64 = pointer->ShaderSignedZeroInfNanPreserveFloat64;
            result.ShaderDenormPreserveFloat16 = pointer->ShaderDenormPreserveFloat16;
            result.ShaderDenormPreserveFloat32 = pointer->ShaderDenormPreserveFloat32;
            result.ShaderDenormPreserveFloat64 = pointer->ShaderDenormPreserveFloat64;
            result.ShaderDenormFlushToZeroFloat16 = pointer->ShaderDenormFlushToZeroFloat16;
            result.ShaderDenormFlushToZeroFloat32 = pointer->ShaderDenormFlushToZeroFloat32;
            result.ShaderDenormFlushToZeroFloat64 = pointer->ShaderDenormFlushToZeroFloat64;
            result.ShaderRoundingModeRTEFloat16 = pointer->ShaderRoundingModeRTEFloat16;
            result.ShaderRoundingModeRTEFloat32 = pointer->ShaderRoundingModeRTEFloat32;
            result.ShaderRoundingModeRTEFloat64 = pointer->ShaderRoundingModeRTEFloat64;
            result.ShaderRoundingModeRTZFloat16 = pointer->ShaderRoundingModeRTZFloat16;
            result.ShaderRoundingModeRTZFloat32 = pointer->ShaderRoundingModeRTZFloat32;
            result.ShaderRoundingModeRTZFloat64 = pointer->ShaderRoundingModeRTZFloat64;
            result.MaxUpdateAfterBindDescriptorsInAllPools = pointer->MaxUpdateAfterBindDescriptorsInAllPools;
            result.ShaderUniformBufferArrayNonUniformIndexingNative = pointer->ShaderUniformBufferArrayNonUniformIndexingNative;
            result.ShaderSampledImageArrayNonUniformIndexingNative = pointer->ShaderSampledImageArrayNonUniformIndexingNative;
            result.ShaderStorageBufferArrayNonUniformIndexingNative = pointer->ShaderStorageBufferArrayNonUniformIndexingNative;
            result.ShaderStorageImageArrayNonUniformIndexingNative = pointer->ShaderStorageImageArrayNonUniformIndexingNative;
            result.ShaderInputAttachmentArrayNonUniformIndexingNative = pointer->ShaderInputAttachmentArrayNonUniformIndexingNative;
            result.RobustBufferAccessUpdateAfterBind = pointer->RobustBufferAccessUpdateAfterBind;
            result.QuadDivergentImplicitLod = pointer->QuadDivergentImplicitLod;
            result.MaxPerStageDescriptorUpdateAfterBindSamplers = pointer->MaxPerStageDescriptorUpdateAfterBindSamplers;
            result.MaxPerStageDescriptorUpdateAfterBindUniformBuffers = pointer->MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
            result.MaxPerStageDescriptorUpdateAfterBindStorageBuffers = pointer->MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
            result.MaxPerStageDescriptorUpdateAfterBindSampledImages = pointer->MaxPerStageDescriptorUpdateAfterBindSampledImages;
            result.MaxPerStageDescriptorUpdateAfterBindStorageImages = pointer->MaxPerStageDescriptorUpdateAfterBindStorageImages;
            result.MaxPerStageDescriptorUpdateAfterBindInputAttachments = pointer->MaxPerStageDescriptorUpdateAfterBindInputAttachments;
            result.MaxPerStageUpdateAfterBindResources = pointer->MaxPerStageUpdateAfterBindResources;
            result.MaxDescriptorSetUpdateAfterBindSamplers = pointer->MaxDescriptorSetUpdateAfterBindSamplers;
            result.MaxDescriptorSetUpdateAfterBindUniformBuffers = pointer->MaxDescriptorSetUpdateAfterBindUniformBuffers;
            result.MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic = pointer->MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
            result.MaxDescriptorSetUpdateAfterBindStorageBuffers = pointer->MaxDescriptorSetUpdateAfterBindStorageBuffers;
            result.MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic = pointer->MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
            result.MaxDescriptorSetUpdateAfterBindSampledImages = pointer->MaxDescriptorSetUpdateAfterBindSampledImages;
            result.MaxDescriptorSetUpdateAfterBindStorageImages = pointer->MaxDescriptorSetUpdateAfterBindStorageImages;
            result.MaxDescriptorSetUpdateAfterBindInputAttachments = pointer->MaxDescriptorSetUpdateAfterBindInputAttachments;
            result.SupportedDepthResolveModes = pointer->SupportedDepthResolveModes;
            result.SupportedStencilResolveModes = pointer->SupportedStencilResolveModes;
            result.IndependentResolveNone = pointer->IndependentResolveNone;
            result.IndependentResolve = pointer->IndependentResolve;
            result.FilterMinmaxSingleComponentFormats = pointer->FilterMinmaxSingleComponentFormats;
            result.FilterMinmaxImageComponentMapping = pointer->FilterMinmaxImageComponentMapping;
            result.MaxTimelineSemaphoreValueDifference = pointer->MaxTimelineSemaphoreValueDifference;
            result.FramebufferIntegerColorSampleCounts = pointer->FramebufferIntegerColorSampleCounts;
            return result;
        }
    }
}
