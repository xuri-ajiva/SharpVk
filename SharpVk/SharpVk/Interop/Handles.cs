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
	/// -
	/// </summary>
	public struct Buffer
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null Buffer handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct BufferView
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null BufferView handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct CommandBuffer
	{
		internal IntPtr handle;
		
		/// <summary>
		/// Returns a value representing a null CommandBuffer handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct CommandPool
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null CommandPool handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct DebugReportCallback
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null DebugReportCallback handle.
		/// </summary>
		public static DebugReportCallback Null
		{
			get
			{
				return new DebugReportCallback
                {
                    handle = 0L
                };
			}
		}
	}

	/// <summary>
	/// -
	/// </summary>
	public struct DescriptorPool
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null DescriptorPool handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct DescriptorSet
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null DescriptorSet handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct DescriptorSetLayout
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null DescriptorSetLayout handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct Device
	{
		internal IntPtr handle;
		
		/// <summary>
		/// Returns a value representing a null Device handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct DeviceMemory
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null DeviceMemory handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct Display
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null Display handle.
		/// </summary>
		public static Display Null
		{
			get
			{
				return new Display
                {
                    handle = 0L
                };
			}
		}
	}

	/// <summary>
	/// -
	/// </summary>
	public struct DisplayMode
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null DisplayMode handle.
		/// </summary>
		public static DisplayMode Null
		{
			get
			{
				return new DisplayMode
                {
                    handle = 0L
                };
			}
		}
	}

	/// <summary>
	/// -
	/// </summary>
	public struct Event
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null Event handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct Fence
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null Fence handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct Framebuffer
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null Framebuffer handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct Image
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null Image handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct ImageView
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null ImageView handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct Instance
	{
		internal IntPtr handle;
		
		/// <summary>
		/// Returns a value representing a null Instance handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct PhysicalDevice
	{
		internal IntPtr handle;
		
		/// <summary>
		/// Returns a value representing a null PhysicalDevice handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct Pipeline
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null Pipeline handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct PipelineCache
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null PipelineCache handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct PipelineLayout
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null PipelineLayout handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct QueryPool
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null QueryPool handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct Queue
	{
		internal IntPtr handle;
		
		/// <summary>
		/// Returns a value representing a null Queue handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct RenderPass
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null RenderPass handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct Sampler
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null Sampler handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct Semaphore
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null Semaphore handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct ShaderModule
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null ShaderModule handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct Surface
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null Surface handle.
		/// </summary>
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

	/// <summary>
	/// -
	/// </summary>
	public struct Swapchain
	{
		internal ulong handle;
		
		/// <summary>
		/// Returns a value representing a null Swapchain handle.
		/// </summary>
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