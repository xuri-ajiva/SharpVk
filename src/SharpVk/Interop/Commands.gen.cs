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
        public static extern SharpVk.Result vkCreateInstance(SharpVk.Interop.InstanceCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.Instance* instance);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyInstance(SharpVk.Interop.Instance instance, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkEnumeratePhysicalDevices(SharpVk.Interop.Instance instance, uint* physicalDeviceCount, SharpVk.Interop.PhysicalDevice* physicalDevices);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFeatures(SharpVk.Interop.PhysicalDevice physicalDevice, SharpVk.Interop.PhysicalDeviceFeatures* features);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceFormatProperties(SharpVk.Interop.PhysicalDevice physicalDevice, SharpVk.Format format, SharpVk.FormatProperties* formatProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkGetPhysicalDeviceImageFormatProperties(SharpVk.Interop.PhysicalDevice physicalDevice, SharpVk.Format format, SharpVk.ImageType type, SharpVk.ImageTiling tiling, SharpVk.ImageUsageFlags usage, SharpVk.ImageCreateFlags flags, SharpVk.ImageFormatProperties* imageFormatProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceProperties(SharpVk.Interop.PhysicalDevice physicalDevice, SharpVk.Interop.PhysicalDeviceProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceQueueFamilyProperties(SharpVk.Interop.PhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, SharpVk.QueueFamilyProperties* queueFamilyProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceMemoryProperties(SharpVk.Interop.PhysicalDevice physicalDevice, SharpVk.Interop.PhysicalDeviceMemoryProperties* memoryProperties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr vkGetInstanceProcAddr(SharpVk.Interop.Instance instance, byte* name);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr vkGetDeviceProcAddr(SharpVk.Interop.Device device, byte* name);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateDevice(SharpVk.Interop.PhysicalDevice physicalDevice, SharpVk.Interop.DeviceCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.Device* device);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDevice(SharpVk.Interop.Device device, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkEnumerateInstanceExtensionProperties(byte* layerName, uint* propertyCount, SharpVk.Interop.ExtensionProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkEnumerateDeviceExtensionProperties(SharpVk.Interop.PhysicalDevice physicalDevice, byte* layerName, uint* propertyCount, SharpVk.Interop.ExtensionProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkEnumerateInstanceLayerProperties(uint* propertyCount, SharpVk.Interop.LayerProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkEnumerateDeviceLayerProperties(SharpVk.Interop.PhysicalDevice physicalDevice, uint* propertyCount, SharpVk.Interop.LayerProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceQueue(SharpVk.Interop.Device device, uint queueFamilyIndex, uint queueIndex, SharpVk.Interop.Queue* queue);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkQueueSubmit(SharpVk.Interop.Queue queue, uint submitCount, SharpVk.Interop.SubmitInfo* submits, SharpVk.Interop.Fence fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkQueueWaitIdle(SharpVk.Interop.Queue queue);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkDeviceWaitIdle(SharpVk.Interop.Device device);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkAllocateMemory(SharpVk.Interop.Device device, SharpVk.Interop.MemoryAllocateInfo* allocateInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.DeviceMemory* memory);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeMemory(SharpVk.Interop.Device device, SharpVk.Interop.DeviceMemory memory, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkMapMemory(SharpVk.Interop.Device device, SharpVk.Interop.DeviceMemory memory, DeviceSize offset, DeviceSize size, SharpVk.MemoryMapFlags flags, void** data);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUnmapMemory(SharpVk.Interop.Device device, SharpVk.Interop.DeviceMemory memory);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkFlushMappedMemoryRanges(SharpVk.Interop.Device device, uint memoryRangeCount, SharpVk.Interop.MappedMemoryRange* memoryRanges);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkInvalidateMappedMemoryRanges(SharpVk.Interop.Device device, uint memoryRangeCount, SharpVk.Interop.MappedMemoryRange* memoryRanges);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetDeviceMemoryCommitment(SharpVk.Interop.Device device, SharpVk.Interop.DeviceMemory memory, DeviceSize* committedMemoryInBytes);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkBindBufferMemory(SharpVk.Interop.Device device, SharpVk.Interop.Buffer buffer, SharpVk.Interop.DeviceMemory memory, DeviceSize memoryOffset);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkBindImageMemory(SharpVk.Interop.Device device, SharpVk.Interop.Image image, SharpVk.Interop.DeviceMemory memory, DeviceSize memoryOffset);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetBufferMemoryRequirements(SharpVk.Interop.Device device, SharpVk.Interop.Buffer buffer, SharpVk.MemoryRequirements* memoryRequirements);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageMemoryRequirements(SharpVk.Interop.Device device, SharpVk.Interop.Image image, SharpVk.MemoryRequirements* memoryRequirements);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSparseMemoryRequirements(SharpVk.Interop.Device device, SharpVk.Interop.Image image, uint* sparseMemoryRequirementCount, SharpVk.SparseImageMemoryRequirements* sparseMemoryRequirements);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetPhysicalDeviceSparseImageFormatProperties(SharpVk.Interop.PhysicalDevice physicalDevice, SharpVk.Format format, SharpVk.ImageType type, SharpVk.SampleCountFlags samples, SharpVk.ImageUsageFlags usage, SharpVk.ImageTiling tiling, uint* propertyCount, SharpVk.SparseImageFormatProperties* properties);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkQueueBindSparse(SharpVk.Interop.Queue queue, uint bindInfoCount, SharpVk.Interop.BindSparseInfo* bindInfo, SharpVk.Interop.Fence fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateFence(SharpVk.Interop.Device device, SharpVk.Interop.FenceCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.Fence* fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFence(SharpVk.Interop.Device device, SharpVk.Interop.Fence fence, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkResetFences(SharpVk.Interop.Device device, uint fenceCount, SharpVk.Interop.Fence* fences);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkGetFenceStatus(SharpVk.Interop.Device device, SharpVk.Interop.Fence fence);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkWaitForFences(SharpVk.Interop.Device device, uint fenceCount, SharpVk.Interop.Fence* fences, Bool32 waitAll, ulong timeout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateSemaphore(SharpVk.Interop.Device device, SharpVk.Interop.SemaphoreCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.Semaphore* semaphore);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySemaphore(SharpVk.Interop.Device device, SharpVk.Interop.Semaphore semaphore, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateEvent(SharpVk.Interop.Device device, SharpVk.Interop.EventCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.Event* @event);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyEvent(SharpVk.Interop.Device device, SharpVk.Interop.Event @event, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkGetEventStatus(SharpVk.Interop.Device device, SharpVk.Interop.Event @event);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkSetEvent(SharpVk.Interop.Device device, SharpVk.Interop.Event @event);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkResetEvent(SharpVk.Interop.Device device, SharpVk.Interop.Event @event);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateQueryPool(SharpVk.Interop.Device device, SharpVk.Interop.QueryPoolCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.QueryPool* queryPool);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyQueryPool(SharpVk.Interop.Device device, SharpVk.Interop.QueryPool queryPool, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkGetQueryPoolResults(SharpVk.Interop.Device device, SharpVk.Interop.QueryPool queryPool, uint firstQuery, uint queryCount, HostSize dataSize, void* data, DeviceSize stride, SharpVk.QueryResultFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateBuffer(SharpVk.Interop.Device device, SharpVk.Interop.BufferCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.Buffer* buffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBuffer(SharpVk.Interop.Device device, SharpVk.Interop.Buffer buffer, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateBufferView(SharpVk.Interop.Device device, SharpVk.Interop.BufferViewCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.BufferView* view);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyBufferView(SharpVk.Interop.Device device, SharpVk.Interop.BufferView bufferView, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateImage(SharpVk.Interop.Device device, SharpVk.Interop.ImageCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.Image* image);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImage(SharpVk.Interop.Device device, SharpVk.Interop.Image image, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetImageSubresourceLayout(SharpVk.Interop.Device device, SharpVk.Interop.Image image, SharpVk.ImageSubresource* subresource, SharpVk.SubresourceLayout* layout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateImageView(SharpVk.Interop.Device device, SharpVk.Interop.ImageViewCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.ImageView* view);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyImageView(SharpVk.Interop.Device device, SharpVk.Interop.ImageView imageView, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateShaderModule(SharpVk.Interop.Device device, SharpVk.Interop.ShaderModuleCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.ShaderModule* shaderModule);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyShaderModule(SharpVk.Interop.Device device, SharpVk.Interop.ShaderModule shaderModule, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreatePipelineCache(SharpVk.Interop.Device device, SharpVk.Interop.PipelineCacheCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.PipelineCache* pipelineCache);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineCache(SharpVk.Interop.Device device, SharpVk.Interop.PipelineCache pipelineCache, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkGetPipelineCacheData(SharpVk.Interop.Device device, SharpVk.Interop.PipelineCache pipelineCache, HostSize* dataSize, void* data);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkMergePipelineCaches(SharpVk.Interop.Device device, SharpVk.Interop.PipelineCache destinationCache, uint sourceCacheCount, SharpVk.Interop.PipelineCache* sourceCaches);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateGraphicsPipelines(SharpVk.Interop.Device device, SharpVk.Interop.PipelineCache pipelineCache, uint createInfoCount, SharpVk.Interop.GraphicsPipelineCreateInfo* createInfos, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.Pipeline* pipelines);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateComputePipelines(SharpVk.Interop.Device device, SharpVk.Interop.PipelineCache pipelineCache, uint createInfoCount, SharpVk.Interop.ComputePipelineCreateInfo* createInfos, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.Pipeline* pipelines);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipeline(SharpVk.Interop.Device device, SharpVk.Interop.Pipeline pipeline, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreatePipelineLayout(SharpVk.Interop.Device device, SharpVk.Interop.PipelineLayoutCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.PipelineLayout* pipelineLayout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyPipelineLayout(SharpVk.Interop.Device device, SharpVk.Interop.PipelineLayout pipelineLayout, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateSampler(SharpVk.Interop.Device device, SharpVk.Interop.SamplerCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.Sampler* sampler);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroySampler(SharpVk.Interop.Device device, SharpVk.Interop.Sampler sampler, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateDescriptorSetLayout(SharpVk.Interop.Device device, SharpVk.Interop.DescriptorSetLayoutCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.DescriptorSetLayout* setLayout);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorSetLayout(SharpVk.Interop.Device device, SharpVk.Interop.DescriptorSetLayout descriptorSetLayout, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateDescriptorPool(SharpVk.Interop.Device device, SharpVk.Interop.DescriptorPoolCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.DescriptorPool* descriptorPool);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyDescriptorPool(SharpVk.Interop.Device device, SharpVk.Interop.DescriptorPool descriptorPool, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkResetDescriptorPool(SharpVk.Interop.Device device, SharpVk.Interop.DescriptorPool descriptorPool, SharpVk.DescriptorPoolResetFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkAllocateDescriptorSets(SharpVk.Interop.Device device, SharpVk.Interop.DescriptorSetAllocateInfo* allocateInfo, SharpVk.Interop.DescriptorSet* descriptorSets);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkFreeDescriptorSets(SharpVk.Interop.Device device, SharpVk.Interop.DescriptorPool descriptorPool, uint descriptorSetCount, SharpVk.Interop.DescriptorSet* descriptorSets);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkUpdateDescriptorSets(SharpVk.Interop.Device device, uint descriptorWriteCount, SharpVk.Interop.WriteDescriptorSet* descriptorWrites, uint descriptorCopyCount, SharpVk.Interop.CopyDescriptorSet* descriptorCopies);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateFramebuffer(SharpVk.Interop.Device device, SharpVk.Interop.FramebufferCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.Framebuffer* framebuffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyFramebuffer(SharpVk.Interop.Device device, SharpVk.Interop.Framebuffer framebuffer, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateRenderPass(SharpVk.Interop.Device device, SharpVk.Interop.RenderPassCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.RenderPass* renderPass);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyRenderPass(SharpVk.Interop.Device device, SharpVk.Interop.RenderPass renderPass, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkGetRenderAreaGranularity(SharpVk.Interop.Device device, SharpVk.Interop.RenderPass renderPass, SharpVk.Extent2D* granularity);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkCreateCommandPool(SharpVk.Interop.Device device, SharpVk.Interop.CommandPoolCreateInfo* createInfo, SharpVk.Interop.AllocationCallbacks* allocator, SharpVk.Interop.CommandPool* commandPool);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkDestroyCommandPool(SharpVk.Interop.Device device, SharpVk.Interop.CommandPool commandPool, SharpVk.Interop.AllocationCallbacks* allocator);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkResetCommandPool(SharpVk.Interop.Device device, SharpVk.Interop.CommandPool commandPool, SharpVk.CommandPoolResetFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkAllocateCommandBuffers(SharpVk.Interop.Device device, SharpVk.Interop.CommandBufferAllocateInfo* allocateInfo, SharpVk.Interop.CommandBuffer* commandBuffers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkFreeCommandBuffers(SharpVk.Interop.Device device, SharpVk.Interop.CommandPool commandPool, uint commandBufferCount, SharpVk.Interop.CommandBuffer* commandBuffers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkBeginCommandBuffer(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.CommandBufferBeginInfo* beginInfo);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkEndCommandBuffer(SharpVk.Interop.CommandBuffer commandBuffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern SharpVk.Result vkResetCommandBuffer(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.CommandBufferResetFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindPipeline(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.Interop.Pipeline pipeline);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetViewport(SharpVk.Interop.CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, SharpVk.Viewport* viewports);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetScissor(SharpVk.Interop.CommandBuffer commandBuffer, uint firstScissor, uint scissorCount, SharpVk.Rect2D* scissors);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetLineWidth(SharpVk.Interop.CommandBuffer commandBuffer, float lineWidth);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDepthBias(SharpVk.Interop.CommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetBlendConstants(SharpVk.Interop.CommandBuffer commandBuffer, float blendConstants);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetDepthBounds(SharpVk.Interop.CommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilCompareMask(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.StencilFaceFlags faceMask, uint compareMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilWriteMask(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.StencilFaceFlags faceMask, uint writeMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetStencilReference(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.StencilFaceFlags faceMask, uint reference);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindDescriptorSets(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.Interop.PipelineLayout layout, uint firstSet, uint descriptorSetCount, SharpVk.Interop.DescriptorSet* descriptorSets, uint dynamicOffsetCount, uint* dynamicOffsets);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindIndexBuffer(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Buffer buffer, DeviceSize offset, SharpVk.IndexType indexType);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBindVertexBuffers(SharpVk.Interop.CommandBuffer commandBuffer, uint firstBinding, uint bindingCount, SharpVk.Interop.Buffer* buffers, DeviceSize* offsets);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDraw(SharpVk.Interop.CommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexed(SharpVk.Interop.CommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndirect(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Buffer buffer, DeviceSize offset, uint drawCount, uint stride);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDrawIndexedIndirect(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Buffer buffer, DeviceSize offset, uint drawCount, uint stride);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatch(SharpVk.Interop.CommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdDispatchIndirect(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Buffer buffer, DeviceSize offset);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyBuffer(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Buffer sourceBuffer, SharpVk.Interop.Buffer destinationBuffer, uint regionCount, SharpVk.BufferCopy* regions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyImage(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Image sourceImage, SharpVk.ImageLayout sourceImageLayout, SharpVk.Interop.Image destinationImage, SharpVk.ImageLayout destinationImageLayout, uint regionCount, SharpVk.ImageCopy* regions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBlitImage(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Image sourceImage, SharpVk.ImageLayout sourceImageLayout, SharpVk.Interop.Image destinationImage, SharpVk.ImageLayout destinationImageLayout, uint regionCount, SharpVk.Interop.ImageBlit* regions, SharpVk.Filter filter);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyBufferToImage(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Buffer sourceBuffer, SharpVk.Interop.Image destinationImage, SharpVk.ImageLayout destinationImageLayout, uint regionCount, SharpVk.BufferImageCopy* regions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyImageToBuffer(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Image sourceImage, SharpVk.ImageLayout sourceImageLayout, SharpVk.Interop.Buffer destinationBuffer, uint regionCount, SharpVk.BufferImageCopy* regions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdUpdateBuffer(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize dataSize, void* data);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdFillBuffer(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize size, uint data);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearColorImage(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Image image, SharpVk.ImageLayout imageLayout, SharpVk.ClearColorValue* color, uint rangeCount, SharpVk.ImageSubresourceRange* ranges);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearDepthStencilImage(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Image image, SharpVk.ImageLayout imageLayout, SharpVk.ClearDepthStencilValue* depthStencil, uint rangeCount, SharpVk.ImageSubresourceRange* ranges);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdClearAttachments(SharpVk.Interop.CommandBuffer commandBuffer, uint attachmentCount, SharpVk.ClearAttachment* attachments, uint rectCount, SharpVk.ClearRect* rects);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResolveImage(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Image sourceImage, SharpVk.ImageLayout sourceImageLayout, SharpVk.Interop.Image destinationImage, SharpVk.ImageLayout destinationImageLayout, uint regionCount, SharpVk.ImageResolve* regions);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdSetEvent(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Event @event, SharpVk.PipelineStageFlags stageMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResetEvent(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.Event @event, SharpVk.PipelineStageFlags stageMask);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWaitEvents(SharpVk.Interop.CommandBuffer commandBuffer, uint eventCount, SharpVk.Interop.Event* events, SharpVk.PipelineStageFlags sourceStageMask, SharpVk.PipelineStageFlags destinationStageMask, uint memoryBarrierCount, SharpVk.Interop.MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, SharpVk.Interop.BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, SharpVk.Interop.ImageMemoryBarrier* imageMemoryBarriers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPipelineBarrier(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.PipelineStageFlags sourceStageMask, SharpVk.PipelineStageFlags destinationStageMask, SharpVk.DependencyFlags dependencyFlags, uint memoryBarrierCount, SharpVk.Interop.MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, SharpVk.Interop.BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, SharpVk.Interop.ImageMemoryBarrier* imageMemoryBarriers);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginQuery(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.QueryPool queryPool, uint query, SharpVk.QueryControlFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndQuery(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.QueryPool queryPool, uint query);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdResetQueryPool(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.QueryPool queryPool, uint firstQuery, uint queryCount);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdWriteTimestamp(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.PipelineStageFlags pipelineStage, SharpVk.Interop.QueryPool queryPool, uint query);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdCopyQueryPoolResults(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.QueryPool queryPool, uint firstQuery, uint queryCount, SharpVk.Interop.Buffer destinationBuffer, DeviceSize destinationOffset, DeviceSize stride, SharpVk.QueryResultFlags flags);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdPushConstants(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.PipelineLayout layout, SharpVk.ShaderStageFlags stageFlags, uint offset, uint size, void* values);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdBeginRenderPass(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.Interop.RenderPassBeginInfo* renderPassBegin, SharpVk.SubpassContents contents);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdNextSubpass(SharpVk.Interop.CommandBuffer commandBuffer, SharpVk.SubpassContents contents);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdEndRenderPass(SharpVk.Interop.CommandBuffer commandBuffer);
        
        /// <summary>
        /// 
        /// </summary>
        [DllImport(VulkanDll, CallingConvention = CallingConvention.Winapi)]
        public static extern void vkCmdExecuteCommands(SharpVk.Interop.CommandBuffer commandBuffer, uint commandBufferCount, SharpVk.Interop.CommandBuffer* commandBuffers);
    }
}
