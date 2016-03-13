
using System;
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
	public static class NativeMethods
	{
		public const string VulkanDll = "vulcan-1.dll";

		[DllImport(VulkanDll)]
		public static extern Result vkCreateInstance();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyInstance();

		[DllImport(VulkanDll)]
		public static extern Result vkEnumeratePhysicalDevices();

		[DllImport(VulkanDll)]
		public static extern IntPtr vkGetDeviceProcAddr();

		[DllImport(VulkanDll)]
		public static extern IntPtr vkGetInstanceProcAddr();

		[DllImport(VulkanDll)]
		public static extern void vkGetPhysicalDeviceProperties();

		[DllImport(VulkanDll)]
		public static extern void vkGetPhysicalDeviceQueueFamilyProperties();

		[DllImport(VulkanDll)]
		public static extern void vkGetPhysicalDeviceMemoryProperties();

		[DllImport(VulkanDll)]
		public static extern void vkGetPhysicalDeviceFeatures();

		[DllImport(VulkanDll)]
		public static extern void vkGetPhysicalDeviceFormatProperties();

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceImageFormatProperties();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateDevice();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyDevice();

		[DllImport(VulkanDll)]
		public static extern Result vkEnumerateInstanceLayerProperties();

		[DllImport(VulkanDll)]
		public static extern Result vkEnumerateInstanceExtensionProperties();

		[DllImport(VulkanDll)]
		public static extern Result vkEnumerateDeviceLayerProperties();

		[DllImport(VulkanDll)]
		public static extern Result vkEnumerateDeviceExtensionProperties();

		[DllImport(VulkanDll)]
		public static extern void vkGetDeviceQueue();

		[DllImport(VulkanDll)]
		public static extern Result vkQueueSubmit();

		[DllImport(VulkanDll)]
		public static extern Result vkQueueWaitIdle();

		[DllImport(VulkanDll)]
		public static extern Result vkDeviceWaitIdle();

		[DllImport(VulkanDll)]
		public static extern Result vkAllocateMemory();

		[DllImport(VulkanDll)]
		public static extern void vkFreeMemory();

		[DllImport(VulkanDll)]
		public static extern Result vkMapMemory();

		[DllImport(VulkanDll)]
		public static extern void vkUnmapMemory();

		[DllImport(VulkanDll)]
		public static extern Result vkFlushMappedMemoryRanges();

		[DllImport(VulkanDll)]
		public static extern Result vkInvalidateMappedMemoryRanges();

		[DllImport(VulkanDll)]
		public static extern void vkGetDeviceMemoryCommitment();

		[DllImport(VulkanDll)]
		public static extern void vkGetBufferMemoryRequirements();

		[DllImport(VulkanDll)]
		public static extern Result vkBindBufferMemory();

		[DllImport(VulkanDll)]
		public static extern void vkGetImageMemoryRequirements();

		[DllImport(VulkanDll)]
		public static extern Result vkBindImageMemory();

		[DllImport(VulkanDll)]
		public static extern void vkGetImageSparseMemoryRequirements();

		[DllImport(VulkanDll)]
		public static extern void vkGetPhysicalDeviceSparseImageFormatProperties();

		[DllImport(VulkanDll)]
		public static extern Result vkQueueBindSparse();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateFence();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyFence();

		[DllImport(VulkanDll)]
		public static extern Result vkResetFences();

		[DllImport(VulkanDll)]
		public static extern Result vkGetFenceStatus();

		[DllImport(VulkanDll)]
		public static extern Result vkWaitForFences();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateSemaphore();

		[DllImport(VulkanDll)]
		public static extern void vkDestroySemaphore();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateEvent();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyEvent();

		[DllImport(VulkanDll)]
		public static extern Result vkGetEventStatus();

		[DllImport(VulkanDll)]
		public static extern Result vkSetEvent();

		[DllImport(VulkanDll)]
		public static extern Result vkResetEvent();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateQueryPool();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyQueryPool();

		[DllImport(VulkanDll)]
		public static extern Result vkGetQueryPoolResults();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateBuffer();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyBuffer();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateBufferView();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyBufferView();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateImage();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyImage();

		[DllImport(VulkanDll)]
		public static extern void vkGetImageSubresourceLayout();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateImageView();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyImageView();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateShaderModule();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyShaderModule();

		[DllImport(VulkanDll)]
		public static extern Result vkCreatePipelineCache();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyPipelineCache();

		[DllImport(VulkanDll)]
		public static extern Result vkGetPipelineCacheData();

		[DllImport(VulkanDll)]
		public static extern Result vkMergePipelineCaches();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateGraphicsPipelines();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateComputePipelines();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyPipeline();

		[DllImport(VulkanDll)]
		public static extern Result vkCreatePipelineLayout();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyPipelineLayout();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateSampler();

		[DllImport(VulkanDll)]
		public static extern void vkDestroySampler();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateDescriptorSetLayout();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyDescriptorSetLayout();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateDescriptorPool();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyDescriptorPool();

		[DllImport(VulkanDll)]
		public static extern Result vkResetDescriptorPool();

		[DllImport(VulkanDll)]
		public static extern Result vkAllocateDescriptorSets();

		[DllImport(VulkanDll)]
		public static extern Result vkFreeDescriptorSets();

		[DllImport(VulkanDll)]
		public static extern void vkUpdateDescriptorSets();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateFramebuffer();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyFramebuffer();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateRenderPass();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyRenderPass();

		[DllImport(VulkanDll)]
		public static extern void vkGetRenderAreaGranularity();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateCommandPool();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyCommandPool();

		[DllImport(VulkanDll)]
		public static extern Result vkResetCommandPool();

		[DllImport(VulkanDll)]
		public static extern Result vkAllocateCommandBuffers();

		[DllImport(VulkanDll)]
		public static extern void vkFreeCommandBuffers();

		[DllImport(VulkanDll)]
		public static extern Result vkBeginCommandBuffer();

		[DllImport(VulkanDll)]
		public static extern Result vkEndCommandBuffer();

		[DllImport(VulkanDll)]
		public static extern Result vkResetCommandBuffer();

		[DllImport(VulkanDll)]
		public static extern void vkCmdBindPipeline();

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetViewport();

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetScissor();

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetLineWidth();

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetDepthBias();

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetBlendConstants();

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetDepthBounds();

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetStencilCompareMask();

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetStencilWriteMask();

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetStencilReference();

		[DllImport(VulkanDll)]
		public static extern void vkCmdBindDescriptorSets();

		[DllImport(VulkanDll)]
		public static extern void vkCmdBindIndexBuffer();

		[DllImport(VulkanDll)]
		public static extern void vkCmdBindVertexBuffers();

		[DllImport(VulkanDll)]
		public static extern void vkCmdDraw();

		[DllImport(VulkanDll)]
		public static extern void vkCmdDrawIndexed();

		[DllImport(VulkanDll)]
		public static extern void vkCmdDrawIndirect();

		[DllImport(VulkanDll)]
		public static extern void vkCmdDrawIndexedIndirect();

		[DllImport(VulkanDll)]
		public static extern void vkCmdDispatch();

		[DllImport(VulkanDll)]
		public static extern void vkCmdDispatchIndirect();

		[DllImport(VulkanDll)]
		public static extern void vkCmdCopyBuffer();

		[DllImport(VulkanDll)]
		public static extern void vkCmdCopyImage();

		[DllImport(VulkanDll)]
		public static extern void vkCmdBlitImage();

		[DllImport(VulkanDll)]
		public static extern void vkCmdCopyBufferToImage();

		[DllImport(VulkanDll)]
		public static extern void vkCmdCopyImageToBuffer();

		[DllImport(VulkanDll)]
		public static extern void vkCmdUpdateBuffer();

		[DllImport(VulkanDll)]
		public static extern void vkCmdFillBuffer();

		[DllImport(VulkanDll)]
		public static extern void vkCmdClearColorImage();

		[DllImport(VulkanDll)]
		public static extern void vkCmdClearDepthStencilImage();

		[DllImport(VulkanDll)]
		public static extern void vkCmdClearAttachments();

		[DllImport(VulkanDll)]
		public static extern void vkCmdResolveImage();

		[DllImport(VulkanDll)]
		public static extern void vkCmdSetEvent();

		[DllImport(VulkanDll)]
		public static extern void vkCmdResetEvent();

		[DllImport(VulkanDll)]
		public static extern void vkCmdWaitEvents();

		[DllImport(VulkanDll)]
		public static extern void vkCmdPipelineBarrier();

		[DllImport(VulkanDll)]
		public static extern void vkCmdBeginQuery();

		[DllImport(VulkanDll)]
		public static extern void vkCmdEndQuery();

		[DllImport(VulkanDll)]
		public static extern void vkCmdResetQueryPool();

		[DllImport(VulkanDll)]
		public static extern void vkCmdWriteTimestamp();

		[DllImport(VulkanDll)]
		public static extern void vkCmdCopyQueryPoolResults();

		[DllImport(VulkanDll)]
		public static extern void vkCmdPushConstants();

		[DllImport(VulkanDll)]
		public static extern void vkCmdBeginRenderPass();

		[DllImport(VulkanDll)]
		public static extern void vkCmdNextSubpass();

		[DllImport(VulkanDll)]
		public static extern void vkCmdEndRenderPass();

		[DllImport(VulkanDll)]
		public static extern void vkCmdExecuteCommands();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateAndroidSurfaceKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceDisplayPropertiesKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceDisplayPlanePropertiesKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkGetDisplayPlaneSupportedDisplaysKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkGetDisplayModePropertiesKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateDisplayModeKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkGetDisplayPlaneCapabilitiesKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateDisplayPlaneSurfaceKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateSharedSwapchainsKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateMirSurfaceKHR();

		[DllImport(VulkanDll)]
		public static extern Bool32 vkGetPhysicalDeviceMirPresentationSupportKHR();

		[DllImport(VulkanDll)]
		public static extern void vkDestroySurfaceKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceSurfaceSupportKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceSurfaceCapabilitiesKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceSurfaceFormatsKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkGetPhysicalDeviceSurfacePresentModesKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateSwapchainKHR();

		[DllImport(VulkanDll)]
		public static extern void vkDestroySwapchainKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkGetSwapchainImagesKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkAcquireNextImageKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkQueuePresentKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateWaylandSurfaceKHR();

		[DllImport(VulkanDll)]
		public static extern Bool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateWin32SurfaceKHR();

		[DllImport(VulkanDll)]
		public static extern Bool32 vkGetPhysicalDeviceWin32PresentationSupportKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateXlibSurfaceKHR();

		[DllImport(VulkanDll)]
		public static extern Bool32 vkGetPhysicalDeviceXlibPresentationSupportKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateXcbSurfaceKHR();

		[DllImport(VulkanDll)]
		public static extern Bool32 vkGetPhysicalDeviceXcbPresentationSupportKHR();

		[DllImport(VulkanDll)]
		public static extern Result vkCreateDebugReportCallbackEXT();

		[DllImport(VulkanDll)]
		public static extern void vkDestroyDebugReportCallbackEXT();

		[DllImport(VulkanDll)]
		public static extern void vkDebugReportMessageEXT();

	}
}