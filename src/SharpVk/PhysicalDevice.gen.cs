// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir & xuri 2021
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

namespace SharpVk
{
    /// <summary>
    /// Opaque handle to a physical device object.
    /// </summary>
    public partial class PhysicalDevice
    {
        internal readonly SharpVk.Interop.PhysicalDevice Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly Instance parent; 
        
        internal PhysicalDevice(Instance parent, SharpVk.Interop.PhysicalDevice handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.PhysicalDevice RawHandle => Handle;
        
        /// <summary>
        /// Reports capabilities of a physical device.
        /// </summary>
        public unsafe PhysicalDeviceFeatures GetFeatures()
        {
            try
            {
                PhysicalDeviceFeatures result = default;
                SharpVk.Interop.PhysicalDeviceFeatures marshalledFeatures = default;
                Interop.VkPhysicalDeviceGetFeaturesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceFeatures;
                commandDelegate(Handle, &marshalledFeatures);
                result = PhysicalDeviceFeatures.MarshalFrom(&marshalledFeatures);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Lists physical device's format capabilities.
        /// </summary>
        /// <param name="format">
        /// </param>
        public unsafe FormatProperties GetFormatProperties(Format format)
        {
            try
            {
                FormatProperties result = default;
                FormatProperties marshalledFormatProperties = default;
                Interop.VkPhysicalDeviceGetFormatPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceFormatProperties;
                commandDelegate(Handle, format, &marshalledFormatProperties);
                result = marshalledFormatProperties;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Lists physical device's image format capabilities.
        /// </summary>
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="tiling">
        /// </param>
        /// <param name="usage">
        /// </param>
        /// <param name="flags">
        /// </param>
        public unsafe ImageFormatProperties GetImageFormatProperties(Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags? flags = default)
        {
            try
            {
                ImageFormatProperties result = default;
                ImageCreateFlags marshalledFlags = default;
                ImageFormatProperties marshalledImageFormatProperties = default;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default;
                }
                Interop.VkPhysicalDeviceGetImageFormatPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceImageFormatProperties;
                Result methodResult = commandDelegate(Handle, format, type, tiling, usage, marshalledFlags, &marshalledImageFormatProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledImageFormatProperties;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Returns properties of a physical device.
        /// </summary>
        public unsafe PhysicalDeviceProperties GetProperties()
        {
            try
            {
                PhysicalDeviceProperties result = default;
                SharpVk.Interop.PhysicalDeviceProperties marshalledProperties = default;
                Interop.VkPhysicalDeviceGetPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceProperties;
                commandDelegate(Handle, &marshalledProperties);
                result = PhysicalDeviceProperties.MarshalFrom(&marshalledProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reports properties of the queues of the specified physical device.
        /// </summary>
        public unsafe QueueFamilyProperties[] GetQueueFamilyProperties()
        {
            try
            {
                QueueFamilyProperties[] result = default;
                uint marshalledQueueFamilyPropertyCount = default;
                QueueFamilyProperties* marshalledQueueFamilyProperties = default;
                Interop.VkPhysicalDeviceGetQueueFamilyPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceQueueFamilyProperties;
                commandDelegate(Handle, &marshalledQueueFamilyPropertyCount, marshalledQueueFamilyProperties);
                marshalledQueueFamilyProperties = (QueueFamilyProperties*)(Interop.HeapUtil.Allocate<QueueFamilyProperties>((uint)(marshalledQueueFamilyPropertyCount)));
                commandDelegate(Handle, &marshalledQueueFamilyPropertyCount, marshalledQueueFamilyProperties);
                if (marshalledQueueFamilyProperties != null)
                {
                    var fieldPointer = new QueueFamilyProperties[(uint)(marshalledQueueFamilyPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledQueueFamilyPropertyCount); index++)
                    {
                        fieldPointer[index] = marshalledQueueFamilyProperties[index];
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Reports memory information for the specified physical device.
        /// </summary>
        public unsafe PhysicalDeviceMemoryProperties GetMemoryProperties()
        {
            try
            {
                PhysicalDeviceMemoryProperties result = default;
                SharpVk.Interop.PhysicalDeviceMemoryProperties marshalledMemoryProperties = default;
                Interop.VkPhysicalDeviceGetMemoryPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceMemoryProperties;
                commandDelegate(Handle, &marshalledMemoryProperties);
                result = PhysicalDeviceMemoryProperties.MarshalFrom(&marshalledMemoryProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new device instance.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="queueCreateInfos">
        /// </param>
        /// <param name="enabledLayerNames">
        /// ppEnabledLayerNames is deprecated and ignored.
        /// </param>
        /// <param name="enabledExtensionNames">
        /// An array of enabledExtensionCount strings containing the names of
        /// extensions to enable for the created device.
        /// </param>
        /// <param name="enabledFeatures">
        /// Null or a PhysicalDeviceFeatures structure that contains boolean
        /// indicators of all the features to be enabled.
        /// </param>
        /// <param name="physicalDeviceDeviceGeneratedCommandsFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="devicePrivateDataCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePrivateDataFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFeatures2">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVariablePointersFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMultiviewFeatures">
        /// Extension struct
        /// </param>
        /// <param name="deviceGroupDeviceCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevice16BitStorageFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderSubgroupExtendedTypesFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceSamplerYcbcrConversionFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceProtectedMemoryFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceBlendOperationAdvancedFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceInlineUniformBlockFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderDrawParametersFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderFloat16Int8Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceHostQueryResetFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDescriptorIndexingFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTimelineSemaphoreFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevice8BitStorageFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceConditionalRenderingFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVulkanMemoryModelFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderAtomicInt64Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderAtomicFloatFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVertexAttributeDivisorFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceASTCDecodeFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTransformFeedbackFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRepresentativeFragmentTestFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExclusiveScissorFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCornerSampledImageFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceComputeShaderDerivativesFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentShaderBarycentricFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderImageFootprintFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDedicatedAllocationImageAliasingFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShadingRateImageFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMeshShaderFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRayTracingFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="deviceMemoryOverallocationCreateInfoAmd">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentDensityMapFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentDensityMap2FeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceScalarBlockLayoutFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceUniformBufferStandardLayoutFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDepthClipEnableFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceMemoryPriorityFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceBufferDeviceAddressFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceBufferDeviceAddressFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImagelessFramebufferFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTextureCompressionASTCHDRFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCooperativeMatrixFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceYcbcrImageArraysFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePerformanceQueryFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCoverageReductionModeFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderIntegerFunctions2FeaturesIntel">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderClockFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceIndexTypeUint8FeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderSMBuiltinsFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceFragmentShaderInterlockFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceSeparateDepthStencilLayoutsFeatures">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePipelineExecutablePropertiesFeaturesKhr">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceShaderDemoteToHelperInvocationFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceTexelBufferAlignmentFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceSubgroupSizeControlFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceLineRasterizationFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevicePipelineCreationCacheControlFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVulkan11Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceVulkan12Features">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCoherentMemoryFeaturesAmd">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceCustomBorderColorFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceExtendedDynamicStateFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceDiagnosticsConfigFeaturesNv">
        /// Extension struct
        /// </param>
        /// <param name="deviceDiagnosticsConfigCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceRobustness2FeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDeviceImageRobustnessFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="physicalDevice4444FormatsFeaturesExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe Device CreateDevice(ArrayProxy<DeviceQueueCreateInfo>? queueCreateInfos, ArrayProxy<string>? enabledLayerNames, ArrayProxy<string>? enabledExtensionNames, DeviceCreateFlags? flags = default, PhysicalDeviceFeatures? enabledFeatures = default, NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures? physicalDeviceDeviceGeneratedCommandsFeaturesNv = null, Multivendor.DevicePrivateDataCreateInfo? devicePrivateDataCreateInfoExt = null, Multivendor.PhysicalDevicePrivateDataFeatures? physicalDevicePrivateDataFeaturesExt = null, PhysicalDeviceFeatures2? physicalDeviceFeatures2 = null, PhysicalDeviceVariablePointersFeatures? physicalDeviceVariablePointersFeatures = null, PhysicalDeviceMultiviewFeatures? physicalDeviceMultiviewFeatures = null, DeviceGroupDeviceCreateInfo? deviceGroupDeviceCreateInfo = null, PhysicalDevice16BitStorageFeatures? physicalDevice16BitStorageFeatures = null, PhysicalDeviceShaderSubgroupExtendedTypesFeatures? physicalDeviceShaderSubgroupExtendedTypesFeatures = null, PhysicalDeviceSamplerYcbcrConversionFeatures? physicalDeviceSamplerYcbcrConversionFeatures = null, PhysicalDeviceProtectedMemoryFeatures? physicalDeviceProtectedMemoryFeatures = null, Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures? physicalDeviceBlendOperationAdvancedFeaturesExt = null, Multivendor.PhysicalDeviceInlineUniformBlockFeatures? physicalDeviceInlineUniformBlockFeaturesExt = null, PhysicalDeviceShaderDrawParametersFeatures? physicalDeviceShaderDrawParametersFeatures = null, PhysicalDeviceShaderFloat16Int8Features? physicalDeviceShaderFloat16Int8Features = null, PhysicalDeviceHostQueryResetFeatures? physicalDeviceHostQueryResetFeatures = null, PhysicalDeviceDescriptorIndexingFeatures? physicalDeviceDescriptorIndexingFeatures = null, PhysicalDeviceTimelineSemaphoreFeatures? physicalDeviceTimelineSemaphoreFeatures = null, PhysicalDevice8BitStorageFeatures? physicalDevice8BitStorageFeatures = null, Multivendor.PhysicalDeviceConditionalRenderingFeatures? physicalDeviceConditionalRenderingFeaturesExt = null, PhysicalDeviceVulkanMemoryModelFeatures? physicalDeviceVulkanMemoryModelFeatures = null, PhysicalDeviceShaderAtomicInt64Features? physicalDeviceShaderAtomicInt64Features = null, Multivendor.PhysicalDeviceShaderAtomicFloatFeatures? physicalDeviceShaderAtomicFloatFeaturesExt = null, Multivendor.PhysicalDeviceVertexAttributeDivisorFeatures? physicalDeviceVertexAttributeDivisorFeaturesExt = null, Multivendor.PhysicalDeviceASTCDecodeFeatures? physicalDeviceASTCDecodeFeaturesExt = null, Multivendor.PhysicalDeviceTransformFeedbackFeatures? physicalDeviceTransformFeedbackFeaturesExt = null, NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures? physicalDeviceRepresentativeFragmentTestFeaturesNv = null, NVidia.PhysicalDeviceExclusiveScissorFeatures? physicalDeviceExclusiveScissorFeaturesNv = null, NVidia.PhysicalDeviceCornerSampledImageFeatures? physicalDeviceCornerSampledImageFeaturesNv = null, NVidia.PhysicalDeviceComputeShaderDerivativesFeatures? physicalDeviceComputeShaderDerivativesFeaturesNv = null, NVidia.PhysicalDeviceFragmentShaderBarycentricFeatures? physicalDeviceFragmentShaderBarycentricFeaturesNv = null, NVidia.PhysicalDeviceShaderImageFootprintFeatures? physicalDeviceShaderImageFootprintFeaturesNv = null, NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures? physicalDeviceDedicatedAllocationImageAliasingFeaturesNv = null, NVidia.PhysicalDeviceShadingRateImageFeatures? physicalDeviceShadingRateImageFeaturesNv = null, NVidia.PhysicalDeviceMeshShaderFeatures? physicalDeviceMeshShaderFeaturesNv = null, Khronos.PhysicalDeviceRayTracingFeatures? physicalDeviceRayTracingFeaturesKhr = null, Amd.DeviceMemoryOverallocationCreateInfo? deviceMemoryOverallocationCreateInfoAmd = null, Multivendor.PhysicalDeviceFragmentDensityMapFeatures? physicalDeviceFragmentDensityMapFeaturesExt = null, Multivendor.PhysicalDeviceFragmentDensityMap2Features? physicalDeviceFragmentDensityMap2FeaturesExt = null, PhysicalDeviceScalarBlockLayoutFeatures? physicalDeviceScalarBlockLayoutFeatures = null, PhysicalDeviceUniformBufferStandardLayoutFeatures? physicalDeviceUniformBufferStandardLayoutFeatures = null, Multivendor.PhysicalDeviceDepthClipEnableFeatures? physicalDeviceDepthClipEnableFeaturesExt = null, Multivendor.PhysicalDeviceMemoryPriorityFeatures? physicalDeviceMemoryPriorityFeaturesExt = null, PhysicalDeviceBufferDeviceAddressFeatures? physicalDeviceBufferDeviceAddressFeatures = null, SharpVk.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures? physicalDeviceBufferDeviceAddressFeaturesExt = null, PhysicalDeviceImagelessFramebufferFeatures? physicalDeviceImagelessFramebufferFeatures = null, Multivendor.PhysicalDeviceTextureCompressionASTCHDRFeatures? physicalDeviceTextureCompressionASTCHDRFeaturesExt = null, NVidia.PhysicalDeviceCooperativeMatrixFeatures? physicalDeviceCooperativeMatrixFeaturesNv = null, Multivendor.PhysicalDeviceYcbcrImageArraysFeatures? physicalDeviceYcbcrImageArraysFeaturesExt = null, Khronos.PhysicalDevicePerformanceQueryFeatures? physicalDevicePerformanceQueryFeaturesKhr = null, NVidia.PhysicalDeviceCoverageReductionModeFeatures? physicalDeviceCoverageReductionModeFeaturesNv = null, Intel.PhysicalDeviceShaderIntegerFunctions2Features? physicalDeviceShaderIntegerFunctions2FeaturesIntel = null, Khronos.PhysicalDeviceShaderClockFeatures? physicalDeviceShaderClockFeaturesKhr = null, Multivendor.PhysicalDeviceIndexTypeUint8Features? physicalDeviceIndexTypeUint8FeaturesExt = null, NVidia.PhysicalDeviceShaderSMBuiltinsFeatures? physicalDeviceShaderSMBuiltinsFeaturesNv = null, Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures? physicalDeviceFragmentShaderInterlockFeaturesExt = null, PhysicalDeviceSeparateDepthStencilLayoutsFeatures? physicalDeviceSeparateDepthStencilLayoutsFeatures = null, Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures? physicalDevicePipelineExecutablePropertiesFeaturesKhr = null, Multivendor.PhysicalDeviceShaderDemoteToHelperInvocationFeatures? physicalDeviceShaderDemoteToHelperInvocationFeaturesExt = null, Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures? physicalDeviceTexelBufferAlignmentFeaturesExt = null, Multivendor.PhysicalDeviceSubgroupSizeControlFeatures? physicalDeviceSubgroupSizeControlFeaturesExt = null, Multivendor.PhysicalDeviceLineRasterizationFeatures? physicalDeviceLineRasterizationFeaturesExt = null, Multivendor.PhysicalDevicePipelineCreationCacheControlFeatures? physicalDevicePipelineCreationCacheControlFeaturesExt = null, PhysicalDeviceVulkan11Features? physicalDeviceVulkan11Features = null, PhysicalDeviceVulkan12Features? physicalDeviceVulkan12Features = null, Amd.PhysicalDeviceCoherentMemoryFeatures? physicalDeviceCoherentMemoryFeaturesAmd = null, Multivendor.PhysicalDeviceCustomBorderColorFeatures? physicalDeviceCustomBorderColorFeaturesExt = null, Multivendor.PhysicalDeviceExtendedDynamicStateFeatures? physicalDeviceExtendedDynamicStateFeaturesExt = null, NVidia.PhysicalDeviceDiagnosticsConfigFeatures? physicalDeviceDiagnosticsConfigFeaturesNv = null, NVidia.DeviceDiagnosticsConfigCreateInfo? deviceDiagnosticsConfigCreateInfoNv = null, Multivendor.PhysicalDeviceRobustness2Features? physicalDeviceRobustness2FeaturesExt = null, Multivendor.PhysicalDeviceImageRobustnessFeatures? physicalDeviceImageRobustnessFeaturesExt = null, Multivendor.PhysicalDevice4444FormatsFeatures? physicalDevice4444FormatsFeaturesExt = null, AllocationCallbacks? allocator = default)
        {
            try
            {
                Device result = default;
                SharpVk.Interop.DeviceCreateInfo* marshalledCreateInfo = default;
                void* vkDeviceCreateInfoNextPointer = default;
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default;
                SharpVk.Interop.Device marshalledDevice = default;
                if (physicalDeviceDeviceGeneratedCommandsFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsFeatures>());
                    physicalDeviceDeviceGeneratedCommandsFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (devicePrivateDataCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.DevicePrivateDataCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.DevicePrivateDataCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DevicePrivateDataCreateInfo>());
                    devicePrivateDataCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePrivateDataFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDevicePrivateDataFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDevicePrivateDataFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDevicePrivateDataFeatures>());
                    physicalDevicePrivateDataFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFeatures2 != null)
                {
                    SharpVk.Interop.PhysicalDeviceFeatures2* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceFeatures2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceFeatures2>());
                    physicalDeviceFeatures2.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVariablePointersFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceVariablePointersFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceVariablePointersFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceVariablePointersFeatures>());
                    physicalDeviceVariablePointersFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMultiviewFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceMultiviewFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceMultiviewFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceMultiviewFeatures>());
                    physicalDeviceMultiviewFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (deviceGroupDeviceCreateInfo != null)
                {
                    SharpVk.Interop.DeviceGroupDeviceCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.DeviceGroupDeviceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceGroupDeviceCreateInfo>());
                    deviceGroupDeviceCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevice16BitStorageFeatures != null)
                {
                    SharpVk.Interop.PhysicalDevice16BitStorageFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDevice16BitStorageFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDevice16BitStorageFeatures>());
                    physicalDevice16BitStorageFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderSubgroupExtendedTypesFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderSubgroupExtendedTypesFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderSubgroupExtendedTypesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderSubgroupExtendedTypesFeatures>());
                    physicalDeviceShaderSubgroupExtendedTypesFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSamplerYcbcrConversionFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceSamplerYcbcrConversionFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceSamplerYcbcrConversionFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceSamplerYcbcrConversionFeatures>());
                    physicalDeviceSamplerYcbcrConversionFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceProtectedMemoryFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceProtectedMemoryFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceProtectedMemoryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceProtectedMemoryFeatures>());
                    physicalDeviceProtectedMemoryFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceBlendOperationAdvancedFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceBlendOperationAdvancedFeatures>());
                    physicalDeviceBlendOperationAdvancedFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceInlineUniformBlockFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceInlineUniformBlockFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceInlineUniformBlockFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceInlineUniformBlockFeatures>());
                    physicalDeviceInlineUniformBlockFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderDrawParametersFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderDrawParametersFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderDrawParametersFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderDrawParametersFeatures>());
                    physicalDeviceShaderDrawParametersFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderFloat16Int8Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderFloat16Int8Features* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderFloat16Int8Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderFloat16Int8Features>());
                    physicalDeviceShaderFloat16Int8Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceHostQueryResetFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceHostQueryResetFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceHostQueryResetFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceHostQueryResetFeatures>());
                    physicalDeviceHostQueryResetFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDescriptorIndexingFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceDescriptorIndexingFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceDescriptorIndexingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceDescriptorIndexingFeatures>());
                    physicalDeviceDescriptorIndexingFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTimelineSemaphoreFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceTimelineSemaphoreFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceTimelineSemaphoreFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceTimelineSemaphoreFeatures>());
                    physicalDeviceTimelineSemaphoreFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevice8BitStorageFeatures != null)
                {
                    SharpVk.Interop.PhysicalDevice8BitStorageFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDevice8BitStorageFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDevice8BitStorageFeatures>());
                    physicalDevice8BitStorageFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceConditionalRenderingFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceConditionalRenderingFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceConditionalRenderingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceConditionalRenderingFeatures>());
                    physicalDeviceConditionalRenderingFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVulkanMemoryModelFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceVulkanMemoryModelFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceVulkanMemoryModelFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceVulkanMemoryModelFeatures>());
                    physicalDeviceVulkanMemoryModelFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderAtomicInt64Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceShaderAtomicInt64Features* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceShaderAtomicInt64Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceShaderAtomicInt64Features>());
                    physicalDeviceShaderAtomicInt64Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderAtomicFloatFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloatFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloatFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloatFeatures>());
                    physicalDeviceShaderAtomicFloatFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVertexAttributeDivisorFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceVertexAttributeDivisorFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceVertexAttributeDivisorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceVertexAttributeDivisorFeatures>());
                    physicalDeviceVertexAttributeDivisorFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceASTCDecodeFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceASTCDecodeFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceASTCDecodeFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceASTCDecodeFeatures>());
                    physicalDeviceASTCDecodeFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTransformFeedbackFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceTransformFeedbackFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceTransformFeedbackFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceTransformFeedbackFeatures>());
                    physicalDeviceTransformFeedbackFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRepresentativeFragmentTestFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceRepresentativeFragmentTestFeatures>());
                    physicalDeviceRepresentativeFragmentTestFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExclusiveScissorFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceExclusiveScissorFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceExclusiveScissorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceExclusiveScissorFeatures>());
                    physicalDeviceExclusiveScissorFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCornerSampledImageFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceCornerSampledImageFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceCornerSampledImageFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceCornerSampledImageFeatures>());
                    physicalDeviceCornerSampledImageFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceComputeShaderDerivativesFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceComputeShaderDerivativesFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceComputeShaderDerivativesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceComputeShaderDerivativesFeatures>());
                    physicalDeviceComputeShaderDerivativesFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentShaderBarycentricFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceFragmentShaderBarycentricFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceFragmentShaderBarycentricFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceFragmentShaderBarycentricFeatures>());
                    physicalDeviceFragmentShaderBarycentricFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderImageFootprintFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceShaderImageFootprintFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceShaderImageFootprintFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceShaderImageFootprintFeatures>());
                    physicalDeviceShaderImageFootprintFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDedicatedAllocationImageAliasingFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceDedicatedAllocationImageAliasingFeatures>());
                    physicalDeviceDedicatedAllocationImageAliasingFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShadingRateImageFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceShadingRateImageFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceShadingRateImageFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceShadingRateImageFeatures>());
                    physicalDeviceShadingRateImageFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMeshShaderFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceMeshShaderFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceMeshShaderFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceMeshShaderFeatures>());
                    physicalDeviceMeshShaderFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRayTracingFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceRayTracingFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceRayTracingFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceRayTracingFeatures>());
                    physicalDeviceRayTracingFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (deviceMemoryOverallocationCreateInfoAmd != null)
                {
                    SharpVk.Interop.Amd.DeviceMemoryOverallocationCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Amd.DeviceMemoryOverallocationCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.DeviceMemoryOverallocationCreateInfo>());
                    deviceMemoryOverallocationCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentDensityMapFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMapFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMapFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMapFeatures>());
                    physicalDeviceFragmentDensityMapFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentDensityMap2FeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMap2Features* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMap2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceFragmentDensityMap2Features>());
                    physicalDeviceFragmentDensityMap2FeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceScalarBlockLayoutFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceScalarBlockLayoutFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceScalarBlockLayoutFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceScalarBlockLayoutFeatures>());
                    physicalDeviceScalarBlockLayoutFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceUniformBufferStandardLayoutFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceUniformBufferStandardLayoutFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceUniformBufferStandardLayoutFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceUniformBufferStandardLayoutFeatures>());
                    physicalDeviceUniformBufferStandardLayoutFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDepthClipEnableFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceDepthClipEnableFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceDepthClipEnableFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceDepthClipEnableFeatures>());
                    physicalDeviceDepthClipEnableFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceMemoryPriorityFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceMemoryPriorityFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceMemoryPriorityFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceMemoryPriorityFeatures>());
                    physicalDeviceMemoryPriorityFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceBufferDeviceAddressFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceBufferDeviceAddressFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceBufferDeviceAddressFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceBufferDeviceAddressFeatures>());
                    physicalDeviceBufferDeviceAddressFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceBufferDeviceAddressFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceBufferDeviceAddressFeatures>());
                    physicalDeviceBufferDeviceAddressFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImagelessFramebufferFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceImagelessFramebufferFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceImagelessFramebufferFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceImagelessFramebufferFeatures>());
                    physicalDeviceImagelessFramebufferFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTextureCompressionASTCHDRFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceTextureCompressionASTCHDRFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceTextureCompressionASTCHDRFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceTextureCompressionASTCHDRFeatures>());
                    physicalDeviceTextureCompressionASTCHDRFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCooperativeMatrixFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrixFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrixFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceCooperativeMatrixFeatures>());
                    physicalDeviceCooperativeMatrixFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceYcbcrImageArraysFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceYcbcrImageArraysFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceYcbcrImageArraysFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceYcbcrImageArraysFeatures>());
                    physicalDeviceYcbcrImageArraysFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePerformanceQueryFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePerformanceQueryFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePerformanceQueryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePerformanceQueryFeatures>());
                    physicalDevicePerformanceQueryFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCoverageReductionModeFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceCoverageReductionModeFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceCoverageReductionModeFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceCoverageReductionModeFeatures>());
                    physicalDeviceCoverageReductionModeFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderIntegerFunctions2FeaturesIntel != null)
                {
                    SharpVk.Interop.Intel.PhysicalDeviceShaderIntegerFunctions2Features* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Intel.PhysicalDeviceShaderIntegerFunctions2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Intel.PhysicalDeviceShaderIntegerFunctions2Features>());
                    physicalDeviceShaderIntegerFunctions2FeaturesIntel.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderClockFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDeviceShaderClockFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDeviceShaderClockFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDeviceShaderClockFeatures>());
                    physicalDeviceShaderClockFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceIndexTypeUint8FeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceIndexTypeUint8Features* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceIndexTypeUint8Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceIndexTypeUint8Features>());
                    physicalDeviceIndexTypeUint8FeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderSMBuiltinsFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceShaderSMBuiltinsFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceShaderSMBuiltinsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceShaderSMBuiltinsFeatures>());
                    physicalDeviceShaderSMBuiltinsFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceFragmentShaderInterlockFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceFragmentShaderInterlockFeatures>());
                    physicalDeviceFragmentShaderInterlockFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSeparateDepthStencilLayoutsFeatures != null)
                {
                    SharpVk.Interop.PhysicalDeviceSeparateDepthStencilLayoutsFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceSeparateDepthStencilLayoutsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceSeparateDepthStencilLayoutsFeatures>());
                    physicalDeviceSeparateDepthStencilLayoutsFeatures.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePipelineExecutablePropertiesFeaturesKhr != null)
                {
                    SharpVk.Interop.Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PhysicalDevicePipelineExecutablePropertiesFeatures>());
                    physicalDevicePipelineExecutablePropertiesFeaturesKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceShaderDemoteToHelperInvocationFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceShaderDemoteToHelperInvocationFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceShaderDemoteToHelperInvocationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceShaderDemoteToHelperInvocationFeatures>());
                    physicalDeviceShaderDemoteToHelperInvocationFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceTexelBufferAlignmentFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceTexelBufferAlignmentFeatures>());
                    physicalDeviceTexelBufferAlignmentFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceSubgroupSizeControlFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceSubgroupSizeControlFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceSubgroupSizeControlFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceSubgroupSizeControlFeatures>());
                    physicalDeviceSubgroupSizeControlFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceLineRasterizationFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceLineRasterizationFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceLineRasterizationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceLineRasterizationFeatures>());
                    physicalDeviceLineRasterizationFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevicePipelineCreationCacheControlFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDevicePipelineCreationCacheControlFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDevicePipelineCreationCacheControlFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDevicePipelineCreationCacheControlFeatures>());
                    physicalDevicePipelineCreationCacheControlFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVulkan11Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceVulkan11Features* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceVulkan11Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceVulkan11Features>());
                    physicalDeviceVulkan11Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceVulkan12Features != null)
                {
                    SharpVk.Interop.PhysicalDeviceVulkan12Features* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.PhysicalDeviceVulkan12Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceVulkan12Features>());
                    physicalDeviceVulkan12Features.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCoherentMemoryFeaturesAmd != null)
                {
                    SharpVk.Interop.Amd.PhysicalDeviceCoherentMemoryFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Amd.PhysicalDeviceCoherentMemoryFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.PhysicalDeviceCoherentMemoryFeatures>());
                    physicalDeviceCoherentMemoryFeaturesAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceCustomBorderColorFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceCustomBorderColorFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceCustomBorderColorFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceCustomBorderColorFeatures>());
                    physicalDeviceCustomBorderColorFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceExtendedDynamicStateFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicStateFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicStateFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicStateFeatures>());
                    physicalDeviceExtendedDynamicStateFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceDiagnosticsConfigFeaturesNv != null)
                {
                    SharpVk.Interop.NVidia.PhysicalDeviceDiagnosticsConfigFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.PhysicalDeviceDiagnosticsConfigFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PhysicalDeviceDiagnosticsConfigFeatures>());
                    physicalDeviceDiagnosticsConfigFeaturesNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (deviceDiagnosticsConfigCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.DeviceDiagnosticsConfigCreateInfo* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.NVidia.DeviceDiagnosticsConfigCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.DeviceDiagnosticsConfigCreateInfo>());
                    deviceDiagnosticsConfigCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceRobustness2FeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceRobustness2Features* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceRobustness2Features*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceRobustness2Features>());
                    physicalDeviceRobustness2FeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDeviceImageRobustnessFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDeviceImageRobustnessFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDeviceImageRobustnessFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDeviceImageRobustnessFeatures>());
                    physicalDeviceImageRobustnessFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                if (physicalDevice4444FormatsFeaturesExt != null)
                {
                    SharpVk.Interop.Multivendor.PhysicalDevice4444FormatsFeatures* extensionPointer = default;
                    extensionPointer = (SharpVk.Interop.Multivendor.PhysicalDevice4444FormatsFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PhysicalDevice4444FormatsFeatures>());
                    physicalDevice4444FormatsFeaturesExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkDeviceCreateInfoNextPointer;
                    vkDeviceCreateInfoNextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.DeviceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DeviceCreateInfo;
                marshalledCreateInfo->Next = vkDeviceCreateInfoNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default;
                }
                marshalledCreateInfo->QueueCreateInfoCount = (uint)(Interop.HeapUtil.GetLength(queueCreateInfos));
                if (queueCreateInfos.IsNull())
                {
                    marshalledCreateInfo->QueueCreateInfos = null;
                }
                else
                {
                    if (queueCreateInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->QueueCreateInfos = (SharpVk.Interop.DeviceQueueCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceQueueCreateInfo>());
                        queueCreateInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.DeviceQueueCreateInfo*)(marshalledCreateInfo->QueueCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.DeviceQueueCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DeviceQueueCreateInfo>(Interop.HeapUtil.GetLength(queueCreateInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueCreateInfos.Value)); index++)
                        {
                            queueCreateInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfo->QueueCreateInfos = fieldPointer;
                    }
                }
                marshalledCreateInfo->EnabledLayerCount = (uint)(Interop.HeapUtil.GetLength(enabledLayerNames));
                marshalledCreateInfo->EnabledLayerNames = Interop.HeapUtil.MarshalTo(enabledLayerNames);
                marshalledCreateInfo->EnabledExtensionCount = (uint)(Interop.HeapUtil.GetLength(enabledExtensionNames));
                marshalledCreateInfo->EnabledExtensionNames = Interop.HeapUtil.MarshalTo(enabledExtensionNames);
                if (enabledFeatures != null)
                {
                    marshalledCreateInfo->EnabledFeatures = (SharpVk.Interop.PhysicalDeviceFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceFeatures>());
                    enabledFeatures.Value.MarshalTo(marshalledCreateInfo->EnabledFeatures);
                }
                else
                {
                    marshalledCreateInfo->EnabledFeatures = default;
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default;
                }
                Interop.VkPhysicalDeviceCreateDeviceDelegate commandDelegate = commandCache.Cache.vkCreateDevice;
                Result methodResult = commandDelegate(Handle, marshalledCreateInfo, marshalledAllocator, &marshalledDevice);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new Device(this, marshalledDevice);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Returns properties of available physical device extensions.
        /// </summary>
        /// <param name="layerName">
        /// </param>
        public unsafe ExtensionProperties[] EnumerateDeviceExtensionProperties(string layerName)
        {
            try
            {
                ExtensionProperties[] result = default;
                uint marshalledPropertyCount = default;
                SharpVk.Interop.ExtensionProperties* marshalledProperties = default;
                Interop.VkPhysicalDeviceEnumerateDeviceExtensionPropertiesDelegate commandDelegate = commandCache.Cache.vkEnumerateDeviceExtensionProperties;
                Result methodResult = commandDelegate(Handle, Interop.HeapUtil.MarshalTo(layerName), &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.ExtensionProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExtensionProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(Handle, Interop.HeapUtil.MarshalTo(layerName), &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new ExtensionProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = ExtensionProperties.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Returns properties of available physical device layers.
        /// </summary>
        public unsafe LayerProperties[] EnumerateDeviceLayerProperties()
        {
            try
            {
                LayerProperties[] result = default;
                uint marshalledPropertyCount = default;
                SharpVk.Interop.LayerProperties* marshalledProperties = default;
                Interop.VkPhysicalDeviceEnumerateDeviceLayerPropertiesDelegate commandDelegate = commandCache.Cache.vkEnumerateDeviceLayerProperties;
                Result methodResult = commandDelegate(Handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.LayerProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.LayerProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(Handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new LayerProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = LayerProperties.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Retrieve properties of an image format applied to sparse images.
        /// </summary>
        /// <param name="format">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="samples">
        /// </param>
        /// <param name="usage">
        /// </param>
        /// <param name="tiling">
        /// </param>
        public unsafe SparseImageFormatProperties[] GetSparseImageFormatProperties(Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling)
        {
            try
            {
                SparseImageFormatProperties[] result = default;
                uint marshalledPropertyCount = default;
                SparseImageFormatProperties* marshalledProperties = default;
                Interop.VkPhysicalDeviceGetSparseImageFormatPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSparseImageFormatProperties;
                commandDelegate(Handle, format, type, samples, usage, tiling, &marshalledPropertyCount, marshalledProperties);
                marshalledProperties = (SparseImageFormatProperties*)(Interop.HeapUtil.Allocate<SparseImageFormatProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(Handle, format, type, samples, usage, tiling, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SparseImageFormatProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = marshalledProperties[index];
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        public unsafe PhysicalDeviceFeatures2 GetFeatures2()
        {
            try
            {
                PhysicalDeviceFeatures2 result = default;
                SharpVk.Interop.PhysicalDeviceFeatures2 marshalledFeatures = default;
                Interop.VkPhysicalDeviceGetFeatures2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceFeatures2;
                commandDelegate(Handle, &marshalledFeatures);
                result = PhysicalDeviceFeatures2.MarshalFrom(&marshalledFeatures);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        public unsafe PhysicalDeviceProperties2 GetProperties2()
        {
            try
            {
                PhysicalDeviceProperties2 result = default;
                SharpVk.Interop.PhysicalDeviceProperties2 marshalledProperties = default;
                Interop.VkPhysicalDeviceGetProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceProperties2;
                commandDelegate(Handle, &marshalledProperties);
                result = PhysicalDeviceProperties2.MarshalFrom(&marshalledProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="format">
        /// </param>
        public unsafe FormatProperties2 GetFormatProperties2(Format format)
        {
            try
            {
                FormatProperties2 result = default;
                SharpVk.Interop.FormatProperties2 marshalledFormatProperties = default;
                Interop.VkPhysicalDeviceGetFormatProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceFormatProperties2;
                commandDelegate(Handle, format, &marshalledFormatProperties);
                result = FormatProperties2.MarshalFrom(&marshalledFormatProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="imageFormatInfo">
        /// </param>
        public unsafe ImageFormatProperties2 GetImageFormatProperties2(PhysicalDeviceImageFormatInfo2 imageFormatInfo)
        {
            try
            {
                ImageFormatProperties2 result = default;
                SharpVk.Interop.PhysicalDeviceImageFormatInfo2* marshalledImageFormatInfo = default;
                SharpVk.Interop.ImageFormatProperties2 marshalledImageFormatProperties = default;
                marshalledImageFormatInfo = (SharpVk.Interop.PhysicalDeviceImageFormatInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceImageFormatInfo2>());
                imageFormatInfo.MarshalTo(marshalledImageFormatInfo);
                Interop.VkPhysicalDeviceGetImageFormatProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceImageFormatProperties2;
                Result methodResult = commandDelegate(Handle, marshalledImageFormatInfo, &marshalledImageFormatProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = ImageFormatProperties2.MarshalFrom(&marshalledImageFormatProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        public unsafe QueueFamilyProperties2[] GetQueueFamilyProperties2()
        {
            try
            {
                QueueFamilyProperties2[] result = default;
                uint marshalledQueueFamilyPropertyCount = default;
                SharpVk.Interop.QueueFamilyProperties2* marshalledQueueFamilyProperties = default;
                Interop.VkPhysicalDeviceGetQueueFamilyProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceQueueFamilyProperties2;
                commandDelegate(Handle, &marshalledQueueFamilyPropertyCount, marshalledQueueFamilyProperties);
                marshalledQueueFamilyProperties = (SharpVk.Interop.QueueFamilyProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.QueueFamilyProperties2>((uint)(marshalledQueueFamilyPropertyCount)));
                commandDelegate(Handle, &marshalledQueueFamilyPropertyCount, marshalledQueueFamilyProperties);
                if (marshalledQueueFamilyProperties != null)
                {
                    var fieldPointer = new QueueFamilyProperties2[(uint)(marshalledQueueFamilyPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledQueueFamilyPropertyCount); index++)
                    {
                        fieldPointer[index] = QueueFamilyProperties2.MarshalFrom(&marshalledQueueFamilyProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        public unsafe PhysicalDeviceMemoryProperties2 GetMemoryProperties2()
        {
            try
            {
                PhysicalDeviceMemoryProperties2 result = default;
                SharpVk.Interop.PhysicalDeviceMemoryProperties2 marshalledMemoryProperties = default;
                Interop.VkPhysicalDeviceGetMemoryProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceMemoryProperties2;
                commandDelegate(Handle, &marshalledMemoryProperties);
                result = PhysicalDeviceMemoryProperties2.MarshalFrom(&marshalledMemoryProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="formatInfo">
        /// </param>
        public unsafe SparseImageFormatProperties2[] GetSparseImageFormatProperties2(PhysicalDeviceSparseImageFormatInfo2 formatInfo)
        {
            try
            {
                SparseImageFormatProperties2[] result = default;
                uint marshalledPropertyCount = default;
                SharpVk.Interop.PhysicalDeviceSparseImageFormatInfo2* marshalledFormatInfo = default;
                SharpVk.Interop.SparseImageFormatProperties2* marshalledProperties = default;
                marshalledFormatInfo = (SharpVk.Interop.PhysicalDeviceSparseImageFormatInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceSparseImageFormatInfo2>());
                formatInfo.MarshalTo(marshalledFormatInfo);
                Interop.VkPhysicalDeviceGetSparseImageFormatProperties2Delegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceSparseImageFormatProperties2;
                commandDelegate(Handle, marshalledFormatInfo, &marshalledPropertyCount, marshalledProperties);
                marshalledProperties = (SharpVk.Interop.SparseImageFormatProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SparseImageFormatProperties2>((uint)(marshalledPropertyCount)));
                commandDelegate(Handle, marshalledFormatInfo, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SparseImageFormatProperties2[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = SparseImageFormatProperties2.MarshalFrom(&marshalledProperties[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="externalBufferInfo">
        /// </param>
        public unsafe ExternalBufferProperties GetExternalBufferProperties(PhysicalDeviceExternalBufferInfo externalBufferInfo)
        {
            try
            {
                ExternalBufferProperties result = default;
                SharpVk.Interop.PhysicalDeviceExternalBufferInfo* marshalledExternalBufferInfo = default;
                SharpVk.Interop.ExternalBufferProperties marshalledExternalBufferProperties = default;
                marshalledExternalBufferInfo = (SharpVk.Interop.PhysicalDeviceExternalBufferInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceExternalBufferInfo>());
                externalBufferInfo.MarshalTo(marshalledExternalBufferInfo);
                Interop.VkPhysicalDeviceGetExternalBufferPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalBufferProperties;
                commandDelegate(Handle, marshalledExternalBufferInfo, &marshalledExternalBufferProperties);
                result = ExternalBufferProperties.MarshalFrom(&marshalledExternalBufferProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="externalFenceInfo">
        /// </param>
        public unsafe ExternalFenceProperties GetExternalFenceProperties(PhysicalDeviceExternalFenceInfo externalFenceInfo)
        {
            try
            {
                ExternalFenceProperties result = default;
                SharpVk.Interop.PhysicalDeviceExternalFenceInfo* marshalledExternalFenceInfo = default;
                SharpVk.Interop.ExternalFenceProperties marshalledExternalFenceProperties = default;
                marshalledExternalFenceInfo = (SharpVk.Interop.PhysicalDeviceExternalFenceInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceExternalFenceInfo>());
                externalFenceInfo.MarshalTo(marshalledExternalFenceInfo);
                Interop.VkPhysicalDeviceGetExternalFencePropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalFenceProperties;
                commandDelegate(Handle, marshalledExternalFenceInfo, &marshalledExternalFenceProperties);
                result = ExternalFenceProperties.MarshalFrom(&marshalledExternalFenceProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="externalSemaphoreInfo">
        /// </param>
        public unsafe ExternalSemaphoreProperties GetExternalSemaphoreProperties(PhysicalDeviceExternalSemaphoreInfo externalSemaphoreInfo)
        {
            try
            {
                ExternalSemaphoreProperties result = default;
                SharpVk.Interop.PhysicalDeviceExternalSemaphoreInfo* marshalledExternalSemaphoreInfo = default;
                SharpVk.Interop.ExternalSemaphoreProperties marshalledExternalSemaphoreProperties = default;
                marshalledExternalSemaphoreInfo = (SharpVk.Interop.PhysicalDeviceExternalSemaphoreInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PhysicalDeviceExternalSemaphoreInfo>());
                externalSemaphoreInfo.MarshalTo(marshalledExternalSemaphoreInfo);
                Interop.VkPhysicalDeviceGetExternalSemaphorePropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalSemaphoreProperties;
                commandDelegate(Handle, marshalledExternalSemaphoreInfo, &marshalledExternalSemaphoreProperties);
                result = ExternalSemaphoreProperties.MarshalFrom(&marshalledExternalSemaphoreProperties);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
