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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Queue
    {
        internal readonly SharpVk.Interop.Queue handle; 
        
        internal Queue(SharpVk.Interop.Queue handle)
        {
            this.handle = handle;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Submit(SubmitInfo[] submits, Fence fence)
        {
            try
            {
                uint marshalledSubmitCount = default(uint);
                Interop.SubmitInfo* marshalledSubmits = default(Interop.SubmitInfo*);
                Interop.Fence marshalledFence = default(Interop.Fence);
                marshalledSubmitCount = (uint)(submits?.Length ?? 0);
                if (submits != null)
                {
                    var fieldPointer = (Interop.SubmitInfo*)(Interop.HeapUtil.AllocateAndClear<Interop.SubmitInfo>(submits.Length).ToPointer());
                    for(int index = 0; index < submits.Length; index++)
                    {
                        submits[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledSubmits = fieldPointer;
                }
                else
                {
                    marshalledSubmits = null;
                }
                marshalledFence = fence.handle;
                Interop.Commands.vkQueueSubmit(this.handle, marshalledSubmitCount, marshalledSubmits, marshalledFence);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void WaitIdle()
        {
            try
            {
                Interop.Commands.vkQueueWaitIdle(this.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void BindSparse(BindSparseInfo[] bindInfo, Fence fence)
        {
            try
            {
                uint marshalledBindInfoCount = default(uint);
                Interop.BindSparseInfo* marshalledBindInfo = default(Interop.BindSparseInfo*);
                Interop.Fence marshalledFence = default(Interop.Fence);
                marshalledBindInfoCount = (uint)(bindInfo?.Length ?? 0);
                if (bindInfo != null)
                {
                    var fieldPointer = (Interop.BindSparseInfo*)(Interop.HeapUtil.AllocateAndClear<Interop.BindSparseInfo>(bindInfo.Length).ToPointer());
                    for(int index = 0; index < bindInfo.Length; index++)
                    {
                        bindInfo[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledBindInfo = fieldPointer;
                }
                else
                {
                    marshalledBindInfo = null;
                }
                marshalledFence = fence.handle;
                Interop.Commands.vkQueueBindSparse(this.handle, marshalledBindInfoCount, marshalledBindInfo, marshalledFence);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
