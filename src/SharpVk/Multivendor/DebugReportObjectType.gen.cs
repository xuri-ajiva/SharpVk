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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// Specify the type of an object handle.
    /// </summary>
    public enum DebugReportObjectType
    {
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT is an unknown object.
        /// </summary>
        Unknown = 0, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT is a
        /// sname:VkInstance.
        /// </summary>
        Instance = 1, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT is a
        /// sname:VkPhysicalDevice.
        /// </summary>
        PhysicalDevice = 2, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT is a sname:VkDevice.
        /// </summary>
        Device = 3, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT is a sname:VkQueue.
        /// </summary>
        Queue = 4, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT is a
        /// sname:VkSemaphore.
        /// </summary>
        Semaphore = 5, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT is a
        /// sname:VkCommandBuffer.
        /// </summary>
        CommandBuffer = 6, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT is a sname:VkFence.
        /// </summary>
        Fence = 7, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT is a
        /// sname:VkDeviceMemory.
        /// </summary>
        DeviceMemory = 8, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT is a sname:VkBuffer.
        /// </summary>
        Buffer = 9, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT is a sname:VkImage.
        /// </summary>
        Image = 10, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT is a sname:VkEvent.
        /// </summary>
        Event = 11, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT is a
        /// sname:VkQueryPool.
        /// </summary>
        QueryPool = 12, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT is a
        /// sname:VkBufferView.
        /// </summary>
        BufferView = 13, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT is a
        /// sname:VkImageView.
        /// </summary>
        ImageView = 14, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT is a
        /// sname:VkShaderModule.
        /// </summary>
        ShaderModule = 15, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT is a
        /// sname:VkPipelineCache.
        /// </summary>
        PipelineCache = 16, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT is a
        /// sname:VkPipelineLayout.
        /// </summary>
        PipelineLayout = 17, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT is a
        /// sname:VkRenderPass.
        /// </summary>
        RenderPass = 18, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT is a
        /// sname:VkPipeline.
        /// </summary>
        Pipeline = 19, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT is a
        /// sname:VkDescriptorSetLayout.
        /// </summary>
        DescriptorSetLayout = 20, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT is a sname:VkSampler.
        /// </summary>
        Sampler = 21, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT is a
        /// sname:VkDescriptorPool.
        /// </summary>
        DescriptorPool = 22, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT is a
        /// sname:VkDescriptorSet.
        /// </summary>
        DescriptorSet = 23, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT is a
        /// sname:VkFramebuffer.
        /// </summary>
        Framebuffer = 24, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT is a
        /// sname:VkCommandPool.
        /// </summary>
        CommandPool = 25, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT is a
        /// sname:VkSurfaceKHR.
        /// </summary>
        SurfaceKhr = 26, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT is a
        /// sname:VkSwapchainKHR.
        /// </summary>
        SwapchainKhr = 27, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugReportCallbackExt = 28, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT is a
        /// sname:VkDisplayKHR.
        /// </summary>
        DisplayKhr = 29, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT is a
        /// sname:VkDisplayModeKHR.
        /// </summary>
        DisplayModeKhr = 30, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_OBJECT_TABLE_NVX_EXT is a
        /// sname:VkObjectTableNVX.
        /// </summary>
        ObjectTableNvx = 31, 
        
        /// <summary>
        /// ename:VK_DEBUG_REPORT_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NVX_EXT
        /// is a sname:VkIndirectCommandsLayoutNVX.
        /// </summary>
        IndirectCommandsLayoutNvx = 32, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorUpdateTemplateKhrKhr = 1000085000, 
    }
}
