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

using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// Structure specifying a sparse binding operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BindSparseInfo
    {
        /// <summary>
        /// An array of semaphores upon which to wait on before the sparse
        /// binding operations for this batch begin execution. If semaphores to
        /// wait on are provided, they define a semaphore wait operation.
        /// </summary>
        public Semaphore[] WaitSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of SparseBufferMemoryBindInfo structures.
        /// </summary>
        public SparseBufferMemoryBindInfo[] BufferBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of SparseImageOpaqueMemoryBindInfo structures, indicating
        /// opaque sparse image bindings to perform.
        /// </summary>
        public SparseImageOpaqueMemoryBindInfo[] ImageOpaqueBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of SparseImageMemoryBindInfo structures, indicating sparse
        /// image bindings to perform.
        /// </summary>
        public SparseImageMemoryBindInfo[] ImageBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// An array of semaphores which will be signaled when the sparse
        /// binding operations for this batch have completed execution. If
        /// semaphores to be signaled are provided, they define a semaphore
        /// signal operation.
        /// </summary>
        public Semaphore[] SignalSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.BindSparseInfo* pointer)
        {
            pointer->SType = StructureType.BindSparseInfo;
            pointer->Next = null;
            pointer->WaitSemaphoreCount = (uint)(Interop.HeapUtil.GetLength(WaitSemaphores));
            if (WaitSemaphores != null)
            {
                var fieldPointer = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Semaphore>(WaitSemaphores.Length).ToPointer());
                for(int index = 0; index < (uint)(WaitSemaphores.Length); index++)
                {
                    fieldPointer[index] = WaitSemaphores[index]?.Handle ?? default;
                }
                pointer->WaitSemaphores = fieldPointer;
            }
            else
            {
                pointer->WaitSemaphores = null;
            }
            pointer->BufferBindCount = (uint)(Interop.HeapUtil.GetLength(BufferBinds));
            if (BufferBinds != null)
            {
                var fieldPointer = (SharpVk.Interop.SparseBufferMemoryBindInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SparseBufferMemoryBindInfo>(BufferBinds.Length).ToPointer());
                for(int index = 0; index < (uint)(BufferBinds.Length); index++)
                {
                    BufferBinds[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->BufferBinds = fieldPointer;
            }
            else
            {
                pointer->BufferBinds = null;
            }
            pointer->ImageOpaqueBindCount = (uint)(Interop.HeapUtil.GetLength(ImageOpaqueBinds));
            if (ImageOpaqueBinds != null)
            {
                var fieldPointer = (SharpVk.Interop.SparseImageOpaqueMemoryBindInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SparseImageOpaqueMemoryBindInfo>(ImageOpaqueBinds.Length).ToPointer());
                for(int index = 0; index < (uint)(ImageOpaqueBinds.Length); index++)
                {
                    ImageOpaqueBinds[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ImageOpaqueBinds = fieldPointer;
            }
            else
            {
                pointer->ImageOpaqueBinds = null;
            }
            pointer->ImageBindCount = (uint)(Interop.HeapUtil.GetLength(ImageBinds));
            if (ImageBinds != null)
            {
                var fieldPointer = (SharpVk.Interop.SparseImageMemoryBindInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SparseImageMemoryBindInfo>(ImageBinds.Length).ToPointer());
                for(int index = 0; index < (uint)(ImageBinds.Length); index++)
                {
                    ImageBinds[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ImageBinds = fieldPointer;
            }
            else
            {
                pointer->ImageBinds = null;
            }
            pointer->SignalSemaphoreCount = (uint)(Interop.HeapUtil.GetLength(SignalSemaphores));
            if (SignalSemaphores != null)
            {
                var fieldPointer = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Semaphore>(SignalSemaphores.Length).ToPointer());
                for(int index = 0; index < (uint)(SignalSemaphores.Length); index++)
                {
                    fieldPointer[index] = SignalSemaphores[index]?.Handle ?? default;
                }
                pointer->SignalSemaphores = fieldPointer;
            }
            else
            {
                pointer->SignalSemaphores = null;
            }
        }
    }
}
