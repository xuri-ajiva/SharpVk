// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir & xuri 2021
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

namespace SharpVk
{
    /// <summary>
    /// Opaque handle to a queue object.
    /// </summary>
    public class Queue
    {
        internal readonly SharpVk.Interop.Queue Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly Device parent; 
        
        internal Queue(Device parent, SharpVk.Interop.Queue handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Queue RawHandle => Handle;
        
        /// <summary>
        /// Submits a sequence of semaphores or command buffers to a queue.
        /// </summary>
        /// <param name="submits">
        /// </param>
        /// <param name="fence">
        /// </param>
        public unsafe void Submit(ArrayProxy<SubmitInfo>? submits, Fence fence)
        {
            try
            {
                SharpVk.Interop.SubmitInfo* marshalledSubmits = default;
                if (submits.IsNull())
                {
                    marshalledSubmits = null;
                }
                else
                {
                    if (submits.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSubmits = (SharpVk.Interop.SubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SubmitInfo>());
                        submits.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.SubmitInfo*)(marshalledSubmits));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.SubmitInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SubmitInfo>(Interop.HeapUtil.GetLength(submits.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(submits.Value)); index++)
                        {
                            submits.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledSubmits = fieldPointer;
                    }
                }
                Interop.VkQueueSubmitDelegate commandDelegate = commandCache.Cache.vkQueueSubmit;
                Result methodResult = commandDelegate(Handle, (uint)(Interop.HeapUtil.GetLength(submits)), marshalledSubmits, fence?.Handle ?? default);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Wait for a queue to become idle.
        /// </summary>
        public unsafe void WaitIdle()
        {
            try
            {
                Interop.VkQueueWaitIdleDelegate commandDelegate = commandCache.Cache.vkQueueWaitIdle;
                Result methodResult = commandDelegate(Handle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Bind device memory to a sparse resource object.
        /// </summary>
        /// <param name="bindInfo">
        /// </param>
        /// <param name="fence">
        /// </param>
        public unsafe void BindSparse(ArrayProxy<BindSparseInfo>? bindInfo, Fence fence)
        {
            try
            {
                SharpVk.Interop.BindSparseInfo* marshalledBindInfo = default;
                if (bindInfo.IsNull())
                {
                    marshalledBindInfo = null;
                }
                else
                {
                    if (bindInfo.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfo = (SharpVk.Interop.BindSparseInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BindSparseInfo>());
                        bindInfo.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.BindSparseInfo*)(marshalledBindInfo));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.BindSparseInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BindSparseInfo>(Interop.HeapUtil.GetLength(bindInfo.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfo.Value)); index++)
                        {
                            bindInfo.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfo = fieldPointer;
                    }
                }
                Interop.VkQueueBindSparseDelegate commandDelegate = commandCache.Cache.vkQueueBindSparse;
                Result methodResult = commandDelegate(Handle, (uint)(Interop.HeapUtil.GetLength(bindInfo)), marshalledBindInfo, fence?.Handle ?? default);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
