using System;
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public static unsafe class Commands
    {
        /// <summary>
        /// 
        /// </summary>
        public const string VulkanDll = "vulkan-1.dll"; 
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateInstance();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyInstance();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkEnumeratePhysicalDevices();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceProcAddr();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetInstanceProcAddr();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMemoryProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFeatures();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFormatProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceImageFormatProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateDevice();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDevice();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkEnumerateInstanceLayerProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkEnumerateInstanceExtensionProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkEnumerateDeviceLayerProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkEnumerateDeviceExtensionProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceQueue();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkQueueSubmit();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkQueueWaitIdle();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDeviceWaitIdle();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkAllocateMemory();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeMemory();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkMapMemory();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUnmapMemory();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFlushMappedMemoryRanges();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkInvalidateMappedMemoryRanges();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceMemoryCommitment();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetBufferMemoryRequirements();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkBindBufferMemory();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageMemoryRequirements();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkBindImageMemory();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSparseMemoryRequirements();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkQueueBindSparse();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateFence();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFence();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkResetFences();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetFenceStatus();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkWaitForFences();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateSemaphore();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySemaphore();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateEvent();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyEvent();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetEventStatus();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkSetEvent();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkResetEvent();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateQueryPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyQueryPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetQueryPoolResults();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateBufferView();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBufferView();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateImage();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImage();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSubresourceLayout();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateImageView();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImageView();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateShaderModule();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyShaderModule();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreatePipelineCache();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineCache();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPipelineCacheData();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkMergePipelineCaches();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateGraphicsPipelines();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateComputePipelines();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipeline();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreatePipelineLayout();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineLayout();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateSampler();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySampler();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateDescriptorSetLayout();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorSetLayout();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateDescriptorPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkResetDescriptorPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkAllocateDescriptorSets();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeDescriptorSets();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSets();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateFramebuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFramebuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateRenderPass();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyRenderPass();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetRenderAreaGranularity();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateCommandPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyCommandPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkResetCommandPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkAllocateCommandBuffers();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeCommandBuffers();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkBeginCommandBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkEndCommandBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkResetCommandBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindPipeline();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewport();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetScissor();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetLineWidth();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDepthBias();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetBlendConstants();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDepthBounds();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilCompareMask();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilWriteMask();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilReference();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindDescriptorSets();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindIndexBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindVertexBuffers();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDraw();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexed();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirect();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirect();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatch();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchIndirect();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyImage();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBlitImage();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyBufferToImage();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyImageToBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdUpdateBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdFillBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearColorImage();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearDepthStencilImage();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearAttachments();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResolveImage();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetEvent();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResetEvent();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWaitEvents();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPipelineBarrier();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginQuery();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndQuery();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResetQueryPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWriteTimestamp();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyQueryPoolResults();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushConstants();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginRenderPass();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdNextSubpass();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndRenderPass();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdExecuteCommands();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateAndroidSurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceDisplayPropertiesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceDisplayPlanePropertiesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDisplayPlaneSupportedDisplaysKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDisplayModePropertiesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateDisplayModeKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDisplayPlaneCapabilitiesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateDisplayPlaneSurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateSharedSwapchainsKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateMirSurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMirPresentationSupportKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSurfaceSupportKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSurfaceCapabilitiesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSurfaceFormatsKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSurfacePresentModesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateSwapchainKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySwapchainKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetSwapchainImagesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkAcquireNextImageKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkQueuePresentKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateViSurfaceNN();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateWaylandSurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceWaylandPresentationSupportKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateWin32SurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceWin32PresentationSupportKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateXlibSurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceXlibPresentationSupportKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateXcbSurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceXcbPresentationSupportKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateDebugReportCallbackEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDebugReportCallbackEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDebugReportMessageEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDebugMarkerSetObjectNameEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDebugMarkerSetObjectTagEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerBeginEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerEndEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerInsertEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalImageFormatPropertiesNV();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetMemoryWin32HandleNV();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirectCountAMD();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirectCountAMD();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdProcessCommandsNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdReserveSpaceForCommandsNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateIndirectCommandsLayoutNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyIndirectCommandsLayoutNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateObjectTableNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyObjectTableNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkRegisterObjectsNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUnregisterObjectsNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFeatures2KHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceProperties2KHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFormatProperties2KHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceImageFormatProperties2KHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2KHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2KHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2KHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushDescriptorSetKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkTrimCommandPoolKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalBufferPropertiesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetMemoryWin32HandleKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetMemoryWin32HandlePropertiesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetMemoryFdKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetMemoryFdPropertiesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalSemaphorePropertiesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetSemaphoreWin32HandleKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkImportSemaphoreWin32HandleKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetSemaphoreFdKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkImportSemaphoreFdKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkReleaseDisplayEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkAcquireXlibDisplayEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetRandROutputDisplayEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDisplayPowerControlEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkRegisterDeviceEventEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkRegisterDisplayEventEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetSwapchainCounterEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSurfaceCapabilities2EXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkEnumeratePhysicalDeviceGroupsKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceGroupPeerMemoryFeaturesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkBindBufferMemory2KHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkBindImageMemory2KHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDeviceMaskKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceGroupPresentCapabilitiesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceGroupSurfacePresentModesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkAcquireNextImage2KHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchBaseKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDevicePresentRectanglesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateDescriptorUpdateTemplateKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorUpdateTemplateKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSetWithTemplateKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushDescriptorSetWithTemplateKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkSetHdrMetadataEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetRefreshCycleDurationGOOGLE();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPastPresentationTimingGOOGLE();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateIOSSurfaceMVK();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCreateMacOSSurfaceMVK();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewportWScalingNV();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDiscardRectangleEXT();
    }
}
