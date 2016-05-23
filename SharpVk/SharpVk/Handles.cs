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

namespace SharpVk
{
	public class Buffer
	{
		internal readonly Interop.Buffer handle;

		private readonly Device parent;

		internal Buffer(Interop.Buffer handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void BindBufferMemory(DeviceMemory memory, DeviceSize memoryOffset)
		{
			unsafe
			{
				Interop.DeviceMemory marshalledMemory = memory?.Pack() ?? Interop.DeviceMemory.Null;

				Interop.Commands.vkBindBufferMemory(this.parent.handle, this.handle, marshalledMemory, memoryOffset);


				Interop.HeapUtil.FreeLog();
			}
		}

		public MemoryRequirements GetBufferMemoryRequirements()
		{
			unsafe
			{
				MemoryRequirements result = default(MemoryRequirements);


				Interop.Commands.vkGetBufferMemoryRequirements(this.parent.handle, this.handle, &result);


				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		internal Interop.Buffer Pack()
		{
			return this.handle;
		}
	}

	public class CommandBuffer
	{
		internal readonly Interop.CommandBuffer handle;

		private readonly CommandPool parent;

		internal CommandBuffer(Interop.CommandBuffer handle, CommandPool parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		internal Interop.CommandBuffer Pack()
		{
			return this.handle;
		}
	}

	public class CommandPool
	{
		internal readonly Interop.CommandPool handle;

		private readonly Device parent;

		internal CommandPool(Interop.CommandPool handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		internal Interop.CommandPool Pack()
		{
			return this.handle;
		}
	}

	public class Device
	{
		internal readonly Interop.Device handle;

		private readonly PhysicalDevice parent;

		internal Device(Interop.Device handle, PhysicalDevice parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public IntPtr GetDeviceProcAddr(string name)
		{
			unsafe
			{
				IntPtr result = default(IntPtr);

				char* marshalledName = Interop.HeapUtil.MarshalTo(name);

				Interop.Commands.vkGetDeviceProcAddr(this.handle, marshalledName);


				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public void DestroyDevice(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();

				Interop.Commands.vkDestroyDevice(this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();
			}
		}

		public Queue GetDeviceQueue(uint queueFamilyIndex, uint queueIndex)
		{
			unsafe
			{
				Queue result = default(Queue);

				Interop.Queue marshalledQueue;

				Interop.Commands.vkGetDeviceQueue(this.handle, queueFamilyIndex, queueIndex, &marshalledQueue);

				result = new Queue(marshalledQueue, this);

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public void DeviceWaitIdle()
		{
			unsafe
			{

				Interop.Commands.vkDeviceWaitIdle(this.handle);


				Interop.HeapUtil.FreeLog();
			}
		}

		public DeviceMemory AllocateMemory(MemoryAllocateInfo allocateInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				DeviceMemory result = default(DeviceMemory);

				Interop.MemoryAllocateInfo marshalledAllocateInfo;
				if(allocateInfo != null) marshalledAllocateInfo = allocateInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.DeviceMemory marshalledMemory;

				Interop.Commands.vkAllocateMemory(this.handle, allocateInfo == null ? null : &marshalledAllocateInfo, allocator == null ? null : &marshalledAllocator, &marshalledMemory);

				result = new DeviceMemory(marshalledMemory, this);

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public void FlushMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
		{
			unsafe
			{

				Interop.Commands.vkFlushMappedMemoryRanges(this.handle, (uint)memoryRanges.Length, null);


				Interop.HeapUtil.FreeLog();
			}
		}

		public void InvalidateMappedMemoryRanges(MappedMemoryRange[] memoryRanges)
		{
			unsafe
			{

				Interop.Commands.vkInvalidateMappedMemoryRanges(this.handle, (uint)memoryRanges.Length, null);


				Interop.HeapUtil.FreeLog();
			}
		}

		internal Interop.Device Pack()
		{
			return this.handle;
		}
	}

	public class DeviceMemory
	{
		internal readonly Interop.DeviceMemory handle;

		private readonly Device parent;

		internal DeviceMemory(Interop.DeviceMemory handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void FreeMemory(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();

				Interop.Commands.vkFreeMemory(this.parent.handle, this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();
			}
		}

		public void MapMemory(DeviceSize offset, DeviceSize size, MemoryMapFlags flags, ref IntPtr data)
		{
			unsafe
			{
				void* marshalledData;

				Interop.Commands.vkMapMemory(this.parent.handle, this.handle, offset, size, flags, &marshalledData);

				data = new IntPtr(marshalledData);

				Interop.HeapUtil.FreeLog();
			}
		}

		public void UnmapMemory()
		{
			unsafe
			{

				Interop.Commands.vkUnmapMemory(this.parent.handle, this.handle);


				Interop.HeapUtil.FreeLog();
			}
		}

		public DeviceSize GetDeviceMemoryCommitment()
		{
			unsafe
			{
				DeviceSize result = default(DeviceSize);


				Interop.Commands.vkGetDeviceMemoryCommitment(this.parent.handle, this.handle, &result);


				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		internal Interop.DeviceMemory Pack()
		{
			return this.handle;
		}
	}

	public class Fence
	{
		internal readonly Interop.Fence handle;

		private readonly Device parent;

		internal Fence(Interop.Fence handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		internal Interop.Fence Pack()
		{
			return this.handle;
		}
	}

	public class Image
	{
		internal readonly Interop.Image handle;

		private readonly Device parent;

		internal Image(Interop.Image handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void BindImageMemory(DeviceMemory memory, DeviceSize memoryOffset)
		{
			unsafe
			{
				Interop.DeviceMemory marshalledMemory = memory?.Pack() ?? Interop.DeviceMemory.Null;

				Interop.Commands.vkBindImageMemory(this.parent.handle, this.handle, marshalledMemory, memoryOffset);


				Interop.HeapUtil.FreeLog();
			}
		}

		public MemoryRequirements GetImageMemoryRequirements()
		{
			unsafe
			{
				MemoryRequirements result = default(MemoryRequirements);


				Interop.Commands.vkGetImageMemoryRequirements(this.parent.handle, this.handle, &result);


				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public SparseImageMemoryRequirements[] GetImageSparseMemoryRequirements()
		{
			unsafe
			{
				SparseImageMemoryRequirements[] result = default(SparseImageMemoryRequirements[]);

				uint sparseMemoryRequirementCount;
				SparseImageMemoryRequirements* marshalledSparseMemoryRequirements = null;
				Interop.Commands.vkGetImageSparseMemoryRequirements(this.parent.handle, this.handle, &sparseMemoryRequirementCount, null);

				marshalledSparseMemoryRequirements = (SparseImageMemoryRequirements*)Interop.HeapUtil.Allocate<SparseImageMemoryRequirements>(sparseMemoryRequirementCount);

				Interop.Commands.vkGetImageSparseMemoryRequirements(this.parent.handle, this.handle, &sparseMemoryRequirementCount, marshalledSparseMemoryRequirements);

				result = new SparseImageMemoryRequirements[sparseMemoryRequirementCount];
				for(int index = 0; index < sparseMemoryRequirementCount; index++)
				{
					result[index] = marshalledSparseMemoryRequirements[index];
				}

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		internal Interop.Image Pack()
		{
			return this.handle;
		}
	}

	public class Instance
	{
		internal readonly Interop.Instance handle;

		internal Instance(Interop.Instance handle)
		{
			this.handle = handle;
		}

		public static Instance CreateInstance(InstanceCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				Instance result = default(Instance);

				Interop.InstanceCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Instance marshalledInstance;

				Interop.Commands.vkCreateInstance(createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledInstance);

				result = new Instance(marshalledInstance);

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public void DestroyInstance(AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();

				Interop.Commands.vkDestroyInstance(this.handle, allocator == null ? null : &marshalledAllocator);


				Interop.HeapUtil.FreeLog();
			}
		}

		public PhysicalDevice[] EnumeratePhysicalDevices()
		{
			unsafe
			{
				PhysicalDevice[] result = default(PhysicalDevice[]);

				uint physicalDeviceCount;
				Interop.PhysicalDevice* marshalledPhysicalDevices = null;
				Interop.Commands.vkEnumeratePhysicalDevices(this.handle, &physicalDeviceCount, null);

				marshalledPhysicalDevices = (Interop.PhysicalDevice*)Interop.HeapUtil.Allocate<Interop.PhysicalDevice>(physicalDeviceCount);

				Interop.Commands.vkEnumeratePhysicalDevices(this.handle, &physicalDeviceCount, marshalledPhysicalDevices);

				result = new PhysicalDevice[physicalDeviceCount];
				for(int index = 0; index < physicalDeviceCount; index++)
				{
					result[index] = new PhysicalDevice(marshalledPhysicalDevices[index], this);
				}

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public IntPtr GetInstanceProcAddr(string name)
		{
			unsafe
			{
				IntPtr result = default(IntPtr);

				char* marshalledName = Interop.HeapUtil.MarshalTo(name);

				Interop.Commands.vkGetInstanceProcAddr(this.handle, marshalledName);


				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public static ExtensionProperties[] EnumerateInstanceExtensionProperties(string layerName)
		{
			unsafe
			{
				ExtensionProperties[] result = default(ExtensionProperties[]);

				char* marshalledLayerName = Interop.HeapUtil.MarshalTo(layerName);
				uint propertyCount;
				Interop.ExtensionProperties* marshalledProperties = null;
				Interop.Commands.vkEnumerateInstanceExtensionProperties(marshalledLayerName, &propertyCount, null);

				marshalledProperties = (Interop.ExtensionProperties*)Interop.HeapUtil.Allocate<Interop.ExtensionProperties>(propertyCount);

				Interop.Commands.vkEnumerateInstanceExtensionProperties(marshalledLayerName, &propertyCount, marshalledProperties);

				result = new ExtensionProperties[propertyCount];
				for(int index = 0; index < propertyCount; index++)
				{
					result[index] = ExtensionProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public static LayerProperties[] EnumerateInstanceLayerProperties()
		{
			unsafe
			{
				LayerProperties[] result = default(LayerProperties[]);

				uint propertyCount;
				Interop.LayerProperties* marshalledProperties = null;
				Interop.Commands.vkEnumerateInstanceLayerProperties(&propertyCount, null);

				marshalledProperties = (Interop.LayerProperties*)Interop.HeapUtil.Allocate<Interop.LayerProperties>(propertyCount);

				Interop.Commands.vkEnumerateInstanceLayerProperties(&propertyCount, marshalledProperties);

				result = new LayerProperties[propertyCount];
				for(int index = 0; index < propertyCount; index++)
				{
					result[index] = LayerProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		internal Interop.Instance Pack()
		{
			return this.handle;
		}
	}

	public class PhysicalDevice
	{
		internal readonly Interop.PhysicalDevice handle;

		private readonly Instance parent;

		internal PhysicalDevice(Interop.PhysicalDevice handle, Instance parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public PhysicalDeviceFeatures GetPhysicalDeviceFeatures()
		{
			unsafe
			{
				PhysicalDeviceFeatures result = default(PhysicalDeviceFeatures);


				Interop.Commands.vkGetPhysicalDeviceFeatures(this.handle, &result);


				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public FormatProperties GetPhysicalDeviceFormatProperties(Format format)
		{
			unsafe
			{
				FormatProperties result = default(FormatProperties);


				Interop.Commands.vkGetPhysicalDeviceFormatProperties(this.handle, format, &result);


				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public ImageFormatProperties GetPhysicalDeviceImageFormatProperties(Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags)
		{
			unsafe
			{
				ImageFormatProperties result = default(ImageFormatProperties);


				Interop.Commands.vkGetPhysicalDeviceImageFormatProperties(this.handle, format, type, tiling, usage, flags, &result);


				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public PhysicalDeviceProperties GetPhysicalDeviceProperties()
		{
			unsafe
			{
				PhysicalDeviceProperties result = default(PhysicalDeviceProperties);

				Interop.PhysicalDeviceProperties marshalledProperties;

				Interop.Commands.vkGetPhysicalDeviceProperties(this.handle, &marshalledProperties);

				result = PhysicalDeviceProperties.MarshalFrom(&marshalledProperties);

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public QueueFamilyProperties[] GetPhysicalDeviceQueueFamilyProperties()
		{
			unsafe
			{
				QueueFamilyProperties[] result = default(QueueFamilyProperties[]);

				uint queueFamilyPropertyCount;
				QueueFamilyProperties* marshalledQueueFamilyProperties = null;
				Interop.Commands.vkGetPhysicalDeviceQueueFamilyProperties(this.handle, &queueFamilyPropertyCount, null);

				marshalledQueueFamilyProperties = (QueueFamilyProperties*)Interop.HeapUtil.Allocate<QueueFamilyProperties>(queueFamilyPropertyCount);

				Interop.Commands.vkGetPhysicalDeviceQueueFamilyProperties(this.handle, &queueFamilyPropertyCount, marshalledQueueFamilyProperties);

				result = new QueueFamilyProperties[queueFamilyPropertyCount];
				for(int index = 0; index < queueFamilyPropertyCount; index++)
				{
					result[index] = marshalledQueueFamilyProperties[index];
				}

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public PhysicalDeviceMemoryProperties GetPhysicalDeviceMemoryProperties()
		{
			unsafe
			{
				PhysicalDeviceMemoryProperties result = default(PhysicalDeviceMemoryProperties);

				Interop.PhysicalDeviceMemoryProperties marshalledMemoryProperties;

				Interop.Commands.vkGetPhysicalDeviceMemoryProperties(this.handle, &marshalledMemoryProperties);

				result = PhysicalDeviceMemoryProperties.MarshalFrom(&marshalledMemoryProperties);

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public Device CreateDevice(DeviceCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				Device result = default(Device);

				Interop.DeviceCreateInfo marshalledCreateInfo;
				if(createInfo != null) marshalledCreateInfo = createInfo.Pack();
				Interop.AllocationCallbacks marshalledAllocator;
				if(allocator != null) marshalledAllocator = allocator.Pack();
				Interop.Device marshalledDevice;

				Interop.Commands.vkCreateDevice(this.handle, createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledDevice);

				result = new Device(marshalledDevice, this);

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public ExtensionProperties[] EnumerateDeviceExtensionProperties(string layerName)
		{
			unsafe
			{
				ExtensionProperties[] result = default(ExtensionProperties[]);

				char* marshalledLayerName = Interop.HeapUtil.MarshalTo(layerName);
				uint propertyCount;
				Interop.ExtensionProperties* marshalledProperties = null;
				Interop.Commands.vkEnumerateDeviceExtensionProperties(this.handle, marshalledLayerName, &propertyCount, null);

				marshalledProperties = (Interop.ExtensionProperties*)Interop.HeapUtil.Allocate<Interop.ExtensionProperties>(propertyCount);

				Interop.Commands.vkEnumerateDeviceExtensionProperties(this.handle, marshalledLayerName, &propertyCount, marshalledProperties);

				result = new ExtensionProperties[propertyCount];
				for(int index = 0; index < propertyCount; index++)
				{
					result[index] = ExtensionProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public LayerProperties[] EnumerateDeviceLayerProperties()
		{
			unsafe
			{
				LayerProperties[] result = default(LayerProperties[]);

				uint propertyCount;
				Interop.LayerProperties* marshalledProperties = null;
				Interop.Commands.vkEnumerateDeviceLayerProperties(this.handle, &propertyCount, null);

				marshalledProperties = (Interop.LayerProperties*)Interop.HeapUtil.Allocate<Interop.LayerProperties>(propertyCount);

				Interop.Commands.vkEnumerateDeviceLayerProperties(this.handle, &propertyCount, marshalledProperties);

				result = new LayerProperties[propertyCount];
				for(int index = 0; index < propertyCount; index++)
				{
					result[index] = LayerProperties.MarshalFrom(&marshalledProperties[index]);
				}

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		public SparseImageFormatProperties[] GetPhysicalDeviceSparseImageFormatProperties(Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling)
		{
			unsafe
			{
				SparseImageFormatProperties[] result = default(SparseImageFormatProperties[]);

				uint propertyCount;
				SparseImageFormatProperties* marshalledProperties = null;
				Interop.Commands.vkGetPhysicalDeviceSparseImageFormatProperties(this.handle, format, type, samples, usage, tiling, &propertyCount, null);

				marshalledProperties = (SparseImageFormatProperties*)Interop.HeapUtil.Allocate<SparseImageFormatProperties>(propertyCount);

				Interop.Commands.vkGetPhysicalDeviceSparseImageFormatProperties(this.handle, format, type, samples, usage, tiling, &propertyCount, marshalledProperties);

				result = new SparseImageFormatProperties[propertyCount];
				for(int index = 0; index < propertyCount; index++)
				{
					result[index] = marshalledProperties[index];
				}

				Interop.HeapUtil.FreeLog();

				return result;
			}
		}

		internal Interop.PhysicalDevice Pack()
		{
			return this.handle;
		}
	}

	public class Queue
	{
		internal readonly Interop.Queue handle;

		private readonly Device parent;

		internal Queue(Interop.Queue handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		public void QueueSubmit(SubmitInfo[] submits, Fence fence)
		{
			unsafe
			{
				Interop.Fence marshalledFence = fence?.Pack() ?? Interop.Fence.Null;

				Interop.Commands.vkQueueSubmit(this.handle, (uint)submits.Length, null, marshalledFence);


				Interop.HeapUtil.FreeLog();
			}
		}

		public void QueueWaitIdle()
		{
			unsafe
			{

				Interop.Commands.vkQueueWaitIdle(this.handle);


				Interop.HeapUtil.FreeLog();
			}
		}

		public void QueueBindSparse(BindSparseInfo[] bindInfo, Fence fence)
		{
			unsafe
			{
				Interop.Fence marshalledFence = fence?.Pack() ?? Interop.Fence.Null;

				Interop.Commands.vkQueueBindSparse(this.handle, (uint)bindInfo.Length, null, marshalledFence);


				Interop.HeapUtil.FreeLog();
			}
		}

		internal Interop.Queue Pack()
		{
			return this.handle;
		}
	}

	public class Semaphore
	{
		internal readonly Interop.Semaphore handle;

		private readonly Device parent;

		internal Semaphore(Interop.Semaphore handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		internal Interop.Semaphore Pack()
		{
			return this.handle;
		}
	}

}