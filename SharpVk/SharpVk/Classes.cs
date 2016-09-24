// The MIT License (MIT)
//
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be editted directly.

using System;

namespace SharpVk
{

    /// <summary>
    /// <para>
    /// Structure containing callback function pointers for memory allocation.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:pfnAllocation must: be a pointer to a valid user-defined tlink:PFN_vkAllocationFunction * pname:pfnReallocation must: be a pointer to a valid user-defined tlink:PFN_vkReallocationFunction * pname:pfnFree must: be a pointer to a valid user-defined tlink:PFN_vkFreeFunction * If either of pname:pfnInternalAllocation or pname:pfnInternalFree is not `NULL`, both must: be valid callbacks ****
    /// </para>
    /// </summary>
	public struct AllocationCallbacks
	{
		/// <summary>
		/// -
		/// </summary>
		public IntPtr UserData
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Interop.AllocationFunctionDelegate PfnAllocation
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Interop.ReallocationFunctionDelegate PfnReallocation
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Interop.FreeFunctionDelegate PfnFree
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Interop.InternalAllocationNotificationDelegate PfnInternalAllocation
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Interop.InternalFreeNotificationDelegate PfnInternalFree
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.AllocationCallbacks Pack()
		{
			Interop.AllocationCallbacks result = default(Interop.AllocationCallbacks);
			result.UserData = this.UserData.ToPointer();
			result.PfnAllocation = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnAllocation);
			result.PfnReallocation = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnReallocation);
			result.PfnFree = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnFree);
			result.PfnInternalAllocation = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnInternalAllocation);
			result.PfnInternalFree = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnInternalFree);
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.AllocationCallbacks* MarshalTo()
		{
			return (Interop.AllocationCallbacks*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created Android surface object.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:window must: not be in a connected state ****
    /// </para>
    /// </summary>
	public struct AndroidSurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public AndroidSurfaceCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Window
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.AndroidSurfaceCreateInfo Pack()
		{
			Interop.AndroidSurfaceCreateInfo result = default(Interop.AndroidSurfaceCreateInfo);
			result.SType = StructureType.AndroidSurfaceCreateInfo;
			result.Window = (IntPtr*)Interop.HeapUtil.AllocateAndMarshal(this.Window);
			result.Flags = this.Flags;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.AndroidSurfaceCreateInfo* MarshalTo()
		{
			return (Interop.AndroidSurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying application info.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:apiVersion must: be zero, or otherwise it must: be a version that the implementation supports, or supports an effective substitute for ****
    /// </para>
    /// </summary>
	public struct ApplicationInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public string ApplicationName
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Version ApplicationVersion
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public string EngineName
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Version EngineVersion
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Version ApiVersion
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ApplicationInfo Pack()
		{
			Interop.ApplicationInfo result = default(Interop.ApplicationInfo);
			result.SType = StructureType.ApplicationInfo;
			result.ApplicationName = Interop.HeapUtil.MarshalTo(this.ApplicationName);
			result.ApplicationVersion = (uint)this.ApplicationVersion;
			result.EngineName = Interop.HeapUtil.MarshalTo(this.EngineName);
			result.EngineVersion = (uint)this.EngineVersion;
			result.ApiVersion = (uint)this.ApiVersion;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ApplicationInfo* MarshalTo()
		{
			return (Interop.ApplicationInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct BindSparseInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Semaphore[] WaitSemaphores
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SparseBufferMemoryBindInfo[] BufferBinds
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SparseImageOpaqueMemoryBindInfo[] ImageOpaqueBinds
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SparseImageMemoryBindInfo[] ImageBinds
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Semaphore[] SignalSemaphores
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.BindSparseInfo Pack()
		{
			Interop.BindSparseInfo result = default(Interop.BindSparseInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.BindSparseInfo* MarshalTo()
		{
			return (Interop.BindSparseInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct BufferCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public BufferCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong Size
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public BufferUsageFlags Usage
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SharingMode SharingMode
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint[] QueueFamilyIndices
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.BufferCreateInfo Pack()
		{
			Interop.BufferCreateInfo result = default(Interop.BufferCreateInfo);
			result.SType = StructureType.BufferCreateInfo;
			result.QueueFamilyIndices = this.QueueFamilyIndices == null ? null : Interop.HeapUtil.MarshalTo(this.QueueFamilyIndices);
			result.QueueFamilyIndexCount = (uint)(this.QueueFamilyIndices?.Length ?? 0);
			result.Flags = this.Flags;
			result.Size = this.Size;
			result.Usage = this.Usage;
			result.SharingMode = this.SharingMode;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.BufferCreateInfo* MarshalTo()
		{
			return (Interop.BufferCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying the parameters of a buffer memory barrier.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:offset must: be less than the size of pname:buffer * If pname:size is not equal to ename:VK_WHOLE_SIZE, pname:size must: be greater than `0` * If pname:size is not equal to ename:VK_WHOLE_SIZE, pname:size must: be less than or equal to than the size of pname:buffer minus pname:offset * If pname:buffer was created with a sharing mode of ename:VK_SHARING_MODE_CONCURRENT, pname:srcQueueFamilyIndex and pname:dstQueueFamilyIndex must: both be ename:VK_QUEUE_FAMILY_IGNORED * If pname:buffer was created with a sharing mode of ename:VK_SHARING_MODE_EXCLUSIVE, pname:srcQueueFamilyIndex and pname:dstQueueFamilyIndex must: either both be ename:VK_QUEUE_FAMILY_IGNORED, or both be a valid queue family (see &lt;&lt;devsandqueues-queueprops&gt;&gt;) * If pname:buffer was created with a sharing mode of ename:VK_SHARING_MODE_EXCLUSIVE, and pname:srcQueueFamilyIndex and pname:dstQueueFamilyIndex are valid queue families, at least one of them must: be the same as the family of the queue that will execute this barrier ****
    /// </para>
    /// </summary>
	public struct BufferMemoryBarrier
	{
		/// <summary>
		/// -
		/// </summary>
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint SourceQueueFamilyIndex
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint DestinationQueueFamilyIndex
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Buffer Buffer
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong Offset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong Size
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.BufferMemoryBarrier Pack()
		{
			Interop.BufferMemoryBarrier result = default(Interop.BufferMemoryBarrier);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.BufferMemoryBarrier* MarshalTo()
		{
			return (Interop.BufferMemoryBarrier*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created buffer view.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:offset must: be less than the size of pname:buffer * pname:offset must: be a multiple of sname:VkPhysicalDeviceLimits::pname:minTexelBufferOffsetAlignment * If pname:range is not equal to ename:VK_WHOLE_SIZE: ** pname:range must: be greater than `0` ** pname:range must: be a multiple of the element size of pname:format ** pname:range divided by the size of an element of pname:format, must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxTexelBufferElements ** the sum of pname:offset and pname:range must: be less than or equal to the size of pname:buffer * pname:buffer must: have been created with a pname:usage value containing at least one of ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT * If pname:buffer was created with pname:usage containing ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT, pname:format must: be supported for uniform texel buffers, as specified by the ename:VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT flag in sname:VkFormatProperties::pname:bufferFeatures returned by fname:vkGetPhysicalDeviceFormatProperties * If pname:buffer was created with pname:usage containing ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT, pname:format must: be supported for storage texel buffers, as specified by the ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT flag in sname:VkFormatProperties::pname:bufferFeatures returned by fname:vkGetPhysicalDeviceFormatProperties ****
    /// </para>
    /// </summary>
	public struct BufferViewCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public BufferViewCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Buffer Buffer
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Format Format
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong Offset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong Range
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.BufferViewCreateInfo Pack()
		{
			Interop.BufferViewCreateInfo result = default(Interop.BufferViewCreateInfo);
			result.SType = StructureType.BufferViewCreateInfo;
			result.Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;
			result.Flags = this.Flags;
			result.Format = this.Format;
			result.Offset = this.Offset;
			result.Range = this.Range;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.BufferViewCreateInfo* MarshalTo()
		{
			return (Interop.BufferViewCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct CommandBufferAllocateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public CommandPool CommandPool
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public CommandBufferLevel Level
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint CommandBufferCount
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.CommandBufferAllocateInfo Pack()
		{
			Interop.CommandBufferAllocateInfo result = default(Interop.CommandBufferAllocateInfo);
			result.SType = StructureType.CommandBufferAllocateInfo;
			result.CommandPool = this.CommandPool?.Pack() ?? Interop.CommandPool.Null;
			result.Level = this.Level;
			result.CommandBufferCount = this.CommandBufferCount;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.CommandBufferAllocateInfo* MarshalTo()
		{
			return (Interop.CommandBufferAllocateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct CommandBufferBeginInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public CommandBufferUsageFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public CommandBufferInheritanceInfo? InheritanceInfo
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.CommandBufferBeginInfo Pack()
		{
			Interop.CommandBufferBeginInfo result = default(Interop.CommandBufferBeginInfo);
			result.SType = StructureType.CommandBufferBeginInfo;
			result.InheritanceInfo = this.InheritanceInfo == null ? null : this.InheritanceInfo.Value.MarshalTo();
			result.Flags = this.Flags;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.CommandBufferBeginInfo* MarshalTo()
		{
			return (Interop.CommandBufferBeginInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying command buffer inheritance info.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the &lt;&lt;features-features-inheritedQueries,inherited queries&gt;&gt; feature is not enabled, pname:occlusionQueryEnable must: be ename:VK_FALSE * If the &lt;&lt;features-features-inheritedQueries,inherited queries&gt;&gt; feature is enabled, pname:queryFlags must: be a valid combination of elink:VkQueryControlFlagBits values * If the &lt;&lt;features-features-pipelineStatisticsQuery,pipeline statistics queries&gt;&gt; feature is not enabled, pname:pipelineStatistics must: be code:0 ****
    /// </para>
    /// </summary>
	public struct CommandBufferInheritanceInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public RenderPass RenderPass
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint Subpass
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Framebuffer Framebuffer
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 OcclusionQueryEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:queryFlags indicates the query flags that can: be used by an active occlusion query in the primary command buffer when this secondary command buffer is executed. If this value includes the ename:VK_QUERY_CONTROL_PRECISE_BIT bit, then the active query can: return boolean results or actual sample counts. If this bit is not set, then the active query must: not use the ename:VK_QUERY_CONTROL_PRECISE_BIT bit.
		/// </para>
		/// </summary>
		public QueryControlFlags QueryFlags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public QueryPipelineStatisticFlags PipelineStatistics
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.CommandBufferInheritanceInfo Pack()
		{
			Interop.CommandBufferInheritanceInfo result = default(Interop.CommandBufferInheritanceInfo);
			result.SType = StructureType.CommandBufferInheritanceInfo;
			result.RenderPass = this.RenderPass?.Pack() ?? Interop.RenderPass.Null;
			result.Framebuffer = this.Framebuffer?.Pack() ?? Interop.Framebuffer.Null;
			result.Subpass = this.Subpass;
			result.OcclusionQueryEnable = this.OcclusionQueryEnable;
			result.QueryFlags = this.QueryFlags;
			result.PipelineStatistics = this.PipelineStatistics;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.CommandBufferInheritanceInfo* MarshalTo()
		{
			return (Interop.CommandBufferInheritanceInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct CommandPoolCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public CommandPoolCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint QueueFamilyIndex
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.CommandPoolCreateInfo Pack()
		{
			Interop.CommandPoolCreateInfo result = default(Interop.CommandPoolCreateInfo);
			result.SType = StructureType.CommandPoolCreateInfo;
			result.Flags = this.Flags;
			result.QueueFamilyIndex = this.QueueFamilyIndex;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.CommandPoolCreateInfo* MarshalTo()
		{
			return (Interop.CommandPoolCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created compute pipeline.
    /// </para>
    /// <para>
    /// The parameters pname:basePipelineHandle and pname:basePipelineIndex are described in more detail in &lt;&lt;pipelines-pipeline-derivatives,Pipeline Derivatives&gt;&gt;.
    /// </para>
    /// <para>
    /// pname:stage points to a structure of type sname:VkPipelineShaderStageCreateInfo.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:flags contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and pname:basePipelineIndex is not `-1`, pname:basePipelineHandle must: be dlink:VK_NULL_HANDLE * If pname:flags contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and pname:basePipelineIndex is not `-1`, it must: be a valid index into the calling command's pname:pCreateInfos parameter * If pname:flags contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and pname:basePipelineHandle is not dlink:VK_NULL_HANDLE, pname:basePipelineIndex must: be `-1` * If pname:flags contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and pname:basePipelineHandle is not dlink:VK_NULL_HANDLE, pname:basePipelineHandle must: be a valid sname:VkPipeline handle * If pname:flags contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and pname:basePipelineHandle is not dlink:VK_NULL_HANDLE, it must: be a valid handle to a compute sname:VkPipeline * The pname:stage member of pname:stage must: be ename:VK_SHADER_STAGE_COMPUTE_BIT * The shader code for the entry point identified by pname:stage and the rest of the state identified by this structure must: adhere to the pipeline linking rules described in the &lt;&lt;interfaces,Shader Interfaces&gt;&gt; chapter * pname:layout must: be &lt;&lt;descriptorsets-pipelinelayout-consistency,consistent&gt;&gt; with the layout of the compute shader specified in pname:stage ****
    /// </para>
    /// </summary>
	public struct ComputePipelineCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineShaderStageCreateInfo Stage
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineLayout Layout
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Pipeline BasePipelineHandle
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public int BasePipelineIndex
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ComputePipelineCreateInfo Pack()
		{
			Interop.ComputePipelineCreateInfo result = default(Interop.ComputePipelineCreateInfo);
			result.SType = StructureType.ComputePipelineCreateInfo;
			result.Stage = this.Stage.Pack();
			result.Layout = this.Layout?.Pack() ?? Interop.PipelineLayout.Null;
			result.BasePipelineHandle = this.BasePipelineHandle?.Pack() ?? Interop.Pipeline.Null;
			result.Flags = this.Flags;
			result.BasePipelineIndex = this.BasePipelineIndex;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ComputePipelineCreateInfo* MarshalTo()
		{
			return (Interop.ComputePipelineCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying a copy descriptor set operation.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:srcBinding must: be a valid binding within pname:srcSet * The sum of pname:srcArrayElement and pname:descriptorCount must: be less than or equal to the number of array elements in the descriptor set binding specified by pname:srcBinding, and all applicable consecutive bindings, as described by &lt;&lt;descriptorsets-updates-consecutive&gt;&gt; * pname:dstBinding must: be a valid binding within pname:dstSet * The sum of pname:dstArrayElement and pname:descriptorCount must: be less than or equal to the number of array elements in the descriptor set binding specified by pname:dstBinding, and all applicable consecutive bindings, as described by &lt;&lt;descriptorsets-updates-consecutive&gt;&gt; * If pname:srcSet is equal to pname:dstSet, then the source and destination ranges of descriptors must: not overlap, where the ranges may: include array elements from consecutive bindings as described by &lt;&lt;descriptorsets-updates-consecutive&gt;&gt; ****
    /// </para>
    /// </summary>
	public struct CopyDescriptorSet
	{
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSet SourceSet
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint SourceBinding
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint SourceArrayElement
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSet DestinationSet
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint DestinationBinding
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint DestinationArrayElement
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint DescriptorCount
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.CopyDescriptorSet Pack()
		{
			Interop.CopyDescriptorSet result = default(Interop.CopyDescriptorSet);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.CopyDescriptorSet* MarshalTo()
		{
			return (Interop.CopyDescriptorSet*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct DebugMarkerMarkerInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public string MarkerName
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float[] Color
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DebugMarkerMarkerInfo Pack()
		{
			Interop.DebugMarkerMarkerInfo result = default(Interop.DebugMarkerMarkerInfo);
			result.SType = StructureType.DebugMarkerMarkerInfo;
			result.MarkerName = Interop.HeapUtil.MarshalTo(this.MarkerName);
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DebugMarkerMarkerInfo* MarshalTo()
		{
			return (Interop.DebugMarkerMarkerInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct DebugMarkerObjectNameInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public DebugReportObjectType ObjectType
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong Object
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public string ObjectName
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DebugMarkerObjectNameInfo Pack()
		{
			Interop.DebugMarkerObjectNameInfo result = default(Interop.DebugMarkerObjectNameInfo);
			result.SType = StructureType.DebugMarkerObjectNameInfo;
			result.ObjectName = Interop.HeapUtil.MarshalTo(this.ObjectName);
			result.ObjectType = this.ObjectType;
			result.Object = this.Object;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DebugMarkerObjectNameInfo* MarshalTo()
		{
			return (Interop.DebugMarkerObjectNameInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct DebugMarkerObjectTagInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public DebugReportObjectType ObjectType
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong Object
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong TagName
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public byte[] Tag
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DebugMarkerObjectTagInfo Pack()
		{
			Interop.DebugMarkerObjectTagInfo result = default(Interop.DebugMarkerObjectTagInfo);
			result.SType = StructureType.DebugMarkerObjectTagInfo;
			result.Tag = this.Tag == null ? null : Interop.HeapUtil.MarshalTo(this.Tag);
			result.TagSize = (Size)(this.Tag?.Length ?? 0);
			result.ObjectType = this.ObjectType;
			result.Object = this.Object;
			result.TagName = this.TagName;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DebugMarkerObjectTagInfo* MarshalTo()
		{
			return (Interop.DebugMarkerObjectTagInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct DebugReportCallbackCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public DebugReportFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Interop.DebugReportCallbackDelegate PfnCallback
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr UserData
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DebugReportCallbackCreateInfo Pack()
		{
			Interop.DebugReportCallbackCreateInfo result = default(Interop.DebugReportCallbackCreateInfo);
			result.SType = StructureType.DebugReportCallbackCreateInfo;
			result.PfnCallback = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnCallback);
			result.UserData = this.UserData.ToPointer();
			result.Flags = this.Flags;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DebugReportCallbackCreateInfo* MarshalTo()
		{
			return (Interop.DebugReportCallbackCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Specify that a buffer is bound to a dedicated memory resource.
    /// </para>
    /// <para>
    /// If the pname:pNext list includes a sname:VkDedicatedAllocationBufferCreateInfoNV structure, then that structure includes an enable controlling whether the buffer will have a dedicated memory allocation bound to it.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:dedicatedAllocation is ename:VK_TRUE, sname:VkBufferCreateInfo::pname:flags must: not include ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT, ename:VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT, or ename:VK_BUFFER_CREATE_SPARSE_ALIASED_BIT ****
    /// </para>
    /// </summary>
	public struct DedicatedAllocationBufferCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DedicatedAllocation
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DedicatedAllocationBufferCreateInfo Pack()
		{
			Interop.DedicatedAllocationBufferCreateInfo result = default(Interop.DedicatedAllocationBufferCreateInfo);
			result.SType = StructureType.DedicatedAllocationBufferCreateInfo;
			result.DedicatedAllocation = this.DedicatedAllocation;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DedicatedAllocationBufferCreateInfo* MarshalTo()
		{
			return (Interop.DedicatedAllocationBufferCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Specify that an image is bound to a dedicated memory resource.
    /// </para>
    /// <para>
    /// If the pname:pNext list includes a sname:VkDedicatedAllocationImageCreateInfoNV structure, then that structure includes an enable controlling whether the image will have a dedicated memory allocation bound to it.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Using a dedicated allocation for color and depth/stencil attachments or other large images may: improve performance on some devices. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:dedicatedAllocation is ename:VK_TRUE, sname:VkImageCreateInfo::pname:flags must: not include ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT, ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT, or ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT ****
    /// </para>
    /// </summary>
	public struct DedicatedAllocationImageCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DedicatedAllocation
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DedicatedAllocationImageCreateInfo Pack()
		{
			Interop.DedicatedAllocationImageCreateInfo result = default(Interop.DedicatedAllocationImageCreateInfo);
			result.SType = StructureType.DedicatedAllocationImageCreateInfo;
			result.DedicatedAllocation = this.DedicatedAllocation;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DedicatedAllocationImageCreateInfo* MarshalTo()
		{
			return (Interop.DedicatedAllocationImageCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Specify a dedicated memory allocation resource.
    /// </para>
    /// <para>
    /// If the pname:pNext list includes a sname:VkDedicatedAllocationMemoryAllocateInfoNV structure, then that structure includes a handle of the sole buffer or image resource that the memory can: be bound to.
    /// </para>
    /// <para>
    /// .Valid Usage **** * At least one of pname:image and pname:buffer must: be sname:VK_NULL_HANDLE * If pname:image is not sname:VK_NULL_HANDLE, the image must: have been created with sname:VkDedicatedAllocationImageCreateInfoNV::pname:dedicatedAllocation equal to ename:VK_TRUE * If pname:buffer is not sname:VK_NULL_HANDLE, the buffer must: have been created with sname:VkDedicatedAllocationBufferCreateInfoNV::pname:dedicatedAllocation equal to ename:VK_TRUE * If pname:image is not sname:VK_NULL_HANDLE, sname:VkMemoryAllocateInfo::pname:allocationSize must: equal the sname:VkMemoryRequirements::pname:size of the image * If pname:buffer is not sname:VK_NULL_HANDLE, sname:VkMemoryAllocateInfo::pname:allocationSize must: equal the sname:VkMemoryRequirements::pname:size of the buffer ****
    /// </para>
    /// </summary>
	public struct DedicatedAllocationMemoryAllocateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Image Image
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Buffer Buffer
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DedicatedAllocationMemoryAllocateInfo Pack()
		{
			Interop.DedicatedAllocationMemoryAllocateInfo result = default(Interop.DedicatedAllocationMemoryAllocateInfo);
			result.SType = StructureType.DedicatedAllocationMemoryAllocateInfo;
			result.Image = this.Image?.Pack() ?? Interop.Image.Null;
			result.Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DedicatedAllocationMemoryAllocateInfo* MarshalTo()
		{
			return (Interop.DedicatedAllocationMemoryAllocateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying descriptor buffer info.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:offset must: be less than the size of pname:buffer * If pname:range is not equal to ename:VK_WHOLE_SIZE, pname:range must: be greater than `0` * If pname:range is not equal to ename:VK_WHOLE_SIZE, pname:range must: be less than or equal to the size of pname:buffer minus pname:offset ****
    /// </para>
    /// </summary>
	public struct DescriptorBufferInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Buffer Buffer
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong Offset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong Range
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DescriptorBufferInfo Pack()
		{
			Interop.DescriptorBufferInfo result = default(Interop.DescriptorBufferInfo);
			result.Buffer = this.Buffer?.Pack() ?? Interop.Buffer.Null;
			result.Offset = this.Offset;
			result.Range = this.Range;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DescriptorBufferInfo* MarshalTo()
		{
			return (Interop.DescriptorBufferInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct DescriptorImageInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Sampler Sampler
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageView ImageView
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageLayout ImageLayout
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DescriptorImageInfo Pack()
		{
			Interop.DescriptorImageInfo result = default(Interop.DescriptorImageInfo);
			result.Sampler = this.Sampler?.Pack() ?? Interop.Sampler.Null;
			result.ImageView = this.ImageView?.Pack() ?? Interop.ImageView.Null;
			result.ImageLayout = this.ImageLayout;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DescriptorImageInfo* MarshalTo()
		{
			return (Interop.DescriptorImageInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct DescriptorPoolCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public DescriptorPoolCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxSets
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DescriptorPoolSize[] PoolSizes
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DescriptorPoolCreateInfo Pack()
		{
			Interop.DescriptorPoolCreateInfo result = default(Interop.DescriptorPoolCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DescriptorPoolCreateInfo* MarshalTo()
		{
			return (Interop.DescriptorPoolCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying the allocation parameters for descriptor sets.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:descriptorSetCount must: not be greater than the number of sets that are currently available for allocation in pname:descriptorPool * pname:descriptorPool must: have enough free descriptor capacity remaining to allocate the descriptor sets of the specified layouts ****
    /// </para>
    /// </summary>
	public struct DescriptorSetAllocateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public DescriptorPool DescriptorPool
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSetLayout[] SetLayouts
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DescriptorSetAllocateInfo Pack()
		{
			Interop.DescriptorSetAllocateInfo result = default(Interop.DescriptorSetAllocateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DescriptorSetAllocateInfo* MarshalTo()
		{
			return (Interop.DescriptorSetAllocateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying a descriptor set layout binding.
    /// </para>
    /// <para>
    /// The above layout definition allows the descriptor bindings to be specified sparsely such that not all binding numbers between 0 and the maximum binding number need to be specified in the pname:pBindings array. However, all binding numbers between 0 and the maximum binding number may: consume memory in the descriptor set layout even if not all descriptor bindings are used, though it should: not consume additional memory from the descriptor pool.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== The maximum binding number specified should: be as compact as possible to avoid wasted memory. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_SAMPLER or ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and pname:descriptorCount is not `0` and pname:pImmutableSamplers is not `NULL`, pname:pImmutableSamplers must: be a pointer to an array of pname:descriptorCount valid sname:VkSampler handles * If pname:descriptorCount is not `0`, pname:stageFlags must: be a valid combination of elink:VkShaderStageFlagBits values ****
    /// </para>
    /// </summary>
	public struct DescriptorSetLayoutBinding
	{
		/// <summary>
		/// -
		/// </summary>
		public uint Binding
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DescriptorType DescriptorType
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint DescriptorCount
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ShaderStageFlags StageFlags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Sampler[] ImmutableSamplers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DescriptorSetLayoutBinding Pack()
		{
			Interop.DescriptorSetLayoutBinding result = default(Interop.DescriptorSetLayoutBinding);
			
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
			result.DescriptorCount = (uint)(this.ImmutableSamplers?.Length ?? (int)this.DescriptorCount);
			result.Binding = this.Binding;
			result.DescriptorType = this.DescriptorType;
			result.DescriptorCount = this.DescriptorCount;
			result.StageFlags = this.StageFlags;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DescriptorSetLayoutBinding* MarshalTo()
		{
			return (Interop.DescriptorSetLayoutBinding*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct DescriptorSetLayoutCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSetLayoutCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSetLayoutBinding[] Bindings
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DescriptorSetLayoutCreateInfo Pack()
		{
			Interop.DescriptorSetLayoutCreateInfo result = default(Interop.DescriptorSetLayoutCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DescriptorSetLayoutCreateInfo* MarshalTo()
		{
			return (Interop.DescriptorSetLayoutCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created device.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The pname:queueFamilyIndex member of any given element of pname:pQueueCreateInfos must: be unique within pname:pQueueCreateInfos ****
    /// </para>
    /// </summary>
	public struct DeviceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public DeviceCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DeviceQueueCreateInfo[] QueueCreateInfos
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public string[] EnabledLayerNames
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public string[] EnabledExtensionNames
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PhysicalDeviceFeatures EnabledFeatures
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DeviceCreateInfo Pack()
		{
			Interop.DeviceCreateInfo result = default(Interop.DeviceCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DeviceCreateInfo* MarshalTo()
		{
			return (Interop.DeviceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created device queue.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:queueFamilyIndex must: be less than pname:pQueueFamilyPropertyCount returned by fname:vkGetPhysicalDeviceQueueFamilyProperties * pname:queueCount must: be less than or equal to the pname:queueCount member of the sname:VkQueueFamilyProperties structure, as returned by fname:vkGetPhysicalDeviceQueueFamilyProperties in the pname:pQueueFamilyProperties[pname:queueFamilyIndex] * Each element of pname:pQueuePriorities must: be between `0.0` and `1.0` inclusive ****
    /// </para>
    /// </summary>
	public struct DeviceQueueCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public DeviceQueueCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint QueueFamilyIndex
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float[] QueuePriorities
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DeviceQueueCreateInfo Pack()
		{
			Interop.DeviceQueueCreateInfo result = default(Interop.DeviceQueueCreateInfo);
			result.SType = StructureType.DeviceQueueCreateInfo;
			result.QueuePriorities = this.QueuePriorities == null ? null : Interop.HeapUtil.MarshalTo(this.QueuePriorities);
			result.QueueCount = (uint)(this.QueuePriorities?.Length ?? 0);
			result.Flags = this.Flags;
			result.QueueFamilyIndex = this.QueueFamilyIndex;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DeviceQueueCreateInfo* MarshalTo()
		{
			return (Interop.DeviceQueueCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created display mode object.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The pname:width and pname:height members of the pname:visibleRegion member of pname:parameters must: be greater than `0` * The pname:refreshRate member of pname:parameters must: be greater than `0` ****
    /// </para>
    /// </summary>
	public struct DisplayModeCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public DisplayModeCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DisplayModeParameters Parameters
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DisplayModeCreateInfo Pack()
		{
			Interop.DisplayModeCreateInfo result = default(Interop.DisplayModeCreateInfo);
			result.SType = StructureType.DisplayModeCreateInfo;
			result.Flags = this.Flags;
			result.Parameters = this.Parameters;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DisplayModeCreateInfo* MarshalTo()
		{
			return (Interop.DisplayModeCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct DisplayModeProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public DisplayMode DisplayMode
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DisplayModeParameters Parameters
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal static unsafe DisplayModeProperties MarshalFrom(Interop.DisplayModeProperties* value)
		{
			DisplayModeProperties result = new DisplayModeProperties();
			result.Parameters = value->Parameters;
			return result;
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct DisplayPlaneProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public Display CurrentDisplay
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint CurrentStackIndex
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal static unsafe DisplayPlaneProperties MarshalFrom(Interop.DisplayPlaneProperties* value)
		{
			DisplayPlaneProperties result = new DisplayPlaneProperties();
			result.CurrentStackIndex = value->CurrentStackIndex;
			return result;
		}
	}

    /// <summary>
    /// <para>
    /// Structure describing parameters of a queue presentation to a swapchain.
    /// </para>
    /// <para>
    /// If the extent of the pname:srcRect and pname:dstRect are not equal, the presented pixels will be scaled accordingly.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:srcRect must: specify a rectangular region that is a subset of the image being presented * pname:dstRect must: specify a rectangular region that is a subset of the pname:visibleRegion parameter of the display mode the swapchain being presented uses * If the pname:persistentContent member of the sname:VkDisplayPropertiesKHR structure returned by fname:vkGetPhysicalDeviceDisplayPropertiesKHR for the display the present operation targets then pname:persistent must: be ename:VK_FALSE ****
    /// </para>
    /// </summary>
	public struct DisplayPresentInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Rect2D SourceRect
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Rect2D DestinationRect
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 Persistent
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DisplayPresentInfo Pack()
		{
			Interop.DisplayPresentInfo result = default(Interop.DisplayPresentInfo);
			result.SType = StructureType.DisplayPresentInfo;
			result.SourceRect = this.SourceRect;
			result.DestinationRect = this.DestinationRect;
			result.Persistent = this.Persistent;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DisplayPresentInfo* MarshalTo()
		{
			return (Interop.DisplayPresentInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct DisplayProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public Display Display
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public string DisplayName
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Extent2D PhysicalDimensions
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Extent2D PhysicalResolution
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SurfaceTransformFlags SupportedTransforms
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 PlaneReorderPossible
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 PersistentContent
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal static unsafe DisplayProperties MarshalFrom(Interop.DisplayProperties* value)
		{
			DisplayProperties result = new DisplayProperties();
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
    /// <para>
    /// Structure specifying parameters of a newly created display plane surface object.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Creating a display surface must: not modify the state of the displays, planes, or other resources it names. For example, it must: not apply the specified mode to be set on the associated display. Application of display configuration occurs as a side effect of presenting to a display surface. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:planeIndex must: be less than the number of display planes supported by the device as determined by calling fname:vkGetPhysicalDeviceDisplayPlanePropertiesKHR * If the pname:planeReorderPossible member of the sname:VkDisplayPropertiesKHR structure returned by fname:vkGetPhysicalDeviceDisplayPropertiesKHR for the display corresponding to pname:displayMode is ename:VK_TRUE then pname:planeStackIndex must: be less than the number of display planes supported by the device as determined by calling fname:vkGetPhysicalDeviceDisplayPlanePropertiesKHR; otherwise pname:planeStackIndex must: equal the pname:currentStackIndex member of sname:VkDisplayPlanePropertiesKHR returned by fname:vkGetPhysicalDeviceDisplayPlanePropertiesKHR for the display plane corresponding to pname:displayMode * If pname:alphaMode is ename:VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR then pname:globalAlpha must: be between `0` and `1`, inclusive * pname:alphaMode must: be `0` or one of the bits present in the pname:supportedAlpha member of sname:VkDisplayPlaneCapabilitiesKHR returned by fname:vkGetDisplayPlaneCapabilitiesKHR for the display plane corresponding to pname:displayMode * The pname:width and pname:height members of pname:imageExtent must: be less than the pname:maxImageDimensions2D member of sname:VkPhysicalDeviceLimits ****
    /// </para>
    /// </summary>
	public struct DisplaySurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public DisplaySurfaceCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DisplayMode DisplayMode
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint PlaneIndex
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint PlaneStackIndex
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SurfaceTransformFlags Transform
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float GlobalAlpha
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DisplayPlaneAlphaFlags AlphaMode
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Extent2D ImageExtent
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DisplaySurfaceCreateInfo Pack()
		{
			Interop.DisplaySurfaceCreateInfo result = default(Interop.DisplaySurfaceCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.DisplaySurfaceCreateInfo* MarshalTo()
		{
			return (Interop.DisplaySurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct EventCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public EventCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.EventCreateInfo Pack()
		{
			Interop.EventCreateInfo result = default(Interop.EventCreateInfo);
			result.SType = StructureType.EventCreateInfo;
			result.Flags = this.Flags;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.EventCreateInfo* MarshalTo()
		{
			return (Interop.EventCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct ExportMemoryAllocateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public ExternalMemoryHandleTypeFlags HandleTypes
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ExportMemoryAllocateInfo Pack()
		{
			Interop.ExportMemoryAllocateInfo result = default(Interop.ExportMemoryAllocateInfo);
			result.SType = StructureType.ExportMemoryAllocateInfo;
			result.HandleTypes = this.HandleTypes;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ExportMemoryAllocateInfo* MarshalTo()
		{
			return (Interop.ExportMemoryAllocateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct ExportMemoryWin32HandleInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public SECURITY_ATTRIBUTES Attributes
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint DwAccess
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ExportMemoryWin32HandleInfo Pack()
		{
			Interop.ExportMemoryWin32HandleInfo result = default(Interop.ExportMemoryWin32HandleInfo);
			result.SType = StructureType.ExportMemoryWin32HandleInfo;
			result.Attributes = (SECURITY_ATTRIBUTES*)Interop.HeapUtil.AllocateAndMarshal(this.Attributes);
			result.DwAccess = this.DwAccess;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ExportMemoryWin32HandleInfo* MarshalTo()
		{
			return (Interop.ExportMemoryWin32HandleInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct ExtensionProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public string ExtensionName
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Version SpecVersion
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal static unsafe ExtensionProperties MarshalFrom(Interop.ExtensionProperties* value)
		{
			ExtensionProperties result = new ExtensionProperties();
			result.ExtensionName = System.Text.Encoding.UTF8.GetString(Interop.HeapUtil.MarshalFrom(value->ExtensionName, (int)Constants.MaxExtensionNameSize, true));
			result.SpecVersion = value->SpecVersion;
			return result;
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct ExternalMemoryImageCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public ExternalMemoryHandleTypeFlags HandleTypes
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ExternalMemoryImageCreateInfo Pack()
		{
			Interop.ExternalMemoryImageCreateInfo result = default(Interop.ExternalMemoryImageCreateInfo);
			result.SType = StructureType.ExternalMemoryImageCreateInfo;
			result.HandleTypes = this.HandleTypes;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ExternalMemoryImageCreateInfo* MarshalTo()
		{
			return (Interop.ExternalMemoryImageCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct FenceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public FenceCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.FenceCreateInfo Pack()
		{
			Interop.FenceCreateInfo result = default(Interop.FenceCreateInfo);
			result.SType = StructureType.FenceCreateInfo;
			result.Flags = this.Flags;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.FenceCreateInfo* MarshalTo()
		{
			return (Interop.FenceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created framebuffer.
    /// </para>
    /// <para>
    /// Image subresources used as attachments must: not be used via any non-attachment usage for the duration of a render pass instance.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== This restriction means that the render pass has full knowledge of all uses of all of the attachments, so that the implementation is able to make correct decisions about when and how to perform layout transitions, when to overlap execution of subpasses, etc. ====
    /// </para>
    /// <para>
    /// It is legal for a subpass to use no color or depth/stencil attachments, and rather use shader side effects such as image stores and atomics to produce an output. In this case, the subpass continues to use the pname:width, pname:height, and pname:layers of the framebuffer to define the dimensions of the rendering area, and the pname:rasterizationSamples from each pipeline's slink:VkPipelineMultisampleStateCreateInfo to define the number of samples used in rasterization; however, if slink:VkPhysicalDeviceFeatures::pname:variableMultisampleRate is code:VK_FALSE, then all pipelines to be bound with a given zero-attachment subpass must: have the same value for slink:VkPipelineMultisampleStateCreateInfo::pname:rasterizationSamples.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:attachmentCount must: be equal to the attachment count specified in pname:renderPass * Any given element of pname:pAttachments that is used as a color attachment or resolve attachment by pname:renderPass must: have been created with a pname:usage value including ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT * Any given element of pname:pAttachments that is used as a depth/stencil attachment by pname:renderPass must: have been created with a pname:usage value including ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT * Any given element of pname:pAttachments that is used as an input attachment by pname:renderPass must: have been created with a pname:usage value including ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT * Any given element of pname:pAttachments must: have been created with an elink:VkFormat value that matches the elink:VkFormat specified by the corresponding sname:VkAttachmentDescription in pname:renderPass * Any given element of pname:pAttachments must: have been created with a pname:samples value that matches the pname:samples value specified by the corresponding sname:VkAttachmentDescription in pname:renderPass * Any given element of pname:pAttachments must: have dimensions at least as large as the corresponding framebuffer dimension * Any given element of pname:pAttachments must: only specify a single mip level * Any given element of pname:pAttachments must: have been created with the identity swizzle * pname:width must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxFramebufferWidth * pname:height must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxFramebufferHeight * pname:layers must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxFramebufferLayers ****
    /// </para>
    /// </summary>
	public struct FramebufferCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public FramebufferCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public RenderPass RenderPass
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageView[] Attachments
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint Width
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint Height
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint Layers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.FramebufferCreateInfo Pack()
		{
			Interop.FramebufferCreateInfo result = default(Interop.FramebufferCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.FramebufferCreateInfo* MarshalTo()
		{
			return (Interop.FramebufferCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct GraphicsPipelineCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineShaderStageCreateInfo[] Stages
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineVertexInputStateCreateInfo? VertexInputState
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineInputAssemblyStateCreateInfo? InputAssemblyState
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineTessellationStateCreateInfo? TessellationState
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineViewportStateCreateInfo? ViewportState
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineRasterizationStateCreateInfo? RasterizationState
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineMultisampleStateCreateInfo? MultisampleState
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineDepthStencilStateCreateInfo? DepthStencilState
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineColorBlendStateCreateInfo? ColorBlendState
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineDynamicStateCreateInfo? DynamicState
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineLayout Layout
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public RenderPass RenderPass
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint Subpass
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Pipeline BasePipelineHandle
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public int BasePipelineIndex
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.GraphicsPipelineCreateInfo Pack()
		{
			Interop.GraphicsPipelineCreateInfo result = default(Interop.GraphicsPipelineCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.GraphicsPipelineCreateInfo* MarshalTo()
		{
			return (Interop.GraphicsPipelineCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying an image blit operation.
    /// </para>
    /// <para>
    /// For each element of the pname:pRegions array, a blit operation is performed the specified source and destination regions.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The pname:aspectMask member of pname:srcSubresource and pname:dstSubresource must: match * The pname:layerCount member of pname:srcSubresource and pname:dstSubresource must: match * If either of the calling command's pname:srcImage or pname:dstImage parameters are of elink:VkImageType ename:VK_IMAGE_TYPE_3D, the pname:baseArrayLayer and pname:layerCount members of both pname:srcSubresource and pname:dstSubresource must: be `0` and `1`, respectively * The pname:aspectMask member of pname:srcSubresource must: specify aspects present in the calling command's pname:srcImage * The pname:aspectMask member of pname:dstSubresource must: specify aspects present in the calling command's pname:dstImage * The pname:layerCount member of pname:dstSubresource must: be equal to the pname:layerCount member of pname:srcSubresource * pname:srcOffset[0].pname:x and pname:srcOffset[1].pname:x must: both be greater than or equal to `0` and less than or equal to the source image subresource width * pname:srcOffset[0].pname:y and pname:srcOffset[1].pname:y must: both be greater than or equal to `0` and less than or equal to the source image subresource height * pname:srcOffset[0].pname:z and pname:srcOffset[1].pname:z must: both be greater than or equal to `0` and less than or equal to the source image subresource depth * pname:dstOffset[0].pname:x and pname:dstOffset[1].pname:x must: both be greater than or equal to `0` and less than or equal to the destination image subresource width * pname:dstOffset[0].pname:y and pname:dstOffset[1].pname:y must: both be greater than or equal to `0` and less than or equal to the destination image subresource height * pname:dstOffset[0].pname:z and pname:dstOffset[1].pname:z must: both be greater than or equal to `0` and less than or equal to the destination image subresource depth ****
    /// </para>
    /// </summary>
	public struct ImageBlit
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceLayers SourceSubresource
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Offset3D[] SourceOffsets
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceLayers DestinationSubresource
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Offset3D[] DestinationOffsets
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ImageBlit Pack()
		{
			Interop.ImageBlit result = default(Interop.ImageBlit);
			result.SourceSubresource = this.SourceSubresource;
			result.DestinationSubresource = this.DestinationSubresource;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ImageBlit* MarshalTo()
		{
			return (Interop.ImageBlit*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying the parameters of a newly created image object.
    /// </para>
    /// <para>
    /// Valid limits for the image pname:extent, pname:mipLevels, pname:arrayLayers and pname:samples members are queried with the flink:vkGetPhysicalDeviceImageFormatProperties command.
    /// </para>
    /// <para>
    /// Images created with pname:tiling equal to ename:VK_IMAGE_TILING_LINEAR have further restrictions on their limits and capabilities compared to images created with pname:tiling equal to ename:VK_IMAGE_TILING_OPTIMAL. Creation of images with tiling ename:VK_IMAGE_TILING_LINEAR may: not be supported unless other parameters meet all of the constraints:
    /// </para>
    /// <para>
    /// * pname:imageType is ename:VK_IMAGE_TYPE_2D * pname:format is not a depth/stencil format * pname:mipLevels is 1 * pname:arrayLayers is 1 * pname:samples is ename:VK_SAMPLE_COUNT_1_BIT * pname:usage only includes ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT and/or ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT
    /// </para>
    /// <para>
    /// Implementations may: support additional limits and capabilities beyond those listed above. To determine the specific capabilities of an implementation, query the valid pname:usage bits by calling flink:vkGetPhysicalDeviceFormatProperties and the valid limits for pname:mipLevels and pname:arrayLayers by calling flink:vkGetPhysicalDeviceImageFormatProperties.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:sharingMode is ename:VK_SHARING_MODE_CONCURRENT, pname:pQueueFamilyIndices must: be a pointer to an array of pname:queueFamilyIndexCount basetype:uint32_t values * If pname:sharingMode is ename:VK_SHARING_MODE_CONCURRENT, pname:queueFamilyIndexCount must: be greater than `1` * pname:format must: not be ename:VK_FORMAT_UNDEFINED * The pname:width, pname:height, and pname:depth members of pname:extent must: all be greater than `0` * pname:mipLevels must: be greater than `0` * pname:arrayLayers must: be greater than `0` * If pname:flags contains ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:imageType must be ename:VK_IMAGE_TYPE_2D * If pname:imageType is ename:VK_IMAGE_TYPE_1D, pname:extent.width must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxImageDimension1D, or sname:VkImageFormatProperties::pname:maxExtent.width (as returned by fname:vkGetPhysicalDeviceImageFormatProperties with pname:format, pname:type, pname:tiling, pname:usage, and pname:flags equal to those in this structure) - whichever is higher * If pname:imageType is ename:VK_IMAGE_TYPE_2D and pname:flags does not contain ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:extent.width and pname:extent.height must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxImageDimension2D, or sname:VkImageFormatProperties::pname:maxExtent.width/height (as returned by fname:vkGetPhysicalDeviceImageFormatProperties with pname:format, pname:type, pname:tiling, pname:usage, and pname:flags equal to those in this structure) - whichever is higher * If pname:imageType is ename:VK_IMAGE_TYPE_2D and pname:flags contains ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:extent.width and pname:extent.height must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxImageDimensionCube, or sname:VkImageFormatProperties::pname:maxExtent.width/height (as returned by fname:vkGetPhysicalDeviceImageFormatProperties with pname:format, pname:type, pname:tiling, pname:usage, and pname:flags equal to those in this structure) - whichever is higher * If pname:imageType is ename:VK_IMAGE_TYPE_2D and pname:flags contains ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:extent.width and pname:extent.height must: be equal and pname:arrayLayers must: be greater than or equal to 6 * If pname:imageType is ename:VK_IMAGE_TYPE_3D, pname:extent.width, pname:extent.height and pname:extent.depth must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxImageDimension3D, or sname:VkImageFormatProperties::pname:maxExtent.width/height/depth (as returned by fname:vkGetPhysicalDeviceImageFormatProperties with pname:format, pname:type, pname:tiling, pname:usage, and pname:flags equal to those in this structure) - whichever is higher * If pname:imageType is ename:VK_IMAGE_TYPE_1D, both pname:extent.height and pname:extent.depth must: be `1` * If pname:imageType is ename:VK_IMAGE_TYPE_2D, pname:extent.depth must: be `1` * pname:mipLevels must: be less than or equal to [eq]#{lfloor}log~2~(max(pname:extent.width, pname:extent.height, pname:extent.depth)){rfloor} + 1#. * If any of pname:extent.width, pname:extent.height, or pname:extent.depth are greater than the equivalently named members of sname:VkPhysicalDeviceLimits::pname:maxImageDimension3D, pname:mipLevels must: be less than or equal to sname:VkImageFormatProperties::pname:maxMipLevels (as returned by fname:vkGetPhysicalDeviceImageFormatProperties with pname:format, pname:type, pname:tiling, pname:usage, and pname:flags equal to those in this structure) * pname:arrayLayers must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxImageArrayLayers, or sname:VkImageFormatProperties::pname:maxArrayLayers (as returned by fname:vkGetPhysicalDeviceImageFormatProperties with pname:format, pname:type, pname:tiling, pname:usage, and pname:flags equal to those in this structure) - whichever is higher * If pname:samples is not ename:VK_SAMPLE_COUNT_1_BIT, pname:imageType must: be ename:VK_IMAGE_TYPE_2D, pname:flags must: not contain ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:tiling must: be ename:VK_IMAGE_TILING_OPTIMAL, and pname:mipLevels must: be equal to `1` * If pname:usage includes ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT, then bits other than ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT, ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, and ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT must: not be set * If pname:usage includes ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT, ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT, or ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT, pname:extent.width must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxFramebufferWidth * If pname:usage includes ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT, ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT, or ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT, pname:extent.height must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxFramebufferHeight * pname:samples must: be a bit value that is set in sname:VkImageFormatProperties::pname:sampleCounts returned by fname:vkGetPhysicalDeviceImageFormatProperties with pname:format, pname:type, pname:tiling, pname:usage, and pname:flags equal to those in this structure * If the &lt;&lt;features-features-textureCompressionETC2,ETC2 texture compression&gt;&gt; feature is not enabled, pname:format must: not be ename:VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK, ename:VK_FORMAT_EAC_R11_UNORM_BLOCK, ename:VK_FORMAT_EAC_R11_SNORM_BLOCK, ename:VK_FORMAT_EAC_R11G11_UNORM_BLOCK, or ename:VK_FORMAT_EAC_R11G11_SNORM_BLOCK * If the &lt;&lt;features-features-textureCompressionASTC_LDR,ASTC LDR texture compression&gt;&gt; feature is not enabled, pname:format must: not be ename:VK_FORMAT_ASTC_4x4_UNORM_BLOCK, ename:VK_FORMAT_ASTC_4x4_SRGB_BLOCK, ename:VK_FORMAT_ASTC_5x4_UNORM_BLOCK, ename:VK_FORMAT_ASTC_5x4_SRGB_BLOCK, ename:VK_FORMAT_ASTC_5x5_UNORM_BLOCK, ename:VK_FORMAT_ASTC_5x5_SRGB_BLOCK, ename:VK_FORMAT_ASTC_6x5_UNORM_BLOCK, ename:VK_FORMAT_ASTC_6x5_SRGB_BLOCK, ename:VK_FORMAT_ASTC_6x6_UNORM_BLOCK, ename:VK_FORMAT_ASTC_6x6_SRGB_BLOCK, ename:VK_FORMAT_ASTC_8x5_UNORM_BLOCK, ename:VK_FORMAT_ASTC_8x5_SRGB_BLOCK, ename:VK_FORMAT_ASTC_8x6_UNORM_BLOCK, ename:VK_FORMAT_ASTC_8x6_SRGB_BLOCK, ename:VK_FORMAT_ASTC_8x8_UNORM_BLOCK, ename:VK_FORMAT_ASTC_8x8_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x5_UNORM_BLOCK, ename:VK_FORMAT_ASTC_10x5_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x6_UNORM_BLOCK, ename:VK_FORMAT_ASTC_10x6_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x8_UNORM_BLOCK, ename:VK_FORMAT_ASTC_10x8_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x10_UNORM_BLOCK, ename:VK_FORMAT_ASTC_10x10_SRGB_BLOCK, ename:VK_FORMAT_ASTC_12x10_UNORM_BLOCK, ename:VK_FORMAT_ASTC_12x10_SRGB_BLOCK, ename:VK_FORMAT_ASTC_12x12_UNORM_BLOCK, or ename:VK_FORMAT_ASTC_12x12_SRGB_BLOCK * If the &lt;&lt;features-features-textureCompressionBC,BC texture compression&gt;&gt; feature is not enabled, pname:format must: not be ename:VK_FORMAT_BC1_RGB_UNORM_BLOCK, ename:VK_FORMAT_BC1_RGB_SRGB_BLOCK, ename:VK_FORMAT_BC1_RGBA_UNORM_BLOCK, ename:VK_FORMAT_BC1_RGBA_SRGB_BLOCK, ename:VK_FORMAT_BC2_UNORM_BLOCK, ename:VK_FORMAT_BC2_SRGB_BLOCK, ename:VK_FORMAT_BC3_UNORM_BLOCK, ename:VK_FORMAT_BC3_SRGB_BLOCK, ename:VK_FORMAT_BC4_UNORM_BLOCK, ename:VK_FORMAT_BC4_SNORM_BLOCK, ename:VK_FORMAT_BC5_UNORM_BLOCK, ename:VK_FORMAT_BC5_SNORM_BLOCK, ename:VK_FORMAT_BC6H_UFLOAT_BLOCK, ename:VK_FORMAT_BC6H_SFLOAT_BLOCK, ename:VK_FORMAT_BC7_UNORM_BLOCK, or ename:VK_FORMAT_BC7_SRGB_BLOCK * If the &lt;&lt;features-features-shaderStorageImageMultisample,multisampled storage images&gt;&gt; feature is not enabled, and pname:usage contains ename:VK_IMAGE_USAGE_STORAGE_BIT, pname:samples must: be ename:VK_SAMPLE_COUNT_1_BIT * If the &lt;&lt;features-features-sparseBinding,sparse bindings&gt;&gt; feature is not enabled, pname:flags must: not contain ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT * If the &lt;&lt;features-features-sparseResidencyImage2D,sparse residency for 2D images&gt;&gt; feature is not enabled, and pname:imageType is ename:VK_IMAGE_TYPE_2D, pname:flags must: not contain ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the &lt;&lt;features-features-sparseResidencyImage3D,sparse residency for 3D images&gt;&gt; feature is not enabled, and pname:imageType is ename:VK_IMAGE_TYPE_3D, pname:flags must: not contain ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the &lt;&lt;features-features-sparseResidency2Samples,sparse residency for images with 2 samples&gt;&gt; feature is not enabled, pname:imageType is ename:VK_IMAGE_TYPE_2D, and pname:samples is ename:VK_SAMPLE_COUNT_2_BIT, pname:flags must: not contain ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the &lt;&lt;features-features-sparseResidency4Samples,sparse residency for images with 4 samples&gt;&gt; feature is not enabled, pname:imageType is ename:VK_IMAGE_TYPE_2D, and pname:samples is ename:VK_SAMPLE_COUNT_4_BIT, pname:flags must: not contain ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the &lt;&lt;features-features-sparseResidency8Samples,sparse residency for images with 8 samples&gt;&gt; feature is not enabled, pname:imageType is ename:VK_IMAGE_TYPE_2D, and pname:samples is ename:VK_SAMPLE_COUNT_8_BIT, pname:flags must: not contain ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the &lt;&lt;features-features-sparseResidency16Samples,sparse residency for images with 16 samples&gt;&gt; feature is not enabled, pname:imageType is ename:VK_IMAGE_TYPE_2D, and pname:samples is ename:VK_SAMPLE_COUNT_16_BIT, pname:flags must: not contain ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If pname:tiling is ename:VK_IMAGE_TILING_LINEAR, pname:format must: be a format that has at least one supported feature bit present in the value of sname:VkFormatProperties::pname:linearTilingFeatures returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format * If pname:tiling is ename:VK_IMAGE_TILING_LINEAR, and sname:VkFormatProperties::pname:linearTilingFeatures (as returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format) does not include ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT, pname:usage must: not contain ename:VK_IMAGE_USAGE_SAMPLED_BIT * If pname:tiling is ename:VK_IMAGE_TILING_LINEAR, and sname:VkFormatProperties::pname:linearTilingFeatures (as returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format) does not include ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT, pname:usage must: not contain ename:VK_IMAGE_USAGE_STORAGE_BIT * If pname:tiling is ename:VK_IMAGE_TILING_LINEAR, and sname:VkFormatProperties::pname:linearTilingFeatures (as returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format) does not include ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT, pname:usage must: not contain ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT * If pname:tiling is ename:VK_IMAGE_TILING_LINEAR, and sname:VkFormatProperties::pname:linearTilingFeatures (as returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format) does not include ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT, pname:usage must: not contain ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT * If pname:tiling is ename:VK_IMAGE_TILING_OPTIMAL, pname:format must: be a format that has at least one supported feature bit present in the value of sname:VkFormatProperties::pname:optimalTilingFeatures returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format * If pname:tiling is ename:VK_IMAGE_TILING_OPTIMAL, and sname:VkFormatProperties::pname:optimalTilingFeatures (as returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format) does not include ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT, pname:usage must: not contain ename:VK_IMAGE_USAGE_SAMPLED_BIT * If pname:tiling is ename:VK_IMAGE_TILING_OPTIMAL, and sname:VkFormatProperties::pname:optimalTilingFeatures (as returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format) does not include ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT, pname:usage must: not contain ename:VK_IMAGE_USAGE_STORAGE_BIT * If pname:tiling is ename:VK_IMAGE_TILING_OPTIMAL, and sname:VkFormatProperties::pname:optimalTilingFeatures (as returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format) does not include ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT, pname:usage must: not contain ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT * If pname:tiling is ename:VK_IMAGE_TILING_OPTIMAL, and sname:VkFormatProperties::pname:optimalTilingFeatures (as returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format) does not include ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT, pname:usage must: not contain ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT * If pname:flags contains ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT or ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT, it must: also contain ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT ****
    /// </para>
    /// </summary>
	public struct ImageCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageType ImageType
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Format Format
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Extent3D Extent
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MipLevels
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint ArrayLayers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags Samples
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageTiling Tiling
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageUsageFlags Usage
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SharingMode SharingMode
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint[] QueueFamilyIndices
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageLayout InitialLayout
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ImageCreateInfo Pack()
		{
			Interop.ImageCreateInfo result = default(Interop.ImageCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ImageCreateInfo* MarshalTo()
		{
			return (Interop.ImageCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying the parameters of an image memory barrier.
    /// </para>
    /// <para>
    /// If pname:oldLayout differs from pname:newLayout, a layout transition occurs as part of the image memory barrier, affecting the data contained in the region of the image defined by the pname:subresourceRange. If pname:oldLayout is ename:VK_IMAGE_LAYOUT_UNDEFINED, then the data is undefined after the layout transition. This may: allow a more efficient transition, since the data may: be discarded. The layout transition must: occur after all operations using the old layout are completed and before all operations using the new layout are started. This is achieved by ensuring that there is a memory dependency between previous accesses and the layout transition, as well as between the layout transition and subsequent accesses, where the layout transition occurs between the two halves of a memory dependency in an image memory barrier.
    /// </para>
    /// <para>
    /// Layout transitions that are performed via image memory barriers are automatically ordered against other layout transitions, including those that occur as part of a render pass instance.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== See &lt;&lt;resources-image-layouts&gt;&gt; for details on available image layouts and their usages. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:oldLayout must: be ename:VK_IMAGE_LAYOUT_UNDEFINED or the current layout of the image subresources affected by the barrier * pname:newLayout must: not be ename:VK_IMAGE_LAYOUT_UNDEFINED or ename:VK_IMAGE_LAYOUT_PREINITIALIZED * If pname:image was created with a sharing mode of ename:VK_SHARING_MODE_CONCURRENT, pname:srcQueueFamilyIndex and pname:dstQueueFamilyIndex must: both be ename:VK_QUEUE_FAMILY_IGNORED * If pname:image was created with a sharing mode of ename:VK_SHARING_MODE_EXCLUSIVE, pname:srcQueueFamilyIndex and pname:dstQueueFamilyIndex must: either both be ename:VK_QUEUE_FAMILY_IGNORED, or both be a valid queue family (see &lt;&lt;devsandqueues-queueprops&gt;&gt;) * If pname:image was created with a sharing mode of ename:VK_SHARING_MODE_EXCLUSIVE, and pname:srcQueueFamilyIndex and pname:dstQueueFamilyIndex are valid queue families, at least one of them must: be the same as the family of the queue that will execute this barrier * pname:subresourceRange must: be a valid image subresource range for the image (see &lt;&lt;resources-image-views&gt;&gt;) * If pname:image has a depth/stencil format with both depth and stencil components, then pname:aspectMask member of pname:subresourceRange must: include both ename:VK_IMAGE_ASPECT_DEPTH_BIT and ename:VK_IMAGE_ASPECT_STENCIL_BIT * If either pname:oldLayout or pname:newLayout is ename:VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL then pname:image must: have been created with ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT set * If either pname:oldLayout or pname:newLayout is ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL then pname:image must: have been created with ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT set * If either pname:oldLayout or pname:newLayout is ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL then pname:image must: have been created with ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT set * If either pname:oldLayout or pname:newLayout is ename:VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL then pname:image must: have been created with ename:VK_IMAGE_USAGE_SAMPLED_BIT or ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT set * If either pname:oldLayout or pname:newLayout is ename:VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL then pname:image must: have been created with ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT set * If either pname:oldLayout or pname:newLayout is ename:VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL then pname:image must: have been created with ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT set ****
    /// </para>
    /// </summary>
	public struct ImageMemoryBarrier
	{
		/// <summary>
		/// -
		/// </summary>
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageLayout OldLayout
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageLayout NewLayout
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint SourceQueueFamilyIndex
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint DestinationQueueFamilyIndex
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Image Image
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceRange SubresourceRange
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ImageMemoryBarrier Pack()
		{
			Interop.ImageMemoryBarrier result = default(Interop.ImageMemoryBarrier);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ImageMemoryBarrier* MarshalTo()
		{
			return (Interop.ImageMemoryBarrier*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created image view.
    /// </para>
    /// <para>
    /// If pname:image was created with the ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT flag, pname:format can: be different from the image's format, but if they are not equal they must: be _compatible_. Image format compatibility is defined in the &lt;&lt;features-formats-compatibility-classes,Format Compatibility Classes&gt;&gt; section.
    /// </para>
    /// <para>
    /// .Image and image view parameter compatibility requirements [cols="15%h,35%,50%",options="header"] |==== | Dim, Arrayed, MS | Image parameters | View parameters | | pname:imageType = ci.pname:imageType + pname:width = ci.pname:extent.width + pname:height = ci.pname:extent.height + pname:depth = ci.pname:extent.depth + pname:arrayLayers = ci.pname:arrayLayers + pname:samples = ci.pname:samples + where ci is the slink:VkImageCreateInfo used to create pname:image. | pname:baseArrayLayer and pname:layerCount are members of the pname:subresourceRange member. | 1D, 0, 0 | pname:imageType = ename:VK_IMAGE_TYPE_1D + pname:width {geq} 1 + pname:height = 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 + pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_1D + pname:baseArrayLayer {geq} 0 + pname:layerCount = 1 | 1D, 1, 0 | pname:imageType = ename:VK_IMAGE_TYPE_1D + pname:width {geq} 1 + pname:height = 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 + pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_1D_ARRAY + pname:baseArrayLayer {geq} 0 + pname:layerCount {geq} 1 | 2D, 0, 0 | pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 + pname:height {geq} 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 + pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_2D + pname:baseArrayLayer {geq} 0 + pname:layerCount = 1 | 2D, 1, 0 | pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 + pname:height {geq} 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 + pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_2D_ARRAY + pname:baseArrayLayer {geq} 0 + pname:layerCount {geq} 1 | 2D, 0, 1 | pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 + pname:height {geq} 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 + pname:samples &gt; 1 | pname:viewType = ename:VK_VIEW_TYPE_2D + pname:baseArrayLayer {geq} 0 + pname:layerCount = 1 | 2D, 1, 1 | pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 + pname:height {geq} 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 + pname:samples &gt; 1 | pname:viewType = ename:VK_VIEW_TYPE_2D_ARRAY + pname:baseArrayLayer {geq} 0 + pname:layerCount {geq} 1 | CUBE, 0, 0 | pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 + pname:height = pname:width + pname:depth = 1 + pname:arrayLayers {geq} 6 + pname:samples = 1 + pname:flags includes ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT | pname:viewType = ename:VK_VIEW_TYPE_CUBE + pname:baseArrayLayer {geq} 0 + pname:layerCount = 6 | CUBE, 1, 0 | pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 + pname:height = width + pname:depth = 1 + _N_ {geq} 1 + pname:arrayLayers {geq} 6 {times} _N_ + pname:samples = 1 + pname:flags includes ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT | pname:viewType = ename:VK_VIEW_TYPE_CUBE_ARRAY + pname:baseArrayLayer {geq} 0 + pname:layerCount = 6 {times} _N_, _N_ {geq} 1 | 3D, 0, 0 | pname:imageType = ename:VK_IMAGE_TYPE_3D + pname:width {geq} 1 + pname:height {geq} 1 + pname:depth {geq} 1 + pname:arrayLayers = 1 + pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_3D + pname:baseArrayLayer = 0 + pname:layerCount = 1 |====
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:image was not created with ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT then pname:viewType must: not be ename:VK_IMAGE_VIEW_TYPE_CUBE or ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY * If the &lt;&lt;features-features-imageCubeArray,image cubemap arrays&gt;&gt; feature is not enabled, pname:viewType must: not be ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY * If the &lt;&lt;features-features-textureCompressionETC2,ETC2 texture compression&gt;&gt; feature is not enabled, pname:format must: not be ename:VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK, ename:VK_FORMAT_EAC_R11_UNORM_BLOCK, ename:VK_FORMAT_EAC_R11_SNORM_BLOCK, ename:VK_FORMAT_EAC_R11G11_UNORM_BLOCK, or ename:VK_FORMAT_EAC_R11G11_SNORM_BLOCK * If the &lt;&lt;features-features-textureCompressionASTC_LDR,ASTC LDR texture compression&gt;&gt; feature is not enabled, pname:format must: not be ename:VK_FORMAT_ASTC_4x4_UNORM_BLOCK, ename:VK_FORMAT_ASTC_4x4_SRGB_BLOCK, ename:VK_FORMAT_ASTC_5x4_UNORM_BLOCK, ename:VK_FORMAT_ASTC_5x4_SRGB_BLOCK, ename:VK_FORMAT_ASTC_5x5_UNORM_BLOCK, ename:VK_FORMAT_ASTC_5x5_SRGB_BLOCK, ename:VK_FORMAT_ASTC_6x5_UNORM_BLOCK, ename:VK_FORMAT_ASTC_6x5_SRGB_BLOCK, ename:VK_FORMAT_ASTC_6x6_UNORM_BLOCK, ename:VK_FORMAT_ASTC_6x6_SRGB_BLOCK, ename:VK_FORMAT_ASTC_8x5_UNORM_BLOCK, ename:VK_FORMAT_ASTC_8x5_SRGB_BLOCK, ename:VK_FORMAT_ASTC_8x6_UNORM_BLOCK, ename:VK_FORMAT_ASTC_8x6_SRGB_BLOCK, ename:VK_FORMAT_ASTC_8x8_UNORM_BLOCK, ename:VK_FORMAT_ASTC_8x8_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x5_UNORM_BLOCK, ename:VK_FORMAT_ASTC_10x5_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x6_UNORM_BLOCK, ename:VK_FORMAT_ASTC_10x6_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x8_UNORM_BLOCK, ename:VK_FORMAT_ASTC_10x8_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x10_UNORM_BLOCK, ename:VK_FORMAT_ASTC_10x10_SRGB_BLOCK, ename:VK_FORMAT_ASTC_12x10_UNORM_BLOCK, ename:VK_FORMAT_ASTC_12x10_SRGB_BLOCK, ename:VK_FORMAT_ASTC_12x12_UNORM_BLOCK, or ename:VK_FORMAT_ASTC_12x12_SRGB_BLOCK * If the &lt;&lt;features-features-textureCompressionBC,BC texture compression&gt;&gt; feature is not enabled, pname:format must: not be ename:VK_FORMAT_BC1_RGB_UNORM_BLOCK, ename:VK_FORMAT_BC1_RGB_SRGB_BLOCK, ename:VK_FORMAT_BC1_RGBA_UNORM_BLOCK, ename:VK_FORMAT_BC1_RGBA_SRGB_BLOCK, ename:VK_FORMAT_BC2_UNORM_BLOCK, ename:VK_FORMAT_BC2_SRGB_BLOCK, ename:VK_FORMAT_BC3_UNORM_BLOCK, ename:VK_FORMAT_BC3_SRGB_BLOCK, ename:VK_FORMAT_BC4_UNORM_BLOCK, ename:VK_FORMAT_BC4_SNORM_BLOCK, ename:VK_FORMAT_BC5_UNORM_BLOCK, ename:VK_FORMAT_BC5_SNORM_BLOCK, ename:VK_FORMAT_BC6H_UFLOAT_BLOCK, ename:VK_FORMAT_BC6H_SFLOAT_BLOCK, ename:VK_FORMAT_BC7_UNORM_BLOCK, or ename:VK_FORMAT_BC7_SRGB_BLOCK * If pname:image was created with ename:VK_IMAGE_TILING_LINEAR, pname:format must: be format that has at least one supported feature bit present in the value of sname:VkFormatProperties::pname:linearTilingFeatures returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format * If pname:image was created with ename:VK_IMAGE_TILING_LINEAR and pname:usage containing ename:VK_IMAGE_USAGE_SAMPLED_BIT, pname:format must: be supported for sampled images, as specified by the ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT flag in sname:VkFormatProperties::pname:linearTilingFeatures returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format * If pname:image was created with ename:VK_IMAGE_TILING_LINEAR and pname:usage containing ename:VK_IMAGE_USAGE_STORAGE_BIT, pname:format must: be supported for storage images, as specified by the ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT flag in sname:VkFormatProperties::pname:linearTilingFeatures returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format * If pname:image was created with ename:VK_IMAGE_TILING_LINEAR and pname:usage containing ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT, pname:format must: be supported for color attachments, as specified by the ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT flag in sname:VkFormatProperties::pname:linearTilingFeatures returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format * If pname:image was created with ename:VK_IMAGE_TILING_LINEAR and pname:usage containing ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, pname:format must: be supported for depth/stencil attachments, as specified by the ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT flag in sname:VkFormatProperties::pname:linearTilingFeatures returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format * If pname:image was created with ename:VK_IMAGE_TILING_OPTIMAL, pname:format must: be format that has at least one supported feature bit present in the value of sname:VkFormatProperties::pname:optimalTilingFeatures returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format * If pname:image was created with ename:VK_IMAGE_TILING_OPTIMAL and pname:usage containing ename:VK_IMAGE_USAGE_SAMPLED_BIT, pname:format must: be supported for sampled images, as specified by the ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT flag in sname:VkFormatProperties::pname:optimalTilingFeatures returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format * If pname:image was created with ename:VK_IMAGE_TILING_OPTIMAL and pname:usage containing ename:VK_IMAGE_USAGE_STORAGE_BIT, pname:format must: be supported for storage images, as specified by the ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT flag in sname:VkFormatProperties::pname:optimalTilingFeatures returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format * If pname:image was created with ename:VK_IMAGE_TILING_OPTIMAL and pname:usage containing ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT, pname:format must: be supported for color attachments, as specified by the ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT flag in sname:VkFormatProperties::pname:optimalTilingFeatures returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format * If pname:image was created with ename:VK_IMAGE_TILING_OPTIMAL and pname:usage containing ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, pname:format must: be supported for depth/stencil attachments, as specified by the ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT flag in sname:VkFormatProperties::pname:optimalTilingFeatures returned by fname:vkGetPhysicalDeviceFormatProperties with the same value of pname:format * pname:subresourceRange must: be a valid image subresource range for pname:image (see &lt;&lt;resources-image-views&gt;&gt;) * If pname:image was created with the ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT flag, pname:format must: be compatible with the pname:format used to create pname:image, as defined in &lt;&lt;features-formats-compatibility-classes,Format Compatibility Classes&gt;&gt; * If pname:image was not created with the ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT flag, pname:format must: be identical to the pname:format used to create pname:image * pname:subResourceRange and pname:viewType must: be compatible with the image, as described in the &lt;&lt;resources-image-views-compatibility,compatibility table&gt;&gt; ****
    /// </para>
    /// </summary>
	public struct ImageViewCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageViewCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Image Image
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageViewType ViewType
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Format Format
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ComponentMapping Components
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageSubresourceRange SubresourceRange
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ImageViewCreateInfo Pack()
		{
			Interop.ImageViewCreateInfo result = default(Interop.ImageViewCreateInfo);
			result.SType = StructureType.ImageViewCreateInfo;
			result.Image = this.Image?.Pack() ?? Interop.Image.Null;
			result.Flags = this.Flags;
			result.ViewType = this.ViewType;
			result.Format = this.Format;
			result.Components = this.Components;
			result.SubresourceRange = this.SubresourceRange;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ImageViewCreateInfo* MarshalTo()
		{
			return (Interop.ImageViewCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct ImportMemoryWin32HandleInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public ExternalMemoryHandleTypeFlags HandleType
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Handle
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ImportMemoryWin32HandleInfo Pack()
		{
			Interop.ImportMemoryWin32HandleInfo result = default(Interop.ImportMemoryWin32HandleInfo);
			result.SType = StructureType.ImportMemoryWin32HandleInfo;
			result.HandleType = this.HandleType;
			result.Handle = this.Handle;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ImportMemoryWin32HandleInfo* MarshalTo()
		{
			return (Interop.ImportMemoryWin32HandleInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct InstanceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public InstanceCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ApplicationInfo? ApplicationInfo
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public string[] EnabledLayerNames
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public string[] EnabledExtensionNames
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.InstanceCreateInfo Pack()
		{
			Interop.InstanceCreateInfo result = default(Interop.InstanceCreateInfo);
			result.SType = StructureType.InstanceCreateInfo;
			result.ApplicationInfo = this.ApplicationInfo == null ? null : this.ApplicationInfo.Value.MarshalTo();
			result.EnabledLayerNames = this.EnabledLayerNames == null ? null : Interop.HeapUtil.MarshalTo(this.EnabledLayerNames);
			result.EnabledExtensionNames = this.EnabledExtensionNames == null ? null : Interop.HeapUtil.MarshalTo(this.EnabledExtensionNames);
			result.EnabledLayerCount = (uint)(this.EnabledLayerNames?.Length ?? 0);
			result.EnabledExtensionCount = (uint)(this.EnabledExtensionNames?.Length ?? 0);
			result.Flags = this.Flags;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.InstanceCreateInfo* MarshalTo()
		{
			return (Interop.InstanceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct LayerProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public string LayerName
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Version SpecVersion
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Version ImplementationVersion
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public string Description
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal static unsafe LayerProperties MarshalFrom(Interop.LayerProperties* value)
		{
			LayerProperties result = new LayerProperties();
			result.LayerName = System.Text.Encoding.UTF8.GetString(Interop.HeapUtil.MarshalFrom(value->LayerName, (int)Constants.MaxExtensionNameSize, true));
			result.SpecVersion = value->SpecVersion;
			result.ImplementationVersion = value->ImplementationVersion;
			result.Description = System.Text.Encoding.UTF8.GetString(Interop.HeapUtil.MarshalFrom(value->Description, (int)Constants.MaxDescriptionSize, true));
			return result;
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying a mapped memory range.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:memory must: currently be mapped * If pname:size is not equal to ename:VK_WHOLE_SIZE, pname:offset and pname:size must: specify a range contained within the currently mapped range of pname:memory * If pname:size is equal to ename:VK_WHOLE_SIZE, pname:offset must: be within the currently mapped range of pname:memory * pname:offset must: be a multiple of sname:VkPhysicalDeviceLimits::pname:nonCoherentAtomSize * If pname:size is not equal to ename:VK_WHOLE_SIZE, pname:size must: be a multiple of sname:VkPhysicalDeviceLimits::pname:nonCoherentAtomSize ****
    /// </para>
    /// </summary>
	public struct MappedMemoryRange
	{
		/// <summary>
		/// -
		/// </summary>
		public DeviceMemory Memory
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong Offset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong Size
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.MappedMemoryRange Pack()
		{
			Interop.MappedMemoryRange result = default(Interop.MappedMemoryRange);
			result.SType = StructureType.MappedMemoryRange;
			result.Memory = this.Memory?.Pack() ?? Interop.DeviceMemory.Null;
			result.Offset = this.Offset;
			result.Size = this.Size;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.MappedMemoryRange* MarshalTo()
		{
			return (Interop.MappedMemoryRange*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure containing parameters of a memory allocation.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:allocationSize must: be less than or equal to the amount of memory available to the sname:VkMemoryHeap specified by pname:memoryTypeIndex and the calling command's sname:VkDevice * pname:allocationSize must: be greater than `0` ****
    /// </para>
    /// </summary>
	public struct MemoryAllocateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public ulong AllocationSize
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MemoryTypeIndex
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.MemoryAllocateInfo Pack()
		{
			Interop.MemoryAllocateInfo result = default(Interop.MemoryAllocateInfo);
			result.SType = StructureType.MemoryAllocateInfo;
			result.AllocationSize = this.AllocationSize;
			result.MemoryTypeIndex = this.MemoryTypeIndex;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.MemoryAllocateInfo* MarshalTo()
		{
			return (Interop.MemoryAllocateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct MemoryBarrier
	{
		/// <summary>
		/// -
		/// </summary>
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.MemoryBarrier Pack()
		{
			Interop.MemoryBarrier result = default(Interop.MemoryBarrier);
			result.SType = StructureType.MemoryBarrier;
			result.SourceAccessMask = this.SourceAccessMask;
			result.DestinationAccessMask = this.DestinationAccessMask;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.MemoryBarrier* MarshalTo()
		{
			return (Interop.MemoryBarrier*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct MirSurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public MirSurfaceCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Connection
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr MirSurface
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.MirSurfaceCreateInfo Pack()
		{
			Interop.MirSurfaceCreateInfo result = default(Interop.MirSurfaceCreateInfo);
			result.SType = StructureType.MirSurfaceCreateInfo;
			result.Connection = (IntPtr*)Interop.HeapUtil.AllocateAndMarshal(this.Connection);
			result.MirSurface = (IntPtr*)Interop.HeapUtil.AllocateAndMarshal(this.MirSurface);
			result.Flags = this.Flags;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.MirSurfaceCreateInfo* MarshalTo()
		{
			return (Interop.MirSurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct PhysicalDeviceLimits
	{
		/// <summary>
		/// -
		/// </summary>
		public uint MaxImageDimension1D
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxImageDimension2D
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxImageDimension3D
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxImageDimensionCube
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxImageArrayLayers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTexelBufferElements
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxUniformBufferRange
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxStorageBufferRange
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPushConstantsSize
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxMemoryAllocationCount
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxSamplerAllocationCount
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong BufferImageGranularity
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong SparseAddressSpaceSize
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxBoundDescriptorSets
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageDescriptorSamplers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageDescriptorUniformBuffers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageDescriptorStorageBuffers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageDescriptorSampledImages
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageDescriptorStorageImages
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageDescriptorInputAttachments
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxPerStageResources
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetSamplers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetUniformBuffers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetUniformBuffersDynamic
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetStorageBuffers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetStorageBuffersDynamic
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetSampledImages
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetStorageImages
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDescriptorSetInputAttachments
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxVertexInputAttributes
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxVertexInputBindings
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxVertexInputAttributeOffset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxVertexInputBindingStride
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxVertexOutputComponents
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationGenerationLevel
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationPatchSize
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationControlPerVertexInputComponents
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationControlPerVertexOutputComponents
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationControlPerPatchOutputComponents
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationControlTotalOutputComponents
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationEvaluationInputComponents
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTessellationEvaluationOutputComponents
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxGeometryShaderInvocations
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxGeometryInputComponents
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxGeometryOutputComponents
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxGeometryOutputVertices
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxGeometryTotalOutputComponents
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFragmentInputComponents
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFragmentOutputAttachments
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFragmentDualSourceAttachments
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFragmentCombinedOutputResources
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxComputeSharedMemorySize
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint[] MaxComputeWorkGroupCount
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxComputeWorkGroupInvocations
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint[] MaxComputeWorkGroupSize
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:subPixelPrecisionBits is the number of bits of subpixel precision in framebuffer coordinates [eq]#x~f~# and [eq]#y~f~#. See &lt;&lt;primsrast&gt;&gt;.
		/// </para>
		/// </summary>
		public uint SubPixelPrecisionBits
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:subTexelPrecisionBits is the number of bits of precision in the division along an axis of an image used for minification and magnification filters. [eq]#2^pname:subTexelPrecisionBits^# is the actual number of divisions along each axis of the image represented. The filtering hardware will snap to these locations when computing the filtered results.
		/// </para>
		/// </summary>
		public uint SubTexelPrecisionBits
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:mipmapPrecisionBits is the number of bits of division that the LOD calculation for mipmap fetching get snapped to when determining the contribution from each mip level to the mip filtered results. [eq]#2^pname:mipmapPrecisionBits^# is the actual number of divisions. + -- [NOTE] .Note ==== For example, if this value is 2 bits then when linearly filtering between two levels, each level could: contribute: 0%, 33%, 66%, or 100% (this is just an example and the amount of contribution should: be covered by different equations in the spec). ==== -- +
		/// </para>
		/// </summary>
		public uint MipmapPrecisionBits
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDrawIndexedIndexValue
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxDrawIndirectCount
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:maxSamplerLodBias is the maximum absolute sampler level of detail bias. The sum of the pname:mipLodBias member of the sname:VkSamplerCreateInfo structure and the code:Bias operand of image sampling operations in shader modules (or 0 if no code:Bias operand is provided to an image sampling operation) are clamped to the range [eq]#[-pname:maxSamplerLodBias,+pname:maxSamplerLodBias]#. See &lt;&lt;samplers-mipLodBias&gt;&gt;.
		/// </para>
		/// </summary>
		public float MaxSamplerLodBias
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float MaxSamplerAnisotropy
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxViewports
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint[] MaxViewportDimensions
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:viewportBoundsRange[2] is the [eq]#[minimum, maximum]# range that the corners of a viewport must: be contained in. This range must: be at least + -- [eq]#[-2 {times} pname:size, 2 {times} pname:size - 1]#, where [eq]#pname:size = max(pname:maxViewportDimensions[0], maxViewportDimensions[1])# See &lt;&lt;vertexpostproc-viewport,Controlling the Viewport&gt;&gt;.  [NOTE] .Note ==== The intent of the pname:viewportBoundsRange limit is to allow a maximum sized viewport to be arbitrarily shifted relative to the output target as long as at least some portion intersects. This would give a bounds limit of [eq]#[-pname:size + 1, 2 {times} pname:size - 1]# which would allow all possible non-empty-set intersections of the output target and the viewport. Since these numbers are typically powers of two, picking the signed number range using the smallest possible number of bits ends up with the specified range. ==== --
		/// </para>
		/// </summary>
		public float[] ViewportBoundsRange
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint ViewportSubPixelBits
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Size MinMemoryMapAlignment
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong MinTexelBufferOffsetAlignment
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong MinUniformBufferOffsetAlignment
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong MinStorageBufferOffsetAlignment
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public int MinTexelOffset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTexelOffset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public int MinTexelGatherOffset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxTexelGatherOffset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float MinInterpolationOffset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float MaxInterpolationOffset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint SubPixelInterpolationOffsetBits
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFramebufferWidth
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFramebufferHeight
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxFramebufferLayers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags FramebufferColorSampleCounts
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags FramebufferDepthSampleCounts
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags FramebufferStencilSampleCounts
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags FramebufferNoAttachmentsSampleCounts
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxColorAttachments
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags SampledImageColorSampleCounts
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags SampledImageIntegerSampleCounts
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags SampledImageDepthSampleCounts
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags SampledImageStencilSampleCounts
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags StorageImageSampleCounts
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxSampleMaskWords
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 TimestampComputeAndGraphics
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float TimestampPeriod
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxClipDistances
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxCullDistances
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MaxCombinedClipAndCullDistances
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint DiscreteQueuePriorities
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pointSizeRange[2] is the range [eq]#[pname:minimum,pname:maximum]# of supported sizes for points. Values written to variables decorated with the code:PointSize built-in decoration are clamped to this range.
		/// </para>
		/// </summary>
		public float[] PointSizeRange
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:lineWidthRange[2] is the range [eq]#[pname:minimum,pname:maximum]# of supported widths for lines. Values specified by the pname:lineWidth member of the sname:VkPipelineRasterizationStateCreateInfo or the pname:lineWidth parameter to fname:vkCmdSetLineWidth are clamped to this range.
		/// </para>
		/// </summary>
		public float[] LineWidthRange
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float PointSizeGranularity
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float LineWidthGranularity
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 StrictLines
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 StandardSampleLocations
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong OptimalBufferCopyOffsetAlignment
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong OptimalBufferCopyRowPitchAlignment
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong NonCoherentAtomSize
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal static unsafe PhysicalDeviceLimits MarshalFrom(Interop.PhysicalDeviceLimits* value)
		{
			PhysicalDeviceLimits result = new PhysicalDeviceLimits();
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
    /// <para>
    /// Structure specifying physical device memory properties.
    /// </para>
    /// <para>
    /// The sname:VkPhysicalDeviceMemoryProperties structure describes a number of _memory heaps_ as well as a number of _memory types_ that can: be used to access memory allocated in those heaps. Each heap describes a memory resource of a particular size, and each memory type describes a set of memory properties (e.g. host cached vs uncached) that can: be used with a given memory heap. Allocations using a particular memory type will consume resources from the heap indicated by that memory type's heap index. More than one memory type may: share each heap, and the heaps and memory types provide a mechanism to advertise an accurate size of the physical memory resources while allowing the memory to be used with a variety of different properties.
    /// </para>
    /// <para>
    /// The number of memory heaps is given by pname:memoryHeapCount and is less than or equal to ename:VK_MAX_MEMORY_HEAPS. Each heap is described by an element of the pname:memoryHeaps array, as a sname:VkMemoryHeap structure. The number of memory types available across all memory heaps is given by pname:memoryTypeCount and is less than or equal to ename:VK_MAX_MEMORY_TYPES. Each memory type is described by an element of the pname:memoryTypes array, as a sname:VkMemoryType structure.
    /// </para>
    /// <para>
    /// At least one heap must: include ename:VK_MEMORY_HEAP_DEVICE_LOCAL_BIT in slink:VkMemoryHeap::pname:flags. If there are multiple heaps that all have similar performance characteristics, they may: all include ename:VK_MEMORY_HEAP_DEVICE_LOCAL_BIT. In a unified memory architecture (UMA) system, there is often only a single memory heap which is considered to be equally ``local'' to the host and to the device, and such an implementation must: advertise the heap as device-local.
    /// </para>
    /// <para>
    /// Each memory type returned by flink:vkGetPhysicalDeviceMemoryProperties must: have its pname:propertyFlags set to one of the following values:
    /// </para>
    /// <para>
    /// * 0 * ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT * ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT * ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT | ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT * ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT * ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT | ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT * ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT | ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT * ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT | ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT | ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT | ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT * ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT | ename:VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT
    /// </para>
    /// <para>
    /// There must: be at least one memory type with both the ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT and ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT bits set in its pname:propertyFlags. There must: be at least one memory type with the ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT bit set in its pname:propertyFlags.
    /// </para>
    /// <para>
    /// The memory types are sorted according to a preorder which serves to aid in easily selecting an appropriate memory type. Given two memory types X and Y, the preorder defines [eq]#X {leq} Y# if:
    /// </para>
    /// <para>
    /// * the memory property bits set for X are a strict subset of the memory property bits set for Y. Or, * the memory property bits set for X are the same as the memory property bits set for Y, and X uses a memory heap with greater or equal performance (as determined in an implementation-specific manner).
    /// </para>
    /// <para>
    /// Memory types are ordered in the list such that X is assigned a lesser pname:memoryTypeIndex than Y if [eq]#(X {leq} Y) {land} {lnot} (Y {leq} X)# according to the preorder. Note that the list of all allowed memory property flag combinations above satisfies this preorder, but other orders would as well. The goal of this ordering is to enable applications to use a simple search loop in selecting the proper memory type, along the lines of:
    /// </para>
    /// <para>
    /// [source,{basebackend@docbook:c++:cpp}] --------------------------------------------------- // Find a memory type in "memoryTypeBits" that includes all of "properties" int32_t FindProperties(uint32_t memoryTypeBits, VkMemoryPropertyFlags properties) { for (int32_t i = 0; i &lt; memoryTypeCount; ++i) { if ((memoryTypeBits &amp; (1 &lt;&lt; i)) &amp;&amp; ((memoryTypes[i].propertyFlags &amp; properties) == properties)) return i; } return -1; }
    /// </para>
    /// <para>
    /// // Try to find an optimal memory type, or if it does not exist // find any compatible memory type VkMemoryRequirements memoryRequirements; vkGetImageMemoryRequirements(device, image, &amp;memoryRequirements); int32_t memoryType = FindProperties(memoryRequirements.memoryTypeBits, optimalProperties); if (memoryType == -1) memoryType = FindProperties(memoryRequirements.memoryTypeBits, requiredProperties); ---------------------------------------------------
    /// </para>
    /// <para>
    /// The loop will find the first supported memory type that has all bits requested in code:properties set. If there is no exact match, it will find a closest match (i.e. a memory type with the fewest additional bits set), which has some additional bits set but which are not detrimental to the behaviors requested by code:properties. The application can: first search for the optimal properties, e.g. a memory type that is device-local or supports coherent cached accesses, as appropriate for the intended usage, and if such a memory type is not present can: fallback to searching for a less optimal but guaranteed set of properties such as "0" or "host-visible and coherent".
    /// </para>
    /// </summary>
	public struct PhysicalDeviceMemoryProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public MemoryType[] MemoryTypes
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public MemoryHeap[] MemoryHeaps
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal static unsafe PhysicalDeviceMemoryProperties MarshalFrom(Interop.PhysicalDeviceMemoryProperties* value)
		{
			PhysicalDeviceMemoryProperties result = new PhysicalDeviceMemoryProperties();
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
	/// -
	/// </summary>
	public struct PhysicalDeviceProperties
	{
		/// <summary>
		/// -
		/// </summary>
		public Version ApiVersion
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Version DriverVersion
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint VendorID
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint DeviceID
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PhysicalDeviceType DeviceType
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public string DeviceName
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Guid PipelineCacheUUID
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PhysicalDeviceLimits Limits
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PhysicalDeviceSparseProperties SparseProperties
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal static unsafe PhysicalDeviceProperties MarshalFrom(Interop.PhysicalDeviceProperties* value)
		{
			PhysicalDeviceProperties result = new PhysicalDeviceProperties();
			result.ApiVersion = value->ApiVersion;
			result.DriverVersion = value->DriverVersion;
			result.DeviceName = System.Text.Encoding.UTF8.GetString(Interop.HeapUtil.MarshalFrom(value->DeviceName, (int)Constants.MaxPhysicalDeviceNameSize, true));
			result.PipelineCacheUUID = new Guid(Interop.HeapUtil.MarshalFrom(value->PipelineCacheUUID, (int)Constants.UuidSize));
			result.Limits = PhysicalDeviceLimits.MarshalFrom(&value->Limits);
			result.VendorID = value->VendorID;
			result.DeviceID = value->DeviceID;
			result.DeviceType = value->DeviceType;
			result.SparseProperties = value->SparseProperties;
			return result;
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline cache.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:initialDataSize is not `0`, it must: be equal to the size of pname:pInitialData, as returned by fname:vkGetPipelineCacheData when pname:pInitialData was originally retrieved * If pname:initialDataSize is not `0`, pname:pInitialData must: have been retrieved from a previous call to fname:vkGetPipelineCacheData ****
    /// </para>
    /// </summary>
	public struct PipelineCacheCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineCacheCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public byte[] InitialData
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineCacheCreateInfo Pack()
		{
			Interop.PipelineCacheCreateInfo result = default(Interop.PipelineCacheCreateInfo);
			result.SType = StructureType.PipelineCacheCreateInfo;
			result.InitialData = this.InitialData == null ? null : Interop.HeapUtil.MarshalTo(this.InitialData);
			result.InitialDataSize = (Size)(this.InitialData?.Length ?? 0);
			result.Flags = this.Flags;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineCacheCreateInfo* MarshalTo()
		{
			return (Interop.PipelineCacheCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline color blend state.
    /// </para>
    /// <para>
    /// Each element of the pname:pAttachments array is a slink:VkPipelineColorBlendAttachmentState structure specifying per-target blending state for each individual color attachment. If the &lt;&lt;features-features-independentBlend,independent blending&gt;&gt; feature is not enabled on the device, all slink:VkPipelineColorBlendAttachmentState elements in the pname:pAttachments array must: be identical.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the &lt;&lt;features-features-independentBlend,independent blending&gt;&gt; feature is not enabled, all elements of pname:pAttachments must: be identical * If the &lt;&lt;features-features-logicOp,logic operations&gt;&gt; feature is not enabled, pname:logicOpEnable must: be ename:VK_FALSE * If pname:logicOpEnable is ename:VK_TRUE, pname:logicOp must: be a valid elink:VkLogicOp value ****
    /// </para>
    /// </summary>
	public struct PipelineColorBlendStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineColorBlendStateCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 LogicOpEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public LogicOp LogicOp
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineColorBlendAttachmentState[] Attachments
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float[] BlendConstants
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineColorBlendStateCreateInfo Pack()
		{
			Interop.PipelineColorBlendStateCreateInfo result = default(Interop.PipelineColorBlendStateCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineColorBlendStateCreateInfo* MarshalTo()
		{
			return (Interop.PipelineColorBlendStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline depth stencil state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the &lt;&lt;features-features-depthBounds,depth bounds testing&gt;&gt; feature is not enabled, pname:depthBoundsTestEnable must: be ename:VK_FALSE ****
    /// </para>
    /// </summary>
	public struct PipelineDepthStencilStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineDepthStencilStateCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthTestEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthWriteEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public CompareOp DepthCompareOp
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthBoundsTestEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 StencilTestEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public StencilOpState Front
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public StencilOpState Back
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float MinDepthBounds
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float MaxDepthBounds
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineDepthStencilStateCreateInfo Pack()
		{
			Interop.PipelineDepthStencilStateCreateInfo result = default(Interop.PipelineDepthStencilStateCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineDepthStencilStateCreateInfo* MarshalTo()
		{
			return (Interop.PipelineDepthStencilStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct PipelineDynamicStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineDynamicStateCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DynamicState[] DynamicStates
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineDynamicStateCreateInfo Pack()
		{
			Interop.PipelineDynamicStateCreateInfo result = default(Interop.PipelineDynamicStateCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineDynamicStateCreateInfo* MarshalTo()
		{
			return (Interop.PipelineDynamicStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline input assembly state.
    /// </para>
    /// <para>
    /// Restarting the assembly of primitives discards the most recent index values if those elements formed an incomplete primitive, and restarts the primitive assembly using the subsequent indices, but only assembling the immediately following element through the end of the originally specified elements. The primitive restart index value comparison is performed before adding the pname:vertexOffset value to the index value.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:topology is ename:VK_PRIMITIVE_TOPOLOGY_POINT_LIST, ename:VK_PRIMITIVE_TOPOLOGY_LINE_LIST, ename:VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST, ename:VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY, ename:VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY or ename:VK_PRIMITIVE_TOPOLOGY_PATCH_LIST, pname:primitiveRestartEnable must: be ename:VK_FALSE * If the &lt;&lt;features-features-geometryShader,geometry shaders&gt;&gt; feature is not enabled, pname:topology must: not be any of ename:VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY, ename:VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY, ename:VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY or ename:VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY * If the &lt;&lt;features-features-tessellationShader,tessellation shaders&gt;&gt; feature is not enabled, pname:topology must: not be ename:VK_PRIMITIVE_TOPOLOGY_PATCH_LIST ****
    /// </para>
    /// </summary>
	public struct PipelineInputAssemblyStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineInputAssemblyStateCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PrimitiveTopology Topology
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 PrimitiveRestartEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineInputAssemblyStateCreateInfo Pack()
		{
			Interop.PipelineInputAssemblyStateCreateInfo result = default(Interop.PipelineInputAssemblyStateCreateInfo);
			result.SType = StructureType.PipelineInputAssemblyStateCreateInfo;
			result.Flags = this.Flags;
			result.Topology = this.Topology;
			result.PrimitiveRestartEnable = this.PrimitiveRestartEnable;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineInputAssemblyStateCreateInfo* MarshalTo()
		{
			return (Interop.PipelineInputAssemblyStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying the parameters of a newly created pipeline layout object.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:setLayoutCount must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxBoundDescriptorSets * The total number of descriptors of the type ename:VK_DESCRIPTOR_TYPE_SAMPLER and ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER accessible to any given shader stage across all elements of pname:pSetLayouts must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorSamplers * The total number of descriptors of the type ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER and ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC accessible to any given shader stage across all elements of pname:pSetLayouts must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorUniformBuffers * The total number of descriptors of the type ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER and ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC accessible to any given shader stage across all elements of pname:pSetLayouts must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorStorageBuffers * The total number of descriptors of the type ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, and ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER accessible to any given shader stage across all elements of pname:pSetLayouts must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorSampledImages * The total number of descriptors of the type ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, and ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER accessible to any given shader stage across all elements of pname:pSetLayouts must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorStorageImages * Any two elements of pname:pPushConstantRanges must: not include the same stage in pname:stageFlags ****
    /// </para>
    /// </summary>
	public struct PipelineLayoutCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineLayoutCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSetLayout[] SetLayouts
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PushConstantRange[] PushConstantRanges
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineLayoutCreateInfo Pack()
		{
			Interop.PipelineLayoutCreateInfo result = default(Interop.PipelineLayoutCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineLayoutCreateInfo* MarshalTo()
		{
			return (Interop.PipelineLayoutCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline multisample state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the &lt;&lt;features-features-sampleRateShading,sample rate shading&gt;&gt; feature is not enabled, pname:sampleShadingEnable must: be ename:VK_FALSE * If the &lt;&lt;features-features-alphaToOne,alpha to one&gt;&gt; feature is not enabled, pname:alphaToOneEnable must: be ename:VK_FALSE * pname:minSampleShading must: be in the range [eq]#[0,1]# ****
    /// </para>
    /// </summary>
	public struct PipelineMultisampleStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineMultisampleStateCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SampleCountFlags RasterizationSamples
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 SampleShadingEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float MinSampleShading
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SampleMask[] SampleMask
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 AlphaToCoverageEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 AlphaToOneEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineMultisampleStateCreateInfo Pack()
		{
			Interop.PipelineMultisampleStateCreateInfo result = default(Interop.PipelineMultisampleStateCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineMultisampleStateCreateInfo* MarshalTo()
		{
			return (Interop.PipelineMultisampleStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline rasterization state.
    /// </para>
    /// <para>
    /// ifdef::VK_AMD_rasterization_order[] The application can: also chain a sname:VkPipelineRasterizationStateRasterizationOrderAMD structure to the sname:VkPipelineRasterizationStateCreateInfo structure through its pname:pNext member. This structure enables selecting the rasterization order to use when rendering with the corresponding graphics pipeline as described in &lt;&lt;primrast-order, Rasterization Order&gt;&gt;. endif::VK_AMD_rasterization_order[]
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the &lt;&lt;features-features-depthClamp,depth clamping&gt;&gt; feature is not enabled, pname:depthClampEnable must: be ename:VK_FALSE * If the &lt;&lt;features-features-fillModeNonSolid,non-solid fill modes&gt;&gt; feature is not enabled, pname:polygonMode must: be ename:VK_POLYGON_MODE_FILL ****
    /// </para>
    /// </summary>
	public struct PipelineRasterizationStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineRasterizationStateCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthClampEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 RasterizerDiscardEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PolygonMode PolygonMode
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public CullModeFlags CullMode
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public FrontFace FrontFace
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 DepthBiasEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float DepthBiasConstantFactor
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float DepthBiasClamp
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float DepthBiasSlopeFactor
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float LineWidth
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineRasterizationStateCreateInfo Pack()
		{
			Interop.PipelineRasterizationStateCreateInfo result = default(Interop.PipelineRasterizationStateCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineRasterizationStateCreateInfo* MarshalTo()
		{
			return (Interop.PipelineRasterizationStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct PipelineRasterizationStateRasterizationOrder
	{
		/// <summary>
		/// -
		/// </summary>
		public RasterizationOrder RasterizationOrder
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineRasterizationStateRasterizationOrder Pack()
		{
			Interop.PipelineRasterizationStateRasterizationOrder result = default(Interop.PipelineRasterizationStateRasterizationOrder);
			result.SType = StructureType.PipelineRasterizationStateRasterizationOrder;
			result.RasterizationOrder = this.RasterizationOrder;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineRasterizationStateRasterizationOrder* MarshalTo()
		{
			return (Interop.PipelineRasterizationStateRasterizationOrder*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct PipelineShaderStageCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineShaderStageCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ShaderStageFlags Stage
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ShaderModule Module
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public string Name
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SpecializationInfo? SpecializationInfo
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineShaderStageCreateInfo Pack()
		{
			Interop.PipelineShaderStageCreateInfo result = default(Interop.PipelineShaderStageCreateInfo);
			result.SType = StructureType.PipelineShaderStageCreateInfo;
			result.Module = this.Module?.Pack() ?? Interop.ShaderModule.Null;
			result.Name = Interop.HeapUtil.MarshalTo(this.Name);
			result.SpecializationInfo = this.SpecializationInfo == null ? null : this.SpecializationInfo.Value.MarshalTo();
			result.Flags = this.Flags;
			result.Stage = this.Stage;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineShaderStageCreateInfo* MarshalTo()
		{
			return (Interop.PipelineShaderStageCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline tessellation state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:patchControlPoints must: be greater than zero and less than or equal to sname:VkPhysicalDeviceLimits::pname:maxTessellationPatchSize ****
    /// </para>
    /// </summary>
	public struct PipelineTessellationStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineTessellationStateCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint PatchControlPoints
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineTessellationStateCreateInfo Pack()
		{
			Interop.PipelineTessellationStateCreateInfo result = default(Interop.PipelineTessellationStateCreateInfo);
			result.SType = StructureType.PipelineTessellationStateCreateInfo;
			result.Flags = this.Flags;
			result.PatchControlPoints = this.PatchControlPoints;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineTessellationStateCreateInfo* MarshalTo()
		{
			return (Interop.PipelineTessellationStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline vertex input state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:vertexBindingDescriptionCount must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxVertexInputBindings * pname:vertexAttributeDescriptionCount must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxVertexInputAttributes * For every pname:binding specified by any given element of pname:pVertexAttributeDescriptions, a sname:VkVertexInputBindingDescription must: exist in pname:pVertexBindingDescriptions with the same value of pname:binding * All elements of pname:pVertexBindingDescriptions must: describe distinct binding numbers * All elements of pname:pVertexAttributeDescriptions must: describe distinct attribute locations ****
    /// </para>
    /// </summary>
	public struct PipelineVertexInputStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineVertexInputStateCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public VertexInputBindingDescription[] VertexBindingDescriptions
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public VertexInputAttributeDescription[] VertexAttributeDescriptions
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineVertexInputStateCreateInfo Pack()
		{
			Interop.PipelineVertexInputStateCreateInfo result = default(Interop.PipelineVertexInputStateCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineVertexInputStateCreateInfo* MarshalTo()
		{
			return (Interop.PipelineVertexInputStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline viewport state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the &lt;&lt;features-features-multiViewport,multiple viewports&gt;&gt; feature is not enabled, pname:viewportCount must: be `1` * If the &lt;&lt;features-features-multiViewport,multiple viewports&gt;&gt; feature is not enabled, pname:scissorCount must: be `1` * pname:viewportCount must: be between `1` and sname:VkPhysicalDeviceLimits::pname:maxViewports, inclusive * pname:scissorCount must: be between `1` and sname:VkPhysicalDeviceLimits::pname:maxViewports, inclusive * pname:scissorCount and pname:viewportCount must: be identical ****
    /// </para>
    /// </summary>
	public struct PipelineViewportStateCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public PipelineViewportStateCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Viewport[] Viewports
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Rect2D[] Scissors
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineViewportStateCreateInfo Pack()
		{
			Interop.PipelineViewportStateCreateInfo result = default(Interop.PipelineViewportStateCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PipelineViewportStateCreateInfo* MarshalTo()
		{
			return (Interop.PipelineViewportStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure describing parameters of a queue presentation.
    /// </para>
    /// <para>
    /// .Valid Usage **** * Any given element of pname:pImageIndices must: be the index of a presentable image acquired from the swapchain specified by the corresponding element of the pname:pSwapchains array * Any given element of sname:VkSemaphore in pname:pWaitSemaphores must: refer to a prior signal of that sname:VkSemaphore that will not be consumed by any other wait on that semaphore ****
    /// </para>
    /// </summary>
	public struct PresentInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Semaphore[] WaitSemaphores
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Swapchain[] Swapchains
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint[] ImageIndices
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Result[] Results
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PresentInfo Pack()
		{
			Interop.PresentInfo result = default(Interop.PresentInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.PresentInfo* MarshalTo()
		{
			return (Interop.PresentInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct QueryPoolCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public QueryPoolCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public QueryType QueryType
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint QueryCount
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public QueryPipelineStatisticFlags PipelineStatistics
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.QueryPoolCreateInfo Pack()
		{
			Interop.QueryPoolCreateInfo result = default(Interop.QueryPoolCreateInfo);
			result.SType = StructureType.QueryPoolCreateInfo;
			result.Flags = this.Flags;
			result.QueryType = this.QueryType;
			result.QueryCount = this.QueryCount;
			result.PipelineStatistics = this.PipelineStatistics;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.QueryPoolCreateInfo* MarshalTo()
		{
			return (Interop.QueryPoolCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying render pass begin info.
    /// </para>
    /// <para>
    /// pname:renderArea is the render area that is affected by the render pass instance. The effects of attachment load, store and resolve operations are restricted to the pixels whose x and y coordinates fall within the render area on all attachments. The render area extends to all layers of pname:framebuffer. The application must: ensure (using scissor if necessary) that all rendering is contained within the render area, otherwise the pixels outside of the render area become undefined and shader side effects may: occur for fragments outside the render area. The render area must: be contained within the framebuffer dimensions.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== There may: be a performance cost for using a render area smaller than the framebuffer, unless it matches the render area granularity for the render pass. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:clearValueCount must: be greater than the largest attachment index in pname:renderPass that specifies a pname:loadOp (or pname:stencilLoadOp, if the attachment has a depth/stencil format) of ename:VK_ATTACHMENT_LOAD_OP_CLEAR ****
    /// </para>
    /// </summary>
	public struct RenderPassBeginInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public RenderPass RenderPass
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Framebuffer Framebuffer
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Rect2D RenderArea
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ClearValue[] ClearValues
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.RenderPassBeginInfo Pack()
		{
			Interop.RenderPassBeginInfo result = default(Interop.RenderPassBeginInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.RenderPassBeginInfo* MarshalTo()
		{
			return (Interop.RenderPassBeginInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created render pass.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If any two subpasses operate on attachments with overlapping ranges of the same sname:VkDeviceMemory object, and at least one subpass writes to that area of sname:VkDeviceMemory, a subpass dependency must: be included (either directly or via some intermediate subpasses) between them * If the pname:attachment member of any element of pname:pInputAttachments, pname:pColorAttachments, pname:pResolveAttachments or pname:pDepthStencilAttachment, or the attachment indexed by any element of pname:pPreserveAttachments in any given element of pname:pSubpasses is bound to a range of a sname:VkDeviceMemory object that overlaps with any other attachment in any subpass (including the same subpass), the sname:VkAttachmentDescription structures describing them must: include ename:VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT in pname:flags * If the pname:attachment member of any element of pname:pInputAttachments, pname:pColorAttachments, pname:pResolveAttachments or pname:pDepthStencilAttachment, or any element of pname:pPreserveAttachments in any given element of pname:pSubpasses is not ename:VK_ATTACHMENT_UNUSED, it must: be less than pname:attachmentCount * The value of any element of the pname:pPreserveAttachments member in any given element of pname:pSubpasses must: not be ename:VK_ATTACHMENT_UNUSED ****
    /// </para>
    /// </summary>
	public struct RenderPassCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public RenderPassCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public AttachmentDescription[] Attachments
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SubpassDescription[] Subpasses
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SubpassDependency[] Dependencies
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.RenderPassCreateInfo Pack()
		{
			Interop.RenderPassCreateInfo result = default(Interop.RenderPassCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.RenderPassCreateInfo* MarshalTo()
		{
			return (Interop.RenderPassCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct SamplerCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public SamplerCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Filter MagFilter
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Filter MinFilter
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SamplerMipmapMode MipmapMode
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SamplerAddressMode AddressModeU
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SamplerAddressMode AddressModeV
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SamplerAddressMode AddressModeW
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float MipLodBias
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 AnisotropyEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float MaxAnisotropy
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 CompareEnable
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public CompareOp CompareOp
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float MinLod
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public float MaxLod
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public BorderColor BorderColor
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 UnnormalizedCoordinates
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SamplerCreateInfo Pack()
		{
			Interop.SamplerCreateInfo result = default(Interop.SamplerCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SamplerCreateInfo* MarshalTo()
		{
			return (Interop.SamplerCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct SemaphoreCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public SemaphoreCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SemaphoreCreateInfo Pack()
		{
			Interop.SemaphoreCreateInfo result = default(Interop.SemaphoreCreateInfo);
			result.SType = StructureType.SemaphoreCreateInfo;
			result.Flags = this.Flags;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SemaphoreCreateInfo* MarshalTo()
		{
			return (Interop.SemaphoreCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created shader module.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:codeSize must: be greater than 0 * pname:codeSize must: be a multiple of 4. If the +VK_NV_glsl_shader extension+ is enabled and pname:pCode references GLSL code pname:codeSize can be a multiple of 1 * pname:pCode must: point to valid SPIR-V code, formatted and packed as described by the &lt;&lt;spirv-spec,Khronos SPIR-V Specification&gt;&gt;. If the +VK_NV_glsl_shader+ extension is enabled pname:pCode can instead reference valid GLSL code and must: be written to the +GL_KHR_vulkan_glsl+ extension specification * pname:pCode must: adhere to the validation rules described by the &lt;&lt;spirvenv-module-validation, Validation Rules within a Module&gt;&gt; section of the &lt;&lt;spirvenv-capabilities,SPIR-V Environment&gt;&gt; appendix. If the +VK_NV_glsl_shader+ extension is enabled pname:pCode can be valid GLSL code with respect to the +GL_KHR_vulkan_glsl+ GLSL extension specification * pname:pCode must: declare the code:Shader capability for SPIR-V code * pname:pCode must: not declare any capability that is not supported by the API, as described by the &lt;&lt;spirvenv-module-validation, Capabilities&gt;&gt; section of the &lt;&lt;spirvenv-capabilities,SPIR-V Environment&gt;&gt; appendix * If pname:pCode declares any of the capabilities that are listed as not required by the implementation, the relevant feature must: be enabled, as listed in the &lt;&lt;spirvenv-capabilities-table,SPIR-V Environment&gt;&gt; appendix ****
    /// </para>
    /// </summary>
	public struct ShaderModuleCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public ShaderModuleCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Size CodeSize
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint[] Code
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ShaderModuleCreateInfo Pack()
		{
			Interop.ShaderModuleCreateInfo result = default(Interop.ShaderModuleCreateInfo);
			result.SType = StructureType.ShaderModuleCreateInfo;
			result.Code = this.Code == null ? null : Interop.HeapUtil.MarshalTo(this.Code);
			result.Flags = this.Flags;
			result.CodeSize = this.CodeSize;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ShaderModuleCreateInfo* MarshalTo()
		{
			return (Interop.ShaderModuleCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct SparseBufferMemoryBindInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Buffer Buffer
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SparseMemoryBind[] Binds
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SparseBufferMemoryBindInfo Pack()
		{
			Interop.SparseBufferMemoryBindInfo result = default(Interop.SparseBufferMemoryBindInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SparseBufferMemoryBindInfo* MarshalTo()
		{
			return (Interop.SparseBufferMemoryBindInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying sparse image memory bind.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the &lt;&lt;features-features-sparseResidencyAliased,sparse aliased residency&gt;&gt; feature is not enabled, and if any other resources are bound to ranges of pname:memory, the range of pname:memory being bound must: not overlap with those bound ranges * pname:memory and pname:memoryOffset must: match the memory requirements of the calling command's pname:image, as described in section &lt;&lt;resources-association&gt;&gt; * pname:subresource must: be a valid image subresource for pname:image (see &lt;&lt;resources-image-views&gt;&gt;) * pname:offset.x must: be a multiple of the sparse image block width (sname:VkSparseImageFormatProperties::pname:imageGranularity.width) of the image * pname:extent.width must: either be a multiple of the sparse image block width of the image, or else pname:extent.width + pname:offset.x must: equal the width of the image subresource * pname:offset.y must: be a multiple of the sparse image block height (sname:VkSparseImageFormatProperties::pname:imageGranularity.height) of the image * pname:extent.height must: either be a multiple of the sparse image block height of the image, or else pname:extent.height + pname:offset.y must: equal the height of the image subresource * pname:offset.z must: be a multiple of the sparse image block depth (sname:VkSparseImageFormatProperties::pname:imageGranularity.depth) of the image * pname:extent.depth must: either be a multiple of the sparse image block depth of the image, or else pname:extent.depth + pname:offset.z must: equal the depth of the image subresource ****
    /// </para>
    /// </summary>
	public struct SparseImageMemoryBind
	{
		/// <summary>
		/// -
		/// </summary>
		public ImageSubresource Subresource
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Offset3D Offset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:extent is the size in texels of the region within the image subresource to bind. The extent must: be a multiple of the sparse image block dimensions, except when binding sparse image blocks along the edge of an image subresource it can: instead be such that any coordinate of [eq]#pname:offset + pname:extent# equals the corresponding dimensions of the image subresource.
		/// </para>
		/// </summary>
		public Extent3D Extent
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DeviceMemory Memory
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong MemoryOffset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SparseMemoryBindFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SparseImageMemoryBind Pack()
		{
			Interop.SparseImageMemoryBind result = default(Interop.SparseImageMemoryBind);
			result.Memory = this.Memory?.Pack() ?? Interop.DeviceMemory.Null;
			result.Subresource = this.Subresource;
			result.Offset = this.Offset;
			result.Extent = this.Extent;
			result.MemoryOffset = this.MemoryOffset;
			result.Flags = this.Flags;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SparseImageMemoryBind* MarshalTo()
		{
			return (Interop.SparseImageMemoryBind*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct SparseImageMemoryBindInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Image Image
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SparseImageMemoryBind[] Binds
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SparseImageMemoryBindInfo Pack()
		{
			Interop.SparseImageMemoryBindInfo result = default(Interop.SparseImageMemoryBindInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SparseImageMemoryBindInfo* MarshalTo()
		{
			return (Interop.SparseImageMemoryBindInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying sparse image opaque memory bind info.
    /// </para>
    /// <para>
    /// .Valid Usage **** * For any given element of pname:pBinds, if the pname:flags member of that element contains ename:VK_SPARSE_MEMORY_BIND_METADATA_BIT, the binding range defined must: be within the mip tail region of the metadata aspect of pname:image ****
    /// </para>
    /// </summary>
	public struct SparseImageOpaqueMemoryBindInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Image Image
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SparseMemoryBind[] Binds
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SparseImageOpaqueMemoryBindInfo Pack()
		{
			Interop.SparseImageOpaqueMemoryBindInfo result = default(Interop.SparseImageOpaqueMemoryBindInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SparseImageOpaqueMemoryBindInfo* MarshalTo()
		{
			return (Interop.SparseImageOpaqueMemoryBindInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct SparseMemoryBind
	{
		/// <summary>
		/// -
		/// </summary>
		public ulong ResourceOffset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong Size
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DeviceMemory Memory
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong MemoryOffset
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SparseMemoryBindFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SparseMemoryBind Pack()
		{
			Interop.SparseMemoryBind result = default(Interop.SparseMemoryBind);
			result.Memory = this.Memory?.Pack() ?? Interop.DeviceMemory.Null;
			result.ResourceOffset = this.ResourceOffset;
			result.Size = this.Size;
			result.MemoryOffset = this.MemoryOffset;
			result.Flags = this.Flags;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SparseMemoryBind* MarshalTo()
		{
			return (Interop.SparseMemoryBind*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying specialization info.
    /// </para>
    /// <para>
    /// pname:pMapEntries points to a structure of type slink:VkSpecializationMapEntry.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The pname:offset member of any given element of pname:pMapEntries must: be less than pname:dataSize * For any given element of pname:pMapEntries, pname:size must: be less than or equal to pname:dataSize minus pname:offset ****
    /// </para>
    /// </summary>
	public struct SpecializationInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public SpecializationMapEntry[] MapEntries
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public byte[] Data
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SpecializationInfo Pack()
		{
			Interop.SpecializationInfo result = default(Interop.SpecializationInfo);
			
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
			result.DataSize = (Size)(this.Data?.Length ?? 0);
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SpecializationInfo* MarshalTo()
		{
			return (Interop.SpecializationInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying a queue submit operation.
    /// </para>
    /// <para>
    /// .Valid Usage **** * Any given element of pname:pSignalSemaphores must: currently be unsignaled * Any given element of pname:pCommandBuffers must: either have been recorded with the ename:VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT, or not currently be executing on the device * Any given element of pname:pCommandBuffers must: be in the executable state * If any given element of pname:pCommandBuffers contains commands that execute secondary command buffers, those secondary command buffers must: have been recorded with the ename:VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT, or not currently be executing on the device * If any given element of pname:pCommandBuffers was recorded with ename:VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT, it must: not have been previously submitted without re-recording that command buffer * If any given element of pname:pCommandBuffers contains commands that execute secondary command buffers recorded with ename:VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT, each such secondary command buffer must: not have been previously submitted without re-recording that command buffer * Any given element of pname:pCommandBuffers must: not contain commands that execute a secondary command buffer, if that secondary command buffer has been recorded in another primary command buffer after it was recorded into this sname:VkCommandBuffer * Any given element of pname:pCommandBuffers must: have been allocated from a sname:VkCommandPool that was created for the same queue family that the calling command's pname:queue belongs to * Any given element of pname:pCommandBuffers must: not have been allocated with ename:VK_COMMAND_BUFFER_LEVEL_SECONDARY * Any given element of sname:VkSemaphore in pname:pWaitSemaphores must: refer to a prior signal of that sname:VkSemaphore that will not be consumed by any other wait on that semaphore * If the &lt;&lt;features-features-geometryShader,geometry shaders&gt;&gt; feature is not enabled, any given element of pname:pWaitDstStageMask must: not contain ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT * If the &lt;&lt;features-features-tessellationShader,tessellation shaders&gt;&gt; feature is not enabled, any given element of pname:pWaitDstStageMask must: not contain ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT or ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT ****
    /// </para>
    /// </summary>
	public struct SubmitInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Semaphore[] WaitSemaphores
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineStageFlags[] WaitDestinationStageMask
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public CommandBuffer[] CommandBuffers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Semaphore[] SignalSemaphores
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SubmitInfo Pack()
		{
			Interop.SubmitInfo result = default(Interop.SubmitInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SubmitInfo* MarshalTo()
		{
			return (Interop.SubmitInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying a subpass description.
    /// </para>
    /// <para>
    /// The contents of an attachment within the render area become undefined at the start of a subpass S if all of the following conditions are true:
    /// </para>
    /// <para>
    /// * The attachment is used as a color, depth/stencil, or resolve attachment in any subpass in the render pass. * There is a subpass S1 that uses or preserves the attachment, and a subpass dependency from S1 to S. * The attachment is not used or preserved in subpass S.
    /// </para>
    /// <para>
    /// Once the contents of an attachment become undefined in subpass S, they remain undefined for subpasses in subpass dependency chains starting with subpass S until they are written again. However, they remain valid for subpasses in other subpass dependency chains starting with subpass S1 if those subpasses use or preserve the attachment.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:pipelineBindPoint must: be ename:VK_PIPELINE_BIND_POINT_GRAPHICS * pname:colorAttachmentCount must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxColorAttachments * If the first use of an attachment in this render pass is as an input attachment, and the attachment is not also used as a color or depth/stencil attachment in the same subpass, then pname:loadOp must: not be ename:VK_ATTACHMENT_LOAD_OP_CLEAR * If pname:pResolveAttachments is not `NULL`, for each resolve attachment that does not have the value ename:VK_ATTACHMENT_UNUSED, the corresponding color attachment must: not have the value ename:VK_ATTACHMENT_UNUSED * If pname:pResolveAttachments is not `NULL`, the sample count of each element of pname:pColorAttachments must: be anything other than ename:VK_SAMPLE_COUNT_1_BIT * Any given element of pname:pResolveAttachments must: have a sample count of ename:VK_SAMPLE_COUNT_1_BIT * Any given element of pname:pResolveAttachments must: have the same elink:VkFormat as its corresponding color attachment * All attachments in pname:pColorAttachments and pname:pDepthStencilAttachment that are not ename:VK_ATTACHMENT_UNUSED must: have the same sample count * If any input attachments are ename:VK_ATTACHMENT_UNUSED, then any pipelines bound during the subpass must: not access those input attachments from the fragment shader * The pname:attachment member of any element of pname:pPreserveAttachments must: not be ename:VK_ATTACHMENT_UNUSED * Any given element of pname:pPreserveAttachments must: not also be an element of any other member of the subpass description * If any attachment is used as both an input attachment and a color or depth/stencil attachment, then each use must: use the same pname:layout ****
    /// </para>
    /// </summary>
	public struct SubpassDescription
	{
		/// <summary>
		/// -
		/// </summary>
		public SubpassDescriptionFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PipelineBindPoint PipelineBindPoint
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public AttachmentReference[] InputAttachments
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public AttachmentReference[] ColorAttachments
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public AttachmentReference[] ResolveAttachments
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public AttachmentReference DepthStencilAttachment
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint[] PreserveAttachments
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SubpassDescription Pack()
		{
			Interop.SubpassDescription result = default(Interop.SubpassDescription);
			
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SubpassDescription* MarshalTo()
		{
			return (Interop.SubpassDescription*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created swapchain object.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Applications should: set this value to ename:VK_TRUE if they do not expect to read back the content of presentable images before presenting them or after reacquiring them and if their pixel shaders do not have any side effects that require them to run for all pixels in the presentable image. ====
    /// </para>
    /// <para>
    /// * pname:oldSwapchain, if not code:VK_NULL_HANDLE, specifies the swapchain that will be replaced by the new swapchain being created. The new swapchain will be a descendant of pname:oldSwapchain. Further, any descendants of the new swapchain will also be descendants of pname:oldSwapchain. Upon calling fname:vkCreateSwapchainKHR with a pname:oldSwapchain that is not code:VK_NULL_HANDLE, any images not acquired by the application may: be freed by the implementation, which may: occur even if creation of the new swapchain fails. The application must: destroy the old swapchain to free all memory associated with the old swapchain. The application must: wait for the completion of any outstanding rendering to images it currently has acquired at the time the swapchain is destroyed. The application can: continue to present any images it acquired and has not yet presented using the old swapchain, as long as it has not entered a state that causes it to return ename:VK_ERROR_OUT_OF_DATE_KHR. However, the application cannot: acquire any more images from the old swapchain regardless of whether or not creation of the new swapchain succeeds.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:surface must: be a surface that is supported by the device as determined using fname:vkGetPhysicalDeviceSurfaceSupportKHR * The native window referred to by pname:surface must: not already be associated with a swapchain other than pname:oldSwapchain, or with a non-Vulkan graphics API surface * pname:minImageCount must: be greater than or equal to the value returned in the pname:minImageCount member of the sname:VkSurfaceCapabilitiesKHR structure returned by fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR for the surface * pname:minImageCount must: be less than or equal to the value returned in the pname:maxImageCount member of the sname:VkSurfaceCapabilitiesKHR structure returned by fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR for the surface if the returned pname:maxImageCount is not zero * pname:imageFormat and pname:imageColorSpace must: match the pname:format and pname:colorSpace members, respectively, of one of the sname:VkSurfaceFormatKHR structures returned by fname:vkGetPhysicalDeviceSurfaceFormatsKHR for the surface * pname:imageExtent must: be between pname:minImageExtent and pname:maxImageExtent, inclusive, where pname:minImageExtent and pname:maxImageExtent are members of the sname:VkSurfaceCapabilitiesKHR structure returned by fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR for the surface * pname:imageArrayLayers must: be greater than `0` and less than or equal to the pname:maxImageArrayLayers member of the sname:VkSurfaceCapabilitiesKHR structure returned by fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR for the surface * pname:imageUsage must: be a subset of the supported usage flags present in the pname:supportedUsageFlags member of the sname:VkSurfaceCapabilitiesKHR structure returned by fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR for the surface * If pname:imageSharingMode is ename:VK_SHARING_MODE_CONCURRENT, pname:pQueueFamilyIndices must: be a pointer to an array of pname:queueFamilyIndexCount basetype:uint32_t values * If pname:imageSharingMode is ename:VK_SHARING_MODE_CONCURRENT, pname:queueFamilyIndexCount must: be greater than `1` * pname:preTransform must: be one of the bits present in the pname:supportedTransforms member of the sname:VkSurfaceCapabilitiesKHR structure returned by fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR for the surface * pname:compositeAlpha must: be one of the bits present in the pname:supportedCompositeAlpha member of the sname:VkSurfaceCapabilitiesKHR structure returned by fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR for the surface * pname:presentMode must: be one of the ename:VkPresentModeKHR values returned by fname:vkGetPhysicalDeviceSurfacePresentModesKHR for the surface ****
    /// </para>
    /// </summary>
	public struct SwapchainCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public SwapchainCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Surface Surface
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint MinImageCount
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Format ImageFormat
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ColorSpace ImageColorSpace
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Extent2D ImageExtent
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint ImageArrayLayers
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ImageUsageFlags ImageUsage
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SharingMode ImageSharingMode
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint[] QueueFamilyIndices
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public SurfaceTransformFlags PreTransform
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public CompositeAlphaFlags CompositeAlpha
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public PresentMode PresentMode
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Bool32 Clipped
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public Swapchain OldSwapchain
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SwapchainCreateInfo Pack()
		{
			Interop.SwapchainCreateInfo result = default(Interop.SwapchainCreateInfo);
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
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.SwapchainCreateInfo* MarshalTo()
		{
			return (Interop.SwapchainCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct ValidationFlags
	{
		/// <summary>
		/// -
		/// </summary>
		public ValidationCheck[] DisabledValidationChecks
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ValidationFlags Pack()
		{
			Interop.ValidationFlags result = default(Interop.ValidationFlags);
			result.SType = StructureType.ValidationFlags;
			
			//DisabledValidationChecks
			if (this.DisabledValidationChecks != null)
			{
			    result.DisabledValidationChecks = (ValidationCheck*)Interop.HeapUtil.Allocate<int>(this.DisabledValidationChecks.Length).ToPointer();
			    for (int index = 0; index < this.DisabledValidationChecks.Length; index++)
			    {
			        result.DisabledValidationChecks[index] = this.DisabledValidationChecks[index];
			    }
			}
			else
			{
			    result.DisabledValidationChecks = null;
			}
			result.DisabledValidationCheckCount = (uint)(this.DisabledValidationChecks?.Length ?? 0);
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.ValidationFlags* MarshalTo()
		{
			return (Interop.ValidationFlags*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct WaylandSurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public WaylandSurfaceCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Display
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Surface
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.WaylandSurfaceCreateInfo Pack()
		{
			Interop.WaylandSurfaceCreateInfo result = default(Interop.WaylandSurfaceCreateInfo);
			result.SType = StructureType.WaylandSurfaceCreateInfo;
			result.Flags = this.Flags;
			result.Display = this.Display;
			result.Surface = this.Surface;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.WaylandSurfaceCreateInfo* MarshalTo()
		{
			return (Interop.WaylandSurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct Win32KeyedMutexAcquireReleaseInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public DeviceMemory[] AcquireSyncs
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong[] AcquireKeys
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint[] AcquireTimeoutMilliseconds
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DeviceMemory[] ReleaseSyncs
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public ulong[] ReleaseKeys
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.Win32KeyedMutexAcquireReleaseInfo Pack()
		{
			Interop.Win32KeyedMutexAcquireReleaseInfo result = default(Interop.Win32KeyedMutexAcquireReleaseInfo);
			result.SType = StructureType.Win32KeyedMutexAcquireReleaseInfo;
			
			//AcquireSyncs
			if (this.AcquireSyncs != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DeviceMemory>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DeviceMemory>(this.AcquireSyncs.Length);
			    for (int index = 0; index < this.AcquireSyncs.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.AcquireSyncs[index].Pack(), pointer + (size * index), false);
			    }
			    result.AcquireSyncs = (Interop.DeviceMemory*)pointer.ToPointer();
			}
			else
			{
			    result.AcquireSyncs = null;
			}
			result.AcquireKeys = this.AcquireKeys == null ? null : Interop.HeapUtil.MarshalTo(this.AcquireKeys);
			result.AcquireTimeoutMilliseconds = this.AcquireTimeoutMilliseconds == null ? null : Interop.HeapUtil.MarshalTo(this.AcquireTimeoutMilliseconds);
			
			//ReleaseSyncs
			if (this.ReleaseSyncs != null)
			{
			    int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.DeviceMemory>();
			    IntPtr pointer = Interop.HeapUtil.Allocate<Interop.DeviceMemory>(this.ReleaseSyncs.Length);
			    for (int index = 0; index < this.ReleaseSyncs.Length; index++)
			    {
			        System.Runtime.InteropServices.Marshal.StructureToPtr(this.ReleaseSyncs[index].Pack(), pointer + (size * index), false);
			    }
			    result.ReleaseSyncs = (Interop.DeviceMemory*)pointer.ToPointer();
			}
			else
			{
			    result.ReleaseSyncs = null;
			}
			result.ReleaseKeys = this.ReleaseKeys == null ? null : Interop.HeapUtil.MarshalTo(this.ReleaseKeys);
			result.AcquireCount = (uint)(this.AcquireTimeoutMilliseconds?.Length ?? 0);
			result.ReleaseCount = (uint)(this.ReleaseKeys?.Length ?? 0);
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.Win32KeyedMutexAcquireReleaseInfo* MarshalTo()
		{
			return (Interop.Win32KeyedMutexAcquireReleaseInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct Win32SurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public Win32SurfaceCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Hinstance
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Hwnd
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.Win32SurfaceCreateInfo Pack()
		{
			Interop.Win32SurfaceCreateInfo result = default(Interop.Win32SurfaceCreateInfo);
			result.SType = StructureType.Win32SurfaceCreateInfo;
			result.Flags = this.Flags;
			result.Hinstance = this.Hinstance;
			result.Hwnd = this.Hwnd;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.Win32SurfaceCreateInfo* MarshalTo()
		{
			return (Interop.Win32SurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying the parameters of a descriptor set write operation.
    /// </para>
    /// <para>
    /// Only one of pname:pImageInfo, pname:pBufferInfo, or pname:pTexelBufferView members is used according to the descriptor type specified in the pname:descriptorType member of the containing sname:VkWriteDescriptorSet structure, as specified below.
    /// </para>
    /// <para>
    /// [[descriptorsets-updates-consecutive, consecutive binding updates]] If the pname:dstBinding has fewer than pname:descriptorCount array elements remaining starting from pname:dstArrayElement, then the remainder will be used to update the subsequent binding - pname:dstBinding+1 starting at array element zero. This behavior applies recursively, with the update affecting consecutive bindings as needed to update all pname:descriptorCount descriptors. All consecutive bindings updated via a single sname:VkWriteDescriptorSet structure must: have identical pname:descriptorType and pname:stageFlags, and must: all either use immutable samplers or must: all not use immutable samplers.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:dstBinding must: be a valid binding point within pname:dstSet * pname:descriptorType must: match the type of pname:dstBinding within pname:dstSet * The sum of pname:dstArrayElement and pname:descriptorCount must: be less than or equal to the number of array elements in the descriptor set binding specified by pname:dstBinding, and all applicable consecutive bindings, as described by &lt;&lt;descriptorsets-updates-consecutive&gt;&gt; * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT, pname:pImageInfo must: be a pointer to an array of pname:descriptorCount valid sname:VkDescriptorImageInfo structures * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER or ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER, pname:pTexelBufferView must: be a pointer to an array of pname:descriptorCount valid sname:VkBufferView handles * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER, ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER, ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, pname:pBufferInfo must: be a pointer to an array of pname:descriptorCount valid sname:VkDescriptorBufferInfo structures * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_SAMPLER or ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and pname:dstSet was not allocated with a layout that included immutable samplers for pname:dstBinding with pname:descriptorType, the pname:sampler member of any given element of pname:pImageInfo must: be a valid sname:VkSampler object * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT, the pname:imageView and pname:imageLayout members of any given element of pname:pImageInfo must: be a valid sname:VkImageView and elink:VkImageLayout, respectively * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, the pname:offset member of any given element of pname:pBufferInfo must: be a multiple of sname:VkPhysicalDeviceLimits::pname:minUniformBufferOffsetAlignment * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, the pname:offset member of any given element of pname:pBufferInfo must: be a multiple of sname:VkPhysicalDeviceLimits::pname:minStorageBufferOffsetAlignment * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, the pname:buffer member of any given element of pname:pBufferInfo must: have been created with ename:VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT set * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, the pname:buffer member of any given element of pname:pBufferInfo must: have been created with ename:VK_BUFFER_USAGE_STORAGE_BUFFER_BIT set * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, the pname:range member of any given element of pname:pBufferInfo, or the effective range if pname:range is ename:VK_WHOLE_SIZE, must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxUniformBufferRange * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, the pname:range member of any given element of pname:pBufferInfo, or the effective range if pname:range is ename:VK_WHOLE_SIZE, must: be less than or equal to sname:VkPhysicalDeviceLimits::pname:maxStorageBufferRange * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER, the sname:VkBuffer that any given element of pname:pTexelBufferView was created from must: have been created with ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT set * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER, the sname:VkBuffer that any given element of pname:pTexelBufferView was created from must: have been created with ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set * If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE or ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT, the pname:imageView member of any given element of pname:pImageInfo must: have been created with the identity swizzle ****
    /// </para>
    /// </summary>
	public struct WriteDescriptorSet
	{
		/// <summary>
		/// -
		/// </summary>
		public DescriptorSet DestinationSet
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint DestinationBinding
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public uint DestinationArrayElement
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DescriptorType DescriptorType
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DescriptorImageInfo[] ImageInfo
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public DescriptorBufferInfo[] BufferInfo
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public BufferView[] TexelBufferView
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.WriteDescriptorSet Pack()
		{
			Interop.WriteDescriptorSet result = default(Interop.WriteDescriptorSet);
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
			result.DescriptorCount = (uint)(this.ImageInfo?.Length ?? this.BufferInfo?.Length ?? this.TexelBufferView?.Length ?? 0);
			result.DestinationBinding = this.DestinationBinding;
			result.DestinationArrayElement = this.DestinationArrayElement;
			result.DescriptorType = this.DescriptorType;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.WriteDescriptorSet* MarshalTo()
		{
			return (Interop.WriteDescriptorSet*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct XcbSurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public XcbSurfaceCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Connection
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Window
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.XcbSurfaceCreateInfo Pack()
		{
			Interop.XcbSurfaceCreateInfo result = default(Interop.XcbSurfaceCreateInfo);
			result.SType = StructureType.XcbSurfaceCreateInfo;
			result.Connection = (IntPtr*)Interop.HeapUtil.AllocateAndMarshal(this.Connection);
			result.Flags = this.Flags;
			result.Window = this.Window;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.XcbSurfaceCreateInfo* MarshalTo()
		{
			return (Interop.XcbSurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
	
	/// <summary>
	/// -
	/// </summary>
	public struct XlibSurfaceCreateInfo
	{
		/// <summary>
		/// -
		/// </summary>
		public XlibSurfaceCreateFlags Flags
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Dpy
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		public IntPtr Window
		{
			get;
			set;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.XlibSurfaceCreateInfo Pack()
		{
			Interop.XlibSurfaceCreateInfo result = default(Interop.XlibSurfaceCreateInfo);
			result.SType = StructureType.XlibSurfaceCreateInfo;
			result.Dpy = (IntPtr*)Interop.HeapUtil.AllocateAndMarshal(this.Dpy);
			result.Flags = this.Flags;
			result.Window = this.Window;
			return result;
		}
		
		/// <summary>
		/// -
		/// </summary>
		internal unsafe Interop.XlibSurfaceCreateInfo* MarshalTo()
		{
			return (Interop.XlibSurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}
}
