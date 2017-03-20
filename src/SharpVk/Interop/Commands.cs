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
        public static extern Result vkCreateInstance();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyInstance();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumeratePhysicalDevices();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern VoidFunctionDelegate vkGetDeviceProcAddr();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern VoidFunctionDelegate vkGetInstanceProcAddr();
        
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
        public static extern Result vkGetPhysicalDeviceImageFormatProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDevice();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDevice();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumerateInstanceLayerProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumerateInstanceExtensionProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumerateDeviceLayerProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumerateDeviceExtensionProperties();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceQueue();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkQueueSubmit();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkQueueWaitIdle();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkDeviceWaitIdle();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAllocateMemory();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeMemory();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkMapMemory();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUnmapMemory();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkFlushMappedMemoryRanges();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkInvalidateMappedMemoryRanges();
        
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
        public static extern Result vkBindBufferMemory();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageMemoryRequirements();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBindImageMemory();
        
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
        public static extern Result vkQueueBindSparse();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateFence();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFence();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetFences();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetFenceStatus();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkWaitForFences();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateSemaphore();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySemaphore();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateEvent();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyEvent();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetEventStatus();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkSetEvent();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetEvent();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateQueryPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyQueryPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetQueryPoolResults();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateBufferView();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBufferView();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateImage();
        
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
        public static extern Result vkCreateImageView();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImageView();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateShaderModule();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyShaderModule();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreatePipelineCache();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineCache();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPipelineCacheData();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkMergePipelineCaches();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateGraphicsPipelines();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateComputePipelines();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipeline();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreatePipelineLayout();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineLayout();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateSampler();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySampler();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDescriptorSetLayout();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorSetLayout();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDescriptorPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetDescriptorPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAllocateDescriptorSets();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkFreeDescriptorSets();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSets();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateFramebuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFramebuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateRenderPass();
        
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
        public static extern Result vkCreateCommandPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyCommandPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetCommandPool();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAllocateCommandBuffers();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeCommandBuffers();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBeginCommandBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEndCommandBuffer();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetCommandBuffer();
        
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
        public static extern Result vkCreateAndroidSurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceDisplayPropertiesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceDisplayPlanePropertiesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDisplayPlaneSupportedDisplaysKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDisplayModePropertiesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDisplayModeKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDisplayPlaneCapabilitiesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDisplayPlaneSurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateSharedSwapchainsKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateMirSurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceMirPresentationSupportKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfaceSupportKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfaceCapabilitiesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfaceFormatsKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfacePresentModesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateSwapchainKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySwapchainKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetSwapchainImagesKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAcquireNextImageKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkQueuePresentKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateViSurfaceNN();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateWaylandSurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateWin32SurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceWin32PresentationSupportKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateXlibSurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceXlibPresentationSupportKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateXcbSurfaceKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceXcbPresentationSupportKHR();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDebugReportCallbackEXT();
        
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
        public static extern Result vkDebugMarkerSetObjectNameEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkDebugMarkerSetObjectTagEXT();
        
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
        public static extern Result vkGetPhysicalDeviceExternalImageFormatPropertiesNV();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryWin32HandleNV();
        
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
        public static extern Result vkCreateIndirectCommandsLayoutNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyIndirectCommandsLayoutNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateObjectTableNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyObjectTableNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkRegisterObjectsNVX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkUnregisterObjectsNVX();
        
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
        public static extern Result vkGetPhysicalDeviceImageFormatProperties2KHR();
        
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
        public static extern Result vkGetMemoryWin32HandleKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryWin32HandlePropertiesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryFdKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryFdPropertiesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalSemaphorePropertiesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetSemaphoreWin32HandleKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkImportSemaphoreWin32HandleKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetSemaphoreFdKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkImportSemaphoreFdKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkReleaseDisplayEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAcquireXlibDisplayEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetRandROutputDisplayEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkDisplayPowerControlEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkRegisterDeviceEventEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkRegisterDisplayEventEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetSwapchainCounterEXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfaceCapabilities2EXT();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumeratePhysicalDeviceGroupsKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceGroupPeerMemoryFeaturesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBindBufferMemory2KHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBindImageMemory2KHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDeviceMaskKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDeviceGroupPresentCapabilitiesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDeviceGroupSurfacePresentModesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAcquireNextImage2KHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchBaseKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDevicePresentRectanglesKHX();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDescriptorUpdateTemplateKHR();
        
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
        public static extern Result vkGetRefreshCycleDurationGOOGLE();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPastPresentationTimingGOOGLE();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateIOSSurfaceMVK();
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateMacOSSurfaceMVK();
        
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
