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
	public class Buffer
	{
		internal readonly Interop.Buffer handle;

		private readonly Device parent;

		internal Buffer(Interop.Buffer handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
	}

	public class BufferView
	{
		internal readonly Interop.BufferView handle;

		private readonly Device parent;

		internal BufferView(Interop.BufferView handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
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
	}

	public class DescriptorPool
	{
		internal readonly Interop.DescriptorPool handle;

		private readonly Device parent;

		internal DescriptorPool(Interop.DescriptorPool handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
	}

	public class DescriptorSet
	{
		internal readonly Interop.DescriptorSet handle;

		private readonly DescriptorPool parent;

		internal DescriptorSet(Interop.DescriptorSet handle, DescriptorPool parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
	}

	public class DescriptorSetLayout
	{
		internal readonly Interop.DescriptorSetLayout handle;

		private readonly Device parent;

		internal DescriptorSetLayout(Interop.DescriptorSetLayout handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
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
	}

	public class Event
	{
		internal readonly Interop.Event handle;

		private readonly Device parent;

		internal Event(Interop.Event handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
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
	}

	public class Framebuffer
	{
		internal readonly Interop.Framebuffer handle;

		private readonly Device parent;

		internal Framebuffer(Interop.Framebuffer handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
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
	}

	public class ImageView
	{
		internal readonly Interop.ImageView handle;

		private readonly Device parent;

		internal ImageView(Interop.ImageView handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
	}

	public class Instance
	{
		internal readonly Interop.Instance handle;

		internal Instance(Interop.Instance handle)
		{
			this.handle = handle;
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
	}

	public class Pipeline
	{
		internal readonly Interop.Pipeline handle;

		private readonly Device parent;

		internal Pipeline(Interop.Pipeline handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
	}

	public class PipelineCache
	{
		internal readonly Interop.PipelineCache handle;

		private readonly Device parent;

		internal PipelineCache(Interop.PipelineCache handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
	}

	public class PipelineLayout
	{
		internal readonly Interop.PipelineLayout handle;

		private readonly Device parent;

		internal PipelineLayout(Interop.PipelineLayout handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
	}

	public class QueryPool
	{
		internal readonly Interop.QueryPool handle;

		private readonly Device parent;

		internal QueryPool(Interop.QueryPool handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
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
	}

	public class RenderPass
	{
		internal readonly Interop.RenderPass handle;

		private readonly Device parent;

		internal RenderPass(Interop.RenderPass handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
	}

	public class Sampler
	{
		internal readonly Interop.Sampler handle;

		private readonly Device parent;

		internal Sampler(Interop.Sampler handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
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
	}

	public class ShaderModule
	{
		internal readonly Interop.ShaderModule handle;

		private readonly Device parent;

		internal ShaderModule(Interop.ShaderModule handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
	}

}