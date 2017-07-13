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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum StructureType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationInfo = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        InstanceCreateInfo = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceQueueCreateInfo = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceCreateInfo = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        SubmitInfo = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryAllocateInfo = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        MappedMemoryRange = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        BindSparseInfo = 7, 
        
        /// <summary>
        /// 
        /// </summary>
        FenceCreateInfo = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        SemaphoreCreateInfo = 9, 
        
        /// <summary>
        /// 
        /// </summary>
        EventCreateInfo = 10, 
        
        /// <summary>
        /// 
        /// </summary>
        QueryPoolCreateInfo = 11, 
        
        /// <summary>
        /// 
        /// </summary>
        BufferCreateInfo = 12, 
        
        /// <summary>
        /// 
        /// </summary>
        BufferViewCreateInfo = 13, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageCreateInfo = 14, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageViewCreateInfo = 15, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderModuleCreateInfo = 16, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineCacheCreateInfo = 17, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineShaderStageCreateInfo = 18, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineVertexInputStateCreateInfo = 19, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineInputAssemblyStateCreateInfo = 20, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineTessellationStateCreateInfo = 21, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineViewportStateCreateInfo = 22, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineRasterizationStateCreateInfo = 23, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineMultisampleStateCreateInfo = 24, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineDepthStencilStateCreateInfo = 25, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineColorBlendStateCreateInfo = 26, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineDynamicStateCreateInfo = 27, 
        
        /// <summary>
        /// 
        /// </summary>
        GraphicsPipelineCreateInfo = 28, 
        
        /// <summary>
        /// 
        /// </summary>
        ComputePipelineCreateInfo = 29, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineLayoutCreateInfo = 30, 
        
        /// <summary>
        /// 
        /// </summary>
        SamplerCreateInfo = 31, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorSetLayoutCreateInfo = 32, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorPoolCreateInfo = 33, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorSetAllocateInfo = 34, 
        
        /// <summary>
        /// 
        /// </summary>
        WriteDescriptorSet = 35, 
        
        /// <summary>
        /// 
        /// </summary>
        CopyDescriptorSet = 36, 
        
        /// <summary>
        /// 
        /// </summary>
        FramebufferCreateInfo = 37, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderPassCreateInfo = 38, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandPoolCreateInfo = 39, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandBufferAllocateInfo = 40, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandBufferInheritanceInfo = 41, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandBufferBeginInfo = 42, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderPassBeginInfo = 43, 
        
        /// <summary>
        /// 
        /// </summary>
        BufferMemoryBarrier = 44, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageMemoryBarrier = 45, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryBarrier = 46, 
        
        /// <summary>
        /// 
        /// </summary>
        LoaderInstanceCreateInfo = 47, 
        
        /// <summary>
        /// 
        /// </summary>
        LoaderDeviceCreateInfo = 48, 
        
        /// <summary>
        /// 
        /// </summary>
        SwapchainCreateInfoKhr = 1000001000, 
        
        /// <summary>
        /// 
        /// </summary>
        PresentInfoKhr = 1000001001, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayModeCreateInfoKhr = 1000002000, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplaySurfaceCreateInfoKhr = 1000002001, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayPresentInfoKhr = 1000003000, 
        
        /// <summary>
        /// 
        /// </summary>
        XlibSurfaceCreateInfoKhr = 1000004000, 
        
        /// <summary>
        /// 
        /// </summary>
        XcbSurfaceCreateInfoKhr = 1000005000, 
        
        /// <summary>
        /// 
        /// </summary>
        WaylandSurfaceCreateInfoKhr = 1000006000, 
        
        /// <summary>
        /// 
        /// </summary>
        MirSurfaceCreateInfoKhr = 1000007000, 
        
        /// <summary>
        /// 
        /// </summary>
        AndroidSurfaceCreateInfoKhr = 1000008000, 
        
        /// <summary>
        /// 
        /// </summary>
        Win32SurfaceCreateInfoKhr = 1000009000, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugReportCallbackCreateInfoExt = 1000011000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineRasterizationStateRasterizationOrderAmd = 1000018000, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugMarkerObjectNameInfoExt = 1000022000, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugMarkerObjectTagInfoExt = 1000022001, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugMarkerMarkerInfoExt = 1000022002, 
        
        /// <summary>
        /// 
        /// </summary>
        DedicatedAllocationImageCreateInfoNv = 1000026000, 
        
        /// <summary>
        /// 
        /// </summary>
        DedicatedAllocationBufferCreateInfoNv = 1000026001, 
        
        /// <summary>
        /// 
        /// </summary>
        DedicatedAllocationMemoryAllocateInfoNv = 1000026002, 
        
        /// <summary>
        /// 
        /// </summary>
        TextureLodGatherFormatPropertiesAmd = 1000041000, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderPassMultiviewCreateInfoKhx = 1000053000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceMultiviewFeaturesKhx = 1000053001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceMultiviewPropertiesKhx = 1000053002, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalMemoryImageCreateInfoNv = 1000056000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportMemoryAllocateInfoNv = 1000056001, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportMemoryWin32HandleInfoNv = 1000057000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportMemoryWin32HandleInfoNv = 1000057001, 
        
        /// <summary>
        /// 
        /// </summary>
        Win32KeyedMutexAcquireReleaseInfoNv = 1000058000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceFeatures2Khr = 1000059000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceProperties2Khr = 1000059001, 
        
        /// <summary>
        /// 
        /// </summary>
        FormatProperties2Khr = 1000059002, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageFormatProperties2Khr = 1000059003, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceImageFormatInfo2Khr = 1000059004, 
        
        /// <summary>
        /// 
        /// </summary>
        QueueFamilyProperties2Khr = 1000059005, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceMemoryProperties2Khr = 1000059006, 
        
        /// <summary>
        /// 
        /// </summary>
        SparseImageFormatProperties2Khr = 1000059007, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceSparseImageFormatInfo2Khr = 1000059008, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryAllocateFlagsInfoKhx = 1000060000, 
        
        /// <summary>
        /// 
        /// </summary>
        BindBufferMemoryInfoKhx = 1000060001, 
        
        /// <summary>
        /// 
        /// </summary>
        BindImageMemoryInfoKhx = 1000060002, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupRenderPassBeginInfoKhx = 1000060003, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupCommandBufferBeginInfoKhx = 1000060004, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupSubmitInfoKhx = 1000060005, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupBindSparseInfoKhx = 1000060006, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupPresentCapabilitiesKhx = 1000060007, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageSwapchainCreateInfoKhx = 1000060008, 
        
        /// <summary>
        /// 
        /// </summary>
        BindImageMemorySwapchainInfoKhx = 1000060009, 
        
        /// <summary>
        /// 
        /// </summary>
        AcquireNextImageInfoKhx = 1000060010, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupPresentInfoKhx = 1000060011, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupSwapchainCreateInfoKhx = 1000060012, 
        
        /// <summary>
        /// 
        /// </summary>
        ValidationFlagsExt = 1000061000, 
        
        /// <summary>
        /// 
        /// </summary>
        ViSurfaceCreateInfoNn = 1000062000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceGroupPropertiesKhx = 1000070000, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupDeviceCreateInfoKhx = 1000070001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceExternalImageFormatInfoKhr = 1000071000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalImageFormatPropertiesKhr = 1000071001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceExternalBufferInfoKhr = 1000071002, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalBufferPropertiesKhr = 1000071003, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceIdPropertiesKhr = 1000071004, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalMemoryBufferCreateInfoKhr = 1000072000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalMemoryImageCreateInfoKhr = 1000072001, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportMemoryAllocateInfoKhr = 1000072002, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportMemoryWin32HandleInfoKhr = 1000073000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportMemoryWin32HandleInfoKhr = 1000073001, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryWin32HandlePropertiesKhr = 1000073002, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryGetWin32HandleInfoKhr = 1000073003, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportMemoryFileDescriptorInfoKhr = 1000074000, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryFileDescriptorPropertiesKhr = 1000074001, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryGetFileDescriptorInfoKhr = 1000074002, 
        
        /// <summary>
        /// 
        /// </summary>
        Win32KeyedMutexAcquireReleaseInfoKhr = 1000075000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceExternalSemaphoreInfoKhr = 1000076000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalSemaphorePropertiesKhr = 1000076001, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportSemaphoreCreateInfoKhr = 1000077000, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportSemaphoreWin32HandleInfoKhr = 1000078000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportSemaphoreWin32HandleInfoKhr = 1000078001, 
        
        /// <summary>
        /// 
        /// </summary>
        D3d12FenceSubmitInfoKhr = 1000078002, 
        
        /// <summary>
        /// 
        /// </summary>
        SemaphoreGetWin32HandleInfoKhr = 1000078003, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportSemaphoreFileDescriptorInfoKhr = 1000079000, 
        
        /// <summary>
        /// 
        /// </summary>
        SemaphoreGetFileDescriptorInfoKhr = 1000079001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDevicePushDescriptorPropertiesKhr = 1000080000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDevice16bitStorageFeaturesKhr = 1000083000, 
        
        /// <summary>
        /// 
        /// </summary>
        PresentRegionsKhr = 1000084000, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorUpdateTemplateCreateInfoKhr = 1000085000, 
        
        /// <summary>
        /// 
        /// </summary>
        ObjectTableCreateInfoNvx = 1000086000, 
        
        /// <summary>
        /// 
        /// </summary>
        IndirectCommandsLayoutCreateInfoNvx = 1000086001, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandProcessCommandsInfoNvx = 1000086002, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandReserveSpaceForCommandsInfoNvx = 1000086003, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGeneratedCommandsLimitsNvx = 1000086004, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGeneratedCommandsFeaturesNvx = 1000086005, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineViewportWScalingStateCreateInfoNv = 1000087000, 
        
        /// <summary>
        /// 
        /// </summary>
        SurfaceCapabilities2Ext = 1000090000, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayPowerInfoExt = 1000091000, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceEventInfoExt = 1000091001, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayEventInfoExt = 1000091002, 
        
        /// <summary>
        /// 
        /// </summary>
        SwapchainCounterCreateInfoExt = 1000091003, 
        
        /// <summary>
        /// 
        /// </summary>
        PresentTimesInfoGoogle = 1000092000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceMultiviewPerViewAttributesPropertiesNvx = 1000097000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineViewportSwizzleStateCreateInfoNv = 1000098000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceDiscardRectanglePropertiesExt = 1000099000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineDiscardRectangleStateCreateInfoExt = 1000099001, 
        
        /// <summary>
        /// 
        /// </summary>
        HdrMetadataExt = 1000105000, 
        
        /// <summary>
        /// 
        /// </summary>
        SharedPresentSurfaceCapabilitiesKhr = 1000111000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceExternalFenceInfoKhr = 1000112000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalFencePropertiesKhr = 1000112001, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportFenceCreateInfoKhr = 1000113000, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportFenceWin32HandleInfoKhr = 1000114000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportFenceWin32HandleInfoKhr = 1000114001, 
        
        /// <summary>
        /// 
        /// </summary>
        FenceGetWin32HandleInfoKhr = 1000114002, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportFenceFileDescriptorInfoKhr = 1000115000, 
        
        /// <summary>
        /// 
        /// </summary>
        FenceGetFileDescriptorInfoKhr = 1000115001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceSurfaceInfo2Khr = 1000119000, 
        
        /// <summary>
        /// 
        /// </summary>
        SurfaceCapabilities2Khr = 1000119001, 
        
        /// <summary>
        /// 
        /// </summary>
        SurfaceFormat2Khr = 1000119002, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceVariablePointerFeaturesKhr = 1000120000, 
        
        /// <summary>
        /// 
        /// </summary>
        IosSurfaceCreateInfoMvk = 1000122000, 
        
        /// <summary>
        /// 
        /// </summary>
        MacosSurfaceCreateInfoMvk = 1000123000, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryDedicatedRequirementsKhr = 1000127000, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryDedicatedAllocateInfoKhr = 1000127001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceSamplerFilterMinmaxPropertiesExt = 1000130000, 
        
        /// <summary>
        /// 
        /// </summary>
        SamplerReductionModeCreateInfoExt = 1000130001, 
        
        /// <summary>
        /// 
        /// </summary>
        BufferMemoryRequirementsInfo2Khr = 1000146000, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageMemoryRequirementsInfo2Khr = 1000146001, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageSparseMemoryRequirementsInfo2Khr = 1000146002, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryRequirements2Khr = 1000146003, 
        
        /// <summary>
        /// 
        /// </summary>
        SparseImageMemoryRequirements2Khr = 1000146004, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceBlendOperationAdvancedFeaturesExt = 1000148000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceBlendOperationAdvancedPropertiesExt = 1000148001, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineColorBlendAdvancedStateCreateInfoExt = 1000148002, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineCoverageToColorStateCreateInfoNv = 1000149000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineCoverageModulationStateCreateInfoNv = 1000152000, 
    }
}
