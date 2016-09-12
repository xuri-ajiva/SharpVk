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
    /// <para>
    /// Structure containing callback function pointers for memory allocation.
    /// </para>
    /// </summary>
	public struct AllocationCallbacks
	{
	    /// <summary>
		/// <para>
		/// pname:pUserData is a value to be interpreted by the implementation of the callbacks. When any of the callbacks in sname:VkAllocationCallbacks are called, the Vulkan implementation will pass this value as the first parameter to the callback. This value can: vary each time an allocator is passed into a command, even when the same object takes an allocator in multiple commands.
		/// </para>
		/// </summary>
		public IntPtr UserData
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pfnAllocation is a pointer to an application-defined memory allocation function of type tlink:PFN_vkAllocationFunction.
		/// </para>
		/// </summary>
		public AllocationFunctionDelegate PfnAllocation
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pfnReallocation is a pointer to an application-defined memory reallocation function of type tlink:PFN_vkReallocationFunction.
		/// </para>
		/// </summary>
		public ReallocationFunctionDelegate PfnReallocation
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pfnFree is a pointer to an application-defined memory free function of type tlink:PFN_vkFreeFunction.
		/// </para>
		/// </summary>
		public FreeFunctionDelegate PfnFree
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pfnInternalAllocation is a pointer to an application-defined function that is called by the implementation when the implementation makes internal allocations, and it is of type tlink:PFN_vkInternalAllocationNotification.
		/// </para>
		/// </summary>
		public InternalAllocationNotificationDelegate PfnInternalAllocation
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pfnInternalFree is a pointer to an application-defined function that is called by the implementation when the implementation frees internal allocations, and it is of type tlink:PFN_vkInternalFreeNotification.
		/// </para>
		/// </summary>
		public InternalFreeNotificationDelegate PfnInternalFree
		{
			get;
			set;
		}

        internal unsafe Interop.AllocationCallbacks Pack()
        {
            var result = new Interop.AllocationCallbacks();
			result.UserData = this.UserData.ToPointer();
			result.PfnAllocation = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnAllocation);
			result.PfnReallocation = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnReallocation);
			result.PfnFree = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnFree);
			result.PfnInternalAllocation = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnInternalAllocation);
			result.PfnInternalFree = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnInternalFree);

            return result;
        }

		internal unsafe Interop.AllocationCallbacks* MarshalTo()
        {
            return (Interop.AllocationCallbacks*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created Android surface object.
    /// </para>
    /// </summary>
	public struct AndroidSurfaceCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public AndroidSurfaceCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:window is a pointer to the ANativeWindow to associate the surface with.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying application info.
    /// </para>
    /// </summary>
	public struct ApplicationInfo
	{
	    /// <summary>
		/// <para>
		/// pname:pApplicationName is a pointer to a null-terminated UTF-8 string containing the name of the application.
		/// </para>
		/// </summary>
		public string ApplicationName
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:applicationVersion is an unsigned integer variable containing the developer-supplied version number of the application.
		/// </para>
		/// </summary>
		public Version ApplicationVersion
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pEngineName is a pointer to a null-terminated UTF-8 string containing the name of the engine (if any) used to create the application.
		/// </para>
		/// </summary>
		public string EngineName
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:engineVersion is an unsigned integer variable containing the developer-supplied version number of the engine used to create the application.
		/// </para>
		/// </summary>
		public Version EngineVersion
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:apiVersion is the version of the Vulkan API against which the application expects to run, encoded as described in the &lt;&lt;fundamentals-versionnum,API Version Numbers and Semantics&gt;&gt; section. If pname:apiVersion is 0 the implementation must: ignore it, otherwise if the implementation does not support the requested pname:apiVersion it must: return ename:VK_ERROR_INCOMPATIBLE_DRIVER. The patch version number specified in pname:apiVersion is ignored when creating an instance object. Only the major and minor versions of the instance must: match those requested in pname:apiVersion.
		/// </para>
		/// </summary>
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
			result.ApplicationVersion = (uint)this.ApplicationVersion;
			result.EngineName = Interop.HeapUtil.MarshalTo(this.EngineName);
			result.EngineVersion = (uint)this.EngineVersion;
			result.ApiVersion = (uint)this.ApiVersion;

            return result;
        }

		internal unsafe Interop.ApplicationInfo* MarshalTo()
        {
            return (Interop.ApplicationInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying a sparse binding operation.
    /// </para>
    /// </summary>
	public struct BindSparseInfo
	{
	    /// <summary>
		/// <para>
		/// pname:pWaitSemaphores is a pointer to an array of semaphores upon which to wait on before the sparse binding operations for this batch begin execution. If semaphores to wait on are provided, they define a &lt;&lt;synchronization-semaphores-waiting, semaphore wait operation&gt;&gt;.
		/// </para>
		/// </summary>
		public Semaphore[] WaitSemaphores
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pBufferBinds is a pointer to an array of slink:VkSparseBufferMemoryBindInfo structures.
		/// </para>
		/// </summary>
		public SparseBufferMemoryBindInfo[] BufferBinds
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pImageOpaqueBinds is a pointer to an array of slink:VkSparseImageOpaqueMemoryBindInfo structures, indicating opaque sparse image bindings to perform.
		/// </para>
		/// </summary>
		public SparseImageOpaqueMemoryBindInfo[] ImageOpaqueBinds
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pImageBinds is a pointer to an array of slink:VkSparseImageMemoryBindInfo structures, indicating sparse image bindings to perform.
		/// </para>
		/// </summary>
		public SparseImageMemoryBindInfo[] ImageBinds
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pSignalSemaphores is a pointer to an array of semaphores which will be signaled when the sparse binding operations for this batch have completed execution. If semaphores to be signaled are provided, they define a &lt;&lt;synchronization-semaphores-signaling, semaphore signal operation&gt;&gt;.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying the parameters of a newly created buffer object.
    /// </para>
    /// </summary>
	public struct BufferCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is a bitmask describing additional parameters of the buffer. See elink:VkBufferCreateFlagBits below for a description of the supported bits.
		/// </para>
		/// </summary>
		public BufferCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:size is the size in bytes of the buffer to be created.
		/// </para>
		/// </summary>
		public ulong Size
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:usage is a bitmask describing the allowed usages of the buffer. See elink:VkBufferUsageFlagBits below for a description of the supported bits.
		/// </para>
		/// </summary>
		public BufferUsageFlags Usage
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:sharingMode is the sharing mode of the buffer when it will be accessed by multiple queue families, see elink:VkSharingMode in the &lt;&lt;resources-sharing,Resource Sharing&gt;&gt; section below for supported values.
		/// </para>
		/// </summary>
		public SharingMode SharingMode
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pQueueFamilyIndices is a list of queue families that will access this buffer (ignored if pname:sharingMode is not ename:VK_SHARING_MODE_CONCURRENT).
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying the parameters of a buffer memory barrier.
    /// </para>
    /// </summary>
	public struct BufferMemoryBarrier
	{
	    /// <summary>
		/// <para>
		/// pname:srcAccessMask is a bitmask of the classes of memory accesses performed by the first set of commands that will participate in the dependency.
		/// </para>
		/// </summary>
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dstAccessMask is a bitmask of the classes of memory accesses performed by the second set of commands that will participate in the dependency.
		/// </para>
		/// </summary>
		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:srcQueueFamilyIndex is the queue family that is relinquishing ownership of the range of pname:buffer to another queue, or ename:VK_QUEUE_FAMILY_IGNORED if there is no transfer of ownership.
		/// </para>
		/// </summary>
		public uint SourceQueueFamilyIndex
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dstQueueFamilyIndex is the queue family that is acquiring ownership of the range of pname:buffer from another queue, or ename:VK_QUEUE_FAMILY_IGNORED if there is no transfer of ownership.
		/// </para>
		/// </summary>
		public uint DestinationQueueFamilyIndex
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:buffer is a handle to the buffer whose backing memory is affected by the barrier.
		/// </para>
		/// </summary>
		public Buffer Buffer
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:offset is an offset in bytes into the backing memory for pname:buffer; this is relative to the base offset as bound to the buffer (see flink:vkBindBufferMemory).
		/// </para>
		/// </summary>
		public ulong Offset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:size is a size in bytes of the affected area of backing memory for pname:buffer, or ename:VK_WHOLE_SIZE to use the range from pname:offset to the end of the buffer.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created buffer view.
    /// </para>
    /// </summary>
	public struct BufferViewCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public BufferViewCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:buffer is a sname:VkBuffer on which the view will be created.
		/// </para>
		/// </summary>
		public Buffer Buffer
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:format is a elink:VkFormat describing the format of the data elements in the buffer.
		/// </para>
		/// </summary>
		public Format Format
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:offset is an offset in bytes from the base address of the buffer. Accesses to the buffer view from shaders use addressing that is relative to this starting offset.
		/// </para>
		/// </summary>
		public ulong Offset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:range is a size in bytes of the buffer view. If pname:range is equal to ename:VK_WHOLE_SIZE, the range from pname:offset to the end of the buffer is used. If ename:VK_WHOLE_SIZE is used and the remaining size of the buffer is not a multiple of the element size of pname:format, then the nearest smaller multiple is used.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying the allocation parameters for command buffer object.
    /// </para>
    /// </summary>
	public struct CommandBufferAllocateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:commandPool is the name of the command pool that the command buffers allocate their memory from.
		/// </para>
		/// </summary>
		public CommandPool CommandPool
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:level determines whether the command buffers are primary or secondary command buffers. Possible values include: + --
		/// </para>
		/// </summary>
		public CommandBufferLevel Level
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying a command buffer begin operation.
    /// </para>
    /// </summary>
	public struct CommandBufferBeginInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is a bitmask indicating usage behavior for the command buffer. Bits which can: be set include: + --
		/// </para>
		/// </summary>
		public CommandBufferUsageFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying command buffer inheritance info.
    /// </para>
    /// </summary>
	public struct CommandBufferInheritanceInfo
	{
	    /// <summary>
		/// <para>
		/// pname:renderPass is a sname:VkRenderPass object defining which render passes the sname:VkCommandBuffer will be &lt;&lt;renderpass-compatibility, compatible&gt;&gt; with and can: be executed within. If the sname:VkCommandBuffer will not be executed within a render pass instance, pname:renderPass is ignored.
		/// </para>
		/// </summary>
		public RenderPass RenderPass
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:subpass is the index of the subpass within pname:renderPass that the sname:VkCommandBuffer will be executed within. If the sname:VkCommandBuffer will not be executed within a render pass instance, pname:subpass is ignored.
		/// </para>
		/// </summary>
		public uint Subpass
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:framebuffer optionally refers to the sname:VkFramebuffer object that the sname:VkCommandBuffer will be rendering to if it is executed within a render pass instance. It can: be dlink:VK_NULL_HANDLE if the framebuffer is not known, or if the sname:VkCommandBuffer will not be executed within a render pass instance. + [NOTE] .Note ==== Specifying the exact framebuffer that the secondary command buffer will be executed with may: result in better performance at command buffer execution time. ====
		/// </para>
		/// </summary>
		public Framebuffer Framebuffer
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:occlusionQueryEnable indicates whether the command buffer can: be executed while an occlusion query is active in the primary command buffer. If this is ename:VK_TRUE, then this command buffer can: be executed whether the primary command buffer has an occlusion query active or not. If this is ename:VK_FALSE, then the primary command buffer must: not have an occlusion query active.
		/// </para>
		/// </summary>
		public Bool32 OcclusionQueryEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:queryFlags indicates the query flags that can: be used by an active occlusion query in the primary command buffer when this secondary command buffer is executed. If this value includes the ename:VK_QUERY_CONTROL_PRECISE_BIT bit, then the active query can: return boolean results or actual sample counts. If this bit is not set, then the active query must: not use the ename:VK_QUERY_CONTROL_PRECISE_BIT bit. If this is a primary command buffer, then this value is ignored.
		/// </para>
		/// </summary>
		public QueryControlFlags QueryFlags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pipelineStatistics indicates the set of pipeline statistics that can: be counted by an active query in the primary command buffer when this secondary command buffer is executed. If this value includes a given bit, then this command buffer can: be executed whether the primary command buffer has a pipeline statistics query active that includes this bit or not. If this value excludes a given bit, then the active pipeline statistics query must: not be from a query pool that counts that statistic.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created command pool.
    /// </para>
    /// </summary>
	public struct CommandPoolCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is a bitmask indicating usage behavior for the pool and command buffers allocated from it. Bits which can: be set include: + --
		/// </para>
		/// </summary>
		public CommandPoolCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created compute pipeline.
    /// </para>
    /// </summary>
	public struct ComputePipelineCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags provides options for pipeline creation, and is of type elink:VkPipelineCreateFlagBits.
		/// </para>
		/// </summary>
		public PipelineCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:stage is a slink:VkPipelineShaderStageCreateInfo describing the compute shader.
		/// </para>
		/// </summary>
		public PipelineShaderStageCreateInfo Stage
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:layout is the description of binding locations used by both the pipeline and descriptor sets used with the pipeline.
		/// </para>
		/// </summary>
		public PipelineLayout Layout
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:basePipelineHandle is a pipeline to derive from
		/// </para>
		/// </summary>
		public Pipeline BasePipelineHandle
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:basePipelineIndex is an index into the pname:pCreateInfos parameter to use as a pipeline to derive from
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying a copy descriptor set operation.
    /// </para>
    /// </summary>
	public struct CopyDescriptorSet
	{
	    /// <summary>
		/// <para>
		/// pname:srcSet, pname:srcBinding, and pname:srcArrayElement are the source set, binding, and array element, respectively.
		/// </para>
		/// </summary>
		public DescriptorSet SourceSet
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint SourceBinding
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint SourceArrayElement
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dstSet, pname:dstBinding, and pname:dstArrayElement are the destination set, binding, and array element, respectively.
		/// </para>
		/// </summary>
		public DescriptorSet DestinationSet
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint DestinationBinding
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint DestinationArrayElement
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:descriptorCount is the number of descriptors to copy from the source to destination. If pname:descriptorCount is greater than the number of remaining array elements in the source or destination binding, those affect consecutive bindings in a manner similar to slink:VkWriteDescriptorSet above.
		/// </para>
		/// </summary>
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
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public struct DebugMarkerMarkerInfo
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public string MarkerName
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public struct DebugMarkerObjectNameInfo
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public DebugReportObjectType ObjectType
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ulong Object
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public struct DebugMarkerObjectTagInfo
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public DebugReportObjectType ObjectType
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ulong Object
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ulong TagName
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
			result.TagSize = (Size)(this.Tag?.Length ?? 0);
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
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public struct DebugReportCallbackCreateInfo
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public DebugReportFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public DebugReportCallbackDelegate PfnCallback
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public IntPtr UserData
		{
			get;
			set;
		}

        internal unsafe Interop.DebugReportCallbackCreateInfo Pack()
        {
            var result = new Interop.DebugReportCallbackCreateInfo();
			result.SType = StructureType.DebugReportCallbackCreateInfo;
			result.PfnCallback = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(this.PfnCallback);
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
    /// <para>
    /// Specify that a buffer is bound to a dedicated memory resource.
    /// </para>
    /// <para>
    /// If the pname:pNext list includes a sname:VkDedicatedAllocationBufferCreateInfoNV structure, then that structure includes an enable controlling whether the buffer will have a dedicated memory allocation bound to it.
    /// </para>
    /// </summary>
	public struct DedicatedAllocationBufferCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:dedicatedAllocation indicates whether the buffer will have a dedicated allocation bound to it.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Specify that an image is bound to a dedicated memory resource.
    /// </para>
    /// <para>
    /// If the pname:pNext list includes a sname:VkDedicatedAllocationImageCreateInfoNV structure, then that structure includes an enable controlling whether the image will have a dedicated memory allocation bound to it.
    /// </para>
    /// </summary>
	public struct DedicatedAllocationImageCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:dedicatedAllocation indicates whether the image will have a dedicated allocation bound to it.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Specify a dedicated memory allocation resource.
    /// </para>
    /// <para>
    /// If the pname:pNext list includes a sname:VkDedicatedAllocationMemoryAllocateInfoNV structure, then that structure includes a handle of the sole buffer or image resource that the memory can: be bound to.
    /// </para>
    /// </summary>
	public struct DedicatedAllocationMemoryAllocateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:image is sname:VK_NULL_HANDLE or a handle of an image which this memory will be bound to.
		/// </para>
		/// </summary>
		public Image Image
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:buffer is sname:VK_NULL_HANDLE or a handle of a buffer which this memory will be bound to.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying descriptor buffer info.
    /// </para>
    /// </summary>
	public struct DescriptorBufferInfo
	{
	    /// <summary>
		/// <para>
		/// pname:buffer is the buffer resource.
		/// </para>
		/// </summary>
		public Buffer Buffer
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:offset is the offset in bytes from the start of pname:buffer. Access to buffer memory via this descriptor uses addressing that is relative to this starting offset.
		/// </para>
		/// </summary>
		public ulong Offset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:range is the size in bytes that is used for this descriptor update, or ename:VK_WHOLE_SIZE to use the range from pname:offset to the end of the buffer. + -- [NOTE] .Note ==== When using ename:VK_WHOLE_SIZE, the effective range must: not be larger than the maximum range for the descriptor type (&lt;&lt;features-limits-maxUniformBufferRange, maxUniformBufferRange&gt;&gt; or &lt;&lt;features-limits-maxStorageBufferRange, maxStorageBufferRange&gt;&gt;). This means that ename:VK_WHOLE_SIZE is not typically useful in the common case where uniform buffer descriptors are suballocated from a buffer that is much larger than pname:maxUniformBufferRange. ==== -- + For ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC and ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC descriptor types, pname:offset is the base offset from which the dynamic offset is applied and pname:range is the static size used for all dynamic offsets.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying descriptor image info.
    /// </para>
    /// </summary>
	public struct DescriptorImageInfo
	{
	    /// <summary>
		/// <para>
		/// pname:sampler is a sampler handle, and is used in descriptor updates for types ename:VK_DESCRIPTOR_TYPE_SAMPLER and ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER if the binding being updated does not use immutable samplers.
		/// </para>
		/// </summary>
		public Sampler Sampler
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:imageView is an image view handle, and is used in descriptor updates for types ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT.
		/// </para>
		/// </summary>
		public ImageView ImageView
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:imageLayout is the layout that the image will be in at the time this descriptor is accessed. pname:imageLayout is used in descriptor updates for types ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created descriptor pool.
    /// </para>
    /// </summary>
	public struct DescriptorPoolCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags specifies certain supported operations on the pool. Bits which can: be set include: + --
		/// </para>
		/// </summary>
		public DescriptorPoolCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint MaxSets
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying the allocation parameters for descriptor sets.
    /// </para>
    /// </summary>
	public struct DescriptorSetAllocateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:descriptorPool is the pool which the sets will be allocated from.
		/// </para>
		/// </summary>
		public DescriptorPool DescriptorPool
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pSetLayouts is an array of descriptor set layouts, with each member specifying how the corresponding descriptor set is allocated.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying a descriptor set layout binding.
    /// </para>
    /// </summary>
	public struct DescriptorSetLayoutBinding
	{
	    /// <summary>
		/// <para>
		/// pname:binding is the binding number of this entry and corresponds to a resource of the same binding number in the shader stages.
		/// </para>
		/// </summary>
		public uint Binding
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:descriptorType is a elink:VkDescriptorType specifying which type of resource descriptors are used for this binding.
		/// </para>
		/// </summary>
		public DescriptorType DescriptorType
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:stageFlags member is a bitmask of elink:VkShaderStageFlagBits specifying which pipeline shader stages can: access a resource for this binding. ename:VK_SHADER_STAGE_ALL is a shorthand specifying that all defined shader stages, including any additional stages defined by extensions, can: access the resource. + -- If a shader stage is not included in pname:stageFlags, then a resource must: not be accessed from that stage via this binding within any pipeline using the set layout. There are no limitations on what combinations of stages can: be used by a descriptor binding, and in particular a binding can: be used by both graphics stages and the compute stage. --
		/// </para>
		/// </summary>
		public ShaderStageFlags StageFlags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pImmutableSamplers affects initialization of samplers. If pname:descriptorType specifies a ename:VK_DESCRIPTOR_TYPE_SAMPLER or ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER type descriptor, then pname:pImmutableSamplers can: be used to initialize a set of _immutable samplers_. Immutable samplers are permanently bound into the set layout; later binding a sampler into an immutable sampler slot in a descriptor set is not allowed. If pname:pImmutableSamplers is not `NULL`, then it is considered to be a pointer to an array of sampler handles that will be consumed by the set layout and used for the corresponding binding. If pname:pImmutableSamplers is `NULL`, then the sampler slots are dynamic and sampler handles must: be bound into descriptor sets using this layout. If pname:descriptorType is not one of these descriptor types, then pname:pImmutableSamplers is ignored.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created descriptor set layout.
    /// </para>
    /// </summary>
	public struct DescriptorSetLayoutCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public DescriptorSetLayoutCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pBindings is a pointer to an array of slink:VkDescriptorSetLayoutBinding structures.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created device.
    /// </para>
    /// </summary>
	public struct DeviceCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public DeviceCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pQueueCreateInfos is a pointer to an array of slink:VkDeviceQueueCreateInfo structures describing the queues that are requested to be created along with the logical device. Refer to the &lt;&lt;devsandqueues-queue-creation,Queue Creation&gt;&gt; section below for further details.
		/// </para>
		/// </summary>
		public DeviceQueueCreateInfo[] QueueCreateInfos
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:ppEnabledLayerNames is deprecated and ignored. See &lt;&lt;extended-functionality-device-layer-deprecation,Device Layer Deprecation&gt;&gt;.
		/// </para>
		/// </summary>
		public string[] EnabledLayerNames
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:ppEnabledExtensionNames is a pointer to an array of pname:enabledExtensionCount null-terminated UTF-8 strings containing the names of extensions to enable for the created device. See the &lt;&lt;extended-functionality-extensions,Extensions&gt;&gt; section for further details.
		/// </para>
		/// </summary>
		public string[] EnabledExtensionNames
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pEnabledFeatures is `NULL` or a pointer to a slink:VkPhysicalDeviceFeatures structure that contains boolean indicators of all the features to be enabled. Refer to the &lt;&lt;features-features,Features&gt;&gt; section for further details.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created device queue.
    /// </para>
    /// </summary>
	public struct DeviceQueueCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public DeviceQueueCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:queueFamilyIndex is an unsigned integer indicating the index of the queue family to create on this device. This index corresponds to the index of an element of the pname:pQueueFamilyProperties array that was returned by fname:vkGetPhysicalDeviceQueueFamilyProperties.
		/// </para>
		/// </summary>
		public uint QueueFamilyIndex
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pQueuePriorities is an array of pname:queueCount normalized floating point values, specifying priorities of work that will be submitted to each created queue. See &lt;&lt;devsandqueues-priority,Queue Priority&gt;&gt; for more information.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created display mode object.
    /// </para>
    /// </summary>
	public struct DisplayModeCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use, and must: be zero.
		/// </para>
		/// </summary>
		public DisplayModeCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:parameters is a sname:VkDisplayModeParametersKHR structure describing the display parameters to use in creating the new mode. If the parameters are not compatible with the specified display, the implementation must: return ename:VK_ERROR_INITIALIZATION_FAILED.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure describing display mode properties.
    /// </para>
    /// </summary>
	public struct DisplayModeProperties
	{
	    /// <summary>
		/// <para>
		/// pname:displayMode is a handle to the display mode described in this structure.  This handle will be valid for the lifetime of the Vulkan instance.
		/// </para>
		/// </summary>
		public DisplayMode DisplayMode
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:parameters is a sname:VkDisplayModeParametersKHR structure describing the display parameters associated with pname:displayMode.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure describing display plane properties.
    /// </para>
    /// </summary>
	public struct DisplayPlaneProperties
	{
	    /// <summary>
		/// <para>
		/// pname:currentDisplay is the handle of the display the plane is currently associated with. If the plane is not currently attached to any displays, this will be sname:VK_NULL_HANDLE.
		/// </para>
		/// </summary>
		public Display CurrentDisplay
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:currentStackIndex is the current z-order of the plane. This will be between 0 and the value returned by fname:vkGetPhysicalDeviceDisplayPlanePropertiesKHR() in pname:pPropertyCount.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure describing parameters of a queue presentation to a swapchain.
    /// </para>
    /// </summary>
	public struct DisplayPresentInfo
	{
	    /// <summary>
		/// <para>
		/// pname:srcRect is a rectangular region of pixels to present. It must: be a subset of the image being presented. If sname:VkDisplayPresentInfoKHR is not specified, this region will be assumed to be the entire presentable image.
		/// </para>
		/// </summary>
		public Rect2D SourceRect
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dstRect is a rectangular region within the visible region of the swapchain's display mode. If sname:VkDisplayPresentInfoKHR is not specified, this region will be assumed to be the entire visible region of the visible region of the swapchain's mode. If the specified rectangle is a subset of the display mode's visible region, content from display planes below the swapchain's plane will be visible outside the rectangle. If there are no planes below the swapchain's, the area outside the specified rectangle will be black. If portions of the specified rectangle are outside of the display's visible region, pixels mapping only to those portions of the rectangle will be discarded.
		/// </para>
		/// </summary>
		public Rect2D DestinationRect
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:persistent: If this is ename:VK_TRUE, the display engine will enable buffered mode on displays that support it. This allows the display engine to stop sending content to the display until a new image is presented. The display will instead maintain a copy of the last presented image. This allows less power to be used, but may: increase presentation latency. If sname:VkDisplayPresentInfoKHR is not specified, persistent mode will not be used.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure describing an available display device.
    /// </para>
    /// </summary>
	public struct DisplayProperties
	{
	    /// <summary>
		/// <para>
		/// pname:display is a handle that is used to refer to the display described here. This handle will be valid for the lifetime of the Vulkan instance.
		/// </para>
		/// </summary>
		public Display Display
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:displayName is a pointer to a NULL-terminated string containing the name of the display. Generally, this will be the name provided by the display's EDID. It can: be `NULL` if no suitable name is available.
		/// </para>
		/// </summary>
		public string DisplayName
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:physicalDimensions describes the physical width and height of the visible portion of the display, in millimeters.
		/// </para>
		/// </summary>
		public Extent2D PhysicalDimensions
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:physicalResolution describes the physical, native, or preferred resolution of the display.
		/// </para>
		/// </summary>
		public Extent2D PhysicalResolution
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public SurfaceTransformFlags SupportedTransforms
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 PlaneReorderPossible
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created display plane surface object.
    /// </para>
    /// </summary>
	public struct DisplaySurfaceCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use, and must: be zero.
		/// </para>
		/// </summary>
		public DisplaySurfaceCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:displayMode is the mode to use when displaying this surface.
		/// </para>
		/// </summary>
		public DisplayMode DisplayMode
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:planeIndex is the plane on which this surface appears.
		/// </para>
		/// </summary>
		public uint PlaneIndex
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:planeStackIndex is the z-order of the plane.
		/// </para>
		/// </summary>
		public uint PlaneStackIndex
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:transform is the transform to apply to the images as part of the scanout operation.
		/// </para>
		/// </summary>
		public SurfaceTransformFlags Transform
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:globalAlpha is the global alpha value.  This value is ignored if pname:alphaMode is not ename:VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR.
		/// </para>
		/// </summary>
		public float GlobalAlpha
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:alphaMode is the type of alpha blending to use.
		/// </para>
		/// </summary>
		public DisplayPlaneAlphaFlags AlphaMode
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created event.
    /// </para>
    /// </summary>
	public struct EventCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
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
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public struct ExportMemoryAllocateInfo
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ExternalMemoryHandleTypeFlags HandleTypes
		{
			get;
			set;
		}

        internal unsafe Interop.ExportMemoryAllocateInfo Pack()
        {
            var result = new Interop.ExportMemoryAllocateInfo();
			result.SType = StructureType.ExportMemoryAllocateInfo;
			result.HandleTypes = this.HandleTypes;

            return result;
        }

		internal unsafe Interop.ExportMemoryAllocateInfo* MarshalTo()
        {
            return (Interop.ExportMemoryAllocateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Specify security attributes and access rights for Win32 memory handles.
    /// </para>
    /// <para>
    /// When slink:VkExportMemoryAllocateInfoNV::pname:handleTypes includes ename:VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV, add a sname:VkExportMemoryWin32HandleInfoNV to the pname:pNext chain of the slink:VkExportMemoryAllocateInfoNV structure to specify security attributes and access rights for the memory object's external handle.
    /// </para>
    /// </summary>
	public struct ExportMemoryWin32HandleInfo
	{
	    /// <summary>
		/// <para>
		/// pname:pAttributes is a pointer to a Windows sname:SECURITY_ATTRIBUTES structure specifying security attributes of the handle.
		/// </para>
		/// </summary>
		public SECURITY_ATTRIBUTES Attributes
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dwAccess is a basetype:DWORD specifying access rights of the handle.
		/// </para>
		/// </summary>
		public uint DwAccess
		{
			get;
			set;
		}

        internal unsafe Interop.ExportMemoryWin32HandleInfo Pack()
        {
            var result = new Interop.ExportMemoryWin32HandleInfo();
			result.SType = StructureType.ExportMemoryWin32HandleInfo;
			result.Attributes = (SECURITY_ATTRIBUTES*)Interop.HeapUtil.AllocateAndMarshal(this.Attributes);
			result.DwAccess = this.DwAccess;

            return result;
        }

		internal unsafe Interop.ExportMemoryWin32HandleInfo* MarshalTo()
        {
            return (Interop.ExportMemoryWin32HandleInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying a extension properties.
    /// </para>
    /// </summary>
	public struct ExtensionProperties
	{
	    /// <summary>
		/// <para>
		/// pname:extensionName is a null-terminated string specifying the name of the extension.
		/// </para>
		/// </summary>
		public string ExtensionName
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:specVersion is the version of this extension. It is an integer, incremented with backward compatible changes.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Specify that an image may be backed by external memory.
    /// </para>
    /// <para>
    /// If the pname:pNext list includes a sname:VkExternalMemoryImageCreateInfoNV structure, then that structure defines a set of external memory handle types that may: be used as backing store for the image.
    /// </para>
    /// </summary>
	public struct ExternalMemoryImageCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:handleTypes is a bitmask of elink:VkExternalMemoryHandleTypeFlagBitsNV specifying one or more external memory handle types. The types must: all be compatible with each other and the other image creation parameters, as reported by flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV.
		/// </para>
		/// </summary>
		public ExternalMemoryHandleTypeFlags HandleTypes
		{
			get;
			set;
		}

        internal unsafe Interop.ExternalMemoryImageCreateInfo Pack()
        {
            var result = new Interop.ExternalMemoryImageCreateInfo();
			result.SType = StructureType.ExternalMemoryImageCreateInfo;
			result.HandleTypes = this.HandleTypes;

            return result;
        }

		internal unsafe Interop.ExternalMemoryImageCreateInfo* MarshalTo()
        {
            return (Interop.ExternalMemoryImageCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created fence.
    /// </para>
    /// </summary>
	public struct FenceCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags defines the initial state and behavior of the fence. Bits which can: be set include: + --
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created framebuffer.
    /// </para>
    /// </summary>
	public struct FramebufferCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public FramebufferCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:renderPass is a render pass that defines what render passes the framebuffer will be compatible with. See &lt;&lt;renderpass-compatibility,Render Pass Compatibility&gt;&gt; for details.
		/// </para>
		/// </summary>
		public RenderPass RenderPass
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pAttachments is an array of sname:VkImageView handles, each of which will be used as the corresponding attachment in a render pass instance.
		/// </para>
		/// </summary>
		public ImageView[] Attachments
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:width, pname:height and pname:layers define the dimensions of the framebuffer.
		/// </para>
		/// </summary>
		public uint Width
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint Height
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created graphics pipeline.
    /// </para>
    /// </summary>
	public struct GraphicsPipelineCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is a bitmask of elink:VkPipelineCreateFlagBits controlling how the pipeline will be generated, as described below.
		/// </para>
		/// </summary>
		public PipelineCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pStages is an array of size pname:stageCount structures of type slink:VkPipelineShaderStageCreateInfo describing the set of the shader stages to be included in the graphics pipeline.
		/// </para>
		/// </summary>
		public PipelineShaderStageCreateInfo[] Stages
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pVertexInputState is a pointer to an instance of the slink:VkPipelineVertexInputStateCreateInfo structure.
		/// </para>
		/// </summary>
		public PipelineVertexInputStateCreateInfo? VertexInputState
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pInputAssemblyState is a pointer to an instance of the slink:VkPipelineInputAssemblyStateCreateInfo structure which determines input assembly behavior, as described in &lt;&lt;drawing, Drawing Commands&gt;&gt;.
		/// </para>
		/// </summary>
		public PipelineInputAssemblyStateCreateInfo? InputAssemblyState
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pTessellationState is a pointer to an instance of the slink:VkPipelineTessellationStateCreateInfo structure, or `NULL` if the pipeline does not include a tessellation control shader stage and tessellation evaluation shader stage.
		/// </para>
		/// </summary>
		public PipelineTessellationStateCreateInfo? TessellationState
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pViewportState is a pointer to an instance of the slink:VkPipelineViewportStateCreateInfo structure, or `NULL` if the pipeline has rasterization disabled.
		/// </para>
		/// </summary>
		public PipelineViewportStateCreateInfo? ViewportState
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pRasterizationState is a pointer to an instance of the slink:VkPipelineRasterizationStateCreateInfo structure.
		/// </para>
		/// </summary>
		public PipelineRasterizationStateCreateInfo? RasterizationState
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pMultisampleState is a pointer to an instance of the slink:VkPipelineMultisampleStateCreateInfo, or `NULL` if the pipeline has rasterization disabled.
		/// </para>
		/// </summary>
		public PipelineMultisampleStateCreateInfo? MultisampleState
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pDepthStencilState is a pointer to an instance of the slink:VkPipelineDepthStencilStateCreateInfo structure, or `NULL` if the pipeline has rasterization disabled or if the subpass of the render pass the pipeline is created against does not use a depth/stencil attachment.
		/// </para>
		/// </summary>
		public PipelineDepthStencilStateCreateInfo? DepthStencilState
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pColorBlendState is a pointer to an instance of the slink:VkPipelineColorBlendStateCreateInfo structure, or `NULL` if the pipeline has rasterization disabled or if the subpass of the render pass the pipeline is created against does not use any color attachments.
		/// </para>
		/// </summary>
		public PipelineColorBlendStateCreateInfo? ColorBlendState
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pDynamicState is a pointer to slink:VkPipelineDynamicStateCreateInfo and is used to indicate which properties of the pipeline state object are dynamic and can: be changed independently of the pipeline state. This can: be `NULL`, which means no state in the pipeline is considered dynamic.
		/// </para>
		/// </summary>
		public PipelineDynamicStateCreateInfo? DynamicState
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:layout is the description of binding locations used by both the pipeline and descriptor sets used with the pipeline.
		/// </para>
		/// </summary>
		public PipelineLayout Layout
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:renderPass is a handle to a render pass object describing the environment in which the pipeline will be used; the pipeline can: be used with an instance of any render pass compatible with the one provided. See &lt;&lt;renderpass-compatibility,Render Pass Compatibility&gt;&gt; for more information.
		/// </para>
		/// </summary>
		public RenderPass RenderPass
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:subpass is the index of the subpass in pname:renderPass where this pipeline will be used.
		/// </para>
		/// </summary>
		public uint Subpass
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:basePipelineHandle is a pipeline to derive from.
		/// </para>
		/// </summary>
		public Pipeline BasePipelineHandle
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:basePipelineIndex is an index into the pname:pCreateInfos parameter to use as a pipeline to derive from.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying an image blit operation.
    /// </para>
    /// </summary>
	public struct ImageBlit
	{
	    /// <summary>
		/// <para>
		/// pname:srcSubresource is the subresource to blit from.
		/// </para>
		/// </summary>
		public ImageSubresourceLayers SourceSubresource
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:srcOffsets is an array of two slink:VkOffset3D structures specifying the bounds of the source region within pname:srcSubresource.
		/// </para>
		/// </summary>
		public Offset3D[] SourceOffsets
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dstSubresource is the subresource to blit into.
		/// </para>
		/// </summary>
		public ImageSubresourceLayers DestinationSubresource
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dstOffsets is an array of two slink:VkOffset3D structures specifying the bounds of the destination region within pname:dstSubresource.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying the parameters of a newly created image object.
    /// </para>
    /// </summary>
	public struct ImageCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is a bitmask describing additional parameters of the image. See elink:VkImageCreateFlagBits below for a description of the supported bits.
		/// </para>
		/// </summary>
		public ImageCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:imageType is a elink:VkImageType specifying the basic dimensionality of the image, as described below. Layers in array textures do not count as a dimension for the purposes of the image type.
		/// </para>
		/// </summary>
		public ImageType ImageType
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:format is a elink:VkFormat describing the format and type of the data elements that will be contained in the image.
		/// </para>
		/// </summary>
		public Format Format
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:extent is a slink:VkExtent3D describing the number of data elements in each dimension of the base level.
		/// </para>
		/// </summary>
		public Extent3D Extent
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:mipLevels describes the number of levels of detail available for minified sampling of the image.
		/// </para>
		/// </summary>
		public uint MipLevels
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:arrayLayers is the number of layers in the image.
		/// </para>
		/// </summary>
		public uint ArrayLayers
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:samples is the number of sub-data element samples in the image as defined in elink:VkSampleCountFlagBits. See &lt;&lt;primsrast-multisampling,Multisampling&gt;&gt;.
		/// </para>
		/// </summary>
		public SampleCountFlags Samples
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:tiling is a elink:VkImageTiling specifying the tiling arrangement of the data elements in memory, as described below.
		/// </para>
		/// </summary>
		public ImageTiling Tiling
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:usage is a bitmask describing the intended usage of the image. See elink:VkImageUsageFlagBits below for a description of the supported bits.
		/// </para>
		/// </summary>
		public ImageUsageFlags Usage
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:sharingMode is the sharing mode of the image when it will be accessed by multiple queue families, and must: be one of the values described for elink:VkSharingMode in the &lt;&lt;resources-sharing,Resource Sharing&gt;&gt; section below.
		/// </para>
		/// </summary>
		public SharingMode SharingMode
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pQueueFamilyIndices is a list of queue families that will access this image (ignored if pname:sharingMode is not ename:VK_SHARING_MODE_CONCURRENT).
		/// </para>
		/// </summary>
		public uint[] QueueFamilyIndices
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:initialLayout selects the initial elink:VkImageLayout state of all image subresources of the image. See &lt;&lt;resources-image-layouts,Image Layouts&gt;&gt;. pname:initialLayout must: be ename:VK_IMAGE_LAYOUT_UNDEFINED or ename:VK_IMAGE_LAYOUT_PREINITIALIZED.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying the parameters of an image memory barrier.
    /// </para>
    /// </summary>
	public struct ImageMemoryBarrier
	{
	    /// <summary>
		/// <para>
		/// pname:srcAccessMask is a bitmask of the classes of memory accesses performed by the first set of commands that will participate in the dependency.
		/// </para>
		/// </summary>
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dstAccessMask is a bitmask of the classes of memory accesses performed by the second set of commands that will participate in the dependency.
		/// </para>
		/// </summary>
		public AccessFlags DestinationAccessMask
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:oldLayout describes the current layout of the image subresource(s).
		/// </para>
		/// </summary>
		public ImageLayout OldLayout
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:newLayout describes the new layout of the image subresource(s).
		/// </para>
		/// </summary>
		public ImageLayout NewLayout
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:srcQueueFamilyIndex is the queue family that is relinquishing ownership of the image subresource(s) to another queue, or ename:VK_QUEUE_FAMILY_IGNORED if there is no transfer of ownership).
		/// </para>
		/// </summary>
		public uint SourceQueueFamilyIndex
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dstQueueFamilyIndex is the queue family that is acquiring ownership of the image subresource(s) from another queue, or ename:VK_QUEUE_FAMILY_IGNORED if there is no transfer of ownership).
		/// </para>
		/// </summary>
		public uint DestinationQueueFamilyIndex
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:image is a handle to the image whose backing memory is affected by the barrier.
		/// </para>
		/// </summary>
		public Image Image
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:subresourceRange describes an area of the backing memory for pname:image (see &lt;&lt;resources-image-views&gt;&gt; for the description of sname:VkImageSubresourceRange), as well as the set of image subresources whose image layouts are modified.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created image view.
    /// </para>
    /// </summary>
	public struct ImageViewCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public ImageViewCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:image is a sname:VkImage on which the view will be created.
		/// </para>
		/// </summary>
		public Image Image
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:viewType is the type of the image view.
		/// </para>
		/// </summary>
		public ImageViewType ViewType
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:format is a elink:VkFormat describing the format and type used to interpret data elements in the image.
		/// </para>
		/// </summary>
		public Format Format
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:components specifies a remapping of color components (or of depth or stencil components after they have been converted into color components). See slink:VkComponentMapping.
		/// </para>
		/// </summary>
		public ComponentMapping Components
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:subresourceRange is a slink:VkImageSubresourceRange selecting the set of mipmap levels and array layers to be accessible to the view.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Import Win32 memory created on the same physical device.
    /// </para>
    /// <para>
    /// To import memory created on the same physical device but outside of the current Vulkan instance, add a slink:VkImportMemoryWin32HandleInfoNV structure to the pname:pNext chain of the slink:VkMemoryAllocateInfo structure, specifying a handle to and the type of the memory.
    /// </para>
    /// </summary>
	public struct ImportMemoryWin32HandleInfo
	{
	    /// <summary>
		/// <para>
		/// pname:handleType is 0 or a flag specifying the type of memory handle in pname:handle. Flags which may: be specified are: + --
		/// </para>
		/// </summary>
		public ExternalMemoryHandleTypeFlags HandleType
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public IntPtr Handle
		{
			get;
			set;
		}

        internal unsafe Interop.ImportMemoryWin32HandleInfo Pack()
        {
            var result = new Interop.ImportMemoryWin32HandleInfo();
			result.SType = StructureType.ImportMemoryWin32HandleInfo;
			result.HandleType = this.HandleType;
			result.Handle = this.Handle;

            return result;
        }

		internal unsafe Interop.ImportMemoryWin32HandleInfo* MarshalTo()
        {
            return (Interop.ImportMemoryWin32HandleInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created instance.
    /// </para>
    /// </summary>
	public struct InstanceCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public InstanceCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pApplicationInfo is `NULL` or a pointer to an instance of sname:VkApplicationInfo. If not `NULL`, this information helps implementations recognize behavior inherent to classes of applications. slink:VkApplicationInfo is defined in detail below.
		/// </para>
		/// </summary>
		public ApplicationInfo? ApplicationInfo
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:ppEnabledLayerNames is a pointer to an array of pname:enabledLayerCount null-terminated UTF-8 strings containing the names of layers to enable for the created instance. See the &lt;&lt;extended-functionality-layers,Layers&gt;&gt; section for further details.
		/// </para>
		/// </summary>
		public string[] EnabledLayerNames
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:ppEnabledExtensionNames is a pointer to an array of pname:enabledExtensionCount null-terminated UTF-8 strings containing the names of extensions to enable.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying layer properties.
    /// </para>
    /// </summary>
	public struct LayerProperties
	{
	    /// <summary>
		/// <para>
		/// pname:layerName is a null-terminated UTF-8 string specifying the name of the layer. Use this name in the pname:ppEnabledLayerNames array passed in the slink:VkInstanceCreateInfo structure to enable this layer for an instance.
		/// </para>
		/// </summary>
		public string LayerName
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:specVersion is the Vulkan version the layer was written to, encoded as described in the &lt;&lt;fundamentals-versionnum,API Version Numbers and Semantics&gt;&gt; section.
		/// </para>
		/// </summary>
		public Version SpecVersion
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:implementationVersion is the version of this layer. It is an integer, increasing with backward compatible changes.
		/// </para>
		/// </summary>
		public Version ImplementationVersion
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:description is a null-terminated UTF-8 string providing additional details that can: be used by the application to identify the layer.
		/// </para>
		/// </summary>
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
    /// </summary>
	public struct MappedMemoryRange
	{
	    /// <summary>
		/// <para>
		/// pname:memory is the memory object to which this range belongs.
		/// </para>
		/// </summary>
		public DeviceMemory Memory
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:offset is the zero-based byte offset from the beginning of the memory object.
		/// </para>
		/// </summary>
		public ulong Offset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:size is either the size of range, or ename:VK_WHOLE_SIZE to affect the range from pname:offset to the end of the current mapping of the allocation.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure containing parameters of a memory allocation.
    /// </para>
    /// </summary>
	public struct MemoryAllocateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:allocationSize is the size of the allocation in bytes
		/// </para>
		/// </summary>
		public ulong AllocationSize
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:memoryTypeIndex is the memory type index, which selects the properties of the memory to be allocated, as well as the heap the memory will come from.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying a memory barrier.
    /// </para>
    /// </summary>
	public struct MemoryBarrier
	{
	    /// <summary>
		/// <para>
		/// pname:srcAccessMask is a bitmask of the classes of memory accesses performed by the first set of commands that will participate in the dependency.
		/// </para>
		/// </summary>
		public AccessFlags SourceAccessMask
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dstAccessMask is a bitmask of the classes of memory accesses performed by the second set of commands that will participate in the dependency.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created Mir surface object.
    /// </para>
    /// </summary>
	public struct MirSurfaceCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public MirSurfaceCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:connection and pname:surface are pointers to the MirConnection and MirSurface for the window to associate the surface with.
		/// </para>
		/// </summary>
		public IntPtr Connection
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure.
    /// </para>
    /// </summary>
	public struct PhysicalDeviceLimits
	{
	    /// <summary>
		/// <para>
		/// [[features-limits-maxImageDimension1D]] pname:maxImageDimension1D is the maximum dimension (pname:width) of an image created with an pname:imageType of ename:VK_IMAGE_TYPE_1D.
		/// </para>
		/// </summary>
		public uint MaxImageDimension1D
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxImageDimension2D]] pname:maxImageDimension2D is the maximum dimension (pname:width or pname:height) of an image created with an pname:imageType of ename:VK_IMAGE_TYPE_2D and without ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT set in pname:flags.
		/// </para>
		/// </summary>
		public uint MaxImageDimension2D
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxImageDimension3D]] pname:maxImageDimension3D is the maximum dimension (pname:width, pname:height, or pname:depth) of an image created with an pname:imageType of ename:VK_IMAGE_TYPE_3D.
		/// </para>
		/// </summary>
		public uint MaxImageDimension3D
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxImageDimensionCube]] pname:maxImageDimensionCube is the maximum dimension (pname:width or pname:height) of an image created with an pname:imageType of ename:VK_IMAGE_TYPE_2D and with ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT set in pname:flags.
		/// </para>
		/// </summary>
		public uint MaxImageDimensionCube
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxImageArrayLayers]] pname:maxImageArrayLayers is the maximum number of layers (pname:arrayLayers) for an image.
		/// </para>
		/// </summary>
		public uint MaxImageArrayLayers
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxTexelBufferElements]] pname:maxTexelBufferElements is the maximum number of addressable texels for a buffer view created on a buffer which was created with the ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set in the pname:usage member of the sname:VkBufferCreateInfo structure.
		/// </para>
		/// </summary>
		public uint MaxTexelBufferElements
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxUniformBufferRange]] pname:maxUniformBufferRange is the maximum value that can: be specified in the pname:range member of any slink:VkDescriptorBufferInfo structures passed to a call to flink:vkUpdateDescriptorSets for descriptors of type ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC.
		/// </para>
		/// </summary>
		public uint MaxUniformBufferRange
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxStorageBufferRange]] pname:maxStorageBufferRange is the maximum value that can: be specified in the pname:range member of any slink:VkDescriptorBufferInfo structures passed to a call to flink:vkUpdateDescriptorSets for descriptors of type ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC.
		/// </para>
		/// </summary>
		public uint MaxStorageBufferRange
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxPushConstantsSize]] pname:maxPushConstantsSize is the maximum size, in bytes, of the pool of push constant memory. For each of the push constant ranges indicated by the pname:pPushConstantRanges member of the sname:VkPipelineLayoutCreateInfo structure, pname:offset + pname:size must: be less than or equal to this limit.
		/// </para>
		/// </summary>
		public uint MaxPushConstantsSize
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxMemoryAllocationCount]] pname:maxMemoryAllocationCount is the maximum number of device memory allocations, as created by flink:vkAllocateMemory, which can: simultaneously exist.
		/// </para>
		/// </summary>
		public uint MaxMemoryAllocationCount
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxSamplerAllocationCount]] pname:maxSamplerAllocationCount is the maximum number of sampler objects, as created by flink:vkCreateSampler, which can: simultaneously exist on a device.
		/// </para>
		/// </summary>
		public uint MaxSamplerAllocationCount
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-bufferImageGranularity]] pname:bufferImageGranularity is the granularity, in bytes, at which buffer or linear image resources, and optimal image resources can: be bound to adjacent offsets in the same sname:VkDeviceMemory object without aliasing. See &lt;&lt;resources-bufferimagegranularity,Buffer-Image Granularity&gt;&gt; for more details.
		/// </para>
		/// </summary>
		public ulong BufferImageGranularity
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-sparseAddressSpaceSize]] pname:sparseAddressSpaceSize is the total amount of address space available, in bytes, for sparse memory resources. This is an upper bound on the sum of the size of all sparse resources, regardless of whether any memory is bound to them.
		/// </para>
		/// </summary>
		public ulong SparseAddressSpaceSize
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxBoundDescriptorSets]] pname:maxBoundDescriptorSets is the maximum number of descriptor sets that can: be simultaneously used by a pipeline. All code:DescriptorSet decorations in shader modules must: have a value less than pname:maxBoundDescriptorSets. See &lt;&lt;descriptorsets-sets&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxBoundDescriptorSets
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxPerStageDescriptorSamplers]] pname:maxPerStageDescriptorSamplers is the maximum number of samplers that can: be accessible to a single shader stage in a pipeline layout. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_SAMPLER or ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER count against this limit. A descriptor is accessible to a shader stage when the pname:stageFlags member of the sname:VkDescriptorSetLayoutBinding structure has the bit for that shader stage set. See &lt;&lt;descriptorsets-sampler&gt;&gt; and &lt;&lt;descriptorsets-combinedimagesampler&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxPerStageDescriptorSamplers
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxPerStageDescriptorUniformBuffers]] pname:maxPerStageDescriptorUniformBuffers is the maximum number of uniform buffers that can: be accessible to a single shader stage in a pipeline layout. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this limit. A descriptor is accessible to a shader stage when the pname:stageFlags member of the sname:VkDescriptorSetLayoutBinding structure has the bit for that shader stage set. See &lt;&lt;descriptorsets-uniformbuffer&gt;&gt; and &lt;&lt;descriptorsets-uniformbufferdynamic&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxPerStageDescriptorUniformBuffers
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxPerStageDescriptorStorageBuffers]] pname:maxPerStageDescriptorStorageBuffers is the maximum number of storage buffers that can: be accessible to a single shader stage in a pipeline layout. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this limit. A descriptor is accessible to a pipeline shader stage when the pname:stageFlags member of the sname:VkDescriptorSetLayoutBinding structure has the bit for that shader stage set. See &lt;&lt;descriptorsets-storagebuffer&gt;&gt; and &lt;&lt;descriptorsets-storagebufferdynamic&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxPerStageDescriptorStorageBuffers
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxPerStageDescriptorSampledImages]] pname:maxPerStageDescriptorSampledImages is the maximum number of sampled images that can: be accessible to a single shader stage in a pipeline layout. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, or ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER count against this limit. A descriptor is accessible to a pipeline shader stage when the pname:stageFlags member of the sname:VkDescriptorSetLayoutBinding structure has the bit for that shader stage set. See &lt;&lt;descriptorsets-combinedimagesampler&gt;&gt;, &lt;&lt;descriptorsets-sampledimage&gt;&gt;, and &lt;&lt;descriptorsets-uniformtexelbuffer&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxPerStageDescriptorSampledImages
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxPerStageDescriptorStorageImages]] pname:maxPerStageDescriptorStorageImages is the maximum number of storage images that can: be accessible to a single shader stage in a pipeline layout. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER count against this limit. A descriptor is accessible to a pipeline shader stage when the pname:stageFlags member of the sname:VkDescriptorSetLayoutBinding structure has the bit for that shader stage set. See &lt;&lt;descriptorsets-storageimage&gt;&gt;, and &lt;&lt;descriptorsets-storagetexelbuffer&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxPerStageDescriptorStorageImages
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxPerStageDescriptorInputAttachments]] pname:maxPerStageDescriptorInputAttachments is the maximum number of input attachments that can: be accessible to a single shader stage in a pipeline layout. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT count against this limit. A descriptor is accessible to a pipeline shader stage when the pname:stageFlags member of the sname:VkDescriptorSetLayoutBinding structure has the bit for that shader stage set. These are only supported for the fragment stage. See &lt;&lt;descriptorsets-inputattachment&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxPerStageDescriptorInputAttachments
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxPerStageResources]] pname:maxPerStageResources is the maximum number of resources that can: be accessible to a single shader stage in a pipeline layout. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER, ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER, ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER, ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER, ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, or ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT count against this limit. For the fragment shader stage the framebuffer color attachments also count against this limit.
		/// </para>
		/// </summary>
		public uint MaxPerStageResources
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxDescriptorSetSamplers]] pname:maxDescriptorSetSamplers is the maximum number of samplers that can: be included in descriptor bindings in a pipeline layout across all pipeline shader stages and descriptor set numbers. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_SAMPLER or ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER count against this limit. See &lt;&lt;descriptorsets-sampler&gt;&gt; and &lt;&lt;descriptorsets-combinedimagesampler&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxDescriptorSetSamplers
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxDescriptorSetUniformBuffers]] pname:maxDescriptorSetUniformBuffers is the maximum number of uniform buffers that can: be included in descriptor bindings in a pipeline layout across all pipeline shader stages and descriptor set numbers. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this limit. See &lt;&lt;descriptorsets-uniformbuffer&gt;&gt; and &lt;&lt;descriptorsets-uniformbufferdynamic&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxDescriptorSetUniformBuffers
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxDescriptorSetUniformBuffersDynamic]] pname:maxDescriptorSetUniformBuffersDynamic is the maximum number of dynamic uniform buffers that can: be included in descriptor bindings in a pipeline layout across all pipeline shader stages and descriptor set numbers. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this limit. See &lt;&lt;descriptorsets-uniformbufferdynamic&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxDescriptorSetUniformBuffersDynamic
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxDescriptorSetStorageBuffers]] pname:maxDescriptorSetStorageBuffers is the maximum number of storage buffers that can: be included in descriptor bindings in a pipeline layout across all pipeline shader stages and descriptor set numbers. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this limit. See &lt;&lt;descriptorsets-storagebuffer&gt;&gt; and &lt;&lt;descriptorsets-storagebufferdynamic&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxDescriptorSetStorageBuffers
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxDescriptorSetStorageBuffersDynamic]] pname:maxDescriptorSetStorageBuffersDynamic is the maximum number of dynamic storage buffers that can: be included in descriptor bindings in a pipeline layout across all pipeline shader stages and descriptor set numbers. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this limit. See &lt;&lt;descriptorsets-storagebufferdynamic&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxDescriptorSetStorageBuffersDynamic
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxDescriptorSetSampledImages]] pname:maxDescriptorSetSampledImages is the maximum number of sampled images that can: be included in descriptor bindings in a pipeline layout across all pipeline shader stages and descriptor set numbers. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, or ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER count against this limit. See &lt;&lt;descriptorsets-combinedimagesampler&gt;&gt;, &lt;&lt;descriptorsets-sampledimage&gt;&gt;, and &lt;&lt;descriptorsets-uniformtexelbuffer&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxDescriptorSetSampledImages
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxDescriptorSetStorageImages]] pname:maxDescriptorSetStorageImages is the maximum number of storage images that can: be included in descriptor bindings in a pipeline layout across all pipeline shader stages and descriptor set numbers. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER count against this limit. See &lt;&lt;descriptorsets-storageimage&gt;&gt;, and &lt;&lt;descriptorsets-storagetexelbuffer&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxDescriptorSetStorageImages
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxDescriptorSetInputAttachments]] pname:maxDescriptorSetInputAttachments is the maximum number of input attachments that can: be included in descriptor bindings in a pipeline layout across all pipeline shader stages and descriptor set numbers. Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT count against this limit. See &lt;&lt;descriptorsets-inputattachment&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxDescriptorSetInputAttachments
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxVertexInputAttributes]] pname:maxVertexInputAttributes is the maximum number of vertex input attributes that can: be specified for a graphics pipeline. These are described in the array of sname:VkVertexInputAttributeDescription structures that are provided at graphics pipeline creation time via the pname:pVertexAttributeDescriptions member of the sname:VkPipelineVertexInputStateCreateInfo structure. See &lt;&lt;fxvertex-attrib&gt;&gt; and &lt;&lt;fxvertex-input&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxVertexInputAttributes
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxVertexInputBindings]] pname:maxVertexInputBindings is the maximum number of vertex buffers that can: be specified for providing vertex attributes to a graphics pipeline. These are described in the array of sname:VkVertexInputBindingDescription structures that are provided at graphics pipeline creation time via the pname:pVertexBindingDescriptions member of the sname:VkPipelineVertexInputStateCreateInfo structure. The pname:binding member of sname:VkVertexInputBindingDescription must: be less than this limit. See &lt;&lt;fxvertex-input&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxVertexInputBindings
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxVertexInputAttributeOffset]] pname:maxVertexInputAttributeOffset is the maximum vertex input attribute offset that can: be added to the vertex input binding stride. The pname:offset member of the sname:VkVertexInputAttributeDescription structure must: be less than or equal to this limit. See &lt;&lt;fxvertex-input&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxVertexInputAttributeOffset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxVertexInputBindingStride]] pname:maxVertexInputBindingStride is the maximum vertex input binding stride that can: be specified in a vertex input binding. The pname:stride member of the sname:VkVertexInputBindingDescription structure must: be less than or equal to this limit. See &lt;&lt;fxvertex-input&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxVertexInputBindingStride
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxVertexOutputComponents]] pname:maxVertexOutputComponents is the maximum number of components of output variables which can: be output by a vertex shader. See &lt;&lt;shaders-vertex&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxVertexOutputComponents
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxTessellationGenerationLevel]] pname:maxTessellationGenerationLevel is the maximum tessellation generation level supported by the fixed-function tessellation primitive generator. See &lt;&lt;tessellation&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxTessellationGenerationLevel
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxTessellationPatchSize]] pname:maxTessellationPatchSize is the maximum patch size, in vertices, of patches that can: be processed by the tessellation control shader and tessellation primitive generator. The pname:patchControlPoints member of the sname:VkPipelineTessellationStateCreateInfo structure specified at pipeline creation time and the value provided in the code:OutputVertices execution mode of shader modules must: be less than or equal to this limit. See &lt;&lt;tessellation&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxTessellationPatchSize
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxTessellationControlPerVertexInputComponents]] pname:maxTessellationControlPerVertexInputComponents is the maximum number of components of input variables which can: be provided as per-vertex inputs to the tessellation control shader stage.
		/// </para>
		/// </summary>
		public uint MaxTessellationControlPerVertexInputComponents
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxTessellationControlPerVertexOutputComponents]] pname:maxTessellationControlPerVertexOutputComponents is the maximum number of components of per-vertex output variables which can: be output from the tessellation control shader stage.
		/// </para>
		/// </summary>
		public uint MaxTessellationControlPerVertexOutputComponents
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxTessellationControlPerPatchOutputComponents]] pname:maxTessellationControlPerPatchOutputComponents is the maximum number of components of per-patch output variables which can: be output from the tessellation control shader stage.
		/// </para>
		/// </summary>
		public uint MaxTessellationControlPerPatchOutputComponents
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxTessellationControlTotalOutputComponents]] pname:maxTessellationControlTotalOutputComponents is the maximum total number of components of per-vertex and per-patch output variables which can: be output from the tessellation control shader stage.
		/// </para>
		/// </summary>
		public uint MaxTessellationControlTotalOutputComponents
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxTessellationEvaluationInputComponents]] pname:maxTessellationEvaluationInputComponents is the maximum number of components of input variables which can: be provided as per-vertex inputs to the tessellation evaluation shader stage.
		/// </para>
		/// </summary>
		public uint MaxTessellationEvaluationInputComponents
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxTessellationEvaluationOutputComponents]] pname:maxTessellationEvaluationOutputComponents is the maximum number of components of per-vertex output variables which can: be output from the tessellation evaluation shader stage.
		/// </para>
		/// </summary>
		public uint MaxTessellationEvaluationOutputComponents
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxGeometryShaderInvocations]] pname:maxGeometryShaderInvocations is the maximum invocation count supported for instanced geometry shaders. The value provided in the code:Invocations execution mode of shader modules must: be less than or equal to this limit. See &lt;&lt;geometry&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxGeometryShaderInvocations
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxGeometryInputComponents]] pname:maxGeometryInputComponents is the maximum number of components of input variables which can: be provided as inputs to the geometry shader stage.
		/// </para>
		/// </summary>
		public uint MaxGeometryInputComponents
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxGeometryOutputComponents]] pname:maxGeometryOutputComponents is the maximum number of components of output variables which can: be output from the geometry shader stage.
		/// </para>
		/// </summary>
		public uint MaxGeometryOutputComponents
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxGeometryOutputVertices]] pname:maxGeometryOutputVertices is the maximum number of vertices which can: be emitted by any geometry shader.
		/// </para>
		/// </summary>
		public uint MaxGeometryOutputVertices
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxGeometryTotalOutputComponents]] pname:maxGeometryTotalOutputComponents is the maximum total number of components of output, across all emitted vertices, which can: be output from the geometry shader stage.
		/// </para>
		/// </summary>
		public uint MaxGeometryTotalOutputComponents
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxFragmentInputComponents]] pname:maxFragmentInputComponents is the maximum number of components of input variables which can: be provided as inputs to the fragment shader stage.
		/// </para>
		/// </summary>
		public uint MaxFragmentInputComponents
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxFragmentOutputAttachments]] pname:maxFragmentOutputAttachments is the maximum number of output attachments which can: be written to by the fragment shader stage.
		/// </para>
		/// </summary>
		public uint MaxFragmentOutputAttachments
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxFragmentDualSrcAttachments]] pname:maxFragmentDualSrcAttachments is the maximum number of output attachments which can: be written to by the fragment shader stage when blending is enabled and one of the dual source blend modes is in use. See &lt;&lt;framebuffer-dsb&gt;&gt; and &lt;&lt;features-features-dualSrcBlend,dualSrcBlend&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxFragmentDualSourceAttachments
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxFragmentCombinedOutputResources]] pname:maxFragmentCombinedOutputResources is the total number of storage buffers, storage images, and output buffers which can: be used in the fragment shader stage.
		/// </para>
		/// </summary>
		public uint MaxFragmentCombinedOutputResources
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxComputeSharedMemorySize]] pname:maxComputeSharedMemorySize is the maximum total storage size, in bytes, of all variables declared with the code:WorkgroupLocal storage class in shader modules (or with the code:shared storage qualifier in GLSL) in the compute shader stage.
		/// </para>
		/// </summary>
		public uint MaxComputeSharedMemorySize
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxComputeWorkGroupCount]] pname:maxComputeWorkGroupCount[3] is the maximum number of local workgroups that can: be dispatched by a single dispatch command. These three values represent the maximum number of local workgroups for the X, Y, and Z dimensions, respectively. The pname:x, pname:y, and pname:z parameters to the flink:vkCmdDispatch command, or members of the slink:VkDispatchIndirectCommand structure must: be less than or equal to the corresponding limit. See &lt;&lt;dispatch&gt;&gt;.
		/// </para>
		/// </summary>
		public uint[] MaxComputeWorkGroupCount
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxComputeWorkGroupInvocations]] pname:maxComputeWorkGroupInvocations is the maximum total number of compute shader invocations in a single local workgroup. The product of the X, Y, and Z sizes as specified by the code:LocalSize execution mode in shader modules and by the object decorated by the code:WorkgroupSize decoration must: be less than or equal to this limit.
		/// </para>
		/// </summary>
		public uint MaxComputeWorkGroupInvocations
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxComputeWorkGroupSize]] pname:maxComputeWorkGroupSize[3] is the maximum size of a local compute workgroup, per dimension. These three values represent the maximum local workgroup size in the X, Y, and Z dimensions, respectively. The pname:x, pname:y, and pname:z sizes specified by the code:LocalSize execution mode and by the object decorated by the code:WorkgroupSize decoration in shader modules must: be less than or equal to the corresponding limit.
		/// </para>
		/// </summary>
		public uint[] MaxComputeWorkGroupSize
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-subPixelPrecisionBits]] pname:subPixelPrecisionBits is the number of bits of subpixel precision in framebuffer coordinates latexmath:[$x_f$] and latexmath:[$y_f$]. See &lt;&lt;primsrast&gt;&gt;.
		/// </para>
		/// </summary>
		public uint SubPixelPrecisionBits
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-subTexelPrecisionBits]] pname:subTexelPrecisionBits is the number of bits of precision in the division along an axis of an image used for minification and magnification filters. latexmath:[$2^\mathit{subTexelPrecisionBits}$] is the actual number of divisions along each axis of the image represented. The filtering hardware will snap to these locations when computing the filtered results.
		/// </para>
		/// </summary>
		public uint SubTexelPrecisionBits
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-mipmapPrecisionBits]] pname:mipmapPrecisionBits is the number of bits of division that the LOD calculation for mipmap fetching get snapped to when determining the contribution from each mip level to the mip filtered results. latexmath:[$2^\mathit{mipmapPrecisionBits}$] is the actual number of divisions. + -- [NOTE] .Note ==== For example, if this value is 2 bits then when linearly filtering between two levels, each level could: contribute: 0%, 33%, 66%, or 100% (this is just an example and the amount of contribution should: be covered by different equations in the spec). ==== -- +
		/// </para>
		/// </summary>
		public uint MipmapPrecisionBits
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxDrawIndexedIndexValue]] pname:maxDrawIndexedIndexValue is the maximum index value that can: be used for indexed draw calls when using 32-bit indices. This excludes the primitive restart index value of 0xFFFFFFFF. See &lt;&lt;features-features-fullDrawIndexUint32,fullDrawIndexUint32&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxDrawIndexedIndexValue
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxDrawIndirectCount]] pname:maxDrawIndirectCount is the maximum draw count that is supported for indirect draw calls. See &lt;&lt;features-features-multiDrawIndirect,multiDrawIndirect&gt;&gt;.
		/// </para>
		/// </summary>
		public uint MaxDrawIndirectCount
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxSamplerLodBias]] pname:maxSamplerLodBias is the maximum absolute sampler level of detail bias. The sum of the pname:mipLodBias member of the sname:VkSamplerCreateInfo structure and the code:Bias operand of image sampling operations in shader modules (or 0 if no code:Bias operand is provided to an image sampling operation) are clamped to the range latexmath:[$[-\mathit{maxSamplerLodBias},+\mathit{maxSamplerLodBias}\]$]. See &lt;&lt;samplers-mipLodBias&gt;&gt;.
		/// </para>
		/// </summary>
		public float MaxSamplerLodBias
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxSamplerAnisotropy]] pname:maxSamplerAnisotropy is the maximum degree of sampler anisotropy. The maximum degree of anisotropic filtering used for an image sampling operation is the minimum of the pname:maxAnisotropy member of the sname:VkSamplerCreateInfo structure and this limit. See &lt;&lt;samplers-maxAnisotropy&gt;&gt;.
		/// </para>
		/// </summary>
		public float MaxSamplerAnisotropy
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxViewports]] pname:maxViewports is the maximum number of active viewports. The pname:viewportCount member of the sname:VkPipelineViewportStateCreateInfo structure that is provided at pipeline creation must: be less than or equal to this limit.
		/// </para>
		/// </summary>
		public uint MaxViewports
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxViewportDimensions]] pname:maxViewportDimensions[2] are the maximum viewport dimensions in the X (width) and Y (height) dimensions, respectively. The maximum viewport dimensions must: be greater than or equal to the largest image which can: be created and used as a framebuffer attachment. See &lt;&lt;vertexpostproc-viewport,Controlling the Viewport&gt;&gt;.
		/// </para>
		/// </summary>
		public uint[] MaxViewportDimensions
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-viewportboundsrange]] pname:viewportBoundsRange[2] is the latexmath:[$[\mathit{minimum},\mathit{maximum}\]$] range that the corners of a viewport must: be contained in. This range must: be at least latexmath:[$[- 2 \times \mathit{maxViewportDimensions}, 2 \times \mathit{maxViewportDimensions} - 1\]$]. See &lt;&lt;vertexpostproc-viewport,Controlling the Viewport&gt;&gt;. + -- [NOTE] .Note ==== The intent of the pname:viewportBoundsRange limit is to allow a maximum sized viewport to be arbitrarily shifted relative to the output target as long as at least some portion intersects. This would give a bounds limit of latexmath:[$[- \mathit{maxViewportDimensions}+1, 2 \times \mathit{maxViewportDimensions} -1\]$] which would allow all possible non-empty-set intersections of the output target and the viewport. Since these numbers are typically powers of two, picking the signed number range using the smallest possible number of bits ends up with the specified range. ==== --
		/// </para>
		/// </summary>
		public float[] ViewportBoundsRange
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-viewportSubPixelBits]] pname:viewportSubPixelBits is the number of bits of subpixel precision for viewport bounds. The subpixel precision that floating-point viewport bounds are interpreted at is given by this limit.
		/// </para>
		/// </summary>
		public uint ViewportSubPixelBits
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-minMemoryMapAlignment]] pname:minMemoryMapAlignment is the minimum required alignment, in bytes, of host visible memory allocations within the host address space. When mapping a memory allocation with flink:vkMapMemory, subtracting pname:offset bytes from the returned pointer will always produce an integer multiple of this limit. See &lt;&lt;memory-device-hostaccess&gt;&gt;.
		/// </para>
		/// </summary>
		public Size MinMemoryMapAlignment
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-minTexelBufferOffsetAlignment]] pname:minTexelBufferOffsetAlignment is the minimum required alignment, in bytes, for the pname:offset member of the sname:VkBufferViewCreateInfo structure for texel buffers. When a buffer view is created for a buffer which was created with ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set in the pname:usage member of the sname:VkBufferCreateInfo structure, the pname:offset must: be an integer multiple of this limit.
		/// </para>
		/// </summary>
		public ulong MinTexelBufferOffsetAlignment
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-minUniformBufferOffsetAlignment]] pname:minUniformBufferOffsetAlignment is the minimum required alignment, in bytes, for the pname:offset member of the sname:VkDescriptorBufferInfo structure for uniform buffers. When a descriptor of type ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC is updated, the pname:offset must: be an integer multiple of this limit. Similarly, dynamic offsets for uniform buffers must: be multiples of this limit.
		/// </para>
		/// </summary>
		public ulong MinUniformBufferOffsetAlignment
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-minStorageBufferOffsetAlignment]] pname:minStorageBufferOffsetAlignment is the minimum required alignment, in bytes, for the pname:offset member of the sname:VkDescriptorBufferInfo structure for storage buffers. When a descriptor of type ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC is updated, the pname:offset must: be an integer multiple of this limit. Similarly, dynamic offsets for storage buffers must: be multiples of this limit.
		/// </para>
		/// </summary>
		public ulong MinStorageBufferOffsetAlignment
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-minTexelOffset]] pname:minTexelOffset is the minimum offset value for the code:ConstOffset image operand of any of the code:OpImageSample* or code:OpImageFetch* image instructions.
		/// </para>
		/// </summary>
		public int MinTexelOffset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxTexelOffset]] pname:maxTexelOffset is the maximum offset value for the code:ConstOffset image operand of any of the code:OpImageSample* or code:OpImageFetch* image instructions.
		/// </para>
		/// </summary>
		public uint MaxTexelOffset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-minTexelGatherOffset]] pname:minTexelGatherOffset is the minimum offset value for the code:Offset or code:ConstOffsets image operands of any of the code:OpImage*code:Gather image instructions.
		/// </para>
		/// </summary>
		public int MinTexelGatherOffset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxTexelGatherOffset]] pname:maxTexelGatherOffset is the maximum offset value for the code:Offset or code:ConstOffsets image operands of any of the code:OpImage*code:Gather image instructions.
		/// </para>
		/// </summary>
		public uint MaxTexelGatherOffset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-minInterpolationOffset]] pname:minInterpolationOffset is the minimum negative offset value for the code:offset operand of the code:InterpolateAtOffset extended instruction.
		/// </para>
		/// </summary>
		public float MinInterpolationOffset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxInterpolationOffset]] pname:maxInterpolationOffset is the maximum positive offset value for the code:offset operand of the code:InterpolateAtOffset extended instruction.
		/// </para>
		/// </summary>
		public float MaxInterpolationOffset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-subPixelInterpolationOffsetBits]] pname:subPixelInterpolationOffsetBits is the number of subpixel fractional bits that the code:x and code:y offsets to the code:InterpolateAtOffset extended instruction may: be rounded to as fixed-point values.
		/// </para>
		/// </summary>
		public uint SubPixelInterpolationOffsetBits
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxFramebufferWidth]] pname:maxFramebufferWidth is the maximum width for a framebuffer. The pname:width member of the sname:VkFramebufferCreateInfo structure must: be less than or equal to this limit.
		/// </para>
		/// </summary>
		public uint MaxFramebufferWidth
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxFramebufferHeight]] pname:maxFramebufferHeight is the maximum height for a framebuffer. The pname:height member of the sname:VkFramebufferCreateInfo structure must: be less than or equal to this limit.
		/// </para>
		/// </summary>
		public uint MaxFramebufferHeight
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxFramebufferLayers]] pname:maxFramebufferLayers is the maximum layer count for a layered framebuffer. The pname:layers member of the sname:VkFramebufferCreateInfo structure must: be less than or equal to this limit.
		/// </para>
		/// </summary>
		public uint MaxFramebufferLayers
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-framebufferColorSampleCounts]] pname:framebufferColorSampleCounts is a bitmask^1^ of elink:VkSampleCountFlagBits bits indicating the color sample counts that are supported for all framebuffer color attachments.
		/// </para>
		/// </summary>
		public SampleCountFlags FramebufferColorSampleCounts
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-framebufferDepthSampleCounts]] pname:framebufferDepthSampleCounts is a bitmask^1^ of elink:VkSampleCountFlagBits bits indicating the supported depth sample counts for all framebuffer depth/stencil attachments, when the format includes a depth component.
		/// </para>
		/// </summary>
		public SampleCountFlags FramebufferDepthSampleCounts
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:framebufferStencilSampleCounts is a bitmask^1^ of elink:VkSampleCountFlagBits bits indicating the supported stencil sample counts for all framebuffer depth/stencil attachments, when the format includes a stencil component.
		/// </para>
		/// </summary>
		public SampleCountFlags FramebufferStencilSampleCounts
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:framebufferNoAttachmentsSampleCounts is a bitmask^1^ of elink:VkSampleCountFlagBits bits indicating the supported sample counts for a framebuffer with no attachments.
		/// </para>
		/// </summary>
		public SampleCountFlags FramebufferNoAttachmentsSampleCounts
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxColorAttachments]] pname:maxColorAttachments is the maximum number of color attachments that can: be used by a subpass in a render pass. The pname:colorAttachmentCount member of the sname:VkSubpassDescription structure must: be less than or equal to this limit.
		/// </para>
		/// </summary>
		public uint MaxColorAttachments
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-sampledImageColorSampleCounts]] pname:sampledImageColorSampleCounts is a bitmask^1^ of elink:VkSampleCountFlagBits bits indicating the sample counts supported for all 2D images created with ename:VK_IMAGE_TILING_OPTIMAL, pname:usage containing ename:VK_IMAGE_USAGE_SAMPLED_BIT, and a non-integer color format.
		/// </para>
		/// </summary>
		public SampleCountFlags SampledImageColorSampleCounts
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-sampledImageIntegerSampleCounts]] pname:sampledImageIntegerSampleCounts is a bitmask^1^ of elink:VkSampleCountFlagBits bits indicating the sample counts supported for all 2D images created with ename:VK_IMAGE_TILING_OPTIMAL, pname:usage containing ename:VK_IMAGE_USAGE_SAMPLED_BIT, and an integer color format.
		/// </para>
		/// </summary>
		public SampleCountFlags SampledImageIntegerSampleCounts
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-sampledImageDepthSampleCounts]] pname:sampledImageDepthSampleCounts is a bitmask^1^ of elink:VkSampleCountFlagBits bits indicating the sample counts supported for all 2D images created with ename:VK_IMAGE_TILING_OPTIMAL, pname:usage containing ename:VK_IMAGE_USAGE_SAMPLED_BIT, and a depth format.
		/// </para>
		/// </summary>
		public SampleCountFlags SampledImageDepthSampleCounts
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-sampledImageStencilSampleCounts]] pname:sampledImageStencilSampleCounts is a bitmask^1^ of elink:VkSampleCountFlagBits bits indicating the sample supported for all 2D images created with ename:VK_IMAGE_TILING_OPTIMAL, pname:usage containing ename:VK_IMAGE_USAGE_SAMPLED_BIT, and a stencil format.
		/// </para>
		/// </summary>
		public SampleCountFlags SampledImageStencilSampleCounts
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-storageImageSampleCounts]] pname:storageImageSampleCounts is a bitmask^1^ of elink:VkSampleCountFlagBits bits indicating the sample counts supported for all 2D images created with ename:VK_IMAGE_TILING_OPTIMAL, and pname:usage containing ename:VK_IMAGE_USAGE_STORAGE_BIT.
		/// </para>
		/// </summary>
		public SampleCountFlags StorageImageSampleCounts
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxSampleMaskWords]] pname:maxSampleMaskWords is the maximum number of array elements of a variable decorated with the code:SampleMask built-in decoration.
		/// </para>
		/// </summary>
		public uint MaxSampleMaskWords
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-timestampComputeAndGraphics]] pname:timestampComputeAndGraphics indicates support for timestamps on all graphics and compute queues. If this limit is set to ename:VK_TRUE, all queues that advertise the ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT in the sname:VkQueueFamilyProperties::pname:queueFlags support sname:VkQueueFamilyProperties::pname:timestampValidBits of at least 36. See &lt;&lt;queries-timestamps, Timestamp Queries&gt;&gt;.
		/// </para>
		/// </summary>
		public Bool32 TimestampComputeAndGraphics
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-timestampPeriod]] pname:timestampPeriod is the number of nanoseconds required for a timestamp query to be incremented by 1. See &lt;&lt;queries-timestamps, Timestamp Queries&gt;&gt;.
		/// </para>
		/// </summary>
		public float TimestampPeriod
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxClipDistances]] pname:maxClipDistances is the maximum number of clip distances that can: be used in a single shader stage. The size of any array declared with the code:ClipDistance built-in decoration in a shader module must: be less than or equal to this limit.
		/// </para>
		/// </summary>
		public uint MaxClipDistances
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxCullDistances]] pname:maxCullDistances is the maximum number of cull distances that can: be used in a single shader stage. The size of any array declared with the code:CullDistance built-in decoration in a shader module must: be less than or equal to this limit.
		/// </para>
		/// </summary>
		public uint MaxCullDistances
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-maxCombinedClipAndCullDistances]] pname:maxCombinedClipAndCullDistances is the maximum combined number of clip and cull distances that can: be used in a single shader stage. The sum of the sizes of any pair of arrays declared with the code:ClipDistance and code:CullDistance built-in decoration used by a single shader stage in a shader module must: be less than or equal to this limit.
		/// </para>
		/// </summary>
		public uint MaxCombinedClipAndCullDistances
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-discreteQueuePriorities]] pname:discreteQueuePriorities is the number of discrete priorities that can: be assigned to a queue based on the value of each member of sname:VkDeviceQueueCreateInfo::pname:pQueuePriorities. This must: be at least 2, and levels must: be spread evenly over the range, with at least one level at 1.0, and another at 0.0. See &lt;&lt;devsandqueues-priority&gt;&gt;.
		/// </para>
		/// </summary>
		public uint DiscreteQueuePriorities
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-pointSizeRange]] pname:pointSizeRange[2] is the range latexmath:[$[\mathit{minimum},\mathit{maximum}\]$] of supported sizes for points. Values written to variables decorated with the code:PointSize built-in decoration are clamped to this range.
		/// </para>
		/// </summary>
		public float[] PointSizeRange
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-lineWidthRange]] pname:lineWidthRange[2] is the range latexmath:[$[\mathit{minimum},\mathit{maximum}\]$] of supported widths for lines. Values specified by the pname:lineWidth member of the sname:VkPipelineRasterizationStateCreateInfo or the pname:lineWidth parameter to fname:vkCmdSetLineWidth are clamped to this range.
		/// </para>
		/// </summary>
		public float[] LineWidthRange
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-pointSizeGranularity]] pname:pointSizeGranularity is the granularity of supported point sizes. Not all point sizes in the range defined by pname:pointSizeRange are supported. This limit specifies the granularity (or increment) between successive supported point sizes.
		/// </para>
		/// </summary>
		public float PointSizeGranularity
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-lineWidthGranularity]] pname:lineWidthGranularity is the granularity of supported line widths. Not all line widths in the range defined by pname:lineWidthRange are supported. This limit specifies the granularity (or increment) between successive supported line widths.
		/// </para>
		/// </summary>
		public float LineWidthGranularity
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-strictLines]] pname:strictLines indicates whether lines are rasterized according to the preferred method of rasterization. If set to ename:VK_FALSE, lines may: be rasterized under a relaxed set of rules. If set to ename:VK_TRUE, lines are rasterized as per the strict definition. See &lt;&lt;primsrast-lines-basic,Basic Line Segment Rasterization&gt;&gt;.
		/// </para>
		/// </summary>
		public Bool32 StrictLines
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-standardSampleLocations]] pname:standardSampleLocations indicates whether rasterization uses the standard sample locations as documented in &lt;&lt;primsrast-multisampling,Multisampling&gt;&gt;. If set to ename:VK_TRUE, the implementation uses the documented sample locations. If set to ename:VK_FALSE, the implementation may: use different sample locations.
		/// </para>
		/// </summary>
		public Bool32 StandardSampleLocations
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-optimalBufferCopyOffsetAlignment]] pname:optimalBufferCopyOffsetAlignment is the optimal buffer offset alignment in bytes for fname:vkCmdCopyBufferToImage and fname:vkCmdCopyImageToBuffer. The per texel alignment requirements are still enforced, this is just an additional alignment recommendation for optimal performance and power.
		/// </para>
		/// </summary>
		public ulong OptimalBufferCopyOffsetAlignment
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-optimalBufferCopyRowPitchAlignment]] pname:optimalBufferCopyRowPitchAlignment is the optimal buffer row pitch alignment in bytes for fname:vkCmdCopyBufferToImage and fname:vkCmdCopyImageToBuffer. Row pitch is the number of bytes between texels with the same X coordinate in adjacent rows (Y coordinates differ by one). The per texel alignment requirements are still enforced, this is just an additional alignment recommendation for optimal performance and power.
		/// </para>
		/// </summary>
		public ulong OptimalBufferCopyRowPitchAlignment
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// [[features-limits-nonCoherentAtomSize]] pname:nonCoherentAtomSize is the size and alignment in bytes that bounds concurrent access to &lt;&lt;memory-device-hostaccess, host-mapped device memory&gt;&gt;.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying physical device memory properties.
    /// </para>
    /// </summary>
	public struct PhysicalDeviceMemoryProperties
	{
	    /// <summary>
		/// <para>
		/// pname:memoryTypes is an array of slink:VkMemoryType structures describing the _memory types_ that can: be used to access memory allocated from the heaps specified by pname:memoryHeaps.
		/// </para>
		/// </summary>
		public MemoryType[] MemoryTypes
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:memoryHeaps is an array of slink:VkMemoryHeap structures describing the _memory heaps_ from which memory can: be allocated.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying physical device properties.
    /// </para>
    /// </summary>
	public struct PhysicalDeviceProperties
	{
	    /// <summary>
		/// <para>
		/// pname:apiVersion is the version of Vulkan supported by the device, encoded as described in the &lt;&lt;fundamentals-versionnum,API Version Numbers and Semantics&gt;&gt; section.
		/// </para>
		/// </summary>
		public Version ApiVersion
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:driverVersion is the vendor-specified version of the driver.
		/// </para>
		/// </summary>
		public Version DriverVersion
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:vendorID is a unique identifier for the _vendor_ (see below) of the physical device.
		/// </para>
		/// </summary>
		public uint VendorID
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:deviceID is a unique identifier for the physical device among devices available from the vendor.
		/// </para>
		/// </summary>
		public uint DeviceID
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:deviceType is a elink:VkPhysicalDeviceType specifying the type of device.
		/// </para>
		/// </summary>
		public PhysicalDeviceType DeviceType
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:deviceName is a null-terminated UTF-8 string containing the name of the device.
		/// </para>
		/// </summary>
		public string DeviceName
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pipelineCacheUUID is an array of size ename:VK_UUID_SIZE, containing 8-bit values that represent a universally unique identifier for the device.
		/// </para>
		/// </summary>
		public Guid PipelineCacheUUID
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:limits is the slink:VkPhysicalDeviceLimits structure which specifies device-specific limits of the physical device. See &lt;&lt;features-limits,Limits&gt;&gt; for details.
		/// </para>
		/// </summary>
		public PhysicalDeviceLimits Limits
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:sparseProperties is the slink:VkPhysicalDeviceSparseProperties structure which specifies various sparse related properties of the physical device. See &lt;&lt;sparsememory-physicalprops,Sparse Properties&gt;&gt; for details.
		/// </para>
		/// </summary>
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
    /// </summary>
	public struct PipelineCacheCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public PipelineCacheCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pInitialData is a pointer to previously retrieved pipeline cache data. If the pipeline cache data is incompatible (as defined below) with the device, the pipeline cache will be initially empty. If pname:initialDataSize is zero, pname:pInitialData is ignored.
		/// </para>
		/// </summary>
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
			result.InitialDataSize = (Size)(this.InitialData?.Length ?? 0);
			result.Flags = this.Flags;

            return result;
        }

		internal unsafe Interop.PipelineCacheCreateInfo* MarshalTo()
        {
            return (Interop.PipelineCacheCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline color blend state.
    /// </para>
    /// </summary>
	public struct PipelineColorBlendStateCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public PipelineColorBlendStateCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:logicOpEnable controls whether to apply &lt;&lt;framebuffer-logicop, Logical Operations&gt;&gt;.
		/// </para>
		/// </summary>
		public Bool32 LogicOpEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:logicOp selects which logical operation to apply.
		/// </para>
		/// </summary>
		public LogicOp LogicOp
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pAttachments: is a pointer to array of per target attachment states.
		/// </para>
		/// </summary>
		public PipelineColorBlendAttachmentState[] Attachments
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:blendConstants is an array of four values used as the R, G, B, and A components of the blend constant that are used in blending, depending on the &lt;&lt;framebuffer-blendfactors,blend factor&gt;&gt;.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created pipeline depth stencil state.
    /// </para>
    /// </summary>
	public struct PipelineDepthStencilStateCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public PipelineDepthStencilStateCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:depthTestEnable controls whether &lt;&lt;fragops-depth,depth testing&gt;&gt; is enabled.
		/// </para>
		/// </summary>
		public Bool32 DepthTestEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:depthWriteEnable controls whether &lt;&lt;fragops-depth-write,depth writes&gt;&gt; are enabled.
		/// </para>
		/// </summary>
		public Bool32 DepthWriteEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:depthCompareOp is the comparison operator used in the &lt;&lt;fragops-depth,depth test&gt;&gt;.
		/// </para>
		/// </summary>
		public CompareOp DepthCompareOp
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:depthBoundsTestEnable controls whether &lt;&lt;fragops-dbt,depth bounds testing&gt;&gt; is enabled.
		/// </para>
		/// </summary>
		public Bool32 DepthBoundsTestEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:stencilTestEnable controls whether &lt;&lt;fragops-stencil,stencil testing&gt;&gt; is enabled.
		/// </para>
		/// </summary>
		public Bool32 StencilTestEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:front and pname:back control the parameters of the &lt;&lt;fragops-stencil,stencil test&gt;&gt;.
		/// </para>
		/// </summary>
		public StencilOpState Front
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public StencilOpState Back
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:minDepthBounds and pname:maxDepthBounds define the range of values used in the &lt;&lt;fragops-dbt,depth bounds test&gt;&gt;.
		/// </para>
		/// </summary>
		public float MinDepthBounds
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created pipeline dynamic state.
    /// </para>
    /// </summary>
	public struct PipelineDynamicStateCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public PipelineDynamicStateCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pDynamicStates is an array of elink:VkDynamicState enums which indicate which pieces of pipeline state will use the values from dynamic state commands rather than from the pipeline state creation info.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created pipeline input assembly state.
    /// </para>
    /// </summary>
	public struct PipelineInputAssemblyStateCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public PipelineInputAssemblyStateCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:topology is a elink:VkPrimitiveTopology defining the primitive topology, as described below.
		/// </para>
		/// </summary>
		public PrimitiveTopology Topology
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:primitiveRestartEnable controls whether a special vertex index value is treated as restarting the assembly of primitives. This enable only applies to indexed draws (flink:vkCmdDrawIndexed and flink:vkCmdDrawIndexedIndirect), and the special index value is either 0xFFFFFFFF when the pname:indexType parameter of fname:vkCmdBindIndexBuffer is equal to ename:VK_INDEX_TYPE_UINT32, or 0xFFFF when pname:indexType is equal to ename:VK_INDEX_TYPE_UINT16. Primitive restart is not allowed for ``list'' topologies.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying the parameters of a newly created pipeline layout object.
    /// </para>
    /// </summary>
	public struct PipelineLayoutCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public PipelineLayoutCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pSetLayouts is a pointer to an array of sname:VkDescriptorSetLayout objects.
		/// </para>
		/// </summary>
		public DescriptorSetLayout[] SetLayouts
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pPushConstantRanges is a pointer to an array of sname:VkPushConstantRange structures defining a set of push constant ranges for use in a single pipeline layout. In addition to descriptor set layouts, a pipeline layout also describes how many push constants can: be accessed by each stage of the pipeline. + [NOTE] .Note ==== Push constants represent a high speed path to modify constant data in pipelines that is expected to outperform memory-backed resource updates. ====
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created pipeline multisample state.
    /// </para>
    /// </summary>
	public struct PipelineMultisampleStateCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public PipelineMultisampleStateCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:rasterizationSamples is a elink:VkSampleCountFlagBits specifying the number of samples per pixel used in rasterization.
		/// </para>
		/// </summary>
		public SampleCountFlags RasterizationSamples
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:sampleShadingEnable specifies that fragment shading executes per-sample if ename:VK_TRUE, or per-fragment if ename:VK_FALSE, as described in &lt;&lt;primsrast-sampleshading,Sample Shading&gt;&gt;.
		/// </para>
		/// </summary>
		public Bool32 SampleShadingEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:minSampleShading is the minimum fraction of sample shading, as described in &lt;&lt;primsrast-sampleshading,Sample Shading&gt;&gt;.
		/// </para>
		/// </summary>
		public float MinSampleShading
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pSampleMask is a bitmask of static coverage information that is ANDed with the coverage information generated during rasterization, as described in &lt;&lt;fragops-samplemask,Sample Mask&gt;&gt;.
		/// </para>
		/// </summary>
		public SampleMask[] SampleMask
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:alphaToCoverageEnable controls whether a temporary coverage value is generated based on the alpha component of the fragment's first color output as specified in the &lt;&lt;fragops-covg,Multisample Coverage&gt;&gt; section.
		/// </para>
		/// </summary>
		public Bool32 AlphaToCoverageEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:alphaToOneEnable controls whether the alpha component of the fragment's first color output is replaced with one as described in &lt;&lt;fragops-covg,Multisample Coverage&gt;&gt;.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created pipeline rasterization state.
    /// </para>
    /// </summary>
	public struct PipelineRasterizationStateCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public PipelineRasterizationStateCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:depthClampEnable controls whether to clamp the fragment's depth values instead of clipping primitives to the z planes of the frustum, as described in &lt;&lt;vertexpostproc-clipping,Primitive Clipping&gt;&gt;.
		/// </para>
		/// </summary>
		public Bool32 DepthClampEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:rasterizerDiscardEnable controls whether primitives are discarded immediately before the rasterization stage.
		/// </para>
		/// </summary>
		public Bool32 RasterizerDiscardEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:polygonMode is the triangle rendering mode. See elink:VkPolygonMode.
		/// </para>
		/// </summary>
		public PolygonMode PolygonMode
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:cullMode is the triangle facing direction used for primitive culling. See elink:VkCullModeFlagBits.
		/// </para>
		/// </summary>
		public CullModeFlags CullMode
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:frontFace is the front-facing triangle orientation to be used for culling. See elink:VkFrontFace.
		/// </para>
		/// </summary>
		public FrontFace FrontFace
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:depthBiasEnable controls whether to bias fragment depth values.
		/// </para>
		/// </summary>
		public Bool32 DepthBiasEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:depthBiasConstantFactor is a scalar factor controlling the constant depth value added to each fragment.
		/// </para>
		/// </summary>
		public float DepthBiasConstantFactor
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:depthBiasClamp is the maximum (or minimum) depth bias of a fragment.
		/// </para>
		/// </summary>
		public float DepthBiasClamp
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:depthBiasSlopeFactor is a scalar factor applied to a fragment's slope in depth bias calculations.
		/// </para>
		/// </summary>
		public float DepthBiasSlopeFactor
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:lineWidth is the width of rasterized line segments.
		/// </para>
		/// </summary>
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
    /// <para>
    /// -
    /// </para>
    /// </summary>
	public struct PipelineRasterizationStateRasterizationOrder
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created pipeline shader stage.
    /// </para>
    /// </summary>
	public struct PipelineShaderStageCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public PipelineShaderStageCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:stage names a single pipeline stage. Bits which can: be set include: + --
		/// </para>
		/// </summary>
		public ShaderStageFlags Stage
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ShaderModule Module
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public string Name
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created pipeline tessellation state.
    /// </para>
    /// </summary>
	public struct PipelineTessellationStateCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public PipelineTessellationStateCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:patchControlPoints number of control points per patch.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created pipeline vertex input state.
    /// </para>
    /// </summary>
	public struct PipelineVertexInputStateCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public PipelineVertexInputStateCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pVertexBindingDescriptions is a pointer to an array of sname:VkVertexInputBindingDescription structures.
		/// </para>
		/// </summary>
		public VertexInputBindingDescription[] VertexBindingDescriptions
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pVertexAttributeDescriptions is a pointer to an array of sname:VkVertexInputAttributeDescription structures.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created pipeline viewport state.
    /// </para>
    /// </summary>
	public struct PipelineViewportStateCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public PipelineViewportStateCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pViewports is a pointer to an array of slink:VkViewport structures, defining the viewport transforms. If the viewport state is dynamic, this member is ignored.
		/// </para>
		/// </summary>
		public Viewport[] Viewports
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pScissors is a pointer to an array of sname:VkRect2D structures which define the rectangular bounds of the scissor for the corresponding viewport. If the scissor state is dynamic, this member is ignored.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure describing parameters of a queue presentation.
    /// </para>
    /// </summary>
	public struct PresentInfo
	{
	    /// <summary>
		/// <para>
		/// pname:pWaitSemaphores, if not code:VK_NULL_HANDLE, is an array of sname:VkSemaphore objects with pname:waitSemaphoreCount entries, and specifies the semaphores to wait for before issuing the present request.
		/// </para>
		/// </summary>
		public Semaphore[] WaitSemaphores
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pSwapchains is an array of sname:VkSwapchainKHR objects with pname:swapchainCount entries.  A given swapchain must: not appear in this list more than once.
		/// </para>
		/// </summary>
		public Swapchain[] Swapchains
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pImageIndices is an array of indices into the array of each swapchain's presentable images, with pname:swapchainCount entries.  Each entry in this array identifies the image to present on the corresponding entry in the pname:pSwapchains array.
		/// </para>
		/// </summary>
		public uint[] ImageIndices
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pResults is an array of ename:VkResult typed elements with pname:swapchainCount entries. Applications that don't need per-swapchain results can: use `NULL` for pname:pResults. If non-`NULL`, each entry in pname:pResults will be set to the ename:VkResult for presenting the swapchain corresponding to the same index in pname:pSwapchains.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created query pool.
    /// </para>
    /// </summary>
	public struct QueryPoolCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public QueryPoolCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:queryType is the type of queries managed by the pool, and must: be one of the values + --
		/// </para>
		/// </summary>
		public QueryType QueryType
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint QueryCount
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying render pass begin info.
    /// </para>
    /// </summary>
	public struct RenderPassBeginInfo
	{
	    /// <summary>
		/// <para>
		/// pname:renderPass is the render pass to begin an instance of.
		/// </para>
		/// </summary>
		public RenderPass RenderPass
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:framebuffer is the framebuffer containing the attachments that are used with the render pass.
		/// </para>
		/// </summary>
		public Framebuffer Framebuffer
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:renderArea is the render area that is affected by the render pass instance, and is described in more detail below.
		/// </para>
		/// </summary>
		public Rect2D RenderArea
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pClearValues is an array of slink:VkClearValue structures that contains clear values for each attachment, if the attachment uses a pname:loadOp value of ename:VK_ATTACHMENT_LOAD_OP_CLEAR or if the attachment has a depth/stencil format and uses a pname:stencilLoadOp value of ename:VK_ATTACHMENT_LOAD_OP_CLEAR. The array is indexed by attachment number. Only elements corresponding to cleared attachments are used. Other elements of pname:pClearValues are ignored.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created render pass.
    /// </para>
    /// </summary>
	public struct RenderPassCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public RenderPassCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pAttachments points to an array of pname:attachmentCount number of slink:VkAttachmentDescription structures describing properties of the attachments, or `NULL` if pname:attachmentCount is zero.
		/// </para>
		/// </summary>
		public AttachmentDescription[] Attachments
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pSubpasses points to an array of pname:subpassCount number of slink:VkSubpassDescription structures describing properties of the subpasses.
		/// </para>
		/// </summary>
		public SubpassDescription[] Subpasses
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pDependencies points to an array of pname:dependencyCount number of slink:VkSubpassDependency structures describing dependencies between pairs of subpasses, or `NULL` if pname:dependencyCount is zero.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created sampler.
    /// </para>
    /// </summary>
	public struct SamplerCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public SamplerCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:magFilter is the magnification filter to apply to lookups, and is of type: + --
		/// </para>
		/// </summary>
		public Filter MagFilter
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Filter MinFilter
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public SamplerMipmapMode MipmapMode
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public SamplerAddressMode AddressModeU
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public SamplerAddressMode AddressModeV
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public SamplerAddressMode AddressModeW
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public float MipLodBias
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 AnisotropyEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public float MaxAnisotropy
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public Bool32 CompareEnable
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public CompareOp CompareOp
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public float MinLod
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public float MaxLod
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public BorderColor BorderColor
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created semaphore.
    /// </para>
    /// </summary>
	public struct SemaphoreCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created shader module.
    /// </para>
    /// </summary>
	public struct ShaderModuleCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public ShaderModuleCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:codeSize is the size, in bytes, of the code pointed to by pname:pCode.
		/// </para>
		/// </summary>
		public Size CodeSize
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pCode points to code that is used to create the shader module. The type and format of the code is determined from the content of the memory addressed by pname:pCode.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying a sparse buffer memory bind operation.
    /// </para>
    /// </summary>
	public struct SparseBufferMemoryBindInfo
	{
	    /// <summary>
		/// <para>
		/// pname:buffer is the sname:VkBuffer object to be bound.
		/// </para>
		/// </summary>
		public Buffer Buffer
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pBinds is a pointer to array of sname:VkSparseMemoryBind structures.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying sparse image memory bind.
    /// </para>
    /// </summary>
	public struct SparseImageMemoryBind
	{
	    /// <summary>
		/// <para>
		/// pname:subresource is the aspectMask and region of interest in the image.
		/// </para>
		/// </summary>
		public ImageSubresource Subresource
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:offset are the coordinates of the first texel within the image subresource to bind.
		/// </para>
		/// </summary>
		public Offset3D Offset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:extent is the size in texels of the region within the image subresource to bind. The extent must: be a multiple of the sparse image block dimensions, except when binding sparse image blocks along the edge of an image subresource it can: instead be such that any coordinate of latexmath:[$\mathit{offset} + \mathit{extent}$] equals the corresponding dimensions of the image subresource.
		/// </para>
		/// </summary>
		public Extent3D Extent
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:memory is the sname:VkDeviceMemory object that the sparse image blocks of the image are bound to. If pname:memory is dlink:VK_NULL_HANDLE, the sparse image blocks are unbound.
		/// </para>
		/// </summary>
		public DeviceMemory Memory
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:memoryOffset is an offset into sname:VkDeviceMemory object. If pname:memory is dlink:VK_NULL_HANDLE, this value is ignored.
		/// </para>
		/// </summary>
		public ulong MemoryOffset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:flags are sparse memory binding flags.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying sparse image memory bind info.
    /// </para>
    /// </summary>
	public struct SparseImageMemoryBindInfo
	{
	    /// <summary>
		/// <para>
		/// pname:image is the sname:VkImage object to be bound
		/// </para>
		/// </summary>
		public Image Image
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pBinds is a pointer to array of sname:VkSparseImageMemoryBind structures
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying sparse image opaque memory bind info.
    /// </para>
    /// </summary>
	public struct SparseImageOpaqueMemoryBindInfo
	{
	    /// <summary>
		/// <para>
		/// pname:image is the sname:VkImage object to be bound.
		/// </para>
		/// </summary>
		public Image Image
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pBinds is a pointer to array of sname:VkSparseMemoryBind structures.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying a sparse memory bind operation.
    /// </para>
    /// </summary>
	public struct SparseMemoryBind
	{
	    /// <summary>
		/// <para>
		/// pname:resourceOffset is the offset into the resource.
		/// </para>
		/// </summary>
		public ulong ResourceOffset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:size is the size of the memory region to be bound.
		/// </para>
		/// </summary>
		public ulong Size
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:memory is the sname:VkDeviceMemory object that the range of the resource is bound to. If pname:memory is dlink:VK_NULL_HANDLE, the range is unbound.
		/// </para>
		/// </summary>
		public DeviceMemory Memory
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:memoryOffset is the offset into the sname:VkDeviceMemory object to bind the resource range to. If pname:memory is dlink:VK_NULL_HANDLE, this value is ignored.
		/// </para>
		/// </summary>
		public ulong MemoryOffset
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:flags is a bitmask specifying usage of the binding operation. Bits which can: be set include: + --
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying specialization info.
    /// </para>
    /// </summary>
	public struct SpecializationInfo
	{
	    /// <summary>
		/// <para>
		/// pname:pMapEntries is a pointer to an array of sname:VkSpecializationMapEntry which maps constant IDs to offsets in pname:pData.
		/// </para>
		/// </summary>
		public SpecializationMapEntry[] MapEntries
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pData contains the actual constant values to specialize with.
		/// </para>
		/// </summary>
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
			result.DataSize = (Size)(this.Data?.Length ?? 0);

            return result;
        }

		internal unsafe Interop.SpecializationInfo* MarshalTo()
        {
            return (Interop.SpecializationInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying a queue submit operation.
    /// </para>
    /// </summary>
	public struct SubmitInfo
	{
	    /// <summary>
		/// <para>
		/// pname:pWaitSemaphores is a pointer to an array of semaphores upon which to wait before the command buffers for this batch begin execution. If semaphores to wait on are provided, they define a &lt;&lt;synchronization-semaphores-waiting, semaphore wait operation&gt;&gt;.
		/// </para>
		/// </summary>
		public Semaphore[] WaitSemaphores
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pWaitDstStageMask is a pointer to an array of pipeline stages at which each corresponding semaphore wait will occur.
		/// </para>
		/// </summary>
		public PipelineStageFlags[] WaitDestinationStageMask
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pCommandBuffers is a pointer to an array of command buffers to execute in the batch. The command buffers submitted in a batch begin execution in the order they appear in pname:pCommandBuffers, but may: complete out of order.
		/// </para>
		/// </summary>
		public CommandBuffer[] CommandBuffers
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pSignalSemaphores is a pointer to an array of semaphores which will be signaled when the command buffers for this batch have completed execution. If semaphores to be signaled are provided, they define a &lt;&lt;synchronization-semaphores-signaling, semaphore signal operation&gt;&gt;.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying a subpass description.
    /// </para>
    /// </summary>
	public struct SubpassDescription
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public SubpassDescriptionFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pipelineBindPoint is a elink:VkPipelineBindPoint value specifying whether this is a compute or graphics subpass. Currently, only graphics subpasses are supported.
		/// </para>
		/// </summary>
		public PipelineBindPoint PipelineBindPoint
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pInputAttachments is an array of slink:VkAttachmentReference structures (defined below) that lists which of the render pass's attachments can: be read in the shader during the subpass, and what layout each attachment will be in during the subpass. Each element of the array corresponds to an input attachment unit number in the shader, i.e. if the shader declares an input variable `layout(input_attachment_index=X, set=Y, binding=Z)` then it uses the attachment provided in pname:pInputAttachments[X]. Input attachments must: also be bound to the pipeline with a descriptor set, with the input attachment descriptor written in the location (set=Y, binding=Z).
		/// </para>
		/// </summary>
		public AttachmentReference[] InputAttachments
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pColorAttachments is an array of pname:colorAttachmentCount slink:VkAttachmentReference structures that lists which of the render pass's attachments will be used as color attachments in the subpass, and what layout each attachment will be in during the subpass. Each element of the array corresponds to a fragment shader output location, i.e. if the shader declared an output variable `layout(location=X)` then it uses the attachment provided in pname:pColorAttachments[X].
		/// </para>
		/// </summary>
		public AttachmentReference[] ColorAttachments
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pResolveAttachments is `NULL` or an array of pname:colorAttachmentCount slink:VkAttachmentReference structures that lists which of the render pass's attachments are resolved to at the end of the subpass, and what layout each attachment will be in during the resolve. If pname:pResolveAttachments is not `NULL`, each of its elements corresponds to a color attachment (the element in pname:pColorAttachments at the same index). At the end of each subpass, the subpass's color attachments are resolved to corresponding resolve attachments, unless the resolve attachment index is ename:VK_ATTACHMENT_UNUSED or pname:pResolveAttachments is `NULL`. If the first use of an attachment in a render pass is as a resolve attachment, then the pname:loadOp is effectively ignored as the resolve is guaranteed to overwrite all pixels in the render area.
		/// </para>
		/// </summary>
		public AttachmentReference[] ResolveAttachments
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pDepthStencilAttachment is a pointer to a slink:VkAttachmentReference specifying which attachment will be used for depth/stencil data and the layout it will be in during the subpass. Setting the attachment index to ename:VK_ATTACHMENT_UNUSED or leaving this pointer as `NULL` indicates that no depth/stencil attachment will be used in the subpass.
		/// </para>
		/// </summary>
		public AttachmentReference DepthStencilAttachment
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pPreserveAttachments is an array of pname:preserveAttachmentCount render pass attachment indices describing the attachments that are not used by a subpass, but whose contents must: be preserved throughout the subpass.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created swapchain object.
    /// </para>
    /// </summary>
	public struct SwapchainCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use, and must: be zero.
		/// </para>
		/// </summary>
		public SwapchainCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:surface is the surface that the swapchain will present images to.
		/// </para>
		/// </summary>
		public Surface Surface
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:minImageCount is the minimum number of presentable images that the application needs. The platform will either create the swapchain with at least that many images, or will fail to create the swapchain.
		/// </para>
		/// </summary>
		public uint MinImageCount
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:imageFormat is a slink:VkFormat that is valid for swapchains on the specified surface.
		/// </para>
		/// </summary>
		public Format ImageFormat
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:imageColorSpace is a slink:VkColorSpaceKHR that is valid for swapchains on the specified surface.
		/// </para>
		/// </summary>
		public ColorSpace ImageColorSpace
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:imageExtent is the size (in pixels) of the swapchain. Behavior is platform-dependent when the image extent does not match the surface's pname:currentExtent as returned by fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR.
		/// </para>
		/// </summary>
		public Extent2D ImageExtent
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:imageArrayLayers is the number of views in a multiview/stereo surface. For non-stereoscopic-3D applications, this value is 1.
		/// </para>
		/// </summary>
		public uint ImageArrayLayers
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:imageUsage is a bitmask of elink:VkImageUsageFlagBits, indicating how the application will use the swapchain's presentable images.
		/// </para>
		/// </summary>
		public ImageUsageFlags ImageUsage
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:imageSharingMode is the sharing mode used for the images of the swapchain.
		/// </para>
		/// </summary>
		public SharingMode ImageSharingMode
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pQueueFamilyIndices is an array of queue family indices having access to the images of the swapchain in case pname:imageSharingMode is ename:VK_SHARING_MODE_CONCURRENT.
		/// </para>
		/// </summary>
		public uint[] QueueFamilyIndices
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:preTransform is a bitmask of elink:VkSurfaceTransformFlagBitsKHR, describing the transform, relative to the presentation engine's natural orientation, applied to the image content prior to presentation. If it does not match the pname:currentTransform value returned by fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR, the presentation engine will transform the image content as part of the presentation operation.
		/// </para>
		/// </summary>
		public SurfaceTransformFlags PreTransform
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:compositeAlpha is a bitmask of elink:VkCompositeAlphaFlagBitsKHR, indicating the alpha compositing mode to use when this surface is composited together with other surfaces on certain window systems.
		/// </para>
		/// </summary>
		public CompositeAlphaFlags CompositeAlpha
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:presentMode is the presentation mode the swapchain will use. A swapchain's present mode determines how incoming present requests will be processed and queued internally.
		/// </para>
		/// </summary>
		public PresentMode PresentMode
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:clipped indicates whether the Vulkan implementation is allowed to discard rendering operations that affect regions of the surface which aren't visible.
		/// </para>
		/// </summary>
		public Bool32 Clipped
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created Wayland surface object.
    /// </para>
    /// </summary>
	public struct WaylandSurfaceCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public WaylandSurfaceCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:display and pname:surface are pointers to the Wayland code:wl_display and code:wl_surface to associate the surface with.
		/// </para>
		/// </summary>
		public IntPtr Display
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Use Windows keyex mutex mechanism to synchronize work.
    /// </para>
    /// <para>
    /// When submitting work that operates on memory imported from a Direct3D 11 resource to a queue, the keyed mutex mechanism may: be used in addition to Vulkan semaphores to synchronize the work.  Keyed mutexes are a property of a properly created shareable Direct3D 11 resource. They can: only be used if the imported resource was created with the etext:D3D11_RESOURCE_MISC_SHARED_KEYEDMUTEX flag.
    /// </para>
    /// <para>
    /// To acquire keyed mutexes before submitted work and/or release them after, add a slink:VkWin32KeyedMutexAcquireReleaseInfoNV structure to the pname:pNext chain of the slink:VkSubmitInfo structure.
    /// </para>
    /// </summary>
	public struct Win32KeyedMutexAcquireReleaseInfo
	{
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public DeviceMemory[] AcquireSyncs
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ulong[] AcquireKeys
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public uint[] AcquireTimeoutMilliseconds
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public DeviceMemory[] ReleaseSyncs
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
		public ulong[] ReleaseKeys
		{
			get;
			set;
		}

        internal unsafe Interop.Win32KeyedMutexAcquireReleaseInfo Pack()
        {
            var result = new Interop.Win32KeyedMutexAcquireReleaseInfo();
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

		internal unsafe Interop.Win32KeyedMutexAcquireReleaseInfo* MarshalTo()
        {
            return (Interop.Win32KeyedMutexAcquireReleaseInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
		}
	}

    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created Win32 surface object.
    /// </para>
    /// </summary>
	public struct Win32SurfaceCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public Win32SurfaceCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:hinstance and pname:hwnd are the Win32 code:HINSTANCE and code:HWND for the window to associate the surface with.
		/// </para>
		/// </summary>
		public IntPtr Hinstance
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// -
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying the parameters of a descriptor set write operation.
    /// </para>
    /// </summary>
	public struct WriteDescriptorSet
	{
	    /// <summary>
		/// <para>
		/// pname:dstSet is the destination descriptor set to update.
		/// </para>
		/// </summary>
		public DescriptorSet DestinationSet
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dstBinding is the descriptor binding within that set.
		/// </para>
		/// </summary>
		public uint DestinationBinding
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dstArrayElement is the starting element in that array.
		/// </para>
		/// </summary>
		public uint DestinationArrayElement
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:descriptorType is a elink:VkDescriptorType specifying the type of each descriptor in pname:pImageInfo, pname:pBufferInfo, or pname:pTexelBufferView, as described below. It must: be the same type as that specified in sname:VkDescriptorSetLayoutBinding for pname:dstSet at pname:dstBinding. The type of the descriptor also controls which array the descriptors are taken from.
		/// </para>
		/// </summary>
		public DescriptorType DescriptorType
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pImageInfo points to an array of slink:VkDescriptorImageInfo structures or is ignored, as described below.
		/// </para>
		/// </summary>
		public DescriptorImageInfo[] ImageInfo
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pBufferInfo points to an array of slink:VkDescriptorBufferInfo structures or is ignored, as described below.
		/// </para>
		/// </summary>
		public DescriptorBufferInfo[] BufferInfo
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:pTexelBufferView points to an array of slink:VkBufferView handles as described in the &lt;&lt;resources-buffer-views,Buffer Views&gt;&gt; section or is ignored, as described below.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created Xcb surface object.
    /// </para>
    /// </summary>
	public struct XcbSurfaceCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public XcbSurfaceCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:connection is a pointer to an sname:xcb_connection_t to the X server.
		/// </para>
		/// </summary>
		public IntPtr Connection
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:window is the sname:xcb_window_t for the X11 window to associate the surface with.
		/// </para>
		/// </summary>
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
    /// <para>
    /// Structure specifying parameters of a newly created Xlib surface object.
    /// </para>
    /// </summary>
	public struct XlibSurfaceCreateInfo
	{
	    /// <summary>
		/// <para>
		/// pname:flags is reserved for future use.
		/// </para>
		/// </summary>
		public XlibSurfaceCreateFlags Flags
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:dpy is a pointer to an Xlib Display connection to the X server.
		/// </para>
		/// </summary>
		public IntPtr Dpy
		{
			get;
			set;
		}
	    /// <summary>
		/// <para>
		/// pname:window is an Xlib Window to associate the surface with.
		/// </para>
		/// </summary>
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