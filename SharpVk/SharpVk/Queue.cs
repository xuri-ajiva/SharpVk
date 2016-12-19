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
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Opaque handle to a queue object.
    /// </para>
    /// <para>
    /// Creating a logical device also creates the queues associated with that
    /// device. The queues to create are described by a set of
    /// slink:VkDeviceQueueCreateInfo structures that are passed to
    /// flink:vkCreateDevice in pname:pQueueCreateInfos.
    /// </para>
    /// </summary>
    public partial class Queue
    {
        internal readonly Interop.Queue handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly Device parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal Queue(Interop.Queue handle, Device parent, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Submits a sequence of semaphores or command buffers to a queue.
        /// </summary>
        public void Submit(ArrayProxy<SubmitInfo> submits, Fence fence)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    Interop.SubmitInfo* marshalledSubmits = null;
                    if (submits.Contents != ProxyContents.Null)
                    {
                        Interop.SubmitInfo* arrayPointer = stackalloc Interop.SubmitInfo[submits.Length];
                        if(submits.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = submits.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = submits.GetArrayValue();
                            for (int index = 0; index < submits.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledSubmits = arrayPointer;
                    }
                    else
                    {
                        marshalledSubmits = null;
                    }
                    Interop.Fence marshalledFence = fence?.Pack() ?? Interop.Fence.Null;
                    commandResult = Interop.Commands.vkQueueSubmit(this.handle, (uint)(submits.Length), marshalledSubmits, marshalledFence);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Wait for a queue to become idle.
        /// </summary>
        public void WaitIdle()
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    commandResult = Interop.Commands.vkQueueWaitIdle(this.handle);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Bind device memory to a sparse resource object.
        /// </summary>
        public void BindSparse(ArrayProxy<BindSparseInfo> bindInfo, Fence fence)
        {
            unsafe
            {
                try
                {
                    Result commandResult;
                    Interop.BindSparseInfo* marshalledBindInfo = null;
                    if (bindInfo.Contents != ProxyContents.Null)
                    {
                        Interop.BindSparseInfo* arrayPointer = stackalloc Interop.BindSparseInfo[bindInfo.Length];
                        if(bindInfo.Contents == ProxyContents.Single)
                        {
                            *arrayPointer = bindInfo.GetSingleValue().Pack();
                        }
                        else
                        {
                            var arrayValue  = bindInfo.GetArrayValue();
                            for (int index = 0; index < bindInfo.Length; index++)
                            {
                                arrayPointer[index] = arrayValue.Array[arrayValue.Offset + index].Pack();
                            }
                        }
                        marshalledBindInfo = arrayPointer;
                    }
                    else
                    {
                        marshalledBindInfo = null;
                    }
                    Interop.Fence marshalledFence = fence?.Pack() ?? Interop.Fence.Null;
                    commandResult = Interop.Commands.vkQueueBindSparse(this.handle, (uint)(bindInfo.Length), marshalledBindInfo, marshalledFence);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        /// <summary>
        /// Queue an image for presentation.
        /// </summary>
        public Result Present(PresentInfo presentInfo)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkQueuePresentKHR>("vkQueuePresentKHR", "device");
                    Result result = default(Result);
                    Interop.PresentInfo marshalledPresentInfo;
                    marshalledPresentInfo = presentInfo.Pack();
                    result = commandDelegate(this.handle, &marshalledPresentInfo);
                    if (SharpVkException.IsError(result))
                    {
                        throw SharpVkException.Create(result);
                    }
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        internal Interop.Queue Pack()
        {
            return this.handle;
        }
        
        /// <summary>
        /// The interop handle for this Queue.
        /// </summary>
        public Interop.Queue RawHandle => this.handle;
    }
}
