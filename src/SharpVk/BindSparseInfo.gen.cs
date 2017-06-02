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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BindSparseInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public Semaphore[] WaitSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SparseBufferMemoryBindInfo[] BufferBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SparseImageOpaqueMemoryBindInfo[] ImageOpaqueBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SparseImageMemoryBindInfo[] ImageBinds
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Semaphore[] SignalSemaphores
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.BindSparseInfo* pointer)
        {
            pointer->SType = StructureType.BindSparseInfo;
            pointer->Next = null;
            pointer->WaitSemaphoreCount = (uint)(this.WaitSemaphores?.Length ?? 0);
            if (this.WaitSemaphores != null)
            {
                var fieldPointer = (Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<Interop.Semaphore>(this.WaitSemaphores.Length).ToPointer());
                for(int index = 0; index < (uint)(this.WaitSemaphores.Length); index++)
                {
                    fieldPointer[index] = this.WaitSemaphores[index].handle;
                }
                pointer->WaitSemaphores = fieldPointer;
            }
            else
            {
                pointer->WaitSemaphores = null;
            }
            pointer->BufferBindCount = (uint)(this.BufferBinds?.Length ?? 0);
            if (this.BufferBinds != null)
            {
                var fieldPointer = (Interop.SparseBufferMemoryBindInfo*)(Interop.HeapUtil.AllocateAndClear<Interop.SparseBufferMemoryBindInfo>(this.BufferBinds.Length).ToPointer());
                for(int index = 0; index < (uint)(this.BufferBinds.Length); index++)
                {
                    this.BufferBinds[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->BufferBinds = fieldPointer;
            }
            else
            {
                pointer->BufferBinds = null;
            }
            pointer->ImageOpaqueBindCount = (uint)(this.ImageOpaqueBinds?.Length ?? 0);
            if (this.ImageOpaqueBinds != null)
            {
                var fieldPointer = (Interop.SparseImageOpaqueMemoryBindInfo*)(Interop.HeapUtil.AllocateAndClear<Interop.SparseImageOpaqueMemoryBindInfo>(this.ImageOpaqueBinds.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ImageOpaqueBinds.Length); index++)
                {
                    this.ImageOpaqueBinds[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ImageOpaqueBinds = fieldPointer;
            }
            else
            {
                pointer->ImageOpaqueBinds = null;
            }
            pointer->ImageBindCount = (uint)(this.ImageBinds?.Length ?? 0);
            if (this.ImageBinds != null)
            {
                var fieldPointer = (Interop.SparseImageMemoryBindInfo*)(Interop.HeapUtil.AllocateAndClear<Interop.SparseImageMemoryBindInfo>(this.ImageBinds.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ImageBinds.Length); index++)
                {
                    this.ImageBinds[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ImageBinds = fieldPointer;
            }
            else
            {
                pointer->ImageBinds = null;
            }
            pointer->SignalSemaphoreCount = (uint)(this.SignalSemaphores?.Length ?? 0);
            if (this.SignalSemaphores != null)
            {
                var fieldPointer = (Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<Interop.Semaphore>(this.SignalSemaphores.Length).ToPointer());
                for(int index = 0; index < (uint)(this.SignalSemaphores.Length); index++)
                {
                    fieldPointer[index] = this.SignalSemaphores[index].handle;
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
