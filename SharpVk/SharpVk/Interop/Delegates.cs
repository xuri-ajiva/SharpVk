//The MIT License (MIT)
//
//Copyright (c) Andrew Armstrong/FacticiusVir 2016
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

namespace SharpVk.Interop
{
    /// <summary>
    /// <para>
    /// Application-defined memory allocation function.
    /// </para>
    /// <para>
    /// [[vkAllocationFunction_return_rules]] If pname:pfnAllocation is unable to allocate the requested memory, it must: return `NULL`. If the allocation was successful, it must: return a valid pointer to memory allocation containing at least pname:size bytes, and with the pointer value being a multiple of pname:alignment.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Correct Vulkan operation cannot: be assumed if the application does not follow these rules.
    /// </para>
    /// <para>
    /// For example, pname:pfnAllocation (or pname:pfnReallocation) could cause termination of running Vulkan instance(s) on a failed allocation for debugging purposes, either directly or indirectly. In these circumstances, it cannot: be assumed that any part of any affected VkInstance objects are going to operate correctly (even flink:vkDestroyInstance), and the application must: ensure it cleans up properly via other means (e.g. process termination). ====
    /// </para>
    /// <para>
    /// If pname:pfnAllocation returns `NULL`, and if the implementation is unable to continue correct processing of the current command without the requested allocation, it must: treat this as a run-time error, and generate ename:VK_ERROR_OUT_OF_HOST_MEMORY at the appropriate time for the command in which the condition was detected, as described in &lt;&lt;fundamentals-errorcodes, Return Codes&gt;&gt;.
    /// </para>
    /// <para>
    /// If the implementation is able to continue correct processing of the current command without the requested allocation, then it may: do so, and must: not generate ename:VK_ERROR_OUT_OF_HOST_MEMORY as a result of this failed allocation.
    /// </para>
    /// </summary>
	public unsafe delegate IntPtr AllocationFunctionDelegate(IntPtr userData, Size size, Size alignment, SystemAllocationScope allocationScope);
    /// <summary>
    /// <para>
    /// Application-defined debug report callback function.
    /// </para>
    /// <para>
    /// The callback returns a basetype:VkBool32 that indicates to the calling layer if the Vulkan call should: be aborted or not. Applications should: always return ename:VK_FALSE so that they see the same behavior with and without validation layers enabled.
    /// </para>
    /// <para>
    /// If the application returns ename:VK_TRUE from its callback and the Vulkan call being aborted returns a elink:VkResult, the layer will return ename:VK_ERROR_VALIDATION_FAILED_EXT.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== The primary expected use of ename:VK_ERROR_VALIDATION_FAILED_EXT is for validation layer testing. It is not expected that an application would see this error code during normal use of the validation layers. ====
    /// </para>
    /// </summary>
	public unsafe delegate Bool32 DebugReportCallbackDelegate(DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, Size location, int messageCode, string layerPrefix, string message, IntPtr userData);
    /// <summary>
    /// <para>
    /// Application-defined memory free function.
    /// </para>
    /// <para>
    /// pname:pMemory may: be `NULL`, which the callback must: handle safely. If pname:pMemory is non-`NULL`, it must: be a pointer previously allocated by pname:pfnAllocation or pname:pfnReallocation. The application should: free this memory.
    /// </para>
    /// </summary>
	public unsafe delegate void FreeFunctionDelegate(IntPtr userData, IntPtr memory);
    /// <summary>
    /// <para>
    /// Application-defined memory allocation notification function.
    /// </para>
    /// <para>
    /// This is a purely informational callback.
    /// </para>
    /// </summary>
	public unsafe delegate void InternalAllocationNotificationDelegate(IntPtr userData, Size size, InternalAllocationType allocationType, SystemAllocationScope allocationScope);
    /// <summary>
    /// <para>
    /// Application-defined memory free notification function.
    /// </para>
    /// </summary>
	public unsafe delegate void InternalFreeNotificationDelegate(IntPtr userData, Size size, InternalAllocationType allocationType, SystemAllocationScope allocationScope);
    /// <summary>
    /// <para>
    /// Application-defined memory reallocation function.
    /// </para>
    /// <para>
    /// pname:pfnReallocation must: return an allocation with enough space for pname:size bytes, and the contents of the original allocation from bytes zero to latexmath:[$\min(\textrm{original size, new size})-1$] must: be preserved in the returned allocation. If pname:size is larger than the old size, the contents of the additional space are undefined. If satisfying these requirements involves creating a new allocation, then the old allocation should: be freed.
    /// </para>
    /// <para>
    /// If pname:pOriginal is `NULL`, then pname:pfnReallocation must: behave equivalently to a call to tlink:PFN_vkAllocationFunction with the same parameter values (without pname:pOriginal).
    /// </para>
    /// <para>
    /// If pname:size is zero, then pname:pfnReallocation must: behave equivalently to a call to tlink:PFN_vkFreeFunction with the same pname:pUserData parameter value, and pname:pMemory equal to pname:pOriginal.
    /// </para>
    /// <para>
    /// If pname:pOriginal is non-`NULL`, the implementation must: ensure that pname:alignment is equal to the pname:alignment used to originally allocate pname:pOriginal.
    /// </para>
    /// <para>
    /// If this function fails and pname:pOriginal is non-`NULL` the application must: not free the old allocation.
    /// </para>
    /// <para>
    /// pname:pfnReallocation must: follow the same &lt;&lt;vkAllocationFunction_return_rules, rules for return values as tname:PFN_vkAllocationFunction&gt;&gt;.
    /// </para>
    /// </summary>
	public unsafe delegate IntPtr ReallocationFunctionDelegate(IntPtr userData, IntPtr original, Size size, Size alignment, SystemAllocationScope allocationScope);
    /// <summary>
    /// <para>
    /// Dummy function pointer type returned by queries.
    /// </para>
    /// </summary>
	public unsafe delegate void VoidFunctionDelegate();
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateInstance(InstanceCreateInfo* createInfo, AllocationCallbacks* allocator, Instance* instance);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyInstance(Instance instance, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkEnumeratePhysicalDevices(Instance instance, uint* physicalDeviceCount, PhysicalDevice* physicalDevices);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetPhysicalDeviceFeatures(PhysicalDevice physicalDevice, PhysicalDeviceFeatures* features);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetPhysicalDeviceFormatProperties(PhysicalDevice physicalDevice, Format format, FormatProperties* formatProperties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetPhysicalDeviceImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, ImageFormatProperties* imageFormatProperties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetPhysicalDeviceProperties(PhysicalDevice physicalDevice, PhysicalDeviceProperties* properties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetPhysicalDeviceQueueFamilyProperties(PhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, QueueFamilyProperties* queueFamilyProperties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetPhysicalDeviceMemoryProperties(PhysicalDevice physicalDevice, PhysicalDeviceMemoryProperties* memoryProperties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate IntPtr vkGetInstanceProcAddr(Instance instance, char* name);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate IntPtr vkGetDeviceProcAddr(Device device, char* name);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateDevice(PhysicalDevice physicalDevice, DeviceCreateInfo* createInfo, AllocationCallbacks* allocator, Device* device);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyDevice(Device device, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkEnumerateInstanceExtensionProperties(char* layerName, uint* propertyCount, ExtensionProperties* properties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkEnumerateDeviceExtensionProperties(PhysicalDevice physicalDevice, char* layerName, uint* propertyCount, ExtensionProperties* properties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkEnumerateInstanceLayerProperties(uint* propertyCount, LayerProperties* properties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkEnumerateDeviceLayerProperties(PhysicalDevice physicalDevice, uint* propertyCount, LayerProperties* properties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetDeviceQueue(Device device, uint queueFamilyIndex, uint queueIndex, Queue* queue);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkQueueSubmit(Queue queue, uint submitCount, SubmitInfo* submits, Fence fence);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkQueueWaitIdle(Queue queue);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkDeviceWaitIdle(Device device);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkAllocateMemory(Device device, MemoryAllocateInfo* allocateInfo, AllocationCallbacks* allocator, DeviceMemory* memory);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkFreeMemory(Device device, DeviceMemory memory, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkMapMemory(Device device, DeviceMemory memory, DeviceSize offset, DeviceSize size, MemoryMapFlags flags, void** ppData);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkUnmapMemory(Device device, DeviceMemory memory);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkFlushMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkInvalidateMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetDeviceMemoryCommitment(Device device, DeviceMemory memory, DeviceSize* committedMemoryInBytes);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkBindBufferMemory(Device device, Buffer buffer, DeviceMemory memory, DeviceSize memoryOffset);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkBindImageMemory(Device device, Image image, DeviceMemory memory, DeviceSize memoryOffset);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetBufferMemoryRequirements(Device device, Buffer buffer, MemoryRequirements* memoryRequirements);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetImageMemoryRequirements(Device device, Image image, MemoryRequirements* memoryRequirements);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetImageSparseMemoryRequirements(Device device, Image image, uint* sparseMemoryRequirementCount, SparseImageMemoryRequirements* sparseMemoryRequirements);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetPhysicalDeviceSparseImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling, uint* propertyCount, SparseImageFormatProperties* properties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkQueueBindSparse(Queue queue, uint bindInfoCount, BindSparseInfo* bindInfo, Fence fence);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateFence(Device device, FenceCreateInfo* createInfo, AllocationCallbacks* allocator, Fence* fence);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyFence(Device device, Fence fence, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkResetFences(Device device, uint fenceCount, Fence* fences);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetFenceStatus(Device device, Fence fence);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkWaitForFences(Device device, uint fenceCount, Fence* fences, Bool32 waitAll, ulong timeout);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateSemaphore(Device device, SemaphoreCreateInfo* createInfo, AllocationCallbacks* allocator, Semaphore* semaphore);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroySemaphore(Device device, Semaphore semaphore, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateEvent(Device device, EventCreateInfo* createInfo, AllocationCallbacks* allocator, Event* @event);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyEvent(Device device, Event @event, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetEventStatus(Device device, Event @event);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkSetEvent(Device device, Event @event);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkResetEvent(Device device, Event @event);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateQueryPool(Device device, QueryPoolCreateInfo* createInfo, AllocationCallbacks* allocator, QueryPool* queryPool);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyQueryPool(Device device, QueryPool queryPool, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetQueryPoolResults(Device device, QueryPool queryPool, uint firstQuery, uint queryCount, Size dataSize, void* data, DeviceSize stride, QueryResultFlags flags);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateBuffer(Device device, BufferCreateInfo* createInfo, AllocationCallbacks* allocator, Buffer* buffer);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyBuffer(Device device, Buffer buffer, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateBufferView(Device device, BufferViewCreateInfo* createInfo, AllocationCallbacks* allocator, BufferView* view);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyBufferView(Device device, BufferView bufferView, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateImage(Device device, ImageCreateInfo* createInfo, AllocationCallbacks* allocator, Image* image);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyImage(Device device, Image image, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetImageSubresourceLayout(Device device, Image image, ImageSubresource* subresource, SubresourceLayout* layout);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateImageView(Device device, ImageViewCreateInfo* createInfo, AllocationCallbacks* allocator, ImageView* view);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyImageView(Device device, ImageView imageView, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateShaderModule(Device device, ShaderModuleCreateInfo* createInfo, AllocationCallbacks* allocator, ShaderModule* shaderModule);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyShaderModule(Device device, ShaderModule shaderModule, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreatePipelineCache(Device device, PipelineCacheCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineCache* pipelineCache);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyPipelineCache(Device device, PipelineCache pipelineCache, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetPipelineCacheData(Device device, PipelineCache pipelineCache, Size* dataSize, void* data);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkMergePipelineCaches(Device device, PipelineCache destinationCache, uint sourceCacheCount, PipelineCache* sourceCaches);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateGraphicsPipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, GraphicsPipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateComputePipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, ComputePipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyPipeline(Device device, Pipeline pipeline, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreatePipelineLayout(Device device, PipelineLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineLayout* pipelineLayout);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyPipelineLayout(Device device, PipelineLayout pipelineLayout, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateSampler(Device device, SamplerCreateInfo* createInfo, AllocationCallbacks* allocator, Sampler* sampler);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroySampler(Device device, Sampler sampler, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateDescriptorSetLayout(Device device, DescriptorSetLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorSetLayout* setLayout);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyDescriptorSetLayout(Device device, DescriptorSetLayout descriptorSetLayout, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateDescriptorPool(Device device, DescriptorPoolCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorPool* descriptorPool);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyDescriptorPool(Device device, DescriptorPool descriptorPool, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkResetDescriptorPool(Device device, DescriptorPool descriptorPool, DescriptorPoolResetFlags flags);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkAllocateDescriptorSets(Device device, DescriptorSetAllocateInfo* allocateInfo, DescriptorSet* descriptorSets);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkFreeDescriptorSets(Device device, DescriptorPool descriptorPool, uint descriptorSetCount, DescriptorSet* descriptorSets);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkUpdateDescriptorSets(Device device, uint descriptorWriteCount, WriteDescriptorSet* descriptorWrites, uint descriptorCopyCount, CopyDescriptorSet* descriptorCopies);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateFramebuffer(Device device, FramebufferCreateInfo* createInfo, AllocationCallbacks* allocator, Framebuffer* framebuffer);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyFramebuffer(Device device, Framebuffer framebuffer, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateRenderPass(Device device, RenderPassCreateInfo* createInfo, AllocationCallbacks* allocator, RenderPass* renderPass);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyRenderPass(Device device, RenderPass renderPass, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkGetRenderAreaGranularity(Device device, RenderPass renderPass, Extent2D* granularity);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateCommandPool(Device device, CommandPoolCreateInfo* createInfo, AllocationCallbacks* allocator, CommandPool* commandPool);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyCommandPool(Device device, CommandPool commandPool, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkResetCommandPool(Device device, CommandPool commandPool, CommandPoolResetFlags flags);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkAllocateCommandBuffers(Device device, CommandBufferAllocateInfo* allocateInfo, CommandBuffer* commandBuffers);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkFreeCommandBuffers(Device device, CommandPool commandPool, uint commandBufferCount, CommandBuffer* commandBuffers);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkBeginCommandBuffer(CommandBuffer commandBuffer, CommandBufferBeginInfo* beginInfo);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkEndCommandBuffer(CommandBuffer commandBuffer);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkResetCommandBuffer(CommandBuffer commandBuffer, CommandBufferResetFlags flags);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdBindPipeline(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, Pipeline pipeline);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdSetViewport(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, Viewport* viewports);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdSetScissor(CommandBuffer commandBuffer, uint firstScissor, uint scissorCount, Rect2D* scissors);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdSetLineWidth(CommandBuffer commandBuffer, float lineWidth);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdSetDepthBias(CommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdSetBlendConstants(CommandBuffer commandBuffer, float blendConstants);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdSetDepthBounds(CommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdSetStencilCompareMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint compareMask);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdSetStencilWriteMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint writeMask);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdSetStencilReference(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint reference);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdBindDescriptorSets(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, uint descriptorSetCount, DescriptorSet* descriptorSets, uint dynamicOffsetCount, uint* dynamicOffsets);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdBindIndexBuffer(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, IndexType indexType);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdBindVertexBuffers(CommandBuffer commandBuffer, uint firstBinding, uint bindingCount, Buffer* buffers, DeviceSize* offsets);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdDraw(CommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdDrawIndexed(CommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdDrawIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdDrawIndexedIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdDispatch(CommandBuffer commandBuffer, uint x, uint y, uint z);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdDispatchIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdCopyBuffer(CommandBuffer commandBuffer, Buffer sourceBuffer, Buffer destinationBuffer, uint regionCount, BufferCopy* regions);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdCopyImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageCopy* regions);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdBlitImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageBlit* regions, Filter filter);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdCopyBufferToImage(CommandBuffer commandBuffer, Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, BufferImageCopy* regions);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdCopyImageToBuffer(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, uint regionCount, BufferImageCopy* regions);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdUpdateBuffer(CommandBuffer commandBuffer, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize dataSize, void* data);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdFillBuffer(CommandBuffer commandBuffer, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize size, uint data);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdClearColorImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearColorValue* color, uint rangeCount, ImageSubresourceRange* ranges);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdClearDepthStencilImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearDepthStencilValue* depthStencil, uint rangeCount, ImageSubresourceRange* ranges);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdClearAttachments(CommandBuffer commandBuffer, uint attachmentCount, ClearAttachment* attachments, uint rectCount, ClearRect* rects);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdResolveImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageResolve* regions);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdSetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdResetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdWaitEvents(CommandBuffer commandBuffer, uint eventCount, Event* events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdPipelineBarrier(CommandBuffer commandBuffer, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdBeginQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query, QueryControlFlags flags);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdEndQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdResetQueryPool(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdWriteTimestamp(CommandBuffer commandBuffer, PipelineStageFlags pipelineStage, QueryPool queryPool, uint query);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdCopyQueryPoolResults(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize stride, QueryResultFlags flags);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdPushConstants(CommandBuffer commandBuffer, PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, uint size, void* values);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdBeginRenderPass(CommandBuffer commandBuffer, RenderPassBeginInfo* renderPassBegin, SubpassContents contents);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdNextSubpass(CommandBuffer commandBuffer, SubpassContents contents);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdEndRenderPass(CommandBuffer commandBuffer);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdExecuteCommands(CommandBuffer commandBuffer, uint commandBufferCount, CommandBuffer* commandBuffers);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroySurfaceKHR(Instance instance, Surface surface, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetPhysicalDeviceSurfaceSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, Surface surface, Bool32* supported);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetPhysicalDeviceSurfaceCapabilitiesKHR(PhysicalDevice physicalDevice, Surface surface, SurfaceCapabilities* surfaceCapabilities);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetPhysicalDeviceSurfaceFormatsKHR(PhysicalDevice physicalDevice, Surface surface, uint* surfaceFormatCount, SurfaceFormat* surfaceFormats);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetPhysicalDeviceSurfacePresentModesKHR(PhysicalDevice physicalDevice, Surface surface, uint* presentModeCount, PresentMode* presentModes);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateSwapchainKHR(Device device, SwapchainCreateInfo* createInfo, AllocationCallbacks* allocator, Swapchain* swapchain);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroySwapchainKHR(Device device, Swapchain swapchain, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetSwapchainImagesKHR(Device device, Swapchain swapchain, uint* swapchainImageCount, Image* swapchainImages);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkAcquireNextImageKHR(Device device, Swapchain swapchain, ulong timeout, Semaphore semaphore, Fence fence, uint* imageIndex);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkQueuePresentKHR(Queue queue, PresentInfo* presentInfo);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetPhysicalDeviceDisplayPropertiesKHR(PhysicalDevice physicalDevice, uint* propertyCount, DisplayProperties* properties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetPhysicalDeviceDisplayPlanePropertiesKHR(PhysicalDevice physicalDevice, uint* propertyCount, DisplayPlaneProperties* properties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetDisplayPlaneSupportedDisplaysKHR(PhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, Display* displays);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetDisplayModePropertiesKHR(PhysicalDevice physicalDevice, Display display, uint* propertyCount, DisplayModeProperties* properties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateDisplayModeKHR(PhysicalDevice physicalDevice, Display display, DisplayModeCreateInfo* createInfo, AllocationCallbacks* allocator, DisplayMode* mode);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetDisplayPlaneCapabilitiesKHR(PhysicalDevice physicalDevice, DisplayMode mode, uint planeIndex, DisplayPlaneCapabilities* capabilities);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateDisplayPlaneSurfaceKHR(Instance instance, DisplaySurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateSharedSwapchainsKHR(Device device, uint swapchainCount, SwapchainCreateInfo* createInfos, AllocationCallbacks* allocator, Swapchain* swapchains);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateXlibSurfaceKHR(Instance instance, XlibSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Bool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* dpy, IntPtr visualID);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateXcbSurfaceKHR(Instance instance, XcbSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Bool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* connection, IntPtr visual_id);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateWaylandSurfaceKHR(Instance instance, WaylandSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Bool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateMirSurfaceKHR(Instance instance, MirSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Bool32 vkGetPhysicalDeviceMirPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* connection);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateAndroidSurfaceKHR(Instance instance, AndroidSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateWin32SurfaceKHR(Instance instance, Win32SurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Bool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkCreateDebugReportCallbackEXT(Instance instance, DebugReportCallbackCreateInfo* createInfo, AllocationCallbacks* allocator, DebugReportCallback* callback);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDestroyDebugReportCallbackEXT(Instance instance, DebugReportCallback callback, AllocationCallbacks* allocator);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkDebugReportMessageEXT(Instance instance, DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, Size location, int messageCode, char* layerPrefix, char* message);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkDebugMarkerSetObjectTagEXT(Device device, DebugMarkerObjectTagInfo* tagInfo);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkDebugMarkerSetObjectNameEXT(Device device, DebugMarkerObjectNameInfo* nameInfo);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdDebugMarkerBeginEXT(CommandBuffer commandBuffer, DebugMarkerMarkerInfo* markerInfo);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdDebugMarkerEndEXT(CommandBuffer commandBuffer);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdDebugMarkerInsertEXT(CommandBuffer commandBuffer, DebugMarkerMarkerInfo* markerInfo);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdDrawIndirectCountAMD(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate void vkCmdDrawIndexedIndirectCountAMD(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetPhysicalDeviceExternalImageFormatPropertiesNV(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, ExternalMemoryHandleTypeFlags externalHandleType, ExternalImageFormatProperties* externalImageFormatProperties);
    /// <summary>
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public unsafe delegate Result vkGetMemoryWin32HandleNV(Device device, DeviceMemory memory, ExternalMemoryHandleTypeFlags handleType, IntPtr* handle);
}