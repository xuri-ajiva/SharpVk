// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
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

namespace SharpVk
{
    /// <summary>
    /// -
    /// </summary>
    public enum StructureType
    {
        /// <summary>
        /// -
        /// </summary>
        ApplicationInfo = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        InstanceCreateInfo = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        DeviceQueueCreateInfo = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        DeviceCreateInfo = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        SubmitInfo = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        MemoryAllocateInfo = 5, 
        
        /// <summary>
        /// -
        /// </summary>
        MappedMemoryRange = 6, 
        
        /// <summary>
        /// -
        /// </summary>
        BindSparseInfo = 7, 
        
        /// <summary>
        /// -
        /// </summary>
        FenceCreateInfo = 8, 
        
        /// <summary>
        /// -
        /// </summary>
        SemaphoreCreateInfo = 9, 
        
        /// <summary>
        /// -
        /// </summary>
        EventCreateInfo = 10, 
        
        /// <summary>
        /// -
        /// </summary>
        QueryPoolCreateInfo = 11, 
        
        /// <summary>
        /// -
        /// </summary>
        BufferCreateInfo = 12, 
        
        /// <summary>
        /// -
        /// </summary>
        BufferViewCreateInfo = 13, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageCreateInfo = 14, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageViewCreateInfo = 15, 
        
        /// <summary>
        /// -
        /// </summary>
        ShaderModuleCreateInfo = 16, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineCacheCreateInfo = 17, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineShaderStageCreateInfo = 18, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineVertexInputStateCreateInfo = 19, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineInputAssemblyStateCreateInfo = 20, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineTessellationStateCreateInfo = 21, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineViewportStateCreateInfo = 22, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineRasterizationStateCreateInfo = 23, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineMultisampleStateCreateInfo = 24, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineDepthStencilStateCreateInfo = 25, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineColorBlendStateCreateInfo = 26, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineDynamicStateCreateInfo = 27, 
        
        /// <summary>
        /// -
        /// </summary>
        GraphicsPipelineCreateInfo = 28, 
        
        /// <summary>
        /// -
        /// </summary>
        ComputePipelineCreateInfo = 29, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineLayoutCreateInfo = 30, 
        
        /// <summary>
        /// -
        /// </summary>
        SamplerCreateInfo = 31, 
        
        /// <summary>
        /// -
        /// </summary>
        DescriptorSetLayoutCreateInfo = 32, 
        
        /// <summary>
        /// -
        /// </summary>
        DescriptorPoolCreateInfo = 33, 
        
        /// <summary>
        /// -
        /// </summary>
        DescriptorSetAllocateInfo = 34, 
        
        /// <summary>
        /// -
        /// </summary>
        WriteDescriptorSet = 35, 
        
        /// <summary>
        /// -
        /// </summary>
        CopyDescriptorSet = 36, 
        
        /// <summary>
        /// -
        /// </summary>
        FramebufferCreateInfo = 37, 
        
        /// <summary>
        /// -
        /// </summary>
        RenderPassCreateInfo = 38, 
        
        /// <summary>
        /// -
        /// </summary>
        CommandPoolCreateInfo = 39, 
        
        /// <summary>
        /// -
        /// </summary>
        CommandBufferAllocateInfo = 40, 
        
        /// <summary>
        /// -
        /// </summary>
        CommandBufferInheritanceInfo = 41, 
        
        /// <summary>
        /// -
        /// </summary>
        CommandBufferBeginInfo = 42, 
        
        /// <summary>
        /// -
        /// </summary>
        RenderPassBeginInfo = 43, 
        
        /// <summary>
        /// -
        /// </summary>
        BufferMemoryBarrier = 44, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageMemoryBarrier = 45, 
        
        /// <summary>
        /// -
        /// </summary>
        MemoryBarrier = 46, 
        
        /// <summary>
        /// -
        /// </summary>
        LoaderInstanceCreateInfo = 47, 
        
        /// <summary>
        /// -
        /// </summary>
        LoaderDeviceCreateInfo = 48, 
        
        /// <summary>
        /// -
        /// </summary>
        SwapchainCreateInfo = 1000001000, 
        
        /// <summary>
        /// -
        /// </summary>
        PresentInfo = 1000001001, 
        
        /// <summary>
        /// -
        /// </summary>
        DisplayModeCreateInfo = 1000002000, 
        
        /// <summary>
        /// -
        /// </summary>
        DisplaySurfaceCreateInfo = 1000002001, 
        
        /// <summary>
        /// -
        /// </summary>
        DisplayPresentInfo = 1000003000, 
        
        /// <summary>
        /// -
        /// </summary>
        XlibSurfaceCreateInfo = 1000004000, 
        
        /// <summary>
        /// -
        /// </summary>
        XcbSurfaceCreateInfo = 1000005000, 
        
        /// <summary>
        /// -
        /// </summary>
        WaylandSurfaceCreateInfo = 1000006000, 
        
        /// <summary>
        /// -
        /// </summary>
        MirSurfaceCreateInfo = 1000007000, 
        
        /// <summary>
        /// -
        /// </summary>
        AndroidSurfaceCreateInfo = 1000008000, 
        
        /// <summary>
        /// -
        /// </summary>
        Win32SurfaceCreateInfo = 1000009000, 
        
        /// <summary>
        /// -
        /// </summary>
        DebugReportCallbackCreateInfo = 1000011000, 
        
        /// <summary>
        /// -
        /// </summary>
        PipelineRasterizationStateRasterizationOrder = 1000018000, 
        
        /// <summary>
        /// -
        /// </summary>
        DebugMarkerObjectNameInfo = 1000022000, 
        
        /// <summary>
        /// -
        /// </summary>
        DebugMarkerObjectTagInfo = 1000022001, 
        
        /// <summary>
        /// -
        /// </summary>
        DebugMarkerMarkerInfo = 1000022002, 
        
        /// <summary>
        /// -
        /// </summary>
        DedicatedAllocationImageCreateInfo = 1000026000, 
        
        /// <summary>
        /// -
        /// </summary>
        DedicatedAllocationBufferCreateInfo = 1000026001, 
        
        /// <summary>
        /// -
        /// </summary>
        DedicatedAllocationMemoryAllocateInfo = 1000026002, 
        
        /// <summary>
        /// -
        /// </summary>
        ExternalMemoryImageCreateInfo = 1000056000, 
        
        /// <summary>
        /// -
        /// </summary>
        ExportMemoryAllocateInfo = 1000056001, 
        
        /// <summary>
        /// -
        /// </summary>
        ImportMemoryWin32HandleInfo = 1000057000, 
        
        /// <summary>
        /// -
        /// </summary>
        ExportMemoryWin32HandleInfo = 1000057001, 
        
        /// <summary>
        /// -
        /// </summary>
        Win32KeyedMutexAcquireReleaseInfo = 1000058000, 
        
        /// <summary>
        /// -
        /// </summary>
        ValidationFlags = 1000061000, 
        
        /// <summary>
        /// -
        /// </summary>
        ObjectTableCreateInfoNvx = 1000086000, 
        
        /// <summary>
        /// -
        /// </summary>
        IndirectCommandsLayoutCreateInfoNvx = 1000086001, 
        
        /// <summary>
        /// -
        /// </summary>
        CommandProcessCommandsInfoNvx = 1000086002, 
        
        /// <summary>
        /// -
        /// </summary>
        CommandReserveSpaceForCommandsInfoNvx = 1000086003, 
        
        /// <summary>
        /// -
        /// </summary>
        DeviceGeneratedCommandsLimitsNvx = 1000086004, 
        
        /// <summary>
        /// -
        /// </summary>
        DeviceGeneratedCommandsFeaturesNvx = 1000086005, 
    }
}
