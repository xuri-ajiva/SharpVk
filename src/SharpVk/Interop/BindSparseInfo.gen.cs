// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
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
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct BindSparseInfo
    {
        /// <summary>
        /// pname:sType is the type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// pname:pNext is `NULL` or a pointer to an extension-specific
        /// structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// pname:waitSemaphoreCount is the number of semaphores upon which to
        /// wait before executing the sparse binding operations for the batch.
        /// </summary>
        public uint WaitSemaphoreCount; 
        
        /// <summary>
        /// pname:pWaitSemaphores is a pointer to an array of semaphores upon
        /// which to wait on before the sparse binding operations for this
        /// batch begin execution. If semaphores to wait on are provided, they
        /// define a &lt;&lt;synchronization-semaphores-waiting, semaphore wait
        /// operation&gt;&gt;.
        /// </summary>
        public SharpVk.Interop.Semaphore* WaitSemaphores; 
        
        /// <summary>
        /// pname:bufferBindCount is the number of sparse buffer bindings to
        /// perform in the batch.
        /// </summary>
        public uint BufferBindCount; 
        
        /// <summary>
        /// pname:pBufferBinds is a pointer to an array of
        /// slink:VkSparseBufferMemoryBindInfo structures.
        /// </summary>
        public SharpVk.Interop.SparseBufferMemoryBindInfo* BufferBinds; 
        
        /// <summary>
        /// pname:imageOpaqueBindCount is the number of opaque sparse image
        /// bindings to perform.
        /// </summary>
        public uint ImageOpaqueBindCount; 
        
        /// <summary>
        /// pname:pImageOpaqueBinds is a pointer to an array of
        /// slink:VkSparseImageOpaqueMemoryBindInfo structures, indicating
        /// opaque sparse image bindings to perform.
        /// </summary>
        public SharpVk.Interop.SparseImageOpaqueMemoryBindInfo* ImageOpaqueBinds; 
        
        /// <summary>
        /// pname:imageBindCount is the number of sparse image bindings to
        /// perform.
        /// </summary>
        public uint ImageBindCount; 
        
        /// <summary>
        /// pname:pImageBinds is a pointer to an array of
        /// slink:VkSparseImageMemoryBindInfo structures, indicating sparse
        /// image bindings to perform.
        /// </summary>
        public SharpVk.Interop.SparseImageMemoryBindInfo* ImageBinds; 
        
        /// <summary>
        /// pname:signalSemaphoreCount is the number of semaphores to be
        /// signaled once the sparse binding operations specified by the
        /// structure have completed execution.
        /// </summary>
        public uint SignalSemaphoreCount; 
        
        /// <summary>
        /// pname:pSignalSemaphores is a pointer to an array of semaphores
        /// which will be signaled when the sparse binding operations for this
        /// batch have completed execution. If semaphores to be signaled are
        /// provided, they define a
        /// &lt;&lt;synchronization-semaphores-signaling, semaphore signal
        /// operation&gt;&gt;.
        /// </summary>
        public SharpVk.Interop.Semaphore* SignalSemaphores; 
    }
}
