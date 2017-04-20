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
        public static extern Result vkCreateInstance(InstanceCreateInfo* createInfo, AllocationCallbacks* allocator, Instance* instance);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyInstance(Instance instance, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumeratePhysicalDevices(Instance instance, uint* physicalDeviceCount, PhysicalDevice* physicalDevices);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern VoidFunctionDelegate vkGetDeviceProcAddr(Device device, byte* name);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern VoidFunctionDelegate vkGetInstanceProcAddr(Instance instance, byte* name);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceProperties(PhysicalDevice physicalDevice, PhysicalDeviceProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties(PhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, QueueFamilyProperties* queueFamilyProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMemoryProperties(PhysicalDevice physicalDevice, PhysicalDeviceMemoryProperties* memoryProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFeatures(PhysicalDevice physicalDevice, PhysicalDeviceFeatures* features);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFormatProperties(PhysicalDevice physicalDevice, Format format, FormatProperties* formatProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, ImageFormatProperties* imageFormatProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDevice(PhysicalDevice physicalDevice, DeviceCreateInfo* createInfo, AllocationCallbacks* allocator, Device* device);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDevice(Device device, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumerateInstanceLayerProperties(uint* propertyCount, LayerProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumerateInstanceExtensionProperties(byte* layerName, uint* propertyCount, ExtensionProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumerateDeviceLayerProperties(PhysicalDevice physicalDevice, uint* propertyCount, LayerProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumerateDeviceExtensionProperties(PhysicalDevice physicalDevice, byte* layerName, uint* propertyCount, ExtensionProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceQueue(Device device, uint queueFamilyIndex, uint queueIndex, Queue* queue);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkQueueSubmit(Queue queue, uint submitCount, SubmitInfo* submits, Fence fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkQueueWaitIdle(Queue queue);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkDeviceWaitIdle(Device device);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAllocateMemory(Device device, MemoryAllocateInfo* allocateInfo, AllocationCallbacks* allocator, DeviceMemory* memory);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeMemory(Device device, DeviceMemory memory, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkMapMemory(Device device, DeviceMemory memory, DeviceSize offset, DeviceSize size, MemoryMapFlags flags, void** data);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUnmapMemory(Device device, DeviceMemory memory);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkFlushMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkInvalidateMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceMemoryCommitment(Device device, DeviceMemory memory, DeviceSize* committedMemoryInBytes);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetBufferMemoryRequirements(Device device, Buffer buffer, MemoryRequirements* memoryRequirements);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBindBufferMemory(Device device, Buffer buffer, DeviceMemory memory, DeviceSize memoryOffset);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageMemoryRequirements(Device device, Image image, MemoryRequirements* memoryRequirements);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBindImageMemory(Device device, Image image, DeviceMemory memory, DeviceSize memoryOffset);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSparseMemoryRequirements(Device device, Image image, uint* sparseMemoryRequirementCount, SparseImageMemoryRequirements* sparseMemoryRequirements);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling, uint* propertyCount, SparseImageFormatProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkQueueBindSparse(Queue queue, uint bindInfoCount, BindSparseInfo* bindInfo, Fence fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateFence(Device device, FenceCreateInfo* createInfo, AllocationCallbacks* allocator, Fence* fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFence(Device device, Fence fence, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetFences(Device device, uint fenceCount, Fence* fences);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetFenceStatus(Device device, Fence fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkWaitForFences(Device device, uint fenceCount, Fence* fences, Bool32 waitAll, ulong timeout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateSemaphore(Device device, SemaphoreCreateInfo* createInfo, AllocationCallbacks* allocator, Semaphore* semaphore);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySemaphore(Device device, Semaphore semaphore, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateEvent(Device device, EventCreateInfo* createInfo, AllocationCallbacks* allocator, Event* @event);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyEvent(Device device, Event @event, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetEventStatus(Device device, Event @event);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkSetEvent(Device device, Event @event);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetEvent(Device device, Event @event);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateQueryPool(Device device, QueryPoolCreateInfo* createInfo, AllocationCallbacks* allocator, QueryPool* queryPool);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyQueryPool(Device device, QueryPool queryPool, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetQueryPoolResults(Device device, QueryPool queryPool, uint firstQuery, uint queryCount, HostSize dataSize, void* data, DeviceSize stride, QueryResultFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateBuffer(Device device, BufferCreateInfo* createInfo, AllocationCallbacks* allocator, Buffer* buffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBuffer(Device device, Buffer buffer, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateBufferView(Device device, BufferViewCreateInfo* createInfo, AllocationCallbacks* allocator, BufferView* view);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBufferView(Device device, BufferView bufferView, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateImage(Device device, ImageCreateInfo* createInfo, AllocationCallbacks* allocator, Image* image);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImage(Device device, Image image, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSubresourceLayout(Device device, Image image, ImageSubresource* subresource, SubresourceLayout* layout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateImageView(Device device, ImageViewCreateInfo* createInfo, AllocationCallbacks* allocator, ImageView* view);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImageView(Device device, ImageView imageView, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateShaderModule(Device device, ShaderModuleCreateInfo* createInfo, AllocationCallbacks* allocator, ShaderModule* shaderModule);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyShaderModule(Device device, ShaderModule shaderModule, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreatePipelineCache(Device device, PipelineCacheCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineCache* pipelineCache);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineCache(Device device, PipelineCache pipelineCache, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPipelineCacheData(Device device, PipelineCache pipelineCache, HostSize* dataSize, void* data);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkMergePipelineCaches(Device device, PipelineCache destinationCache, uint sourceCacheCount, PipelineCache* sourceCaches);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateGraphicsPipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, GraphicsPipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateComputePipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, ComputePipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipeline(Device device, Pipeline pipeline, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreatePipelineLayout(Device device, PipelineLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineLayout* pipelineLayout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineLayout(Device device, PipelineLayout pipelineLayout, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateSampler(Device device, SamplerCreateInfo* createInfo, AllocationCallbacks* allocator, Sampler* sampler);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySampler(Device device, Sampler sampler, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDescriptorSetLayout(Device device, DescriptorSetLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorSetLayout* setLayout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorSetLayout(Device device, DescriptorSetLayout descriptorSetLayout, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDescriptorPool(Device device, DescriptorPoolCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorPool* descriptorPool);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorPool(Device device, DescriptorPool descriptorPool, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetDescriptorPool(Device device, DescriptorPool descriptorPool, DescriptorPoolResetFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAllocateDescriptorSets(Device device, DescriptorSetAllocateInfo* allocateInfo, DescriptorSet* descriptorSets);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkFreeDescriptorSets(Device device, DescriptorPool descriptorPool, uint descriptorSetCount, DescriptorSet* descriptorSets);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSets(Device device, uint descriptorWriteCount, WriteDescriptorSet* descriptorWrites, uint descriptorCopyCount, CopyDescriptorSet* descriptorCopies);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateFramebuffer(Device device, FramebufferCreateInfo* createInfo, AllocationCallbacks* allocator, Framebuffer* framebuffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFramebuffer(Device device, Framebuffer framebuffer, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateRenderPass(Device device, RenderPassCreateInfo* createInfo, AllocationCallbacks* allocator, RenderPass* renderPass);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyRenderPass(Device device, RenderPass renderPass, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetRenderAreaGranularity(Device device, RenderPass renderPass, Extent2D* granularity);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateCommandPool(Device device, CommandPoolCreateInfo* createInfo, AllocationCallbacks* allocator, CommandPool* commandPool);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyCommandPool(Device device, CommandPool commandPool, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetCommandPool(Device device, CommandPool commandPool, CommandPoolResetFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAllocateCommandBuffers(Device device, CommandBufferAllocateInfo* allocateInfo, CommandBuffer* commandBuffers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeCommandBuffers(Device device, CommandPool commandPool, uint commandBufferCount, CommandBuffer* commandBuffers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBeginCommandBuffer(CommandBuffer commandBuffer, CommandBufferBeginInfo* beginInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEndCommandBuffer(CommandBuffer commandBuffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkResetCommandBuffer(CommandBuffer commandBuffer, CommandBufferResetFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindPipeline(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, Pipeline pipeline);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewport(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, Viewport* viewports);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetScissor(CommandBuffer commandBuffer, uint firstScissor, uint scissorCount, Rect2D* scissors);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetLineWidth(CommandBuffer commandBuffer, float lineWidth);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDepthBias(CommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetBlendConstants(CommandBuffer commandBuffer, float blendConstants);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDepthBounds(CommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilCompareMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint compareMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilWriteMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint writeMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilReference(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint reference);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindDescriptorSets(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, uint descriptorSetCount, DescriptorSet* descriptorSets, uint dynamicOffsetCount, uint* dynamicOffsets);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindIndexBuffer(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, IndexType indexType);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindVertexBuffers(CommandBuffer commandBuffer, uint firstBinding, uint bindingCount, Buffer* buffers, DeviceSize* offsets);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDraw(CommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexed(CommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, uint drawCount, uint stride);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatch(CommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchIndirect(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyBuffer(CommandBuffer commandBuffer, Buffer sourceBuffer, Buffer destinationBuffer, uint regionCount, BufferCopy* regions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageCopy* regions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBlitImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageBlit* regions, Filter filter);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyBufferToImage(CommandBuffer commandBuffer, Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, BufferImageCopy* regions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyImageToBuffer(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, uint regionCount, BufferImageCopy* regions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdUpdateBuffer(CommandBuffer commandBuffer, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize dataSize, void* data);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdFillBuffer(CommandBuffer commandBuffer, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize size, uint data);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearColorImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearColorValue* color, uint rangeCount, ImageSubresourceRange* ranges);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearDepthStencilImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearDepthStencilValue* depthStencil, uint rangeCount, ImageSubresourceRange* ranges);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearAttachments(CommandBuffer commandBuffer, uint attachmentCount, ClearAttachment* attachments, uint rectCount, ClearRect* rects);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResolveImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageResolve* regions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWaitEvents(CommandBuffer commandBuffer, uint eventCount, Event* events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPipelineBarrier(CommandBuffer commandBuffer, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query, QueryControlFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResetQueryPool(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWriteTimestamp(CommandBuffer commandBuffer, PipelineStageFlags pipelineStage, QueryPool queryPool, uint query);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyQueryPoolResults(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize stride, QueryResultFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushConstants(CommandBuffer commandBuffer, PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, uint size, void* values);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginRenderPass(CommandBuffer commandBuffer, RenderPassBeginInfo* renderPassBegin, SubpassContents contents);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdNextSubpass(CommandBuffer commandBuffer, SubpassContents contents);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndRenderPass(CommandBuffer commandBuffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdExecuteCommands(CommandBuffer commandBuffer, uint commandBufferCount, CommandBuffer* commandBuffers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateAndroidSurfaceKHR(Instance instance, Khr.AndroidSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.Surface* surface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceDisplayPropertiesKHR(PhysicalDevice physicalDevice, uint* propertyCount, Khr.DisplayProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceDisplayPlanePropertiesKHR(PhysicalDevice physicalDevice, uint* propertyCount, Khr.DisplayPlaneProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDisplayPlaneSupportedDisplaysKHR(PhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, Khr.Display* displays);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDisplayModePropertiesKHR(PhysicalDevice physicalDevice, Khr.Display display, uint* propertyCount, Khr.DisplayModeProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDisplayModeKHR(PhysicalDevice physicalDevice, Khr.Display display, Khr.DisplayModeCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.DisplayMode* mode);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDisplayPlaneCapabilitiesKHR(PhysicalDevice physicalDevice, Khr.DisplayMode mode, uint planeIndex, SharpVk.Khr.DisplayPlaneCapabilities* capabilities);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDisplayPlaneSurfaceKHR(Instance instance, Khr.DisplaySurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.Surface* surface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateSharedSwapchainsKHR(Device device, uint swapchainCount, Khr.SwapchainCreateInfo* createInfos, AllocationCallbacks* allocator, Khr.Swapchain* swapchains);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateMirSurfaceKHR(Instance instance, Khr.MirSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.Surface* surface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceMirPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* connection);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySurfaceKHR(Instance instance, Khr.Surface surface, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfaceSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, Khr.Surface surface, Bool32* supported);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfaceCapabilitiesKHR(PhysicalDevice physicalDevice, Khr.Surface surface, SharpVk.Khr.SurfaceCapabilities* surfaceCapabilities);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfaceFormatsKHR(PhysicalDevice physicalDevice, Khr.Surface surface, uint* surfaceFormatCount, SharpVk.Khr.SurfaceFormat* surfaceFormats);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfacePresentModesKHR(PhysicalDevice physicalDevice, Khr.Surface surface, uint* presentModeCount, SharpVk.Khr.PresentMode* presentModes);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateSwapchainKHR(Device device, Khr.SwapchainCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.Swapchain* swapchain);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySwapchainKHR(Device device, Khr.Swapchain swapchain, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetSwapchainImagesKHR(Device device, Khr.Swapchain swapchain, uint* swapchainImageCount, Image* swapchainImages);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAcquireNextImageKHR(Device device, Khr.Swapchain swapchain, ulong timeout, Semaphore semaphore, Fence fence, uint* imageIndex);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkQueuePresentKHR(Queue queue, Khr.PresentInfo* presentInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateViSurfaceNN(Instance instance, Nn.ViSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.Surface* surface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateWaylandSurfaceKHR(Instance instance, Khr.WaylandSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.Surface* surface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr display);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateWin32SurfaceKHR(Instance instance, Khr.Win32SurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.Surface* surface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateXlibSurfaceKHR(Instance instance, Khr.XlibSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.Surface* surface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* dpy, IntPtr visualID);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateXcbSurfaceKHR(Instance instance, Khr.XcbSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.Surface* surface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Bool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr* connection, IntPtr visualId);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDebugReportCallbackEXT(Instance instance, Ext.DebugReportCallbackCreateInfo* createInfo, AllocationCallbacks* allocator, Ext.DebugReportCallback* callback);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDebugReportCallbackEXT(Instance instance, Ext.DebugReportCallback callback, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDebugReportMessageEXT(Instance instance, SharpVk.Ext.DebugReportFlags flags, SharpVk.Ext.DebugReportObjectType objectType, ulong @object, HostSize location, int messageCode, byte* layerPrefix, byte* message);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkDebugMarkerSetObjectNameEXT(Device device, Ext.DebugMarkerObjectNameInfo* nameInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkDebugMarkerSetObjectTagEXT(Device device, Ext.DebugMarkerObjectTagInfo* tagInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerBeginEXT(CommandBuffer commandBuffer, Ext.DebugMarkerMarkerInfo* markerInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerEndEXT(CommandBuffer commandBuffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDebugMarkerInsertEXT(CommandBuffer commandBuffer, Ext.DebugMarkerMarkerInfo* markerInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceExternalImageFormatPropertiesNV(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, SharpVk.Nv.ExternalMemoryHandleTypeFlags externalHandleType, SharpVk.Nv.ExternalImageFormatProperties* externalImageFormatProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryWin32HandleNV(Device device, DeviceMemory memory, SharpVk.Nv.ExternalMemoryHandleTypeFlags handleType, IntPtr* handle);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirectCountAMD(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirectCountAMD(CommandBuffer commandBuffer, Buffer buffer, DeviceSize offset, Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdProcessCommandsNVX(CommandBuffer commandBuffer, Nvx.CommandProcessCommandsInfo* processCommandsInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdReserveSpaceForCommandsNVX(CommandBuffer commandBuffer, Nvx.CommandReserveSpaceForCommandsInfo* reserveSpaceInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateIndirectCommandsLayoutNVX(Device device, Nvx.IndirectCommandsLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, Nvx.IndirectCommandsLayout* indirectCommandsLayout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyIndirectCommandsLayoutNVX(Device device, Nvx.IndirectCommandsLayout indirectCommandsLayout, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateObjectTableNVX(Device device, Nvx.ObjectTableCreateInfo* createInfo, AllocationCallbacks* allocator, Nvx.ObjectTable* objectTable);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyObjectTableNVX(Device device, Nvx.ObjectTable objectTable, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkRegisterObjectsNVX(Device device, Nvx.ObjectTable objectTable, uint objectCount, SharpVk.Nvx.ObjectTableEntry** objectTableEntries, uint* objectIndices);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkUnregisterObjectsNVX(Device device, Nvx.ObjectTable objectTable, uint objectCount, SharpVk.Nvx.ObjectEntryType* objectEntryTypes, uint* objectIndices);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX(PhysicalDevice physicalDevice, Nvx.DeviceGeneratedCommandsFeatures* features, Nvx.DeviceGeneratedCommandsLimits* limits);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFeatures2KHR(PhysicalDevice physicalDevice, Khr.PhysicalDeviceFeatures2* features);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceProperties2KHR(PhysicalDevice physicalDevice, Khr.PhysicalDeviceProperties2* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFormatProperties2KHR(PhysicalDevice physicalDevice, Format format, Khr.FormatProperties2* formatProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceImageFormatProperties2KHR(PhysicalDevice physicalDevice, Khr.PhysicalDeviceImageFormatInfo2* imageFormatInfo, Khr.ImageFormatProperties2* imageFormatProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties2KHR(PhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, Khr.QueueFamilyProperties2* queueFamilyProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMemoryProperties2KHR(PhysicalDevice physicalDevice, Khr.PhysicalDeviceMemoryProperties2* memoryProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties2KHR(PhysicalDevice physicalDevice, Khr.PhysicalDeviceSparseImageFormatInfo2* formatInfo, uint* propertyCount, Khr.SparseImageFormatProperties2* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushDescriptorSetKHR(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint set, uint descriptorWriteCount, WriteDescriptorSet* descriptorWrites);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkTrimCommandPoolKHR(Device device, CommandPool commandPool, SharpVk.Khr.CommandPoolTrimFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalBufferPropertiesKHX(PhysicalDevice physicalDevice, Khx.PhysicalDeviceExternalBufferInfo* externalBufferInfo, Khx.ExternalBufferProperties* externalBufferProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryWin32HandleKHX(Device device, DeviceMemory memory, SharpVk.Khx.ExternalMemoryHandleTypeFlags handleType, IntPtr* handle);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryWin32HandlePropertiesKHX(Device device, SharpVk.Khx.ExternalMemoryHandleTypeFlags handleType, IntPtr handle, Khx.MemoryWin32HandleProperties* memoryWin32HandleProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryFdKHX(Device device, DeviceMemory memory, SharpVk.Khx.ExternalMemoryHandleTypeFlags handleType, int* fileDescriptor);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetMemoryFdPropertiesKHX(Device device, SharpVk.Khx.ExternalMemoryHandleTypeFlags handleType, int fileDescriptor, Khx.MemoryFileDescriptorProperties* memoryFileDescriptorProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceExternalSemaphorePropertiesKHX(PhysicalDevice physicalDevice, Khx.PhysicalDeviceExternalSemaphoreInfo* externalSemaphoreInfo, Khx.ExternalSemaphoreProperties* externalSemaphoreProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetSemaphoreWin32HandleKHX(Device device, Semaphore semaphore, SharpVk.Khx.ExternalSemaphoreHandleTypeFlags handleType, IntPtr* handle);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkImportSemaphoreWin32HandleKHX(Device device, Khx.ImportSemaphoreWin32HandleInfo* importSemaphoreWin32HandleInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetSemaphoreFdKHX(Device device, Semaphore semaphore, SharpVk.Khx.ExternalSemaphoreHandleTypeFlags handleType, int* fileDescriptor);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkImportSemaphoreFdKHX(Device device, Khx.ImportSemaphoreFileDescriptorInfo* importSemaphoreFileDescriptorInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkReleaseDisplayEXT(PhysicalDevice physicalDevice, Khr.Display display);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAcquireXlibDisplayEXT(PhysicalDevice physicalDevice, IntPtr* dpy, Khr.Display display);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetRandROutputDisplayEXT(PhysicalDevice physicalDevice, IntPtr* dpy, IntPtr rrOutput, Khr.Display* display);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkDisplayPowerControlEXT(Device device, Khr.Display display, Ext.DisplayPowerInfo* displayPowerInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkRegisterDeviceEventEXT(Device device, Ext.DeviceEventInfo* deviceEventInfo, AllocationCallbacks* allocator, Fence* fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkRegisterDisplayEventEXT(Device device, Khr.Display display, Ext.DisplayEventInfo* displayEventInfo, AllocationCallbacks* allocator, Fence* fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetSwapchainCounterEXT(Device device, Khr.Swapchain swapchain, SharpVk.Ext.SurfaceCounterFlags counter, ulong* counterValue);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDeviceSurfaceCapabilities2EXT(PhysicalDevice physicalDevice, Khr.Surface surface, Ext.SurfaceCapabilities2* surfaceCapabilities);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkEnumeratePhysicalDeviceGroupsKHX(Instance instance, uint* physicalDeviceGroupCount, Khx.PhysicalDeviceGroupProperties* physicalDeviceGroupProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceGroupPeerMemoryFeaturesKHX(Device device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, SharpVk.Khx.PeerMemoryFeatureFlags* peerMemoryFeatures);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBindBufferMemory2KHX(Device device, uint bindInfoCount, Khx.BindBufferMemoryInfo* bindInfos);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkBindImageMemory2KHX(Device device, uint bindInfoCount, Khx.BindImageMemoryInfo* bindInfos);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDeviceMaskKHX(CommandBuffer commandBuffer, uint deviceMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDeviceGroupPresentCapabilitiesKHX(Device device, Khx.DeviceGroupPresentCapabilities* deviceGroupPresentCapabilities);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetDeviceGroupSurfacePresentModesKHX(Device device, Khr.Surface surface, SharpVk.Khx.DeviceGroupPresentModeFlags* modes);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkAcquireNextImage2KHX(Device device, Khx.AcquireNextImageInfo* acquireInfo, uint* imageIndex);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchBaseKHX(CommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPhysicalDevicePresentRectanglesKHX(PhysicalDevice physicalDevice, Khr.Surface surface, uint* rectCount, Rect2D* rects);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateDescriptorUpdateTemplateKHR(Device device, Khr.DescriptorUpdateTemplateCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.DescriptorUpdateTemplate* descriptorUpdateTemplate);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorUpdateTemplateKHR(Device device, Khr.DescriptorUpdateTemplate descriptorUpdateTemplate, AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSetWithTemplateKHR(Device device, DescriptorSet descriptorSet, Khr.DescriptorUpdateTemplate descriptorUpdateTemplate, void* data);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushDescriptorSetWithTemplateKHR(CommandBuffer commandBuffer, Khr.DescriptorUpdateTemplate descriptorUpdateTemplate, PipelineLayout layout, uint set, void* data);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkSetHdrMetadataEXT(Device device, uint swapchainCount, Khr.Swapchain* swapchains, Ext.HdrMetadata* metadata);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetRefreshCycleDurationGOOGLE(Device device, Khr.Swapchain swapchain, SharpVk.Google.RefreshCycleDuration* displayTimingProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkGetPastPresentationTimingGOOGLE(Device device, Khr.Swapchain swapchain, uint* presentationTimingCount, SharpVk.Google.PastPresentationTiming* presentationTimings);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateIOSSurfaceMVK(Instance instance, Mvk.IOSSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.Surface* surface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern Result vkCreateMacOSSurfaceMVK(Instance instance, Mvk.MacOSSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Khr.Surface* surface);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewportWScalingNV(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, SharpVk.Nv.ViewportWScaling* viewportWScalings);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDiscardRectangleEXT(CommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, Rect2D* discardRectangles);
    }
}
