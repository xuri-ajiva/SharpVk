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


namespace SharpVk
{
	public class Instance
	{
		private Interop.Instance handle;

		public Instance(InstanceCreateInfo createInfo, AllocationCallbacks allocator)
		{
			unsafe
			{
				Interop.Instance newHandle;
				var marshalledCreateInfo = (createInfo?.MarshalTo()).GetValueOrDefault();
				var marshalledAllocator = (allocator?.MarshalTo()).GetValueOrDefault();
				Result createResult = Interop.Commands.vkCreateInstance(createInfo == null ? null : &marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &newHandle);

				ResultUtil.HandleResult(createResult);

				this.handle = newHandle;
			}
		}
	}

	public class PhysicalDevice
	{
		private Interop.PhysicalDevice handle;

		internal PhysicalDevice(Interop.PhysicalDevice handle)
		{
			this.handle = handle;
		}
	}

	public class Device
	{
		private Interop.Device handle;

		internal Device(Interop.Device handle)
		{
			this.handle = handle;
		}
	}

	public class Queue
	{
		private Interop.Queue handle;

		internal Queue(Interop.Queue handle)
		{
			this.handle = handle;
		}
	}

	public class CommandBuffer
	{
		private Interop.CommandBuffer handle;

		internal CommandBuffer(Interop.CommandBuffer handle)
		{
			this.handle = handle;
		}
	}

	public class DeviceMemory
	{
		private Interop.DeviceMemory handle;

		internal DeviceMemory(Interop.DeviceMemory handle)
		{
			this.handle = handle;
		}
	}

	public class CommandPool
	{
		private Interop.CommandPool handle;

		internal CommandPool(Interop.CommandPool handle)
		{
			this.handle = handle;
		}
	}

	public class Buffer
	{
		private Interop.Buffer handle;

		internal Buffer(Interop.Buffer handle)
		{
			this.handle = handle;
		}
	}

	public class BufferView
	{
		private Interop.BufferView handle;

		internal BufferView(Interop.BufferView handle)
		{
			this.handle = handle;
		}
	}

	public class Image
	{
		private Interop.Image handle;

		internal Image(Interop.Image handle)
		{
			this.handle = handle;
		}
	}

	public class ImageView
	{
		private Interop.ImageView handle;

		internal ImageView(Interop.ImageView handle)
		{
			this.handle = handle;
		}
	}

	public class ShaderModule
	{
		private Interop.ShaderModule handle;

		internal ShaderModule(Interop.ShaderModule handle)
		{
			this.handle = handle;
		}
	}

	public class Pipeline
	{
		private Interop.Pipeline handle;

		internal Pipeline(Interop.Pipeline handle)
		{
			this.handle = handle;
		}
	}

	public class PipelineLayout
	{
		private Interop.PipelineLayout handle;

		internal PipelineLayout(Interop.PipelineLayout handle)
		{
			this.handle = handle;
		}
	}

	public class Sampler
	{
		private Interop.Sampler handle;

		internal Sampler(Interop.Sampler handle)
		{
			this.handle = handle;
		}
	}

	public class DescriptorSet
	{
		private Interop.DescriptorSet handle;

		internal DescriptorSet(Interop.DescriptorSet handle)
		{
			this.handle = handle;
		}
	}

	public class DescriptorSetLayout
	{
		private Interop.DescriptorSetLayout handle;

		internal DescriptorSetLayout(Interop.DescriptorSetLayout handle)
		{
			this.handle = handle;
		}
	}

	public class DescriptorPool
	{
		private Interop.DescriptorPool handle;

		internal DescriptorPool(Interop.DescriptorPool handle)
		{
			this.handle = handle;
		}
	}

	public class Fence
	{
		private Interop.Fence handle;

		internal Fence(Interop.Fence handle)
		{
			this.handle = handle;
		}
	}

	public class Semaphore
	{
		private Interop.Semaphore handle;

		internal Semaphore(Interop.Semaphore handle)
		{
			this.handle = handle;
		}
	}

	public class Event
	{
		private Interop.Event handle;

		internal Event(Interop.Event handle)
		{
			this.handle = handle;
		}
	}

	public class QueryPool
	{
		private Interop.QueryPool handle;

		internal QueryPool(Interop.QueryPool handle)
		{
			this.handle = handle;
		}
	}

	public class Framebuffer
	{
		private Interop.Framebuffer handle;

		internal Framebuffer(Interop.Framebuffer handle)
		{
			this.handle = handle;
		}
	}

	public class RenderPass
	{
		private Interop.RenderPass handle;

		internal RenderPass(Interop.RenderPass handle)
		{
			this.handle = handle;
		}
	}

	public class PipelineCache
	{
		private Interop.PipelineCache handle;

		internal PipelineCache(Interop.PipelineCache handle)
		{
			this.handle = handle;
		}
	}

	public class DisplayKHR
	{
		private Interop.DisplayKHR handle;

		internal DisplayKHR(Interop.DisplayKHR handle)
		{
			this.handle = handle;
		}
	}

	public class DisplayModeKHR
	{
		private Interop.DisplayModeKHR handle;

		internal DisplayModeKHR(Interop.DisplayModeKHR handle)
		{
			this.handle = handle;
		}
	}

	public class SurfaceKHR
	{
		private Interop.SurfaceKHR handle;

		internal SurfaceKHR(Interop.SurfaceKHR handle)
		{
			this.handle = handle;
		}
	}

	public class SwapchainKHR
	{
		private Interop.SwapchainKHR handle;

		internal SwapchainKHR(Interop.SwapchainKHR handle)
		{
			this.handle = handle;
		}
	}

	public class DebugReportCallbackEXT
	{
		private Interop.DebugReportCallbackEXT handle;

		internal DebugReportCallbackEXT(Interop.DebugReportCallbackEXT handle)
		{
			this.handle = handle;
		}
	}

}