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
		private readonly Interop.Buffer handle;

		private readonly Device parent;

		internal Buffer(Interop.Buffer handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		internal Interop.Buffer MarshalTo()
		{
			return this.handle;
		}
	}

	public class Device
	{
		private readonly Interop.Device handle;

		private readonly PhysicalDevice parent;

		internal Device(Interop.Device handle, PhysicalDevice parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		internal Interop.Device MarshalTo()
		{
			return this.handle;
		}
	}

	public class Image
	{
		private readonly Interop.Image handle;

		private readonly Device parent;

		internal Image(Interop.Image handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}

		internal Interop.Image MarshalTo()
		{
			return this.handle;
		}
	}

	public class Instance
	{
		private readonly Interop.Instance handle;

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

		internal Interop.Instance MarshalTo()
		{
			return this.handle;
		}
	}

	public class PhysicalDevice
	{
		private readonly Interop.PhysicalDevice handle;

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

		internal Interop.PhysicalDevice MarshalTo()
		{
			return this.handle;
		}
	}

}