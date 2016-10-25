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

// This file was automatically generated and should not be edited directly.

using System;

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure containing callback function pointers for memory allocation.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:pfnAllocation must: be a pointer to a valid
    /// user-defined tlink:PFN_vkAllocationFunction * pname:pfnReallocation
    /// must: be a pointer to a valid user-defined
    /// tlink:PFN_vkReallocationFunction * pname:pfnFree must: be a pointer to
    /// a valid user-defined tlink:PFN_vkFreeFunction * If either of
    /// pname:pfnInternalAllocation or pname:pfnInternalFree is not `NULL`,
    /// both must: be valid callbacks ****
    /// </para>
    /// </summary>
    public struct AllocationCallbacks
    {
        /// <summary>
        /// pname:pUserData is a value to be interpreted by the implementation
        /// of the callbacks. When any of the callbacks in
        /// sname:VkAllocationCallbacks are called, the Vulkan implementation
        /// will pass this value as the first parameter to the callback. This
        /// value can: vary each time an allocator is passed into a command,
        /// even when the same object takes an allocator in multiple commands.
        /// </summary>
        public IntPtr UserData
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pfnAllocation is a pointer to an application-defined memory
        /// allocation function of type tlink:PFN_vkAllocationFunction.
        /// </summary>
        public Interop.AllocationFunctionDelegate PfnAllocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pfnReallocation is a pointer to an application-defined memory
        /// reallocation function of type tlink:PFN_vkReallocationFunction.
        /// </summary>
        public Interop.ReallocationFunctionDelegate PfnReallocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pfnFree is a pointer to an application-defined memory free
        /// function of type tlink:PFN_vkFreeFunction.
        /// </summary>
        public Interop.FreeFunctionDelegate PfnFree
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pfnInternalAllocation is a pointer to an application-defined
        /// function that is called by the implementation when the
        /// implementation makes internal allocations, and it is of type
        /// tlink:PFN_vkInternalAllocationNotification.
        /// </summary>
        public Interop.InternalAllocationNotificationDelegate PfnInternalAllocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pfnInternalFree is a pointer to an application-defined
        /// function that is called by the implementation when the
        /// implementation frees internal allocations, and it is of type
        /// tlink:PFN_vkInternalFreeNotification.
        /// </summary>
        public Interop.InternalFreeNotificationDelegate PfnInternalFree
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.AllocationCallbacks* MarshalTo()
        {
            return (Interop.AllocationCallbacks*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying parameters of a newly created Android surface
    /// object.
    /// </summary>
    public struct AndroidSurfaceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public AndroidSurfaceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:window is a pointer to the code:ANativeWindow to associate
        /// the surface with.
        /// </summary>
        public IntPtr Window
        {
            get;
            set;
        }
        
        internal unsafe Interop.AndroidSurfaceCreateInfo Pack()
        {
            Interop.AndroidSurfaceCreateInfo result = default(Interop.AndroidSurfaceCreateInfo);
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
    /// <para>
    /// .Valid Usage **** * pname:apiVersion must: be zero, or otherwise it
    /// must: be a version that the implementation supports, or supports an
    /// effective substitute for ****
    /// </para>
    /// </summary>
    public struct ApplicationInfo
    {
        /// <summary>
        /// pname:pApplicationName is a pointer to a null-terminated UTF-8
        /// string containing the name of the application.
        /// </summary>
        public string ApplicationName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:applicationVersion is an unsigned integer variable containing
        /// the developer-supplied version number of the application.
        /// </summary>
        public Version ApplicationVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pEngineName is a pointer to a null-terminated UTF-8 string
        /// containing the name of the engine (if any) used to create the
        /// application.
        /// </summary>
        public string EngineName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:engineVersion is an unsigned integer variable containing the
        /// developer-supplied version number of the engine used to create the
        /// application.
        /// </summary>
        public Version EngineVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:apiVersion is the version of the Vulkan API against which the
        /// application expects to run, encoded as described in the
        /// &lt;&lt;fundamentals-versionnum,API Version Numbers and
        /// Semantics&gt;&gt; section. If pname:apiVersion is 0 the
        /// implementation must: ignore it, otherwise if the implementation
        /// does not support the requested pname:apiVersion it must: return
        /// ename:VK_ERROR_INCOMPATIBLE_DRIVER. The patch version number
        /// specified in pname:apiVersion is ignored when creating an instance
        /// object. Only the major and minor versions of the instance must:
        /// match those requested in pname:apiVersion.
        /// </summary>
        public Version ApiVersion
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.ApplicationInfo* MarshalTo()
        {
            return (Interop.ApplicationInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying a sparse binding operation.
    /// </summary>
    public struct BindSparseInfo
    {
        /// <summary>
        /// pname:pWaitSemaphores is a pointer to an array of semaphores upon
        /// which to wait on before the sparse binding operations for this
        /// batch begin execution. If semaphores to wait on are provided, they
        /// define a &lt;&lt;synchronization-semaphores-waiting, semaphore wait
        /// operation&gt;&gt;.
        /// </summary>
        public Semaphore[] WaitSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pBufferBinds is a pointer to an array of
        /// slink:VkSparseBufferMemoryBindInfo structures.
        /// </summary>
        public SparseBufferMemoryBindInfo[] BufferBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pImageOpaqueBinds is a pointer to an array of
        /// slink:VkSparseImageOpaqueMemoryBindInfo structures, indicating
        /// opaque sparse image bindings to perform.
        /// </summary>
        public SparseImageOpaqueMemoryBindInfo[] ImageOpaqueBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pImageBinds is a pointer to an array of
        /// slink:VkSparseImageMemoryBindInfo structures, indicating sparse
        /// image bindings to perform.
        /// </summary>
        public SparseImageMemoryBindInfo[] ImageBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSignalSemaphores is a pointer to an array of semaphores
        /// which will be signaled when the sparse binding operations for this
        /// batch have completed execution. If semaphores to be signaled are
        /// provided, they define a
        /// &lt;&lt;synchronization-semaphores-signaling, semaphore signal
        /// operation&gt;&gt;.
        /// </summary>
        public Semaphore[] SignalSemaphores
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.BindSparseInfo* MarshalTo()
        {
            return (Interop.BindSparseInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// <para>
    /// Structure specifying the parameters of a newly created buffer object.
    /// </para>
    /// <para>
    /// Bits which can: be set in pname:usage are:
    /// </para>
    /// </summary>
    public struct BufferCreateInfo
    {
        /// <summary>
        /// pname:flags is a bitmask describing additional parameters of the
        /// buffer. See elink:VkBufferCreateFlagBits below for a description of
        /// the supported bits.
        /// </summary>
        public BufferCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:size is the size in bytes of the buffer to be created.
        /// </summary>
        public ulong Size
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:usage is a bitmask describing the allowed usages of the
        /// buffer. See elink:VkBufferUsageFlagBits below for a description of
        /// the supported bits.
        /// </summary>
        public BufferUsageFlags Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sharingMode is the sharing mode of the buffer when it will be
        /// accessed by multiple queue families, see elink:VkSharingMode in the
        /// &lt;&lt;resources-sharing,Resource Sharing&gt;&gt; section below
        /// for supported values.
        /// </summary>
        public SharingMode SharingMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pQueueFamilyIndices is a list of queue families that will
        /// access this buffer (ignored if pname:sharingMode is not
        /// ename:VK_SHARING_MODE_CONCURRENT).
        /// </summary>
        public uint[] QueueFamilyIndices
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * pname:offset must: be less than the size of
    /// pname:buffer * If pname:size is not equal to ename:VK_WHOLE_SIZE,
    /// pname:size must: be greater than `0` * If pname:size is not equal to
    /// ename:VK_WHOLE_SIZE, pname:size must: be less than or equal to than the
    /// size of pname:buffer minus pname:offset * If pname:buffer was created
    /// with a sharing mode of ename:VK_SHARING_MODE_CONCURRENT,
    /// pname:srcQueueFamilyIndex and pname:dstQueueFamilyIndex must: both be
    /// ename:VK_QUEUE_FAMILY_IGNORED * If pname:buffer was created with a
    /// sharing mode of ename:VK_SHARING_MODE_EXCLUSIVE,
    /// pname:srcQueueFamilyIndex and pname:dstQueueFamilyIndex must: either
    /// both be ename:VK_QUEUE_FAMILY_IGNORED, or both be a valid queue family
    /// (see &lt;&lt;devsandqueues-queueprops&gt;&gt;) * If pname:buffer was
    /// created with a sharing mode of ename:VK_SHARING_MODE_EXCLUSIVE, and
    /// pname:srcQueueFamilyIndex and pname:dstQueueFamilyIndex are valid queue
    /// families, at least one of them must: be the same as the family of the
    /// queue that will execute this barrier ****
    /// </para>
    /// </summary>
    public struct BufferMemoryBarrier
    {
        /// <summary>
        /// pname:srcAccessMask is a bitmask of the classes of memory accesses
        /// performed by the first set of commands that will participate in the
        /// dependency.
        /// </summary>
        public AccessFlags SourceAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstAccessMask is a bitmask of the classes of memory accesses
        /// performed by the second set of commands that will participate in
        /// the dependency.
        /// </summary>
        public AccessFlags DestinationAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:srcQueueFamilyIndex is the queue family that is relinquishing
        /// ownership of the range of pname:buffer to another queue, or
        /// ename:VK_QUEUE_FAMILY_IGNORED if there is no transfer of ownership.
        /// </summary>
        public uint SourceQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstQueueFamilyIndex is the queue family that is acquiring
        /// ownership of the range of pname:buffer from another queue, or
        /// ename:VK_QUEUE_FAMILY_IGNORED if there is no transfer of ownership.
        /// </summary>
        public uint DestinationQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:buffer is a handle to the buffer whose backing memory is
        /// affected by the barrier.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:offset is an offset in bytes into the backing memory for
        /// pname:buffer; this is relative to the base offset as bound to the
        /// buffer (see flink:vkBindBufferMemory).
        /// </summary>
        public ulong Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:size is a size in bytes of the affected area of backing
        /// memory for pname:buffer, or ename:VK_WHOLE_SIZE to use the range
        /// from pname:offset to the end of the buffer.
        /// </summary>
        public ulong Size
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * pname:offset must: be less than the size of
    /// pname:buffer * pname:offset must: be a multiple of
    /// sname:VkPhysicalDeviceLimits::pname:minTexelBufferOffsetAlignment * If
    /// pname:range is not equal to ename:VK_WHOLE_SIZE: ** pname:range must:
    /// be greater than `0` ** pname:range must: be a multiple of the element
    /// size of pname:format ** pname:range divided by the element size of
    /// pname:format, must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxTexelBufferElements ** the sum
    /// of pname:offset and pname:range must: be less than or equal to the size
    /// of pname:buffer * pname:buffer must: have been created with a
    /// pname:usage value containing at least one of
    /// ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or
    /// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT * If pname:buffer was
    /// created with pname:usage containing
    /// ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT, pname:format must: be
    /// supported for uniform texel buffers, as specified by the
    /// ename:VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT flag in
    /// sname:VkFormatProperties::pname:bufferFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties * If pname:buffer was created
    /// with pname:usage containing
    /// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT, pname:format must: be
    /// supported for storage texel buffers, as specified by the
    /// ename:VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT flag in
    /// sname:VkFormatProperties::pname:bufferFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties ****
    /// </para>
    /// </summary>
    public struct BufferViewCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public BufferViewCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:buffer is a sname:VkBuffer on which the view will be created.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:format is a elink:VkFormat describing the format of the data
        /// elements in the buffer.
        /// </summary>
        public Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:offset is an offset in bytes from the base address of the
        /// buffer. Accesses to the buffer view from shaders use addressing
        /// that is relative to this starting offset.
        /// </summary>
        public ulong Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:range is a size in bytes of the buffer view. If pname:range
        /// is equal to ename:VK_WHOLE_SIZE, the range from pname:offset to the
        /// end of the buffer is used. If ename:VK_WHOLE_SIZE is used and the
        /// remaining size of the buffer is not a multiple of the element size
        /// of pname:format, then the nearest smaller multiple is used.
        /// </summary>
        public ulong Range
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.BufferViewCreateInfo* MarshalTo()
        {
            return (Interop.BufferViewCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying the allocation parameters for command buffer
    /// object.
    /// </summary>
    public struct CommandBufferAllocateInfo
    {
        /// <summary>
        /// pname:commandPool is the name of the command pool that the command
        /// buffers allocate their memory from.
        /// </summary>
        public CommandPool CommandPool
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:level determines whether the command buffers are primary or
        /// secondary command buffers. Possible values include: + --
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
        
        internal unsafe Interop.CommandBufferAllocateInfo Pack()
        {
            Interop.CommandBufferAllocateInfo result = default(Interop.CommandBufferAllocateInfo);
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
    /// Structure specifying a command buffer begin operation.
    /// </summary>
    public struct CommandBufferBeginInfo
    {
        /// <summary>
        /// pname:flags is a bitmask indicating usage behavior for the command
        /// buffer. Bits which can: be set include: + --
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
        
        internal unsafe Interop.CommandBufferBeginInfo Pack()
        {
            Interop.CommandBufferBeginInfo result = default(Interop.CommandBufferBeginInfo);
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
    /// <para>
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-inheritedQueries,inherited queries&gt;&gt;
    /// feature is not enabled, pname:occlusionQueryEnable must: be
    /// ename:VK_FALSE * If the
    /// &lt;&lt;features-features-inheritedQueries,inherited queries&gt;&gt;
    /// feature is enabled, pname:queryFlags must: be a valid combination of
    /// elink:VkQueryControlFlagBits values * If the
    /// &lt;&lt;features-features-pipelineStatisticsQuery,pipeline statistics
    /// queries&gt;&gt; feature is not enabled, pname:pipelineStatistics must:
    /// be code:0 ****
    /// </para>
    /// </summary>
    public struct CommandBufferInheritanceInfo
    {
        /// <summary>
        /// pname:renderPass is a sname:VkRenderPass object defining which
        /// render passes the sname:VkCommandBuffer will be
        /// &lt;&lt;renderpass-compatibility, compatible&gt;&gt; with and can:
        /// be executed within. If the sname:VkCommandBuffer will not be
        /// executed within a render pass instance, pname:renderPass is
        /// ignored.
        /// </summary>
        public RenderPass RenderPass
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subpass is the index of the subpass within the render pass
        /// instance that the sname:VkCommandBuffer will be executed within. If
        /// the sname:VkCommandBuffer will not be executed within a render pass
        /// instance, pname:subpass is ignored.
        /// </summary>
        public uint Subpass
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:framebuffer optionally refers to the sname:VkFramebuffer
        /// object that the sname:VkCommandBuffer will be rendering to if it is
        /// executed within a render pass instance. It can: be
        /// dlink:VK_NULL_HANDLE if the framebuffer is not known, or if the
        /// sname:VkCommandBuffer will not be executed within a render pass
        /// instance. + [NOTE] .Note ==== Specifying the exact framebuffer that
        /// the secondary command buffer will be executed with may: result in
        /// better performance at command buffer execution time. ====
        /// </summary>
        public Framebuffer Framebuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:occlusionQueryEnable indicates whether the command buffer
        /// can: be executed while an occlusion query is active in the primary
        /// command buffer. If this is ename:VK_TRUE, then this command buffer
        /// can: be executed whether the primary command buffer has an
        /// occlusion query active or not. If this is ename:VK_FALSE, then the
        /// primary command buffer must: not have an occlusion query active.
        /// </summary>
        public Bool32 OcclusionQueryEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:queryFlags indicates the query flags that can: be used by an
        /// active occlusion query in the primary command buffer when this
        /// secondary command buffer is executed. If this value includes the
        /// ename:VK_QUERY_CONTROL_PRECISE_BIT bit, then the active query can:
        /// return boolean results or actual sample counts. If this bit is not
        /// set, then the active query must: not use the
        /// ename:VK_QUERY_CONTROL_PRECISE_BIT bit.
        /// </summary>
        public QueryControlFlags QueryFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pipelineStatistics indicates the set of pipeline statistics
        /// that can: be counted by an active query in the primary command
        /// buffer when this secondary command buffer is executed. If this
        /// value includes a given bit, then this command buffer can: be
        /// executed whether the primary command buffer has a pipeline
        /// statistics query active that includes this bit or not. If this
        /// value excludes a given bit, then the active pipeline statistics
        /// query must: not be from a query pool that counts that statistic.
        /// </summary>
        public QueryPipelineStatisticFlags PipelineStatistics
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.CommandBufferInheritanceInfo* MarshalTo()
        {
            return (Interop.CommandBufferInheritanceInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying parameters of a newly created command pool.
    /// </summary>
    public struct CommandPoolCreateInfo
    {
        /// <summary>
        /// pname:flags is a bitmask indicating usage behavior for the pool and
        /// command buffers allocated from it. Bits which can: be set include:
        /// + --
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
        
        internal unsafe Interop.CommandPoolCreateInfo Pack()
        {
            Interop.CommandPoolCreateInfo result = default(Interop.CommandPoolCreateInfo);
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
    /// <para>
    /// The parameters pname:basePipelineHandle and pname:basePipelineIndex are
    /// described in more detail in
    /// &lt;&lt;pipelines-pipeline-derivatives,Pipeline Derivatives&gt;&gt;.
    /// </para>
    /// <para>
    /// pname:stage points to a structure of type
    /// sname:VkPipelineShaderStageCreateInfo.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:flags contains the
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineIndex is not `-1`, pname:basePipelineHandle must: be
    /// dlink:VK_NULL_HANDLE * If pname:flags contains the
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineIndex is not `-1`, it must: be a valid index into the
    /// calling command's pname:pCreateInfos parameter * If pname:flags
    /// contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineHandle is not dlink:VK_NULL_HANDLE,
    /// pname:basePipelineIndex must: be `-1` * If pname:flags contains the
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineHandle is not dlink:VK_NULL_HANDLE,
    /// pname:basePipelineHandle must: be a valid sname:VkPipeline handle * If
    /// pname:flags contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag,
    /// and pname:basePipelineHandle is not dlink:VK_NULL_HANDLE, it must: be a
    /// valid handle to a compute sname:VkPipeline * The pname:stage member of
    /// pname:stage must: be ename:VK_SHADER_STAGE_COMPUTE_BIT * The shader
    /// code for the entry point identified by pname:stage and the rest of the
    /// state identified by this structure must: adhere to the pipeline linking
    /// rules described in the &lt;&lt;interfaces,Shader Interfaces&gt;&gt;
    /// chapter * pname:layout must: be
    /// &lt;&lt;descriptorsets-pipelinelayout-consistency,consistent&gt;&gt; with
    /// the layout of the compute shader specified in pname:stage ****
    /// </para>
    /// </summary>
    public struct ComputePipelineCreateInfo
    {
        /// <summary>
        /// pname:flags provides options for pipeline creation, and is of type
        /// elink:VkPipelineCreateFlagBits.
        /// </summary>
        public PipelineCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:stage is a slink:VkPipelineShaderStageCreateInfo describing
        /// the compute shader.
        /// </summary>
        public PipelineShaderStageCreateInfo Stage
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:layout is the description of binding locations used by both
        /// the pipeline and descriptor sets used with the pipeline.
        /// </summary>
        public PipelineLayout Layout
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:basePipelineHandle is a pipeline to derive from
        /// </summary>
        public Pipeline BasePipelineHandle
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:basePipelineIndex is an index into the pname:pCreateInfos
        /// parameter to use as a pipeline to derive from
        /// </summary>
        public int BasePipelineIndex
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * pname:srcBinding must: be a valid binding within
    /// pname:srcSet * The sum of pname:srcArrayElement and
    /// pname:descriptorCount must: be less than or equal to the number of
    /// array elements in the descriptor set binding specified by
    /// pname:srcBinding, and all applicable consecutive bindings, as described
    /// by &lt;&lt;descriptorsets-updates-consecutive&gt;&gt; *
    /// pname:dstBinding must: be a valid binding within pname:dstSet * The sum
    /// of pname:dstArrayElement and pname:descriptorCount must: be less than
    /// or equal to the number of array elements in the descriptor set binding
    /// specified by pname:dstBinding, and all applicable consecutive bindings,
    /// as described by &lt;&lt;descriptorsets-updates-consecutive&gt;&gt; * If
    /// pname:srcSet is equal to pname:dstSet, then the source and destination
    /// ranges of descriptors must: not overlap, where the ranges may: include
    /// array elements from consecutive bindings as described by
    /// &lt;&lt;descriptorsets-updates-consecutive&gt;&gt; ****
    /// </para>
    /// </summary>
    public struct CopyDescriptorSet
    {
        /// <summary>
        /// pname:srcSet, pname:srcBinding, and pname:srcArrayElement are the
        /// source set, binding, and array element, respectively.
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
        /// pname:dstSet, pname:dstBinding, and pname:dstArrayElement are the
        /// destination set, binding, and array element, respectively.
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
        /// pname:descriptorCount is the number of descriptors to copy from the
        /// source to destination. If pname:descriptorCount is greater than the
        /// number of remaining array elements in the source or destination
        /// binding, those affect consecutive bindings in a manner similar to
        /// slink:VkWriteDescriptorSet above.
        /// </summary>
        public uint DescriptorCount
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.CopyDescriptorSet* MarshalTo()
        {
            return (Interop.CopyDescriptorSet*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Specify parameters of a command buffer marker region.
    /// </summary>
    public struct DebugMarkerMarkerInfo
    {
        /// <summary>
        /// pname:pMarkerName is a pointer to a null-terminated UTF-8 string
        /// that contains the name of the marker.
        /// </summary>
        public string MarkerName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:color is an optional RGBA color value that can be associated
        /// with the marker. A particular implementation may: choose to ignore
        /// this color value. The values contain RGBA values in order, in the
        /// range 0.0 to 1.0. If all elements in pname:color are set to 0.0
        /// then it is ignored.
        /// </summary>
        public float[] Color
        {
            get;
            set;
        }
        
        internal unsafe Interop.DebugMarkerMarkerInfo Pack()
        {
            Interop.DebugMarkerMarkerInfo result = default(Interop.DebugMarkerMarkerInfo);
            result.SType = StructureType.DebugMarkerMarkerInfo;
            result.MarkerName = Interop.HeapUtil.MarshalTo(this.MarkerName);
            Validate.CheckLength(this.Color, 4, "Color");
            MemUtil.WriteToPtr((IntPtr)(result.Color), this.Color, 0, 4);
            return result;
        }
        
        internal unsafe Interop.DebugMarkerMarkerInfo* MarshalTo()
        {
            return (Interop.DebugMarkerMarkerInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// <para>
    /// Specify parameters of a name to give to an object.
    /// </para>
    /// <para>
    /// Applications may: change the name associated with an object simply by
    /// calling fname:vkDebugMarkerSetObjectNameEXT again with a new string. To
    /// remove a previously set name, pname:pName should: be set to an empty
    /// string.
    /// </para>
    /// </summary>
    public struct DebugMarkerObjectNameInfo
    {
        /// <summary>
        /// pname:objectType is a elink:VkDebugReportObjectTypeEXT specifying
        /// the type of the object to be named.
        /// </summary>
        public DebugReportObjectType ObjectType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:object is the object to be named.
        /// </summary>
        public ulong Object
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pObjectName is a null-terminated UTF-8 string specifying the
        /// name to apply to pname:object.
        /// </summary>
        public string ObjectName
        {
            get;
            set;
        }
        
        internal unsafe Interop.DebugMarkerObjectNameInfo Pack()
        {
            Interop.DebugMarkerObjectNameInfo result = default(Interop.DebugMarkerObjectNameInfo);
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
    /// Specify parameters of a tag to attach to an object.
    /// </para>
    /// <para>
    /// The pname:tagName parameter gives a name or identifier to the type of
    /// data being tagged. This can be used by debugging layers to easily
    /// filter for only data that can be used by that implementation.
    /// </para>
    /// </summary>
    public struct DebugMarkerObjectTagInfo
    {
        /// <summary>
        /// pname:objectType is a elink:VkDebugReportObjectTypeEXT specifying
        /// the type of the object to be named.
        /// </summary>
        public DebugReportObjectType ObjectType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:object is the object to be tagged.
        /// </summary>
        public ulong Object
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:tagName is a numerical identifier of the tag.
        /// </summary>
        public ulong TagName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pTag is an array of pname:tagSize bytes containing the data
        /// to be associated with the object.
        /// </summary>
        public byte[] Tag
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.DebugMarkerObjectTagInfo* MarshalTo()
        {
            return (Interop.DebugMarkerObjectTagInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying parameters of a newly created debug report
    /// callback.
    /// </summary>
    public struct DebugReportCallbackCreateInfo
    {
        /// <summary>
        /// pname:flags indicate which event(s) will cause this callback to be
        /// called. Flags are interpreted as bitmasks and multiple may be set.
        /// Bits which can: be set include: + --
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
        
        internal unsafe Interop.DebugReportCallbackCreateInfo Pack()
        {
            Interop.DebugReportCallbackCreateInfo result = default(Interop.DebugReportCallbackCreateInfo);
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
    /// If the pname:pNext list includes a
    /// sname:VkDedicatedAllocationBufferCreateInfoNV structure, then that
    /// structure includes an enable controlling whether the buffer will have a
    /// dedicated memory allocation bound to it.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:dedicatedAllocation is ename:VK_TRUE,
    /// sname:VkBufferCreateInfo::pname:flags must: not include
    /// ename:VK_BUFFER_CREATE_SPARSE_BINDING_BIT, ename:VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT,
    /// or ename:VK_BUFFER_CREATE_SPARSE_ALIASED_BIT ****
    /// </para>
    /// </summary>
    public struct DedicatedAllocationBufferCreateInfo
    {
        /// <summary>
        /// pname:dedicatedAllocation indicates whether the buffer will have a
        /// dedicated allocation bound to it.
        /// </summary>
        public Bool32 DedicatedAllocation
        {
            get;
            set;
        }
        
        internal unsafe Interop.DedicatedAllocationBufferCreateInfo Pack()
        {
            Interop.DedicatedAllocationBufferCreateInfo result = default(Interop.DedicatedAllocationBufferCreateInfo);
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
    /// If the pname:pNext list includes a
    /// sname:VkDedicatedAllocationImageCreateInfoNV structure, then that
    /// structure includes an enable controlling whether the image will have a
    /// dedicated memory allocation bound to it.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Using a dedicated allocation for color and
    /// depth/stencil attachments or other large images may: improve
    /// performance on some devices. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:dedicatedAllocation is ename:VK_TRUE,
    /// sname:VkImageCreateInfo::pname:flags must: not include
    /// ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT, ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT,
    /// or ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT ****
    /// </para>
    /// </summary>
    public struct DedicatedAllocationImageCreateInfo
    {
        /// <summary>
        /// pname:dedicatedAllocation indicates whether the image will have a
        /// dedicated allocation bound to it.
        /// </summary>
        public Bool32 DedicatedAllocation
        {
            get;
            set;
        }
        
        internal unsafe Interop.DedicatedAllocationImageCreateInfo Pack()
        {
            Interop.DedicatedAllocationImageCreateInfo result = default(Interop.DedicatedAllocationImageCreateInfo);
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
    /// If the pname:pNext list includes a
    /// sname:VkDedicatedAllocationMemoryAllocateInfoNV structure, then that
    /// structure includes a handle of the sole buffer or image resource that
    /// the memory can: be bound to.
    /// </para>
    /// <para>
    /// .Valid Usage **** * At least one of pname:image and pname:buffer must:
    /// be sname:VK_NULL_HANDLE * If pname:image is not sname:VK_NULL_HANDLE,
    /// the image must: have been created with
    /// sname:VkDedicatedAllocationImageCreateInfoNV::pname:dedicatedAllocation equal
    /// to ename:VK_TRUE * If pname:buffer is not sname:VK_NULL_HANDLE, the
    /// buffer must: have been created with
    /// sname:VkDedicatedAllocationBufferCreateInfoNV::pname:dedicatedAllocation equal
    /// to ename:VK_TRUE * If pname:image is not sname:VK_NULL_HANDLE,
    /// sname:VkMemoryAllocateInfo::pname:allocationSize must: equal the
    /// sname:VkMemoryRequirements::pname:size of the image * If pname:buffer
    /// is not sname:VK_NULL_HANDLE,
    /// sname:VkMemoryAllocateInfo::pname:allocationSize must: equal the
    /// sname:VkMemoryRequirements::pname:size of the buffer ****
    /// </para>
    /// </summary>
    public struct DedicatedAllocationMemoryAllocateInfo
    {
        /// <summary>
        /// pname:image is sname:VK_NULL_HANDLE or a handle of an image which
        /// this memory will be bound to.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:buffer is sname:VK_NULL_HANDLE or a handle of a buffer which
        /// this memory will be bound to.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }
        
        internal unsafe Interop.DedicatedAllocationMemoryAllocateInfo Pack()
        {
            Interop.DedicatedAllocationMemoryAllocateInfo result = default(Interop.DedicatedAllocationMemoryAllocateInfo);
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
    /// <para>
    /// .Valid Usage **** * pname:offset must: be less than the size of
    /// pname:buffer * If pname:range is not equal to ename:VK_WHOLE_SIZE,
    /// pname:range must: be greater than `0` * If pname:range is not equal to
    /// ename:VK_WHOLE_SIZE, pname:range must: be less than or equal to the
    /// size of pname:buffer minus pname:offset ****
    /// </para>
    /// </summary>
    public struct DescriptorBufferInfo
    {
        /// <summary>
        /// pname:buffer is the buffer resource.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:offset is the offset in bytes from the start of pname:buffer.
        /// Access to buffer memory via this descriptor uses addressing that is
        /// relative to this starting offset.
        /// </summary>
        public ulong Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:range is the size in bytes that is used for this descriptor
        /// update, or ename:VK_WHOLE_SIZE to use the range from pname:offset
        /// to the end of the buffer. + -- [NOTE] .Note ==== When using
        /// ename:VK_WHOLE_SIZE, the effective range must: not be larger than
        /// the maximum range for the descriptor type
        /// (&lt;&lt;features-limits-maxUniformBufferRange, maxUniformBufferRange&gt;&gt;
        /// or &lt;&lt;features-limits-maxStorageBufferRange,
        /// maxStorageBufferRange&gt;&gt;). This means that ename:VK_WHOLE_SIZE
        /// is not typically useful in the common case where uniform buffer
        /// descriptors are suballocated from a buffer that is much larger than
        /// pname:maxUniformBufferRange. ==== -- + For
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC and
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC descriptor types,
        /// pname:offset is the base offset from which the dynamic offset is
        /// applied and pname:range is the static size used for all dynamic
        /// offsets.
        /// </summary>
        public ulong Range
        {
            get;
            set;
        }
        
        internal unsafe Interop.DescriptorBufferInfo Pack()
        {
            Interop.DescriptorBufferInfo result = default(Interop.DescriptorBufferInfo);
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
    /// <para>
    /// Members of sname:VkDescriptorImageInfo that are not used in an update
    /// (as described above) are ignored.
    /// </para>
    /// </summary>
    public struct DescriptorImageInfo
    {
        /// <summary>
        /// pname:sampler is a sampler handle, and is used in descriptor
        /// updates for types ename:VK_DESCRIPTOR_TYPE_SAMPLER and
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER if the binding
        /// being updated does not use immutable samplers.
        /// </summary>
        public Sampler Sampler
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageView is an image view handle, and is used in descriptor
        /// updates for types ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER,
        /// and ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT.
        /// </summary>
        public ImageView ImageView
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageLayout is the layout that the image will be in at the
        /// time this descriptor is accessed. pname:imageLayout is used in
        /// descriptor updates for types
        /// ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE,
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and
        /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT.
        /// </summary>
        public ImageLayout ImageLayout
        {
            get;
            set;
        }
        
        internal unsafe Interop.DescriptorImageInfo Pack()
        {
            Interop.DescriptorImageInfo result = default(Interop.DescriptorImageInfo);
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
    /// Structure specifying parameters of a newly created descriptor pool.
    /// </summary>
    public struct DescriptorPoolCreateInfo
    {
        /// <summary>
        /// pname:flags specifies certain supported operations on the pool.
        /// Bits which can: be set include: + --
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
    /// .Valid Usage **** * pname:descriptorSetCount must: not be greater than
    /// the number of sets that are currently available for allocation in
    /// pname:descriptorPool * pname:descriptorPool must: have enough free
    /// descriptor capacity remaining to allocate the descriptor sets of the
    /// specified layouts ****
    /// </para>
    /// </summary>
    public struct DescriptorSetAllocateInfo
    {
        /// <summary>
        /// pname:descriptorPool is the pool which the sets will be allocated
        /// from.
        /// </summary>
        public DescriptorPool DescriptorPool
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSetLayouts is an array of descriptor set layouts, with each
        /// member specifying how the corresponding descriptor set is
        /// allocated.
        /// </summary>
        public DescriptorSetLayout[] SetLayouts
        {
            get;
            set;
        }
        
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
    /// The above layout definition allows the descriptor bindings to be
    /// specified sparsely such that not all binding numbers between 0 and the
    /// maximum binding number need to be specified in the pname:pBindings
    /// array. However, all binding numbers between 0 and the maximum binding
    /// number in the slink:VkDescriptorSetLayoutCreateInfo::pname:pBindings
    /// array may: consume memory in the descriptor set layout even if not all
    /// descriptor bindings are used, though it should: not consume additional
    /// memory from the descriptor pool.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== The maximum binding number specified should: be as
    /// compact as possible to avoid wasted memory. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_SAMPLER or
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and
    /// pname:descriptorCount is not `0` and pname:pImmutableSamplers is not
    /// `NULL`, pname:pImmutableSamplers must: be a pointer to an array of
    /// pname:descriptorCount valid sname:VkSampler handles * If
    /// pname:descriptorCount is not `0`, pname:stageFlags must: be a valid
    /// combination of elink:VkShaderStageFlagBits values ****
    /// </para>
    /// </summary>
    public struct DescriptorSetLayoutBinding
    {
        /// <summary>
        /// pname:binding is the binding number of this entry and corresponds
        /// to a resource of the same binding number in the shader stages.
        /// </summary>
        public uint Binding
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:descriptorType is a elink:VkDescriptorType specifying which
        /// type of resource descriptors are used for this binding.
        /// </summary>
        public DescriptorType DescriptorType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:descriptorCount is the number of descriptors contained in the
        /// binding, accessed in a shader as an array. If pname:descriptorCount
        /// is zero this binding entry is reserved and the resource must: not
        /// be accessed from any stage via this binding within any pipeline
        /// using the set layout.
        /// </summary>
        public uint DescriptorCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:stageFlags member is a bitmask of elink:VkShaderStageFlagBits
        /// specifying which pipeline shader stages can: access a resource for
        /// this binding. ename:VK_SHADER_STAGE_ALL is a shorthand specifying
        /// that all defined shader stages, including any additional stages
        /// defined by extensions, can: access the resource. + -- If a shader
        /// stage is not included in pname:stageFlags, then a resource must:
        /// not be accessed from that stage via this binding within any
        /// pipeline using the set layout. There are no limitations on what
        /// combinations of stages can: be used by a descriptor binding, and in
        /// particular a binding can: be used by both graphics stages and the
        /// compute stage. --
        /// </summary>
        public ShaderStageFlags StageFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pImmutableSamplers affects initialization of samplers. If
        /// pname:descriptorType specifies a ename:VK_DESCRIPTOR_TYPE_SAMPLER
        /// or ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER type descriptor,
        /// then pname:pImmutableSamplers can: be used to initialize a set of
        /// _immutable samplers_. Immutable samplers are permanently bound into
        /// the set layout; later binding a sampler into an immutable sampler
        /// slot in a descriptor set is not allowed. If
        /// pname:pImmutableSamplers is not `NULL`, then it is considered to be
        /// a pointer to an array of sampler handles that will be consumed by
        /// the set layout and used for the corresponding binding. If
        /// pname:pImmutableSamplers is `NULL`, then the sampler slots are
        /// dynamic and sampler handles must: be bound into descriptor sets
        /// using this layout. If pname:descriptorType is not one of these
        /// descriptor types, then pname:pImmutableSamplers is ignored.
        /// </summary>
        public Sampler[] ImmutableSamplers
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.DescriptorSetLayoutBinding* MarshalTo()
        {
            return (Interop.DescriptorSetLayoutBinding*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created descriptor set
    /// layout.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The
    /// slink:VkDescriptorSetLayoutBinding::pname:binding members of the
    /// elements of the pname:pBindings array must: each have different values.
    /// ****
    /// </para>
    /// </summary>
    public struct DescriptorSetLayoutCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public DescriptorSetLayoutCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pBindings is a pointer to an array of
        /// slink:VkDescriptorSetLayoutBinding structures.
        /// </summary>
        public DescriptorSetLayoutBinding[] Bindings
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * The pname:queueFamilyIndex member of any given
    /// element of pname:pQueueCreateInfos must: be unique within
    /// pname:pQueueCreateInfos ****
    /// </para>
    /// </summary>
    public struct DeviceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public DeviceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pQueueCreateInfos is a pointer to an array of
        /// slink:VkDeviceQueueCreateInfo structures describing the queues that
        /// are requested to be created along with the logical device. Refer to
        /// the &lt;&lt;devsandqueues-queue-creation,Queue Creation&gt;&gt;
        /// section below for further details.
        /// </summary>
        public DeviceQueueCreateInfo[] QueueCreateInfos
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:ppEnabledLayerNames is deprecated and ignored. See
        /// &lt;&lt;extended-functionality-device-layer-deprecation,Device Layer
        /// Deprecation&gt;&gt;.
        /// </summary>
        public string[] EnabledLayerNames
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:ppEnabledExtensionNames is a pointer to an array of
        /// pname:enabledExtensionCount null-terminated UTF-8 strings
        /// containing the names of extensions to enable for the created
        /// device. See the
        /// &lt;&lt;extended-functionality-extensions,Extensions&gt;&gt; section
        /// for further details.
        /// </summary>
        public string[] EnabledExtensionNames
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pEnabledFeatures is `NULL` or a pointer to a
        /// slink:VkPhysicalDeviceFeatures structure that contains boolean
        /// indicators of all the features to be enabled. Refer to the
        /// &lt;&lt;features-features,Features&gt;&gt; section for further
        /// details.
        /// </summary>
        public PhysicalDeviceFeatures EnabledFeatures
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * pname:queueFamilyIndex must: be less than
    /// pname:pQueueFamilyPropertyCount returned by
    /// fname:vkGetPhysicalDeviceQueueFamilyProperties * pname:queueCount must:
    /// be less than or equal to the pname:queueCount member of the
    /// sname:VkQueueFamilyProperties structure, as returned by
    /// fname:vkGetPhysicalDeviceQueueFamilyProperties in the
    /// pname:pQueueFamilyProperties[pname:queueFamilyIndex] * Each element of
    /// pname:pQueuePriorities must: be between `0.0` and `1.0` inclusive ****
    /// </para>
    /// </summary>
    public struct DeviceQueueCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public DeviceQueueCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:queueFamilyIndex is an unsigned integer indicating the index
        /// of the queue family to create on this device. This index
        /// corresponds to the index of an element of the
        /// pname:pQueueFamilyProperties array that was returned by
        /// fname:vkGetPhysicalDeviceQueueFamilyProperties.
        /// </summary>
        public uint QueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pQueuePriorities is an array of pname:queueCount normalized
        /// floating point values, specifying priorities of work that will be
        /// submitted to each created queue. See
        /// &lt;&lt;devsandqueues-priority,Queue Priority&gt;&gt; for more
        /// information.
        /// </summary>
        public float[] QueuePriorities
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * The pname:width and pname:height members of the
    /// pname:visibleRegion member of pname:parameters must: be greater than
    /// `0` * The pname:refreshRate member of pname:parameters must: be greater
    /// than `0` ****
    /// </para>
    /// </summary>
    public struct DisplayModeCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use, and must: be zero.
        /// </summary>
        public DisplayModeCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:parameters is a sname:VkDisplayModeParametersKHR structure
        /// describing the display parameters to use in creating the new mode.
        /// If the parameters are not compatible with the specified display,
        /// the implementation must: return
        /// ename:VK_ERROR_INITIALIZATION_FAILED.
        /// </summary>
        public DisplayModeParameters Parameters
        {
            get;
            set;
        }
        
        internal unsafe Interop.DisplayModeCreateInfo Pack()
        {
            Interop.DisplayModeCreateInfo result = default(Interop.DisplayModeCreateInfo);
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
    /// Structure describing display mode properties.
    /// </summary>
    public struct DisplayModeProperties
    {
        /// <summary>
        /// pname:displayMode is a handle to the display mode described in this
        /// structure. This handle will be valid for the lifetime of the Vulkan
        /// instance.
        /// </summary>
        public DisplayMode DisplayMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:parameters is a sname:VkDisplayModeParametersKHR structure
        /// describing the display parameters associated with
        /// pname:displayMode.
        /// </summary>
        public DisplayModeParameters Parameters
        {
            get;
            set;
        }
        
        internal static unsafe DisplayModeProperties MarshalFrom(Interop.DisplayModeProperties* value)
        {
            DisplayModeProperties result = new DisplayModeProperties();
            result.Parameters = value->Parameters;
            return result;
        }
    }
    
    /// <summary>
    /// Structure describing display plane properties.
    /// </summary>
    public struct DisplayPlaneProperties
    {
        /// <summary>
        /// pname:currentDisplay is the handle of the display the plane is
        /// currently associated with. If the plane is not currently attached
        /// to any displays, this will be sname:VK_NULL_HANDLE.
        /// </summary>
        public Display CurrentDisplay
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:currentStackIndex is the current z-order of the plane. This
        /// will be between 0 and the value returned by
        /// fname:vkGetPhysicalDeviceDisplayPlanePropertiesKHR() in
        /// pname:pPropertyCount.
        /// </summary>
        public uint CurrentStackIndex
        {
            get;
            set;
        }
        
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
    /// If the extent of the pname:srcRect and pname:dstRect are not equal, the
    /// presented pixels will be scaled accordingly.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:srcRect must: specify a rectangular region
    /// that is a subset of the image being presented * pname:dstRect must:
    /// specify a rectangular region that is a subset of the
    /// pname:visibleRegion parameter of the display mode the swapchain being
    /// presented uses * If the pname:persistentContent member of the
    /// sname:VkDisplayPropertiesKHR structure returned by
    /// fname:vkGetPhysicalDeviceDisplayPropertiesKHR for the display the
    /// present operation targets then pname:persistent must: be ename:VK_FALSE
    /// ****
    /// </para>
    /// </summary>
    public struct DisplayPresentInfo
    {
        /// <summary>
        /// pname:srcRect is a rectangular region of pixels to present. It
        /// must: be a subset of the image being presented. If
        /// sname:VkDisplayPresentInfoKHR is not specified, this region will be
        /// assumed to be the entire presentable image.
        /// </summary>
        public Rect2D SourceRect
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstRect is a rectangular region within the visible region of
        /// the swapchain's display mode. If sname:VkDisplayPresentInfoKHR is
        /// not specified, this region will be assumed to be the entire visible
        /// region of the visible region of the swapchain's mode. If the
        /// specified rectangle is a subset of the display mode's visible
        /// region, content from display planes below the swapchain's plane
        /// will be visible outside the rectangle. If there are no planes below
        /// the swapchain's, the area outside the specified rectangle will be
        /// black. If portions of the specified rectangle are outside of the
        /// display's visible region, pixels mapping only to those portions of
        /// the rectangle will be discarded.
        /// </summary>
        public Rect2D DestinationRect
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:persistent: If this is ename:VK_TRUE, the display engine will
        /// enable buffered mode on displays that support it. This allows the
        /// display engine to stop sending content to the display until a new
        /// image is presented. The display will instead maintain a copy of the
        /// last presented image. This allows less power to be used, but may:
        /// increase presentation latency. If sname:VkDisplayPresentInfoKHR is
        /// not specified, persistent mode will not be used.
        /// </summary>
        public Bool32 Persistent
        {
            get;
            set;
        }
        
        internal unsafe Interop.DisplayPresentInfo Pack()
        {
            Interop.DisplayPresentInfo result = default(Interop.DisplayPresentInfo);
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
    /// <para>
    /// [NOTE] .Note ==== For devices which have no natural value to return
    /// here, implementations should: return the maximum resolution supported.
    /// ====
    /// </para>
    /// <para>
    /// * pname:supportedTransforms tells which transforms are supported by
    /// this display. This will contain one or more of the bits from
    /// sname:VkSurfaceTransformFlagsKHR. * pname:planeReorderPossible tells
    /// whether the planes on this display can: have their z order changed. If
    /// this is ename:VK_TRUE, the application can: re-arrange the planes on
    /// this display in any order relative to each other. *
    /// pname:persistentContent tells whether the display supports
    /// self-refresh/internal buffering. If this is true, the application can:
    /// submit persistent present operations on swapchains created against this
    /// display.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Persistent presents may: have higher latency, and
    /// may: use less power when the screen content is updated infrequently, or
    /// when only a portion of the screen needs to be updated in most frames.
    /// ====
    /// </para>
    /// </summary>
    public struct DisplayProperties
    {
        /// <summary>
        /// pname:display is a handle that is used to refer to the display
        /// described here. This handle will be valid for the lifetime of the
        /// Vulkan instance.
        /// </summary>
        public Display Display
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:displayName is a pointer to a NULL-terminated string
        /// containing the name of the display. Generally, this will be the
        /// name provided by the display's EDID. It can: be `NULL` if no
        /// suitable name is available.
        /// </summary>
        public string DisplayName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:physicalDimensions describes the physical width and height of
        /// the visible portion of the display, in millimeters.
        /// </summary>
        public Extent2D PhysicalDimensions
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:physicalResolution describes the physical, native, or
        /// preferred resolution of the display.
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
    /// Structure specifying parameters of a newly created display plane
    /// surface object.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Creating a display surface must: not modify the state
    /// of the displays, planes, or other resources it names. For example, it
    /// must: not apply the specified mode to be set on the associated display.
    /// Application of display configuration occurs as a side effect of
    /// presenting to a display surface. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:planeIndex must: be less than the number of
    /// display planes supported by the device as determined by calling
    /// fname:vkGetPhysicalDeviceDisplayPlanePropertiesKHR * If the
    /// pname:planeReorderPossible member of the sname:VkDisplayPropertiesKHR
    /// structure returned by fname:vkGetPhysicalDeviceDisplayPropertiesKHR for
    /// the display corresponding to pname:displayMode is ename:VK_TRUE then
    /// pname:planeStackIndex must: be less than the number of display planes
    /// supported by the device as determined by calling
    /// fname:vkGetPhysicalDeviceDisplayPlanePropertiesKHR; otherwise
    /// pname:planeStackIndex must: equal the pname:currentStackIndex member of
    /// sname:VkDisplayPlanePropertiesKHR returned by
    /// fname:vkGetPhysicalDeviceDisplayPlanePropertiesKHR for the display
    /// plane corresponding to pname:displayMode * If pname:alphaMode is
    /// ename:VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR then pname:globalAlpha
    /// must: be between `0` and `1`, inclusive * pname:alphaMode must: be `0`
    /// or one of the bits present in the pname:supportedAlpha member of
    /// sname:VkDisplayPlaneCapabilitiesKHR returned by
    /// fname:vkGetDisplayPlaneCapabilitiesKHR for the display plane
    /// corresponding to pname:displayMode * The pname:width and pname:height
    /// members of pname:imageExtent must: be less than the
    /// pname:maxImageDimensions2D member of sname:VkPhysicalDeviceLimits ****
    /// </para>
    /// </summary>
    public struct DisplaySurfaceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use, and must: be zero.
        /// </summary>
        public DisplaySurfaceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:displayMode is the mode to use when displaying this surface.
        /// </summary>
        public DisplayMode DisplayMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:planeIndex is the plane on which this surface appears.
        /// </summary>
        public uint PlaneIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:planeStackIndex is the z-order of the plane.
        /// </summary>
        public uint PlaneStackIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:transform is the transform to apply to the images as part of
        /// the scanout operation.
        /// </summary>
        public SurfaceTransformFlags Transform
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:globalAlpha is the global alpha value. This value is ignored
        /// if pname:alphaMode is not
        /// ename:VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR.
        /// </summary>
        public float GlobalAlpha
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:alphaMode is the type of alpha blending to use.
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
        
        internal unsafe Interop.DisplaySurfaceCreateInfo* MarshalTo()
        {
            return (Interop.DisplaySurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying parameters of a newly created event.
    /// </summary>
    public struct EventCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public EventCreateFlags Flags
        {
            get;
            set;
        }
        
        internal unsafe Interop.EventCreateInfo Pack()
        {
            Interop.EventCreateInfo result = default(Interop.EventCreateInfo);
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
        
        internal unsafe Interop.ExportMemoryAllocateInfo Pack()
        {
            Interop.ExportMemoryAllocateInfo result = default(Interop.ExportMemoryAllocateInfo);
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
    /// When slink:VkExportMemoryAllocateInfoNV::pname:handleTypes includes
    /// ename:VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV, add a
    /// sname:VkExportMemoryWin32HandleInfoNV to the pname:pNext chain of the
    /// slink:VkExportMemoryAllocateInfoNV structure to specify security
    /// attributes and access rights for the memory object's external handle.
    /// </para>
    /// <para>
    /// If this structure is not present, or if pname:pAttributes is set to
    /// `NULL`, default security descriptor values will be used, and child
    /// processes created by the application will not inherit the handle, as
    /// described in the MSDN documentation for ``Synchronization Object
    /// Security and Access Rights''[1]. Further, if the structure is not
    /// present, the access rights will be
    /// </para>
    /// <para>
    /// code:DXGI_SHARED_RESOURCE_READ | code:DXGI_SHARED_RESOURCE_WRITE
    /// </para>
    /// <para>
    /// [1]
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms686670.aspx
    /// </para>
    /// </summary>
    public struct ExportMemoryWin32HandleInfo
    {
        /// <summary>
        /// pname:pAttributes is a pointer to a Windows
        /// code:SECURITY_ATTRIBUTES structure specifying security attributes
        /// of the handle.
        /// </summary>
        public SECURITY_ATTRIBUTES Attributes
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dwAccess is a code:DWORD specifying access rights of the
        /// handle.
        /// </summary>
        public uint DwAccess
        {
            get;
            set;
        }
        
        internal unsafe Interop.ExportMemoryWin32HandleInfo Pack()
        {
            Interop.ExportMemoryWin32HandleInfo result = default(Interop.ExportMemoryWin32HandleInfo);
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
    /// Structure specifying a extension properties.
    /// </summary>
    public struct ExtensionProperties
    {
        /// <summary>
        /// pname:extensionName is a null-terminated string specifying the name
        /// of the extension.
        /// </summary>
        public string ExtensionName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:specVersion is the version of this extension. It is an
        /// integer, incremented with backward compatible changes.
        /// </summary>
        public Version SpecVersion
        {
            get;
            set;
        }
        
        internal static unsafe ExtensionProperties MarshalFrom(Interop.ExtensionProperties* value)
        {
            ExtensionProperties result = new ExtensionProperties();
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
    /// If the pname:pNext list includes a
    /// sname:VkExternalMemoryImageCreateInfoNV structure, then that structure
    /// defines a set of external memory handle types that may: be used as
    /// backing store for the image.
    /// </para>
    /// </summary>
    public struct ExternalMemoryImageCreateInfo
    {
        /// <summary>
        /// pname:handleTypes is a bitmask of
        /// elink:VkExternalMemoryHandleTypeFlagBitsNV specifying one or more
        /// external memory handle types. The types must: all be compatible
        /// with each other and the other image creation parameters, as
        /// reported by
        /// flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV.
        /// </summary>
        public ExternalMemoryHandleTypeFlags HandleTypes
        {
            get;
            set;
        }
        
        internal unsafe Interop.ExternalMemoryImageCreateInfo Pack()
        {
            Interop.ExternalMemoryImageCreateInfo result = default(Interop.ExternalMemoryImageCreateInfo);
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
    /// Structure specifying parameters of a newly created fence.
    /// </summary>
    public struct FenceCreateInfo
    {
        /// <summary>
        /// pname:flags defines the initial state and behavior of the fence.
        /// Bits which can: be set include: + --
        /// </summary>
        public FenceCreateFlags Flags
        {
            get;
            set;
        }
        
        internal unsafe Interop.FenceCreateInfo Pack()
        {
            Interop.FenceCreateInfo result = default(Interop.FenceCreateInfo);
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
    /// <para>
    /// Image subresources used as attachments must: not be used via any
    /// non-attachment usage for the duration of a render pass instance.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== This restriction means that the render pass has full
    /// knowledge of all uses of all of the attachments, so that the
    /// implementation is able to make correct decisions about when and how to
    /// perform layout transitions, when to overlap execution of subpasses,
    /// etc. ====
    /// </para>
    /// <para>
    /// It is legal for a subpass to use no color or depth/stencil attachments,
    /// and rather use shader side effects such as image stores and atomics to
    /// produce an output. In this case, the subpass continues to use the
    /// pname:width, pname:height, and pname:layers of the framebuffer to
    /// define the dimensions of the rendering area, and the
    /// pname:rasterizationSamples from each pipeline's
    /// slink:VkPipelineMultisampleStateCreateInfo to define the number of
    /// samples used in rasterization; however, if
    /// slink:VkPhysicalDeviceFeatures::pname:variableMultisampleRate is
    /// code:VK_FALSE, then all pipelines to be bound with a given
    /// zero-attachment subpass must: have the same value for
    /// slink:VkPipelineMultisampleStateCreateInfo::pname:rasterizationSamples.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:attachmentCount must: be equal to the
    /// attachment count specified in pname:renderPass * Any given element of
    /// pname:pAttachments that is used as a color attachment or resolve
    /// attachment by pname:renderPass must: have been created with a
    /// pname:usage value including ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT *
    /// Any given element of pname:pAttachments that is used as a depth/stencil
    /// attachment by pname:renderPass must: have been created with a
    /// pname:usage value including
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT * Any given element
    /// of pname:pAttachments that is used as an input attachment by
    /// pname:renderPass must: have been created with a pname:usage value
    /// including ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT * Any given element
    /// of pname:pAttachments must: have been created with an elink:VkFormat
    /// value that matches the elink:VkFormat specified by the corresponding
    /// sname:VkAttachmentDescription in pname:renderPass * Any given element
    /// of pname:pAttachments must: have been created with a pname:samples
    /// value that matches the pname:samples value specified by the
    /// corresponding sname:VkAttachmentDescription in pname:renderPass * Any
    /// given element of pname:pAttachments must: have dimensions at least as
    /// large as the corresponding framebuffer dimension * Any given element of
    /// pname:pAttachments must: only specify a single mip level * Any given
    /// element of pname:pAttachments must: have been created with the identity
    /// swizzle * pname:width must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxFramebufferWidth * pname:height
    /// must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxFramebufferHeight * pname:layers
    /// must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxFramebufferLayers ****
    /// </para>
    /// </summary>
    public struct FramebufferCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public FramebufferCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:renderPass is a render pass that defines what render passes
        /// the framebuffer will be compatible with. See
        /// &lt;&lt;renderpass-compatibility,Render Pass Compatibility&gt;&gt;
        /// for details.
        /// </summary>
        public RenderPass RenderPass
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pAttachments is an array of sname:VkImageView handles, each
        /// of which will be used as the corresponding attachment in a render
        /// pass instance.
        /// </summary>
        public ImageView[] Attachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:width, pname:height and pname:layers define the dimensions of
        /// the framebuffer.
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
        
        internal unsafe Interop.FramebufferCreateInfo* MarshalTo()
        {
            return (Interop.FramebufferCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created graphics pipeline.
    /// </para>
    /// <para>
    /// The parameters pname:basePipelineHandle and pname:basePipelineIndex are
    /// described in more detail in
    /// &lt;&lt;pipelines-pipeline-derivatives,Pipeline Derivatives&gt;&gt;.
    /// </para>
    /// <para>
    /// pname:pStages points to an array of
    /// slink:VkPipelineShaderStageCreateInfo structures, which were previously
    /// described in &lt;&lt;pipelines-compute,Compute Pipelines&gt;&gt;.
    /// </para>
    /// <para>
    /// Bits which can: be set in pname:flags are:
    /// </para>
    /// </summary>
    public struct GraphicsPipelineCreateInfo
    {
        /// <summary>
        /// pname:flags is a bitmask of elink:VkPipelineCreateFlagBits
        /// controlling how the pipeline will be generated, as described below.
        /// </summary>
        public PipelineCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pStages is an array of size pname:stageCount structures of
        /// type slink:VkPipelineShaderStageCreateInfo describing the set of
        /// the shader stages to be included in the graphics pipeline.
        /// </summary>
        public PipelineShaderStageCreateInfo[] Stages
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pVertexInputState is a pointer to an instance of the
        /// slink:VkPipelineVertexInputStateCreateInfo structure.
        /// </summary>
        public PipelineVertexInputStateCreateInfo? VertexInputState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pInputAssemblyState is a pointer to an instance of the
        /// slink:VkPipelineInputAssemblyStateCreateInfo structure which
        /// determines input assembly behavior, as described in
        /// &lt;&lt;drawing, Drawing Commands&gt;&gt;.
        /// </summary>
        public PipelineInputAssemblyStateCreateInfo? InputAssemblyState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pTessellationState is a pointer to an instance of the
        /// slink:VkPipelineTessellationStateCreateInfo structure, or `NULL` if
        /// the pipeline does not include a tessellation control shader stage
        /// and tessellation evaluation shader stage.
        /// </summary>
        public PipelineTessellationStateCreateInfo? TessellationState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pViewportState is a pointer to an instance of the
        /// slink:VkPipelineViewportStateCreateInfo structure, or `NULL` if the
        /// pipeline has rasterization disabled.
        /// </summary>
        public PipelineViewportStateCreateInfo? ViewportState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pRasterizationState is a pointer to an instance of the
        /// slink:VkPipelineRasterizationStateCreateInfo structure.
        /// </summary>
        public PipelineRasterizationStateCreateInfo? RasterizationState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pMultisampleState is a pointer to an instance of the
        /// slink:VkPipelineMultisampleStateCreateInfo, or `NULL` if the
        /// pipeline has rasterization disabled.
        /// </summary>
        public PipelineMultisampleStateCreateInfo? MultisampleState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pDepthStencilState is a pointer to an instance of the
        /// slink:VkPipelineDepthStencilStateCreateInfo structure, or `NULL` if
        /// the pipeline has rasterization disabled or if the subpass of the
        /// render pass the pipeline is created against does not use a
        /// depth/stencil attachment.
        /// </summary>
        public PipelineDepthStencilStateCreateInfo? DepthStencilState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pColorBlendState is a pointer to an instance of the
        /// slink:VkPipelineColorBlendStateCreateInfo structure, or `NULL` if
        /// the pipeline has rasterization disabled or if the subpass of the
        /// render pass the pipeline is created against does not use any color
        /// attachments.
        /// </summary>
        public PipelineColorBlendStateCreateInfo? ColorBlendState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pDynamicState is a pointer to
        /// slink:VkPipelineDynamicStateCreateInfo and is used to indicate
        /// which properties of the pipeline state object are dynamic and can:
        /// be changed independently of the pipeline state. This can: be
        /// `NULL`, which means no state in the pipeline is considered dynamic.
        /// </summary>
        public PipelineDynamicStateCreateInfo? DynamicState
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:layout is the description of binding locations used by both
        /// the pipeline and descriptor sets used with the pipeline.
        /// </summary>
        public PipelineLayout Layout
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:renderPass is a handle to a render pass object describing the
        /// environment in which the pipeline will be used; the pipeline must:
        /// only be used with an instance of any render pass compatible with
        /// the one provided. See &lt;&lt;renderpass-compatibility,Render Pass
        /// Compatibility&gt;&gt; for more information.
        /// </summary>
        public RenderPass RenderPass
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subpass is the index of the subpass in the render pass where
        /// this pipeline will be used.
        /// </summary>
        public uint Subpass
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:basePipelineHandle is a pipeline to derive from.
        /// </summary>
        public Pipeline BasePipelineHandle
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:basePipelineIndex is an index into the pname:pCreateInfos
        /// parameter to use as a pipeline to derive from.
        /// </summary>
        public int BasePipelineIndex
        {
            get;
            set;
        }
        
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
    /// For each element of the pname:pRegions array, a blit operation is
    /// performed the specified source and destination regions.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The pname:aspectMask member of pname:srcSubresource
    /// and pname:dstSubresource must: match * The pname:layerCount member of
    /// pname:srcSubresource and pname:dstSubresource must: match * If either
    /// of the calling command's pname:srcImage or pname:dstImage parameters
    /// are of elink:VkImageType ename:VK_IMAGE_TYPE_3D, the
    /// pname:baseArrayLayer and pname:layerCount members of both
    /// pname:srcSubresource and pname:dstSubresource must: be `0` and `1`,
    /// respectively * The pname:aspectMask member of pname:srcSubresource
    /// must: specify aspects present in the calling command's pname:srcImage *
    /// The pname:aspectMask member of pname:dstSubresource must: specify
    /// aspects present in the calling command's pname:dstImage * The
    /// pname:layerCount member of pname:dstSubresource must: be equal to the
    /// pname:layerCount member of pname:srcSubresource *
    /// pname:srcOffset[0].pname:x and pname:srcOffset[1].pname:x must: both be
    /// greater than or equal to `0` and less than or equal to the source image
    /// subresource width * pname:srcOffset[0].pname:y and
    /// pname:srcOffset[1].pname:y must: both be greater than or equal to `0`
    /// and less than or equal to the source image subresource height ** If the
    /// calling command's pname:srcImage is of type ename:VK_IMAGE_TYPE_1D,
    /// then pname:srcOffset[0].y must: be `0` and pname:srcOffset[1].y must:
    /// be `1`. * pname:srcOffset[0].pname:z and pname:srcOffset[1].pname:z
    /// must: both be greater than or equal to `0` and less than or equal to
    /// the source image subresource depth ** If the calling command's
    /// pname:srcImage is of type ename:VK_IMAGE_TYPE_1D or
    /// ename:VK_IMAGE_TYPE_2D, then pname:srcOffset[0].z must: be `0` and
    /// pname:srcOffset[1].z must: be `1`. * pname:dstOffset[0].pname:x and
    /// pname:dstOffset[1].pname:x must: both be greater than or equal to `0`
    /// and less than or equal to the destination image subresource width *
    /// pname:dstOffset[0].pname:y and pname:dstOffset[1].pname:y must: both be
    /// greater than or equal to `0` and less than or equal to the destination
    /// image subresource height ** If the calling command's pname:dstImage is
    /// of type ename:VK_IMAGE_TYPE_1D, then pname:dstOffset[0].y must: be `0`
    /// and pname:dstOffset[1].y must: be `1`. * pname:dstOffset[0].pname:z and
    /// pname:dstOffset[1].pname:z must: both be greater than or equal to `0`
    /// and less than or equal to the destination image subresource depth ** If
    /// the calling command's pname:dstImage is of type ename:VK_IMAGE_TYPE_1D
    /// or ename:VK_IMAGE_TYPE_2D, then pname:dstOffset[0].z must: be `0` and
    /// pname:dstOffset[1].z must: be `1`. ****
    /// </para>
    /// </summary>
    public struct ImageBlit
    {
        /// <summary>
        /// pname:srcSubresource is the subresource to blit from.
        /// </summary>
        public ImageSubresourceLayers SourceSubresource
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:srcOffsets is an array of two slink:VkOffset3D structures
        /// specifying the bounds of the source region within
        /// pname:srcSubresource.
        /// </summary>
        public Offset3D[] SourceOffsets
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstSubresource is the subresource to blit into.
        /// </summary>
        public ImageSubresourceLayers DestinationSubresource
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstOffsets is an array of two slink:VkOffset3D structures
        /// specifying the bounds of the destination region within
        /// pname:dstSubresource.
        /// </summary>
        public Offset3D[] DestinationOffsets
        {
            get;
            set;
        }
        
        internal unsafe Interop.ImageBlit Pack()
        {
            Interop.ImageBlit result = default(Interop.ImageBlit);
            Validate.CheckLength(this.SourceOffsets, 2, "SourceOffsets");
            MemUtil.WriteToPtr((IntPtr)(&result.SourceOffsets), this.SourceOffsets, 0, 2);
            Validate.CheckLength(this.DestinationOffsets, 2, "DestinationOffsets");
            MemUtil.WriteToPtr((IntPtr)(&result.DestinationOffsets), this.DestinationOffsets, 0, 2);
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
    /// <para>
    /// Valid limits for the image pname:extent, pname:mipLevels,
    /// pname:arrayLayers and pname:samples members are queried with the
    /// flink:vkGetPhysicalDeviceImageFormatProperties command.
    /// </para>
    /// <para>
    /// Images created with pname:tiling equal to ename:VK_IMAGE_TILING_LINEAR
    /// have further restrictions on their limits and capabilities compared to
    /// images created with pname:tiling equal to
    /// ename:VK_IMAGE_TILING_OPTIMAL. Creation of images with tiling
    /// ename:VK_IMAGE_TILING_LINEAR may: not be supported unless other
    /// parameters meet all of the constraints:
    /// </para>
    /// <para>
    /// * pname:imageType is ename:VK_IMAGE_TYPE_2D * pname:format is not a
    /// depth/stencil format * pname:mipLevels is 1 * pname:arrayLayers is 1 *
    /// pname:samples is ename:VK_SAMPLE_COUNT_1_BIT * pname:usage only
    /// includes ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT and/or
    /// ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT
    /// </para>
    /// <para>
    /// Implementations may: support additional limits and capabilities beyond
    /// those listed above. To determine the specific capabilities of an
    /// implementation, query the valid pname:usage bits by calling
    /// flink:vkGetPhysicalDeviceFormatProperties and the valid limits for
    /// pname:mipLevels and pname:arrayLayers by calling
    /// flink:vkGetPhysicalDeviceImageFormatProperties.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:sharingMode is
    /// ename:VK_SHARING_MODE_CONCURRENT, pname:pQueueFamilyIndices must: be a
    /// pointer to an array of pname:queueFamilyIndexCount basetype:uint32_t
    /// values * If pname:sharingMode is ename:VK_SHARING_MODE_CONCURRENT,
    /// pname:queueFamilyIndexCount must: be greater than `1` * pname:format
    /// must: not be ename:VK_FORMAT_UNDEFINED * The pname:width, pname:height,
    /// and pname:depth members of pname:extent must: all be greater than `0` *
    /// pname:mipLevels must: be greater than `0` * pname:arrayLayers must: be
    /// greater than `0` * If pname:flags contains
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:imageType must be
    /// ename:VK_IMAGE_TYPE_2D * If pname:imageType is ename:VK_IMAGE_TYPE_1D,
    /// pname:extent.width must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxImageDimension1D, or
    /// sname:VkImageFormatProperties::pname:maxExtent.width (as returned by
    /// fname:vkGetPhysicalDeviceImageFormatProperties with pname:format,
    /// pname:type, pname:tiling, pname:usage, and pname:flags equal to those
    /// in this structure) - whichever is higher * If pname:imageType is
    /// ename:VK_IMAGE_TYPE_2D and pname:flags does not contain
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:extent.width and
    /// pname:extent.height must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxImageDimension2D, or
    /// sname:VkImageFormatProperties::pname:maxExtent.width/height (as
    /// returned by fname:vkGetPhysicalDeviceImageFormatProperties with
    /// pname:format, pname:type, pname:tiling, pname:usage, and pname:flags
    /// equal to those in this structure) - whichever is higher * If
    /// pname:imageType is ename:VK_IMAGE_TYPE_2D and pname:flags contains
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:extent.width and
    /// pname:extent.height must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxImageDimensionCube, or
    /// sname:VkImageFormatProperties::pname:maxExtent.width/height (as
    /// returned by fname:vkGetPhysicalDeviceImageFormatProperties with
    /// pname:format, pname:type, pname:tiling, pname:usage, and pname:flags
    /// equal to those in this structure) - whichever is higher * If
    /// pname:imageType is ename:VK_IMAGE_TYPE_2D and pname:flags contains
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:extent.width and
    /// pname:extent.height must: be equal and pname:arrayLayers must: be
    /// greater than or equal to 6 * If pname:imageType is
    /// ename:VK_IMAGE_TYPE_3D, pname:extent.width, pname:extent.height and
    /// pname:extent.depth must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxImageDimension3D, or
    /// sname:VkImageFormatProperties::pname:maxExtent.width/height/depth (as
    /// returned by fname:vkGetPhysicalDeviceImageFormatProperties with
    /// pname:format, pname:type, pname:tiling, pname:usage, and pname:flags
    /// equal to those in this structure) - whichever is higher * If
    /// pname:imageType is ename:VK_IMAGE_TYPE_1D, both pname:extent.height and
    /// pname:extent.depth must: be `1` * If pname:imageType is
    /// ename:VK_IMAGE_TYPE_2D, pname:extent.depth must: be `1` *
    /// pname:mipLevels must: be less than or equal to
    /// [eq]#{lfloor}log~2~(max(pname:extent.width, pname:extent.height,
    /// pname:extent.depth)){rfloor} + 1#. * If any of pname:extent.width,
    /// pname:extent.height, or pname:extent.depth are greater than the
    /// equivalently named members of
    /// sname:VkPhysicalDeviceLimits::pname:maxImageDimension3D, pname:mipLevels
    /// must: be less than or equal to
    /// sname:VkImageFormatProperties::pname:maxMipLevels (as returned by
    /// fname:vkGetPhysicalDeviceImageFormatProperties with pname:format,
    /// pname:type, pname:tiling, pname:usage, and pname:flags equal to those
    /// in this structure) * pname:arrayLayers must: be less than or equal to
    /// sname:VkImageFormatProperties::pname:maxArrayLayers (as returned by
    /// fname:vkGetPhysicalDeviceImageFormatProperties with pname:format,
    /// pname:type, pname:tiling, pname:usage, and pname:flags equal to those
    /// in this structure) * If pname:imageType is ename:VK_IMAGE_TYPE_3D,
    /// pname:arrayLayers must: be `1`. * If pname:samples is not
    /// ename:VK_SAMPLE_COUNT_1_BIT, pname:imageType must: be
    /// ename:VK_IMAGE_TYPE_2D, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT, pname:tiling must: be
    /// ename:VK_IMAGE_TILING_OPTIMAL, and pname:mipLevels must: be equal to
    /// `1` * If pname:usage includes
    /// ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT, then bits other than
    /// ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT, ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT,
    /// and ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT must: not be set * If
    /// pname:usage includes ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT,
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT,
    /// or ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT, pname:extent.width must:
    /// be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxFramebufferWidth * If
    /// pname:usage includes ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT,
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, ename:VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT,
    /// or ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT, pname:extent.height must:
    /// be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxFramebufferHeight *
    /// pname:samples must: be a bit value that is set in
    /// sname:VkImageFormatProperties::pname:sampleCounts returned by
    /// fname:vkGetPhysicalDeviceImageFormatProperties with pname:format,
    /// pname:type, pname:tiling, pname:usage, and pname:flags equal to those
    /// in this structure * If the
    /// &lt;&lt;features-features-textureCompressionETC2,ETC2 texture
    /// compression&gt;&gt; feature is not enabled, pname:format must: not be
    /// ename:VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK,
    /// ename:VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK,
    /// ename:VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK,
    /// ename:VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK,
    /// ename:VK_FORMAT_EAC_R11_UNORM_BLOCK, ename:VK_FORMAT_EAC_R11_SNORM_BLOCK,
    /// ename:VK_FORMAT_EAC_R11G11_UNORM_BLOCK, or
    /// ename:VK_FORMAT_EAC_R11G11_SNORM_BLOCK * If the
    /// &lt;&lt;features-features-textureCompressionASTC_LDR,ASTC LDR texture
    /// compression&gt;&gt; feature is not enabled, pname:format must: not be
    /// ename:VK_FORMAT_ASTC_4x4_UNORM_BLOCK, ename:VK_FORMAT_ASTC_4x4_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_5x4_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_5x4_SRGB_BLOCK, ename:VK_FORMAT_ASTC_5x5_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_5x5_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_6x5_UNORM_BLOCK, ename:VK_FORMAT_ASTC_6x5_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_6x6_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_6x6_SRGB_BLOCK, ename:VK_FORMAT_ASTC_8x5_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_8x5_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_8x6_UNORM_BLOCK, ename:VK_FORMAT_ASTC_8x6_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_8x8_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_8x8_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x5_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x5_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x6_UNORM_BLOCK, ename:VK_FORMAT_ASTC_10x6_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x8_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x8_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x10_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x10_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_12x10_UNORM_BLOCK, ename:VK_FORMAT_ASTC_12x10_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_12x12_UNORM_BLOCK, or
    /// ename:VK_FORMAT_ASTC_12x12_SRGB_BLOCK * If the
    /// &lt;&lt;features-features-textureCompressionBC,BC texture
    /// compression&gt;&gt; feature is not enabled, pname:format must: not be
    /// ename:VK_FORMAT_BC1_RGB_UNORM_BLOCK, ename:VK_FORMAT_BC1_RGB_SRGB_BLOCK,
    /// ename:VK_FORMAT_BC1_RGBA_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC1_RGBA_SRGB_BLOCK, ename:VK_FORMAT_BC2_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC2_SRGB_BLOCK, ename:VK_FORMAT_BC3_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC3_SRGB_BLOCK, ename:VK_FORMAT_BC4_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC4_SNORM_BLOCK, ename:VK_FORMAT_BC5_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC5_SNORM_BLOCK, ename:VK_FORMAT_BC6H_UFLOAT_BLOCK,
    /// ename:VK_FORMAT_BC6H_SFLOAT_BLOCK, ename:VK_FORMAT_BC7_UNORM_BLOCK, or
    /// ename:VK_FORMAT_BC7_SRGB_BLOCK * If the
    /// &lt;&lt;features-features-shaderStorageImageMultisample,multisampled storage
    /// images&gt;&gt; feature is not enabled, and pname:usage contains
    /// ename:VK_IMAGE_USAGE_STORAGE_BIT, pname:samples must: be
    /// ename:VK_SAMPLE_COUNT_1_BIT * If the
    /// &lt;&lt;features-features-sparseBinding,sparse bindings&gt;&gt; feature
    /// is not enabled, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT * If the
    /// &lt;&lt;features-features-sparseResidencyImage2D,sparse residency for
    /// 2D images&gt;&gt; feature is not enabled, and pname:imageType is
    /// ename:VK_IMAGE_TYPE_2D, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the
    /// &lt;&lt;features-features-sparseResidencyImage3D,sparse residency for
    /// 3D images&gt;&gt; feature is not enabled, and pname:imageType is
    /// ename:VK_IMAGE_TYPE_3D, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the
    /// &lt;&lt;features-features-sparseResidency2Samples,sparse residency for
    /// images with 2 samples&gt;&gt; feature is not enabled, pname:imageType
    /// is ename:VK_IMAGE_TYPE_2D, and pname:samples is
    /// ename:VK_SAMPLE_COUNT_2_BIT, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the
    /// &lt;&lt;features-features-sparseResidency4Samples,sparse residency for
    /// images with 4 samples&gt;&gt; feature is not enabled, pname:imageType
    /// is ename:VK_IMAGE_TYPE_2D, and pname:samples is
    /// ename:VK_SAMPLE_COUNT_4_BIT, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the
    /// &lt;&lt;features-features-sparseResidency8Samples,sparse residency for
    /// images with 8 samples&gt;&gt; feature is not enabled, pname:imageType
    /// is ename:VK_IMAGE_TYPE_2D, and pname:samples is
    /// ename:VK_SAMPLE_COUNT_8_BIT, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If the
    /// &lt;&lt;features-features-sparseResidency16Samples,sparse residency for
    /// images with 16 samples&gt;&gt; feature is not enabled, pname:imageType
    /// is ename:VK_IMAGE_TYPE_2D, and pname:samples is
    /// ename:VK_SAMPLE_COUNT_16_BIT, pname:flags must: not contain
    /// ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_LINEAR, pname:format must: be a format that has
    /// at least one supported feature bit present in the value of
    /// sname:VkFormatProperties::pname:linearTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:tiling is ename:VK_IMAGE_TILING_LINEAR, and
    /// sname:VkFormatProperties::pname:linearTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT, pname:usage must: not
    /// contain ename:VK_IMAGE_USAGE_SAMPLED_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_LINEAR, and
    /// sname:VkFormatProperties::pname:linearTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT, pname:usage must: not
    /// contain ename:VK_IMAGE_USAGE_STORAGE_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_LINEAR, and
    /// sname:VkFormatProperties::pname:linearTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT, pname:usage must: not
    /// contain ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_LINEAR, and
    /// sname:VkFormatProperties::pname:linearTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT, pname:usage must:
    /// not contain ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT * If
    /// pname:tiling is ename:VK_IMAGE_TILING_OPTIMAL, pname:format must: be a
    /// format that has at least one supported feature bit present in the value
    /// of sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:tiling is ename:VK_IMAGE_TILING_OPTIMAL, and
    /// sname:VkFormatProperties::pname:optimalTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT, pname:usage must: not
    /// contain ename:VK_IMAGE_USAGE_SAMPLED_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_OPTIMAL, and
    /// sname:VkFormatProperties::pname:optimalTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT, pname:usage must: not
    /// contain ename:VK_IMAGE_USAGE_STORAGE_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_OPTIMAL, and
    /// sname:VkFormatProperties::pname:optimalTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT, pname:usage must: not
    /// contain ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT * If pname:tiling is
    /// ename:VK_IMAGE_TILING_OPTIMAL, and
    /// sname:VkFormatProperties::pname:optimalTilingFeatures (as returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format) does not include
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT, pname:usage must:
    /// not contain ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT * If
    /// pname:flags contains ename:VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT or
    /// ename:VK_IMAGE_CREATE_SPARSE_ALIASED_BIT, it must: also contain
    /// ename:VK_IMAGE_CREATE_SPARSE_BINDING_BIT ****
    /// </para>
    /// </summary>
    public struct ImageCreateInfo
    {
        /// <summary>
        /// pname:flags is a bitmask describing additional parameters of the
        /// image. See elink:VkImageCreateFlagBits below for a description of
        /// the supported bits.
        /// </summary>
        public ImageCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageType is a elink:VkImageType specifying the basic
        /// dimensionality of the image, as described below. Layers in array
        /// textures do not count as a dimension for the purposes of the image
        /// type.
        /// </summary>
        public ImageType ImageType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:format is a elink:VkFormat describing the format and type of
        /// the data elements that will be contained in the image.
        /// </summary>
        public Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:extent is a slink:VkExtent3D describing the number of data
        /// elements in each dimension of the base level.
        /// </summary>
        public Extent3D Extent
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:mipLevels describes the number of levels of detail available
        /// for minified sampling of the image.
        /// </summary>
        public uint MipLevels
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:arrayLayers is the number of layers in the image.
        /// </summary>
        public uint ArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:samples is the number of sub-data element samples in the
        /// image as defined in elink:VkSampleCountFlagBits. See
        /// &lt;&lt;primsrast-multisampling,Multisampling&gt;&gt;.
        /// </summary>
        public SampleCountFlags Samples
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:tiling is a elink:VkImageTiling specifying the tiling
        /// arrangement of the data elements in memory, as described below.
        /// </summary>
        public ImageTiling Tiling
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:usage is a bitmask describing the intended usage of the
        /// image. See elink:VkImageUsageFlagBits below for a description of
        /// the supported bits.
        /// </summary>
        public ImageUsageFlags Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sharingMode is the sharing mode of the image when it will be
        /// accessed by multiple queue families, and must: be one of the values
        /// described for elink:VkSharingMode in the
        /// &lt;&lt;resources-sharing,Resource Sharing&gt;&gt; section below.
        /// </summary>
        public SharingMode SharingMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pQueueFamilyIndices is a list of queue families that will
        /// access this image (ignored if pname:sharingMode is not
        /// ename:VK_SHARING_MODE_CONCURRENT).
        /// </summary>
        public uint[] QueueFamilyIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:initialLayout selects the initial elink:VkImageLayout state
        /// of all image subresources of the image. See
        /// &lt;&lt;resources-image-layouts,Image Layouts&gt;&gt;.
        /// pname:initialLayout must: be ename:VK_IMAGE_LAYOUT_UNDEFINED or
        /// ename:VK_IMAGE_LAYOUT_PREINITIALIZED.
        /// </summary>
        public ImageLayout InitialLayout
        {
            get;
            set;
        }
        
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
    /// If pname:oldLayout differs from pname:newLayout, a layout transition
    /// occurs as part of the image memory barrier, affecting the data
    /// contained in the region of the image defined by the
    /// pname:subresourceRange. If pname:oldLayout is
    /// ename:VK_IMAGE_LAYOUT_UNDEFINED, then the data is undefined after the
    /// layout transition. This may: allow a more efficient transition, since
    /// the data may: be discarded. The layout transition must: occur after all
    /// operations using the old layout are completed and before all operations
    /// using the new layout are started. This is achieved by ensuring that
    /// there is a memory dependency between previous accesses and the layout
    /// transition, as well as between the layout transition and subsequent
    /// accesses, where the layout transition occurs between the two halves of
    /// a memory dependency in an image memory barrier.
    /// </para>
    /// <para>
    /// Layout transitions that are performed via image memory barriers are
    /// automatically ordered against other layout transitions, including those
    /// that occur as part of a render pass instance.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== See &lt;&lt;resources-image-layouts&gt;&gt; for
    /// details on available image layouts and their usages. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:oldLayout must: be
    /// ename:VK_IMAGE_LAYOUT_UNDEFINED or the current layout of the image
    /// subresources affected by the barrier * pname:newLayout must: not be
    /// ename:VK_IMAGE_LAYOUT_UNDEFINED or ename:VK_IMAGE_LAYOUT_PREINITIALIZED
    /// * If pname:image was created with a sharing mode of
    /// ename:VK_SHARING_MODE_CONCURRENT, pname:srcQueueFamilyIndex and
    /// pname:dstQueueFamilyIndex must: both be ename:VK_QUEUE_FAMILY_IGNORED *
    /// If pname:image was created with a sharing mode of
    /// ename:VK_SHARING_MODE_EXCLUSIVE, pname:srcQueueFamilyIndex and
    /// pname:dstQueueFamilyIndex must: either both be
    /// ename:VK_QUEUE_FAMILY_IGNORED, or both be a valid queue family (see
    /// &lt;&lt;devsandqueues-queueprops&gt;&gt;) * If pname:image was created
    /// with a sharing mode of ename:VK_SHARING_MODE_EXCLUSIVE, and
    /// pname:srcQueueFamilyIndex and pname:dstQueueFamilyIndex are valid queue
    /// families, at least one of them must: be the same as the family of the
    /// queue that will execute this barrier * pname:subresourceRange must: be
    /// a valid image subresource range for the image (see
    /// &lt;&lt;resources-image-views&gt;&gt;) * If pname:image has a
    /// depth/stencil format with both depth and stencil components, then
    /// pname:aspectMask member of pname:subresourceRange must: include both
    /// ename:VK_IMAGE_ASPECT_DEPTH_BIT and ename:VK_IMAGE_ASPECT_STENCIL_BIT *
    /// If either pname:oldLayout or pname:newLayout is
    /// ename:VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL then pname:image must:
    /// have been created with ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT set *
    /// If either pname:oldLayout or pname:newLayout is
    /// ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL then pname:image
    /// must: have been created with
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT set * If either
    /// pname:oldLayout or pname:newLayout is
    /// ename:VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL then pname:image
    /// must: have been created with
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT set * If either
    /// pname:oldLayout or pname:newLayout is
    /// ename:VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL then pname:image must:
    /// have been created with ename:VK_IMAGE_USAGE_SAMPLED_BIT or
    /// ename:VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT set * If either
    /// pname:oldLayout or pname:newLayout is
    /// ename:VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL then pname:image must: have
    /// been created with ename:VK_IMAGE_USAGE_TRANSFER_SRC_BIT set * If either
    /// pname:oldLayout or pname:newLayout is
    /// ename:VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL then pname:image must: have
    /// been created with ename:VK_IMAGE_USAGE_TRANSFER_DST_BIT set ****
    /// </para>
    /// </summary>
    public struct ImageMemoryBarrier
    {
        /// <summary>
        /// pname:srcAccessMask is a bitmask of the classes of memory accesses
        /// performed by the first set of commands that will participate in the
        /// dependency.
        /// </summary>
        public AccessFlags SourceAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstAccessMask is a bitmask of the classes of memory accesses
        /// performed by the second set of commands that will participate in
        /// the dependency.
        /// </summary>
        public AccessFlags DestinationAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:oldLayout describes the current layout of the image
        /// subresource(s).
        /// </summary>
        public ImageLayout OldLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:newLayout describes the new layout of the image
        /// subresource(s).
        /// </summary>
        public ImageLayout NewLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:srcQueueFamilyIndex is the queue family that is relinquishing
        /// ownership of the image subresource(s) to another queue, or
        /// ename:VK_QUEUE_FAMILY_IGNORED if there is no transfer of
        /// ownership).
        /// </summary>
        public uint SourceQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstQueueFamilyIndex is the queue family that is acquiring
        /// ownership of the image subresource(s) from another queue, or
        /// ename:VK_QUEUE_FAMILY_IGNORED if there is no transfer of
        /// ownership).
        /// </summary>
        public uint DestinationQueueFamilyIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:image is a handle to the image whose backing memory is
        /// affected by the barrier.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subresourceRange describes an area of the backing memory for
        /// pname:image (see &lt;&lt;resources-image-views&gt;&gt; for the
        /// description of sname:VkImageSubresourceRange), as well as the set
        /// of image subresources whose image layouts are modified.
        /// </summary>
        public ImageSubresourceRange SubresourceRange
        {
            get;
            set;
        }
        
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
    /// If pname:image was created with the
    /// ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT flag, pname:format can: be
    /// different from the image's format, but if they are not equal they must:
    /// be _compatible_. Image format compatibility is defined in the
    /// &lt;&lt;features-formats-compatibility-classes,Format Compatibility
    /// Classes&gt;&gt; section.
    /// </para>
    /// <para>
    /// .Image and image view parameter compatibility requirements
    /// [cols="15%h,35%,50%",options="header"] |==== | Dim, Arrayed, MS | Image
    /// parameters | View parameters | | pname:imageType = ci.pname:imageType +
    /// pname:width = ci.pname:extent.width + pname:height =
    /// ci.pname:extent.height + pname:depth = ci.pname:extent.depth +
    /// pname:arrayLayers = ci.pname:arrayLayers + pname:samples =
    /// ci.pname:samples + where ci is the slink:VkImageCreateInfo used to
    /// create pname:image. | pname:baseArrayLayer and pname:layerCount are
    /// members of the pname:subresourceRange member. | 1D, 0, 0 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_1D + pname:width {geq} 1 +
    /// pname:height = 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 +
    /// pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_1D +
    /// pname:baseArrayLayer {geq} 0 + pname:layerCount = 1 | 1D, 1, 0 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_1D + pname:width {geq} 1 +
    /// pname:height = 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 +
    /// pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_1D_ARRAY +
    /// pname:baseArrayLayer {geq} 0 + pname:layerCount {geq} 1 | 2D, 0, 0 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 +
    /// pname:height {geq} 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 +
    /// pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_2D +
    /// pname:baseArrayLayer {geq} 0 + pname:layerCount = 1 | 2D, 1, 0 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 +
    /// pname:height {geq} 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 +
    /// pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_2D_ARRAY +
    /// pname:baseArrayLayer {geq} 0 + pname:layerCount {geq} 1 | 2D, 0, 1 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 +
    /// pname:height {geq} 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 +
    /// pname:samples &gt; 1 | pname:viewType = ename:VK_VIEW_TYPE_2D +
    /// pname:baseArrayLayer {geq} 0 + pname:layerCount = 1 | 2D, 1, 1 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 +
    /// pname:height {geq} 1 + pname:depth = 1 + pname:arrayLayers {geq} 1 +
    /// pname:samples &gt; 1 | pname:viewType = ename:VK_VIEW_TYPE_2D_ARRAY +
    /// pname:baseArrayLayer {geq} 0 + pname:layerCount {geq} 1 | CUBE, 0, 0 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 +
    /// pname:height = pname:width + pname:depth = 1 + pname:arrayLayers {geq}
    /// 6 + pname:samples = 1 + pname:flags includes
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT | pname:viewType =
    /// ename:VK_VIEW_TYPE_CUBE + pname:baseArrayLayer {geq} 0 +
    /// pname:layerCount = 6 | CUBE, 1, 0 | pname:imageType =
    /// ename:VK_IMAGE_TYPE_2D + pname:width {geq} 1 + pname:height = width +
    /// pname:depth = 1 + _N_ {geq} 1 + pname:arrayLayers {geq} 6 {times} _N_ +
    /// pname:samples = 1 + pname:flags includes
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT | pname:viewType =
    /// ename:VK_VIEW_TYPE_CUBE_ARRAY + pname:baseArrayLayer {geq} 0 +
    /// pname:layerCount = 6 {times} _N_, _N_ {geq} 1 | 3D, 0, 0 |
    /// pname:imageType = ename:VK_IMAGE_TYPE_3D + pname:width {geq} 1 +
    /// pname:height {geq} 1 + pname:depth {geq} 1 + pname:arrayLayers = 1 +
    /// pname:samples = 1 | pname:viewType = ename:VK_VIEW_TYPE_3D +
    /// pname:baseArrayLayer = 0 + pname:layerCount = 1 |====
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:image was not created with
    /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT then pname:viewType must: not
    /// be ename:VK_IMAGE_VIEW_TYPE_CUBE or ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY
    /// * If the &lt;&lt;features-features-imageCubeArray,image cubemap
    /// arrays&gt;&gt; feature is not enabled, pname:viewType must: not be
    /// ename:VK_IMAGE_VIEW_TYPE_CUBE_ARRAY * If the
    /// &lt;&lt;features-features-textureCompressionETC2,ETC2 texture
    /// compression&gt;&gt; feature is not enabled, pname:format must: not be
    /// ename:VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK,
    /// ename:VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK,
    /// ename:VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK, ename:VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK,
    /// ename:VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK,
    /// ename:VK_FORMAT_EAC_R11_UNORM_BLOCK, ename:VK_FORMAT_EAC_R11_SNORM_BLOCK,
    /// ename:VK_FORMAT_EAC_R11G11_UNORM_BLOCK, or
    /// ename:VK_FORMAT_EAC_R11G11_SNORM_BLOCK * If the
    /// &lt;&lt;features-features-textureCompressionASTC_LDR,ASTC LDR texture
    /// compression&gt;&gt; feature is not enabled, pname:format must: not be
    /// ename:VK_FORMAT_ASTC_4x4_UNORM_BLOCK, ename:VK_FORMAT_ASTC_4x4_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_5x4_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_5x4_SRGB_BLOCK, ename:VK_FORMAT_ASTC_5x5_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_5x5_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_6x5_UNORM_BLOCK, ename:VK_FORMAT_ASTC_6x5_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_6x6_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_6x6_SRGB_BLOCK, ename:VK_FORMAT_ASTC_8x5_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_8x5_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_8x6_UNORM_BLOCK, ename:VK_FORMAT_ASTC_8x6_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_8x8_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_8x8_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x5_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x5_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x6_UNORM_BLOCK, ename:VK_FORMAT_ASTC_10x6_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x8_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x8_SRGB_BLOCK, ename:VK_FORMAT_ASTC_10x10_UNORM_BLOCK,
    /// ename:VK_FORMAT_ASTC_10x10_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_12x10_UNORM_BLOCK, ename:VK_FORMAT_ASTC_12x10_SRGB_BLOCK,
    /// ename:VK_FORMAT_ASTC_12x12_UNORM_BLOCK, or
    /// ename:VK_FORMAT_ASTC_12x12_SRGB_BLOCK * If the
    /// &lt;&lt;features-features-textureCompressionBC,BC texture
    /// compression&gt;&gt; feature is not enabled, pname:format must: not be
    /// ename:VK_FORMAT_BC1_RGB_UNORM_BLOCK, ename:VK_FORMAT_BC1_RGB_SRGB_BLOCK,
    /// ename:VK_FORMAT_BC1_RGBA_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC1_RGBA_SRGB_BLOCK, ename:VK_FORMAT_BC2_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC2_SRGB_BLOCK, ename:VK_FORMAT_BC3_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC3_SRGB_BLOCK, ename:VK_FORMAT_BC4_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC4_SNORM_BLOCK, ename:VK_FORMAT_BC5_UNORM_BLOCK,
    /// ename:VK_FORMAT_BC5_SNORM_BLOCK, ename:VK_FORMAT_BC6H_UFLOAT_BLOCK,
    /// ename:VK_FORMAT_BC6H_SFLOAT_BLOCK, ename:VK_FORMAT_BC7_UNORM_BLOCK, or
    /// ename:VK_FORMAT_BC7_SRGB_BLOCK * If pname:image was created with
    /// ename:VK_IMAGE_TILING_LINEAR, pname:format must: be format that has at
    /// least one supported feature bit present in the value of
    /// sname:VkFormatProperties::pname:linearTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_LINEAR and pname:usage containing
    /// ename:VK_IMAGE_USAGE_SAMPLED_BIT, pname:format must: be supported for
    /// sampled images, as specified by the
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT flag in
    /// sname:VkFormatProperties::pname:linearTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_LINEAR and pname:usage containing
    /// ename:VK_IMAGE_USAGE_STORAGE_BIT, pname:format must: be supported for
    /// storage images, as specified by the
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT flag in
    /// sname:VkFormatProperties::pname:linearTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_LINEAR and pname:usage containing
    /// ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT, pname:format must: be
    /// supported for color attachments, as specified by the
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT flag in
    /// sname:VkFormatProperties::pname:linearTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_LINEAR and pname:usage containing
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, pname:format must:
    /// be supported for depth/stencil attachments, as specified by the
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT flag in
    /// sname:VkFormatProperties::pname:linearTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_OPTIMAL, pname:format must: be format that has at
    /// least one supported feature bit present in the value of
    /// sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_OPTIMAL and pname:usage containing
    /// ename:VK_IMAGE_USAGE_SAMPLED_BIT, pname:format must: be supported for
    /// sampled images, as specified by the
    /// ename:VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT flag in
    /// sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_OPTIMAL and pname:usage containing
    /// ename:VK_IMAGE_USAGE_STORAGE_BIT, pname:format must: be supported for
    /// storage images, as specified by the
    /// ename:VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT flag in
    /// sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_OPTIMAL and pname:usage containing
    /// ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT, pname:format must: be
    /// supported for color attachments, as specified by the
    /// ename:VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT flag in
    /// sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * If pname:image was created with
    /// ename:VK_IMAGE_TILING_OPTIMAL and pname:usage containing
    /// ename:VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT, pname:format must:
    /// be supported for depth/stencil attachments, as specified by the
    /// ename:VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT flag in
    /// sname:VkFormatProperties::pname:optimalTilingFeatures returned by
    /// fname:vkGetPhysicalDeviceFormatProperties with the same value of
    /// pname:format * pname:subresourceRange must: be a valid image
    /// subresource range for pname:image (see
    /// &lt;&lt;resources-image-views&gt;&gt;) * If pname:image was created
    /// with the ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT flag, pname:format
    /// must: be compatible with the pname:format used to create pname:image,
    /// as defined in &lt;&lt;features-formats-compatibility-classes,Format
    /// Compatibility Classes&gt;&gt; * If pname:image was not created with the
    /// ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT flag, pname:format must: be
    /// identical to the pname:format used to create pname:image *
    /// pname:subResourceRange and pname:viewType must: be compatible with the
    /// image, as described in the
    /// &lt;&lt;resources-image-views-compatibility,compatibility table&gt;&gt;
    /// ****
    /// </para>
    /// </summary>
    public struct ImageViewCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public ImageViewCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:image is a sname:VkImage on which the view will be created.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:viewType is the type of the image view.
        /// </summary>
        public ImageViewType ViewType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:format is a elink:VkFormat describing the format and type
        /// used to interpret data elements in the image.
        /// </summary>
        public Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:components specifies a remapping of color components (or of
        /// depth or stencil components after they have been converted into
        /// color components). See slink:VkComponentMapping.
        /// </summary>
        public ComponentMapping Components
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subresourceRange is a slink:VkImageSubresourceRange selecting
        /// the set of mipmap levels and array layers to be accessible to the
        /// view.
        /// </summary>
        public ImageSubresourceRange SubresourceRange
        {
            get;
            set;
        }
        
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
    /// To import memory created on the same physical device but outside of the
    /// current Vulkan instance, add a slink:VkImportMemoryWin32HandleInfoNV
    /// structure to the pname:pNext chain of the slink:VkMemoryAllocateInfo
    /// structure, specifying a handle to and the type of the memory.
    /// </para>
    /// </summary>
    public struct ImportMemoryWin32HandleInfo
    {
        /// <summary>
        /// pname:handleType is 0 or a flag specifying the type of memory
        /// handle in pname:handle. Flags which may: be specified are: + --
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
        
        internal unsafe Interop.ImportMemoryWin32HandleInfo Pack()
        {
            Interop.ImportMemoryWin32HandleInfo result = default(Interop.ImportMemoryWin32HandleInfo);
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
    /// Structure specifying parameters of a newly created instance.
    /// </summary>
    public struct InstanceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public InstanceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pApplicationInfo is `NULL` or a pointer to an instance of
        /// sname:VkApplicationInfo. If not `NULL`, this information helps
        /// implementations recognize behavior inherent to classes of
        /// applications. slink:VkApplicationInfo is defined in detail below.
        /// </summary>
        public ApplicationInfo? ApplicationInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:ppEnabledLayerNames is a pointer to an array of
        /// pname:enabledLayerCount null-terminated UTF-8 strings containing
        /// the names of layers to enable for the created instance. See the
        /// &lt;&lt;extended-functionality-layers,Layers&gt;&gt; section for
        /// further details.
        /// </summary>
        public string[] EnabledLayerNames
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:ppEnabledExtensionNames is a pointer to an array of
        /// pname:enabledExtensionCount null-terminated UTF-8 strings
        /// containing the names of extensions to enable.
        /// </summary>
        public string[] EnabledExtensionNames
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.InstanceCreateInfo* MarshalTo()
        {
            return (Interop.InstanceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying layer properties.
    /// </summary>
    public struct LayerProperties
    {
        /// <summary>
        /// pname:layerName is a null-terminated UTF-8 string specifying the
        /// name of the layer. Use this name in the pname:ppEnabledLayerNames
        /// array passed in the slink:VkInstanceCreateInfo structure to enable
        /// this layer for an instance.
        /// </summary>
        public string LayerName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:specVersion is the Vulkan version the layer was written to,
        /// encoded as described in the &lt;&lt;fundamentals-versionnum,API
        /// Version Numbers and Semantics&gt;&gt; section.
        /// </summary>
        public Version SpecVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:implementationVersion is the version of this layer. It is an
        /// integer, increasing with backward compatible changes.
        /// </summary>
        public Version ImplementationVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:description is a null-terminated UTF-8 string providing
        /// additional details that can: be used by the application to identify
        /// the layer.
        /// </summary>
        public string Description
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * pname:memory must: currently be mapped * If
    /// pname:size is not equal to ename:VK_WHOLE_SIZE, pname:offset and
    /// pname:size must: specify a range contained within the currently mapped
    /// range of pname:memory * If pname:size is equal to ename:VK_WHOLE_SIZE,
    /// pname:offset must: be within the currently mapped range of pname:memory
    /// * pname:offset must: be a multiple of
    /// sname:VkPhysicalDeviceLimits::pname:nonCoherentAtomSize * If pname:size
    /// is not equal to ename:VK_WHOLE_SIZE, pname:size must: be a multiple of
    /// sname:VkPhysicalDeviceLimits::pname:nonCoherentAtomSize ****
    /// </para>
    /// </summary>
    public struct MappedMemoryRange
    {
        /// <summary>
        /// pname:memory is the memory object to which this range belongs.
        /// </summary>
        public DeviceMemory Memory
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:offset is the zero-based byte offset from the beginning of
        /// the memory object.
        /// </summary>
        public ulong Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:size is either the size of range, or ename:VK_WHOLE_SIZE to
        /// affect the range from pname:offset to the end of the current
        /// mapping of the allocation.
        /// </summary>
        public ulong Size
        {
            get;
            set;
        }
        
        internal unsafe Interop.MappedMemoryRange Pack()
        {
            Interop.MappedMemoryRange result = default(Interop.MappedMemoryRange);
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
    /// <para>
    /// .Valid Usage **** * pname:allocationSize must: be less than or equal to
    /// the amount of memory available to the sname:VkMemoryHeap specified by
    /// pname:memoryTypeIndex and the calling command's sname:VkDevice *
    /// pname:allocationSize must: be greater than `0` ****
    /// </para>
    /// </summary>
    public struct MemoryAllocateInfo
    {
        /// <summary>
        /// pname:allocationSize is the size of the allocation in bytes
        /// </summary>
        public ulong AllocationSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memoryTypeIndex is the memory type index, which selects the
        /// properties of the memory to be allocated, as well as the heap the
        /// memory will come from.
        /// </summary>
        public uint MemoryTypeIndex
        {
            get;
            set;
        }
        
        internal unsafe Interop.MemoryAllocateInfo Pack()
        {
            Interop.MemoryAllocateInfo result = default(Interop.MemoryAllocateInfo);
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
    /// <para>
    /// pname:srcAccessMask and pname:dstAccessMask, along with
    /// pname:srcStageMask and pname:dstStageMask from
    /// flink:vkCmdPipelineBarrier, define the two halves of a memory
    /// dependency and an execution dependency. Memory accesses using the set
    /// of access types in pname:srcAccessMask performed in pipeline stages in
    /// pname:srcStageMask by the first set of commands must: complete and be
    /// available to later commands. The side effects of the first set of
    /// commands will be visible to memory accesses using the set of access
    /// types in pname:dstAccessMask performed in pipeline stages in
    /// pname:dstStageMask by the second set of commands. If the barrier is
    /// by-region, these requirements only apply to invocations within the same
    /// framebuffer-space region, for pipeline stages that perform
    /// framebuffer-space work. The execution dependency guarantees that
    /// execution of work by the destination stages of the second set of
    /// commands will not begin until execution of work by the source stages of
    /// the first set of commands has completed.
    /// </para>
    /// <para>
    /// A common type of memory dependency is to avoid a read-after-write
    /// hazard. In this case, the source access mask and stages will include
    /// writes from a particular stage, and the destination access mask and
    /// stages will indicate how those writes will be read in subsequent
    /// commands. However, barriers can: also express write-after-read
    /// dependencies and write-after-write dependencies, and are even useful to
    /// express read-after-read dependencies across an image layout change.
    /// </para>
    /// </summary>
    public struct MemoryBarrier
    {
        /// <summary>
        /// pname:srcAccessMask is a bitmask of the classes of memory accesses
        /// performed by the first set of commands that will participate in the
        /// dependency.
        /// </summary>
        public AccessFlags SourceAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstAccessMask is a bitmask of the classes of memory accesses
        /// performed by the second set of commands that will participate in
        /// the dependency.
        /// </summary>
        public AccessFlags DestinationAccessMask
        {
            get;
            set;
        }
        
        internal unsafe Interop.MemoryBarrier Pack()
        {
            Interop.MemoryBarrier result = default(Interop.MemoryBarrier);
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
    /// Structure specifying parameters of a newly created Mir surface object.
    /// </summary>
    public struct MirSurfaceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public MirSurfaceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:connection and pname:surface are pointers to the
        /// code:MirConnection and code:MirSurface for the window to associate
        /// the surface with.
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
        
        internal unsafe Interop.MirSurfaceCreateInfo Pack()
        {
            Interop.MirSurfaceCreateInfo result = default(Interop.MirSurfaceCreateInfo);
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
    /// Structure reporting implementation-dependent physical device limits.
    /// </summary>
    public struct PhysicalDeviceLimits
    {
        /// <summary>
        /// pname:maxImageDimension1D is the maximum dimension (pname:width) of
        /// an image created with an pname:imageType of ename:VK_IMAGE_TYPE_1D.
        /// </summary>
        public uint MaxImageDimension1D
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxImageDimension2D is the maximum dimension (pname:width or
        /// pname:height) of an image created with an pname:imageType of
        /// ename:VK_IMAGE_TYPE_2D and without
        /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT set in pname:flags.
        /// </summary>
        public uint MaxImageDimension2D
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxImageDimension3D is the maximum dimension (pname:width,
        /// pname:height, or pname:depth) of an image created with an
        /// pname:imageType of ename:VK_IMAGE_TYPE_3D.
        /// </summary>
        public uint MaxImageDimension3D
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxImageDimensionCube is the maximum dimension (pname:width
        /// or pname:height) of an image created with an pname:imageType of
        /// ename:VK_IMAGE_TYPE_2D and with
        /// ename:VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT set in pname:flags.
        /// </summary>
        public uint MaxImageDimensionCube
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxImageArrayLayers is the maximum number of layers
        /// (pname:arrayLayers) for an image.
        /// </summary>
        public uint MaxImageArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTexelBufferElements is the maximum number of addressable
        /// texels for a buffer view created on a buffer which was created with
        /// the ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or
        /// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set in the
        /// pname:usage member of the sname:VkBufferCreateInfo structure.
        /// </summary>
        public uint MaxTexelBufferElements
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxUniformBufferRange is the maximum value that can: be
        /// specified in the pname:range member of any
        /// slink:VkDescriptorBufferInfo structures passed to a call to
        /// flink:vkUpdateDescriptorSets for descriptors of type
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC.
        /// </summary>
        public uint MaxUniformBufferRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxStorageBufferRange is the maximum value that can: be
        /// specified in the pname:range member of any
        /// slink:VkDescriptorBufferInfo structures passed to a call to
        /// flink:vkUpdateDescriptorSets for descriptors of type
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC.
        /// </summary>
        public uint MaxStorageBufferRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPushConstantsSize is the maximum size, in bytes, of the
        /// pool of push constant memory. For each of the push constant ranges
        /// indicated by the pname:pPushConstantRanges member of the
        /// sname:VkPipelineLayoutCreateInfo structure, pname:offset +
        /// pname:size must: be less than or equal to this limit.
        /// </summary>
        public uint MaxPushConstantsSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxMemoryAllocationCount is the maximum number of device
        /// memory allocations, as created by flink:vkAllocateMemory, which
        /// can: simultaneously exist.
        /// </summary>
        public uint MaxMemoryAllocationCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxSamplerAllocationCount is the maximum number of sampler
        /// objects, as created by flink:vkCreateSampler, which can:
        /// simultaneously exist on a device.
        /// </summary>
        public uint MaxSamplerAllocationCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:bufferImageGranularity is the granularity, in bytes, at which
        /// buffer or linear image resources, and optimal image resources can:
        /// be bound to adjacent offsets in the same sname:VkDeviceMemory
        /// object without aliasing. See
        /// &lt;&lt;resources-bufferimagegranularity,Buffer-Image Granularity&gt;&gt;
        /// for more details.
        /// </summary>
        public ulong BufferImageGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sparseAddressSpaceSize is the total amount of address space
        /// available, in bytes, for sparse memory resources. This is an upper
        /// bound on the sum of the size of all sparse resources, regardless of
        /// whether any memory is bound to them.
        /// </summary>
        public ulong SparseAddressSpaceSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxBoundDescriptorSets is the maximum number of descriptor
        /// sets that can: be simultaneously used by a pipeline. All
        /// code:DescriptorSet decorations in shader modules must: have a value
        /// less than pname:maxBoundDescriptorSets. See
        /// &lt;&lt;descriptorsets-sets&gt;&gt;.
        /// </summary>
        public uint MaxBoundDescriptorSets
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageDescriptorSamplers is the maximum number of
        /// samplers that can: be accessible to a single shader stage in a
        /// pipeline layout. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_SAMPLER or
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER count against this
        /// limit. A descriptor is accessible to a shader stage when the
        /// pname:stageFlags member of the sname:VkDescriptorSetLayoutBinding
        /// structure has the bit for that shader stage set. See
        /// &lt;&lt;descriptorsets-sampler&gt;&gt; and
        /// &lt;&lt;descriptorsets-combinedimagesampler&gt;&gt;.
        /// </summary>
        public uint MaxPerStageDescriptorSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageDescriptorUniformBuffers is the maximum number of
        /// uniform buffers that can: be accessible to a single shader stage in
        /// a pipeline layout. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this
        /// limit. A descriptor is accessible to a shader stage when the
        /// pname:stageFlags member of the sname:VkDescriptorSetLayoutBinding
        /// structure has the bit for that shader stage set. See
        /// &lt;&lt;descriptorsets-uniformbuffer&gt;&gt; and
        /// &lt;&lt;descriptorsets-uniformbufferdynamic&gt;&gt;.
        /// </summary>
        public uint MaxPerStageDescriptorUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageDescriptorStorageBuffers is the maximum number of
        /// storage buffers that can: be accessible to a single shader stage in
        /// a pipeline layout. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this
        /// limit. A descriptor is accessible to a pipeline shader stage when
        /// the pname:stageFlags member of the
        /// sname:VkDescriptorSetLayoutBinding structure has the bit for that
        /// shader stage set. See &lt;&lt;descriptorsets-storagebuffer&gt;&gt;
        /// and &lt;&lt;descriptorsets-storagebufferdynamic&gt;&gt;.
        /// </summary>
        public uint MaxPerStageDescriptorStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageDescriptorSampledImages is the maximum number of
        /// sampled images that can: be accessible to a single shader stage in
        /// a pipeline layout. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
        /// or ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER count against this
        /// limit. A descriptor is accessible to a pipeline shader stage when
        /// the pname:stageFlags member of the
        /// sname:VkDescriptorSetLayoutBinding structure has the bit for that
        /// shader stage set. See
        /// &lt;&lt;descriptorsets-combinedimagesampler&gt;&gt;, &lt;&lt;descriptorsets-sampledimage&gt;&gt;,
        /// and &lt;&lt;descriptorsets-uniformtexelbuffer&gt;&gt;.
        /// </summary>
        public uint MaxPerStageDescriptorSampledImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageDescriptorStorageImages is the maximum number of
        /// storage images that can: be accessible to a single shader stage in
        /// a pipeline layout. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER count against this
        /// limit. A descriptor is accessible to a pipeline shader stage when
        /// the pname:stageFlags member of the
        /// sname:VkDescriptorSetLayoutBinding structure has the bit for that
        /// shader stage set. See &lt;&lt;descriptorsets-storageimage&gt;&gt;,
        /// and &lt;&lt;descriptorsets-storagetexelbuffer&gt;&gt;.
        /// </summary>
        public uint MaxPerStageDescriptorStorageImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageDescriptorInputAttachments is the maximum number
        /// of input attachments that can: be accessible to a single shader
        /// stage in a pipeline layout. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT count against this limit.
        /// A descriptor is accessible to a pipeline shader stage when the
        /// pname:stageFlags member of the sname:VkDescriptorSetLayoutBinding
        /// structure has the bit for that shader stage set. These are only
        /// supported for the fragment stage. See
        /// &lt;&lt;descriptorsets-inputattachment&gt;&gt;.
        /// </summary>
        public uint MaxPerStageDescriptorInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxPerStageResources is the maximum number of resources that
        /// can: be accessible to a single shader stage in a pipeline layout.
        /// Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE,
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER, ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER,
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER,
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER, ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC,
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, or
        /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT count against this limit.
        /// For the fragment shader stage the framebuffer color attachments
        /// also count against this limit.
        /// </summary>
        public uint MaxPerStageResources
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetSamplers is the maximum number of samplers
        /// that can: be included in descriptor bindings in a pipeline layout
        /// across all pipeline shader stages and descriptor set numbers.
        /// Descriptors with a type of ename:VK_DESCRIPTOR_TYPE_SAMPLER or
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER count against this
        /// limit. See &lt;&lt;descriptorsets-sampler&gt;&gt; and
        /// &lt;&lt;descriptorsets-combinedimagesampler&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetUniformBuffers is the maximum number of
        /// uniform buffers that can: be included in descriptor bindings in a
        /// pipeline layout across all pipeline shader stages and descriptor
        /// set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this
        /// limit. See &lt;&lt;descriptorsets-uniformbuffer&gt;&gt; and
        /// &lt;&lt;descriptorsets-uniformbufferdynamic&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetUniformBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetUniformBuffersDynamic is the maximum number
        /// of dynamic uniform buffers that can: be included in descriptor
        /// bindings in a pipeline layout across all pipeline shader stages and
        /// descriptor set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC count against this
        /// limit. See &lt;&lt;descriptorsets-uniformbufferdynamic&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetUniformBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetStorageBuffers is the maximum number of
        /// storage buffers that can: be included in descriptor bindings in a
        /// pipeline layout across all pipeline shader stages and descriptor
        /// set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this
        /// limit. See &lt;&lt;descriptorsets-storagebuffer&gt;&gt; and
        /// &lt;&lt;descriptorsets-storagebufferdynamic&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetStorageBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetStorageBuffersDynamic is the maximum number
        /// of dynamic storage buffers that can: be included in descriptor
        /// bindings in a pipeline layout across all pipeline shader stages and
        /// descriptor set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC count against this
        /// limit. See &lt;&lt;descriptorsets-storagebufferdynamic&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetStorageBuffersDynamic
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetSampledImages is the maximum number of
        /// sampled images that can: be included in descriptor bindings in a
        /// pipeline layout across all pipeline shader stages and descriptor
        /// set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
        /// or ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER count against this
        /// limit. See &lt;&lt;descriptorsets-combinedimagesampler&gt;&gt;,
        /// &lt;&lt;descriptorsets-sampledimage&gt;&gt;, and
        /// &lt;&lt;descriptorsets-uniformtexelbuffer&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetSampledImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetStorageImages is the maximum number of
        /// storage images that can: be included in descriptor bindings in a
        /// pipeline layout across all pipeline shader stages and descriptor
        /// set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER count against this
        /// limit. See &lt;&lt;descriptorsets-storageimage&gt;&gt;, and
        /// &lt;&lt;descriptorsets-storagetexelbuffer&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetStorageImages
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDescriptorSetInputAttachments is the maximum number of
        /// input attachments that can: be included in descriptor bindings in a
        /// pipeline layout across all pipeline shader stages and descriptor
        /// set numbers. Descriptors with a type of
        /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT count against this limit.
        /// See &lt;&lt;descriptorsets-inputattachment&gt;&gt;.
        /// </summary>
        public uint MaxDescriptorSetInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxVertexInputAttributes is the maximum number of vertex
        /// input attributes that can: be specified for a graphics pipeline.
        /// These are described in the array of
        /// sname:VkVertexInputAttributeDescription structures that are
        /// provided at graphics pipeline creation time via the
        /// pname:pVertexAttributeDescriptions member of the
        /// sname:VkPipelineVertexInputStateCreateInfo structure. See
        /// &lt;&lt;fxvertex-attrib&gt;&gt; and &lt;&lt;fxvertex-input&gt;&gt;.
        /// </summary>
        public uint MaxVertexInputAttributes
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxVertexInputBindings is the maximum number of vertex
        /// buffers that can: be specified for providing vertex attributes to a
        /// graphics pipeline. These are described in the array of
        /// sname:VkVertexInputBindingDescription structures that are provided
        /// at graphics pipeline creation time via the
        /// pname:pVertexBindingDescriptions member of the
        /// sname:VkPipelineVertexInputStateCreateInfo structure. The
        /// pname:binding member of sname:VkVertexInputBindingDescription must:
        /// be less than this limit. See &lt;&lt;fxvertex-input&gt;&gt;.
        /// </summary>
        public uint MaxVertexInputBindings
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxVertexInputAttributeOffset is the maximum vertex input
        /// attribute offset that can: be added to the vertex input binding
        /// stride. The pname:offset member of the
        /// sname:VkVertexInputAttributeDescription structure must: be less
        /// than or equal to this limit. See &lt;&lt;fxvertex-input&gt;&gt;.
        /// </summary>
        public uint MaxVertexInputAttributeOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxVertexInputBindingStride is the maximum vertex input
        /// binding stride that can: be specified in a vertex input binding.
        /// The pname:stride member of the
        /// sname:VkVertexInputBindingDescription structure must: be less than
        /// or equal to this limit. See &lt;&lt;fxvertex-input&gt;&gt;.
        /// </summary>
        public uint MaxVertexInputBindingStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxVertexOutputComponents is the maximum number of components
        /// of output variables which can: be output by a vertex shader. See
        /// &lt;&lt;shaders-vertex&gt;&gt;.
        /// </summary>
        public uint MaxVertexOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationGenerationLevel is the maximum tessellation
        /// generation level supported by the fixed-function tessellation
        /// primitive generator. See &lt;&lt;tessellation&gt;&gt;.
        /// </summary>
        public uint MaxTessellationGenerationLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationPatchSize is the maximum patch size, in
        /// vertices, of patches that can: be processed by the tessellation
        /// control shader and tessellation primitive generator. The
        /// pname:patchControlPoints member of the
        /// sname:VkPipelineTessellationStateCreateInfo structure specified at
        /// pipeline creation time and the value provided in the
        /// code:OutputVertices execution mode of shader modules must: be less
        /// than or equal to this limit. See &lt;&lt;tessellation&gt;&gt;.
        /// </summary>
        public uint MaxTessellationPatchSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationControlPerVertexInputComponents is the maximum
        /// number of components of input variables which can: be provided as
        /// per-vertex inputs to the tessellation control shader stage.
        /// </summary>
        public uint MaxTessellationControlPerVertexInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationControlPerVertexOutputComponents is the
        /// maximum number of components of per-vertex output variables which
        /// can: be output from the tessellation control shader stage.
        /// </summary>
        public uint MaxTessellationControlPerVertexOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationControlPerPatchOutputComponents is the maximum
        /// number of components of per-patch output variables which can: be
        /// output from the tessellation control shader stage.
        /// </summary>
        public uint MaxTessellationControlPerPatchOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationControlTotalOutputComponents is the maximum
        /// total number of components of per-vertex and per-patch output
        /// variables which can: be output from the tessellation control shader
        /// stage.
        /// </summary>
        public uint MaxTessellationControlTotalOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationEvaluationInputComponents is the maximum
        /// number of components of input variables which can: be provided as
        /// per-vertex inputs to the tessellation evaluation shader stage.
        /// </summary>
        public uint MaxTessellationEvaluationInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTessellationEvaluationOutputComponents is the maximum
        /// number of components of per-vertex output variables which can: be
        /// output from the tessellation evaluation shader stage.
        /// </summary>
        public uint MaxTessellationEvaluationOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxGeometryShaderInvocations is the maximum invocation count
        /// supported for instanced geometry shaders. The value provided in the
        /// code:Invocations execution mode of shader modules must: be less
        /// than or equal to this limit. See &lt;&lt;geometry&gt;&gt;.
        /// </summary>
        public uint MaxGeometryShaderInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxGeometryInputComponents is the maximum number of
        /// components of input variables which can: be provided as inputs to
        /// the geometry shader stage.
        /// </summary>
        public uint MaxGeometryInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxGeometryOutputComponents is the maximum number of
        /// components of output variables which can: be output from the
        /// geometry shader stage.
        /// </summary>
        public uint MaxGeometryOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxGeometryOutputVertices is the maximum number of vertices
        /// which can: be emitted by any geometry shader.
        /// </summary>
        public uint MaxGeometryOutputVertices
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxGeometryTotalOutputComponents is the maximum total number
        /// of components of output, across all emitted vertices, which can: be
        /// output from the geometry shader stage.
        /// </summary>
        public uint MaxGeometryTotalOutputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFragmentInputComponents is the maximum number of
        /// components of input variables which can: be provided as inputs to
        /// the fragment shader stage.
        /// </summary>
        public uint MaxFragmentInputComponents
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFragmentOutputAttachments is the maximum number of output
        /// attachments which can: be written to by the fragment shader stage.
        /// </summary>
        public uint MaxFragmentOutputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFragmentDualSrcAttachments is the maximum number of output
        /// attachments which can: be written to by the fragment shader stage
        /// when blending is enabled and one of the dual source blend modes is
        /// in use. See &lt;&lt;framebuffer-dsb&gt;&gt; and
        /// &lt;&lt;features-features-dualSrcBlend,dualSrcBlend&gt;&gt;.
        /// </summary>
        public uint MaxFragmentDualSourceAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFragmentCombinedOutputResources is the total number of
        /// storage buffers, storage images, and output buffers which can: be
        /// used in the fragment shader stage.
        /// </summary>
        public uint MaxFragmentCombinedOutputResources
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxComputeSharedMemorySize is the maximum total storage size,
        /// in bytes, of all variables declared with the code:WorkgroupLocal
        /// storage class in shader modules (or with the code:shared storage
        /// qualifier in GLSL) in the compute shader stage.
        /// </summary>
        public uint MaxComputeSharedMemorySize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxComputeWorkGroupCount[3] is the maximum number of local
        /// workgroups that can: be dispatched by a single dispatch command.
        /// These three values represent the maximum number of local workgroups
        /// for the X, Y, and Z dimensions, respectively. The pname:x, pname:y,
        /// and pname:z parameters to the flink:vkCmdDispatch command, or
        /// members of the slink:VkDispatchIndirectCommand structure must: be
        /// less than or equal to the corresponding limit. See
        /// &lt;&lt;dispatch&gt;&gt;.
        /// </summary>
        public uint[] MaxComputeWorkGroupCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxComputeWorkGroupInvocations is the maximum total number of
        /// compute shader invocations in a single local workgroup. The product
        /// of the X, Y, and Z sizes as specified by the code:LocalSize
        /// execution mode in shader modules and by the object decorated by the
        /// code:WorkgroupSize decoration must: be less than or equal to this
        /// limit.
        /// </summary>
        public uint MaxComputeWorkGroupInvocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxComputeWorkGroupSize[3] is the maximum size of a local
        /// compute workgroup, per dimension. These three values represent the
        /// maximum local workgroup size in the X, Y, and Z dimensions,
        /// respectively. The pname:x, pname:y, and pname:z sizes specified by
        /// the code:LocalSize execution mode and by the object decorated by
        /// the code:WorkgroupSize decoration in shader modules must: be less
        /// than or equal to the corresponding limit.
        /// </summary>
        public uint[] MaxComputeWorkGroupSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subPixelPrecisionBits is the number of bits of subpixel
        /// precision in framebuffer coordinates [eq]#x~f~# and [eq]#y~f~#. See
        /// &lt;&lt;primsrast&gt;&gt;.
        /// </summary>
        public uint SubPixelPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subTexelPrecisionBits is the number of bits of precision in
        /// the division along an axis of an image used for minification and
        /// magnification filters. [eq]#2^pname:subTexelPrecisionBits^# is the
        /// actual number of divisions along each axis of the image
        /// represented. The filtering hardware will snap to these locations
        /// when computing the filtered results.
        /// </summary>
        public uint SubTexelPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:mipmapPrecisionBits is the number of bits of division that
        /// the LOD calculation for mipmap fetching get snapped to when
        /// determining the contribution from each mip level to the mip
        /// filtered results. [eq]#2^pname:mipmapPrecisionBits^# is the actual
        /// number of divisions. + -- [NOTE] .Note ==== For example, if this
        /// value is 2 bits then when linearly filtering between two levels,
        /// each level could: contribute: 0%, 33%, 66%, or 100% (this is just
        /// an example and the amount of contribution should: be covered by
        /// different equations in the spec). ==== -- +
        /// </summary>
        public uint MipmapPrecisionBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDrawIndexedIndexValue is the maximum index value that can:
        /// be used for indexed draw calls when using 32-bit indices. This
        /// excludes the primitive restart index value of 0xFFFFFFFF. See
        /// &lt;&lt;features-features-fullDrawIndexUint32,fullDrawIndexUint32&gt;&gt;.
        /// </summary>
        public uint MaxDrawIndexedIndexValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxDrawIndirectCount is the maximum draw count that is
        /// supported for indirect draw calls. See
        /// &lt;&lt;features-features-multiDrawIndirect,multiDrawIndirect&gt;&gt;.
        /// </summary>
        public uint MaxDrawIndirectCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxSamplerLodBias is the maximum absolute sampler level of
        /// detail bias. The sum of the pname:mipLodBias member of the
        /// sname:VkSamplerCreateInfo structure and the code:Bias operand of
        /// image sampling operations in shader modules (or 0 if no code:Bias
        /// operand is provided to an image sampling operation) are clamped to
        /// the range
        /// [eq]#[-pname:maxSamplerLodBias,+pname:maxSamplerLodBias]#. See
        /// &lt;&lt;samplers-mipLodBias&gt;&gt;.
        /// </summary>
        public float MaxSamplerLodBias
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxSamplerAnisotropy is the maximum degree of sampler
        /// anisotropy. The maximum degree of anisotropic filtering used for an
        /// image sampling operation is the minimum of the pname:maxAnisotropy
        /// member of the sname:VkSamplerCreateInfo structure and this limit.
        /// See &lt;&lt;samplers-maxAnisotropy&gt;&gt;.
        /// </summary>
        public float MaxSamplerAnisotropy
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxViewports is the maximum number of active viewports. The
        /// pname:viewportCount member of the
        /// sname:VkPipelineViewportStateCreateInfo structure that is provided
        /// at pipeline creation must: be less than or equal to this limit.
        /// </summary>
        public uint MaxViewports
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxViewportDimensions[2] are the maximum viewport dimensions
        /// in the X (width) and Y (height) dimensions, respectively. The
        /// maximum viewport dimensions must: be greater than or equal to the
        /// largest image which can: be created and used as a framebuffer
        /// attachment. See &lt;&lt;vertexpostproc-viewport,Controlling the
        /// Viewport&gt;&gt;.
        /// </summary>
        public uint[] MaxViewportDimensions
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:viewportBoundsRange[2] is the [eq]#[minimum, maximum]# range
        /// that the corners of a viewport must: be contained in. This range
        /// must: be at least + -- [eq]#[-2 {times} pname:size, 2 {times}
        /// pname:size - 1]#, where [eq]#pname:size =
        /// max(pname:maxViewportDimensions[0], maxViewportDimensions[1])# See
        /// &lt;&lt;vertexpostproc-viewport,Controlling the Viewport&gt;&gt;.
        /// [NOTE] .Note ==== The intent of the pname:viewportBoundsRange limit
        /// is to allow a maximum sized viewport to be arbitrarily shifted
        /// relative to the output target as long as at least some portion
        /// intersects. This would give a bounds limit of [eq]#[-pname:size +
        /// 1, 2 {times} pname:size - 1]# which would allow all possible
        /// non-empty-set intersections of the output target and the viewport.
        /// Since these numbers are typically powers of two, picking the signed
        /// number range using the smallest possible number of bits ends up
        /// with the specified range. ==== --
        /// </summary>
        public float[] ViewportBoundsRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:viewportSubPixelBits is the number of bits of subpixel
        /// precision for viewport bounds. The subpixel precision that
        /// floating-point viewport bounds are interpreted at is given by this
        /// limit.
        /// </summary>
        public uint ViewportSubPixelBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minMemoryMapAlignment is the minimum required: alignment, in
        /// bytes, of host visible memory allocations within the host address
        /// space. When mapping a memory allocation with flink:vkMapMemory,
        /// subtracting pname:offset bytes from the returned pointer will
        /// always produce an integer multiple of this limit. See
        /// &lt;&lt;memory-device-hostaccess&gt;&gt;.
        /// </summary>
        public Size MinMemoryMapAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minTexelBufferOffsetAlignment is the minimum required:
        /// alignment, in bytes, for the pname:offset member of the
        /// sname:VkBufferViewCreateInfo structure for texel buffers. When a
        /// buffer view is created for a buffer which was created with
        /// ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT or
        /// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set in the
        /// pname:usage member of the sname:VkBufferCreateInfo structure, the
        /// pname:offset must: be an integer multiple of this limit.
        /// </summary>
        public ulong MinTexelBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minUniformBufferOffsetAlignment is the minimum required:
        /// alignment, in bytes, for the pname:offset member of the
        /// sname:VkDescriptorBufferInfo structure for uniform buffers. When a
        /// descriptor of type ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC is updated, the
        /// pname:offset must: be an integer multiple of this limit. Similarly,
        /// dynamic offsets for uniform buffers must: be multiples of this
        /// limit.
        /// </summary>
        public ulong MinUniformBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minStorageBufferOffsetAlignment is the minimum required:
        /// alignment, in bytes, for the pname:offset member of the
        /// sname:VkDescriptorBufferInfo structure for storage buffers. When a
        /// descriptor of type ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC is updated, the
        /// pname:offset must: be an integer multiple of this limit. Similarly,
        /// dynamic offsets for storage buffers must: be multiples of this
        /// limit.
        /// </summary>
        public ulong MinStorageBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minTexelOffset is the minimum offset value for the
        /// code:ConstOffset image operand of any of the code:OpImageSample* or
        /// code:OpImageFetch* image instructions.
        /// </summary>
        public int MinTexelOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTexelOffset is the maximum offset value for the
        /// code:ConstOffset image operand of any of the code:OpImageSample* or
        /// code:OpImageFetch* image instructions.
        /// </summary>
        public uint MaxTexelOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minTexelGatherOffset is the minimum offset value for the
        /// code:Offset or code:ConstOffsets image operands of any of the
        /// code:OpImage*code:Gather image instructions.
        /// </summary>
        public int MinTexelGatherOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxTexelGatherOffset is the maximum offset value for the
        /// code:Offset or code:ConstOffsets image operands of any of the
        /// code:OpImage*code:Gather image instructions.
        /// </summary>
        public uint MaxTexelGatherOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minInterpolationOffset is the minimum negative offset value
        /// for the code:offset operand of the code:InterpolateAtOffset
        /// extended instruction.
        /// </summary>
        public float MinInterpolationOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxInterpolationOffset is the maximum positive offset value
        /// for the code:offset operand of the code:InterpolateAtOffset
        /// extended instruction.
        /// </summary>
        public float MaxInterpolationOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subPixelInterpolationOffsetBits is the number of subpixel
        /// fractional bits that the code:x and code:y offsets to the
        /// code:InterpolateAtOffset extended instruction may: be rounded to as
        /// fixed-point values.
        /// </summary>
        public uint SubPixelInterpolationOffsetBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFramebufferWidth is the maximum width for a framebuffer.
        /// The pname:width member of the sname:VkFramebufferCreateInfo
        /// structure must: be less than or equal to this limit.
        /// </summary>
        public uint MaxFramebufferWidth
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFramebufferHeight is the maximum height for a framebuffer.
        /// The pname:height member of the sname:VkFramebufferCreateInfo
        /// structure must: be less than or equal to this limit.
        /// </summary>
        public uint MaxFramebufferHeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxFramebufferLayers is the maximum layer count for a layered
        /// framebuffer. The pname:layers member of the
        /// sname:VkFramebufferCreateInfo structure must: be less than or equal
        /// to this limit.
        /// </summary>
        public uint MaxFramebufferLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:framebufferColorSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the color sample counts
        /// that are supported for all framebuffer color attachments.
        /// </summary>
        public SampleCountFlags FramebufferColorSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:framebufferDepthSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the supported depth
        /// sample counts for all framebuffer depth/stencil attachments, when
        /// the format includes a depth component.
        /// </summary>
        public SampleCountFlags FramebufferDepthSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:framebufferStencilSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the supported stencil
        /// sample counts for all framebuffer depth/stencil attachments, when
        /// the format includes a stencil component.
        /// </summary>
        public SampleCountFlags FramebufferStencilSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:framebufferNoAttachmentsSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the supported sample
        /// counts for a framebuffer with no attachments.
        /// </summary>
        public SampleCountFlags FramebufferNoAttachmentsSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxColorAttachments is the maximum number of color
        /// attachments that can: be used by a subpass in a render pass. The
        /// pname:colorAttachmentCount member of the sname:VkSubpassDescription
        /// structure must: be less than or equal to this limit.
        /// </summary>
        public uint MaxColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sampledImageColorSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the sample counts
        /// supported for all 2D images created with
        /// ename:VK_IMAGE_TILING_OPTIMAL, pname:usage containing
        /// ename:VK_IMAGE_USAGE_SAMPLED_BIT, and a non-integer color format.
        /// </summary>
        public SampleCountFlags SampledImageColorSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sampledImageIntegerSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the sample counts
        /// supported for all 2D images created with
        /// ename:VK_IMAGE_TILING_OPTIMAL, pname:usage containing
        /// ename:VK_IMAGE_USAGE_SAMPLED_BIT, and an integer color format.
        /// </summary>
        public SampleCountFlags SampledImageIntegerSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sampledImageDepthSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the sample counts
        /// supported for all 2D images created with
        /// ename:VK_IMAGE_TILING_OPTIMAL, pname:usage containing
        /// ename:VK_IMAGE_USAGE_SAMPLED_BIT, and a depth format.
        /// </summary>
        public SampleCountFlags SampledImageDepthSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sampledImageStencilSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the sample supported
        /// for all 2D images created with ename:VK_IMAGE_TILING_OPTIMAL,
        /// pname:usage containing ename:VK_IMAGE_USAGE_SAMPLED_BIT, and a
        /// stencil format.
        /// </summary>
        public SampleCountFlags SampledImageStencilSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:storageImageSampleCounts is a bitmask^1^ of
        /// elink:VkSampleCountFlagBits bits indicating the sample counts
        /// supported for all 2D images created with
        /// ename:VK_IMAGE_TILING_OPTIMAL, and pname:usage containing
        /// ename:VK_IMAGE_USAGE_STORAGE_BIT.
        /// </summary>
        public SampleCountFlags StorageImageSampleCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxSampleMaskWords is the maximum number of array elements of
        /// a variable decorated with the code:SampleMask built-in decoration.
        /// </summary>
        public uint MaxSampleMaskWords
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:timestampComputeAndGraphics indicates support for timestamps
        /// on all graphics and compute queues. If this limit is set to
        /// ename:VK_TRUE, all queues that advertise the
        /// ename:VK_QUEUE_GRAPHICS_BIT or ename:VK_QUEUE_COMPUTE_BIT in the
        /// sname:VkQueueFamilyProperties::pname:queueFlags support
        /// sname:VkQueueFamilyProperties::pname:timestampValidBits of at least
        /// 36. See &lt;&lt;queries-timestamps, Timestamp Queries&gt;&gt;.
        /// </summary>
        public Bool32 TimestampComputeAndGraphics
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:timestampPeriod is the number of nanoseconds required: for a
        /// timestamp query to be incremented by 1. See
        /// &lt;&lt;queries-timestamps, Timestamp Queries&gt;&gt;.
        /// </summary>
        public float TimestampPeriod
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxClipDistances is the maximum number of clip distances that
        /// can: be used in a single shader stage. The size of any array
        /// declared with the code:ClipDistance built-in decoration in a shader
        /// module must: be less than or equal to this limit.
        /// </summary>
        public uint MaxClipDistances
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxCullDistances is the maximum number of cull distances that
        /// can: be used in a single shader stage. The size of any array
        /// declared with the code:CullDistance built-in decoration in a shader
        /// module must: be less than or equal to this limit.
        /// </summary>
        public uint MaxCullDistances
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxCombinedClipAndCullDistances is the maximum combined
        /// number of clip and cull distances that can: be used in a single
        /// shader stage. The sum of the sizes of any pair of arrays declared
        /// with the code:ClipDistance and code:CullDistance built-in
        /// decoration used by a single shader stage in a shader module must:
        /// be less than or equal to this limit.
        /// </summary>
        public uint MaxCombinedClipAndCullDistances
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:discreteQueuePriorities is the number of discrete priorities
        /// that can: be assigned to a queue based on the value of each member
        /// of sname:VkDeviceQueueCreateInfo::pname:pQueuePriorities. This
        /// must: be at least 2, and levels must: be spread evenly over the
        /// range, with at least one level at 1.0, and another at 0.0. See
        /// &lt;&lt;devsandqueues-priority&gt;&gt;.
        /// </summary>
        public uint DiscreteQueuePriorities
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pointSizeRange[2] is the range
        /// [eq]#[pname:minimum,pname:maximum]# of supported sizes for points.
        /// Values written to variables decorated with the code:PointSize
        /// built-in decoration are clamped to this range.
        /// </summary>
        public float[] PointSizeRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:lineWidthRange[2] is the range
        /// [eq]#[pname:minimum,pname:maximum]# of supported widths for lines.
        /// Values specified by the pname:lineWidth member of the
        /// sname:VkPipelineRasterizationStateCreateInfo or the pname:lineWidth
        /// parameter to fname:vkCmdSetLineWidth are clamped to this range.
        /// </summary>
        public float[] LineWidthRange
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pointSizeGranularity is the granularity of supported point
        /// sizes. Not all point sizes in the range defined by
        /// pname:pointSizeRange are supported. This limit specifies the
        /// granularity (or increment) between successive supported point
        /// sizes.
        /// </summary>
        public float PointSizeGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:lineWidthGranularity is the granularity of supported line
        /// widths. Not all line widths in the range defined by
        /// pname:lineWidthRange are supported. This limit specifies the
        /// granularity (or increment) between successive supported line
        /// widths.
        /// </summary>
        public float LineWidthGranularity
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:strictLines indicates whether lines are rasterized according
        /// to the preferred method of rasterization. If set to ename:VK_FALSE,
        /// lines may: be rasterized under a relaxed set of rules. If set to
        /// ename:VK_TRUE, lines are rasterized as per the strict definition.
        /// See &lt;&lt;primsrast-lines-basic,Basic Line Segment
        /// Rasterization&gt;&gt;.
        /// </summary>
        public Bool32 StrictLines
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:standardSampleLocations indicates whether rasterization uses
        /// the standard sample locations as documented in
        /// &lt;&lt;primsrast-multisampling,Multisampling&gt;&gt;. If set to
        /// ename:VK_TRUE, the implementation uses the documented sample
        /// locations. If set to ename:VK_FALSE, the implementation may: use
        /// different sample locations.
        /// </summary>
        public Bool32 StandardSampleLocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:optimalBufferCopyOffsetAlignment is the optimal buffer offset
        /// alignment in bytes for fname:vkCmdCopyBufferToImage and
        /// fname:vkCmdCopyImageToBuffer. The per texel alignment requirements
        /// are still enforced, this is just an additional alignment
        /// recommendation for optimal performance and power.
        /// </summary>
        public ulong OptimalBufferCopyOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:optimalBufferCopyRowPitchAlignment is the optimal buffer row
        /// pitch alignment in bytes for fname:vkCmdCopyBufferToImage and
        /// fname:vkCmdCopyImageToBuffer. Row pitch is the number of bytes
        /// between texels with the same X coordinate in adjacent rows (Y
        /// coordinates differ by one). The per texel alignment requirements
        /// are still enforced, this is just an additional alignment
        /// recommendation for optimal performance and power.
        /// </summary>
        public ulong OptimalBufferCopyRowPitchAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:nonCoherentAtomSize is the size and alignment in bytes that
        /// bounds concurrent access to &lt;&lt;memory-device-hostaccess,
        /// host-mapped device memory&gt;&gt;.
        /// </summary>
        public ulong NonCoherentAtomSize
        {
            get;
            set;
        }
        
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
    /// The sname:VkPhysicalDeviceMemoryProperties structure describes a number
    /// of _memory heaps_ as well as a number of _memory types_ that can: be
    /// used to access memory allocated in those heaps. Each heap describes a
    /// memory resource of a particular size, and each memory type describes a
    /// set of memory properties (e.g. host cached vs uncached) that can: be
    /// used with a given memory heap. Allocations using a particular memory
    /// type will consume resources from the heap indicated by that memory
    /// type's heap index. More than one memory type may: share each heap, and
    /// the heaps and memory types provide a mechanism to advertise an accurate
    /// size of the physical memory resources while allowing the memory to be
    /// used with a variety of different properties.
    /// </para>
    /// <para>
    /// The number of memory heaps is given by pname:memoryHeapCount and is
    /// less than or equal to ename:VK_MAX_MEMORY_HEAPS. Each heap is described
    /// by an element of the pname:memoryHeaps array, as a sname:VkMemoryHeap
    /// structure. The number of memory types available across all memory heaps
    /// is given by pname:memoryTypeCount and is less than or equal to
    /// ename:VK_MAX_MEMORY_TYPES. Each memory type is described by an element
    /// of the pname:memoryTypes array, as a sname:VkMemoryType structure.
    /// </para>
    /// <para>
    /// At least one heap must: include ename:VK_MEMORY_HEAP_DEVICE_LOCAL_BIT
    /// in slink:VkMemoryHeap::pname:flags. If there are multiple heaps that
    /// all have similar performance characteristics, they may: all include
    /// ename:VK_MEMORY_HEAP_DEVICE_LOCAL_BIT. In a unified memory architecture
    /// (UMA) system, there is often only a single memory heap which is
    /// considered to be equally ``local'' to the host and to the device, and
    /// such an implementation must: advertise the heap as device-local.
    /// </para>
    /// <para>
    /// Each memory type returned by flink:vkGetPhysicalDeviceMemoryProperties
    /// must: have its pname:propertyFlags set to one of the following values:
    /// </para>
    /// <para>
    /// * 0 * ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT *
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT *
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT *
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT *
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT *
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT *
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_CACHED_BIT |
    /// ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT *
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT |
    /// ename:VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT
    /// </para>
    /// <para>
    /// There must: be at least one memory type with both the
    /// ename:VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT and
    /// ename:VK_MEMORY_PROPERTY_HOST_COHERENT_BIT bits set in its
    /// pname:propertyFlags. There must: be at least one memory type with the
    /// ename:VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT bit set in its
    /// pname:propertyFlags.
    /// </para>
    /// <para>
    /// The memory types are sorted according to a preorder which serves to aid
    /// in easily selecting an appropriate memory type. Given two memory types
    /// X and Y, the preorder defines [eq]#X {leq} Y# if:
    /// </para>
    /// <para>
    /// * the memory property bits set for X are a strict subset of the memory
    /// property bits set for Y. Or, * the memory property bits set for X are
    /// the same as the memory property bits set for Y, and X uses a memory
    /// heap with greater or equal performance (as determined in an
    /// implementation-specific manner).
    /// </para>
    /// <para>
    /// Memory types are ordered in the list such that X is assigned a lesser
    /// pname:memoryTypeIndex than Y if [eq]#(X {leq} Y) {land} {lnot} (Y {leq}
    /// X)# according to the preorder. Note that the list of all allowed memory
    /// property flag combinations above satisfies this preorder, but other
    /// orders would as well. The goal of this ordering is to enable
    /// applications to use a simple search loop in selecting the proper memory
    /// type, along the lines of:
    /// </para>
    /// <para>
    /// [source,{basebackend@docbook:c++:cpp}]
    /// --------------------------------------------------- // Find a memory
    /// type in "memoryTypeBits" that includes all of "properties" int32_t
    /// FindProperties(uint32_t memoryTypeBits, VkMemoryPropertyFlags
    /// properties) { for (int32_t i = 0; i &lt; memoryTypeCount; ++i) { if
    /// ((memoryTypeBits &amp; (1 &lt;&lt; i)) &amp;&amp;
    /// ((memoryTypes[i].propertyFlags &amp; properties) == properties)) return
    /// i; } return -1; }
    /// </para>
    /// <para>
    /// // Try to find an optimal memory type, or if it does not exist // find
    /// any compatible memory type VkMemoryRequirements memoryRequirements;
    /// vkGetImageMemoryRequirements(device, image, &amp;memoryRequirements);
    /// int32_t memoryType = FindProperties(memoryRequirements.memoryTypeBits,
    /// optimalProperties); if (memoryType == -1) memoryType =
    /// FindProperties(memoryRequirements.memoryTypeBits, requiredProperties);
    /// ---------------------------------------------------
    /// </para>
    /// <para>
    /// The loop will find the first supported memory type that has all bits
    /// requested in code:properties set. If there is no exact match, it will
    /// find a closest match (i.e. a memory type with the fewest additional
    /// bits set), which has some additional bits set but which are not
    /// detrimental to the behaviors requested by code:properties. The
    /// application can: first search for the optimal properties, e.g. a memory
    /// type that is device-local or supports coherent cached accesses, as
    /// appropriate for the intended usage, and if such a memory type is not
    /// present can: fallback to searching for a less optimal but guaranteed
    /// set of properties such as "0" or "host-visible and coherent".
    /// </para>
    /// </summary>
    public struct PhysicalDeviceMemoryProperties
    {
        /// <summary>
        /// pname:memoryTypes is an array of slink:VkMemoryType structures
        /// describing the _memory types_ that can: be used to access memory
        /// allocated from the heaps specified by pname:memoryHeaps.
        /// </summary>
        public MemoryType[] MemoryTypes
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memoryHeaps is an array of slink:VkMemoryHeap structures
        /// describing the _memory heaps_ from which memory can: be allocated.
        /// </summary>
        public MemoryHeap[] MemoryHeaps
        {
            get;
            set;
        }
        
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
    /// <para>
    /// Structure specifying physical device properties.
    /// </para>
    /// <para>
    /// The pname:vendorID and pname:deviceID fields are provided to allow
    /// applications to adapt to device characteristics that are not adequately
    /// exposed by other Vulkan queries. These may: include performance
    /// profiles, hardware errata, or other characteristics. In PCI-based
    /// implementations, the low sixteen bits of pname:vendorID and
    /// pname:deviceID must: contain (respectively) the PCI vendor and device
    /// IDs associated with the hardware device, and the remaining bits must:
    /// be set to zero. In non-PCI implementations, the choice of what values
    /// to return may: be dictated by operating system or platform policies. It
    /// is otherwise at the discretion of the implementer, subject to the
    /// following constraints and guidelines:
    /// </para>
    /// <para>
    /// * For purposes of physical device identification, the _vendor_ of a
    /// physical device is the entity responsible for the most salient
    /// characteristics of the hardware represented by the physical device
    /// handle. In the case of a discrete GPU, this should: be the GPU chipset
    /// vendor. In the case of a GPU or other accelerator integrated into a
    /// system-on-chip (SoC), this should: be the supplier of the silicon IP
    /// used to create the GPU or other accelerator. * If the vendor of the
    /// physical device has a valid PCI vendor ID issued by
    /// https://pcisig.com/[PCI-SIG], that ID should: be used to construct
    /// pname:vendorID as described above for PCI-based implementations.
    /// Implementations that do not return a PCI vendor ID in pname:vendorID
    /// must: return a valid Khronos vendor ID, obtained as described in the
    /// &lt;&lt;vulkan-styleguide,Vulkan Documentation and Extensions&gt;&gt;
    /// document in the section ``Registering a Vendor ID with Khronos''.
    /// Khronos vendor IDs are allocated starting at 0x10000, to distinguish
    /// them from the PCI vendor ID namespace. * The vendor of the physical
    /// device is responsible for selecting pname:deviceID. The value selected
    /// should: uniquely identify both the device version and any major
    /// configuration options (for example, core count in the case of multicore
    /// devices). The same device ID should: be used for all physical
    /// implementations of that device version and configuration. For example,
    /// all uses of a specific silicon IP GPU version and configuration should:
    /// use the same device ID, even if those uses occur in different SoCs.
    /// </para>
    /// </summary>
    public struct PhysicalDeviceProperties
    {
        /// <summary>
        /// pname:apiVersion is the version of Vulkan supported by the device,
        /// encoded as described in the &lt;&lt;fundamentals-versionnum,API
        /// Version Numbers and Semantics&gt;&gt; section.
        /// </summary>
        public Version ApiVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:driverVersion is the vendor-specified version of the driver.
        /// </summary>
        public Version DriverVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:vendorID is a unique identifier for the _vendor_ (see below)
        /// of the physical device.
        /// </summary>
        public uint VendorID
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:deviceID is a unique identifier for the physical device among
        /// devices available from the vendor.
        /// </summary>
        public uint DeviceID
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:deviceType is a elink:VkPhysicalDeviceType specifying the
        /// type of device.
        /// </summary>
        public PhysicalDeviceType DeviceType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:deviceName is a null-terminated UTF-8 string containing the
        /// name of the device.
        /// </summary>
        public string DeviceName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pipelineCacheUUID is an array of size ename:VK_UUID_SIZE,
        /// containing 8-bit values that represent a universally unique
        /// identifier for the device.
        /// </summary>
        public Guid PipelineCacheUUID
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:limits is the slink:VkPhysicalDeviceLimits structure which
        /// specifies device-specific limits of the physical device. See
        /// &lt;&lt;features-limits,Limits&gt;&gt; for details.
        /// </summary>
        public PhysicalDeviceLimits Limits
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sparseProperties is the
        /// slink:VkPhysicalDeviceSparseProperties structure which specifies
        /// various sparse related properties of the physical device. See
        /// &lt;&lt;sparsememory-physicalprops,Sparse Properties&gt;&gt; for
        /// details.
        /// </summary>
        public PhysicalDeviceSparseProperties SparseProperties
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * If pname:initialDataSize is not `0`, it must: be
    /// equal to the size of pname:pInitialData, as returned by
    /// fname:vkGetPipelineCacheData when pname:pInitialData was originally
    /// retrieved * If pname:initialDataSize is not `0`, pname:pInitialData
    /// must: have been retrieved from a previous call to
    /// fname:vkGetPipelineCacheData ****
    /// </para>
    /// </summary>
    public struct PipelineCacheCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineCacheCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pInitialData is a pointer to previously retrieved pipeline
        /// cache data. If the pipeline cache data is incompatible (as defined
        /// below) with the device, the pipeline cache will be initially empty.
        /// If pname:initialDataSize is zero, pname:pInitialData is ignored.
        /// </summary>
        public byte[] InitialData
        {
            get;
            set;
        }
        
        internal unsafe Interop.PipelineCacheCreateInfo Pack()
        {
            Interop.PipelineCacheCreateInfo result = default(Interop.PipelineCacheCreateInfo);
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
    /// Structure specifying parameters of a newly created pipeline color blend
    /// state.
    /// </para>
    /// <para>
    /// Each element of the pname:pAttachments array is a
    /// slink:VkPipelineColorBlendAttachmentState structure specifying
    /// per-target blending state for each individual color attachment. If the
    /// &lt;&lt;features-features-independentBlend,independent blending&gt;&gt;
    /// feature is not enabled on the device, all
    /// slink:VkPipelineColorBlendAttachmentState elements in the
    /// pname:pAttachments array must: be identical.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-independentBlend,independent blending&gt;&gt;
    /// feature is not enabled, all elements of pname:pAttachments must: be
    /// identical * If the &lt;&lt;features-features-logicOp,logic
    /// operations&gt;&gt; feature is not enabled, pname:logicOpEnable must: be
    /// ename:VK_FALSE * If pname:logicOpEnable is ename:VK_TRUE, pname:logicOp
    /// must: be a valid elink:VkLogicOp value ****
    /// </para>
    /// </summary>
    public struct PipelineColorBlendStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineColorBlendStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:logicOpEnable controls whether to apply
        /// &lt;&lt;framebuffer-logicop, Logical Operations&gt;&gt;.
        /// </summary>
        public Bool32 LogicOpEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:logicOp selects which logical operation to apply.
        /// </summary>
        public LogicOp LogicOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pAttachments: is a pointer to array of per target attachment
        /// states.
        /// </summary>
        public PipelineColorBlendAttachmentState[] Attachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:blendConstants is an array of four values used as the R, G,
        /// B, and A components of the blend constant that are used in
        /// blending, depending on the &lt;&lt;framebuffer-blendfactors,blend
        /// factor&gt;&gt;.
        /// </summary>
        public float[] BlendConstants
        {
            get;
            set;
        }
        
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
            Validate.CheckLength(this.BlendConstants, 4, "BlendConstants");
            MemUtil.WriteToPtr((IntPtr)(result.BlendConstants), this.BlendConstants, 0, 4);
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
    /// Structure specifying parameters of a newly created pipeline depth
    /// stencil state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the &lt;&lt;features-features-depthBounds,depth
    /// bounds testing&gt;&gt; feature is not enabled,
    /// pname:depthBoundsTestEnable must: be ename:VK_FALSE ****
    /// </para>
    /// </summary>
    public struct PipelineDepthStencilStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineDepthStencilStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthTestEnable controls whether &lt;&lt;fragops-depth,depth
        /// testing&gt;&gt; is enabled.
        /// </summary>
        public Bool32 DepthTestEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthWriteEnable controls whether
        /// &lt;&lt;fragops-depth-write,depth writes&gt;&gt; are enabled.
        /// </summary>
        public Bool32 DepthWriteEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthCompareOp is the comparison operator used in the
        /// &lt;&lt;fragops-depth,depth test&gt;&gt;.
        /// </summary>
        public CompareOp DepthCompareOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthBoundsTestEnable controls whether
        /// &lt;&lt;fragops-dbt,depth bounds testing&gt;&gt; is enabled.
        /// </summary>
        public Bool32 DepthBoundsTestEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:stencilTestEnable controls whether
        /// &lt;&lt;fragops-stencil,stencil testing&gt;&gt; is enabled.
        /// </summary>
        public Bool32 StencilTestEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:front and pname:back control the parameters of the
        /// &lt;&lt;fragops-stencil,stencil test&gt;&gt;.
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
        /// pname:minDepthBounds and pname:maxDepthBounds define the range of
        /// values used in the &lt;&lt;fragops-dbt,depth bounds test&gt;&gt;.
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
        
        internal unsafe Interop.PipelineDepthStencilStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineDepthStencilStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying parameters of a newly created pipeline dynamic
    /// state.
    /// </summary>
    public struct PipelineDynamicStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineDynamicStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pDynamicStates is an array of elink:VkDynamicState enums
        /// which indicate which pieces of pipeline state will use the values
        /// from dynamic state commands rather than from the pipeline state
        /// creation info.
        /// </summary>
        public DynamicState[] DynamicStates
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.PipelineDynamicStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineDynamicStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline input
    /// assembly state.
    /// </para>
    /// <para>
    /// Restarting the assembly of primitives discards the most recent index
    /// values if those elements formed an incomplete primitive, and restarts
    /// the primitive assembly using the subsequent indices, but only
    /// assembling the immediately following element through the end of the
    /// originally specified elements. The primitive restart index value
    /// comparison is performed before adding the pname:vertexOffset value to
    /// the index value.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:topology is
    /// ename:VK_PRIMITIVE_TOPOLOGY_POINT_LIST, ename:VK_PRIMITIVE_TOPOLOGY_LINE_LIST,
    /// ename:VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST,
    /// ename:VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY, ename:VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY
    /// or ename:VK_PRIMITIVE_TOPOLOGY_PATCH_LIST, pname:primitiveRestartEnable
    /// must: be ename:VK_FALSE * If the
    /// &lt;&lt;features-features-geometryShader,geometry shaders&gt;&gt;
    /// feature is not enabled, pname:topology must: not be any of
    /// ename:VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY, ename:VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY,
    /// ename:VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY or
    /// ename:VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY * If the
    /// &lt;&lt;features-features-tessellationShader,tessellation shaders&gt;&gt;
    /// feature is not enabled, pname:topology must: not be
    /// ename:VK_PRIMITIVE_TOPOLOGY_PATCH_LIST ****
    /// </para>
    /// </summary>
    public struct PipelineInputAssemblyStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineInputAssemblyStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:topology is a elink:VkPrimitiveTopology defining the
        /// primitive topology, as described below.
        /// </summary>
        public PrimitiveTopology Topology
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:primitiveRestartEnable controls whether a special vertex
        /// index value is treated as restarting the assembly of primitives.
        /// This enable only applies to indexed draws (flink:vkCmdDrawIndexed
        /// and flink:vkCmdDrawIndexedIndirect), and the special index value is
        /// either 0xFFFFFFFF when the pname:indexType parameter of
        /// fname:vkCmdBindIndexBuffer is equal to ename:VK_INDEX_TYPE_UINT32,
        /// or 0xFFFF when pname:indexType is equal to
        /// ename:VK_INDEX_TYPE_UINT16. Primitive restart is not allowed for
        /// ``list'' topologies.
        /// </summary>
        public Bool32 PrimitiveRestartEnable
        {
            get;
            set;
        }
        
        internal unsafe Interop.PipelineInputAssemblyStateCreateInfo Pack()
        {
            Interop.PipelineInputAssemblyStateCreateInfo result = default(Interop.PipelineInputAssemblyStateCreateInfo);
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
    /// Structure specifying the parameters of a newly created pipeline layout
    /// object.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:setLayoutCount must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxBoundDescriptorSets * The total
    /// number of descriptors of the type ename:VK_DESCRIPTOR_TYPE_SAMPLER and
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER accessible to any given
    /// shader stage across all elements of pname:pSetLayouts must: be less
    /// than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorSamplers * The
    /// total number of descriptors of the type
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER and
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC accessible to any given
    /// shader stage across all elements of pname:pSetLayouts must: be less
    /// than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorUniformBuffers *
    /// The total number of descriptors of the type
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER and
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC accessible to any given
    /// shader stage across all elements of pname:pSetLayouts must: be less
    /// than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorStorageBuffers *
    /// The total number of descriptors of the type
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
    /// and ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER accessible to any
    /// given shader stage across all elements of pname:pSetLayouts must: be
    /// less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorSampledImages *
    /// The total number of descriptors of the type
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, and
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER accessible to any given
    /// shader stage across all elements of pname:pSetLayouts must: be less
    /// than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxPerStageDescriptorStorageImages *
    /// Any two elements of pname:pPushConstantRanges must: not include the
    /// same stage in pname:stageFlags ****
    /// </para>
    /// </summary>
    public struct PipelineLayoutCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineLayoutCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSetLayouts is a pointer to an array of
        /// sname:VkDescriptorSetLayout objects.
        /// </summary>
        public DescriptorSetLayout[] SetLayouts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pPushConstantRanges is a pointer to an array of
        /// sname:VkPushConstantRange structures defining a set of push
        /// constant ranges for use in a single pipeline layout. In addition to
        /// descriptor set layouts, a pipeline layout also describes how many
        /// push constants can: be accessed by each stage of the pipeline. +
        /// [NOTE] .Note ==== Push constants represent a high speed path to
        /// modify constant data in pipelines that is expected to outperform
        /// memory-backed resource updates. ====
        /// </summary>
        public PushConstantRange[] PushConstantRanges
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.PipelineLayoutCreateInfo* MarshalTo()
        {
            return (Interop.PipelineLayoutCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline multisample
    /// state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-sampleRateShading,sample rate shading&gt;&gt;
    /// feature is not enabled, pname:sampleShadingEnable must: be
    /// ename:VK_FALSE * If the &lt;&lt;features-features-alphaToOne,alpha to
    /// one&gt;&gt; feature is not enabled, pname:alphaToOneEnable must: be
    /// ename:VK_FALSE * pname:minSampleShading must: be in the range
    /// [eq]#[0,1]# ****
    /// </para>
    /// </summary>
    public struct PipelineMultisampleStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineMultisampleStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:rasterizationSamples is a elink:VkSampleCountFlagBits
        /// specifying the number of samples per pixel used in rasterization.
        /// </summary>
        public SampleCountFlags RasterizationSamples
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sampleShadingEnable specifies that fragment shading executes
        /// per-sample if ename:VK_TRUE, or per-fragment if ename:VK_FALSE, as
        /// described in &lt;&lt;primsrast-sampleshading,Sample
        /// Shading&gt;&gt;.
        /// </summary>
        public Bool32 SampleShadingEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minSampleShading is the minimum fraction of sample shading,
        /// as described in &lt;&lt;primsrast-sampleshading,Sample
        /// Shading&gt;&gt;.
        /// </summary>
        public float MinSampleShading
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSampleMask is a bitmask of static coverage information that
        /// is ANDed with the coverage information generated during
        /// rasterization, as described in &lt;&lt;fragops-samplemask,Sample
        /// Mask&gt;&gt;.
        /// </summary>
        public SampleMask[] SampleMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:alphaToCoverageEnable controls whether a temporary coverage
        /// value is generated based on the alpha component of the fragment's
        /// first color output as specified in the
        /// &lt;&lt;fragops-covg,Multisample Coverage&gt;&gt; section.
        /// </summary>
        public Bool32 AlphaToCoverageEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:alphaToOneEnable controls whether the alpha component of the
        /// fragment's first color output is replaced with one as described in
        /// &lt;&lt;fragops-covg,Multisample Coverage&gt;&gt;.
        /// </summary>
        public Bool32 AlphaToOneEnable
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.PipelineMultisampleStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineMultisampleStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline
    /// rasterization state.
    /// </para>
    /// <para>
    /// ifdef::VK_AMD_rasterization_order[] The application can: also chain a
    /// sname:VkPipelineRasterizationStateRasterizationOrderAMD structure to
    /// the sname:VkPipelineRasterizationStateCreateInfo structure through its
    /// pname:pNext member. This structure enables selecting the rasterization
    /// order to use when rendering with the corresponding graphics pipeline as
    /// described in &lt;&lt;primrast-order, Rasterization Order&gt;&gt;.
    /// endif::VK_AMD_rasterization_order[]
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the &lt;&lt;features-features-depthClamp,depth
    /// clamping&gt;&gt; feature is not enabled, pname:depthClampEnable must:
    /// be ename:VK_FALSE * If the
    /// &lt;&lt;features-features-fillModeNonSolid,non-solid fill modes&gt;&gt;
    /// feature is not enabled, pname:polygonMode must: be
    /// ename:VK_POLYGON_MODE_FILL ****
    /// </para>
    /// </summary>
    public struct PipelineRasterizationStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineRasterizationStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthClampEnable controls whether to clamp the fragment's
        /// depth values instead of clipping primitives to the z planes of the
        /// frustum, as described in &lt;&lt;vertexpostproc-clipping,Primitive
        /// Clipping&gt;&gt;.
        /// </summary>
        public Bool32 DepthClampEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:rasterizerDiscardEnable controls whether primitives are
        /// discarded immediately before the rasterization stage.
        /// </summary>
        public Bool32 RasterizerDiscardEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:polygonMode is the triangle rendering mode. See
        /// elink:VkPolygonMode.
        /// </summary>
        public PolygonMode PolygonMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:cullMode is the triangle facing direction used for primitive
        /// culling. See elink:VkCullModeFlagBits.
        /// </summary>
        public CullModeFlags CullMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:frontFace is the front-facing triangle orientation to be used
        /// for culling. See elink:VkFrontFace.
        /// </summary>
        public FrontFace FrontFace
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthBiasEnable controls whether to bias fragment depth
        /// values.
        /// </summary>
        public Bool32 DepthBiasEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthBiasConstantFactor is a scalar factor controlling the
        /// constant depth value added to each fragment.
        /// </summary>
        public float DepthBiasConstantFactor
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthBiasClamp is the maximum (or minimum) depth bias of a
        /// fragment.
        /// </summary>
        public float DepthBiasClamp
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthBiasSlopeFactor is a scalar factor applied to a
        /// fragment's slope in depth bias calculations.
        /// </summary>
        public float DepthBiasSlopeFactor
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:lineWidth is the width of rasterized line segments.
        /// </summary>
        public float LineWidth
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.PipelineRasterizationStateRasterizationOrder Pack()
        {
            Interop.PipelineRasterizationStateRasterizationOrder result = default(Interop.PipelineRasterizationStateRasterizationOrder);
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
    /// Structure specifying parameters of a newly created pipeline shader
    /// stage.
    /// </summary>
    public struct PipelineShaderStageCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineShaderStageCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:stage names a single pipeline stage. Bits which can: be set
        /// include: + --
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
        
        internal unsafe Interop.PipelineShaderStageCreateInfo* MarshalTo()
        {
            return (Interop.PipelineShaderStageCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline
    /// tessellation state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:patchControlPoints must: be greater than zero
    /// and less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxTessellationPatchSize ****
    /// </para>
    /// </summary>
    public struct PipelineTessellationStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineTessellationStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:patchControlPoints number of control points per patch.
        /// </summary>
        public uint PatchControlPoints
        {
            get;
            set;
        }
        
        internal unsafe Interop.PipelineTessellationStateCreateInfo Pack()
        {
            Interop.PipelineTessellationStateCreateInfo result = default(Interop.PipelineTessellationStateCreateInfo);
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
    /// Structure specifying parameters of a newly created pipeline vertex
    /// input state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:vertexBindingDescriptionCount must: be less
    /// than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxVertexInputBindings *
    /// pname:vertexAttributeDescriptionCount must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxVertexInputAttributes * For
    /// every pname:binding specified by any given element of
    /// pname:pVertexAttributeDescriptions, a
    /// sname:VkVertexInputBindingDescription must: exist in
    /// pname:pVertexBindingDescriptions with the same value of pname:binding *
    /// All elements of pname:pVertexBindingDescriptions must: describe
    /// distinct binding numbers * All elements of
    /// pname:pVertexAttributeDescriptions must: describe distinct attribute
    /// locations ****
    /// </para>
    /// </summary>
    public struct PipelineVertexInputStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineVertexInputStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pVertexBindingDescriptions is a pointer to an array of
        /// sname:VkVertexInputBindingDescription structures.
        /// </summary>
        public VertexInputBindingDescription[] VertexBindingDescriptions
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pVertexAttributeDescriptions is a pointer to an array of
        /// sname:VkVertexInputAttributeDescription structures.
        /// </summary>
        public VertexInputAttributeDescription[] VertexAttributeDescriptions
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.PipelineVertexInputStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineVertexInputStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// <para>
    /// Structure specifying parameters of a newly created pipeline viewport
    /// state.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-multiViewport,multiple viewports&gt;&gt;
    /// feature is not enabled, pname:viewportCount must: be `1` * If the
    /// &lt;&lt;features-features-multiViewport,multiple viewports&gt;&gt;
    /// feature is not enabled, pname:scissorCount must: be `1` *
    /// pname:viewportCount must: be between `1` and
    /// sname:VkPhysicalDeviceLimits::pname:maxViewports, inclusive *
    /// pname:scissorCount must: be between `1` and
    /// sname:VkPhysicalDeviceLimits::pname:maxViewports, inclusive *
    /// pname:scissorCount and pname:viewportCount must: be identical ****
    /// </para>
    /// </summary>
    public struct PipelineViewportStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineViewportStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pViewports is a pointer to an array of slink:VkViewport
        /// structures, defining the viewport transforms. If the viewport state
        /// is dynamic, this member is ignored.
        /// </summary>
        public Viewport[] Viewports
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pScissors is a pointer to an array of sname:VkRect2D
        /// structures which define the rectangular bounds of the scissor for
        /// the corresponding viewport. If the scissor state is dynamic, this
        /// member is ignored.
        /// </summary>
        public Rect2D[] Scissors
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * Any given element of pname:pImageIndices must: be
    /// the index of a presentable image acquired from the swapchain specified
    /// by the corresponding element of the pname:pSwapchains array * Any given
    /// element of sname:VkSemaphore in pname:pWaitSemaphores must: refer to a
    /// prior signal of that sname:VkSemaphore that will not be consumed by any
    /// other wait on that semaphore ****
    /// </para>
    /// </summary>
    public struct PresentInfo
    {
        /// <summary>
        /// pname:pWaitSemaphores, if not code:VK_NULL_HANDLE, is an array of
        /// sname:VkSemaphore objects with pname:waitSemaphoreCount entries,
        /// and specifies the semaphores to wait for before issuing the present
        /// request.
        /// </summary>
        public Semaphore[] WaitSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSwapchains is an array of sname:VkSwapchainKHR objects with
        /// pname:swapchainCount entries. A given swapchain must: not appear in
        /// this list more than once.
        /// </summary>
        public Swapchain[] Swapchains
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pImageIndices is an array of indices into the array of each
        /// swapchain's presentable images, with pname:swapchainCount entries.
        /// Each entry in this array identifies the image to present on the
        /// corresponding entry in the pname:pSwapchains array.
        /// </summary>
        public uint[] ImageIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pResults is an array of ename:VkResult typed elements with
        /// pname:swapchainCount entries. Applications that do not need
        /// per-swapchain results can: use `NULL` for pname:pResults. If
        /// non-`NULL`, each entry in pname:pResults will be set to the
        /// ename:VkResult for presenting the swapchain corresponding to the
        /// same index in pname:pSwapchains.
        /// </summary>
        public Result[] Results
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.PresentInfo* MarshalTo()
        {
            return (Interop.PresentInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying parameters of a newly created query pool.
    /// </summary>
    public struct QueryPoolCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public QueryPoolCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:queryType is the type of queries managed by the pool, and
        /// must: be one of the values + --
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
    /// pname:renderArea is the render area that is affected by the render pass
    /// instance. The effects of attachment load, store and resolve operations
    /// are restricted to the pixels whose x and y coordinates fall within the
    /// render area on all attachments. The render area extends to all layers
    /// of pname:framebuffer. The application must: ensure (using scissor if
    /// necessary) that all rendering is contained within the render area,
    /// otherwise the pixels outside of the render area become undefined and
    /// shader side effects may: occur for fragments outside the render area.
    /// The render area must: be contained within the framebuffer dimensions.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== There may: be a performance cost for using a render
    /// area smaller than the framebuffer, unless it matches the render area
    /// granularity for the render pass. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:clearValueCount must: be greater than the
    /// largest attachment index in pname:renderPass that specifies a
    /// pname:loadOp (or pname:stencilLoadOp, if the attachment has a
    /// depth/stencil format) of ename:VK_ATTACHMENT_LOAD_OP_CLEAR * If
    /// pname:clearValueCount is not `0`, pname:pClearValues must: be a pointer
    /// to an array of pname:clearValueCount valid sname:VkClearValue unions *
    /// pname:renderPass must: be
    /// &lt;&lt;renderpass-compatibility,compatible&gt;&gt; with the
    /// pname:renderPass member of the sname:VkFramebufferCreateInfo structure
    /// specified when creating pname:framebuffer. ****
    /// </para>
    /// </summary>
    public struct RenderPassBeginInfo
    {
        /// <summary>
        /// pname:renderPass is the render pass to begin an instance of.
        /// </summary>
        public RenderPass RenderPass
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:framebuffer is the framebuffer containing the attachments
        /// that are used with the render pass.
        /// </summary>
        public Framebuffer Framebuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:renderArea is the render area that is affected by the render
        /// pass instance, and is described in more detail below.
        /// </summary>
        public Rect2D RenderArea
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pClearValues is an array of slink:VkClearValue structures
        /// that contains clear values for each attachment, if the attachment
        /// uses a pname:loadOp value of ename:VK_ATTACHMENT_LOAD_OP_CLEAR or
        /// if the attachment has a depth/stencil format and uses a
        /// pname:stencilLoadOp value of ename:VK_ATTACHMENT_LOAD_OP_CLEAR. The
        /// array is indexed by attachment number. Only elements corresponding
        /// to cleared attachments are used. Other elements of
        /// pname:pClearValues are ignored.
        /// </summary>
        public ClearValue[] ClearValues
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * If any two subpasses operate on attachments with
    /// overlapping ranges of the same sname:VkDeviceMemory object, and at
    /// least one subpass writes to that area of sname:VkDeviceMemory, a
    /// subpass dependency must: be included (either directly or via some
    /// intermediate subpasses) between them * If the pname:attachment member
    /// of any element of pname:pInputAttachments, pname:pColorAttachments,
    /// pname:pResolveAttachments or pname:pDepthStencilAttachment, or the
    /// attachment indexed by any element of pname:pPreserveAttachments in any
    /// given element of pname:pSubpasses is bound to a range of a
    /// sname:VkDeviceMemory object that overlaps with any other attachment in
    /// any subpass (including the same subpass), the
    /// sname:VkAttachmentDescription structures describing them must: include
    /// ename:VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT in pname:flags * If the
    /// pname:attachment member of any element of pname:pInputAttachments,
    /// pname:pColorAttachments, pname:pResolveAttachments or
    /// pname:pDepthStencilAttachment, or any element of
    /// pname:pPreserveAttachments in any given element of pname:pSubpasses is
    /// not ename:VK_ATTACHMENT_UNUSED, it must: be less than
    /// pname:attachmentCount * The value of any element of the
    /// pname:pPreserveAttachments member in any given element of
    /// pname:pSubpasses must: not be ename:VK_ATTACHMENT_UNUSED ****
    /// </para>
    /// </summary>
    public struct RenderPassCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public RenderPassCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pAttachments points to an array of pname:attachmentCount
        /// number of slink:VkAttachmentDescription structures describing
        /// properties of the attachments, or `NULL` if pname:attachmentCount
        /// is zero.
        /// </summary>
        public AttachmentDescription[] Attachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSubpasses points to an array of pname:subpassCount number of
        /// slink:VkSubpassDescription structures describing properties of the
        /// subpasses.
        /// </summary>
        public SubpassDescription[] Subpasses
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pDependencies points to an array of pname:dependencyCount
        /// number of slink:VkSubpassDependency structures describing
        /// dependencies between pairs of subpasses, or `NULL` if
        /// pname:dependencyCount is zero.
        /// </summary>
        public SubpassDependency[] Dependencies
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.RenderPassCreateInfo* MarshalTo()
        {
            return (Interop.RenderPassCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying parameters of a newly created sampler.
    /// </summary>
    public struct SamplerCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public SamplerCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:magFilter is the magnification filter to apply to lookups,
        /// and is of type: + --
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
        
        internal unsafe Interop.SamplerCreateInfo* MarshalTo()
        {
            return (Interop.SamplerCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying parameters of a newly created semaphore.
    /// </summary>
    public struct SemaphoreCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public SemaphoreCreateFlags Flags
        {
            get;
            set;
        }
        
        internal unsafe Interop.SemaphoreCreateInfo Pack()
        {
            Interop.SemaphoreCreateInfo result = default(Interop.SemaphoreCreateInfo);
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
    /// <para>
    /// .Valid Usage **** * pname:codeSize must: be greater than 0 *
    /// pname:codeSize must: be a multiple of 4. If the +VK_NV_glsl_shader
    /// extension+ is enabled and pname:pCode references GLSL code
    /// pname:codeSize can be a multiple of 1 * pname:pCode must: point to
    /// valid SPIR-V code, formatted and packed as described by the
    /// &lt;&lt;spirv-spec,Khronos SPIR-V Specification&gt;&gt;. If the
    /// +VK_NV_glsl_shader+ extension is enabled pname:pCode can instead
    /// reference valid GLSL code and must: be written to the
    /// +GL_KHR_vulkan_glsl+ extension specification * pname:pCode must: adhere
    /// to the validation rules described by the
    /// &lt;&lt;spirvenv-module-validation, Validation Rules within a
    /// Module&gt;&gt; section of the &lt;&lt;spirvenv-capabilities,SPIR-V
    /// Environment&gt;&gt; appendix. If the +VK_NV_glsl_shader+ extension is
    /// enabled pname:pCode can be valid GLSL code with respect to the
    /// +GL_KHR_vulkan_glsl+ GLSL extension specification * pname:pCode must:
    /// declare the code:Shader capability for SPIR-V code * pname:pCode must:
    /// not declare any capability that is not supported by the API, as
    /// described by the &lt;&lt;spirvenv-module-validation,
    /// Capabilities&gt;&gt; section of the
    /// &lt;&lt;spirvenv-capabilities,SPIR-V Environment&gt;&gt; appendix * If
    /// pname:pCode declares any of the capabilities that are listed as not
    /// required by the implementation, the relevant feature must: be enabled,
    /// as listed in the &lt;&lt;spirvenv-capabilities-table,SPIR-V
    /// Environment&gt;&gt; appendix ****
    /// </para>
    /// </summary>
    public struct ShaderModuleCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public ShaderModuleCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:codeSize is the size, in bytes, of the code pointed to by
        /// pname:pCode.
        /// </summary>
        public Size CodeSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pCode points to code that is used to create the shader
        /// module. The type and format of the code is determined from the
        /// content of the memory addressed by pname:pCode.
        /// </summary>
        public uint[] Code
        {
            get;
            set;
        }
        
        internal unsafe Interop.ShaderModuleCreateInfo Pack()
        {
            Interop.ShaderModuleCreateInfo result = default(Interop.ShaderModuleCreateInfo);
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
    /// Structure specifying a sparse buffer memory bind operation.
    /// </summary>
    public struct SparseBufferMemoryBindInfo
    {
        /// <summary>
        /// pname:buffer is the sname:VkBuffer object to be bound.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pBinds is a pointer to array of sname:VkSparseMemoryBind
        /// structures.
        /// </summary>
        public SparseMemoryBind[] Binds
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-sparseResidencyAliased,sparse aliased
    /// residency&gt;&gt; feature is not enabled, and if any other resources
    /// are bound to ranges of pname:memory, the range of pname:memory being
    /// bound must: not overlap with those bound ranges * pname:memory and
    /// pname:memoryOffset must: match the memory requirements of the calling
    /// command's pname:image, as described in section
    /// &lt;&lt;resources-association&gt;&gt; * pname:subresource must: be a
    /// valid image subresource for pname:image (see
    /// &lt;&lt;resources-image-views&gt;&gt;) * pname:offset.x must: be a
    /// multiple of the sparse image block width
    /// (sname:VkSparseImageFormatProperties::pname:imageGranularity.width) of
    /// the image * pname:extent.width must: either be a multiple of the sparse
    /// image block width of the image, or else pname:extent.width +
    /// pname:offset.x must: equal the width of the image subresource *
    /// pname:offset.y must: be a multiple of the sparse image block height
    /// (sname:VkSparseImageFormatProperties::pname:imageGranularity.height) of
    /// the image * pname:extent.height must: either be a multiple of the
    /// sparse image block height of the image, or else pname:extent.height +
    /// pname:offset.y must: equal the height of the image subresource *
    /// pname:offset.z must: be a multiple of the sparse image block depth
    /// (sname:VkSparseImageFormatProperties::pname:imageGranularity.depth) of
    /// the image * pname:extent.depth must: either be a multiple of the sparse
    /// image block depth of the image, or else pname:extent.depth +
    /// pname:offset.z must: equal the depth of the image subresource ****
    /// </para>
    /// </summary>
    public struct SparseImageMemoryBind
    {
        /// <summary>
        /// pname:subresource is the aspectMask and region of interest in the
        /// image.
        /// </summary>
        public ImageSubresource Subresource
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:offset are the coordinates of the first texel within the
        /// image subresource to bind.
        /// </summary>
        public Offset3D Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:extent is the size in texels of the region within the image
        /// subresource to bind. The extent must: be a multiple of the sparse
        /// image block dimensions, except when binding sparse image blocks
        /// along the edge of an image subresource it can: instead be such that
        /// any coordinate of [eq]#pname:offset + pname:extent# equals the
        /// corresponding dimensions of the image subresource.
        /// </summary>
        public Extent3D Extent
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memory is the sname:VkDeviceMemory object that the sparse
        /// image blocks of the image are bound to. If pname:memory is
        /// dlink:VK_NULL_HANDLE, the sparse image blocks are unbound.
        /// </summary>
        public DeviceMemory Memory
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memoryOffset is an offset into sname:VkDeviceMemory object.
        /// If pname:memory is dlink:VK_NULL_HANDLE, this value is ignored.
        /// </summary>
        public ulong MemoryOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:flags are sparse memory binding flags.
        /// </summary>
        public SparseMemoryBindFlags Flags
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.SparseImageMemoryBind* MarshalTo()
        {
            return (Interop.SparseImageMemoryBind*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying sparse image memory bind info.
    /// </summary>
    public struct SparseImageMemoryBindInfo
    {
        /// <summary>
        /// pname:image is the sname:VkImage object to be bound
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pBinds is a pointer to array of sname:VkSparseImageMemoryBind
        /// structures
        /// </summary>
        public SparseImageMemoryBind[] Binds
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * For any given element of pname:pBinds, if the
    /// pname:flags member of that element contains
    /// ename:VK_SPARSE_MEMORY_BIND_METADATA_BIT, the binding range defined
    /// must: be within the mip tail region of the metadata aspect of
    /// pname:image ****
    /// </para>
    /// </summary>
    public struct SparseImageOpaqueMemoryBindInfo
    {
        /// <summary>
        /// pname:image is the sname:VkImage object to be bound.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pBinds is a pointer to array of sname:VkSparseMemoryBind
        /// structures.
        /// </summary>
        public SparseMemoryBind[] Binds
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.SparseImageOpaqueMemoryBindInfo* MarshalTo()
        {
            return (Interop.SparseImageOpaqueMemoryBindInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying a sparse memory bind operation.
    /// </summary>
    public struct SparseMemoryBind
    {
        /// <summary>
        /// pname:resourceOffset is the offset into the resource.
        /// </summary>
        public ulong ResourceOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:size is the size of the memory region to be bound.
        /// </summary>
        public ulong Size
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memory is the sname:VkDeviceMemory object that the range of
        /// the resource is bound to. If pname:memory is dlink:VK_NULL_HANDLE,
        /// the range is unbound.
        /// </summary>
        public DeviceMemory Memory
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:memoryOffset is the offset into the sname:VkDeviceMemory
        /// object to bind the resource range to. If pname:memory is
        /// dlink:VK_NULL_HANDLE, this value is ignored.
        /// </summary>
        public ulong MemoryOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:flags is a bitmask specifying usage of the binding operation.
        /// Bits which can: be set include: + --
        /// </summary>
        public SparseMemoryBindFlags Flags
        {
            get;
            set;
        }
        
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
    /// pname:pMapEntries points to a structure of type
    /// slink:VkSpecializationMapEntry.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The pname:offset member of any given element of
    /// pname:pMapEntries must: be less than pname:dataSize * For any given
    /// element of pname:pMapEntries, pname:size must: be less than or equal to
    /// pname:dataSize minus pname:offset * If pname:mapEntryCount is not `0`,
    /// pname:pMapEntries must: be a pointer to an array of pname:mapEntryCount
    /// valid sname:VkSpecializationMapEntry structures ****
    /// </para>
    /// </summary>
    public struct SpecializationInfo
    {
        /// <summary>
        /// pname:pMapEntries is a pointer to an array of
        /// sname:VkSpecializationMapEntry which maps constant IDs to offsets
        /// in pname:pData.
        /// </summary>
        public SpecializationMapEntry[] MapEntries
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pData contains the actual constant values to specialize with.
        /// </summary>
        public byte[] Data
        {
            get;
            set;
        }
        
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
    /// .Valid Usage **** * Any given element of pname:pSignalSemaphores must:
    /// currently be unsignaled * Any given element of pname:pCommandBuffers
    /// must: either have been recorded with the
    /// ename:VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT, or not currently be
    /// executing on the device * Any given element of pname:pCommandBuffers
    /// must: be in the executable state * If any given element of
    /// pname:pCommandBuffers contains commands that execute secondary command
    /// buffers, those secondary command buffers must: have been recorded with
    /// the ename:VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT, or not
    /// currently be executing on the device * If any given element of
    /// pname:pCommandBuffers was recorded with
    /// ename:VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT, it must: not have
    /// been previously submitted without re-recording that command buffer * If
    /// any given element of pname:pCommandBuffers contains commands that
    /// execute secondary command buffers recorded with
    /// ename:VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT, each such secondary
    /// command buffer must: not have been previously submitted without
    /// re-recording that command buffer * Any given element of
    /// pname:pCommandBuffers must: not contain commands that execute a
    /// secondary command buffer, if that secondary command buffer has been
    /// recorded in another primary command buffer after it was recorded into
    /// this sname:VkCommandBuffer * Any given element of pname:pCommandBuffers
    /// must: have been allocated from a sname:VkCommandPool that was created
    /// for the same queue family that the calling command's pname:queue
    /// belongs to * Any given element of pname:pCommandBuffers must: not have
    /// been allocated with ename:VK_COMMAND_BUFFER_LEVEL_SECONDARY * Any given
    /// element of sname:VkSemaphore in pname:pWaitSemaphores must: refer to a
    /// prior signal of that sname:VkSemaphore that will not be consumed by any
    /// other wait on that semaphore * If the
    /// &lt;&lt;features-features-geometryShader,geometry shaders&gt;&gt;
    /// feature is not enabled, any given element of pname:pWaitDstStageMask
    /// must: not contain ename:VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT * If the
    /// &lt;&lt;features-features-tessellationShader,tessellation shaders&gt;&gt;
    /// feature is not enabled, any given element of pname:pWaitDstStageMask
    /// must: not contain
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT or
    /// ename:VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT ****
    /// </para>
    /// </summary>
    public struct SubmitInfo
    {
        /// <summary>
        /// pname:pWaitSemaphores is a pointer to an array of semaphores upon
        /// which to wait before the command buffers for this batch begin
        /// execution. If semaphores to wait on are provided, they define a
        /// &lt;&lt;synchronization-semaphores-waiting, semaphore wait
        /// operation&gt;&gt;.
        /// </summary>
        public Semaphore[] WaitSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pWaitDstStageMask is a pointer to an array of pipeline stages
        /// at which each corresponding semaphore wait will occur.
        /// </summary>
        public PipelineStageFlags[] WaitDestinationStageMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pCommandBuffers is a pointer to an array of command buffers
        /// to execute in the batch. The command buffers submitted in a batch
        /// begin execution in the order they appear in pname:pCommandBuffers,
        /// but may: complete out of order.
        /// </summary>
        public CommandBuffer[] CommandBuffers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSignalSemaphores is a pointer to an array of semaphores
        /// which will be signaled when the command buffers for this batch have
        /// completed execution. If semaphores to be signaled are provided,
        /// they define a &lt;&lt;synchronization-semaphores-signaling,
        /// semaphore signal operation&gt;&gt;.
        /// </summary>
        public Semaphore[] SignalSemaphores
        {
            get;
            set;
        }
        
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
    /// The contents of an attachment within the render area become undefined
    /// at the start of a subpass S if all of the following conditions are
    /// true:
    /// </para>
    /// <para>
    /// * The attachment is used as a color, depth/stencil, or resolve
    /// attachment in any subpass in the render pass. * There is a subpass S1
    /// that uses or preserves the attachment, and a subpass dependency from S1
    /// to S. * The attachment is not used or preserved in subpass S.
    /// </para>
    /// <para>
    /// Once the contents of an attachment become undefined in subpass S, they
    /// remain undefined for subpasses in subpass dependency chains starting
    /// with subpass S until they are written again. However, they remain valid
    /// for subpasses in other subpass dependency chains starting with subpass
    /// S1 if those subpasses use or preserve the attachment.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:pipelineBindPoint must: be
    /// ename:VK_PIPELINE_BIND_POINT_GRAPHICS * pname:colorAttachmentCount
    /// must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxColorAttachments * If the first
    /// use of an attachment in this render pass is as an input attachment, and
    /// the attachment is not also used as a color or depth/stencil attachment
    /// in the same subpass, then pname:loadOp must: not be
    /// ename:VK_ATTACHMENT_LOAD_OP_CLEAR * If pname:pResolveAttachments is not
    /// `NULL`, for each resolve attachment that does not have the value
    /// ename:VK_ATTACHMENT_UNUSED, the corresponding color attachment must:
    /// not have the value ename:VK_ATTACHMENT_UNUSED * If
    /// pname:pResolveAttachments is not `NULL`, the sample count of each
    /// element of pname:pColorAttachments must: be anything other than
    /// ename:VK_SAMPLE_COUNT_1_BIT * Any given element of
    /// pname:pResolveAttachments must: have a sample count of
    /// ename:VK_SAMPLE_COUNT_1_BIT * Any given element of
    /// pname:pResolveAttachments must: have the same elink:VkFormat as its
    /// corresponding color attachment * All attachments in
    /// pname:pColorAttachments and pname:pDepthStencilAttachment that are not
    /// ename:VK_ATTACHMENT_UNUSED must: have the same sample count * If any
    /// input attachments are ename:VK_ATTACHMENT_UNUSED, then any pipelines
    /// bound during the subpass must: not access those input attachments from
    /// the fragment shader * The pname:attachment member of any element of
    /// pname:pPreserveAttachments must: not be ename:VK_ATTACHMENT_UNUSED *
    /// Any given element of pname:pPreserveAttachments must: not also be an
    /// element of any other member of the subpass description * If any
    /// attachment is used as both an input attachment and a color or
    /// depth/stencil attachment, then each use must: use the same pname:layout
    /// ****
    /// </para>
    /// </summary>
    public struct SubpassDescription
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public SubpassDescriptionFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pipelineBindPoint is a elink:VkPipelineBindPoint value
        /// specifying whether this is a compute or graphics subpass.
        /// Currently, only graphics subpasses are supported.
        /// </summary>
        public PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pInputAttachments is an array of slink:VkAttachmentReference
        /// structures (defined below) that lists which of the render pass's
        /// attachments can: be read in the shader during the subpass, and what
        /// layout each attachment will be in during the subpass. Each element
        /// of the array corresponds to an input attachment unit number in the
        /// shader, i.e. if the shader declares an input variable
        /// `layout(input_attachment_index=X, set=Y, binding=Z)` then it uses
        /// the attachment provided in pname:pInputAttachments[X]. Input
        /// attachments must: also be bound to the pipeline with a descriptor
        /// set, with the input attachment descriptor written in the location
        /// (set=Y, binding=Z).
        /// </summary>
        public AttachmentReference[] InputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pColorAttachments is an array of pname:colorAttachmentCount
        /// slink:VkAttachmentReference structures that lists which of the
        /// render pass's attachments will be used as color attachments in the
        /// subpass, and what layout each attachment will be in during the
        /// subpass. Each element of the array corresponds to a fragment shader
        /// output location, i.e. if the shader declared an output variable
        /// `layout(location=X)` then it uses the attachment provided in
        /// pname:pColorAttachments[X].
        /// </summary>
        public AttachmentReference[] ColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pResolveAttachments is `NULL` or an array of
        /// pname:colorAttachmentCount slink:VkAttachmentReference structures
        /// that lists which of the render pass's attachments are resolved to
        /// at the end of the subpass, and what layout each attachment will be
        /// in during the resolve. If pname:pResolveAttachments is not `NULL`,
        /// each of its elements corresponds to a color attachment (the element
        /// in pname:pColorAttachments at the same index). At the end of each
        /// subpass, the subpass's color attachments are resolved to
        /// corresponding resolve attachments, unless the resolve attachment
        /// index is ename:VK_ATTACHMENT_UNUSED or pname:pResolveAttachments is
        /// `NULL`. If the first use of an attachment in a render pass is as a
        /// resolve attachment, then the pname:loadOp is effectively ignored as
        /// the resolve is guaranteed to overwrite all pixels in the render
        /// area.
        /// </summary>
        public AttachmentReference[] ResolveAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pDepthStencilAttachment is a pointer to a
        /// slink:VkAttachmentReference specifying which attachment will be
        /// used for depth/stencil data and the layout it will be in during the
        /// subpass. Setting the attachment index to ename:VK_ATTACHMENT_UNUSED
        /// or leaving this pointer as `NULL` indicates that no depth/stencil
        /// attachment will be used in the subpass.
        /// </summary>
        public AttachmentReference DepthStencilAttachment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pPreserveAttachments is an array of
        /// pname:preserveAttachmentCount render pass attachment indices
        /// describing the attachments that are not used by a subpass, but
        /// whose contents must: be preserved throughout the subpass.
        /// </summary>
        public uint[] PreserveAttachments
        {
            get;
            set;
        }
        
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
    /// [NOTE] .Note ==== Applications should: set this value to ename:VK_TRUE
    /// if they do not expect to read back the content of presentable images
    /// before presenting them or after reacquiring them and if their pixel
    /// shaders do not have any side effects that require them to run for all
    /// pixels in the presentable image. ====
    /// </para>
    /// <para>
    /// * pname:oldSwapchain, if not code:VK_NULL_HANDLE, specifies the
    /// swapchain that will be replaced by the new swapchain being created. The
    /// new swapchain will be a descendant of pname:oldSwapchain. Further, any
    /// descendants of the new swapchain will also be descendants of
    /// pname:oldSwapchain. Upon calling fname:vkCreateSwapchainKHR with a
    /// pname:oldSwapchain that is not code:VK_NULL_HANDLE, any images not
    /// acquired by the application may: be freed by the implementation, which
    /// may: occur even if creation of the new swapchain fails. The application
    /// must: destroy the old swapchain to free all memory associated with the
    /// old swapchain. The application must: wait for the completion of any
    /// outstanding rendering to images it currently has acquired at the time
    /// the swapchain is destroyed. The application can: continue to present
    /// any images it acquired and has not yet presented using the old
    /// swapchain, as long as it has not entered a state that causes it to
    /// return ename:VK_ERROR_OUT_OF_DATE_KHR. However, the application cannot:
    /// acquire any more images from the old swapchain regardless of whether or
    /// not creation of the new swapchain succeeds.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:surface must: be a surface that is supported
    /// by the device as determined using
    /// fname:vkGetPhysicalDeviceSurfaceSupportKHR * pname:minImageCount must:
    /// be greater than or equal to the value returned in the
    /// pname:minImageCount member of the sname:VkSurfaceCapabilitiesKHR
    /// structure returned by fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR
    /// for the surface * pname:minImageCount must: be less than or equal to
    /// the value returned in the pname:maxImageCount member of the
    /// sname:VkSurfaceCapabilitiesKHR structure returned by
    /// fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR for the surface if the
    /// returned pname:maxImageCount is not zero * pname:imageFormat and
    /// pname:imageColorSpace must: match the pname:format and pname:colorSpace
    /// members, respectively, of one of the sname:VkSurfaceFormatKHR
    /// structures returned by fname:vkGetPhysicalDeviceSurfaceFormatsKHR for
    /// the surface * pname:imageExtent must: be between pname:minImageExtent
    /// and pname:maxImageExtent, inclusive, where pname:minImageExtent and
    /// pname:maxImageExtent are members of the sname:VkSurfaceCapabilitiesKHR
    /// structure returned by fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR
    /// for the surface * pname:imageArrayLayers must: be greater than `0` and
    /// less than or equal to the pname:maxImageArrayLayers member of the
    /// sname:VkSurfaceCapabilitiesKHR structure returned by
    /// fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR for the surface *
    /// pname:imageUsage must: be a subset of the supported usage flags present
    /// in the pname:supportedUsageFlags member of the
    /// sname:VkSurfaceCapabilitiesKHR structure returned by
    /// fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR for the surface * If
    /// pname:imageSharingMode is ename:VK_SHARING_MODE_CONCURRENT,
    /// pname:pQueueFamilyIndices must: be a pointer to an array of
    /// pname:queueFamilyIndexCount basetype:uint32_t values * If
    /// pname:imageSharingMode is ename:VK_SHARING_MODE_CONCURRENT,
    /// pname:queueFamilyIndexCount must: be greater than `1` *
    /// pname:preTransform must: be one of the bits present in the
    /// pname:supportedTransforms member of the sname:VkSurfaceCapabilitiesKHR
    /// structure returned by fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR
    /// for the surface * pname:compositeAlpha must: be one of the bits present
    /// in the pname:supportedCompositeAlpha member of the
    /// sname:VkSurfaceCapabilitiesKHR structure returned by
    /// fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR for the surface *
    /// pname:presentMode must: be one of the ename:VkPresentModeKHR values
    /// returned by fname:vkGetPhysicalDeviceSurfacePresentModesKHR for the
    /// surface ****
    /// </para>
    /// </summary>
    public struct SwapchainCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use, and must: be zero.
        /// </summary>
        public SwapchainCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:surface is the surface that the swapchain will present images
        /// to.
        /// </summary>
        public Surface Surface
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minImageCount is the minimum number of presentable images
        /// that the application needs. The platform will either create the
        /// swapchain with at least that many images, or will fail to create
        /// the swapchain.
        /// </summary>
        public uint MinImageCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageFormat is a slink:VkFormat that is valid for swapchains
        /// on the specified surface.
        /// </summary>
        public Format ImageFormat
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageColorSpace is a slink:VkColorSpaceKHR that is valid for
        /// swapchains on the specified surface.
        /// </summary>
        public ColorSpace ImageColorSpace
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageExtent is the size (in pixels) of the swapchain.
        /// Behavior is platform-dependent when the image extent does not match
        /// the surface's pname:currentExtent as returned by
        /// fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR.
        /// </summary>
        public Extent2D ImageExtent
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageArrayLayers is the number of views in a multiview/stereo
        /// surface. For non-stereoscopic-3D applications, this value is 1.
        /// </summary>
        public uint ImageArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageUsage is a bitmask of elink:VkImageUsageFlagBits,
        /// indicating how the application will use the swapchain's presentable
        /// images.
        /// </summary>
        public ImageUsageFlags ImageUsage
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageSharingMode is the sharing mode used for the images of
        /// the swapchain.
        /// </summary>
        public SharingMode ImageSharingMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pQueueFamilyIndices is an array of queue family indices
        /// having access to the images of the swapchain in case
        /// pname:imageSharingMode is ename:VK_SHARING_MODE_CONCURRENT.
        /// </summary>
        public uint[] QueueFamilyIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:preTransform is a bitmask of
        /// elink:VkSurfaceTransformFlagBitsKHR, describing the transform,
        /// relative to the presentation engine's natural orientation, applied
        /// to the image content prior to presentation. If it does not match
        /// the pname:currentTransform value returned by
        /// fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR, the presentation
        /// engine will transform the image content as part of the presentation
        /// operation.
        /// </summary>
        public SurfaceTransformFlags PreTransform
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:compositeAlpha is a bitmask of
        /// elink:VkCompositeAlphaFlagBitsKHR, indicating the alpha compositing
        /// mode to use when this surface is composited together with other
        /// surfaces on certain window systems.
        /// </summary>
        public CompositeAlphaFlags CompositeAlpha
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:presentMode is the presentation mode the swapchain will use.
        /// A swapchain's present mode determines how incoming present requests
        /// will be processed and queued internally.
        /// </summary>
        public PresentMode PresentMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:clipped indicates whether the Vulkan implementation is
        /// allowed to discard rendering operations that affect regions of the
        /// surface which are not visible.
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
        
        internal unsafe Interop.SwapchainCreateInfo* MarshalTo()
        {
            return (Interop.SwapchainCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Specify validation checks to disable for a Vulkan instance.
    /// </summary>
    public struct ValidationFlags
    {
        /// <summary>
        /// pname:pDisabledValidationChecks is a pointer to an array of values
        /// specifying the validation checks to be disabled. Checks which may:
        /// be specified include: + --
        /// </summary>
        public ValidationCheck[] DisabledValidationChecks
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.ValidationFlags* MarshalTo()
        {
            return (Interop.ValidationFlags*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying parameters of a newly created Wayland surface
    /// object.
    /// </summary>
    public struct WaylandSurfaceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public WaylandSurfaceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:display and pname:surface are pointers to the Wayland
        /// code:wl_display and code:wl_surface to associate the surface with.
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
        
        internal unsafe Interop.WaylandSurfaceCreateInfo Pack()
        {
            Interop.WaylandSurfaceCreateInfo result = default(Interop.WaylandSurfaceCreateInfo);
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
    /// When submitting work that operates on memory imported from a Direct3D
    /// 11 resource to a queue, the keyed mutex mechanism may: be used in
    /// addition to Vulkan semaphores to synchronize the work. Keyed mutexes
    /// are a property of a properly created shareable Direct3D 11 resource.
    /// They can: only be used if the imported resource was created with the
    /// etext:D3D11_RESOURCE_MISC_SHARED_KEYEDMUTEX flag.
    /// </para>
    /// <para>
    /// To acquire keyed mutexes before submitted work and/or release them
    /// after, add a slink:VkWin32KeyedMutexAcquireReleaseInfoNV structure to
    /// the pname:pNext chain of the slink:VkSubmitInfo structure.
    /// </para>
    /// <para>
    /// * pname:acquireCount is the number of entries in the
    /// pname:pAcquireSyncs, pname:pAcquireKeys, and
    /// pname:pAcquireTimeoutMilliseconds arrays. * pname:pAcquireSyncs is a
    /// pointer to an array of slink:VkDeviceMemory objects which were imported
    /// from Direct3D 11 resources. * pname:pAcquireKeys is a pointer to an
    /// array of mutex key values to wait for prior to beginning the submitted
    /// work. Entries refer to the keyed mutex associated with the
    /// corresponding entries in pname:pAcquireSyncs. *
    /// pname:pAcquireTimeoutMilliseconds is an array of timeout values, in
    /// millisecond units, for each acquire specified in pname:pAcquireKeys. *
    /// pname:releaseCount is the number of entries in the pname:pReleaseSyncs
    /// and pname:pReleaseKeys arrays. * pname:pReleaseSyncs is a pointer to an
    /// array of slink:VkDeviceMemory objects which were imported from Direct3D
    /// 11 resources. * pname:pReleaseKeys is a pointer to an array of mutex
    /// key values to set when the submitted work has completed. Entries refer
    /// to the keyed mutex associated with the corresponding entries in
    /// pname:pReleaseSyncs.
    /// </para>
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
        
        internal unsafe Interop.Win32KeyedMutexAcquireReleaseInfo* MarshalTo()
        {
            return (Interop.Win32KeyedMutexAcquireReleaseInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying parameters of a newly created Win32 surface
    /// object.
    /// </summary>
    public struct Win32SurfaceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public Win32SurfaceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:hinstance and pname:hwnd are the Win32 code:HINSTANCE and
        /// code:HWND for the window to associate the surface with.
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
        
        internal unsafe Interop.Win32SurfaceCreateInfo Pack()
        {
            Interop.Win32SurfaceCreateInfo result = default(Interop.Win32SurfaceCreateInfo);
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
    /// Structure specifying the parameters of a descriptor set write
    /// operation.
    /// </para>
    /// <para>
    /// Only one of pname:pImageInfo, pname:pBufferInfo, or
    /// pname:pTexelBufferView members is used according to the descriptor type
    /// specified in the pname:descriptorType member of the containing
    /// sname:VkWriteDescriptorSet structure, as specified below.
    /// </para>
    /// <para>
    /// [[descriptorsets-updates-consecutive, consecutive binding updates]] If
    /// the pname:dstBinding has fewer than pname:descriptorCount array
    /// elements remaining starting from pname:dstArrayElement, then the
    /// remainder will be used to update the subsequent binding -
    /// pname:dstBinding+1 starting at array element zero. This behavior
    /// applies recursively, with the update affecting consecutive bindings as
    /// needed to update all pname:descriptorCount descriptors. All consecutive
    /// bindings updated via a single sname:VkWriteDescriptorSet structure
    /// must: have identical pname:descriptorType and pname:stageFlags, and
    /// must: all either use immutable samplers or must: all not use immutable
    /// samplers.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:dstBinding must: be a valid binding point
    /// within pname:dstSet * pname:descriptorType must: match the type of
    /// pname:dstBinding within pname:dstSet * The sum of pname:dstArrayElement
    /// and pname:descriptorCount must: be less than or equal to the number of
    /// array elements in the descriptor set binding specified by
    /// pname:dstBinding, and all applicable consecutive bindings, as described
    /// by &lt;&lt;descriptorsets-updates-consecutive&gt;&gt; * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_SAMPLER,
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
    /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT, pname:pImageInfo must: be a
    /// pointer to an array of pname:descriptorCount valid
    /// sname:VkDescriptorImageInfo structures * If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER, pname:pTexelBufferView
    /// must: be a pointer to an array of pname:descriptorCount valid
    /// sname:VkBufferView handles * If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER, ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER,
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, pname:pBufferInfo
    /// must: be a pointer to an array of pname:descriptorCount valid
    /// sname:VkDescriptorBufferInfo structures * If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_SAMPLER or
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and pname:dstSet was
    /// not allocated with a layout that included immutable samplers for
    /// pname:dstBinding with pname:descriptorType, the pname:sampler member of
    /// any given element of pname:pImageInfo must: be a valid sname:VkSampler
    /// object * If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, or
    /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT, the pname:imageView and
    /// pname:imageLayout members of any given element of pname:pImageInfo
    /// must: be a valid sname:VkImageView and elink:VkImageLayout,
    /// respectively * If pname:descriptorType is
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, the pname:offset
    /// member of any given element of pname:pBufferInfo must: be a multiple of
    /// sname:VkPhysicalDeviceLimits::pname:minUniformBufferOffsetAlignment *
    /// If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, the pname:offset
    /// member of any given element of pname:pBufferInfo must: be a multiple of
    /// sname:VkPhysicalDeviceLimits::pname:minStorageBufferOffsetAlignment *
    /// If pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, the pname:buffer
    /// member of any given element of pname:pBufferInfo must: have been
    /// created with ename:VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT set * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, the pname:buffer
    /// member of any given element of pname:pBufferInfo must: have been
    /// created with ename:VK_BUFFER_USAGE_STORAGE_BUFFER_BIT set * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC, the pname:range member
    /// of any given element of pname:pBufferInfo, or the effective range if
    /// pname:range is ename:VK_WHOLE_SIZE, must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxUniformBufferRange * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER or
    /// ename:VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC, the pname:range member
    /// of any given element of pname:pBufferInfo, or the effective range if
    /// pname:range is ename:VK_WHOLE_SIZE, must: be less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxStorageBufferRange * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER,
    /// the sname:VkBuffer that any given element of pname:pTexelBufferView was
    /// created from must: have been created with
    /// ename:VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT set * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER,
    /// the sname:VkBuffer that any given element of pname:pTexelBufferView was
    /// created from must: have been created with
    /// ename:VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT set * If
    /// pname:descriptorType is ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE or
    /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT, the pname:imageView member
    /// of any given element of pname:pImageInfo must: have been created with
    /// the identity swizzle ****
    /// </para>
    /// </summary>
    public struct WriteDescriptorSet
    {
        /// <summary>
        /// pname:dstSet is the destination descriptor set to update.
        /// </summary>
        public DescriptorSet DestinationSet
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstBinding is the descriptor binding within that set.
        /// </summary>
        public uint DestinationBinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstArrayElement is the starting element in that array.
        /// </summary>
        public uint DestinationArrayElement
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:descriptorType is a elink:VkDescriptorType specifying the
        /// type of each descriptor in pname:pImageInfo, pname:pBufferInfo, or
        /// pname:pTexelBufferView, as described below. It must: be the same
        /// type as that specified in sname:VkDescriptorSetLayoutBinding for
        /// pname:dstSet at pname:dstBinding. The type of the descriptor also
        /// controls which array the descriptors are taken from.
        /// </summary>
        public DescriptorType DescriptorType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pImageInfo points to an array of slink:VkDescriptorImageInfo
        /// structures or is ignored, as described below.
        /// </summary>
        public DescriptorImageInfo[] ImageInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pBufferInfo points to an array of
        /// slink:VkDescriptorBufferInfo structures or is ignored, as described
        /// below.
        /// </summary>
        public DescriptorBufferInfo[] BufferInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pTexelBufferView points to an array of slink:VkBufferView
        /// handles as described in the &lt;&lt;resources-buffer-views,Buffer
        /// Views&gt;&gt; section or is ignored, as described below.
        /// </summary>
        public BufferView[] TexelBufferView
        {
            get;
            set;
        }
        
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
        
        internal unsafe Interop.WriteDescriptorSet* MarshalTo()
        {
            return (Interop.WriteDescriptorSet*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
    
    /// <summary>
    /// Structure specifying parameters of a newly created Xcb surface object.
    /// </summary>
    public struct XcbSurfaceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public XcbSurfaceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:connection is a pointer to an code:xcb_connection_t to the X
        /// server.
        /// </summary>
        public IntPtr Connection
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:window is the code:xcb_window_t for the X11 window to
        /// associate the surface with.
        /// </summary>
        public IntPtr Window
        {
            get;
            set;
        }
        
        internal unsafe Interop.XcbSurfaceCreateInfo Pack()
        {
            Interop.XcbSurfaceCreateInfo result = default(Interop.XcbSurfaceCreateInfo);
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
    /// Structure specifying parameters of a newly created Xlib surface object.
    /// </summary>
    public struct XlibSurfaceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public XlibSurfaceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dpy is a pointer to an Xlib code:Display connection to the X
        /// server.
        /// </summary>
        public IntPtr Dpy
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:window is an Xlib code:Window to associate the surface with.
        /// </summary>
        public IntPtr Window
        {
            get;
            set;
        }
        
        internal unsafe Interop.XlibSurfaceCreateInfo Pack()
        {
            Interop.XlibSurfaceCreateInfo result = default(Interop.XlibSurfaceCreateInfo);
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
