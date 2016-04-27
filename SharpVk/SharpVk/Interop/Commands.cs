//The MIT License (MIT)
//
//Copyright (c) 2016 Andrew Armstrong/FacticiusVir
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System;
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
	public static unsafe class Commands
	{
		public const string VulkanDll = "vulkan-1.dll";

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateInstance(InstanceCreateInfo* createInfo, AllocationCallbacks* allocator, Instance* instance);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyInstance(Instance instance, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkEnumeratePhysicalDevices(Instance instance, uint* physicalDeviceCount, PhysicalDevice* physicalDevices);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetPhysicalDeviceFeatures(PhysicalDevice physicalDevice, PhysicalDeviceFeatures* features);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetPhysicalDeviceFormatProperties(PhysicalDevice physicalDevice, Format format, FormatProperties* formatProperties);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkGetPhysicalDeviceImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, ImageFormatProperties* imageFormatProperties);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetPhysicalDeviceProperties(PhysicalDevice physicalDevice, PhysicalDeviceProperties* properties);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetPhysicalDeviceQueueFamilyProperties(PhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, QueueFamilyProperties* queueFamilyProperties);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetPhysicalDeviceMemoryProperties(PhysicalDevice physicalDevice, PhysicalDeviceMemoryProperties* memoryProperties);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern IntPtr vkGetInstanceProcAddr(Instance instance, char* name);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern IntPtr vkGetDeviceProcAddr(Device device, char* name);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateDevice(PhysicalDevice physicalDevice, DeviceCreateInfo* createInfo, AllocationCallbacks* allocator, Device* device);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyDevice(Device device, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkEnumerateInstanceExtensionProperties(char* layerName, uint* propertyCount, ExtensionProperties* properties);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkEnumerateDeviceExtensionProperties(PhysicalDevice physicalDevice, char* layerName, uint* propertyCount, ExtensionProperties* properties);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkEnumerateInstanceLayerProperties(uint* propertyCount, LayerProperties* properties);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkEnumerateDeviceLayerProperties(PhysicalDevice physicalDevice, uint* propertyCount, LayerProperties* properties);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetDeviceQueue(Device device, uint queueFamilyIndex, uint queueIndex, Queue* queue);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkQueueSubmit(Queue queue, uint submitCount, SubmitInfo* submits, Fence fence);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkQueueWaitIdle(Queue queue);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkDeviceWaitIdle(Device device);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkAllocateMemory(Device device, MemoryAllocateInfo* allocateInfo, AllocationCallbacks* allocator, DeviceMemory* memory);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkFreeMemory(Device device, DeviceMemory memory, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkMapMemory(Device device, DeviceMemory memory, DeviceSize offset, DeviceSize size, MemoryMapFlags flags, void** data);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkUnmapMemory(Device device, DeviceMemory memory);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkFlushMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkInvalidateMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetDeviceMemoryCommitment(Device device, DeviceMemory memory, DeviceSize* committedMemoryInBytes);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkBindBufferMemory(Device device, Buffer buffer, DeviceMemory memory, DeviceSize memoryOffset);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkBindImageMemory(Device device, Image image, DeviceMemory memory, DeviceSize memoryOffset);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetBufferMemoryRequirements(Device device, Buffer buffer, MemoryRequirements* memoryRequirements);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetImageMemoryRequirements(Device device, Image image, MemoryRequirements* memoryRequirements);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetImageSparseMemoryRequirements(Device device, Image image, uint* sparseMemoryRequirementCount, SparseImageMemoryRequirements* sparseMemoryRequirements);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetPhysicalDeviceSparseImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling, uint* propertyCount, SparseImageFormatProperties* properties);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkQueueBindSparse(Queue queue, uint bindInfoCount, BindSparseInfo* bindInfo, Fence fence);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateFence(Device device, FenceCreateInfo* createInfo, AllocationCallbacks* allocator, Fence* fence);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyFence(Device device, Fence fence, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkResetFences(Device device, uint fenceCount, Fence* fences);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkGetFenceStatus(Device device, Fence fence);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkWaitForFences(Device device, uint fenceCount, Fence* fences, Bool32 waitAll, ulong timeout);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateSemaphore(Device device, SemaphoreCreateInfo* createInfo, AllocationCallbacks* allocator, Semaphore* semaphore);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroySemaphore(Device device, Semaphore semaphore, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateEvent(Device device, EventCreateInfo* createInfo, AllocationCallbacks* allocator, Event* @event);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyEvent(Device device, Event @event, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkGetEventStatus(Device device, Event @event);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkSetEvent(Device device, Event @event);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkResetEvent(Device device, Event @event);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateQueryPool(Device device, QueryPoolCreateInfo* createInfo, AllocationCallbacks* allocator, QueryPool* queryPool);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyQueryPool(Device device, QueryPool queryPool, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkGetQueryPoolResults(Device device, QueryPool queryPool, uint firstQuery, uint queryCount, UIntPtr dataSize, void* data, DeviceSize stride, QueryResultFlags flags);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateBuffer(Device device, BufferCreateInfo* createInfo, AllocationCallbacks* allocator, Buffer* buffer);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyBuffer(Device device, Buffer buffer, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateBufferView(Device device, BufferViewCreateInfo* createInfo, AllocationCallbacks* allocator, BufferView* view);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyBufferView(Device device, BufferView bufferView, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateImage(Device device, ImageCreateInfo* createInfo, AllocationCallbacks* allocator, Image* image);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyImage(Device device, Image image, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetImageSubresourceLayout(Device device, Image image, ImageSubresource* subresource, SubresourceLayout* layout);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateImageView(Device device, ImageViewCreateInfo* createInfo, AllocationCallbacks* allocator, ImageView* view);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyImageView(Device device, ImageView imageView, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateShaderModule(Device device, ShaderModuleCreateInfo* createInfo, AllocationCallbacks* allocator, ShaderModule* shaderModule);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyShaderModule(Device device, ShaderModule shaderModule, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreatePipelineCache(Device device, PipelineCacheCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineCache* pipelineCache);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyPipelineCache(Device device, PipelineCache pipelineCache, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkGetPipelineCacheData(Device device, PipelineCache pipelineCache, UIntPtr* dataSize, void* data);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkMergePipelineCaches(Device device, PipelineCache destinationCache, uint sourceCacheCount, PipelineCache* sourceCaches);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateGraphicsPipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, GraphicsPipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateComputePipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, ComputePipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyPipeline(Device device, Pipeline pipeline, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreatePipelineLayout(Device device, PipelineLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineLayout* pipelineLayout);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyPipelineLayout(Device device, PipelineLayout pipelineLayout, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateSampler(Device device, SamplerCreateInfo* createInfo, AllocationCallbacks* allocator, Sampler* sampler);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroySampler(Device device, Sampler sampler, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateDescriptorSetLayout(Device device, DescriptorSetLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorSetLayout* setLayout);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyDescriptorSetLayout(Device device, DescriptorSetLayout descriptorSetLayout, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateDescriptorPool(Device device, DescriptorPoolCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorPool* descriptorPool);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyDescriptorPool(Device device, DescriptorPool descriptorPool, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkResetDescriptorPool(Device device, DescriptorPool descriptorPool, DescriptorPoolResetFlags flags);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkAllocateDescriptorSets(Device device, DescriptorSetAllocateInfo* allocateInfo, DescriptorSet* descriptorSets);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkFreeDescriptorSets(Device device, DescriptorPool descriptorPool, uint descriptorSetCount, DescriptorSet* descriptorSets);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkUpdateDescriptorSets(Device device, uint descriptorWriteCount, WriteDescriptorSet* descriptorWrites, uint descriptorCopyCount, CopyDescriptorSet* descriptorCopies);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateFramebuffer(Device device, FramebufferCreateInfo* createInfo, AllocationCallbacks* allocator, Framebuffer* framebuffer);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyFramebuffer(Device device, Framebuffer framebuffer, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateRenderPass(Device device, RenderPassCreateInfo* createInfo, AllocationCallbacks* allocator, RenderPass* renderPass);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyRenderPass(Device device, RenderPass renderPass, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkGetRenderAreaGranularity(Device device, RenderPass renderPass, Extent2D* granularity);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkCreateCommandPool(Device device, CommandPoolCreateInfo* createInfo, AllocationCallbacks* allocator, CommandPool* commandPool);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkDestroyCommandPool(Device device, CommandPool commandPool, AllocationCallbacks* allocator);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkResetCommandPool(Device device, CommandPool commandPool, CommandPoolResetFlags flags);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkAllocateCommandBuffers(Device device, CommandBufferAllocateInfo* allocateInfo, CommandBuffer* commandBuffers);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkFreeCommandBuffers(Device device, CommandPool commandPool, uint commandBufferCount, CommandBuffer* commandBuffers);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkBeginCommandBuffer(CommandBuffer commandBuffer, CommandBufferBeginInfo* beginInfo);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkEndCommandBuffer(CommandBuffer commandBuffer);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern Result vkResetCommandBuffer(CommandBuffer commandBuffer, CommandBufferResetFlags flags);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdBindPipeline(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, Pipeline pipeline);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdSetViewport(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, Viewport* viewports);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdSetScissor(CommandBuffer commandBuffer, uint firstScissor, uint scissorCount, Rect2D* scissors);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdSetLineWidth(CommandBuffer commandBuffer, float lineWidth);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdSetDepthBias(CommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdSetBlendConstants(CommandBuffer commandBuffer, float blendConstants);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdSetDepthBounds(CommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdSetStencilCompareMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint compareMask);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdSetStencilWriteMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint writeMask);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdSetStencilReference(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint reference);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdBindDescriptorSets(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, uint descriptorSetCount, DescriptorSet* descriptorSets, uint dynamicOffsetCount, uint* dynamicOffsets);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdBindIndexBuffer(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, IndexType indexType);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdBindVertexBuffers(CommandBuffer commandBuffer, uint firstBinding, uint bindingCount, Buffer* buffers, DeviceSize* offsets);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdDraw(CommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdDrawIndexed(CommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdDrawIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdDrawIndexedIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdDispatch(CommandBuffer commandBuffer, uint x, uint y, uint z);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdDispatchIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdCopyBuffer(CommandBuffer commandBuffer, Buffer sourceBuffer, Buffer destinationBuffer, uint regionCount, BufferCopy* regions);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdCopyImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageCopy* regions);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdBlitImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageBlit* regions, Filter filter);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdCopyBufferToImage(CommandBuffer commandBuffer, Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, BufferImageCopy* regions);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdCopyImageToBuffer(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, uint regionCount, BufferImageCopy* regions);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdUpdateBuffer(CommandBuffer commandBuffer, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize dataSize, uint* data);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdFillBuffer(CommandBuffer commandBuffer, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize size, uint data);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdClearColorImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearColorValue* color, uint rangeCount, ImageSubresourceRange* ranges);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdClearDepthStencilImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearDepthStencilValue* depthStencil, uint rangeCount, ImageSubresourceRange* ranges);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdClearAttachments(CommandBuffer commandBuffer, uint attachmentCount, ClearAttachment* attachments, uint rectCount, ClearRect* rects);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdResolveImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageResolve* regions);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdSetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdResetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdWaitEvents(CommandBuffer commandBuffer, uint eventCount, Event* events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdPipelineBarrier(CommandBuffer commandBuffer, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdBeginQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query, QueryControlFlags flags);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdEndQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdResetQueryPool(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdWriteTimestamp(CommandBuffer commandBuffer, PipelineStageFlags pipelineStage, QueryPool queryPool, uint query);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdCopyQueryPoolResults(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize stride, QueryResultFlags flags);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdPushConstants(CommandBuffer commandBuffer, PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, uint size, void* values);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdBeginRenderPass(CommandBuffer commandBuffer, RenderPassBeginInfo* renderPassBegin, SubpassContents contents);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdNextSubpass(CommandBuffer commandBuffer, SubpassContents contents);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdEndRenderPass(CommandBuffer commandBuffer);

		[DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
		public static extern void vkCmdExecuteCommands(CommandBuffer commandBuffer, uint commandBufferCount, CommandBuffer* commandBuffers);

	}
}