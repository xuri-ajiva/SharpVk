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

	internal static class BufferExtensions
	{
		internal unsafe static Interop.Buffer* MarshalTo(this Buffer[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class BufferView
	{
		private readonly Interop.BufferView handle;

		private readonly Device parent;

		internal BufferView(Interop.BufferView handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.BufferView MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class BufferViewExtensions
	{
		internal unsafe static Interop.BufferView* MarshalTo(this BufferView[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class CommandBuffer
	{
		private readonly Interop.CommandBuffer handle;

		private readonly CommandPool parent;

		internal CommandBuffer(Interop.CommandBuffer handle, CommandPool parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.CommandBuffer MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class CommandBufferExtensions
	{
		internal unsafe static Interop.CommandBuffer* MarshalTo(this CommandBuffer[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class CommandPool
	{
		private readonly Interop.CommandPool handle;

		private readonly Device parent;

		internal CommandPool(Interop.CommandPool handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.CommandPool MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class CommandPoolExtensions
	{
		internal unsafe static Interop.CommandPool* MarshalTo(this CommandPool[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class DescriptorPool
	{
		private readonly Interop.DescriptorPool handle;

		private readonly Device parent;

		internal DescriptorPool(Interop.DescriptorPool handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.DescriptorPool MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class DescriptorPoolExtensions
	{
		internal unsafe static Interop.DescriptorPool* MarshalTo(this DescriptorPool[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class DescriptorSet
	{
		private readonly Interop.DescriptorSet handle;

		private readonly DescriptorPool parent;

		internal DescriptorSet(Interop.DescriptorSet handle, DescriptorPool parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.DescriptorSet MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class DescriptorSetExtensions
	{
		internal unsafe static Interop.DescriptorSet* MarshalTo(this DescriptorSet[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class DescriptorSetLayout
	{
		private readonly Interop.DescriptorSetLayout handle;

		private readonly Device parent;

		internal DescriptorSetLayout(Interop.DescriptorSetLayout handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.DescriptorSetLayout MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class DescriptorSetLayoutExtensions
	{
		internal unsafe static Interop.DescriptorSetLayout* MarshalTo(this DescriptorSetLayout[] values)
		{
			throw new NotImplementedException();
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

	internal static class DeviceExtensions
	{
		internal unsafe static Interop.Device* MarshalTo(this Device[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class DeviceMemory
	{
		private readonly Interop.DeviceMemory handle;

		private readonly Device parent;

		internal DeviceMemory(Interop.DeviceMemory handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.DeviceMemory MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class DeviceMemoryExtensions
	{
		internal unsafe static Interop.DeviceMemory* MarshalTo(this DeviceMemory[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class Event
	{
		private readonly Interop.Event handle;

		private readonly Device parent;

		internal Event(Interop.Event handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.Event MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class EventExtensions
	{
		internal unsafe static Interop.Event* MarshalTo(this Event[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class Fence
	{
		private readonly Interop.Fence handle;

		private readonly Device parent;

		internal Fence(Interop.Fence handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.Fence MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class FenceExtensions
	{
		internal unsafe static Interop.Fence* MarshalTo(this Fence[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class Framebuffer
	{
		private readonly Interop.Framebuffer handle;

		private readonly Device parent;

		internal Framebuffer(Interop.Framebuffer handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.Framebuffer MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class FramebufferExtensions
	{
		internal unsafe static Interop.Framebuffer* MarshalTo(this Framebuffer[] values)
		{
			throw new NotImplementedException();
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

	internal static class ImageExtensions
	{
		internal unsafe static Interop.Image* MarshalTo(this Image[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class ImageView
	{
		private readonly Interop.ImageView handle;

		private readonly Device parent;

		internal ImageView(Interop.ImageView handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.ImageView MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class ImageViewExtensions
	{
		internal unsafe static Interop.ImageView* MarshalTo(this ImageView[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class Instance
	{
		private readonly Interop.Instance handle;

		internal Instance(Interop.Instance handle)
		{
			this.handle = handle;
		}
		internal Interop.Instance MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class InstanceExtensions
	{
		internal unsafe static Interop.Instance* MarshalTo(this Instance[] values)
		{
			throw new NotImplementedException();
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
		internal Interop.PhysicalDevice MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class PhysicalDeviceExtensions
	{
		internal unsafe static Interop.PhysicalDevice* MarshalTo(this PhysicalDevice[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class Pipeline
	{
		private readonly Interop.Pipeline handle;

		private readonly Device parent;

		internal Pipeline(Interop.Pipeline handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.Pipeline MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class PipelineExtensions
	{
		internal unsafe static Interop.Pipeline* MarshalTo(this Pipeline[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineCache
	{
		private readonly Interop.PipelineCache handle;

		private readonly Device parent;

		internal PipelineCache(Interop.PipelineCache handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.PipelineCache MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class PipelineCacheExtensions
	{
		internal unsafe static Interop.PipelineCache* MarshalTo(this PipelineCache[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineLayout
	{
		private readonly Interop.PipelineLayout handle;

		private readonly Device parent;

		internal PipelineLayout(Interop.PipelineLayout handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.PipelineLayout MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class PipelineLayoutExtensions
	{
		internal unsafe static Interop.PipelineLayout* MarshalTo(this PipelineLayout[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class QueryPool
	{
		private readonly Interop.QueryPool handle;

		private readonly Device parent;

		internal QueryPool(Interop.QueryPool handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.QueryPool MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class QueryPoolExtensions
	{
		internal unsafe static Interop.QueryPool* MarshalTo(this QueryPool[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class Queue
	{
		private readonly Interop.Queue handle;

		private readonly Device parent;

		internal Queue(Interop.Queue handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.Queue MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class QueueExtensions
	{
		internal unsafe static Interop.Queue* MarshalTo(this Queue[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class RenderPass
	{
		private readonly Interop.RenderPass handle;

		private readonly Device parent;

		internal RenderPass(Interop.RenderPass handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.RenderPass MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class RenderPassExtensions
	{
		internal unsafe static Interop.RenderPass* MarshalTo(this RenderPass[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class Sampler
	{
		private readonly Interop.Sampler handle;

		private readonly Device parent;

		internal Sampler(Interop.Sampler handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.Sampler MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class SamplerExtensions
	{
		internal unsafe static Interop.Sampler* MarshalTo(this Sampler[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class Semaphore
	{
		private readonly Interop.Semaphore handle;

		private readonly Device parent;

		internal Semaphore(Interop.Semaphore handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.Semaphore MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class SemaphoreExtensions
	{
		internal unsafe static Interop.Semaphore* MarshalTo(this Semaphore[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class ShaderModule
	{
		private readonly Interop.ShaderModule handle;

		private readonly Device parent;

		internal ShaderModule(Interop.ShaderModule handle, Device parent)
		{
			this.handle = handle;
			this.parent = parent;
		}
		internal Interop.ShaderModule MarshalTo()
		{
			return this.handle;
		}
	}

	internal static class ShaderModuleExtensions
	{
		internal unsafe static Interop.ShaderModule* MarshalTo(this ShaderModule[] values)
		{
			throw new NotImplementedException();
		}
	}

}