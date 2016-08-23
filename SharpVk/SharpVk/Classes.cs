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

namespace SharpVk
{

    /// <summary>
    /// 
    /// </summary>
	public struct AllocationCallbacks
	{

		public IntPtr UserData
		{
			get;
			set;
		}

        internal unsafe Interop.AllocationCallbacks Pack()
        {
            var result = new Interop.AllocationCallbacks();
			result.UserData = this.UserData.ToPointer();

            return result;
        }

		internal unsafe Interop.AllocationCallbacks* MarshalTo()
        {
            return (Interop.AllocationCallbacks*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct AndroidSurfaceCreateInfo
	{

		public AndroidSurfaceCreateFlags Flags
		{
			get;
			set;
		}

		public IntPtr Window
		{
			get;
			set;
		}

        internal unsafe Interop.AndroidSurfaceCreateInfo Pack()
        {
            var result = new Interop.AndroidSurfaceCreateInfo();
			result.SType = StructureType.AndroidSurfaceCreateInfo;
			result.Window = (IntPtr*)Interop.HeapUtil.AllocateAndMarshal(this.Window);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.AndroidSurfaceCreateInfo* MarshalTo()
        {
            return (Interop.AndroidSurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct ApplicationInfo
	{

		public string ApplicationName
		{
			get;
			set;
		}

		public Version ApplicationVersion
		{
			get;
			set;
		}

		public string EngineName
		{
			get;
			set;
		}

		public Version EngineVersion
		{
			get;
			set;
		}

		public Version ApiVersion
		{
			get;
			set;
		}

        internal unsafe Interop.ApplicationInfo Pack()
        {
            var result = new Interop.ApplicationInfo();
			result.SType = StructureType.ApplicationInfo;
			result.ApplicationName = Interop.HeapUtil.MarshalTo(this.ApplicationName);
			result.EngineName = Interop.HeapUtil.MarshalTo(this.EngineName);
			result.ApplicationVersion = this.ApplicationVersion;
			result.EngineVersion = this.EngineVersion;
			result.ApiVersion = this.ApiVersion;

            return result;
        }

		internal unsafe Interop.ApplicationInfo* MarshalTo()
        {
            return (Interop.ApplicationInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct BindSparseInfo
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
			result.SType = StructureType.BindSparseInfo;
			
			//WaitSemaphores
			if (this.WaitSemaphores != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.Semaphore>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.Semaphore>(this.WaitSemaphores.Length);
			    for (int index = 0; index < this.WaitSemaphores.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.WaitSemaphores[index].Pack(), pointer + (size * index), false);
			    }
			    result.WaitSemaphores = (Interop.Semaphore*)pointer.ToPointer();
			}
			else
			{
			    result.WaitSemaphores = null;
			}
			
			//BufferBinds
			if (this.BufferBinds != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SparseBufferMemoryBindInfo>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.SparseBufferMemoryBindInfo>(this.BufferBinds.Length);
			    for (int index = 0; index < this.BufferBinds.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.BufferBinds[index].Pack(), pointer + (size * index), false);
			    }
			    result.BufferBinds = (Interop.SparseBufferMemoryBindInfo*)pointer.ToPointer();
			}
			else
			{
			    result.BufferBinds = null;
			}
			
			//ImageOpaqueBinds
			if (this.ImageOpaqueBinds != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SparseImageOpaqueMemoryBindInfo>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.SparseImageOpaqueMemoryBindInfo>(this.ImageOpaqueBinds.Length);
			    for (int index = 0; index < this.ImageOpaqueBinds.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.ImageOpaqueBinds[index].Pack(), pointer + (size * index), false);
			    }
			    result.ImageOpaqueBinds = (Interop.SparseImageOpaqueMemoryBindInfo*)pointer.ToPointer();
			}
			else
			{
			    result.ImageOpaqueBinds = null;
			}
			
			//ImageBinds
			if (this.ImageBinds != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SparseImageMemoryBindInfo>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.SparseImageMemoryBindInfo>(this.ImageBinds.Length);
			    for (int index = 0; index < this.ImageBinds.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.ImageBinds[index].Pack(), pointer + (size * index), false);
			    }
			    result.ImageBinds = (Interop.SparseImageMemoryBindInfo*)pointer.ToPointer();
			}
			else
			{
			    result.ImageBinds = null;
			}
			
			//SignalSemaphores
			if (this.SignalSemaphores != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.Semaphore>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.Semaphore>(this.SignalSemaphores.Length);
			    for (int index = 0; index < this.SignalSemaphores.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.SignalSemaphores[index].Pack(), pointer + (size * index), false);
			    }
			    result.SignalSemaphores = (Interop.Semaphore*)pointer.ToPointer();
			}
			else
			{
			    result.SignalSemaphores = null;
			}
			result.WaitSemaphoreCount = (uint)(this.WaitSemaphores?.Length ?? 0);
			result.BufferBindCount = (uint)(this.BufferBinds?.Length ?? 0);
			result.ImageOpaqueBindCount = (uint)(this.ImageOpaqueBinds?.Length ?? 0);
			result.ImageBindCount = (uint)(this.ImageBinds?.Length ?? 0);
			result.SignalSemaphoreCount = (uint)(this.SignalSemaphores?.Length ?? 0);

            return result;
        }

		internal unsafe Interop.BindSparseInfo* MarshalTo()
        {
            return (Interop.BindSparseInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// Bits which can: be set in pname:usage are:
    /// // refBegin VkBufferUsageFlagBits - Bitmask specifying allowed usage of a buffer
    /// include::../api/enums/VkBufferUsageFlagBits.txt[]
    ///   * ename:VK_BUFFER_USAGE_TRANSFER_SRC_BIT indicates that the buffer can: be
    ///     used as the source of a _transfer command_ (see the definition of
    ///     <<synchronization-transfer,ename:VK_PIPELINE_STAGE_TRANSFER_BIT>>).
    ///   * ename:VK_BUFFER_USAGE_TRANSFER_DST_BIT indicates that the buffer
    ///     can: be used as the destination of a transfer command.
    ///   * ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT indicates that the buffer
    ///     can: be used to create a sname:VkBufferView suitable for occupying a
    ///     sname:VkDescriptorSet slot of type
    ///     ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER.
    ///   * ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT indicates that the buffer
    ///     can: be used to create a sname:VkBufferView suitable for occupying a
    ///     sname:VkDescriptorSet slot of type
    ///     ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER.
    ///   * ename:VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT indicates that the buffer can:
    ///     be used in a sname:VkDescriptorBufferInfo suitable for occupying a
    ///     sname:VkDescriptorSet slot either of type
    ///     ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
    ///     ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC.
    ///   * ename:VK_BUFFER_USAGE_STORAGE_BUFFER_BIT indicates that the buffer can:
    ///     be used in a sname:VkDescriptorBufferInfo suitable for occupying a
    ///     sname:VkDescriptorSet slot either of type
    ///     ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
    ///     ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC.
    ///   * ename:VK_BUFFER_USAGE_INDEX_BUFFER_BIT indicates that the buffer is
    ///     suitable for passing as the pname:buffer parameter to
    ///     fname:vkCmdBindIndexBuffer.
    ///   * ename:VK_BUFFER_USAGE_VERTEX_BUFFER_BIT indicates that the buffer is
    ///     suitable for passing as an element of the pname:pBuffers array to
    ///     fname:vkCmdBindVertexBuffers.
    ///   * ename:VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT indicates that the buffer is
    ///     suitable for passing as the pname:buffer parameter to
    ///     fname:vkCmdDrawIndirect, fname:vkCmdDrawIndexedIndirect, or
    ///     fname:vkCmdDispatchIndirect.
    /// Any combination of bits can: be specified for pname:usage, but at least one
    /// of the bits must: be set in order to create a valid buffer.
    /// Bits which can: be set in pname:flags are:
    /// // refBegin VkBufferCreateFlagBits - Bitmask specifying additional parameters of a buffer
    /// include::../api/enums/VkBufferCreateFlagBits.txt[]
    /// These bits have the following meanings:
    ///   * ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT indicates that the buffer will
    ///     be backed using sparse memory binding.
    ///   * ename:VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT indicates that the buffer
    ///     can: be partially backed using sparse memory binding. Buffers
    ///     created with this flag must: also be created with the
    ///     ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT flag.
    ///   * ename:VK_BUFFER_CREATE_SPARSE_ALIASED_BIT indicates that the buffer will
    ///     be backed using sparse memory binding with memory ranges that might also
    ///     simultaneously be backing another buffer (or another portion of the same
    ///     buffer). Buffers created with this flag must: also be created
    ///     with the ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT flag.
    /// See <<sparsememory-sparseresourcefeatures,Sparse Resource Features>> and
    /// <<features-features,Physical Device Features>> for details of the sparse
    /// memory features supported on a device.
    /// </summary>
	public struct BufferCreateInfo
	{

		public BufferCreateFlags Flags
		{
			get;
			set;
		}

		public ulong Size
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
			result.SType = StructureType.BufferCreateInfo;
			result.QueueFamilyIndices = this.QueueFamilyIndices == null ? null : Interop.HeapUtil.MarshalTo(this.QueueFamilyIndices);
			result.QueueFamilyIndexCount = (uint)(this.QueueFamilyIndices?.Length ?? 0);
			result.Flags = this.Flags;
			result.Size = this.Size;
			result.Usage = this.Usage;
			result.SharingMode = this.SharingMode;

            return result;
        }

		internal unsafe Interop.BufferCreateInfo* MarshalTo()
        {
            return (Interop.BufferCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct BufferMemoryBarrier
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

		public ulong Offset
		{
			get;
			set;
		}

		public ulong Size
		{
			get;
			set;
		}

        internal unsafe Interop.BufferMemoryBarrier Pack()
        {
            var result = new Interop.BufferMemoryBarrier();
			result.SType = StructureType.BufferMemoryBarrier;
			result.Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;
			result.SourceAccessMask = this.SourceAccessMask;
			result.DestinationAccessMask = this.DestinationAccessMask;
			result.SourceQueueFamilyIndex = this.SourceQueueFamilyIndex;
			result.DestinationQueueFamilyIndex = this.DestinationQueueFamilyIndex;
			result.Offset = this.Offset;
			result.Size = this.Size;

            return result;
        }

		internal unsafe Interop.BufferMemoryBarrier* MarshalTo()
        {
            return (Interop.BufferMemoryBarrier*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct BufferViewCreateInfo
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

		public ulong Offset
		{
			get;
			set;
		}

		public ulong Range
		{
			get;
			set;
		}

        internal unsafe Interop.BufferViewCreateInfo Pack()
        {
            var result = new Interop.BufferViewCreateInfo();
			result.SType = StructureType.BufferViewCreateInfo;
			result.Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;
			result.Flags = this.Flags;
			result.Format = this.Format;
			result.Offset = this.Offset;
			result.Range = this.Range;

            return result;
        }

		internal unsafe Interop.BufferViewCreateInfo* MarshalTo()
        {
            return (Interop.BufferViewCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct CommandBufferAllocateInfo
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
			result.SType = StructureType.CommandBufferAllocateInfo;
			result.CommandPool = this.CommandPool?.Pack() ?? Interop.CommandPool.Null;
			result.Level = this.Level;
			result.CommandBufferCount = this.CommandBufferCount;

            return result;
        }

		internal unsafe Interop.CommandBufferAllocateInfo* MarshalTo()
        {
            return (Interop.CommandBufferAllocateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct CommandBufferBeginInfo
	{

		public CommandBufferUsageFlags Flags
		{
			get;
			set;
		}

		public CommandBufferInheritanceInfo? InheritanceInfo
		{
			get;
			set;
		}

        internal unsafe Interop.CommandBufferBeginInfo Pack()
        {
            var result = new Interop.CommandBufferBeginInfo();
			result.SType = StructureType.CommandBufferBeginInfo;
			result.InheritanceInfo = this.InheritanceInfo == null ? null : this.InheritanceInfo.Value.MarshalTo();
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.CommandBufferBeginInfo* MarshalTo()
        {
            return (Interop.CommandBufferBeginInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct CommandBufferInheritanceInfo
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
			result.SType = StructureType.CommandBufferInheritanceInfo;
			result.RenderPass = this.RenderPass?.Pack() ?? Interop.RenderPass.Null;
			result.Framebuffer = this.Framebuffer?.Pack() ?? Interop.Framebuffer.Null;
			result.Subpass = this.Subpass;
			result.OcclusionQueryEnable = this.OcclusionQueryEnable;
			result.QueryFlags = this.QueryFlags;
			result.PipelineStatistics = this.PipelineStatistics;

            return result;
        }

		internal unsafe Interop.CommandBufferInheritanceInfo* MarshalTo()
        {
            return (Interop.CommandBufferInheritanceInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct CommandPoolCreateInfo
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
			result.SType = StructureType.CommandPoolCreateInfo;
			result.Flags = this.Flags;
			result.QueueFamilyIndex = this.QueueFamilyIndex;

            return result;
        }

		internal unsafe Interop.CommandPoolCreateInfo* MarshalTo()
        {
            return (Interop.CommandPoolCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// The parameters pname:basePipelineHandle and pname:basePipelineIndex are
    /// described in more detail in
    /// <<pipelines-pipeline-derivatives,Pipeline Derivatives>>.
    /// pname:stage points to a structure of type
    /// sname:VkPipelineShaderStageCreateInfo.
    /// </summary>
	public struct ComputePipelineCreateInfo
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
			result.SType = StructureType.ComputePipelineCreateInfo;
			result.Stage = this.Stage.Pack();
			result.Layout = this.Layout?.Pack() ?? Interop.PipelineLayout.Null;
			result.BasePipelineHandle = this.BasePipelineHandle?.Pack() ?? Interop.Pipeline.Null;
			result.Flags = this.Flags;
			result.BasePipelineIndex = this.BasePipelineIndex;

            return result;
        }

		internal unsafe Interop.ComputePipelineCreateInfo* MarshalTo()
        {
            return (Interop.ComputePipelineCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct CopyDescriptorSet
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
			result.SType = StructureType.CopyDescriptorSet;
			result.SourceSet = this.SourceSet?.Pack() ?? Interop.DescriptorSet.Null;
			result.DestinationSet = this.DestinationSet?.Pack() ?? Interop.DescriptorSet.Null;
			result.SourceBinding = this.SourceBinding;
			result.SourceArrayElement = this.SourceArrayElement;
			result.DestinationBinding = this.DestinationBinding;
			result.DestinationArrayElement = this.DestinationArrayElement;
			result.DescriptorCount = this.DescriptorCount;

            return result;
        }

		internal unsafe Interop.CopyDescriptorSet* MarshalTo()
        {
            return (Interop.CopyDescriptorSet*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DebugMarkerMarkerInfo
	{

		public string MarkerName
		{
			get;
			set;
		}

		public float[] Color
		{
			get;
			set;
		}

        internal unsafe Interop.DebugMarkerMarkerInfo Pack()
        {
            var result = new Interop.DebugMarkerMarkerInfo();
			result.SType = StructureType.DebugMarkerMarkerInfo;
			result.MarkerName = Interop.HeapUtil.MarshalTo(this.MarkerName);

            return result;
        }

		internal unsafe Interop.DebugMarkerMarkerInfo* MarshalTo()
        {
            return (Interop.DebugMarkerMarkerInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DebugMarkerObjectNameInfo
	{

		public DebugReportObjectType ObjectType
		{
			get;
			set;
		}

		public ulong Object
		{
			get;
			set;
		}

		public string ObjectName
		{
			get;
			set;
		}

        internal unsafe Interop.DebugMarkerObjectNameInfo Pack()
        {
            var result = new Interop.DebugMarkerObjectNameInfo();
			result.SType = StructureType.DebugMarkerObjectNameInfo;
			result.ObjectName = Interop.HeapUtil.MarshalTo(this.ObjectName);
			result.ObjectType = this.ObjectType;
			result.Object = this.Object;

            return result;
        }

		internal unsafe Interop.DebugMarkerObjectNameInfo* MarshalTo()
        {
            return (Interop.DebugMarkerObjectNameInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DebugMarkerObjectTagInfo
	{

		public DebugReportObjectType ObjectType
		{
			get;
			set;
		}

		public ulong Object
		{
			get;
			set;
		}

		public ulong TagName
		{
			get;
			set;
		}

		public byte[] Tag
		{
			get;
			set;
		}

        internal unsafe Interop.DebugMarkerObjectTagInfo Pack()
        {
            var result = new Interop.DebugMarkerObjectTagInfo();
			result.SType = StructureType.DebugMarkerObjectTagInfo;
			result.Tag = this.Tag == null ? null : Interop.HeapUtil.MarshalTo(this.Tag);
			result.TagSize = (UIntPtr)(this.Tag?.Length ?? 0);
			result.ObjectType = this.ObjectType;
			result.Object = this.Object;
			result.TagName = this.TagName;

            return result;
        }

		internal unsafe Interop.DebugMarkerObjectTagInfo* MarshalTo()
        {
            return (Interop.DebugMarkerObjectTagInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DebugReportCallbackCreateInfo
	{

		public DebugReportFlags Flags
		{
			get;
			set;
		}

		public IntPtr UserData
		{
			get;
			set;
		}

        internal unsafe Interop.DebugReportCallbackCreateInfo Pack()
        {
            var result = new Interop.DebugReportCallbackCreateInfo();
			result.SType = StructureType.DebugReportCallbackCreateInfo;
			result.UserData = this.UserData.ToPointer();
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.DebugReportCallbackCreateInfo* MarshalTo()
        {
            return (Interop.DebugReportCallbackCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DedicatedAllocationBufferCreateInfo
	{

		public Bool32 DedicatedAllocation
		{
			get;
			set;
		}

        internal unsafe Interop.DedicatedAllocationBufferCreateInfo Pack()
        {
            var result = new Interop.DedicatedAllocationBufferCreateInfo();
			result.SType = StructureType.DedicatedAllocationBufferCreateInfo;
			result.DedicatedAllocation = this.DedicatedAllocation;

            return result;
        }

		internal unsafe Interop.DedicatedAllocationBufferCreateInfo* MarshalTo()
        {
            return (Interop.DedicatedAllocationBufferCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DedicatedAllocationImageCreateInfo
	{

		public Bool32 DedicatedAllocation
		{
			get;
			set;
		}

        internal unsafe Interop.DedicatedAllocationImageCreateInfo Pack()
        {
            var result = new Interop.DedicatedAllocationImageCreateInfo();
			result.SType = StructureType.DedicatedAllocationImageCreateInfo;
			result.DedicatedAllocation = this.DedicatedAllocation;

            return result;
        }

		internal unsafe Interop.DedicatedAllocationImageCreateInfo* MarshalTo()
        {
            return (Interop.DedicatedAllocationImageCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DedicatedAllocationMemoryAllocateInfo
	{

		public Image Image
		{
			get;
			set;
		}

		public Buffer Buffer
		{
			get;
			set;
		}

        internal unsafe Interop.DedicatedAllocationMemoryAllocateInfo Pack()
        {
            var result = new Interop.DedicatedAllocationMemoryAllocateInfo();
			result.SType = StructureType.DedicatedAllocationMemoryAllocateInfo;
			result.Image = this.Image?.Pack() ?? Interop.Image.Null;
			result.Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;

            return result;
        }

		internal unsafe Interop.DedicatedAllocationMemoryAllocateInfo* MarshalTo()
        {
            return (Interop.DedicatedAllocationMemoryAllocateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DescriptorBufferInfo
	{

		public Buffer Buffer
		{
			get;
			set;
		}

		public ulong Offset
		{
			get;
			set;
		}

		public ulong Range
		{
			get;
			set;
		}

        internal unsafe Interop.DescriptorBufferInfo Pack()
        {
            var result = new Interop.DescriptorBufferInfo();
			result.Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;
			result.Offset = this.Offset;
			result.Range = this.Range;

            return result;
        }

		internal unsafe Interop.DescriptorBufferInfo* MarshalTo()
        {
            return (Interop.DescriptorBufferInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// Members of sname:VkDescriptorImageInfo that are not used in an update (as
    /// described above) are ignored.
    /// </summary>
	public struct DescriptorImageInfo
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
			result.Sampler = this.Sampler?.Pack() ?? Interop.Sampler.Null;
			result.ImageView = this.ImageView?.Pack() ?? Interop.ImageView.Null;
			result.ImageLayout = this.ImageLayout;

            return result;
        }

		internal unsafe Interop.DescriptorImageInfo* MarshalTo()
        {
            return (Interop.DescriptorImageInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// If multiple sname:VkDescriptorPoolSize structures appear in the
    /// pname:pPoolSizes array then the pool will be created with enough storage
    /// for the total number of descriptors of each type.
    /// Fragmentation of a descriptor pool is possible and may: lead to descriptor
    /// set allocation failures. A failure due to fragmentation is defined as
    /// failing a descriptor set allocation despite the sum of all outstanding
    /// descriptor set allocations from the pool plus the requested allocation
    /// requiring no more than the total number of descriptors requested at pool
    /// creation. Implementations provide certain guarantees of when fragmentation
    /// mustnot: cause allocation failure, as described below.
    /// If a descriptor pool has not had any descriptor sets freed since it was
    /// created or most recently reset then fragmentation mustnot: cause an
    /// allocation failure (note that this is always the case for a pool created
    /// without the ename:VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT bit
    /// set). Additionally, if all sets allocated from the pool since it was created
    /// or most recently reset use the same number of descriptors (of each type) and
    /// the requested allocation also uses that same number of descriptors (of each
    /// type), then fragmentation mustnot: cause an allocation failure.
    /// If an allocation failure occurs due to fragmentation, an application can:
    /// create an additional descriptor pool to perform further descriptor set
    /// allocations.
    /// </summary>
	public struct DescriptorPoolCreateInfo
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
			result.SType = StructureType.DescriptorPoolCreateInfo;
			
			//PoolSizes
			if (this.PoolSizes != null)
			{
			    result.PoolSizes = (DescriptorPoolSize*)Interop.HeapUtil.Allocate<DescriptorPoolSize>(this.PoolSizes.Length).ToPointer();
			    for (int index = 0; index < this.PoolSizes.Length; index++)
			    {
			        result.PoolSizes[index] = this.PoolSizes[index];
			    }
			}
			else
			{
			    result.PoolSizes = null;
			}
			result.PoolSizeCount = (uint)(this.PoolSizes?.Length ?? 0);
			result.Flags = this.Flags;
			result.MaxSets = this.MaxSets;

            return result;
        }

		internal unsafe Interop.DescriptorPoolCreateInfo* MarshalTo()
        {
            return (Interop.DescriptorPoolCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DescriptorSetAllocateInfo
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
			result.SType = StructureType.DescriptorSetAllocateInfo;
			result.DescriptorPool = this.DescriptorPool?.Pack() ?? Interop.DescriptorPool.Null;
			
			//SetLayouts
			if (this.SetLayouts != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DescriptorSetLayout>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DescriptorSetLayout>(this.SetLayouts.Length);
			    for (int index = 0; index < this.SetLayouts.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.SetLayouts[index].Pack(), pointer + (size * index), false);
			    }
			    result.SetLayouts = (Interop.DescriptorSetLayout*)pointer.ToPointer();
			}
			else
			{
			    result.SetLayouts = null;
			}
			result.DescriptorSetCount = (uint)(this.SetLayouts?.Length ?? 0);

            return result;
        }

		internal unsafe Interop.DescriptorSetAllocateInfo* MarshalTo()
        {
            return (Interop.DescriptorSetAllocateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// The above layout definition allows the descriptor bindings to be specified
    /// sparsely such that not all binding numbers between 0 and the maximum
    /// binding number need to be specified in the pname:pBindings array. However,
    /// all binding numbers between 0 and the maximum binding number may: consume
    /// memory in the descriptor set layout even if not all descriptor bindings are
    /// used, though it shouldnot:
    /// consume additional memory from the descriptor pool.
    /// [NOTE]
    /// .Note
    /// ====
    /// The maximum binding number specified should: be as compact as possible to
    /// avoid wasted memory.
    /// ====
    /// </summary>
	public struct DescriptorSetLayoutBinding
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
			
			//ImmutableSamplers
			if (this.ImmutableSamplers != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.Sampler>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.Sampler>(this.ImmutableSamplers.Length);
			    for (int index = 0; index < this.ImmutableSamplers.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.ImmutableSamplers[index].Pack(), pointer + (size * index), false);
			    }
			    result.ImmutableSamplers = (Interop.Sampler*)pointer.ToPointer();
			}
			else
			{
			    result.ImmutableSamplers = null;
			}
			result.DescriptorCount = (uint)(this.ImmutableSamplers?.Length ?? 0);
			result.Binding = this.Binding;
			result.DescriptorType = this.DescriptorType;
			result.StageFlags = this.StageFlags;

            return result;
        }

		internal unsafe Interop.DescriptorSetLayoutBinding* MarshalTo()
        {
            return (Interop.DescriptorSetLayoutBinding*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DescriptorSetLayoutCreateInfo
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
			result.SType = StructureType.DescriptorSetLayoutCreateInfo;
			
			//Bindings
			if (this.Bindings != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DescriptorSetLayoutBinding>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DescriptorSetLayoutBinding>(this.Bindings.Length);
			    for (int index = 0; index < this.Bindings.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.Bindings[index].Pack(), pointer + (size * index), false);
			    }
			    result.Bindings = (Interop.DescriptorSetLayoutBinding*)pointer.ToPointer();
			}
			else
			{
			    result.Bindings = null;
			}
			result.BindingCount = (uint)(this.Bindings?.Length ?? 0);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.DescriptorSetLayoutCreateInfo* MarshalTo()
        {
            return (Interop.DescriptorSetLayoutCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DeviceCreateInfo
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
			result.SType = StructureType.DeviceCreateInfo;
			
			//QueueCreateInfos
			if (this.QueueCreateInfos != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DeviceQueueCreateInfo>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DeviceQueueCreateInfo>(this.QueueCreateInfos.Length);
			    for (int index = 0; index < this.QueueCreateInfos.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.QueueCreateInfos[index].Pack(), pointer + (size * index), false);
			    }
			    result.QueueCreateInfos = (Interop.DeviceQueueCreateInfo*)pointer.ToPointer();
			}
			else
			{
			    result.QueueCreateInfos = null;
			}
			result.EnabledLayerNames = this.EnabledLayerNames == null ? null : Interop.HeapUtil.MarshalTo(this.EnabledLayerNames);
			result.EnabledExtensionNames = this.EnabledExtensionNames == null ? null : Interop.HeapUtil.MarshalTo(this.EnabledExtensionNames);
			result.EnabledFeatures = (PhysicalDeviceFeatures*)Interop.HeapUtil.AllocateAndMarshal(this.EnabledFeatures);
			result.QueueCreateInfoCount = (uint)(this.QueueCreateInfos?.Length ?? 0);
			result.EnabledLayerCount = (uint)(this.EnabledLayerNames?.Length ?? 0);
			result.EnabledExtensionCount = (uint)(this.EnabledExtensionNames?.Length ?? 0);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.DeviceCreateInfo* MarshalTo()
        {
            return (Interop.DeviceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DeviceQueueCreateInfo
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
			result.SType = StructureType.DeviceQueueCreateInfo;
			result.QueuePriorities = this.QueuePriorities == null ? null : Interop.HeapUtil.MarshalTo(this.QueuePriorities);
			result.QueueCount = (uint)(this.QueuePriorities?.Length ?? 0);
			result.Flags = this.Flags;
			result.QueueFamilyIndex = this.QueueFamilyIndex;

            return result;
        }

		internal unsafe Interop.DeviceQueueCreateInfo* MarshalTo()
        {
            return (Interop.DeviceQueueCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DisplayModeCreateInfo
	{

		public DisplayModeCreateFlags Flags
		{
			get;
			set;
		}

		public DisplayModeParameters Parameters
		{
			get;
			set;
		}

        internal unsafe Interop.DisplayModeCreateInfo Pack()
        {
            var result = new Interop.DisplayModeCreateInfo();
			result.SType = StructureType.DisplayModeCreateInfo;
			result.Flags = this.Flags;
			result.Parameters = this.Parameters;

            return result;
        }

		internal unsafe Interop.DisplayModeCreateInfo* MarshalTo()
        {
            return (Interop.DisplayModeCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DisplayModeProperties
	{

		public DisplayMode DisplayMode
		{
			get;
			set;
		}

		public DisplayModeParameters Parameters
		{
			get;
			set;
		}

		internal unsafe DisplayModeProperties Unpack(Interop.DisplayModeProperties value)
		{
			return MarshalFrom(&value);
		}

		internal static unsafe DisplayModeProperties MarshalFrom(Interop.DisplayModeProperties* value)
		{
            var result = new DisplayModeProperties();

			result.Parameters = value->Parameters;

			return result;
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DisplayPlaneProperties
	{

		public Display CurrentDisplay
		{
			get;
			set;
		}

		public uint CurrentStackIndex
		{
			get;
			set;
		}

		internal unsafe DisplayPlaneProperties Unpack(Interop.DisplayPlaneProperties value)
		{
			return MarshalFrom(&value);
		}

		internal static unsafe DisplayPlaneProperties MarshalFrom(Interop.DisplayPlaneProperties* value)
		{
            var result = new DisplayPlaneProperties();

			result.CurrentStackIndex = value->CurrentStackIndex;

			return result;
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DisplayPresentInfo
	{

		public Rect2D SourceRect
		{
			get;
			set;
		}

		public Rect2D DestinationRect
		{
			get;
			set;
		}

		public Bool32 Persistent
		{
			get;
			set;
		}

        internal unsafe Interop.DisplayPresentInfo Pack()
        {
            var result = new Interop.DisplayPresentInfo();
			result.SType = StructureType.DisplayPresentInfo;
			result.SourceRect = this.SourceRect;
			result.DestinationRect = this.DestinationRect;
			result.Persistent = this.Persistent;

            return result;
        }

		internal unsafe Interop.DisplayPresentInfo* MarshalTo()
        {
            return (Interop.DisplayPresentInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DisplayProperties
	{

		public Display Display
		{
			get;
			set;
		}

		public string DisplayName
		{
			get;
			set;
		}

		public Extent2D PhysicalDimensions
		{
			get;
			set;
		}

		public Extent2D PhysicalResolution
		{
			get;
			set;
		}

		public SurfaceTransformFlags SupportedTransforms
		{
			get;
			set;
		}

		public Bool32 PlaneReorderPossible
		{
			get;
			set;
		}

		public Bool32 PersistentContent
		{
			get;
			set;
		}

		internal unsafe DisplayProperties Unpack(Interop.DisplayProperties value)
		{
			return MarshalFrom(&value);
		}

		internal static unsafe DisplayProperties MarshalFrom(Interop.DisplayProperties* value)
		{
            var result = new DisplayProperties();

			result.DisplayName = Interop.HeapUtil.MarshalFrom(value->DisplayName);
			result.PhysicalDimensions = value->PhysicalDimensions;
			result.PhysicalResolution = value->PhysicalResolution;
			result.SupportedTransforms = value->SupportedTransforms;
			result.PlaneReorderPossible = value->PlaneReorderPossible;
			result.PersistentContent = value->PersistentContent;

			return result;
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct DisplaySurfaceCreateInfo
	{

		public DisplaySurfaceCreateFlags Flags
		{
			get;
			set;
		}

		public DisplayMode DisplayMode
		{
			get;
			set;
		}

		public uint PlaneIndex
		{
			get;
			set;
		}

		public uint PlaneStackIndex
		{
			get;
			set;
		}

		public SurfaceTransformFlags Transform
		{
			get;
			set;
		}

		public float GlobalAlpha
		{
			get;
			set;
		}

		public DisplayPlaneAlphaFlags AlphaMode
		{
			get;
			set;
		}

		public Extent2D ImageExtent
		{
			get;
			set;
		}

        internal unsafe Interop.DisplaySurfaceCreateInfo Pack()
        {
            var result = new Interop.DisplaySurfaceCreateInfo();
			result.SType = StructureType.DisplaySurfaceCreateInfo;
			result.DisplayMode = this.DisplayMode?.Pack() ?? Interop.DisplayMode.Null;
			result.Flags = this.Flags;
			result.PlaneIndex = this.PlaneIndex;
			result.PlaneStackIndex = this.PlaneStackIndex;
			result.Transform = this.Transform;
			result.GlobalAlpha = this.GlobalAlpha;
			result.AlphaMode = this.AlphaMode;
			result.ImageExtent = this.ImageExtent;

            return result;
        }

		internal unsafe Interop.DisplaySurfaceCreateInfo* MarshalTo()
        {
            return (Interop.DisplaySurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct EventCreateInfo
	{

		public EventCreateFlags Flags
		{
			get;
			set;
		}

        internal unsafe Interop.EventCreateInfo Pack()
        {
            var result = new Interop.EventCreateInfo();
			result.SType = StructureType.EventCreateInfo;
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.EventCreateInfo* MarshalTo()
        {
            return (Interop.EventCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct ExtensionProperties
	{

		public string ExtensionName
		{
			get;
			set;
		}

		public Version SpecVersion
		{
			get;
			set;
		}

		internal unsafe ExtensionProperties Unpack(Interop.ExtensionProperties value)
		{
			return MarshalFrom(&value);
		}

		internal static unsafe ExtensionProperties MarshalFrom(Interop.ExtensionProperties* value)
		{
            var result = new ExtensionProperties();

			result.ExtensionName = System.Text.Encoding.UTF8.GetString(Interop.HeapUtil.MarshalFrom(value->ExtensionName, (int)Constants.MaxExtensionNameSize, true));
			result.SpecVersion = value->SpecVersion;

			return result;
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct FenceCreateInfo
	{

		public FenceCreateFlags Flags
		{
			get;
			set;
		}

        internal unsafe Interop.FenceCreateInfo Pack()
        {
            var result = new Interop.FenceCreateInfo();
			result.SType = StructureType.FenceCreateInfo;
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.FenceCreateInfo* MarshalTo()
        {
            return (Interop.FenceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// Image subresources used as attachments mustnot: be used via any
    /// non-attachment usage for the duration of a render pass instance.
    /// [NOTE]
    /// .Note
    /// ====
    /// This restriction means that the render pass has full knowledge of all uses
    /// of all of the attachments, so that the implementation is able to make
    /// correct decisions about when and how to perform layout transitions, when to
    /// overlap execution of subpasses, etc.
    /// ====
    /// [[renderpass-noattachments]]
    /// It is legal for a subpass to use no color or depth/stencil attachments, and
    /// rather use shader side effects such as image stores and atomics to produce
    /// an output. In this case, the subpass continues to use the pname:width,
    /// pname:height, and pname:layers of the framebuffer to define the dimensions
    /// of the rendering area, and the pname:rasterizationSamples from each
    /// pipeline's slink:VkPipelineMultisampleStateCreateInfo to define the number
    /// of samples used in rasterization; however, if
    /// slink:VkPhysicalDeviceFeatures::pname:variableMultisampleRate is
    /// code:VK_FALSE, then all pipelines to be bound with a given zero-attachment
    /// subpass must: have the same value for
    /// slink:VkPipelineMultisampleStateCreateInfo::pname:rasterizationSamples.
    /// </summary>
	public struct FramebufferCreateInfo
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
			result.SType = StructureType.FramebufferCreateInfo;
			result.RenderPass = this.RenderPass?.Pack() ?? Interop.RenderPass.Null;
			
			//Attachments
			if (this.Attachments != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.ImageView>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.ImageView>(this.Attachments.Length);
			    for (int index = 0; index < this.Attachments.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.Attachments[index].Pack(), pointer + (size * index), false);
			    }
			    result.Attachments = (Interop.ImageView*)pointer.ToPointer();
			}
			else
			{
			    result.Attachments = null;
			}
			result.AttachmentCount = (uint)(this.Attachments?.Length ?? 0);
			result.Flags = this.Flags;
			result.Width = this.Width;
			result.Height = this.Height;
			result.Layers = this.Layers;

            return result;
        }

		internal unsafe Interop.FramebufferCreateInfo* MarshalTo()
        {
            return (Interop.FramebufferCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// The parameters pname:basePipelineHandle and pname:basePipelineIndex are
    /// described in more detail in
    /// <<pipelines-pipeline-derivatives,Pipeline Derivatives>>.
    /// pname:pStages points to an array of slink:VkPipelineShaderStageCreateInfo
    /// structures, which were previously described in
    /// <<pipelines-compute,Compute Pipelines>>.
    /// Bits which can: be set in pname:flags are:
    /// // refBegin VkPipelineCreateFlagBits - Bitmask controlling how a pipeline is generated
    /// include::../api/enums/VkPipelineCreateFlagBits.txt[]
    ///   * ename:VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT specifies that the
    ///     created pipeline will not be optimized. Using this flag may: reduce
    ///     the time taken to create the pipeline.
    ///   * ename:VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT specifies that the
    ///     pipeline to be created is allowed to be the parent of a pipeline that
    ///     will be created in a subsequent call to flink:vkCreateGraphicsPipelines.
    ///   * ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT specifies that the pipeline to
    ///     be created will be a child of a previously created parent pipeline.
    /// It is valid to set both ename:VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT and
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT. This allows a pipeline to be both a
    /// parent and possibly a child in a pipeline hierarchy. See
    /// <<pipelines-pipeline-derivatives,Pipeline Derivatives>> for more
    /// information.
    /// pname:pDynamicState points to a structure of type
    /// sname:VkPipelineDynamicStateCreateInfo.
    /// </summary>
	public struct GraphicsPipelineCreateInfo
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

		public PipelineVertexInputStateCreateInfo? VertexInputState
		{
			get;
			set;
		}

		public PipelineInputAssemblyStateCreateInfo? InputAssemblyState
		{
			get;
			set;
		}

		public PipelineTessellationStateCreateInfo? TessellationState
		{
			get;
			set;
		}

		public PipelineViewportStateCreateInfo? ViewportState
		{
			get;
			set;
		}

		public PipelineRasterizationStateCreateInfo? RasterizationState
		{
			get;
			set;
		}

		public PipelineMultisampleStateCreateInfo? MultisampleState
		{
			get;
			set;
		}

		public PipelineDepthStencilStateCreateInfo? DepthStencilState
		{
			get;
			set;
		}

		public PipelineColorBlendStateCreateInfo? ColorBlendState
		{
			get;
			set;
		}

		public PipelineDynamicStateCreateInfo? DynamicState
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
			result.SType = StructureType.GraphicsPipelineCreateInfo;
			
			//Stages
			if (this.Stages != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.PipelineShaderStageCreateInfo>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.PipelineShaderStageCreateInfo>(this.Stages.Length);
			    for (int index = 0; index < this.Stages.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.Stages[index].Pack(), pointer + (size * index), false);
			    }
			    result.Stages = (Interop.PipelineShaderStageCreateInfo*)pointer.ToPointer();
			}
			else
			{
			    result.Stages = null;
			}
			result.VertexInputState = this.VertexInputState == null ? null : this.VertexInputState.Value.MarshalTo();
			result.InputAssemblyState = this.InputAssemblyState == null ? null : this.InputAssemblyState.Value.MarshalTo();
			result.TessellationState = this.TessellationState == null ? null : this.TessellationState.Value.MarshalTo();
			result.ViewportState = this.ViewportState == null ? null : this.ViewportState.Value.MarshalTo();
			result.RasterizationState = this.RasterizationState == null ? null : this.RasterizationState.Value.MarshalTo();
			result.MultisampleState = this.MultisampleState == null ? null : this.MultisampleState.Value.MarshalTo();
			result.DepthStencilState = this.DepthStencilState == null ? null : this.DepthStencilState.Value.MarshalTo();
			result.ColorBlendState = this.ColorBlendState == null ? null : this.ColorBlendState.Value.MarshalTo();
			result.DynamicState = this.DynamicState == null ? null : this.DynamicState.Value.MarshalTo();
			result.Layout = this.Layout?.Pack() ?? Interop.PipelineLayout.Null;
			result.RenderPass = this.RenderPass?.Pack() ?? Interop.RenderPass.Null;
			result.BasePipelineHandle = this.BasePipelineHandle?.Pack() ?? Interop.Pipeline.Null;
			result.StageCount = (uint)(this.Stages?.Length ?? 0);
			result.Flags = this.Flags;
			result.Subpass = this.Subpass;
			result.BasePipelineIndex = this.BasePipelineIndex;

            return result;
        }

		internal unsafe Interop.GraphicsPipelineCreateInfo* MarshalTo()
        {
            return (Interop.GraphicsPipelineCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// For each element of the pname:pRegions array, a blit operation is performed
    /// the specified source and destination regions.
    /// </summary>
	public struct ImageBlit
	{

		public ImageSubresourceLayers SourceSubresource
		{
			get;
			set;
		}

		public Offset3D[] SourceOffsets
		{
			get;
			set;
		}

		public ImageSubresourceLayers DestinationSubresource
		{
			get;
			set;
		}

		public Offset3D[] DestinationOffsets
		{
			get;
			set;
		}

        internal unsafe Interop.ImageBlit Pack()
        {
            var result = new Interop.ImageBlit();
			result.SourceSubresource = this.SourceSubresource;
			result.DestinationSubresource = this.DestinationSubresource;

            return result;
        }

		internal unsafe Interop.ImageBlit* MarshalTo()
        {
            return (Interop.ImageBlit*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// Valid limits for the image pname:extent, pname:mipLevels, pname:arrayLayers
    /// and pname:samples members are queried with the
    /// flink:vkGetPhysicalDeviceImageFormatProperties command.
    /// Images created with pname:tiling equal to ename:VK_IMAGE_TILING_LINEAR have
    /// further restrictions on their limits and capabilities compared to images
    /// created with pname:tiling equal to ename:VK_IMAGE_TILING_OPTIMAL. Creation
    /// of images with tiling ename:VK_IMAGE_TILING_LINEAR may: not be supported
    /// unless other parameters meet all of the constraints:
    ///   * pname:imageType is ename:VK_IMAGE_TYPE_2D
    ///   * pname:format is not a depth/stencil format
    ///   * pname:mipLevels is 1
    ///   * pname:arrayLayers is 1
    ///   * pname:samples is ename:VK_SAMPLE_COUNT_1_BIT
    ///   * pname:usage only includes ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT
    ///     and/or ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT
    /// Implementations may: support additional limits and capabilities beyond those
    /// listed above. To determine the specific capabilities of an implementation,
    /// query the valid pname:usage bits by calling
    /// flink:vkGetPhysicalDeviceFormatProperties and the valid limits for
    /// pname:mipLevels and pname:arrayLayers by calling
    /// flink:vkGetPhysicalDeviceImageFormatProperties.
    /// </summary>
	public struct ImageCreateInfo
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
			result.SType = StructureType.ImageCreateInfo;
			result.QueueFamilyIndices = this.QueueFamilyIndices == null ? null : Interop.HeapUtil.MarshalTo(this.QueueFamilyIndices);
			result.QueueFamilyIndexCount = (uint)(this.QueueFamilyIndices?.Length ?? 0);
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
			result.InitialLayout = this.InitialLayout;

            return result;
        }

		internal unsafe Interop.ImageCreateInfo* MarshalTo()
        {
            return (Interop.ImageCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// If pname:oldLayout differs from pname:newLayout, a layout transition occurs
    /// as part of the image memory barrier, affecting the data contained in the
    /// region of the image defined by the pname:subresourceRange. If
    /// pname:oldLayout is ename:VK_IMAGE_LAYOUT_UNDEFINED, then the data is
    /// undefined after the layout transition. This may: allow a more efficient
    /// transition, since the data may: be discarded. The layout transition must:
    /// occur after all operations using the old layout are completed and before all
    /// operations using the new layout are started. This is achieved by ensuring
    /// that there is a memory dependency between previous accesses and the layout
    /// transition, as well as between the layout transition and subsequent
    /// accesses, where the layout transition occurs between the two halves of a
    /// memory dependency in an image memory barrier.
    /// Layout transitions that are performed via image memory barriers are
    /// automatically ordered against other layout transitions, including those that
    /// occur as part of a render pass instance.
    /// [NOTE]
    /// .Note
    /// ====
    /// See <<resources-image-layouts>> for details on available image layouts
    /// and their usages.
    /// ====
    /// </summary>
	public struct ImageMemoryBarrier
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
			result.SType = StructureType.ImageMemoryBarrier;
			result.Image = this.Image?.Pack() ?? Interop.Image.Null;
			result.SourceAccessMask = this.SourceAccessMask;
			result.DestinationAccessMask = this.DestinationAccessMask;
			result.OldLayout = this.OldLayout;
			result.NewLayout = this.NewLayout;
			result.SourceQueueFamilyIndex = this.SourceQueueFamilyIndex;
			result.DestinationQueueFamilyIndex = this.DestinationQueueFamilyIndex;
			result.SubresourceRange = this.SubresourceRange;

            return result;
        }

		internal unsafe Interop.ImageMemoryBarrier* MarshalTo()
        {
            return (Interop.ImageMemoryBarrier*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// If pname:image was created with the ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT
    /// flag, pname:format can: be different from the image's format, but if they
    /// are not equal they must: be _compatible_. Image format compatibility is
    /// defined in the <<features-formats-compatibility-classes,Format Compatibility
    /// Classes>> section.
    /// [[resources-image-views-compatibility]]
    /// .Image and image view parameter compatibility requirements
    /// [cols="20%h,35%,45%",options="header"]
    /// |========================================
    /// | Dim, Arrayed, MS | Image parameters | View parameters
    /// | 1D, 0, 0 |
    /// imageType = ename:VK_IMAGE_TYPE_1D +
    /// width >= 1 +
    /// height = 1 +
    /// depth = 1 +
    /// arrayLayers >= 1 +
    /// samples = 1 |
    /// viewType = ename:VK_VIEW_TYPE_1D +
    /// baseArrayLayer >= 0 +
    /// layerCount = 1
    /// | 1D, 1, 0 |
    /// imageType = ename:VK_IMAGE_TYPE_1D +
    /// width >= 1 +
    /// height = 1 +
    /// depth = 1 +
    /// arrayLayers >= 1 +
    /// samples = 1 |
    /// viewType = ename:VK_VIEW_TYPE_1D_ARRAY +
    /// baseArrayLayer >= 0 +
    /// layerCount >= 1
    /// | 2D, 0, 0 |
    /// imageType = ename:VK_IMAGE_TYPE_2D +
    /// width >= 1 +
    /// height >= 1 +
    /// depth = 1 +
    /// arrayLayers >= 1 +
    /// samples = 1 |
    /// viewType = ename:VK_VIEW_TYPE_2D +
    /// baseArrayLayer >= 0 +
    /// layerCount = 1
    /// | 2D, 1, 0 |
    /// imageType = ename:VK_IMAGE_TYPE_2D +
    /// width >= 1 +
    /// height >= 1 +
    /// depth = 1 +
    /// arrayLayers >= 1 +
    /// samples = 1 |
    /// viewType = ename:VK_VIEW_TYPE_2D_ARRAY +
    /// baseArrayLayer >= 0 +
    /// layerCount >= 1
    /// | 2D, 0, 1 |
    /// imageType = ename:VK_IMAGE_TYPE_2D +
    /// width >= 1 +
    /// height >= 1 +
    /// depth = 1 +
    /// arrayLayers >= 1 +
    /// samples > 1 |
    /// viewType = ename:VK_VIEW_TYPE_2D +
    /// baseArrayLayer >= 0 +
    /// layerCount = 1
    /// | 2D, 1, 1 |
    /// imageType = ename:VK_IMAGE_TYPE_2D +
    /// width >= 1 +
    /// height >= 1 +
    /// depth = 1 +
    /// arrayLayers >= 1 +
    /// samples > 1 |
    /// viewType = ename:VK_VIEW_TYPE_2D_ARRAY +
    /// baseArrayLayer >= 0 +
    /// layerCount >= 1
    /// | CUBE, 0, 0 |
    /// imageType = ename:VK_IMAGE_TYPE_2D +
    /// width >= 1 +
    /// height = width +
    /// depth = 1 +
    /// arrayLayers >= 6 +
    /// samples = 1 +
    /// flags include ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT |
    /// viewType = ename:VK_VIEW_TYPE_CUBE +
    /// baseArrayLayer >= 0 +
    /// layerCount = 6
    /// | CUBE, 1, 0 |
    /// imageType = ename:VK_IMAGE_TYPE_2D +
    /// width >= 1 +
    /// height = width +
    /// depth = 1 +
    /// N >= 1 +
    /// arrayLayers >= latexmath:[$6 \times N$] +
    /// samples = 1 +
    /// flags include ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT |
    /// viewType = ename:VK_VIEW_TYPE_CUBE_ARRAY +
    /// baseArrayLayer >= 0 +
    /// N >= 1 +
    /// layerCount = latexmath:[$6 \times N$]
    /// | 3D, 0, 0 |
    /// imageType = ename:VK_IMAGE_TYPE_3D +
    /// width >= 1 +
    /// height >= 1 +
    /// depth >= 1 +
    /// arrayLayers = 1 +
    /// samples = 1 |
    /// viewType = ename:VK_VIEW_TYPE_3D +
    /// baseArrayLayer = 0 +
    /// layerCount = 1
    /// |========================================
    /// </summary>
	public struct ImageViewCreateInfo
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
			result.SType = StructureType.ImageViewCreateInfo;
			result.Image = this.Image?.Pack() ?? Interop.Image.Null;
			result.Flags = this.Flags;
			result.ViewType = this.ViewType;
			result.Format = this.Format;
			result.Components = this.Components;
			result.SubresourceRange = this.SubresourceRange;

            return result;
        }

		internal unsafe Interop.ImageViewCreateInfo* MarshalTo()
        {
            return (Interop.ImageViewCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct InstanceCreateInfo
	{

		public InstanceCreateFlags Flags
		{
			get;
			set;
		}

		public ApplicationInfo? ApplicationInfo
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
			result.SType = StructureType.InstanceCreateInfo;
			result.ApplicationInfo = this.ApplicationInfo == null ? null : this.ApplicationInfo.Value.MarshalTo();
			result.EnabledLayerNames = this.EnabledLayerNames == null ? null : Interop.HeapUtil.MarshalTo(this.EnabledLayerNames);
			result.EnabledExtensionNames = this.EnabledExtensionNames == null ? null : Interop.HeapUtil.MarshalTo(this.EnabledExtensionNames);
			result.EnabledLayerCount = (uint)(this.EnabledLayerNames?.Length ?? 0);
			result.EnabledExtensionCount = (uint)(this.EnabledExtensionNames?.Length ?? 0);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.InstanceCreateInfo* MarshalTo()
        {
            return (Interop.InstanceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct LayerProperties
	{

		public string LayerName
		{
			get;
			set;
		}

		public Version SpecVersion
		{
			get;
			set;
		}

		public Version ImplementationVersion
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		internal unsafe LayerProperties Unpack(Interop.LayerProperties value)
		{
			return MarshalFrom(&value);
		}

		internal static unsafe LayerProperties MarshalFrom(Interop.LayerProperties* value)
		{
            var result = new LayerProperties();

			result.LayerName = System.Text.Encoding.UTF8.GetString(Interop.HeapUtil.MarshalFrom(value->LayerName, (int)Constants.MaxExtensionNameSize, true));
			result.Description = System.Text.Encoding.UTF8.GetString(Interop.HeapUtil.MarshalFrom(value->Description, (int)Constants.MaxDescriptionSize, true));
			result.SpecVersion = value->SpecVersion;
			result.ImplementationVersion = value->ImplementationVersion;

			return result;
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct MappedMemoryRange
	{

		public DeviceMemory Memory
		{
			get;
			set;
		}

		public ulong Offset
		{
			get;
			set;
		}

		public ulong Size
		{
			get;
			set;
		}

        internal unsafe Interop.MappedMemoryRange Pack()
        {
            var result = new Interop.MappedMemoryRange();
			result.SType = StructureType.MappedMemoryRange;
			result.Memory = this.Memory?.Pack() ?? Interop.DeviceMemory.Null;
			result.Offset = this.Offset;
			result.Size = this.Size;

            return result;
        }

		internal unsafe Interop.MappedMemoryRange* MarshalTo()
        {
            return (Interop.MappedMemoryRange*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct MemoryAllocateInfo
	{

		public ulong AllocationSize
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
			result.SType = StructureType.MemoryAllocateInfo;
			result.AllocationSize = this.AllocationSize;
			result.MemoryTypeIndex = this.MemoryTypeIndex;

            return result;
        }

		internal unsafe Interop.MemoryAllocateInfo* MarshalTo()
        {
            return (Interop.MemoryAllocateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// pname:srcAccessMask and pname:dstAccessMask, along with pname:srcStageMask
    /// and pname:dstStageMask from flink:vkCmdPipelineBarrier, define the two
    /// halves of a memory dependency and an execution dependency. Memory accesses
    /// using the set of access types in pname:srcAccessMask performed in pipeline
    /// stages in pname:srcStageMask by the first set of commands must: complete and
    /// be available to later commands. The side effects of the first set of
    /// commands will be visible to memory accesses using the set of access types in
    /// pname:dstAccessMask performed in pipeline stages in pname:dstStageMask by
    /// the second set of commands. If the barrier is by-region, these requirements
    /// only apply to invocations within the same framebuffer-space region, for
    /// pipeline stages that perform framebuffer-space work. The execution
    /// dependency guarantees that execution of work by the destination stages of
    /// the second set of commands will not begin until execution of work by the
    /// source stages of the first set of commands has completed.
    /// A common type of memory dependency is to avoid a read-after-write hazard. In
    /// this case, the source access mask and stages will include writes from a
    /// particular stage, and the destination access mask and stages will indicate
    /// how those writes will be read in subsequent commands. However, barriers can:
    /// also express write-after-read dependencies and write-after-write
    /// dependencies, and are even useful to express read-after-read dependencies
    /// across an image layout change.
    /// // refBegin VkAccessFlagBits - Bitmask specifying classes of memory access the will participate in a memory barrier dependency
    /// Bits which can: be set in slink:VkMemoryBarrier::pname:srcAccessMask and
    /// slink:VkMemoryBarrier::pname:dstAccessMask include:
    /// [[synchronization-access-flags]]
    /// include::../api/enums/VkAccessFlagBits.txt[]
    ///   * ename:VK_ACCESS_INDIRECT_COMMAND_READ_BIT indicates that the access is
    ///     an indirect command structure read as part of an indirect drawing
    ///     command.
    ///   * ename:VK_ACCESS_INDEX_READ_BIT indicates that the access is an index
    ///     buffer read.
    ///   * ename:VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT indicates that the access is a
    ///     read via the vertex input bindings.
    ///   * ename:VK_ACCESS_UNIFORM_READ_BIT indicates that the access is a read via
    ///     a uniform buffer or dynamic uniform buffer descriptor.
    ///   * ename:VK_ACCESS_INPUT_ATTACHMENT_READ_BIT indicates that the access is a
    ///     read via an input attachment descriptor.
    ///   * ename:VK_ACCESS_SHADER_READ_BIT indicates that the access is a read from
    ///     a shader via any other descriptor type.
    ///   * ename:VK_ACCESS_SHADER_WRITE_BIT indicates that the access is a write
    ///     or atomic from a shader via the same descriptor types as in
    ///     ename:VK_ACCESS_SHADER_READ_BIT.
    ///   * ename:VK_ACCESS_COLOR_ATTACHMENT_READ_BIT indicates that the access is a
    ///     read via a color attachment.
    ///   * ename:VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT indicates that the access is
    ///     a write via a color or resolve attachment.
    ///   * ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT indicates that the
    ///     access is a read via a depth/stencil attachment.
    ///   * ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT indicates that the
    ///     access is a write via a depth/stencil attachment.
    ///   * ename:VK_ACCESS_TRANSFER_READ_BIT indicates that the access is a read
    ///     from a transfer (copy, blit, resolve, etc.) operation. For the complete
    ///     set of transfer operations, see
    ///     <<synchronization-transfer,ename:VK_PIPELINE_STAGE_TRANSFER_BIT>>.
    ///   * ename:VK_ACCESS_TRANSFER_WRITE_BIT indicates that the access is a write
    ///     from a transfer (copy, blit, resolve, etc.) operation. For the complete
    ///     set of transfer operations, see
    ///     <<synchronization-transfer,ename:VK_PIPELINE_STAGE_TRANSFER_BIT>>.
    ///   * ename:VK_ACCESS_HOST_READ_BIT indicates that the access is a read via
    ///     the host.
    ///   * ename:VK_ACCESS_HOST_WRITE_BIT indicates that the access is a write via
    ///     the host.
    ///   * ename:VK_ACCESS_MEMORY_READ_BIT indicates that the access is a read via
    ///     a non-specific unit attached to the memory. This unit may: be external
    ///     to the Vulkan device or otherwise not part of the core Vulkan pipeline.
    ///     When included in pname:dstAccessMask, all writes using access types in
    ///     pname:srcAccessMask performed by pipeline stages in pname:srcStageMask
    ///     must: be visible in memory.
    ///   * ename:VK_ACCESS_MEMORY_WRITE_BIT indicates that the access is a write
    ///     via a non-specific unit attached to the memory. This unit may: be
    ///     external to the Vulkan device or otherwise not part of the core Vulkan
    ///     pipeline. When included in pname:srcAccessMask, all access types in
    ///     pname:dstAccessMask from pipeline stages in pname:dstStageMask will
    ///     observe the side effects of commands that executed before the barrier.
    ///     When included in pname:dstAccessMask all writes using access types in
    ///     pname:srcAccessMask performed by pipeline stages in pname:srcStageMask
    ///     must: be visible in memory.
    /// Color attachment reads and writes are automatically (without memory or
    /// execution dependencies) coherent and ordered against themselves and each
    /// other for a given sample within a subpass of a render pass instance,
    /// executing in <<fundamentals-queueoperation-apiorder,API order>>. Similarly,
    /// depth/stencil attachment reads and writes are automatically coherent and
    /// ordered against themselves and each other in the same circumstances.
    /// Shader reads and/or writes through two variables (in the same or different
    /// shader invocations) decorated with code:Coherent and which use the same
    /// image view or buffer view are automatically coherent with each other, but
    /// require execution dependencies if a specific order is desired. Similarly,
    /// shader atomic operations are coherent with each other and with code:Coherent
    /// variables. Non-code:Coherent shader memory accesses require memory
    /// dependencies for writes to be available and reads to be visible.
    /// Certain memory access types are only supported on queues that support a
    /// particular set of operations. The following table lists, for each access
    /// flag, which queue capability flag must: be supported by the queue. When
    /// multiple flags are enumerated in the second column of the table it means
    /// that the access type is supported on the queue if it supports any of the
    /// listed capability flags. For further details on queue capabilities see
    /// <<devsandqueues-physical-device-enumeration,Physical Device Enumeration>>
    /// and <<devsandqueues-queues,Queues>>.
    /// .Supported access flags
    /// [width="100%",cols="67%,33%",options="header",align="center"]
    /// |========================================
    /// |Access flag                                                  | Required queue capability flag
    /// |ename:VK_ACCESS_INDIRECT_COMMAND_READ_BIT                    | ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT
    /// |ename:VK_ACCESS_INDEX_READ_BIT                               | ename:VK_QUEUE_GRAPHICS_BIT
    /// |ename:VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT                    | ename:VK_QUEUE_GRAPHICS_BIT
    /// |ename:VK_ACCESS_UNIFORM_READ_BIT                             | ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT
    /// |ename:VK_ACCESS_INPUT_ATTACHMENT_READ_BIT                    | ename:VK_QUEUE_GRAPHICS_BIT
    /// |ename:VK_ACCESS_SHADER_READ_BIT                              | ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT
    /// |ename:VK_ACCESS_SHADER_WRITE_BIT                             | ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT
    /// |ename:VK_ACCESS_COLOR_ATTACHMENT_READ_BIT                    | ename:VK_QUEUE_GRAPHICS_BIT
    /// |ename:VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT                   | ename:VK_QUEUE_GRAPHICS_BIT
    /// |ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT            | ename:VK_QUEUE_GRAPHICS_BIT
    /// |ename:VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT           | ename:VK_QUEUE_GRAPHICS_BIT
    /// |ename:VK_ACCESS_TRANSFER_READ_BIT                            | ename:VK_QUEUE_GRAPHICS_BIT, ename:VK_QUEUE_COMPUTE_BIT or ename:VK_QUEUE_TRANSFER_BIT
    /// |ename:VK_ACCESS_TRANSFER_WRITE_BIT                           | ename:VK_QUEUE_GRAPHICS_BIT, ename:VK_QUEUE_COMPUTE_BIT or ename:VK_QUEUE_TRANSFER_BIT
    /// |ename:VK_ACCESS_HOST_READ_BIT                                | None
    /// |ename:VK_ACCESS_HOST_WRITE_BIT                               | None
    /// |ename:VK_ACCESS_MEMORY_READ_BIT                              | None
    /// |ename:VK_ACCESS_MEMORY_WRITE_BIT                             | None
    /// |========================================
    /// </summary>
	public struct MemoryBarrier
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
			result.SType = StructureType.MemoryBarrier;
			result.SourceAccessMask = this.SourceAccessMask;
			result.DestinationAccessMask = this.DestinationAccessMask;

            return result;
        }

		internal unsafe Interop.MemoryBarrier* MarshalTo()
        {
            return (Interop.MemoryBarrier*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct MirSurfaceCreateInfo
	{

		public MirSurfaceCreateFlags Flags
		{
			get;
			set;
		}

		public IntPtr Connection
		{
			get;
			set;
		}

		public IntPtr MirSurface
		{
			get;
			set;
		}

        internal unsafe Interop.MirSurfaceCreateInfo Pack()
        {
            var result = new Interop.MirSurfaceCreateInfo();
			result.SType = StructureType.MirSurfaceCreateInfo;
			result.Connection = (IntPtr*)Interop.HeapUtil.AllocateAndMarshal(this.Connection);
			result.MirSurface = (IntPtr*)Interop.HeapUtil.AllocateAndMarshal(this.MirSurface);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.MirSurfaceCreateInfo* MarshalTo()
        {
            return (Interop.MirSurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// // End of list
    /// 1::
    ///     For all bitmasks of type elink:VkSampleCountFlags above, possible
    ///     values include:
    /// +
    /// --
    /// // refBegin VkSampleCountFlagBits - Bitmask specifying sample counts supported for an image used for storage operations
    /// include::../api/enums/VkSampleCountFlagBits.txt[]
    /// --
    /// +
    /// The sample count limits defined above represent the minimum
    /// supported sample counts for each image type. Individual images may: support
    /// additional sample counts, which are queried using
    /// flink:vkGetPhysicalDeviceImageFormatProperties as described
    /// in <<features-supported-sample-counts, Supported Sample Counts>>.
    /// </summary>
	public struct PhysicalDeviceLimits
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

		public ulong BufferImageGranularity
		{
			get;
			set;
		}

		public ulong SparseAddressSpaceSize
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

		public uint[] MaxComputeWorkGroupCount
		{
			get;
			set;
		}

		public uint MaxComputeWorkGroupInvocations
		{
			get;
			set;
		}

		public uint[] MaxComputeWorkGroupSize
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

		public uint[] MaxViewportDimensions
		{
			get;
			set;
		}

		public float[] ViewportBoundsRange
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

		public ulong MinTexelBufferOffsetAlignment
		{
			get;
			set;
		}

		public ulong MinUniformBufferOffsetAlignment
		{
			get;
			set;
		}

		public ulong MinStorageBufferOffsetAlignment
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

		public float[] PointSizeRange
		{
			get;
			set;
		}

		public float[] LineWidthRange
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

		public ulong OptimalBufferCopyOffsetAlignment
		{
			get;
			set;
		}

		public ulong OptimalBufferCopyRowPitchAlignment
		{
			get;
			set;
		}

		public ulong NonCoherentAtomSize
		{
			get;
			set;
		}

		internal unsafe PhysicalDeviceLimits Unpack(Interop.PhysicalDeviceLimits value)
		{
			return MarshalFrom(&value);
		}

		internal static unsafe PhysicalDeviceLimits MarshalFrom(Interop.PhysicalDeviceLimits* value)
		{
            var result = new PhysicalDeviceLimits();

			result.MaxComputeWorkGroupCount = Interop.HeapUtil.MarshalFrom(value->MaxComputeWorkGroupCount, 3);
			result.MaxComputeWorkGroupSize = Interop.HeapUtil.MarshalFrom(value->MaxComputeWorkGroupSize, 3);
			result.MaxViewportDimensions = Interop.HeapUtil.MarshalFrom(value->MaxViewportDimensions, 2);
			result.ViewportBoundsRange = Interop.HeapUtil.MarshalFrom(value->ViewportBoundsRange, 2);
			result.PointSizeRange = Interop.HeapUtil.MarshalFrom(value->PointSizeRange, 2);
			result.LineWidthRange = Interop.HeapUtil.MarshalFrom(value->LineWidthRange, 2);
			result.MaxImageDimension1D = value->MaxImageDimension1D;
			result.MaxImageDimension2D = value->MaxImageDimension2D;
			result.MaxImageDimension3D = value->MaxImageDimension3D;
			result.MaxImageDimensionCube = value->MaxImageDimensionCube;
			result.MaxImageArrayLayers = value->MaxImageArrayLayers;
			result.MaxTexelBufferElements = value->MaxTexelBufferElements;
			result.MaxUniformBufferRange = value->MaxUniformBufferRange;
			result.MaxStorageBufferRange = value->MaxStorageBufferRange;
			result.MaxPushConstantsSize = value->MaxPushConstantsSize;
			result.MaxMemoryAllocationCount = value->MaxMemoryAllocationCount;
			result.MaxSamplerAllocationCount = value->MaxSamplerAllocationCount;
			result.BufferImageGranularity = value->BufferImageGranularity;
			result.SparseAddressSpaceSize = value->SparseAddressSpaceSize;
			result.MaxBoundDescriptorSets = value->MaxBoundDescriptorSets;
			result.MaxPerStageDescriptorSamplers = value->MaxPerStageDescriptorSamplers;
			result.MaxPerStageDescriptorUniformBuffers = value->MaxPerStageDescriptorUniformBuffers;
			result.MaxPerStageDescriptorStorageBuffers = value->MaxPerStageDescriptorStorageBuffers;
			result.MaxPerStageDescriptorSampledImages = value->MaxPerStageDescriptorSampledImages;
			result.MaxPerStageDescriptorStorageImages = value->MaxPerStageDescriptorStorageImages;
			result.MaxPerStageDescriptorInputAttachments = value->MaxPerStageDescriptorInputAttachments;
			result.MaxPerStageResources = value->MaxPerStageResources;
			result.MaxDescriptorSetSamplers = value->MaxDescriptorSetSamplers;
			result.MaxDescriptorSetUniformBuffers = value->MaxDescriptorSetUniformBuffers;
			result.MaxDescriptorSetUniformBuffersDynamic = value->MaxDescriptorSetUniformBuffersDynamic;
			result.MaxDescriptorSetStorageBuffers = value->MaxDescriptorSetStorageBuffers;
			result.MaxDescriptorSetStorageBuffersDynamic = value->MaxDescriptorSetStorageBuffersDynamic;
			result.MaxDescriptorSetSampledImages = value->MaxDescriptorSetSampledImages;
			result.MaxDescriptorSetStorageImages = value->MaxDescriptorSetStorageImages;
			result.MaxDescriptorSetInputAttachments = value->MaxDescriptorSetInputAttachments;
			result.MaxVertexInputAttributes = value->MaxVertexInputAttributes;
			result.MaxVertexInputBindings = value->MaxVertexInputBindings;
			result.MaxVertexInputAttributeOffset = value->MaxVertexInputAttributeOffset;
			result.MaxVertexInputBindingStride = value->MaxVertexInputBindingStride;
			result.MaxVertexOutputComponents = value->MaxVertexOutputComponents;
			result.MaxTessellationGenerationLevel = value->MaxTessellationGenerationLevel;
			result.MaxTessellationPatchSize = value->MaxTessellationPatchSize;
			result.MaxTessellationControlPerVertexInputComponents = value->MaxTessellationControlPerVertexInputComponents;
			result.MaxTessellationControlPerVertexOutputComponents = value->MaxTessellationControlPerVertexOutputComponents;
			result.MaxTessellationControlPerPatchOutputComponents = value->MaxTessellationControlPerPatchOutputComponents;
			result.MaxTessellationControlTotalOutputComponents = value->MaxTessellationControlTotalOutputComponents;
			result.MaxTessellationEvaluationInputComponents = value->MaxTessellationEvaluationInputComponents;
			result.MaxTessellationEvaluationOutputComponents = value->MaxTessellationEvaluationOutputComponents;
			result.MaxGeometryShaderInvocations = value->MaxGeometryShaderInvocations;
			result.MaxGeometryInputComponents = value->MaxGeometryInputComponents;
			result.MaxGeometryOutputComponents = value->MaxGeometryOutputComponents;
			result.MaxGeometryOutputVertices = value->MaxGeometryOutputVertices;
			result.MaxGeometryTotalOutputComponents = value->MaxGeometryTotalOutputComponents;
			result.MaxFragmentInputComponents = value->MaxFragmentInputComponents;
			result.MaxFragmentOutputAttachments = value->MaxFragmentOutputAttachments;
			result.MaxFragmentDualSourceAttachments = value->MaxFragmentDualSourceAttachments;
			result.MaxFragmentCombinedOutputResources = value->MaxFragmentCombinedOutputResources;
			result.MaxComputeSharedMemorySize = value->MaxComputeSharedMemorySize;
			result.MaxComputeWorkGroupInvocations = value->MaxComputeWorkGroupInvocations;
			result.SubPixelPrecisionBits = value->SubPixelPrecisionBits;
			result.SubTexelPrecisionBits = value->SubTexelPrecisionBits;
			result.MipmapPrecisionBits = value->MipmapPrecisionBits;
			result.MaxDrawIndexedIndexValue = value->MaxDrawIndexedIndexValue;
			result.MaxDrawIndirectCount = value->MaxDrawIndirectCount;
			result.MaxSamplerLodBias = value->MaxSamplerLodBias;
			result.MaxSamplerAnisotropy = value->MaxSamplerAnisotropy;
			result.MaxViewports = value->MaxViewports;
			result.ViewportSubPixelBits = value->ViewportSubPixelBits;
			result.MinMemoryMapAlignment = value->MinMemoryMapAlignment;
			result.MinTexelBufferOffsetAlignment = value->MinTexelBufferOffsetAlignment;
			result.MinUniformBufferOffsetAlignment = value->MinUniformBufferOffsetAlignment;
			result.MinStorageBufferOffsetAlignment = value->MinStorageBufferOffsetAlignment;
			result.MinTexelOffset = value->MinTexelOffset;
			result.MaxTexelOffset = value->MaxTexelOffset;
			result.MinTexelGatherOffset = value->MinTexelGatherOffset;
			result.MaxTexelGatherOffset = value->MaxTexelGatherOffset;
			result.MinInterpolationOffset = value->MinInterpolationOffset;
			result.MaxInterpolationOffset = value->MaxInterpolationOffset;
			result.SubPixelInterpolationOffsetBits = value->SubPixelInterpolationOffsetBits;
			result.MaxFramebufferWidth = value->MaxFramebufferWidth;
			result.MaxFramebufferHeight = value->MaxFramebufferHeight;
			result.MaxFramebufferLayers = value->MaxFramebufferLayers;
			result.FramebufferColorSampleCounts = value->FramebufferColorSampleCounts;
			result.FramebufferDepthSampleCounts = value->FramebufferDepthSampleCounts;
			result.FramebufferStencilSampleCounts = value->FramebufferStencilSampleCounts;
			result.FramebufferNoAttachmentsSampleCounts = value->FramebufferNoAttachmentsSampleCounts;
			result.MaxColorAttachments = value->MaxColorAttachments;
			result.SampledImageColorSampleCounts = value->SampledImageColorSampleCounts;
			result.SampledImageIntegerSampleCounts = value->SampledImageIntegerSampleCounts;
			result.SampledImageDepthSampleCounts = value->SampledImageDepthSampleCounts;
			result.SampledImageStencilSampleCounts = value->SampledImageStencilSampleCounts;
			result.StorageImageSampleCounts = value->StorageImageSampleCounts;
			result.MaxSampleMaskWords = value->MaxSampleMaskWords;
			result.TimestampComputeAndGraphics = value->TimestampComputeAndGraphics;
			result.TimestampPeriod = value->TimestampPeriod;
			result.MaxClipDistances = value->MaxClipDistances;
			result.MaxCullDistances = value->MaxCullDistances;
			result.MaxCombinedClipAndCullDistances = value->MaxCombinedClipAndCullDistances;
			result.DiscreteQueuePriorities = value->DiscreteQueuePriorities;
			result.PointSizeGranularity = value->PointSizeGranularity;
			result.LineWidthGranularity = value->LineWidthGranularity;
			result.StrictLines = value->StrictLines;
			result.StandardSampleLocations = value->StandardSampleLocations;
			result.OptimalBufferCopyOffsetAlignment = value->OptimalBufferCopyOffsetAlignment;
			result.OptimalBufferCopyRowPitchAlignment = value->OptimalBufferCopyRowPitchAlignment;
			result.NonCoherentAtomSize = value->NonCoherentAtomSize;

			return result;
		}
	}

    /// <summary>
    /// The sname:VkPhysicalDeviceMemoryProperties structure describes a number of
    /// _memory heaps_ as well as a number of _memory types_ that can: be used to
    /// access memory allocated in those heaps. Each heap describes a memory
    /// resource of a particular size, and each memory type describes a set of
    /// memory properties (e.g. host cached vs uncached) that can: be used with a
    /// given memory heap. Allocations using a particular memory type will consume
    /// resources from the heap indicated by that memory type's heap index. More
    /// than one memory type may: share each heap, and the heaps and memory types
    /// provide a mechanism to advertise an accurate size of the physical memory
    /// resources while allowing the memory to be used with a variety of different
    /// properties.
    /// The number of memory heaps is given by pname:memoryHeapCount and is less
    /// than or equal to ename:VK_MAX_MEMORY_HEAPS. Each heap is described by an
    /// element of the pname:memoryHeaps array, as a sname:VkMemoryHeap structure.
    /// The number of memory types available across all memory heaps is given by
    /// pname:memoryTypeCount and is less than or equal to
    /// ename:VK_MAX_MEMORY_TYPES. Each memory type is described by an element of
    /// the pname:memoryTypes array, as a sname:VkMemoryType structure.
    /// At least one heap must: include ename:VK_MEMORY_HEAP_DEVICE_LOCAL_BIT in
    /// slink:VkMemoryHeap::pname:flags. If there are multiple heaps that all have similar performance
    /// characteristics, they may: all include ename:VK_MEMORY_HEAP_DEVICE_LOCAL_BIT.
    /// In a unified memory architecture (UMA) system, there is often only a single
    /// memory heap which is considered to be equally ``local'' to the host and to the
    /// device, and such an implementation must: advertise the heap as device-local.
    /// Each memory type returned by flink:vkGetPhysicalDeviceMemoryProperties must:
    /// have its pname:propertyFlags set to one of the following values:
    ///   * 0
    ///   * ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT
    ///   * ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT
    ///   * ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT | ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT
    ///   * ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT
    ///   * ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT | ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT
    ///   * ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT | ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT
    ///   * ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT | ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT | ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT
    ///   * ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT | ename:VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT
    /// There must: be at least one memory type with both the
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT and
    /// ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT bits set in its pname:propertyFlags.
    /// There must: be at least one memory type with the
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT bit set in its pname:propertyFlags.
    /// The memory types are sorted according to a preorder which serves to aid
    /// in easily selecting an appropriate memory type. Given two memory types X and
    /// Y, the preorder defines latexmath:[$X \leq Y$] if:
    ///   * the memory property bits set for X are a strict subset of the memory
    ///     property bits set for Y. Or,
    ///   * the memory property bits set for X are the same as the memory property
    ///     bits set for Y, and X uses a memory heap with greater or equal
    ///     performance (as determined in an implementation-specific manner).
    /// Memory types are ordered in the list such that X is assigned a lesser
    /// pname:memoryTypeIndex than Y if latexmath:[$X \leq Y \land \neg(Y \leq X)$] according to the
    /// preorder. Note that the list of all allowed memory property flag
    /// combinations above satisfies this preorder, but other orders would as
    /// well. The goal of this ordering is to enable applications to use a simple
    /// search loop in selecting the proper memory type, along the lines of:
    /// [source,{basebackend@docbook:c++:cpp}]
    /// ---------------------------------------------------
    /// // Find a memory type in "memoryTypeBits" that includes all of "properties"
    /// int32_t FindProperties(uint32_t memoryTypeBits, VkMemoryPropertyFlags properties)
    /// {
    ///     for (int32_t i = 0; i < memoryTypeCount; ++i)
    ///     {
    ///         if ((memoryTypeBits & (1 << i)) &&
    ///             ((memoryTypes[i].propertyFlags & properties) == properties))
    ///             return i;
    ///     }
    ///     return -1;
    /// }
    /// // Try to find an optimal memory type, or if it does not exist
    /// // find any compatible memory type
    /// VkMemoryRequirements memoryRequirements;
    /// vkGetImageMemoryRequirements(device, image, &memoryRequirements);
    /// int32_t memoryType = FindProperties(memoryRequirements.memoryTypeBits, optimalProperties);
    /// if (memoryType == -1)
    ///     memoryType = FindProperties(memoryRequirements.memoryTypeBits, requiredProperties);
    /// ---------------------------------------------------
    /// The loop will find the first supported memory type that has all bits requested in
    /// code:properties set. If there is no exact match, it will find a closest
    /// match (i.e. a memory type with the fewest additional bits set), which has
    /// some additional bits set but which are not detrimental to the behaviors
    /// requested by code:properties. The application can: first search for the optimal
    /// properties, e.g. a memory type that is device-local or supports coherent cached
    /// accesses, as appropriate for the intended usage, and if such a memory type is
    /// not present can: fallback to searching for a less optimal but guaranteed set of
    /// properties such as "0" or "host-visible and coherent".
    /// </summary>
	public struct PhysicalDeviceMemoryProperties
	{

		public MemoryType[] MemoryTypes
		{
			get;
			set;
		}

		public MemoryHeap[] MemoryHeaps
		{
			get;
			set;
		}

		internal unsafe PhysicalDeviceMemoryProperties Unpack(Interop.PhysicalDeviceMemoryProperties value)
		{
			return MarshalFrom(&value);
		}

		internal static unsafe PhysicalDeviceMemoryProperties MarshalFrom(Interop.PhysicalDeviceMemoryProperties* value)
		{
            var result = new PhysicalDeviceMemoryProperties();

			result.MemoryTypes = new MemoryType[value->MemoryTypeCount];
			MemoryType* MemoryTypesPointer = &value->MemoryTypes;
			for (int index = 0; index < value->MemoryTypeCount; index++)
			{
			    result.MemoryTypes[index] = *MemoryTypesPointer;
			    MemoryTypesPointer++;
			}
			result.MemoryHeaps = new MemoryHeap[value->MemoryHeapCount];
			MemoryHeap* MemoryHeapsPointer = &value->MemoryHeaps;
			for (int index = 0; index < value->MemoryHeapCount; index++)
			{
			    result.MemoryHeaps[index] = *MemoryHeapsPointer;
			    MemoryHeapsPointer++;
			}

			return result;
		}
	}

    /// <summary>
    /// The pname:vendorID and pname:deviceID fields are provided to allow
    /// applications to adapt to device characteristics that are not
    /// adequately exposed by other Vulkan queries. These may: include
    /// performance profiles, hardware errata, or other characteristics.
    /// In PCI-based implementations, the low sixteen bits of pname:vendorID
    /// and pname:deviceID must: contain (respectively) the PCI vendor and
    /// device IDs associated with the hardware device, and the remaining bits
    /// must: be set to zero. In non-PCI implementations, the choice of what values
    /// to return may: be dictated by operating system or platform policies. It is
    /// otherwise at the discretion of the implementer, subject to the following
    /// constraints and guidelines:
    ///   * For purposes of physical device identification, the _vendor_ of a
    ///     physical device is the entity responsible for the most salient
    ///     characteristics of the hardware represented by the physical device
    ///     handle. In the case of a discrete GPU, this should: be the GPU
    ///     chipset vendor. In the case of a GPU or other accelerator integrated
    ///     into a system-on-chip (SoC), this should: be the supplier of the
    ///     silicon IP used to create the GPU or other accelerator.
    ///   * If the vendor of the physical device has a valid PCI vendor ID issued by
    ///     https://pcisig.com/[PCI-SIG], that ID should: be used to construct
    ///     pname:vendorID as described above for PCI-based
    ///     implementations. Implementations that do not return a PCI vendor ID in
    ///     pname:vendorID must: return a valid Khronos vendor ID, obtained as
    ///     described in the <<vulkan-styleguide,Vulkan Documentation and Extensions>>
    ///     document in the section ``Registering a Vendor ID
    ///     with Khronos''. Khronos vendor IDs are allocated starting at 0x10000,
    ///     to distinguish them from the PCI vendor ID namespace.
    ///   * The vendor of the physical device is responsible for selecting
    ///     pname:deviceID. The value selected should: uniquely
    ///     identify both the device version and any major configuration options
    ///     (for example, core count in the case of multicore devices). The same
    ///     device ID should: be used for all physical implementations of that
    ///     device version and configuration. For example, all uses of a
    ///     specific silicon IP GPU version and configuration should use the
    ///     same device ID, even if those uses occur in different SoCs.
    /// </summary>
	public struct PhysicalDeviceProperties
	{

		public Version ApiVersion
		{
			get;
			set;
		}

		public Version DriverVersion
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

		public string DeviceName
		{
			get;
			set;
		}

		public Guid PipelineCacheUUID
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

		internal unsafe PhysicalDeviceProperties Unpack(Interop.PhysicalDeviceProperties value)
		{
			return MarshalFrom(&value);
		}

		internal static unsafe PhysicalDeviceProperties MarshalFrom(Interop.PhysicalDeviceProperties* value)
		{
            var result = new PhysicalDeviceProperties();

			result.DeviceName = System.Text.Encoding.UTF8.GetString(Interop.HeapUtil.MarshalFrom(value->DeviceName, (int)Constants.MaxPhysicalDeviceNameSize, true));
			result.PipelineCacheUUID = new Guid(Interop.HeapUtil.MarshalFrom(value->PipelineCacheUUID, (int)Constants.UuidSize));
			result.Limits = PhysicalDeviceLimits.MarshalFrom(&value->Limits);
			result.ApiVersion = value->ApiVersion;
			result.DriverVersion = value->DriverVersion;
			result.VendorID = value->VendorID;
			result.DeviceID = value->DeviceID;
			result.DeviceType = value->DeviceType;
			result.SparseProperties = value->SparseProperties;

			return result;
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct PipelineCacheCreateInfo
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
			result.SType = StructureType.PipelineCacheCreateInfo;
			result.InitialData = this.InitialData == null ? null : Interop.HeapUtil.MarshalTo(this.InitialData);
			result.InitialDataSize = (UIntPtr)(this.InitialData?.Length ?? 0);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.PipelineCacheCreateInfo* MarshalTo()
        {
            return (Interop.PipelineCacheCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// Each element of the pname:pAttachments array is a
    /// slink:VkPipelineColorBlendAttachmentState structure specifying per-target
    /// blending state for each individual color attachment. If the
    /// <<features-features-independentBlend,independent blending>> feature is not
    /// enabled on the device, all slink:VkPipelineColorBlendAttachmentState
    /// elements in the pname:pAttachments array must: be identical.
    /// </summary>
	public struct PipelineColorBlendStateCreateInfo
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

		public float[] BlendConstants
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineColorBlendStateCreateInfo Pack()
        {
            var result = new Interop.PipelineColorBlendStateCreateInfo();
			result.SType = StructureType.PipelineColorBlendStateCreateInfo;
			
			//Attachments
			if (this.Attachments != null)
			{
			    result.Attachments = (PipelineColorBlendAttachmentState*)Interop.HeapUtil.Allocate<PipelineColorBlendAttachmentState>(this.Attachments.Length).ToPointer();
			    for (int index = 0; index < this.Attachments.Length; index++)
			    {
			        result.Attachments[index] = this.Attachments[index];
			    }
			}
			else
			{
			    result.Attachments = null;
			}
			result.AttachmentCount = (uint)(this.Attachments?.Length ?? 0);
			result.Flags = this.Flags;
			result.LogicOpEnable = this.LogicOpEnable;
			result.LogicOp = this.LogicOp;

            return result;
        }

		internal unsafe Interop.PipelineColorBlendStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineColorBlendStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct PipelineDepthStencilStateCreateInfo
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
			result.SType = StructureType.PipelineDepthStencilStateCreateInfo;
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
            return (Interop.PipelineDepthStencilStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct PipelineDynamicStateCreateInfo
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
			result.SType = StructureType.PipelineDynamicStateCreateInfo;
			
			//DynamicStates
			if (this.DynamicStates != null)
			{
			    result.DynamicStates = (DynamicState*)Interop.HeapUtil.Allocate<int>(this.DynamicStates.Length).ToPointer();
			    for (int index = 0; index < this.DynamicStates.Length; index++)
			    {
			        result.DynamicStates[index] = this.DynamicStates[index];
			    }
			}
			else
			{
			    result.DynamicStates = null;
			}
			result.DynamicStateCount = (uint)(this.DynamicStates?.Length ?? 0);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.PipelineDynamicStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineDynamicStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// Restarting the assembly of primitives discards the most recent index values
    /// if those elements formed an incomplete primitive, and restarts the primitive
    /// assembly using the subsequent indices, but only assembling the immediately
    /// following element through the end of the originally specified elements. The
    /// primitive restart index value comparison is performed before adding the
    /// pname:vertexOffset value to the index value.
    /// </summary>
	public struct PipelineInputAssemblyStateCreateInfo
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
			result.SType = StructureType.PipelineInputAssemblyStateCreateInfo;
			result.Flags = this.Flags;
			result.Topology = this.Topology;
			result.PrimitiveRestartEnable = this.PrimitiveRestartEnable;

            return result;
        }

		internal unsafe Interop.PipelineInputAssemblyStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineInputAssemblyStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct PipelineLayoutCreateInfo
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
			result.SType = StructureType.PipelineLayoutCreateInfo;
			
			//SetLayouts
			if (this.SetLayouts != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DescriptorSetLayout>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DescriptorSetLayout>(this.SetLayouts.Length);
			    for (int index = 0; index < this.SetLayouts.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.SetLayouts[index].Pack(), pointer + (size * index), false);
			    }
			    result.SetLayouts = (Interop.DescriptorSetLayout*)pointer.ToPointer();
			}
			else
			{
			    result.SetLayouts = null;
			}
			
			//PushConstantRanges
			if (this.PushConstantRanges != null)
			{
			    result.PushConstantRanges = (PushConstantRange*)Interop.HeapUtil.Allocate<PushConstantRange>(this.PushConstantRanges.Length).ToPointer();
			    for (int index = 0; index < this.PushConstantRanges.Length; index++)
			    {
			        result.PushConstantRanges[index] = this.PushConstantRanges[index];
			    }
			}
			else
			{
			    result.PushConstantRanges = null;
			}
			result.SetLayoutCount = (uint)(this.SetLayouts?.Length ?? 0);
			result.PushConstantRangeCount = (uint)(this.PushConstantRanges?.Length ?? 0);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.PipelineLayoutCreateInfo* MarshalTo()
        {
            return (Interop.PipelineLayoutCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct PipelineMultisampleStateCreateInfo
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
			result.SType = StructureType.PipelineMultisampleStateCreateInfo;
			
			//SampleMask
			if (this.SampleMask != null && Math.Ceiling((int)RasterizationSamples / (float)32) > 0)
			{
			    int length = (int)(Math.Ceiling((int)RasterizationSamples / (float)32));
			    result.SampleMask = (SampleMask*)Interop.HeapUtil.Allocate<SampleMask>(length).ToPointer();
			    for (int index = 0; index < length; index++)
			    {
			        result.SampleMask[index] = this.SampleMask[index];
			    }
			}
			else
			{
			    result.SampleMask = null;
			}
			result.Flags = this.Flags;
			result.RasterizationSamples = this.RasterizationSamples;
			result.SampleShadingEnable = this.SampleShadingEnable;
			result.MinSampleShading = this.MinSampleShading;
			result.AlphaToCoverageEnable = this.AlphaToCoverageEnable;
			result.AlphaToOneEnable = this.AlphaToOneEnable;

            return result;
        }

		internal unsafe Interop.PipelineMultisampleStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineMultisampleStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct PipelineRasterizationStateCreateInfo
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
			result.SType = StructureType.PipelineRasterizationStateCreateInfo;
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
            return (Interop.PipelineRasterizationStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct PipelineRasterizationStateRasterizationOrder
	{

		public RasterizationOrder RasterizationOrder
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineRasterizationStateRasterizationOrder Pack()
        {
            var result = new Interop.PipelineRasterizationStateRasterizationOrder();
			result.SType = StructureType.PipelineRasterizationStateRasterizationOrder;
			result.RasterizationOrder = this.RasterizationOrder;

            return result;
        }

		internal unsafe Interop.PipelineRasterizationStateRasterizationOrder* MarshalTo()
        {
            return (Interop.PipelineRasterizationStateRasterizationOrder*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct PipelineShaderStageCreateInfo
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

		public SpecializationInfo? SpecializationInfo
		{
			get;
			set;
		}

        internal unsafe Interop.PipelineShaderStageCreateInfo Pack()
        {
            var result = new Interop.PipelineShaderStageCreateInfo();
			result.SType = StructureType.PipelineShaderStageCreateInfo;
			result.Module = this.Module?.Pack() ?? Interop.ShaderModule.Null;
			result.Name = Interop.HeapUtil.MarshalTo(this.Name);
			result.SpecializationInfo = this.SpecializationInfo == null ? null : this.SpecializationInfo.Value.MarshalTo();
			result.Flags = this.Flags;
			result.Stage = this.Stage;

            return result;
        }

		internal unsafe Interop.PipelineShaderStageCreateInfo* MarshalTo()
        {
            return (Interop.PipelineShaderStageCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct PipelineTessellationStateCreateInfo
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
			result.SType = StructureType.PipelineTessellationStateCreateInfo;
			result.Flags = this.Flags;
			result.PatchControlPoints = this.PatchControlPoints;

            return result;
        }

		internal unsafe Interop.PipelineTessellationStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineTessellationStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct PipelineVertexInputStateCreateInfo
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
			result.SType = StructureType.PipelineVertexInputStateCreateInfo;
			
			//VertexBindingDescriptions
			if (this.VertexBindingDescriptions != null)
			{
			    result.VertexBindingDescriptions = (VertexInputBindingDescription*)Interop.HeapUtil.Allocate<VertexInputBindingDescription>(this.VertexBindingDescriptions.Length).ToPointer();
			    for (int index = 0; index < this.VertexBindingDescriptions.Length; index++)
			    {
			        result.VertexBindingDescriptions[index] = this.VertexBindingDescriptions[index];
			    }
			}
			else
			{
			    result.VertexBindingDescriptions = null;
			}
			
			//VertexAttributeDescriptions
			if (this.VertexAttributeDescriptions != null)
			{
			    result.VertexAttributeDescriptions = (VertexInputAttributeDescription*)Interop.HeapUtil.Allocate<VertexInputAttributeDescription>(this.VertexAttributeDescriptions.Length).ToPointer();
			    for (int index = 0; index < this.VertexAttributeDescriptions.Length; index++)
			    {
			        result.VertexAttributeDescriptions[index] = this.VertexAttributeDescriptions[index];
			    }
			}
			else
			{
			    result.VertexAttributeDescriptions = null;
			}
			result.VertexBindingDescriptionCount = (uint)(this.VertexBindingDescriptions?.Length ?? 0);
			result.VertexAttributeDescriptionCount = (uint)(this.VertexAttributeDescriptions?.Length ?? 0);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.PipelineVertexInputStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineVertexInputStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct PipelineViewportStateCreateInfo
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
			result.SType = StructureType.PipelineViewportStateCreateInfo;
			
			//Viewports
			if (this.Viewports != null)
			{
			    result.Viewports = (Viewport*)Interop.HeapUtil.Allocate<Viewport>(this.Viewports.Length).ToPointer();
			    for (int index = 0; index < this.Viewports.Length; index++)
			    {
			        result.Viewports[index] = this.Viewports[index];
			    }
			}
			else
			{
			    result.Viewports = null;
			}
			
			//Scissors
			if (this.Scissors != null)
			{
			    result.Scissors = (Rect2D*)Interop.HeapUtil.Allocate<Rect2D>(this.Scissors.Length).ToPointer();
			    for (int index = 0; index < this.Scissors.Length; index++)
			    {
			        result.Scissors[index] = this.Scissors[index];
			    }
			}
			else
			{
			    result.Scissors = null;
			}
			result.ViewportCount = (uint)(this.Viewports?.Length ?? 0);
			result.ScissorCount = (uint)(this.Scissors?.Length ?? 0);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.PipelineViewportStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineViewportStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct PresentInfo
	{

		public Semaphore[] WaitSemaphores
		{
			get;
			set;
		}

		public Swapchain[] Swapchains
		{
			get;
			set;
		}

		public uint[] ImageIndices
		{
			get;
			set;
		}

		public Result[] Results
		{
			get;
			set;
		}

        internal unsafe Interop.PresentInfo Pack()
        {
            var result = new Interop.PresentInfo();
			result.SType = StructureType.PresentInfo;
			
			//WaitSemaphores
			if (this.WaitSemaphores != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.Semaphore>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.Semaphore>(this.WaitSemaphores.Length);
			    for (int index = 0; index < this.WaitSemaphores.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.WaitSemaphores[index].Pack(), pointer + (size * index), false);
			    }
			    result.WaitSemaphores = (Interop.Semaphore*)pointer.ToPointer();
			}
			else
			{
			    result.WaitSemaphores = null;
			}
			
			//Swapchains
			if (this.Swapchains != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.Swapchain>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.Swapchain>(this.Swapchains.Length);
			    for (int index = 0; index < this.Swapchains.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.Swapchains[index].Pack(), pointer + (size * index), false);
			    }
			    result.Swapchains = (Interop.Swapchain*)pointer.ToPointer();
			}
			else
			{
			    result.Swapchains = null;
			}
			result.ImageIndices = this.ImageIndices == null ? null : Interop.HeapUtil.MarshalTo(this.ImageIndices);
			
			//Results
			if (this.Results != null)
			{
			    result.Results = (Result*)Interop.HeapUtil.Allocate<int>(this.Results.Length).ToPointer();
			    for (int index = 0; index < this.Results.Length; index++)
			    {
			        result.Results[index] = this.Results[index];
			    }
			}
			else
			{
			    result.Results = null;
			}
			result.WaitSemaphoreCount = (uint)(this.WaitSemaphores?.Length ?? 0);
			result.SwapchainCount = (uint)(this.ImageIndices?.Length ?? 0);

            return result;
        }

		internal unsafe Interop.PresentInfo* MarshalTo()
        {
            return (Interop.PresentInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct QueryPoolCreateInfo
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
			result.SType = StructureType.QueryPoolCreateInfo;
			result.Flags = this.Flags;
			result.QueryType = this.QueryType;
			result.QueryCount = this.QueryCount;
			result.PipelineStatistics = this.PipelineStatistics;

            return result;
        }

		internal unsafe Interop.QueryPoolCreateInfo* MarshalTo()
        {
            return (Interop.QueryPoolCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// pname:renderArea is the render area that is affected by the render pass
    /// instance. The effects of attachment load, store and resolve operations are
    /// restricted to the pixels whose x and y coordinates fall within the render
    /// area on all attachments. The render area extends to all layers of
    /// pname:framebuffer. The application must: ensure (using scissor if necessary)
    /// that all rendering is contained within the render area, otherwise the pixels
    /// outside of the render area become undefined and shader side effects may:
    /// occur for fragments outside the render area. The render area must: be
    /// contained within the framebuffer dimensions.
    /// [NOTE]
    /// .Note
    /// ====
    /// There may: be a performance cost for using a render area smaller than the
    /// framebuffer, unless it matches the render area granularity for the render
    /// pass.
    /// ====
    /// </summary>
	public struct RenderPassBeginInfo
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
			result.SType = StructureType.RenderPassBeginInfo;
			result.RenderPass = this.RenderPass?.Pack() ?? Interop.RenderPass.Null;
			result.Framebuffer = this.Framebuffer?.Pack() ?? Interop.Framebuffer.Null;
			
			//ClearValues
			if (this.ClearValues != null && this.ClearValues.Length > 0)
			{
			    int length = (int)(this.ClearValues.Length);
			    result.ClearValues = (ClearValue*)Interop.HeapUtil.Allocate<ClearValue>(length).ToPointer();
			    for (int index = 0; index < length; index++)
			    {
			        result.ClearValues[index] = this.ClearValues[index];
			    }
			}
			else
			{
			    result.ClearValues = null;
			}
			result.ClearValueCount = (uint)(this.ClearValues?.Length ?? 0);
			result.RenderArea = this.RenderArea;

            return result;
        }

		internal unsafe Interop.RenderPassBeginInfo* MarshalTo()
        {
            return (Interop.RenderPassBeginInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct RenderPassCreateInfo
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
			result.SType = StructureType.RenderPassCreateInfo;
			
			//Attachments
			if (this.Attachments != null)
			{
			    result.Attachments = (AttachmentDescription*)Interop.HeapUtil.Allocate<AttachmentDescription>(this.Attachments.Length).ToPointer();
			    for (int index = 0; index < this.Attachments.Length; index++)
			    {
			        result.Attachments[index] = this.Attachments[index];
			    }
			}
			else
			{
			    result.Attachments = null;
			}
			
			//Subpasses
			if (this.Subpasses != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SubpassDescription>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.SubpassDescription>(this.Subpasses.Length);
			    for (int index = 0; index < this.Subpasses.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.Subpasses[index].Pack(), pointer + (size * index), false);
			    }
			    result.Subpasses = (Interop.SubpassDescription*)pointer.ToPointer();
			}
			else
			{
			    result.Subpasses = null;
			}
			
			//Dependencies
			if (this.Dependencies != null)
			{
			    result.Dependencies = (SubpassDependency*)Interop.HeapUtil.Allocate<SubpassDependency>(this.Dependencies.Length).ToPointer();
			    for (int index = 0; index < this.Dependencies.Length; index++)
			    {
			        result.Dependencies[index] = this.Dependencies[index];
			    }
			}
			else
			{
			    result.Dependencies = null;
			}
			result.AttachmentCount = (uint)(this.Attachments?.Length ?? 0);
			result.SubpassCount = (uint)(this.Subpasses?.Length ?? 0);
			result.DependencyCount = (uint)(this.Dependencies?.Length ?? 0);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.RenderPassCreateInfo* MarshalTo()
        {
            return (Interop.RenderPassCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// [NOTE]
    /// .Mapping of OpenGL to Vulkan filter modes
    /// ==================
    /// pname:magFilter values of ename:VK_FILTER_NEAREST and ename:VK_FILTER_LINEAR
    /// directly correspond to code:GL_NEAREST and code:GL_LINEAR magnification
    /// filters. pname:minFilter and pname:mipmapMode combine to correspond to the
    /// similarly named OpenGL minification filter of
    /// code:GL_minFilter_MIPMAP_mipmapMode (e.g. pname:minFilter of
    /// ename:VK_FILTER_LINEAR and pname:mipmapMode of
    /// ename:VK_SAMPLER_MIPMAP_MODE_NEAREST correspond to
    /// code:GL_LINEAR_MIPMAP_NEAREST).
    /// There are no Vulkan filter modes that directly correspond to OpenGL
    /// minification filters of code:GL_LINEAR or code:GL_NEAREST, but they can: be
    /// emulated using ename:VK_SAMPLER_MIPMAP_MODE_NEAREST, pname:minLod = 0, and
    /// pname:maxLod = 0.25, and using pname:minFilter = ename:VK_FILTER_LINEAR or
    /// pname:minFilter = ename:VK_FILTER_NEAREST, respectively.
    /// Note that using a pname:maxLod of zero would cause
    /// <<textures-texel-filtering,magnification>> to always be performed, and the
    /// pname:magFilter to always be used. This is valid, just not an exact match
    /// for OpenGL behavior. Clamping the maximum lod to 0.25 allows the
    /// latexmath:[$\lambda$] value to be non-zero and minification to be performed,
    /// while still always rounding down to the base level. If the pname:minFilter
    /// and pname:magFilter are equal, then using a pname:maxLod of zero also works.
    /// ==================
    /// pname:addressModeU, pname:addressModeV, and pname:addressModeW must: each
    /// have one of the following values:
    /// // refBegin VkSamplerAddressMode - specify behavior of sampling with texture coordinates outside an image
    /// include::../api/enums/VkSamplerAddressMode.txt[]
    /// These values control the behavior of sampling with coordinates outside the
    /// range latexmath:[$[0,1\]$] for the respective u, v, or w coordinate as defined in the
    /// <<textures-wrapping-operation, Wrapping Operation>> section.
    ///   * ename:VK_SAMPLER_ADDRESS_MODE_REPEAT indicates that the repeat wrap mode
    ///     will be used.
    ///   * ename:VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT indicates that the
    ///     mirrored repeat wrap mode will be used.
    ///   * ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE indicates that the clamp to
    ///     edge wrap mode will be used.
    ///   * ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER indicates that the clamp
    ///     to border wrap mode will be used.
    ///   * ename:VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE indicates that
    ///     the mirror clamp to edge wrap mode will be used. This is only valid
    ///     if the VK_KHR_mirror_clamp_to_edge extension is enabled.
    /// The maximum number of sampler objects which can: be simultaneously created
    /// on a device is implementation-dependent and specified by the
    /// <<features-limits-maxSamplerAllocationCount,pname:maxSamplerAllocationCount>>
    /// member of the sname:VkPhysicalDeviceLimits structure. If
    /// pname:maxSamplerAllocationCount is exceeded, fname:vkCreateSampler will
    /// return ename:VK_ERROR_TOO_MANY_OBJECTS.
    /// Since sname:VkSampler is a non-dispatchable handle type, implementations
    /// may: return the same handle for sampler state vectors that are identical. In
    /// such cases, all such objects would only count once against the
    /// pname:maxSamplerAllocationCount limit.
    /// </summary>
	public struct SamplerCreateInfo
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
			result.SType = StructureType.SamplerCreateInfo;
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
            return (Interop.SamplerCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct SemaphoreCreateInfo
	{

		public SemaphoreCreateFlags Flags
		{
			get;
			set;
		}

        internal unsafe Interop.SemaphoreCreateInfo Pack()
        {
            var result = new Interop.SemaphoreCreateInfo();
			result.SType = StructureType.SemaphoreCreateInfo;
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.SemaphoreCreateInfo* MarshalTo()
        {
            return (Interop.SemaphoreCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct ShaderModuleCreateInfo
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
			result.SType = StructureType.ShaderModuleCreateInfo;
			result.Code = this.Code == null ? null : Interop.HeapUtil.MarshalTo(this.Code);
			result.Flags = this.Flags;
			result.CodeSize = this.CodeSize;

            return result;
        }

		internal unsafe Interop.ShaderModuleCreateInfo* MarshalTo()
        {
            return (Interop.ShaderModuleCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct SparseBufferMemoryBindInfo
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
			result.Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;
			
			//Binds
			if (this.Binds != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SparseMemoryBind>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.SparseMemoryBind>(this.Binds.Length);
			    for (int index = 0; index < this.Binds.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.Binds[index].Pack(), pointer + (size * index), false);
			    }
			    result.Binds = (Interop.SparseMemoryBind*)pointer.ToPointer();
			}
			else
			{
			    result.Binds = null;
			}
			result.BindCount = (uint)(this.Binds?.Length ?? 0);

            return result;
        }

		internal unsafe Interop.SparseBufferMemoryBindInfo* MarshalTo()
        {
            return (Interop.SparseBufferMemoryBindInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct SparseImageMemoryBind
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

		public ulong MemoryOffset
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
			result.Memory = this.Memory?.Pack() ?? Interop.DeviceMemory.Null;
			result.Subresource = this.Subresource;
			result.Offset = this.Offset;
			result.Extent = this.Extent;
			result.MemoryOffset = this.MemoryOffset;
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.SparseImageMemoryBind* MarshalTo()
        {
            return (Interop.SparseImageMemoryBind*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct SparseImageMemoryBindInfo
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
			result.Image = this.Image?.Pack() ?? Interop.Image.Null;
			
			//Binds
			if (this.Binds != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SparseImageMemoryBind>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.SparseImageMemoryBind>(this.Binds.Length);
			    for (int index = 0; index < this.Binds.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.Binds[index].Pack(), pointer + (size * index), false);
			    }
			    result.Binds = (Interop.SparseImageMemoryBind*)pointer.ToPointer();
			}
			else
			{
			    result.Binds = null;
			}
			result.BindCount = (uint)(this.Binds?.Length ?? 0);

            return result;
        }

		internal unsafe Interop.SparseImageMemoryBindInfo* MarshalTo()
        {
            return (Interop.SparseImageMemoryBindInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct SparseImageOpaqueMemoryBindInfo
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
			result.Image = this.Image?.Pack() ?? Interop.Image.Null;
			
			//Binds
			if (this.Binds != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.SparseMemoryBind>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.SparseMemoryBind>(this.Binds.Length);
			    for (int index = 0; index < this.Binds.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.Binds[index].Pack(), pointer + (size * index), false);
			    }
			    result.Binds = (Interop.SparseMemoryBind*)pointer.ToPointer();
			}
			else
			{
			    result.Binds = null;
			}
			result.BindCount = (uint)(this.Binds?.Length ?? 0);

            return result;
        }

		internal unsafe Interop.SparseImageOpaqueMemoryBindInfo* MarshalTo()
        {
            return (Interop.SparseImageOpaqueMemoryBindInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// The _binding range_ latexmath:[$[\mathit{resourceOffset},
    /// \mathit{resourceOffset} + \mathit{size})$] has different constraints based
    /// on pname:flags. If pname:flags contains
    /// ename:VK_SPARSE_MEMORY_BIND_METADATA_BIT, the binding range must: be within
    /// the mip tail region of the metadata aspect. This metadata region is defined
    /// by:
    /// [latexmath]
    /// ++++++++++++++++++++++++++
    /// \begin{align*}
    /// \mathit{metadataRegion} = [&
    ///         \mathit{imageMipTailOffset} + \mathit{imageMipTailStride} \times n,\\
    ///         &\mathit{imageMipTailOffset} +
    ///                 \mathit{imageMipTailStride} \times n + \mathit{imageMipTailSize})
    /// \end{align*}
    /// ++++++++++++++++++++++++++
    /// Where pname:imageMipTailOffset, pname:imageMipTailSize, and
    /// pname:imageMipTailStride values are from the
    /// slink:VkSparseImageMemoryRequirements that correspond to the metadata aspect
    /// of the image. The term latexmath:[$n$] is a valid array layer index for the
    /// image.
    /// pname:imageMipTailStride is considered to be zero for aspects where
    /// sname:VkSparseImageMemoryRequirements::pname:formatProperties.flags contains
    /// ename:VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT.
    /// If pname:flags does not contain ename:VK_SPARSE_MEMORY_BIND_METADATA_BIT,
    /// the binding range must: be within the range
    /// latexmath:[$[0, {\mathit{VkMemoryRequirements}::\mathit{size}})$].
    /// </summary>
	public struct SparseMemoryBind
	{

		public ulong ResourceOffset
		{
			get;
			set;
		}

		public ulong Size
		{
			get;
			set;
		}

		public DeviceMemory Memory
		{
			get;
			set;
		}

		public ulong MemoryOffset
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
			result.Memory = this.Memory?.Pack() ?? Interop.DeviceMemory.Null;
			result.ResourceOffset = this.ResourceOffset;
			result.Size = this.Size;
			result.MemoryOffset = this.MemoryOffset;
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.SparseMemoryBind* MarshalTo()
        {
            return (Interop.SparseMemoryBind*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// pname:pMapEntries points to a structure of type
    /// slink:VkSpecializationMapEntry.
    /// </summary>
	public struct SpecializationInfo
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
			
			//MapEntries
			if (this.MapEntries != null)
			{
			    result.MapEntries = (SpecializationMapEntry*)Interop.HeapUtil.Allocate<SpecializationMapEntry>(this.MapEntries.Length).ToPointer();
			    for (int index = 0; index < this.MapEntries.Length; index++)
			    {
			        result.MapEntries[index] = this.MapEntries[index];
			    }
			}
			else
			{
			    result.MapEntries = null;
			}
			result.Data = this.Data == null ? null : Interop.HeapUtil.MarshalTo(this.Data);
			result.MapEntryCount = (uint)(this.MapEntries?.Length ?? 0);
			result.DataSize = (UIntPtr)(this.Data?.Length ?? 0);

            return result;
        }

		internal unsafe Interop.SpecializationInfo* MarshalTo()
        {
            return (Interop.SpecializationInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct SubmitInfo
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
			result.SType = StructureType.SubmitInfo;
			
			//WaitSemaphores
			if (this.WaitSemaphores != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.Semaphore>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.Semaphore>(this.WaitSemaphores.Length);
			    for (int index = 0; index < this.WaitSemaphores.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.WaitSemaphores[index].Pack(), pointer + (size * index), false);
			    }
			    result.WaitSemaphores = (Interop.Semaphore*)pointer.ToPointer();
			}
			else
			{
			    result.WaitSemaphores = null;
			}
			
			//WaitDestinationStageMask
			if (this.WaitDestinationStageMask != null)
			{
			    result.WaitDestinationStageMask = (PipelineStageFlags*)Interop.HeapUtil.Allocate<int>(this.WaitDestinationStageMask.Length).ToPointer();
			    for (int index = 0; index < this.WaitDestinationStageMask.Length; index++)
			    {
			        result.WaitDestinationStageMask[index] = this.WaitDestinationStageMask[index];
			    }
			}
			else
			{
			    result.WaitDestinationStageMask = null;
			}
			
			//CommandBuffers
			if (this.CommandBuffers != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.CommandBuffer>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.CommandBuffer>(this.CommandBuffers.Length);
			    for (int index = 0; index < this.CommandBuffers.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.CommandBuffers[index].Pack(), pointer + (size * index), false);
			    }
			    result.CommandBuffers = (Interop.CommandBuffer*)pointer.ToPointer();
			}
			else
			{
			    result.CommandBuffers = null;
			}
			
			//SignalSemaphores
			if (this.SignalSemaphores != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.Semaphore>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.Semaphore>(this.SignalSemaphores.Length);
			    for (int index = 0; index < this.SignalSemaphores.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.SignalSemaphores[index].Pack(), pointer + (size * index), false);
			    }
			    result.SignalSemaphores = (Interop.Semaphore*)pointer.ToPointer();
			}
			else
			{
			    result.SignalSemaphores = null;
			}
			result.WaitSemaphoreCount = (uint)(this.WaitDestinationStageMask?.Length ?? 0);
			result.CommandBufferCount = (uint)(this.CommandBuffers?.Length ?? 0);
			result.SignalSemaphoreCount = (uint)(this.SignalSemaphores?.Length ?? 0);

            return result;
        }

		internal unsafe Interop.SubmitInfo* MarshalTo()
        {
            return (Interop.SubmitInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// The contents of an attachment within the render area become undefined at
    /// the start of a subpass S if all of the following conditions are true:
    ///   * The attachment is used as a color, depth/stencil, or resolve attachment
    ///     in any subpass in the render pass.
    ///   * There is a subpass S1 that uses or preserves the attachment, and a
    ///     subpass dependency from S1 to S.
    ///   * The attachment is not used or preserved in subpass S.
    /// Once the contents of an attachment become undefined in subpass S, they
    /// remain undefined for subpasses in subpass dependency chains starting with
    /// subpass S until they are written again. However, they remain valid for
    /// subpasses in other subpass dependency chains starting with subpass S1 if
    /// those subpasses use or preserve the attachment.
    /// </summary>
	public struct SubpassDescription
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
			
			//InputAttachments
			if (this.InputAttachments != null)
			{
			    result.InputAttachments = (AttachmentReference*)Interop.HeapUtil.Allocate<AttachmentReference>(this.InputAttachments.Length).ToPointer();
			    for (int index = 0; index < this.InputAttachments.Length; index++)
			    {
			        result.InputAttachments[index] = this.InputAttachments[index];
			    }
			}
			else
			{
			    result.InputAttachments = null;
			}
			
			//ColorAttachments
			if (this.ColorAttachments != null)
			{
			    result.ColorAttachments = (AttachmentReference*)Interop.HeapUtil.Allocate<AttachmentReference>(this.ColorAttachments.Length).ToPointer();
			    for (int index = 0; index < this.ColorAttachments.Length; index++)
			    {
			        result.ColorAttachments[index] = this.ColorAttachments[index];
			    }
			}
			else
			{
			    result.ColorAttachments = null;
			}
			
			//ResolveAttachments
			if (this.ResolveAttachments != null)
			{
			    result.ResolveAttachments = (AttachmentReference*)Interop.HeapUtil.Allocate<AttachmentReference>(this.ResolveAttachments.Length).ToPointer();
			    for (int index = 0; index < this.ResolveAttachments.Length; index++)
			    {
			        result.ResolveAttachments[index] = this.ResolveAttachments[index];
			    }
			}
			else
			{
			    result.ResolveAttachments = null;
			}
			result.DepthStencilAttachment = (AttachmentReference*)Interop.HeapUtil.AllocateAndMarshal(this.DepthStencilAttachment);
			result.PreserveAttachments = this.PreserveAttachments == null ? null : Interop.HeapUtil.MarshalTo(this.PreserveAttachments);
			result.InputAttachmentCount = (uint)(this.InputAttachments?.Length ?? 0);
			result.ColorAttachmentCount = (uint)(this.ColorAttachments?.Length ?? 0);
			result.PreserveAttachmentCount = (uint)(this.PreserveAttachments?.Length ?? 0);
			result.Flags = this.Flags;
			result.PipelineBindPoint = this.PipelineBindPoint;

            return result;
        }

		internal unsafe Interop.SubpassDescription* MarshalTo()
        {
            return (Interop.SubpassDescription*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct SwapchainCreateInfo
	{

		public SwapchainCreateFlags Flags
		{
			get;
			set;
		}

		public Surface Surface
		{
			get;
			set;
		}

		public uint MinImageCount
		{
			get;
			set;
		}

		public Format ImageFormat
		{
			get;
			set;
		}

		public ColorSpace ImageColorSpace
		{
			get;
			set;
		}

		public Extent2D ImageExtent
		{
			get;
			set;
		}

		public uint ImageArrayLayers
		{
			get;
			set;
		}

		public ImageUsageFlags ImageUsage
		{
			get;
			set;
		}

		public SharingMode ImageSharingMode
		{
			get;
			set;
		}

		public uint[] QueueFamilyIndices
		{
			get;
			set;
		}

		public SurfaceTransformFlags PreTransform
		{
			get;
			set;
		}

		public CompositeAlphaFlags CompositeAlpha
		{
			get;
			set;
		}

		public PresentMode PresentMode
		{
			get;
			set;
		}

		public Bool32 Clipped
		{
			get;
			set;
		}

		public Swapchain OldSwapchain
		{
			get;
			set;
		}

        internal unsafe Interop.SwapchainCreateInfo Pack()
        {
            var result = new Interop.SwapchainCreateInfo();
			result.SType = StructureType.SwapchainCreateInfo;
			result.Surface = this.Surface?.Pack() ?? Interop.Surface.Null;
			result.QueueFamilyIndices = this.QueueFamilyIndices == null ? null : Interop.HeapUtil.MarshalTo(this.QueueFamilyIndices);
			result.OldSwapchain = this.OldSwapchain?.Pack() ?? Interop.Swapchain.Null;
			result.QueueFamilyIndexCount = (uint)(this.QueueFamilyIndices?.Length ?? 0);
			result.Flags = this.Flags;
			result.MinImageCount = this.MinImageCount;
			result.ImageFormat = this.ImageFormat;
			result.ImageColorSpace = this.ImageColorSpace;
			result.ImageExtent = this.ImageExtent;
			result.ImageArrayLayers = this.ImageArrayLayers;
			result.ImageUsage = this.ImageUsage;
			result.ImageSharingMode = this.ImageSharingMode;
			result.PreTransform = this.PreTransform;
			result.CompositeAlpha = this.CompositeAlpha;
			result.PresentMode = this.PresentMode;
			result.Clipped = this.Clipped;

            return result;
        }

		internal unsafe Interop.SwapchainCreateInfo* MarshalTo()
        {
            return (Interop.SwapchainCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct WaylandSurfaceCreateInfo
	{

		public WaylandSurfaceCreateFlags Flags
		{
			get;
			set;
		}

		public IntPtr Display
		{
			get;
			set;
		}

		public IntPtr Surface
		{
			get;
			set;
		}

        internal unsafe Interop.WaylandSurfaceCreateInfo Pack()
        {
            var result = new Interop.WaylandSurfaceCreateInfo();
			result.SType = StructureType.WaylandSurfaceCreateInfo;
			result.Flags = this.Flags;
			result.Display = this.Display;
			result.Surface = this.Surface;

            return result;
        }

		internal unsafe Interop.WaylandSurfaceCreateInfo* MarshalTo()
        {
            return (Interop.WaylandSurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct Win32SurfaceCreateInfo
	{

		public Win32SurfaceCreateFlags Flags
		{
			get;
			set;
		}

		public IntPtr Hinstance
		{
			get;
			set;
		}

		public IntPtr Hwnd
		{
			get;
			set;
		}

        internal unsafe Interop.Win32SurfaceCreateInfo Pack()
        {
            var result = new Interop.Win32SurfaceCreateInfo();
			result.SType = StructureType.Win32SurfaceCreateInfo;
			result.Flags = this.Flags;
			result.Hinstance = this.Hinstance;
			result.Hwnd = this.Hwnd;

            return result;
        }

		internal unsafe Interop.Win32SurfaceCreateInfo* MarshalTo()
        {
            return (Interop.Win32SurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// Only one of pname:pImageInfo, pname:pBufferInfo, or pname:pTexelBufferView
    /// members is used according to the descriptor type specified in the
    /// pname:descriptorType member of the containing sname:VkWriteDescriptorSet
    /// structure, as specified below.
    /// [[descriptorsets-updates-consecutive, consecutive binding updates]]
    /// If the pname:dstBinding has fewer than pname:descriptorCount array elements
    /// remaining starting from pname:dstArrayElement, then the remainder will be
    /// used to update the subsequent binding - pname:dstBinding+1 starting at array
    /// element zero. This behavior applies recursively, with the update affecting
    /// consecutive bindings as needed to update all pname:descriptorCount
    /// descriptors. All consecutive bindings updated via a single
    /// sname:VkWriteDescriptorSet structure must: have identical
    /// pname:descriptorType and pname:stageFlags, and must: all either use
    /// immutable samplers or must: all not use immutable samplers.
    /// </summary>
	public struct WriteDescriptorSet
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
			result.SType = StructureType.WriteDescriptorSet;
			result.DestinationSet = this.DestinationSet?.Pack() ?? Interop.DescriptorSet.Null;
			
			//ImageInfo
			if (this.ImageInfo != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DescriptorImageInfo>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DescriptorImageInfo>(this.ImageInfo.Length);
			    for (int index = 0; index < this.ImageInfo.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.ImageInfo[index].Pack(), pointer + (size * index), false);
			    }
			    result.ImageInfo = (Interop.DescriptorImageInfo*)pointer.ToPointer();
			}
			else
			{
			    result.ImageInfo = null;
			}
			
			//BufferInfo
			if (this.BufferInfo != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DescriptorBufferInfo>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DescriptorBufferInfo>(this.BufferInfo.Length);
			    for (int index = 0; index < this.BufferInfo.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.BufferInfo[index].Pack(), pointer + (size * index), false);
			    }
			    result.BufferInfo = (Interop.DescriptorBufferInfo*)pointer.ToPointer();
			}
			else
			{
			    result.BufferInfo = null;
			}
			
			//TexelBufferView
			if (this.TexelBufferView != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.BufferView>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.BufferView>(this.TexelBufferView.Length);
			    for (int index = 0; index < this.TexelBufferView.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.TexelBufferView[index].Pack(), pointer + (size * index), false);
			    }
			    result.TexelBufferView = (Interop.BufferView*)pointer.ToPointer();
			}
			else
			{
			    result.TexelBufferView = null;
			}
			result.DescriptorCount = (uint)(this.TexelBufferView?.Length ?? 0);
			result.DestinationBinding = this.DestinationBinding;
			result.DestinationArrayElement = this.DestinationArrayElement;
			result.DescriptorType = this.DescriptorType;

            return result;
        }

		internal unsafe Interop.WriteDescriptorSet* MarshalTo()
        {
            return (Interop.WriteDescriptorSet*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct XcbSurfaceCreateInfo
	{

		public XcbSurfaceCreateFlags Flags
		{
			get;
			set;
		}

		public IntPtr Connection
		{
			get;
			set;
		}

		public IntPtr Window
		{
			get;
			set;
		}

        internal unsafe Interop.XcbSurfaceCreateInfo Pack()
        {
            var result = new Interop.XcbSurfaceCreateInfo();
			result.SType = StructureType.XcbSurfaceCreateInfo;
			result.Connection = (IntPtr*)Interop.HeapUtil.AllocateAndMarshal(this.Connection);
			result.Flags = this.Flags;
			result.Window = this.Window;

            return result;
        }

		internal unsafe Interop.XcbSurfaceCreateInfo* MarshalTo()
        {
            return (Interop.XcbSurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// 
    /// </summary>
	public struct XlibSurfaceCreateInfo
	{

		public XlibSurfaceCreateFlags Flags
		{
			get;
			set;
		}

		public IntPtr Dpy
		{
			get;
			set;
		}

		public IntPtr Window
		{
			get;
			set;
		}

        internal unsafe Interop.XlibSurfaceCreateInfo Pack()
        {
            var result = new Interop.XlibSurfaceCreateInfo();
			result.SType = StructureType.XlibSurfaceCreateInfo;
			result.Dpy = (IntPtr*)Interop.HeapUtil.AllocateAndMarshal(this.Dpy);
			result.Flags = this.Flags;
			result.Window = this.Window;

            return result;
        }

		internal unsafe Interop.XlibSurfaceCreateInfo* MarshalTo()
        {
            return (Interop.XlibSurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
}