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
    /// Structure specifying a queue submit operation.
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
}
