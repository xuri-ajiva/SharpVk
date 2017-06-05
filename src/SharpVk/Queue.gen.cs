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
        
        private readonly SharpVk.Interop.Device parent; 
        
        internal Queue(SharpVk.Interop.Device parent, SharpVk.Interop.Queue handle)
        {
            this.handle = handle;
            this.parent = parent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Submit(SubmitInfo[] submits, Fence fence)
        {
            try
            {
                Interop.SubmitInfo* marshalledSubmits = default(Interop.SubmitInfo*);
                if (submits != null)
                {
                    var fieldPointer = (Interop.SubmitInfo*)(Interop.HeapUtil.AllocateAndClear<Interop.SubmitInfo>(submits.Length).ToPointer());
                    for(int index = 0; index < (uint)(submits.Length); index++)
                    {
                        submits[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledSubmits = fieldPointer;
                }
                else
                {
                    marshalledSubmits = null;
                }
                Interop.Commands.vkQueueSubmit(this.handle, (uint)(submits?.Length ?? 0), marshalledSubmits, fence.handle);
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
                Interop.BindSparseInfo* marshalledBindInfo = default(Interop.BindSparseInfo*);
                if (bindInfo != null)
                {
                    var fieldPointer = (Interop.BindSparseInfo*)(Interop.HeapUtil.AllocateAndClear<Interop.BindSparseInfo>(bindInfo.Length).ToPointer());
                    for(int index = 0; index < (uint)(bindInfo.Length); index++)
                    {
                        bindInfo[index].MarshalTo(&fieldPointer[index]);
                    }
                    marshalledBindInfo = fieldPointer;
                }
                else
                {
                    marshalledBindInfo = null;
                }
                Interop.Commands.vkQueueBindSparse(this.handle, (uint)(bindInfo?.Length ?? 0), marshalledBindInfo, fence.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
