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
    public struct SubmitInfo
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
        public PipelineStageFlags[] WaitDestinationStageMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public CommandBuffer[] CommandBuffers
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
        
        internal unsafe void MarshalTo(Interop.SubmitInfo* pointer)
        {
            pointer->SType = StructureType.SubmitInfo;
            pointer->Next = null;
            pointer->WaitSemaphoreCount = (uint)(this.WaitSemaphores?.Length ?? 0);
            if (this.WaitSemaphores != null)
            {
                var fieldPointer = (Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<Interop.Semaphore>(this.WaitSemaphores.Length).ToPointer());
                for(int index = 0; index < (uint)(this.WaitSemaphores.Length); index++)
                {
                    fieldPointer[index] = this.WaitSemaphores[index]?.handle ?? default(Interop.Semaphore);
                }
                pointer->WaitSemaphores = fieldPointer;
            }
            else
            {
                pointer->WaitSemaphores = null;
            }
            if (this.WaitDestinationStageMask != null)
            {
                var fieldPointer = (PipelineStageFlags*)(Interop.HeapUtil.AllocateAndClear<PipelineStageFlags>(this.WaitDestinationStageMask.Length).ToPointer());
                for(int index = 0; index < (uint)(this.WaitDestinationStageMask.Length); index++)
                {
                    fieldPointer[index] = this.WaitDestinationStageMask[index];
                }
                pointer->WaitDestinationStageMask = fieldPointer;
            }
            else
            {
                pointer->WaitDestinationStageMask = null;
            }
            pointer->CommandBufferCount = (uint)(this.CommandBuffers?.Length ?? 0);
            if (this.CommandBuffers != null)
            {
                var fieldPointer = (Interop.CommandBuffer*)(Interop.HeapUtil.AllocateAndClear<Interop.CommandBuffer>(this.CommandBuffers.Length).ToPointer());
                for(int index = 0; index < (uint)(this.CommandBuffers.Length); index++)
                {
                    fieldPointer[index] = this.CommandBuffers[index]?.handle ?? default(Interop.CommandBuffer);
                }
                pointer->CommandBuffers = fieldPointer;
            }
            else
            {
                pointer->CommandBuffers = null;
            }
            pointer->SignalSemaphoreCount = (uint)(this.SignalSemaphores?.Length ?? 0);
            if (this.SignalSemaphores != null)
            {
                var fieldPointer = (Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<Interop.Semaphore>(this.SignalSemaphores.Length).ToPointer());
                for(int index = 0; index < (uint)(this.SignalSemaphores.Length); index++)
                {
                    fieldPointer[index] = this.SignalSemaphores[index]?.handle ?? default(Interop.Semaphore);
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
