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
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateInstance(InstanceCreateInfo* createInfo, AllocationCallbacks* allocator, Instance* instance);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyInstance(Instance instance, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkEnumeratePhysicalDevices(Instance instance, uint* physicalDeviceCount, PhysicalDevice* physicalDevices);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetPhysicalDeviceFeatures(PhysicalDevice physicalDevice, PhysicalDeviceFeatures* features);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetPhysicalDeviceFormatProperties(PhysicalDevice physicalDevice, Format format, FormatProperties* formatProperties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetPhysicalDeviceImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, ImageFormatProperties* imageFormatProperties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetPhysicalDeviceProperties(PhysicalDevice physicalDevice, PhysicalDeviceProperties* properties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetPhysicalDeviceQueueFamilyProperties(PhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, QueueFamilyProperties* queueFamilyProperties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetPhysicalDeviceMemoryProperties(PhysicalDevice physicalDevice, PhysicalDeviceMemoryProperties* memoryProperties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern IntPtr vkGetInstanceProcAddr(Instance instance, char* name);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern IntPtr vkGetDeviceProcAddr(Device device, char* name);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateDevice(PhysicalDevice physicalDevice, DeviceCreateInfo* createInfo, AllocationCallbacks* allocator, Device* device);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyDevice(Device device, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkEnumerateInstanceExtensionProperties(char* layerName, uint* propertyCount, ExtensionProperties* properties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkEnumerateDeviceExtensionProperties(PhysicalDevice physicalDevice, char* layerName, uint* propertyCount, ExtensionProperties* properties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkEnumerateInstanceLayerProperties(uint* propertyCount, LayerProperties* properties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkEnumerateDeviceLayerProperties(PhysicalDevice physicalDevice, uint* propertyCount, LayerProperties* properties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetDeviceQueue(Device device, uint queueFamilyIndex, uint queueIndex, Queue* queue);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkQueueSubmit(Queue queue, uint submitCount, SubmitInfo* submits, Fence fence);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkQueueWaitIdle(Queue queue);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkDeviceWaitIdle(Device device);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkAllocateMemory(Device device, MemoryAllocateInfo* allocateInfo, AllocationCallbacks* allocator, DeviceMemory* memory);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkFreeMemory(Device device, DeviceMemory memory, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkMapMemory(Device device, DeviceMemory memory, DeviceSize offset, DeviceSize size, MemoryMapFlags flags, void** ppData);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkUnmapMemory(Device device, DeviceMemory memory);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkFlushMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkInvalidateMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetDeviceMemoryCommitment(Device device, DeviceMemory memory, DeviceSize* committedMemoryInBytes);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkBindBufferMemory(Device device, Buffer buffer, DeviceMemory memory, DeviceSize memoryOffset);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkBindImageMemory(Device device, Image image, DeviceMemory memory, DeviceSize memoryOffset);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetBufferMemoryRequirements(Device device, Buffer buffer, MemoryRequirements* memoryRequirements);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetImageMemoryRequirements(Device device, Image image, MemoryRequirements* memoryRequirements);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetImageSparseMemoryRequirements(Device device, Image image, uint* sparseMemoryRequirementCount, SparseImageMemoryRequirements* sparseMemoryRequirements);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetPhysicalDeviceSparseImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling, uint* propertyCount, SparseImageFormatProperties* properties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkQueueBindSparse(Queue queue, uint bindInfoCount, BindSparseInfo* bindInfo, Fence fence);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateFence(Device device, FenceCreateInfo* createInfo, AllocationCallbacks* allocator, Fence* fence);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyFence(Device device, Fence fence, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkResetFences(Device device, uint fenceCount, Fence* fences);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetFenceStatus(Device device, Fence fence);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkWaitForFences(Device device, uint fenceCount, Fence* fences, Bool32 waitAll, ulong timeout);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateSemaphore(Device device, SemaphoreCreateInfo* createInfo, AllocationCallbacks* allocator, Semaphore* semaphore);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroySemaphore(Device device, Semaphore semaphore, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateEvent(Device device, EventCreateInfo* createInfo, AllocationCallbacks* allocator, Event* @event);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyEvent(Device device, Event @event, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetEventStatus(Device device, Event @event);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkSetEvent(Device device, Event @event);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkResetEvent(Device device, Event @event);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateQueryPool(Device device, QueryPoolCreateInfo* createInfo, AllocationCallbacks* allocator, QueryPool* queryPool);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyQueryPool(Device device, QueryPool queryPool, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetQueryPoolResults(Device device, QueryPool queryPool, uint firstQuery, uint queryCount, Size dataSize, void* data, DeviceSize stride, QueryResultFlags flags);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateBuffer(Device device, BufferCreateInfo* createInfo, AllocationCallbacks* allocator, Buffer* buffer);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyBuffer(Device device, Buffer buffer, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateBufferView(Device device, BufferViewCreateInfo* createInfo, AllocationCallbacks* allocator, BufferView* view);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyBufferView(Device device, BufferView bufferView, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateImage(Device device, ImageCreateInfo* createInfo, AllocationCallbacks* allocator, Image* image);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyImage(Device device, Image image, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetImageSubresourceLayout(Device device, Image image, ImageSubresource* subresource, SubresourceLayout* layout);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateImageView(Device device, ImageViewCreateInfo* createInfo, AllocationCallbacks* allocator, ImageView* view);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyImageView(Device device, ImageView imageView, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateShaderModule(Device device, ShaderModuleCreateInfo* createInfo, AllocationCallbacks* allocator, ShaderModule* shaderModule);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyShaderModule(Device device, ShaderModule shaderModule, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreatePipelineCache(Device device, PipelineCacheCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineCache* pipelineCache);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyPipelineCache(Device device, PipelineCache pipelineCache, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetPipelineCacheData(Device device, PipelineCache pipelineCache, Size* dataSize, void* data);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkMergePipelineCaches(Device device, PipelineCache destinationCache, uint sourceCacheCount, PipelineCache* sourceCaches);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateGraphicsPipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, GraphicsPipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateComputePipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, ComputePipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyPipeline(Device device, Pipeline pipeline, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreatePipelineLayout(Device device, PipelineLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineLayout* pipelineLayout);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyPipelineLayout(Device device, PipelineLayout pipelineLayout, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateSampler(Device device, SamplerCreateInfo* createInfo, AllocationCallbacks* allocator, Sampler* sampler);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroySampler(Device device, Sampler sampler, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateDescriptorSetLayout(Device device, DescriptorSetLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorSetLayout* setLayout);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyDescriptorSetLayout(Device device, DescriptorSetLayout descriptorSetLayout, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateDescriptorPool(Device device, DescriptorPoolCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorPool* descriptorPool);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyDescriptorPool(Device device, DescriptorPool descriptorPool, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkResetDescriptorPool(Device device, DescriptorPool descriptorPool, DescriptorPoolResetFlags flags);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkAllocateDescriptorSets(Device device, DescriptorSetAllocateInfo* allocateInfo, DescriptorSet* descriptorSets);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkFreeDescriptorSets(Device device, DescriptorPool descriptorPool, uint descriptorSetCount, DescriptorSet* descriptorSets);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkUpdateDescriptorSets(Device device, uint descriptorWriteCount, WriteDescriptorSet* descriptorWrites, uint descriptorCopyCount, CopyDescriptorSet* descriptorCopies);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateFramebuffer(Device device, FramebufferCreateInfo* createInfo, AllocationCallbacks* allocator, Framebuffer* framebuffer);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyFramebuffer(Device device, Framebuffer framebuffer, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateRenderPass(Device device, RenderPassCreateInfo* createInfo, AllocationCallbacks* allocator, RenderPass* renderPass);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyRenderPass(Device device, RenderPass renderPass, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkGetRenderAreaGranularity(Device device, RenderPass renderPass, Extent2D* granularity);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateCommandPool(Device device, CommandPoolCreateInfo* createInfo, AllocationCallbacks* allocator, CommandPool* commandPool);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyCommandPool(Device device, CommandPool commandPool, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkResetCommandPool(Device device, CommandPool commandPool, CommandPoolResetFlags flags);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkAllocateCommandBuffers(Device device, CommandBufferAllocateInfo* allocateInfo, CommandBuffer* commandBuffers);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkFreeCommandBuffers(Device device, CommandPool commandPool, uint commandBufferCount, CommandBuffer* commandBuffers);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkBeginCommandBuffer(CommandBuffer commandBuffer, CommandBufferBeginInfo* beginInfo);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkEndCommandBuffer(CommandBuffer commandBuffer);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkResetCommandBuffer(CommandBuffer commandBuffer, CommandBufferResetFlags flags);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdBindPipeline(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, Pipeline pipeline);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdSetViewport(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, Viewport* viewports);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdSetScissor(CommandBuffer commandBuffer, uint firstScissor, uint scissorCount, Rect2D* scissors);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdSetLineWidth(CommandBuffer commandBuffer, float lineWidth);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdSetDepthBias(CommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdSetBlendConstants(CommandBuffer commandBuffer, float blendConstants);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdSetDepthBounds(CommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdSetStencilCompareMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint compareMask);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdSetStencilWriteMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint writeMask);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdSetStencilReference(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint reference);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdBindDescriptorSets(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, uint descriptorSetCount, DescriptorSet* descriptorSets, uint dynamicOffsetCount, uint* dynamicOffsets);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdBindIndexBuffer(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, IndexType indexType);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdBindVertexBuffers(CommandBuffer commandBuffer, uint firstBinding, uint bindingCount, Buffer* buffers, DeviceSize* offsets);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdDraw(CommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdDrawIndexed(CommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdDrawIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdDrawIndexedIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdDispatch(CommandBuffer commandBuffer, uint x, uint y, uint z);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdDispatchIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdCopyBuffer(CommandBuffer commandBuffer, Buffer sourceBuffer, Buffer destinationBuffer, uint regionCount, BufferCopy* regions);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdCopyImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageCopy* regions);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdBlitImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageBlit* regions, Filter filter);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdCopyBufferToImage(CommandBuffer commandBuffer, Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, BufferImageCopy* regions);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdCopyImageToBuffer(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, uint regionCount, BufferImageCopy* regions);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdUpdateBuffer(CommandBuffer commandBuffer, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize dataSize, void* data);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdFillBuffer(CommandBuffer commandBuffer, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize size, uint data);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdClearColorImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearColorValue* color, uint rangeCount, ImageSubresourceRange* ranges);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdClearDepthStencilImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearDepthStencilValue* depthStencil, uint rangeCount, ImageSubresourceRange* ranges);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdClearAttachments(CommandBuffer commandBuffer, uint attachmentCount, ClearAttachment* attachments, uint rectCount, ClearRect* rects);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdResolveImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageResolve* regions);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdSetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdResetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdWaitEvents(CommandBuffer commandBuffer, uint eventCount, Event* events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdPipelineBarrier(CommandBuffer commandBuffer, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdBeginQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query, QueryControlFlags flags);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdEndQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdResetQueryPool(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdWriteTimestamp(CommandBuffer commandBuffer, PipelineStageFlags pipelineStage, QueryPool queryPool, uint query);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdCopyQueryPoolResults(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize stride, QueryResultFlags flags);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdPushConstants(CommandBuffer commandBuffer, PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, uint size, void* values);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdBeginRenderPass(CommandBuffer commandBuffer, RenderPassBeginInfo* renderPassBegin, SubpassContents contents);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdNextSubpass(CommandBuffer commandBuffer, SubpassContents contents);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdEndRenderPass(CommandBuffer commandBuffer);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdExecuteCommands(CommandBuffer commandBuffer, uint commandBufferCount, CommandBuffer* commandBuffers);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroySurfaceKHR(Instance instance, Surface surface, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetPhysicalDeviceSurfaceSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, Surface surface, Bool32* supported);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetPhysicalDeviceSurfaceCapabilitiesKHR(PhysicalDevice physicalDevice, Surface surface, SurfaceCapabilities* surfaceCapabilities);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetPhysicalDeviceSurfaceFormatsKHR(PhysicalDevice physicalDevice, Surface surface, uint* surfaceFormatCount, SurfaceFormat* surfaceFormats);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetPhysicalDeviceSurfacePresentModesKHR(PhysicalDevice physicalDevice, Surface surface, uint* presentModeCount, PresentMode* presentModes);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateSwapchainKHR(Device device, SwapchainCreateInfo* createInfo, AllocationCallbacks* allocator, Swapchain* swapchain);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroySwapchainKHR(Device device, Swapchain swapchain, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetSwapchainImagesKHR(Device device, Swapchain swapchain, uint* swapchainImageCount, Image* swapchainImages);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkAcquireNextImageKHR(Device device, Swapchain swapchain, ulong timeout, Semaphore semaphore, Fence fence, uint* imageIndex);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkQueuePresentKHR(Queue queue, PresentInfo* presentInfo);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetPhysicalDeviceDisplayPropertiesKHR(PhysicalDevice physicalDevice, uint* propertyCount, DisplayProperties* properties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetPhysicalDeviceDisplayPlanePropertiesKHR(PhysicalDevice physicalDevice, uint* propertyCount, DisplayPlaneProperties* properties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetDisplayPlaneSupportedDisplaysKHR(PhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, Display* displays);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetDisplayModePropertiesKHR(PhysicalDevice physicalDevice, Display display, uint* propertyCount, DisplayModeProperties* properties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateDisplayModeKHR(PhysicalDevice physicalDevice, Display display, DisplayModeCreateInfo* createInfo, AllocationCallbacks* allocator, DisplayMode* mode);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetDisplayPlaneCapabilitiesKHR(PhysicalDevice physicalDevice, DisplayMode mode, uint planeIndex, DisplayPlaneCapabilities* capabilities);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateDisplayPlaneSurfaceKHR(Instance instance, DisplaySurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateSharedSwapchainsKHR(Device device, uint swapchainCount, SwapchainCreateInfo* createInfos, AllocationCallbacks* allocator, Swapchain* swapchains);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateXlibSurfaceKHR(Instance instance, XlibSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Bool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* dpy, IntPtr visualID);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateXcbSurfaceKHR(Instance instance, XcbSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Bool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* connection, IntPtr visual_id);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateWaylandSurfaceKHR(Instance instance, WaylandSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Bool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateMirSurfaceKHR(Instance instance, MirSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Bool32 vkGetPhysicalDeviceMirPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* connection);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateAndroidSurfaceKHR(Instance instance, AndroidSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateWin32SurfaceKHR(Instance instance, Win32SurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Bool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkCreateDebugReportCallbackEXT(Instance instance, DebugReportCallbackCreateInfo* createInfo, AllocationCallbacks* allocator, DebugReportCallback* callback);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDestroyDebugReportCallbackEXT(Instance instance, DebugReportCallback callback, AllocationCallbacks* allocator);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkDebugReportMessageEXT(Instance instance, DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, Size location, int messageCode, char* layerPrefix, char* message);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkDebugMarkerSetObjectTagEXT(Device device, DebugMarkerObjectTagInfo* tagInfo);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkDebugMarkerSetObjectNameEXT(Device device, DebugMarkerObjectNameInfo* nameInfo);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdDebugMarkerBeginEXT(CommandBuffer commandBuffer, DebugMarkerMarkerInfo* markerInfo);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdDebugMarkerEndEXT(CommandBuffer commandBuffer);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdDebugMarkerInsertEXT(CommandBuffer commandBuffer, DebugMarkerMarkerInfo* markerInfo);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdDrawIndirectCountAMD(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern void vkCmdDrawIndexedIndirectCountAMD(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetPhysicalDeviceExternalImageFormatPropertiesNV(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, ExternalMemoryHandleTypeFlags externalHandleType, ExternalImageFormatProperties* externalImageFormatProperties);
		
		/// <summary>
		/// DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)
		/// </summary>
		public static extern Result vkGetMemoryWin32HandleNV(Device device, DeviceMemory memory, ExternalMemoryHandleTypeFlags handleType, IntPtr* handle);
	}
}
