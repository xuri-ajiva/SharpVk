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
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        internal Queue(SharpVk.Device parent, SharpVk.Interop.Queue handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void Submit(SharpVk.SubmitInfo[] submits, SharpVk.Fence fence)
        {
            try
            {
                SharpVk.Interop.SubmitInfo* marshalledSubmits = default(SharpVk.Interop.SubmitInfo*);
                if (submits != null)
                {
                    var fieldPointer = (SharpVk.Interop.SubmitInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SubmitInfo>(submits.Length).ToPointer());
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
                Result methodResult = Interop.Commands.vkQueueSubmit(this.handle, (uint)(submits?.Length ?? 0), marshalledSubmits, fence?.handle ?? default(SharpVk.Interop.Fence));
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
        /// 
        /// </summary>
        public unsafe void WaitIdle()
        {
            try
            {
                Result methodResult = Interop.Commands.vkQueueWaitIdle(this.handle);
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
        /// 
        /// </summary>
        public unsafe void BindSparse(SharpVk.BindSparseInfo[] bindInfo, SharpVk.Fence fence)
        {
            try
            {
                SharpVk.Interop.BindSparseInfo* marshalledBindInfo = default(SharpVk.Interop.BindSparseInfo*);
                if (bindInfo != null)
                {
                    var fieldPointer = (SharpVk.Interop.BindSparseInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BindSparseInfo>(bindInfo.Length).ToPointer());
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
                Result methodResult = Interop.Commands.vkQueueBindSparse(this.handle, (uint)(bindInfo?.Length ?? 0), marshalledBindInfo, fence?.handle ?? default(SharpVk.Interop.Fence));
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
