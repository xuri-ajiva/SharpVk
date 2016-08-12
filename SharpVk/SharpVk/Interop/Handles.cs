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
	public struct Buffer
	{
		internal ulong handle;

		public static Buffer Null
		{
			get
			{
				return new Buffer
                {
                    handle = 0L
                };
			}
		}
	}

	public struct BufferView
	{
		internal ulong handle;

		public static BufferView Null
		{
			get
			{
				return new BufferView
                {
                    handle = 0L
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
		internal ulong handle;

		public static CommandPool Null
		{
			get
			{
				return new CommandPool
                {
                    handle = 0L
                };
			}
		}
	}

	public struct DescriptorPool
	{
		internal ulong handle;

		public static DescriptorPool Null
		{
			get
			{
				return new DescriptorPool
                {
                    handle = 0L
                };
			}
		}
	}

	public struct DescriptorSet
	{
		internal ulong handle;

		public static DescriptorSet Null
		{
			get
			{
				return new DescriptorSet
                {
                    handle = 0L
                };
			}
		}
	}

	public struct DescriptorSetLayout
	{
		internal ulong handle;

		public static DescriptorSetLayout Null
		{
			get
			{
				return new DescriptorSetLayout
                {
                    handle = 0L
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
		internal ulong handle;

		public static DeviceMemory Null
		{
			get
			{
				return new DeviceMemory
                {
                    handle = 0L
                };
			}
		}
	}

	public struct Event
	{
		internal ulong handle;

		public static Event Null
		{
			get
			{
				return new Event
                {
                    handle = 0L
                };
			}
		}
	}

	public struct Fence
	{
		internal ulong handle;

		public static Fence Null
		{
			get
			{
				return new Fence
                {
                    handle = 0L
                };
			}
		}
	}

	public struct Framebuffer
	{
		internal ulong handle;

		public static Framebuffer Null
		{
			get
			{
				return new Framebuffer
                {
                    handle = 0L
                };
			}
		}
	}

	public struct Image
	{
		internal ulong handle;

		public static Image Null
		{
			get
			{
				return new Image
                {
                    handle = 0L
                };
			}
		}
	}

	public struct ImageView
	{
		internal ulong handle;

		public static ImageView Null
		{
			get
			{
				return new ImageView
                {
                    handle = 0L
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
		internal ulong handle;

		public static Pipeline Null
		{
			get
			{
				return new Pipeline
                {
                    handle = 0L
                };
			}
		}
	}

	public struct PipelineCache
	{
		internal ulong handle;

		public static PipelineCache Null
		{
			get
			{
				return new PipelineCache
                {
                    handle = 0L
                };
			}
		}
	}

	public struct PipelineLayout
	{
		internal ulong handle;

		public static PipelineLayout Null
		{
			get
			{
				return new PipelineLayout
                {
                    handle = 0L
                };
			}
		}
	}

	public struct QueryPool
	{
		internal ulong handle;

		public static QueryPool Null
		{
			get
			{
				return new QueryPool
                {
                    handle = 0L
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
		internal ulong handle;

		public static RenderPass Null
		{
			get
			{
				return new RenderPass
                {
                    handle = 0L
                };
			}
		}
	}

	public struct Sampler
	{
		internal ulong handle;

		public static Sampler Null
		{
			get
			{
				return new Sampler
                {
                    handle = 0L
                };
			}
		}
	}

	public struct Semaphore
	{
		internal ulong handle;

		public static Semaphore Null
		{
			get
			{
				return new Semaphore
                {
                    handle = 0L
                };
			}
		}
	}

	public struct ShaderModule
	{
		internal ulong handle;

		public static ShaderModule Null
		{
			get
			{
				return new ShaderModule
                {
                    handle = 0L
                };
			}
		}
	}

	public struct Surface
	{
		internal ulong handle;

		public static Surface Null
		{
			get
			{
				return new Surface
                {
                    handle = 0L
                };
			}
		}
	}

	public struct Swapchain
	{
		internal ulong handle;

		public static Swapchain Null
		{
			get
			{
				return new Swapchain
                {
                    handle = 0L
                };
			}
		}
	}

}