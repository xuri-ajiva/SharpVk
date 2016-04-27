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

namespace SharpVk
{
	internal unsafe static class MarshalExtensions
	{
        internal static void* MarshalTo(this IntPtr value)
        {
            return value.ToPointer();
        }

        internal static char* MarshalTo(this string value)
        {
            return Interop.HeapUtil.MarshalStringToPointer(value);
        }

        internal static char** MarshalTo(this string[] value)
        {
			throw new NotImplementedException();
        }

        internal static SampleMask* MarshalTo(this SampleMask[] value)
        {
			throw new NotImplementedException();
        }

        internal static uint* MarshalTo(this uint[] values)
		{
            return Interop.HeapUtil.MarshalArrayToPointer(values);
		}

        internal static float* MarshalTo(this float[] values)
		{
            return Interop.HeapUtil.MarshalArrayToPointer(values);
		}

        internal static byte* MarshalTo(this byte[] values)
		{
            return Interop.HeapUtil.MarshalArrayToPointer(values);
		}
	}

	public class AllocationCallbacks
	{
		public IntPtr UserData
		{
			get;
			set;
		}

        internal unsafe Interop.AllocationCallbacks Pack()
        {
            var result = new Interop.AllocationCallbacks();
			result.UserData = this.UserData.MarshalTo();

            return result;
        }

		internal unsafe Interop.AllocationCallbacks* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.AllocationCallbacks>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.AllocationCallbacks*)pointer.ToPointer();
		}
	}

	internal static class AllocationCallbacksExtensions
	{
		internal unsafe static Interop.AllocationCallbacks* MarshalTo(this AllocationCallbacks[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class ApplicationInfo
	{
		public string ApplicationName
		{
			get;
			set;
		}

		public uint ApplicationVersion
		{
			get;
			set;
		}

		public string EngineName
		{
			get;
			set;
		}

		public uint EngineVersion
		{
			get;
			set;
		}

		public uint ApiVersion
		{
			get;
			set;
		}

        internal unsafe Interop.ApplicationInfo Pack()
        {
            var result = new Interop.ApplicationInfo();
			result.ApplicationName = this.ApplicationName.MarshalTo();
			result.ApplicationVersion = this.ApplicationVersion;
			result.EngineName = this.EngineName.MarshalTo();
			result.EngineVersion = this.EngineVersion;
			result.ApiVersion = this.ApiVersion;

            return result;
        }

		internal unsafe Interop.ApplicationInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.ApplicationInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.ApplicationInfo*)pointer.ToPointer();
		}
	}

	internal static class ApplicationInfoExtensions
	{
		internal unsafe static Interop.ApplicationInfo* MarshalTo(this ApplicationInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class BindSparseInfo
	{
		public Semaphore[] WaitSemaphores
		{
			get;
			set;
		}

		public SparseBufferMemoryBindInfo[] BufferBinds
		{
			get;
			set;
		}

		public SparseImageOpaqueMemoryBindInfo[] ImageOpaqueBinds
		{
			get;
			set;
		}

		public SparseImageMemoryBindInfo[] ImageBinds
		{
			get;
			set;
		}

		public Semaphore[] SignalSemaphores
		{
			get;
			set;
		}

        internal unsafe Interop.BindSparseInfo Pack()
        {
            var result = new Interop.BindSparseInfo();
			result.WaitSemaphores = this.WaitSemaphores.MarshalTo();
			result.BufferBinds = this.BufferBinds.MarshalTo();
			result.ImageOpaqueBinds = this.ImageOpaqueBinds.MarshalTo();
			result.ImageBinds = this.ImageBinds.MarshalTo();
			result.SignalSemaphores = this.SignalSemaphores.MarshalTo();

            return result;
        }

		internal unsafe Interop.BindSparseInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.BindSparseInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.BindSparseInfo*)pointer.ToPointer();
		}
	}

	internal static class BindSparseInfoExtensions
	{
		internal unsafe static Interop.BindSparseInfo* MarshalTo(this BindSparseInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class BufferCreateInfo
	{
		public BufferCreateFlags Flags
		{
			get;
			set;
		}

		public DeviceSize Size
		{
			get;
			set;
		}

		public BufferUsageFlags Usage
		{
			get;
			set;
		}

		public SharingMode SharingMode
		{
			get;
			set;
		}

		public uint[] QueueFamilyIndices
		{
			get;
			set;
		}

        internal unsafe Interop.BufferCreateInfo Pack()
        {
            var result = new Interop.BufferCreateInfo();
			result.Flags = this.Flags;
			result.Size = this.Size;
			result.Usage = this.Usage;
			result.SharingMode = this.SharingMode;
			result.QueueFamilyIndices = this.QueueFamilyIndices.MarshalTo();

            return result;
        }

		internal unsafe Interop.BufferCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.BufferCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.BufferCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class BufferCreateInfoExtensions
	{
		internal unsafe static Interop.BufferCreateInfo* MarshalTo(this BufferCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class BufferMemoryBarrier
	{
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}

		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}

		public uint SourceQueueFamilyIndex
		{
			get;
			set;
		}

		public uint DestinationQueueFamilyIndex
		{
			get;
			set;
		}

		public Buffer Buffer
		{
			get;
			set;
		}

		public DeviceSize Offset
		{
			get;
			set;
		}

		public DeviceSize Size
		{
			get;
			set;
		}

        internal unsafe Interop.BufferMemoryBarrier Pack()
        {
            var result = new Interop.BufferMemoryBarrier();
			result.SourceAccessMask = this.SourceAccessMask;
			result.DestinationAccessMask = this.DestinationAccessMask;
			result.SourceQueueFamilyIndex = this.SourceQueueFamilyIndex;
			result.DestinationQueueFamilyIndex = this.DestinationQueueFamilyIndex;
			result.Buffer = this.Buffer.MarshalTo();
			result.Offset = this.Offset;
			result.Size = this.Size;

            return result;
        }

		internal unsafe Interop.BufferMemoryBarrier* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.BufferMemoryBarrier>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.BufferMemoryBarrier*)pointer.ToPointer();
		}
	}

	internal static class BufferMemoryBarrierExtensions
	{
		internal unsafe static Interop.BufferMemoryBarrier* MarshalTo(this BufferMemoryBarrier[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class BufferViewCreateInfo
	{
		public BufferViewCreateFlags Flags
		{
			get;
			set;
		}

		public Buffer Buffer
		{
			get;
			set;
		}

		public Format Format
		{
			get;
			set;
		}

		public DeviceSize Offset
		{
			get;
			set;
		}

		public DeviceSize Range
		{
			get;
			set;
		}

        internal unsafe Interop.BufferViewCreateInfo Pack()
        {
            var result = new Interop.BufferViewCreateInfo();
			result.Flags = this.Flags;
			result.Buffer = this.Buffer.MarshalTo();
			result.Format = this.Format;
			result.Offset = this.Offset;
			result.Range = this.Range;

            return result;
        }

		internal unsafe Interop.BufferViewCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.BufferViewCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.BufferViewCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class BufferViewCreateInfoExtensions
	{
		internal unsafe static Interop.BufferViewCreateInfo* MarshalTo(this BufferViewCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class CommandBufferAllocateInfo
	{
		public CommandPool CommandPool
		{
			get;
			set;
		}

		public CommandBufferLevel Level
		{
			get;
			set;
		}

		public uint CommandBufferCount
		{
			get;
			set;
		}

        internal unsafe Interop.CommandBufferAllocateInfo Pack()
        {
            var result = new Interop.CommandBufferAllocateInfo();
			result.CommandPool = this.CommandPool.MarshalTo();
			result.Level = this.Level;
			result.CommandBufferCount = this.CommandBufferCount;

            return result;
        }

		internal unsafe Interop.CommandBufferAllocateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.CommandBufferAllocateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.CommandBufferAllocateInfo*)pointer.ToPointer();
		}
	}

	internal static class CommandBufferAllocateInfoExtensions
	{
		internal unsafe static Interop.CommandBufferAllocateInfo* MarshalTo(this CommandBufferAllocateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class CommandBufferBeginInfo
	{
		public CommandBufferUsageFlags Flags
		{
			get;
			set;
		}

		public CommandBufferInheritanceInfo InheritanceInfo
		{
			get;
			set;
		}

        internal unsafe Interop.CommandBufferBeginInfo Pack()
        {
            var result = new Interop.CommandBufferBeginInfo();
			result.Flags = this.Flags;
			result.InheritanceInfo = this.InheritanceInfo.MarshalTo();

            return result;
        }

		internal unsafe Interop.CommandBufferBeginInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.CommandBufferBeginInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.CommandBufferBeginInfo*)pointer.ToPointer();
		}
	}

	internal static class CommandBufferBeginInfoExtensions
	{
		internal unsafe static Interop.CommandBufferBeginInfo* MarshalTo(this CommandBufferBeginInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class CommandBufferInheritanceInfo
	{
		public RenderPass RenderPass
		{
			get;
			set;
		}

		public uint Subpass
		{
			get;
			set;
		}

		public Framebuffer Framebuffer
		{
			get;
			set;
		}

		public Bool32 OcclusionQueryEnable
		{
			get;
			set;
		}

		public QueryControlFlags QueryFlags
		{
			get;
			set;
		}

		public QueryPipelineStatisticFlags PipelineStatistics
		{
			get;
			set;
		}

        internal unsafe Interop.CommandBufferInheritanceInfo Pack()
        {
            var result = new Interop.CommandBufferInheritanceInfo();
			result.RenderPass = this.RenderPass.MarshalTo();
			result.Subpass = this.Subpass;
			result.Framebuffer = this.Framebuffer.MarshalTo();
			result.OcclusionQueryEnable = this.OcclusionQueryEnable;
			result.QueryFlags = this.QueryFlags;
			result.PipelineStatistics = this.PipelineStatistics;

            return result;
        }

		internal unsafe Interop.CommandBufferInheritanceInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.CommandBufferInheritanceInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.CommandBufferInheritanceInfo*)pointer.ToPointer();
		}
	}

	internal static class CommandBufferInheritanceInfoExtensions
	{
		internal unsafe static Interop.CommandBufferInheritanceInfo* MarshalTo(this CommandBufferInheritanceInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class CommandPoolCreateInfo
	{
		public CommandPoolCreateFlags Flags
		{
			get;
			set;
		}

		public uint QueueFamilyIndex
		{
			get;
			set;
		}

        internal unsafe Interop.CommandPoolCreateInfo Pack()
        {
            var result = new Interop.CommandPoolCreateInfo();
			result.Flags = this.Flags;
			result.QueueFamilyIndex = this.QueueFamilyIndex;

            return result;
        }

		internal unsafe Interop.CommandPoolCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.CommandPoolCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.CommandPoolCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class CommandPoolCreateInfoExtensions
	{
		internal unsafe static Interop.CommandPoolCreateInfo* MarshalTo(this CommandPoolCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class ComputePipelineCreateInfo
	{
		public PipelineCreateFlags Flags
		{
			get;
			set;
		}

		public PipelineShaderStageCreateInfo Stage
		{
			get;
			set;
		}

		public PipelineLayout Layout
		{
			get;
			set;
		}

		public Pipeline BasePipelineHandle
		{
			get;
			set;
		}

		public int BasePipelineIndex
		{
			get;
			set;
		}

        internal unsafe Interop.ComputePipelineCreateInfo Pack()
        {
            var result = new Interop.ComputePipelineCreateInfo();
			result.Flags = this.Flags;
			result.Stage = this.Stage.Pack();
			result.Layout = this.Layout.MarshalTo();
			result.BasePipelineHandle = this.BasePipelineHandle.MarshalTo();
			result.BasePipelineIndex = this.BasePipelineIndex;

            return result;
        }

		internal unsafe Interop.ComputePipelineCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.ComputePipelineCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.ComputePipelineCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class ComputePipelineCreateInfoExtensions
	{
		internal unsafe static Interop.ComputePipelineCreateInfo* MarshalTo(this ComputePipelineCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class CopyDescriptorSet
	{
		public DescriptorSet SourceSet
		{
			get;
			set;
		}

		public uint SourceBinding
		{
			get;
			set;
		}

		public uint SourceArrayElement
		{
			get;
			set;
		}

		public DescriptorSet DestinationSet
		{
			get;
			set;
		}

		public uint DestinationBinding
		{
			get;
			set;
		}

		public uint DestinationArrayElement
		{
			get;
			set;
		}

		public uint DescriptorCount
		{
			get;
			set;
		}

        internal unsafe Interop.CopyDescriptorSet Pack()
        {
            var result = new Interop.CopyDescriptorSet();
			result.SourceSet = this.SourceSet.MarshalTo();
			result.SourceBinding = this.SourceBinding;
			result.SourceArrayElement = this.SourceArrayElement;
			result.DestinationSet = this.DestinationSet.MarshalTo();
			result.DestinationBinding = this.DestinationBinding;
			result.DestinationArrayElement = this.DestinationArrayElement;
			result.DescriptorCount = this.DescriptorCount;

            return result;
        }

		internal unsafe Interop.CopyDescriptorSet* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.CopyDescriptorSet>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.CopyDescriptorSet*)pointer.ToPointer();
		}
	}

	internal static class CopyDescriptorSetExtensions
	{
		internal unsafe static Interop.CopyDescriptorSet* MarshalTo(this CopyDescriptorSet[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class DescriptorBufferInfo
	{
		public Buffer Buffer
		{
			get;
			set;
		}

		public DeviceSize Offset
		{
			get;
			set;
		}

		public DeviceSize Range
		{
			get;
			set;
		}

        internal unsafe Interop.DescriptorBufferInfo Pack()
        {
            var result = new Interop.DescriptorBufferInfo();
			result.Buffer = this.Buffer.MarshalTo();
			result.Offset = this.Offset;
			result.Range = this.Range;

            return result;
        }

		internal unsafe Interop.DescriptorBufferInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.DescriptorBufferInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.DescriptorBufferInfo*)pointer.ToPointer();
		}
	}

	internal static class DescriptorBufferInfoExtensions
	{
		internal unsafe static Interop.DescriptorBufferInfo* MarshalTo(this DescriptorBufferInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class DescriptorImageInfo
	{
		public Sampler Sampler
		{
			get;
			set;
		}

		public ImageView ImageView
		{
			get;
			set;
		}

		public ImageLayout ImageLayout
		{
			get;
			set;
		}

        internal unsafe Interop.DescriptorImageInfo Pack()
        {
            var result = new Interop.DescriptorImageInfo();
			result.Sampler = this.Sampler.MarshalTo();
			result.ImageView = this.ImageView.MarshalTo();
			result.ImageLayout = this.ImageLayout;

            return result;
        }

		internal unsafe Interop.DescriptorImageInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.DescriptorImageInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.DescriptorImageInfo*)pointer.ToPointer();
		}
	}

	internal static class DescriptorImageInfoExtensions
	{
		internal unsafe static Interop.DescriptorImageInfo* MarshalTo(this DescriptorImageInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class DescriptorPoolCreateInfo
	{
		public DescriptorPoolCreateFlags Flags
		{
			get;
			set;
		}

		public uint MaxSets
		{
			get;
			set;
		}

		public DescriptorPoolSize[] PoolSizes
		{
			get;
			set;
		}

        internal unsafe Interop.DescriptorPoolCreateInfo Pack()
        {
            var result = new Interop.DescriptorPoolCreateInfo();
			result.Flags = this.Flags;
			result.MaxSets = this.MaxSets;
			result.PoolSizes = this.PoolSizes.MarshalTo();

            return result;
        }

		internal unsafe Interop.DescriptorPoolCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.DescriptorPoolCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.DescriptorPoolCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class DescriptorPoolCreateInfoExtensions
	{
		internal unsafe static Interop.DescriptorPoolCreateInfo* MarshalTo(this DescriptorPoolCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class DescriptorSetAllocateInfo
	{
		public DescriptorPool DescriptorPool
		{
			get;
			set;
		}

		public DescriptorSetLayout[] SetLayouts
		{
			get;
			set;
		}

        internal unsafe Interop.DescriptorSetAllocateInfo Pack()
        {
            var result = new Interop.DescriptorSetAllocateInfo();
			result.DescriptorPool = this.DescriptorPool.MarshalTo();
			result.SetLayouts = this.SetLayouts.MarshalTo();

            return result;
        }

		internal unsafe Interop.DescriptorSetAllocateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.DescriptorSetAllocateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.DescriptorSetAllocateInfo*)pointer.ToPointer();
		}
	}

	internal static class DescriptorSetAllocateInfoExtensions
	{
		internal unsafe static Interop.DescriptorSetAllocateInfo* MarshalTo(this DescriptorSetAllocateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class DescriptorSetLayoutBinding
	{
		public uint Binding
		{
			get;
			set;
		}

		public DescriptorType DescriptorType
		{
			get;
			set;
		}

		public ShaderStageFlags StageFlags
		{
			get;
			set;
		}

		public Sampler[] ImmutableSamplers
		{
			get;
			set;
		}

        internal unsafe Interop.DescriptorSetLayoutBinding Pack()
        {
            var result = new Interop.DescriptorSetLayoutBinding();
			result.Binding = this.Binding;
			result.DescriptorType = this.DescriptorType;
			result.StageFlags = this.StageFlags;
			result.ImmutableSamplers = this.ImmutableSamplers.MarshalTo();

            return result;
        }

		internal unsafe Interop.DescriptorSetLayoutBinding* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.DescriptorSetLayoutBinding>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.DescriptorSetLayoutBinding*)pointer.ToPointer();
		}
	}

	internal static class DescriptorSetLayoutBindingExtensions
	{
		internal unsafe static Interop.DescriptorSetLayoutBinding* MarshalTo(this DescriptorSetLayoutBinding[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class DescriptorSetLayoutCreateInfo
	{
		public DescriptorSetLayoutCreateFlags Flags
		{
			get;
			set;
		}

		public DescriptorSetLayoutBinding[] Bindings
		{
			get;
			set;
		}

        internal unsafe Interop.DescriptorSetLayoutCreateInfo Pack()
        {
            var result = new Interop.DescriptorSetLayoutCreateInfo();
			result.Flags = this.Flags;
			result.Bindings = this.Bindings.MarshalTo();

            return result;
        }

		internal unsafe Interop.DescriptorSetLayoutCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.DescriptorSetLayoutCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.DescriptorSetLayoutCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class DescriptorSetLayoutCreateInfoExtensions
	{
		internal unsafe static Interop.DescriptorSetLayoutCreateInfo* MarshalTo(this DescriptorSetLayoutCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class DeviceCreateInfo
	{
		public DeviceCreateFlags Flags
		{
			get;
			set;
		}

		public DeviceQueueCreateInfo[] QueueCreateInfos
		{
			get;
			set;
		}

		public string[] EnabledLayerNames
		{
			get;
			set;
		}

		public string[] EnabledExtensionNames
		{
			get;
			set;
		}

		public PhysicalDeviceFeatures EnabledFeatures
		{
			get;
			set;
		}

        internal unsafe Interop.DeviceCreateInfo Pack()
        {
            var result = new Interop.DeviceCreateInfo();
			result.Flags = this.Flags;
			result.QueueCreateInfos = this.QueueCreateInfos.MarshalTo();
			result.EnabledLayerNames = this.EnabledLayerNames.MarshalTo();
			result.EnabledExtensionNames = this.EnabledExtensionNames.MarshalTo();
			result.EnabledFeatures = this.EnabledFeatures.MarshalTo();

            return result;
        }

		internal unsafe Interop.DeviceCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.DeviceCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.DeviceCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class DeviceCreateInfoExtensions
	{
		internal unsafe static Interop.DeviceCreateInfo* MarshalTo(this DeviceCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class DeviceQueueCreateInfo
	{
		public DeviceQueueCreateFlags Flags
		{
			get;
			set;
		}

		public uint QueueFamilyIndex
		{
			get;
			set;
		}

		public float[] QueuePriorities
		{
			get;
			set;
		}

        internal unsafe Interop.DeviceQueueCreateInfo Pack()
        {
            var result = new Interop.DeviceQueueCreateInfo();
			result.Flags = this.Flags;
			result.QueueFamilyIndex = this.QueueFamilyIndex;
			result.QueuePriorities = this.QueuePriorities.MarshalTo();

            return result;
        }

		internal unsafe Interop.DeviceQueueCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.DeviceQueueCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.DeviceQueueCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class DeviceQueueCreateInfoExtensions
	{
		internal unsafe static Interop.DeviceQueueCreateInfo* MarshalTo(this DeviceQueueCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class EventCreateInfo
	{
		public EventCreateFlags Flags
		{
			get;
			set;
		}

        internal unsafe Interop.EventCreateInfo Pack()
        {
            var result = new Interop.EventCreateInfo();
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.EventCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.EventCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.EventCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class EventCreateInfoExtensions
	{
		internal unsafe static Interop.EventCreateInfo* MarshalTo(this EventCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class ExtensionProperties
	{
		public char ExtensionName
		{
			get;
			set;
		}

		public uint SpecVersion
		{
			get;
			set;
		}

        internal unsafe Interop.ExtensionProperties Pack()
        {
            var result = new Interop.ExtensionProperties();
			result.ExtensionName = this.ExtensionName;
			result.SpecVersion = this.SpecVersion;

            return result;
        }

		internal unsafe Interop.ExtensionProperties* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.ExtensionProperties>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.ExtensionProperties*)pointer.ToPointer();
		}
	}

	internal static class ExtensionPropertiesExtensions
	{
		internal unsafe static Interop.ExtensionProperties* MarshalTo(this ExtensionProperties[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class FenceCreateInfo
	{
		public FenceCreateFlags Flags
		{
			get;
			set;
		}

        internal unsafe Interop.FenceCreateInfo Pack()
        {
            var result = new Interop.FenceCreateInfo();
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.FenceCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.FenceCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.FenceCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class FenceCreateInfoExtensions
	{
		internal unsafe static Interop.FenceCreateInfo* MarshalTo(this FenceCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class FramebufferCreateInfo
	{
		public FramebufferCreateFlags Flags
		{
			get;
			set;
		}

		public RenderPass RenderPass
		{
			get;
			set;
		}

		public ImageView[] Attachments
		{
			get;
			set;
		}

		public uint Width
		{
			get;
			set;
		}

		public uint Height
		{
			get;
			set;
		}

		public uint Layers
		{
			get;
			set;
		}

        internal unsafe Interop.FramebufferCreateInfo Pack()
        {
            var result = new Interop.FramebufferCreateInfo();
			result.Flags = this.Flags;
			result.RenderPass = this.RenderPass.MarshalTo();
			result.Attachments = this.Attachments.MarshalTo();
			result.Width = this.Width;
			result.Height = this.Height;
			result.Layers = this.Layers;

            return result;
        }

		internal unsafe Interop.FramebufferCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.FramebufferCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.FramebufferCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class FramebufferCreateInfoExtensions
	{
		internal unsafe static Interop.FramebufferCreateInfo* MarshalTo(this FramebufferCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class GraphicsPipelineCreateInfo
	{
		public PipelineCreateFlags Flags
		{
			get;
			set;
		}

		public PipelineShaderStageCreateInfo[] Stages
		{
			get;
			set;
		}

		public PipelineVertexInputStateCreateInfo VertexInputState
		{
			get;
			set;
		}

		public PipelineInputAssemblyStateCreateInfo InputAssemblyState
		{
			get;
			set;
		}

		public PipelineTessellationStateCreateInfo TessellationState
		{
			get;
			set;
		}

		public PipelineViewportStateCreateInfo ViewportState
		{
			get;
			set;
		}

		public PipelineRasterizationStateCreateInfo RasterizationState
		{
			get;
			set;
		}

		public PipelineMultisampleStateCreateInfo MultisampleState
		{
			get;
			set;
		}

		public PipelineDepthStencilStateCreateInfo DepthStencilState
		{
			get;
			set;
		}

		public PipelineColorBlendStateCreateInfo ColorBlendState
		{
			get;
			set;
		}

		public PipelineDynamicStateCreateInfo DynamicState
		{
			get;
			set;
		}

		public PipelineLayout Layout
		{
			get;
			set;
		}

		public RenderPass RenderPass
		{
			get;
			set;
		}

		public uint Subpass
		{
			get;
			set;
		}

		public Pipeline BasePipelineHandle
		{
			get;
			set;
		}

		public int BasePipelineIndex
		{
			get;
			set;
		}

        internal unsafe Interop.GraphicsPipelineCreateInfo Pack()
        {
            var result = new Interop.GraphicsPipelineCreateInfo();
			result.Flags = this.Flags;
			result.Stages = this.Stages.MarshalTo();
			result.VertexInputState = this.VertexInputState.MarshalTo();
			result.InputAssemblyState = this.InputAssemblyState.MarshalTo();
			result.TessellationState = this.TessellationState.MarshalTo();
			result.ViewportState = this.ViewportState.MarshalTo();
			result.RasterizationState = this.RasterizationState.MarshalTo();
			result.MultisampleState = this.MultisampleState.MarshalTo();
			result.DepthStencilState = this.DepthStencilState.MarshalTo();
			result.ColorBlendState = this.ColorBlendState.MarshalTo();
			result.DynamicState = this.DynamicState.MarshalTo();
			result.Layout = this.Layout.MarshalTo();
			result.RenderPass = this.RenderPass.MarshalTo();
			result.Subpass = this.Subpass;
			result.BasePipelineHandle = this.BasePipelineHandle.MarshalTo();
			result.BasePipelineIndex = this.BasePipelineIndex;

            return result;
        }

		internal unsafe Interop.GraphicsPipelineCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.GraphicsPipelineCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.GraphicsPipelineCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class GraphicsPipelineCreateInfoExtensions
	{
		internal unsafe static Interop.GraphicsPipelineCreateInfo* MarshalTo(this GraphicsPipelineCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class ImageBlit
	{
		public ImageSubresourceLayers SourceSubresource
		{
			get;
			set;
		}

		public Offset3D SourceOffsets
		{
			get;
			set;
		}

		public ImageSubresourceLayers DestinationSubresource
		{
			get;
			set;
		}

		public Offset3D DestinationOffsets
		{
			get;
			set;
		}

        internal unsafe Interop.ImageBlit Pack()
        {
            var result = new Interop.ImageBlit();
			result.SourceSubresource = this.SourceSubresource;
			result.SourceOffsets = this.SourceOffsets;
			result.DestinationSubresource = this.DestinationSubresource;
			result.DestinationOffsets = this.DestinationOffsets;

            return result;
        }

		internal unsafe Interop.ImageBlit* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.ImageBlit>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.ImageBlit*)pointer.ToPointer();
		}
	}

	internal static class ImageBlitExtensions
	{
		internal unsafe static Interop.ImageBlit* MarshalTo(this ImageBlit[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class ImageCreateInfo
	{
		public ImageCreateFlags Flags
		{
			get;
			set;
		}

		public ImageType ImageType
		{
			get;
			set;
		}

		public Format Format
		{
			get;
			set;
		}

		public Extent3D Extent
		{
			get;
			set;
		}

		public uint MipLevels
		{
			get;
			set;
		}

		public uint ArrayLayers
		{
			get;
			set;
		}

		public SampleCountFlags Samples
		{
			get;
			set;
		}

		public ImageTiling Tiling
		{
			get;
			set;
		}

		public ImageUsageFlags Usage
		{
			get;
			set;
		}

		public SharingMode SharingMode
		{
			get;
			set;
		}

		public uint[] QueueFamilyIndices
		{
			get;
			set;
		}

		public ImageLayout InitialLayout
		{
			get;
			set;
		}

        internal unsafe Interop.ImageCreateInfo Pack()
        {
            var result = new Interop.ImageCreateInfo();
			result.Flags = this.Flags;
			result.ImageType = this.ImageType;
			result.Format = this.Format;
			result.Extent = this.Extent;
			result.MipLevels = this.MipLevels;
			result.ArrayLayers = this.ArrayLayers;
			result.Samples = this.Samples;
			result.Tiling = this.Tiling;
			result.Usage = this.Usage;
			result.SharingMode = this.SharingMode;
			result.QueueFamilyIndices = this.QueueFamilyIndices.MarshalTo();
			result.InitialLayout = this.InitialLayout;

            return result;
        }

		internal unsafe Interop.ImageCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.ImageCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.ImageCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class ImageCreateInfoExtensions
	{
		internal unsafe static Interop.ImageCreateInfo* MarshalTo(this ImageCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class ImageMemoryBarrier
	{
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}

		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}

		public ImageLayout OldLayout
		{
			get;
			set;
		}

		public ImageLayout NewLayout
		{
			get;
			set;
		}

		public uint SourceQueueFamilyIndex
		{
			get;
			set;
		}

		public uint DestinationQueueFamilyIndex
		{
			get;
			set;
		}

		public Image Image
		{
			get;
			set;
		}

		public ImageSubresourceRange SubresourceRange
		{
			get;
			set;
		}

        internal unsafe Interop.ImageMemoryBarrier Pack()
        {
            var result = new Interop.ImageMemoryBarrier();
			result.SourceAccessMask = this.SourceAccessMask;
			result.DestinationAccessMask = this.DestinationAccessMask;
			result.OldLayout = this.OldLayout;
			result.NewLayout = this.NewLayout;
			result.SourceQueueFamilyIndex = this.SourceQueueFamilyIndex;
			result.DestinationQueueFamilyIndex = this.DestinationQueueFamilyIndex;
			result.Image = this.Image.MarshalTo();
			result.SubresourceRange = this.SubresourceRange;

            return result;
        }

		internal unsafe Interop.ImageMemoryBarrier* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.ImageMemoryBarrier>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.ImageMemoryBarrier*)pointer.ToPointer();
		}
	}

	internal static class ImageMemoryBarrierExtensions
	{
		internal unsafe static Interop.ImageMemoryBarrier* MarshalTo(this ImageMemoryBarrier[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class ImageViewCreateInfo
	{
		public ImageViewCreateFlags Flags
		{
			get;
			set;
		}

		public Image Image
		{
			get;
			set;
		}

		public ImageViewType ViewType
		{
			get;
			set;
		}

		public Format Format
		{
			get;
			set;
		}

		public ComponentMapping Components
		{
			get;
			set;
		}

		public ImageSubresourceRange SubresourceRange
		{
			get;
			set;
		}

        internal unsafe Interop.ImageViewCreateInfo Pack()
        {
            var result = new Interop.ImageViewCreateInfo();
			result.Flags = this.Flags;
			result.Image = this.Image.MarshalTo();
			result.ViewType = this.ViewType;
			result.Format = this.Format;
			result.Components = this.Components;
			result.SubresourceRange = this.SubresourceRange;

            return result;
        }

		internal unsafe Interop.ImageViewCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.ImageViewCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.ImageViewCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class ImageViewCreateInfoExtensions
	{
		internal unsafe static Interop.ImageViewCreateInfo* MarshalTo(this ImageViewCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class InstanceCreateInfo
	{
		public InstanceCreateFlags Flags
		{
			get;
			set;
		}

		public ApplicationInfo ApplicationInfo
		{
			get;
			set;
		}

		public string[] EnabledLayerNames
		{
			get;
			set;
		}

		public string[] EnabledExtensionNames
		{
			get;
			set;
		}

        internal unsafe Interop.InstanceCreateInfo Pack()
        {
            var result = new Interop.InstanceCreateInfo();
			result.Flags = this.Flags;
			result.ApplicationInfo = this.ApplicationInfo.MarshalTo();
			result.EnabledLayerNames = this.EnabledLayerNames.MarshalTo();
			result.EnabledExtensionNames = this.EnabledExtensionNames.MarshalTo();

            return result;
        }

		internal unsafe Interop.InstanceCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.InstanceCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.InstanceCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class InstanceCreateInfoExtensions
	{
		internal unsafe static Interop.InstanceCreateInfo* MarshalTo(this InstanceCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class LayerProperties
	{
		public char LayerName
		{
			get;
			set;
		}

		public uint SpecVersion
		{
			get;
			set;
		}

		public uint ImplementationVersion
		{
			get;
			set;
		}

		public char Description
		{
			get;
			set;
		}

        internal unsafe Interop.LayerProperties Pack()
        {
            var result = new Interop.LayerProperties();
			result.LayerName = this.LayerName;
			result.SpecVersion = this.SpecVersion;
			result.ImplementationVersion = this.ImplementationVersion;
			result.Description = this.Description;

            return result;
        }

		internal unsafe Interop.LayerProperties* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.LayerProperties>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.LayerProperties*)pointer.ToPointer();
		}
	}

	internal static class LayerPropertiesExtensions
	{
		internal unsafe static Interop.LayerProperties* MarshalTo(this LayerProperties[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class MappedMemoryRange
	{
		public DeviceMemory Memory
		{
			get;
			set;
		}

		public DeviceSize Offset
		{
			get;
			set;
		}

		public DeviceSize Size
		{
			get;
			set;
		}

        internal unsafe Interop.MappedMemoryRange Pack()
        {
            var result = new Interop.MappedMemoryRange();
			result.Memory = this.Memory.MarshalTo();
			result.Offset = this.Offset;
			result.Size = this.Size;

            return result;
        }

		internal unsafe Interop.MappedMemoryRange* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.MappedMemoryRange>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.MappedMemoryRange*)pointer.ToPointer();
		}
	}

	internal static class MappedMemoryRangeExtensions
	{
		internal unsafe static Interop.MappedMemoryRange* MarshalTo(this MappedMemoryRange[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class MemoryAllocateInfo
	{
		public DeviceSize AllocationSize
		{
			get;
			set;
		}

		public uint MemoryTypeIndex
		{
			get;
			set;
		}

        internal unsafe Interop.MemoryAllocateInfo Pack()
        {
            var result = new Interop.MemoryAllocateInfo();
			result.AllocationSize = this.AllocationSize;
			result.MemoryTypeIndex = this.MemoryTypeIndex;

            return result;
        }

		internal unsafe Interop.MemoryAllocateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.MemoryAllocateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.MemoryAllocateInfo*)pointer.ToPointer();
		}
	}

	internal static class MemoryAllocateInfoExtensions
	{
		internal unsafe static Interop.MemoryAllocateInfo* MarshalTo(this MemoryAllocateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class MemoryBarrier
	{
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}

		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}

        internal unsafe Interop.MemoryBarrier Pack()
        {
            var result = new Interop.MemoryBarrier();
			result.SourceAccessMask = this.SourceAccessMask;
			result.DestinationAccessMask = this.DestinationAccessMask;

            return result;
        }

		internal unsafe Interop.MemoryBarrier* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.MemoryBarrier>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.MemoryBarrier*)pointer.ToPointer();
		}
	}

	internal static class MemoryBarrierExtensions
	{
		internal unsafe static Interop.MemoryBarrier* MarshalTo(this MemoryBarrier[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PhysicalDeviceLimits
	{
		public uint MaxImageDimension1D
		{
			get;
			set;
		}

		public uint MaxImageDimension2D
		{
			get;
			set;
		}

		public uint MaxImageDimension3D
		{
			get;
			set;
		}

		public uint MaxImageDimensionCube
		{
			get;
			set;
		}

		public uint MaxImageArrayLayers
		{
			get;
			set;
		}

		public uint MaxTexelBufferElements
		{
			get;
			set;
		}

		public uint MaxUniformBufferRange
		{
			get;
			set;
		}

		public uint MaxStorageBufferRange
		{
			get;
			set;
		}

		public uint MaxPushConstantsSize
		{
			get;
			set;
		}

		public uint MaxMemoryAllocationCount
		{
			get;
			set;
		}

		public uint MaxSamplerAllocationCount
		{
			get;
			set;
		}

		public DeviceSize BufferImageGranularity
		{
			get;
			set;
		}

		public DeviceSize SparseAddressSpaceSize
		{
			get;
			set;
		}

		public uint MaxBoundDescriptorSets
		{
			get;
			set;
		}

		public uint MaxPerStageDescriptorSamplers
		{
			get;
			set;
		}

		public uint MaxPerStageDescriptorUniformBuffers
		{
			get;
			set;
		}

		public uint MaxPerStageDescriptorStorageBuffers
		{
			get;
			set;
		}

		public uint MaxPerStageDescriptorSampledImages
		{
			get;
			set;
		}

		public uint MaxPerStageDescriptorStorageImages
		{
			get;
			set;
		}

		public uint MaxPerStageDescriptorInputAttachments
		{
			get;
			set;
		}

		public uint MaxPerStageResources
		{
			get;
			set;
		}

		public uint MaxDescriptorSetSamplers
		{
			get;
			set;
		}

		public uint MaxDescriptorSetUniformBuffers
		{
			get;
			set;
		}

		public uint MaxDescriptorSetUniformBuffersDynamic
		{
			get;
			set;
		}

		public uint MaxDescriptorSetStorageBuffers
		{
			get;
			set;
		}

		public uint MaxDescriptorSetStorageBuffersDynamic
		{
			get;
			set;
		}

		public uint MaxDescriptorSetSampledImages
		{
			get;
			set;
		}

		public uint MaxDescriptorSetStorageImages
		{
			get;
			set;
		}

		public uint MaxDescriptorSetInputAttachments
		{
			get;
			set;
		}

		public uint MaxVertexInputAttributes
		{
			get;
			set;
		}

		public uint MaxVertexInputBindings
		{
			get;
			set;
		}

		public uint MaxVertexInputAttributeOffset
		{
			get;
			set;
		}

		public uint MaxVertexInputBindingStride
		{
			get;
			set;
		}

		public uint MaxVertexOutputComponents
		{
			get;
			set;
		}

		public uint MaxTessellationGenerationLevel
		{
			get;
			set;
		}

		public uint MaxTessellationPatchSize
		{
			get;
			set;
		}

		public uint MaxTessellationControlPerVertexInputComponents
		{
			get;
			set;
		}

		public uint MaxTessellationControlPerVertexOutputComponents
		{
			get;
			set;
		}

		public uint MaxTessellationControlPerPatchOutputComponents
		{
			get;
			set;
		}

		public uint MaxTessellationControlTotalOutputComponents
		{
			get;
			set;
		}

		public uint MaxTessellationEvaluationInputComponents
		{
			get;
			set;
		}

		public uint MaxTessellationEvaluationOutputComponents
		{
			get;
			set;
		}

		public uint MaxGeometryShaderInvocations
		{
			get;
			set;
		}

		public uint MaxGeometryInputComponents
		{
			get;
			set;
		}

		public uint MaxGeometryOutputComponents
		{
			get;
			set;
		}

		public uint MaxGeometryOutputVertices
		{
			get;
			set;
		}

		public uint MaxGeometryTotalOutputComponents
		{
			get;
			set;
		}

		public uint MaxFragmentInputComponents
		{
			get;
			set;
		}

		public uint MaxFragmentOutputAttachments
		{
			get;
			set;
		}

		public uint MaxFragmentDualSourceAttachments
		{
			get;
			set;
		}

		public uint MaxFragmentCombinedOutputResources
		{
			get;
			set;
		}

		public uint MaxComputeSharedMemorySize
		{
			get;
			set;
		}

		public uint MaxComputeWorkGroupCount
		{
			get;
			set;
		}

		public uint MaxComputeWorkGroupInvocations
		{
			get;
			set;
		}

		public uint MaxComputeWorkGroupSize
		{
			get;
			set;
		}

		public uint SubPixelPrecisionBits
		{
			get;
			set;
		}

		public uint SubTexelPrecisionBits
		{
			get;
			set;
		}

		public uint MipmapPrecisionBits
		{
			get;
			set;
		}

		public uint MaxDrawIndexedIndexValue
		{
			get;
			set;
		}

		public uint MaxDrawIndirectCount
		{
			get;
			set;
		}

		public float MaxSamplerLodBias
		{
			get;
			set;
		}

		public float MaxSamplerAnisotropy
		{
			get;
			set;
		}

		public uint MaxViewports
		{
			get;
			set;
		}

		public uint MaxViewportDimensions
		{
			get;
			set;
		}

		public float ViewportBoundsRange
		{
			get;
			set;
		}

		public uint ViewportSubPixelBits
		{
			get;
			set;
		}

		public UIntPtr MinMemoryMapAlignment
		{
			get;
			set;
		}

		public DeviceSize MinTexelBufferOffsetAlignment
		{
			get;
			set;
		}

		public DeviceSize MinUniformBufferOffsetAlignment
		{
			get;
			set;
		}

		public DeviceSize MinStorageBufferOffsetAlignment
		{
			get;
			set;
		}

		public int MinTexelOffset
		{
			get;
			set;
		}

		public uint MaxTexelOffset
		{
			get;
			set;
		}

		public int MinTexelGatherOffset
		{
			get;
			set;
		}

		public uint MaxTexelGatherOffset
		{
			get;
			set;
		}

		public float MinInterpolationOffset
		{
			get;
			set;
		}

		public float MaxInterpolationOffset
		{
			get;
			set;
		}

		public uint SubPixelInterpolationOffsetBits
		{
			get;
			set;
		}

		public uint MaxFramebufferWidth
		{
			get;
			set;
		}

		public uint MaxFramebufferHeight
		{
			get;
			set;
		}

		public uint MaxFramebufferLayers
		{
			get;
			set;
		}

		public SampleCountFlags FramebufferColorSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags FramebufferDepthSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags FramebufferStencilSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags FramebufferNoAttachmentsSampleCounts
		{
			get;
			set;
		}

		public uint MaxColorAttachments
		{
			get;
			set;
		}

		public SampleCountFlags SampledImageColorSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags SampledImageIntegerSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags SampledImageDepthSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags SampledImageStencilSampleCounts
		{
			get;
			set;
		}

		public SampleCountFlags StorageImageSampleCounts
		{
			get;
			set;
		}

		public uint MaxSampleMaskWords
		{
			get;
			set;
		}

		public Bool32 TimestampComputeAndGraphics
		{
			get;
			set;
		}

		public float TimestampPeriod
		{
			get;
			set;
		}

		public uint MaxClipDistances
		{
			get;
			set;
		}

		public uint MaxCullDistances
		{
			get;
			set;
		}

		public uint MaxCombinedClipAndCullDistances
		{
			get;
			set;
		}

		public uint DiscreteQueuePriorities
		{
			get;
			set;
		}

		public float PointSizeRange
		{
			get;
			set;
		}

		public float LineWidthRange
		{
			get;
			set;
		}

		public float PointSizeGranularity
		{
			get;
			set;
		}

		public float LineWidthGranularity
		{
			get;
			set;
		}

		public Bool32 StrictLines
		{
			get;
			set;
		}

		public Bool32 StandardSampleLocations
		{
			get;
			set;
		}

		public DeviceSize OptimalBufferCopyOffsetAlignment
		{
			get;
			set;
		}

		public DeviceSize OptimalBufferCopyRowPitchAlignment
		{
			get;
			set;
		}

		public DeviceSize NonCoherentAtomSize
		{
			get;
			set;
		}

        internal unsafe Interop.PhysicalDeviceLimits Pack()
        {
            var result = new Interop.PhysicalDeviceLimits();
			result.MaxImageDimension1D = this.MaxImageDimension1D;
			result.MaxImageDimension2D = this.MaxImageDimension2D;
			result.MaxImageDimension3D = this.MaxImageDimension3D;
			result.MaxImageDimensionCube = this.MaxImageDimensionCube;
			result.MaxImageArrayLayers = this.MaxImageArrayLayers;
			result.MaxTexelBufferElements = this.MaxTexelBufferElements;
			result.MaxUniformBufferRange = this.MaxUniformBufferRange;
			result.MaxStorageBufferRange = this.MaxStorageBufferRange;
			result.MaxPushConstantsSize = this.MaxPushConstantsSize;
			result.MaxMemoryAllocationCount = this.MaxMemoryAllocationCount;
			result.MaxSamplerAllocationCount = this.MaxSamplerAllocationCount;
			result.BufferImageGranularity = this.BufferImageGranularity;
			result.SparseAddressSpaceSize = this.SparseAddressSpaceSize;
			result.MaxBoundDescriptorSets = this.MaxBoundDescriptorSets;
			result.MaxPerStageDescriptorSamplers = this.MaxPerStageDescriptorSamplers;
			result.MaxPerStageDescriptorUniformBuffers = this.MaxPerStageDescriptorUniformBuffers;
			result.MaxPerStageDescriptorStorageBuffers = this.MaxPerStageDescriptorStorageBuffers;
			result.MaxPerStageDescriptorSampledImages = this.MaxPerStageDescriptorSampledImages;
			result.MaxPerStageDescriptorStorageImages = this.MaxPerStageDescriptorStorageImages;
			result.MaxPerStageDescriptorInputAttachments = this.MaxPerStageDescriptorInputAttachments;
			result.MaxPerStageResources = this.MaxPerStageResources;
			result.MaxDescriptorSetSamplers = this.MaxDescriptorSetSamplers;
			result.MaxDescriptorSetUniformBuffers = this.MaxDescriptorSetUniformBuffers;
			result.MaxDescriptorSetUniformBuffersDynamic = this.MaxDescriptorSetUniformBuffersDynamic;
			result.MaxDescriptorSetStorageBuffers = this.MaxDescriptorSetStorageBuffers;
			result.MaxDescriptorSetStorageBuffersDynamic = this.MaxDescriptorSetStorageBuffersDynamic;
			result.MaxDescriptorSetSampledImages = this.MaxDescriptorSetSampledImages;
			result.MaxDescriptorSetStorageImages = this.MaxDescriptorSetStorageImages;
			result.MaxDescriptorSetInputAttachments = this.MaxDescriptorSetInputAttachments;
			result.MaxVertexInputAttributes = this.MaxVertexInputAttributes;
			result.MaxVertexInputBindings = this.MaxVertexInputBindings;
			result.MaxVertexInputAttributeOffset = this.MaxVertexInputAttributeOffset;
			result.MaxVertexInputBindingStride = this.MaxVertexInputBindingStride;
			result.MaxVertexOutputComponents = this.MaxVertexOutputComponents;
			result.MaxTessellationGenerationLevel = this.MaxTessellationGenerationLevel;
			result.MaxTessellationPatchSize = this.MaxTessellationPatchSize;
			result.MaxTessellationControlPerVertexInputComponents = this.MaxTessellationControlPerVertexInputComponents;
			result.MaxTessellationControlPerVertexOutputComponents = this.MaxTessellationControlPerVertexOutputComponents;
			result.MaxTessellationControlPerPatchOutputComponents = this.MaxTessellationControlPerPatchOutputComponents;
			result.MaxTessellationControlTotalOutputComponents = this.MaxTessellationControlTotalOutputComponents;
			result.MaxTessellationEvaluationInputComponents = this.MaxTessellationEvaluationInputComponents;
			result.MaxTessellationEvaluationOutputComponents = this.MaxTessellationEvaluationOutputComponents;
			result.MaxGeometryShaderInvocations = this.MaxGeometryShaderInvocations;
			result.MaxGeometryInputComponents = this.MaxGeometryInputComponents;
			result.MaxGeometryOutputComponents = this.MaxGeometryOutputComponents;
			result.MaxGeometryOutputVertices = this.MaxGeometryOutputVertices;
			result.MaxGeometryTotalOutputComponents = this.MaxGeometryTotalOutputComponents;
			result.MaxFragmentInputComponents = this.MaxFragmentInputComponents;
			result.MaxFragmentOutputAttachments = this.MaxFragmentOutputAttachments;
			result.MaxFragmentDualSourceAttachments = this.MaxFragmentDualSourceAttachments;
			result.MaxFragmentCombinedOutputResources = this.MaxFragmentCombinedOutputResources;
			result.MaxComputeSharedMemorySize = this.MaxComputeSharedMemorySize;
			result.MaxComputeWorkGroupCount = this.MaxComputeWorkGroupCount;
			result.MaxComputeWorkGroupInvocations = this.MaxComputeWorkGroupInvocations;
			result.MaxComputeWorkGroupSize = this.MaxComputeWorkGroupSize;
			result.SubPixelPrecisionBits = this.SubPixelPrecisionBits;
			result.SubTexelPrecisionBits = this.SubTexelPrecisionBits;
			result.MipmapPrecisionBits = this.MipmapPrecisionBits;
			result.MaxDrawIndexedIndexValue = this.MaxDrawIndexedIndexValue;
			result.MaxDrawIndirectCount = this.MaxDrawIndirectCount;
			result.MaxSamplerLodBias = this.MaxSamplerLodBias;
			result.MaxSamplerAnisotropy = this.MaxSamplerAnisotropy;
			result.MaxViewports = this.MaxViewports;
			result.MaxViewportDimensions = this.MaxViewportDimensions;
			result.ViewportBoundsRange = this.ViewportBoundsRange;
			result.ViewportSubPixelBits = this.ViewportSubPixelBits;
			result.MinMemoryMapAlignment = this.MinMemoryMapAlignment;
			result.MinTexelBufferOffsetAlignment = this.MinTexelBufferOffsetAlignment;
			result.MinUniformBufferOffsetAlignment = this.MinUniformBufferOffsetAlignment;
			result.MinStorageBufferOffsetAlignment = this.MinStorageBufferOffsetAlignment;
			result.MinTexelOffset = this.MinTexelOffset;
			result.MaxTexelOffset = this.MaxTexelOffset;
			result.MinTexelGatherOffset = this.MinTexelGatherOffset;
			result.MaxTexelGatherOffset = this.MaxTexelGatherOffset;
			result.MinInterpolationOffset = this.MinInterpolationOffset;
			result.MaxInterpolationOffset = this.MaxInterpolationOffset;
			result.SubPixelInterpolationOffsetBits = this.SubPixelInterpolationOffsetBits;
			result.MaxFramebufferWidth = this.MaxFramebufferWidth;
			result.MaxFramebufferHeight = this.MaxFramebufferHeight;
			result.MaxFramebufferLayers = this.MaxFramebufferLayers;
			result.FramebufferColorSampleCounts = this.FramebufferColorSampleCounts;
			result.FramebufferDepthSampleCounts = this.FramebufferDepthSampleCounts;
			result.FramebufferStencilSampleCounts = this.FramebufferStencilSampleCounts;
			result.FramebufferNoAttachmentsSampleCounts = this.FramebufferNoAttachmentsSampleCounts;
			result.MaxColorAttachments = this.MaxColorAttachments;
			result.SampledImageColorSampleCounts = this.SampledImageColorSampleCounts;
			result.SampledImageIntegerSampleCounts = this.SampledImageIntegerSampleCounts;
			result.SampledImageDepthSampleCounts = this.SampledImageDepthSampleCounts;
			result.SampledImageStencilSampleCounts = this.SampledImageStencilSampleCounts;
			result.StorageImageSampleCounts = this.StorageImageSampleCounts;
			result.MaxSampleMaskWords = this.MaxSampleMaskWords;
			result.TimestampComputeAndGraphics = this.TimestampComputeAndGraphics;
			result.TimestampPeriod = this.TimestampPeriod;
			result.MaxClipDistances = this.MaxClipDistances;
			result.MaxCullDistances = this.MaxCullDistances;
			result.MaxCombinedClipAndCullDistances = this.MaxCombinedClipAndCullDistances;
			result.DiscreteQueuePriorities = this.DiscreteQueuePriorities;
			result.PointSizeRange = this.PointSizeRange;
			result.LineWidthRange = this.LineWidthRange;
			result.PointSizeGranularity = this.PointSizeGranularity;
			result.LineWidthGranularity = this.LineWidthGranularity;
			result.StrictLines = this.StrictLines;
			result.StandardSampleLocations = this.StandardSampleLocations;
			result.OptimalBufferCopyOffsetAlignment = this.OptimalBufferCopyOffsetAlignment;
			result.OptimalBufferCopyRowPitchAlignment = this.OptimalBufferCopyRowPitchAlignment;
			result.NonCoherentAtomSize = this.NonCoherentAtomSize;

            return result;
        }

		internal unsafe Interop.PhysicalDeviceLimits* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PhysicalDeviceLimits>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PhysicalDeviceLimits*)pointer.ToPointer();
		}
	}

	internal static class PhysicalDeviceLimitsExtensions
	{
		internal unsafe static Interop.PhysicalDeviceLimits* MarshalTo(this PhysicalDeviceLimits[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PhysicalDeviceMemoryProperties
	{
		public uint MemoryTypeCount
		{
			get;
			set;
		}

		public MemoryType MemoryTypes
		{
			get;
			set;
		}

		public uint MemoryHeapCount
		{
			get;
			set;
		}

		public MemoryHeap MemoryHeaps
		{
			get;
			set;
		}

        internal unsafe Interop.PhysicalDeviceMemoryProperties Pack()
        {
            var result = new Interop.PhysicalDeviceMemoryProperties();
			result.MemoryTypeCount = this.MemoryTypeCount;
			result.MemoryTypes = this.MemoryTypes;
			result.MemoryHeapCount = this.MemoryHeapCount;
			result.MemoryHeaps = this.MemoryHeaps;

            return result;
        }

		internal unsafe Interop.PhysicalDeviceMemoryProperties* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PhysicalDeviceMemoryProperties>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PhysicalDeviceMemoryProperties*)pointer.ToPointer();
		}
	}

	internal static class PhysicalDeviceMemoryPropertiesExtensions
	{
		internal unsafe static Interop.PhysicalDeviceMemoryProperties* MarshalTo(this PhysicalDeviceMemoryProperties[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PhysicalDeviceProperties
	{
		public uint ApiVersion
		{
			get;
			set;
		}

		public uint DriverVersion
		{
			get;
			set;
		}

		public uint VendorID
		{
			get;
			set;
		}

		public uint DeviceID
		{
			get;
			set;
		}

		public PhysicalDeviceType DeviceType
		{
			get;
			set;
		}

		public char DeviceName
		{
			get;
			set;
		}

		public byte PipelineCacheUUID
		{
			get;
			set;
		}

		public PhysicalDeviceLimits Limits
		{
			get;
			set;
		}

		public PhysicalDeviceSparseProperties SparseProperties
		{
			get;
			set;
		}

        internal unsafe Interop.PhysicalDeviceProperties Pack()
        {
            var result = new Interop.PhysicalDeviceProperties();
			result.ApiVersion = this.ApiVersion;
			result.DriverVersion = this.DriverVersion;
			result.VendorID = this.VendorID;
			result.DeviceID = this.DeviceID;
			result.DeviceType = this.DeviceType;
			result.DeviceName = this.DeviceName;
			result.PipelineCacheUUID = this.PipelineCacheUUID;
			result.Limits = this.Limits.Pack();
			result.SparseProperties = this.SparseProperties;

            return result;
        }

		internal unsafe Interop.PhysicalDeviceProperties* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PhysicalDeviceProperties>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PhysicalDeviceProperties*)pointer.ToPointer();
		}
	}

	internal static class PhysicalDevicePropertiesExtensions
	{
		internal unsafe static Interop.PhysicalDeviceProperties* MarshalTo(this PhysicalDeviceProperties[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineCacheCreateInfo
	{
		public PipelineCacheCreateFlags Flags
		{
			get;
			set;
		}

		public byte[] InitialData
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineCacheCreateInfo Pack()
        {
            var result = new Interop.PipelineCacheCreateInfo();
			result.Flags = this.Flags;
			result.InitialData = this.InitialData.MarshalTo();

            return result;
        }

		internal unsafe Interop.PipelineCacheCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PipelineCacheCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PipelineCacheCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class PipelineCacheCreateInfoExtensions
	{
		internal unsafe static Interop.PipelineCacheCreateInfo* MarshalTo(this PipelineCacheCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineColorBlendStateCreateInfo
	{
		public PipelineColorBlendStateCreateFlags Flags
		{
			get;
			set;
		}

		public Bool32 LogicOpEnable
		{
			get;
			set;
		}

		public LogicOp LogicOp
		{
			get;
			set;
		}

		public PipelineColorBlendAttachmentState[] Attachments
		{
			get;
			set;
		}

		public float BlendConstants
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineColorBlendStateCreateInfo Pack()
        {
            var result = new Interop.PipelineColorBlendStateCreateInfo();
			result.Flags = this.Flags;
			result.LogicOpEnable = this.LogicOpEnable;
			result.LogicOp = this.LogicOp;
			result.Attachments = this.Attachments.MarshalTo();
			result.BlendConstants = this.BlendConstants;

            return result;
        }

		internal unsafe Interop.PipelineColorBlendStateCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PipelineColorBlendStateCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PipelineColorBlendStateCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class PipelineColorBlendStateCreateInfoExtensions
	{
		internal unsafe static Interop.PipelineColorBlendStateCreateInfo* MarshalTo(this PipelineColorBlendStateCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineDepthStencilStateCreateInfo
	{
		public PipelineDepthStencilStateCreateFlags Flags
		{
			get;
			set;
		}

		public Bool32 DepthTestEnable
		{
			get;
			set;
		}

		public Bool32 DepthWriteEnable
		{
			get;
			set;
		}

		public CompareOp DepthCompareOp
		{
			get;
			set;
		}

		public Bool32 DepthBoundsTestEnable
		{
			get;
			set;
		}

		public Bool32 StencilTestEnable
		{
			get;
			set;
		}

		public StencilOpState Front
		{
			get;
			set;
		}

		public StencilOpState Back
		{
			get;
			set;
		}

		public float MinDepthBounds
		{
			get;
			set;
		}

		public float MaxDepthBounds
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineDepthStencilStateCreateInfo Pack()
        {
            var result = new Interop.PipelineDepthStencilStateCreateInfo();
			result.Flags = this.Flags;
			result.DepthTestEnable = this.DepthTestEnable;
			result.DepthWriteEnable = this.DepthWriteEnable;
			result.DepthCompareOp = this.DepthCompareOp;
			result.DepthBoundsTestEnable = this.DepthBoundsTestEnable;
			result.StencilTestEnable = this.StencilTestEnable;
			result.Front = this.Front;
			result.Back = this.Back;
			result.MinDepthBounds = this.MinDepthBounds;
			result.MaxDepthBounds = this.MaxDepthBounds;

            return result;
        }

		internal unsafe Interop.PipelineDepthStencilStateCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PipelineDepthStencilStateCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PipelineDepthStencilStateCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class PipelineDepthStencilStateCreateInfoExtensions
	{
		internal unsafe static Interop.PipelineDepthStencilStateCreateInfo* MarshalTo(this PipelineDepthStencilStateCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineDynamicStateCreateInfo
	{
		public PipelineDynamicStateCreateFlags Flags
		{
			get;
			set;
		}

		public DynamicState[] DynamicStates
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineDynamicStateCreateInfo Pack()
        {
            var result = new Interop.PipelineDynamicStateCreateInfo();
			result.Flags = this.Flags;
			result.DynamicStates = this.DynamicStates.MarshalTo();

            return result;
        }

		internal unsafe Interop.PipelineDynamicStateCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PipelineDynamicStateCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PipelineDynamicStateCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class PipelineDynamicStateCreateInfoExtensions
	{
		internal unsafe static Interop.PipelineDynamicStateCreateInfo* MarshalTo(this PipelineDynamicStateCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineInputAssemblyStateCreateInfo
	{
		public PipelineInputAssemblyStateCreateFlags Flags
		{
			get;
			set;
		}

		public PrimitiveTopology Topology
		{
			get;
			set;
		}

		public Bool32 PrimitiveRestartEnable
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineInputAssemblyStateCreateInfo Pack()
        {
            var result = new Interop.PipelineInputAssemblyStateCreateInfo();
			result.Flags = this.Flags;
			result.Topology = this.Topology;
			result.PrimitiveRestartEnable = this.PrimitiveRestartEnable;

            return result;
        }

		internal unsafe Interop.PipelineInputAssemblyStateCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PipelineInputAssemblyStateCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PipelineInputAssemblyStateCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class PipelineInputAssemblyStateCreateInfoExtensions
	{
		internal unsafe static Interop.PipelineInputAssemblyStateCreateInfo* MarshalTo(this PipelineInputAssemblyStateCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineLayoutCreateInfo
	{
		public PipelineLayoutCreateFlags Flags
		{
			get;
			set;
		}

		public DescriptorSetLayout[] SetLayouts
		{
			get;
			set;
		}

		public PushConstantRange[] PushConstantRanges
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineLayoutCreateInfo Pack()
        {
            var result = new Interop.PipelineLayoutCreateInfo();
			result.Flags = this.Flags;
			result.SetLayouts = this.SetLayouts.MarshalTo();
			result.PushConstantRanges = this.PushConstantRanges.MarshalTo();

            return result;
        }

		internal unsafe Interop.PipelineLayoutCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PipelineLayoutCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PipelineLayoutCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class PipelineLayoutCreateInfoExtensions
	{
		internal unsafe static Interop.PipelineLayoutCreateInfo* MarshalTo(this PipelineLayoutCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineMultisampleStateCreateInfo
	{
		public PipelineMultisampleStateCreateFlags Flags
		{
			get;
			set;
		}

		public SampleCountFlags RasterizationSamples
		{
			get;
			set;
		}

		public Bool32 SampleShadingEnable
		{
			get;
			set;
		}

		public float MinSampleShading
		{
			get;
			set;
		}

		public SampleMask[] SampleMask
		{
			get;
			set;
		}

		public Bool32 AlphaToCoverageEnable
		{
			get;
			set;
		}

		public Bool32 AlphaToOneEnable
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineMultisampleStateCreateInfo Pack()
        {
            var result = new Interop.PipelineMultisampleStateCreateInfo();
			result.Flags = this.Flags;
			result.RasterizationSamples = this.RasterizationSamples;
			result.SampleShadingEnable = this.SampleShadingEnable;
			result.MinSampleShading = this.MinSampleShading;
			result.SampleMask = this.SampleMask.MarshalTo();
			result.AlphaToCoverageEnable = this.AlphaToCoverageEnable;
			result.AlphaToOneEnable = this.AlphaToOneEnable;

            return result;
        }

		internal unsafe Interop.PipelineMultisampleStateCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PipelineMultisampleStateCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PipelineMultisampleStateCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class PipelineMultisampleStateCreateInfoExtensions
	{
		internal unsafe static Interop.PipelineMultisampleStateCreateInfo* MarshalTo(this PipelineMultisampleStateCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineRasterizationStateCreateInfo
	{
		public PipelineRasterizationStateCreateFlags Flags
		{
			get;
			set;
		}

		public Bool32 DepthClampEnable
		{
			get;
			set;
		}

		public Bool32 RasterizerDiscardEnable
		{
			get;
			set;
		}

		public PolygonMode PolygonMode
		{
			get;
			set;
		}

		public CullModeFlags CullMode
		{
			get;
			set;
		}

		public FrontFace FrontFace
		{
			get;
			set;
		}

		public Bool32 DepthBiasEnable
		{
			get;
			set;
		}

		public float DepthBiasConstantFactor
		{
			get;
			set;
		}

		public float DepthBiasClamp
		{
			get;
			set;
		}

		public float DepthBiasSlopeFactor
		{
			get;
			set;
		}

		public float LineWidth
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineRasterizationStateCreateInfo Pack()
        {
            var result = new Interop.PipelineRasterizationStateCreateInfo();
			result.Flags = this.Flags;
			result.DepthClampEnable = this.DepthClampEnable;
			result.RasterizerDiscardEnable = this.RasterizerDiscardEnable;
			result.PolygonMode = this.PolygonMode;
			result.CullMode = this.CullMode;
			result.FrontFace = this.FrontFace;
			result.DepthBiasEnable = this.DepthBiasEnable;
			result.DepthBiasConstantFactor = this.DepthBiasConstantFactor;
			result.DepthBiasClamp = this.DepthBiasClamp;
			result.DepthBiasSlopeFactor = this.DepthBiasSlopeFactor;
			result.LineWidth = this.LineWidth;

            return result;
        }

		internal unsafe Interop.PipelineRasterizationStateCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PipelineRasterizationStateCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PipelineRasterizationStateCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class PipelineRasterizationStateCreateInfoExtensions
	{
		internal unsafe static Interop.PipelineRasterizationStateCreateInfo* MarshalTo(this PipelineRasterizationStateCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineShaderStageCreateInfo
	{
		public PipelineShaderStageCreateFlags Flags
		{
			get;
			set;
		}

		public ShaderStageFlags Stage
		{
			get;
			set;
		}

		public ShaderModule Module
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public SpecializationInfo SpecializationInfo
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineShaderStageCreateInfo Pack()
        {
            var result = new Interop.PipelineShaderStageCreateInfo();
			result.Flags = this.Flags;
			result.Stage = this.Stage;
			result.Module = this.Module.MarshalTo();
			result.Name = this.Name.MarshalTo();
			result.SpecializationInfo = this.SpecializationInfo.MarshalTo();

            return result;
        }

		internal unsafe Interop.PipelineShaderStageCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PipelineShaderStageCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PipelineShaderStageCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class PipelineShaderStageCreateInfoExtensions
	{
		internal unsafe static Interop.PipelineShaderStageCreateInfo* MarshalTo(this PipelineShaderStageCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineTessellationStateCreateInfo
	{
		public PipelineTessellationStateCreateFlags Flags
		{
			get;
			set;
		}

		public uint PatchControlPoints
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineTessellationStateCreateInfo Pack()
        {
            var result = new Interop.PipelineTessellationStateCreateInfo();
			result.Flags = this.Flags;
			result.PatchControlPoints = this.PatchControlPoints;

            return result;
        }

		internal unsafe Interop.PipelineTessellationStateCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PipelineTessellationStateCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PipelineTessellationStateCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class PipelineTessellationStateCreateInfoExtensions
	{
		internal unsafe static Interop.PipelineTessellationStateCreateInfo* MarshalTo(this PipelineTessellationStateCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineVertexInputStateCreateInfo
	{
		public PipelineVertexInputStateCreateFlags Flags
		{
			get;
			set;
		}

		public VertexInputBindingDescription[] VertexBindingDescriptions
		{
			get;
			set;
		}

		public VertexInputAttributeDescription[] VertexAttributeDescriptions
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineVertexInputStateCreateInfo Pack()
        {
            var result = new Interop.PipelineVertexInputStateCreateInfo();
			result.Flags = this.Flags;
			result.VertexBindingDescriptions = this.VertexBindingDescriptions.MarshalTo();
			result.VertexAttributeDescriptions = this.VertexAttributeDescriptions.MarshalTo();

            return result;
        }

		internal unsafe Interop.PipelineVertexInputStateCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PipelineVertexInputStateCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PipelineVertexInputStateCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class PipelineVertexInputStateCreateInfoExtensions
	{
		internal unsafe static Interop.PipelineVertexInputStateCreateInfo* MarshalTo(this PipelineVertexInputStateCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class PipelineViewportStateCreateInfo
	{
		public PipelineViewportStateCreateFlags Flags
		{
			get;
			set;
		}

		public Viewport[] Viewports
		{
			get;
			set;
		}

		public Rect2D[] Scissors
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineViewportStateCreateInfo Pack()
        {
            var result = new Interop.PipelineViewportStateCreateInfo();
			result.Flags = this.Flags;
			result.Viewports = this.Viewports.MarshalTo();
			result.Scissors = this.Scissors.MarshalTo();

            return result;
        }

		internal unsafe Interop.PipelineViewportStateCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.PipelineViewportStateCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.PipelineViewportStateCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class PipelineViewportStateCreateInfoExtensions
	{
		internal unsafe static Interop.PipelineViewportStateCreateInfo* MarshalTo(this PipelineViewportStateCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class QueryPoolCreateInfo
	{
		public QueryPoolCreateFlags Flags
		{
			get;
			set;
		}

		public QueryType QueryType
		{
			get;
			set;
		}

		public uint QueryCount
		{
			get;
			set;
		}

		public QueryPipelineStatisticFlags PipelineStatistics
		{
			get;
			set;
		}

        internal unsafe Interop.QueryPoolCreateInfo Pack()
        {
            var result = new Interop.QueryPoolCreateInfo();
			result.Flags = this.Flags;
			result.QueryType = this.QueryType;
			result.QueryCount = this.QueryCount;
			result.PipelineStatistics = this.PipelineStatistics;

            return result;
        }

		internal unsafe Interop.QueryPoolCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.QueryPoolCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.QueryPoolCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class QueryPoolCreateInfoExtensions
	{
		internal unsafe static Interop.QueryPoolCreateInfo* MarshalTo(this QueryPoolCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class RenderPassBeginInfo
	{
		public RenderPass RenderPass
		{
			get;
			set;
		}

		public Framebuffer Framebuffer
		{
			get;
			set;
		}

		public Rect2D RenderArea
		{
			get;
			set;
		}

		public ClearValue[] ClearValues
		{
			get;
			set;
		}

        internal unsafe Interop.RenderPassBeginInfo Pack()
        {
            var result = new Interop.RenderPassBeginInfo();
			result.RenderPass = this.RenderPass.MarshalTo();
			result.Framebuffer = this.Framebuffer.MarshalTo();
			result.RenderArea = this.RenderArea;
			result.ClearValues = this.ClearValues.MarshalTo();

            return result;
        }

		internal unsafe Interop.RenderPassBeginInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.RenderPassBeginInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.RenderPassBeginInfo*)pointer.ToPointer();
		}
	}

	internal static class RenderPassBeginInfoExtensions
	{
		internal unsafe static Interop.RenderPassBeginInfo* MarshalTo(this RenderPassBeginInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class RenderPassCreateInfo
	{
		public RenderPassCreateFlags Flags
		{
			get;
			set;
		}

		public AttachmentDescription[] Attachments
		{
			get;
			set;
		}

		public SubpassDescription[] Subpasses
		{
			get;
			set;
		}

		public SubpassDependency[] Dependencies
		{
			get;
			set;
		}

        internal unsafe Interop.RenderPassCreateInfo Pack()
        {
            var result = new Interop.RenderPassCreateInfo();
			result.Flags = this.Flags;
			result.Attachments = this.Attachments.MarshalTo();
			result.Subpasses = this.Subpasses.MarshalTo();
			result.Dependencies = this.Dependencies.MarshalTo();

            return result;
        }

		internal unsafe Interop.RenderPassCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.RenderPassCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.RenderPassCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class RenderPassCreateInfoExtensions
	{
		internal unsafe static Interop.RenderPassCreateInfo* MarshalTo(this RenderPassCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class SamplerCreateInfo
	{
		public SamplerCreateFlags Flags
		{
			get;
			set;
		}

		public Filter MagFilter
		{
			get;
			set;
		}

		public Filter MinFilter
		{
			get;
			set;
		}

		public SamplerMipmapMode MipmapMode
		{
			get;
			set;
		}

		public SamplerAddressMode AddressModeU
		{
			get;
			set;
		}

		public SamplerAddressMode AddressModeV
		{
			get;
			set;
		}

		public SamplerAddressMode AddressModeW
		{
			get;
			set;
		}

		public float MipLodBias
		{
			get;
			set;
		}

		public Bool32 AnisotropyEnable
		{
			get;
			set;
		}

		public float MaxAnisotropy
		{
			get;
			set;
		}

		public Bool32 CompareEnable
		{
			get;
			set;
		}

		public CompareOp CompareOp
		{
			get;
			set;
		}

		public float MinLod
		{
			get;
			set;
		}

		public float MaxLod
		{
			get;
			set;
		}

		public BorderColor BorderColor
		{
			get;
			set;
		}

		public Bool32 UnnormalizedCoordinates
		{
			get;
			set;
		}

        internal unsafe Interop.SamplerCreateInfo Pack()
        {
            var result = new Interop.SamplerCreateInfo();
			result.Flags = this.Flags;
			result.MagFilter = this.MagFilter;
			result.MinFilter = this.MinFilter;
			result.MipmapMode = this.MipmapMode;
			result.AddressModeU = this.AddressModeU;
			result.AddressModeV = this.AddressModeV;
			result.AddressModeW = this.AddressModeW;
			result.MipLodBias = this.MipLodBias;
			result.AnisotropyEnable = this.AnisotropyEnable;
			result.MaxAnisotropy = this.MaxAnisotropy;
			result.CompareEnable = this.CompareEnable;
			result.CompareOp = this.CompareOp;
			result.MinLod = this.MinLod;
			result.MaxLod = this.MaxLod;
			result.BorderColor = this.BorderColor;
			result.UnnormalizedCoordinates = this.UnnormalizedCoordinates;

            return result;
        }

		internal unsafe Interop.SamplerCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.SamplerCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.SamplerCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class SamplerCreateInfoExtensions
	{
		internal unsafe static Interop.SamplerCreateInfo* MarshalTo(this SamplerCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class SemaphoreCreateInfo
	{
		public SemaphoreCreateFlags Flags
		{
			get;
			set;
		}

        internal unsafe Interop.SemaphoreCreateInfo Pack()
        {
            var result = new Interop.SemaphoreCreateInfo();
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.SemaphoreCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.SemaphoreCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.SemaphoreCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class SemaphoreCreateInfoExtensions
	{
		internal unsafe static Interop.SemaphoreCreateInfo* MarshalTo(this SemaphoreCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class ShaderModuleCreateInfo
	{
		public ShaderModuleCreateFlags Flags
		{
			get;
			set;
		}

		public UIntPtr CodeSize
		{
			get;
			set;
		}

		public uint[] Code
		{
			get;
			set;
		}

        internal unsafe Interop.ShaderModuleCreateInfo Pack()
        {
            var result = new Interop.ShaderModuleCreateInfo();
			result.Flags = this.Flags;
			result.CodeSize = this.CodeSize;
			result.Code = this.Code.MarshalTo();

            return result;
        }

		internal unsafe Interop.ShaderModuleCreateInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.ShaderModuleCreateInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.ShaderModuleCreateInfo*)pointer.ToPointer();
		}
	}

	internal static class ShaderModuleCreateInfoExtensions
	{
		internal unsafe static Interop.ShaderModuleCreateInfo* MarshalTo(this ShaderModuleCreateInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class SparseBufferMemoryBindInfo
	{
		public Buffer Buffer
		{
			get;
			set;
		}

		public SparseMemoryBind[] Binds
		{
			get;
			set;
		}

        internal unsafe Interop.SparseBufferMemoryBindInfo Pack()
        {
            var result = new Interop.SparseBufferMemoryBindInfo();
			result.Buffer = this.Buffer.MarshalTo();
			result.Binds = this.Binds.MarshalTo();

            return result;
        }

		internal unsafe Interop.SparseBufferMemoryBindInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.SparseBufferMemoryBindInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.SparseBufferMemoryBindInfo*)pointer.ToPointer();
		}
	}

	internal static class SparseBufferMemoryBindInfoExtensions
	{
		internal unsafe static Interop.SparseBufferMemoryBindInfo* MarshalTo(this SparseBufferMemoryBindInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class SparseImageMemoryBind
	{
		public ImageSubresource Subresource
		{
			get;
			set;
		}

		public Offset3D Offset
		{
			get;
			set;
		}

		public Extent3D Extent
		{
			get;
			set;
		}

		public DeviceMemory Memory
		{
			get;
			set;
		}

		public DeviceSize MemoryOffset
		{
			get;
			set;
		}

		public SparseMemoryBindFlags Flags
		{
			get;
			set;
		}

        internal unsafe Interop.SparseImageMemoryBind Pack()
        {
            var result = new Interop.SparseImageMemoryBind();
			result.Subresource = this.Subresource;
			result.Offset = this.Offset;
			result.Extent = this.Extent;
			result.Memory = this.Memory.MarshalTo();
			result.MemoryOffset = this.MemoryOffset;
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.SparseImageMemoryBind* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.SparseImageMemoryBind>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.SparseImageMemoryBind*)pointer.ToPointer();
		}
	}

	internal static class SparseImageMemoryBindExtensions
	{
		internal unsafe static Interop.SparseImageMemoryBind* MarshalTo(this SparseImageMemoryBind[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class SparseImageMemoryBindInfo
	{
		public Image Image
		{
			get;
			set;
		}

		public SparseImageMemoryBind[] Binds
		{
			get;
			set;
		}

        internal unsafe Interop.SparseImageMemoryBindInfo Pack()
        {
            var result = new Interop.SparseImageMemoryBindInfo();
			result.Image = this.Image.MarshalTo();
			result.Binds = this.Binds.MarshalTo();

            return result;
        }

		internal unsafe Interop.SparseImageMemoryBindInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.SparseImageMemoryBindInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.SparseImageMemoryBindInfo*)pointer.ToPointer();
		}
	}

	internal static class SparseImageMemoryBindInfoExtensions
	{
		internal unsafe static Interop.SparseImageMemoryBindInfo* MarshalTo(this SparseImageMemoryBindInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class SparseImageOpaqueMemoryBindInfo
	{
		public Image Image
		{
			get;
			set;
		}

		public SparseMemoryBind[] Binds
		{
			get;
			set;
		}

        internal unsafe Interop.SparseImageOpaqueMemoryBindInfo Pack()
        {
            var result = new Interop.SparseImageOpaqueMemoryBindInfo();
			result.Image = this.Image.MarshalTo();
			result.Binds = this.Binds.MarshalTo();

            return result;
        }

		internal unsafe Interop.SparseImageOpaqueMemoryBindInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.SparseImageOpaqueMemoryBindInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.SparseImageOpaqueMemoryBindInfo*)pointer.ToPointer();
		}
	}

	internal static class SparseImageOpaqueMemoryBindInfoExtensions
	{
		internal unsafe static Interop.SparseImageOpaqueMemoryBindInfo* MarshalTo(this SparseImageOpaqueMemoryBindInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class SparseMemoryBind
	{
		public DeviceSize ResourceOffset
		{
			get;
			set;
		}

		public DeviceSize Size
		{
			get;
			set;
		}

		public DeviceMemory Memory
		{
			get;
			set;
		}

		public DeviceSize MemoryOffset
		{
			get;
			set;
		}

		public SparseMemoryBindFlags Flags
		{
			get;
			set;
		}

        internal unsafe Interop.SparseMemoryBind Pack()
        {
            var result = new Interop.SparseMemoryBind();
			result.ResourceOffset = this.ResourceOffset;
			result.Size = this.Size;
			result.Memory = this.Memory.MarshalTo();
			result.MemoryOffset = this.MemoryOffset;
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.SparseMemoryBind* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.SparseMemoryBind>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.SparseMemoryBind*)pointer.ToPointer();
		}
	}

	internal static class SparseMemoryBindExtensions
	{
		internal unsafe static Interop.SparseMemoryBind* MarshalTo(this SparseMemoryBind[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class SpecializationInfo
	{
		public SpecializationMapEntry[] MapEntries
		{
			get;
			set;
		}

		public byte[] Data
		{
			get;
			set;
		}

        internal unsafe Interop.SpecializationInfo Pack()
        {
            var result = new Interop.SpecializationInfo();
			result.MapEntries = this.MapEntries.MarshalTo();
			result.Data = this.Data.MarshalTo();

            return result;
        }

		internal unsafe Interop.SpecializationInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.SpecializationInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.SpecializationInfo*)pointer.ToPointer();
		}
	}

	internal static class SpecializationInfoExtensions
	{
		internal unsafe static Interop.SpecializationInfo* MarshalTo(this SpecializationInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class SubmitInfo
	{
		public Semaphore[] WaitSemaphores
		{
			get;
			set;
		}

		public PipelineStageFlags[] WaitDestinationStageMask
		{
			get;
			set;
		}

		public CommandBuffer[] CommandBuffers
		{
			get;
			set;
		}

		public Semaphore[] SignalSemaphores
		{
			get;
			set;
		}

        internal unsafe Interop.SubmitInfo Pack()
        {
            var result = new Interop.SubmitInfo();
			result.WaitSemaphores = this.WaitSemaphores.MarshalTo();
			result.WaitDestinationStageMask = this.WaitDestinationStageMask.MarshalTo();
			result.CommandBuffers = this.CommandBuffers.MarshalTo();
			result.SignalSemaphores = this.SignalSemaphores.MarshalTo();

            return result;
        }

		internal unsafe Interop.SubmitInfo* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.SubmitInfo>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.SubmitInfo*)pointer.ToPointer();
		}
	}

	internal static class SubmitInfoExtensions
	{
		internal unsafe static Interop.SubmitInfo* MarshalTo(this SubmitInfo[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class SubpassDescription
	{
		public SubpassDescriptionFlags Flags
		{
			get;
			set;
		}

		public PipelineBindPoint PipelineBindPoint
		{
			get;
			set;
		}

		public AttachmentReference[] InputAttachments
		{
			get;
			set;
		}

		public AttachmentReference[] ColorAttachments
		{
			get;
			set;
		}

		public AttachmentReference[] ResolveAttachments
		{
			get;
			set;
		}

		public AttachmentReference DepthStencilAttachment
		{
			get;
			set;
		}

		public uint[] PreserveAttachments
		{
			get;
			set;
		}

        internal unsafe Interop.SubpassDescription Pack()
        {
            var result = new Interop.SubpassDescription();
			result.Flags = this.Flags;
			result.PipelineBindPoint = this.PipelineBindPoint;
			result.InputAttachments = this.InputAttachments.MarshalTo();
			result.ColorAttachments = this.ColorAttachments.MarshalTo();
			result.ResolveAttachments = this.ResolveAttachments.MarshalTo();
			result.DepthStencilAttachment = this.DepthStencilAttachment.MarshalTo();
			result.PreserveAttachments = this.PreserveAttachments.MarshalTo();

            return result;
        }

		internal unsafe Interop.SubpassDescription* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.SubpassDescription>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.SubpassDescription*)pointer.ToPointer();
		}
	}

	internal static class SubpassDescriptionExtensions
	{
		internal unsafe static Interop.SubpassDescription* MarshalTo(this SubpassDescription[] values)
		{
			throw new NotImplementedException();
		}
	}

	public class WriteDescriptorSet
	{
		public DescriptorSet DestinationSet
		{
			get;
			set;
		}

		public uint DestinationBinding
		{
			get;
			set;
		}

		public uint DestinationArrayElement
		{
			get;
			set;
		}

		public DescriptorType DescriptorType
		{
			get;
			set;
		}

		public DescriptorImageInfo[] ImageInfo
		{
			get;
			set;
		}

		public DescriptorBufferInfo[] BufferInfo
		{
			get;
			set;
		}

		public BufferView[] TexelBufferView
		{
			get;
			set;
		}

        internal unsafe Interop.WriteDescriptorSet Pack()
        {
            var result = new Interop.WriteDescriptorSet();
			result.DestinationSet = this.DestinationSet.MarshalTo();
			result.DestinationBinding = this.DestinationBinding;
			result.DestinationArrayElement = this.DestinationArrayElement;
			result.DescriptorType = this.DescriptorType;
			result.ImageInfo = this.ImageInfo.MarshalTo();
			result.BufferInfo = this.BufferInfo.MarshalTo();
			result.TexelBufferView = this.TexelBufferView.MarshalTo();

            return result;
        }

		internal unsafe Interop.WriteDescriptorSet* MarshalTo()
        {
            IntPtr pointer = Marshal.AllocHGlobal(Marshal.SizeOf<Interop.WriteDescriptorSet>());

            Marshal.StructureToPtr(this.Pack(), pointer, false);

            return (Interop.WriteDescriptorSet*)pointer.ToPointer();
		}
	}

	internal static class WriteDescriptorSetExtensions
	{
		internal unsafe static Interop.WriteDescriptorSet* MarshalTo(this WriteDescriptorSet[] values)
		{
			throw new NotImplementedException();
		}
	}
}