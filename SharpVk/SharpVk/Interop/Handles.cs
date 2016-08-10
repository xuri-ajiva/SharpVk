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

namespace SharpVk.Interop
{
	public struct Buffer
	{
		internal IntPtr handle;

		public static Buffer Null
		{
			get
			{
				return new Buffer
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct BufferView
	{
		internal IntPtr handle;

		public static BufferView Null
		{
			get
			{
				return new BufferView
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct CommandBuffer
	{
		internal IntPtr handle;

		public static CommandBuffer Null
		{
			get
			{
				return new CommandBuffer
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct CommandPool
	{
		internal IntPtr handle;

		public static CommandPool Null
		{
			get
			{
				return new CommandPool
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct DescriptorSetLayout
	{
		internal IntPtr handle;

		public static DescriptorSetLayout Null
		{
			get
			{
				return new DescriptorSetLayout
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Device
	{
		internal IntPtr handle;

		public static Device Null
		{
			get
			{
				return new Device
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct DeviceMemory
	{
		internal IntPtr handle;

		public static DeviceMemory Null
		{
			get
			{
				return new DeviceMemory
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Event
	{
		internal IntPtr handle;

		public static Event Null
		{
			get
			{
				return new Event
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Fence
	{
		internal IntPtr handle;

		public static Fence Null
		{
			get
			{
				return new Fence
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Image
	{
		internal IntPtr handle;

		public static Image Null
		{
			get
			{
				return new Image
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct ImageView
	{
		internal IntPtr handle;

		public static ImageView Null
		{
			get
			{
				return new ImageView
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Instance
	{
		internal IntPtr handle;

		public static Instance Null
		{
			get
			{
				return new Instance
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct PhysicalDevice
	{
		internal IntPtr handle;

		public static PhysicalDevice Null
		{
			get
			{
				return new PhysicalDevice
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Pipeline
	{
		internal IntPtr handle;

		public static Pipeline Null
		{
			get
			{
				return new Pipeline
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct PipelineCache
	{
		internal IntPtr handle;

		public static PipelineCache Null
		{
			get
			{
				return new PipelineCache
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct PipelineLayout
	{
		internal IntPtr handle;

		public static PipelineLayout Null
		{
			get
			{
				return new PipelineLayout
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct QueryPool
	{
		internal IntPtr handle;

		public static QueryPool Null
		{
			get
			{
				return new QueryPool
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Queue
	{
		internal IntPtr handle;

		public static Queue Null
		{
			get
			{
				return new Queue
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct RenderPass
	{
		internal IntPtr handle;

		public static RenderPass Null
		{
			get
			{
				return new RenderPass
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Semaphore
	{
		internal IntPtr handle;

		public static Semaphore Null
		{
			get
			{
				return new Semaphore
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct ShaderModule
	{
		internal IntPtr handle;

		public static ShaderModule Null
		{
			get
			{
				return new ShaderModule
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Surface
	{
		internal IntPtr handle;

		public static Surface Null
		{
			get
			{
				return new Surface
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

	public struct Swapchain
	{
		internal IntPtr handle;

		public static Swapchain Null
		{
			get
			{
				return new Swapchain
                {
                    handle = IntPtr.Zero
                };
			}
		}
	}

}