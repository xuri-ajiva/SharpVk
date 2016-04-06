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
	}

	public class Device
	{
		private Interop.Device handle;
	}

	public class Queue
	{
		private Interop.Queue handle;
	}

	public class CommandBuffer
	{
		private Interop.CommandBuffer handle;
	}

	public class DeviceMemory
	{
		private Interop.DeviceMemory handle;
	}

	public class CommandPool
	{
		private Interop.CommandPool handle;
	}

	public class Buffer
	{
		private Interop.Buffer handle;
	}

	public class BufferView
	{
		private Interop.BufferView handle;
	}

	public class Image
	{
		private Interop.Image handle;
	}

	public class ImageView
	{
		private Interop.ImageView handle;
	}

	public class ShaderModule
	{
		private Interop.ShaderModule handle;
	}

	public class Pipeline
	{
		private Interop.Pipeline handle;
	}

	public class PipelineLayout
	{
		private Interop.PipelineLayout handle;
	}

	public class Sampler
	{
		private Interop.Sampler handle;
	}

	public class DescriptorSet
	{
		private Interop.DescriptorSet handle;
	}

	public class DescriptorSetLayout
	{
		private Interop.DescriptorSetLayout handle;
	}

	public class DescriptorPool
	{
		private Interop.DescriptorPool handle;
	}

	public class Fence
	{
		private Interop.Fence handle;
	}

	public class Semaphore
	{
		private Interop.Semaphore handle;
	}

	public class Event
	{
		private Interop.Event handle;
	}

	public class QueryPool
	{
		private Interop.QueryPool handle;
	}

	public class Framebuffer
	{
		private Interop.Framebuffer handle;
	}

	public class RenderPass
	{
		private Interop.RenderPass handle;
	}

	public class PipelineCache
	{
		private Interop.PipelineCache handle;
	}

	public class DisplayKHR
	{
		private Interop.DisplayKHR handle;
	}

	public class DisplayModeKHR
	{
		private Interop.DisplayModeKHR handle;
	}

	public class SurfaceKHR
	{
		private Interop.SurfaceKHR handle;
	}

	public class SwapchainKHR
	{
		private Interop.SwapchainKHR handle;
	}

	public class DebugReportCallbackEXT
	{
		private Interop.DebugReportCallbackEXT handle;
	}

}