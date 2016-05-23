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

	}
}