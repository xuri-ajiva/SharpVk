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
    /// <para>
    /// Structure describing parameters of a queue presentation.
    /// </para>
    /// <para>
    /// .Valid Usage **** * Any given element of pname:pImageIndices must: be
    /// the index of a presentable image acquired from the swapchain specified
    /// by the corresponding element of the pname:pSwapchains array * Any given
    /// element of sname:VkSemaphore in pname:pWaitSemaphores must: refer to a
    /// prior signal of that sname:VkSemaphore that will not be consumed by any
    /// other wait on that semaphore ****
    /// </para>
    /// </summary>
    public struct PresentInfo
    {
        /// <summary>
        /// pname:pWaitSemaphores, if not code:VK_NULL_HANDLE, is an array of
        /// sname:VkSemaphore objects with pname:waitSemaphoreCount entries,
        /// and specifies the semaphores to wait for before issuing the present
        /// request.
        /// </summary>
        public Semaphore[] WaitSemaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pSwapchains is an array of sname:VkSwapchainKHR objects with
        /// pname:swapchainCount entries. A given swapchain must: not appear in
        /// this list more than once.
        /// </summary>
        public Swapchain[] Swapchains
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pImageIndices is an array of indices into the array of each
        /// swapchain's presentable images, with pname:swapchainCount entries.
        /// Each entry in this array identifies the image to present on the
        /// corresponding entry in the pname:pSwapchains array.
        /// </summary>
        public uint[] ImageIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pResults is an array of ename:VkResult typed elements with
        /// pname:swapchainCount entries. Applications that do not need
        /// per-swapchain results can: use `NULL` for pname:pResults. If
        /// non-`NULL`, each entry in pname:pResults will be set to the
        /// ename:VkResult for presenting the swapchain corresponding to the
        /// same index in pname:pSwapchains.
        /// </summary>
        public Result[] Results
        {
            get;
            set;
        }
        
        internal unsafe Interop.PresentInfo Pack()
        {
            Interop.PresentInfo result = default(Interop.PresentInfo);
            result.SType = StructureType.PresentInfo;
            
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
            
            //Swapchains
            if (this.Swapchains != null)
            {
                int size = System.Runtime.InteropServices.Marshal.SizeOf<Interop.Swapchain>();
                IntPtr pointer = Interop.HeapUtil.Allocate<Interop.Swapchain>(this.Swapchains.Length);
                for (int index = 0; index < this.Swapchains.Length; index++)
                {
                    System.Runtime.InteropServices.Marshal.StructureToPtr(this.Swapchains[index].Pack(), pointer + (size * index), false);
                }
                result.Swapchains = (Interop.Swapchain*)pointer.ToPointer();
            }
            else
            {
                result.Swapchains = null;
            }
            result.ImageIndices = this.ImageIndices == null ? null : Interop.HeapUtil.MarshalTo(this.ImageIndices);
            
            //Results
            if (this.Results != null)
            {
                result.Results = (Result*)Interop.HeapUtil.Allocate<int>(this.Results.Length).ToPointer();
                for (int index = 0; index < this.Results.Length; index++)
                {
                    result.Results[index] = this.Results[index];
                }
            }
            else
            {
                result.Results = null;
            }
            result.WaitSemaphoreCount = (uint)(this.WaitSemaphores?.Length ?? 0);
            result.SwapchainCount = (uint)(this.ImageIndices?.Length ?? 0);
            return result;
        }
        
        internal unsafe Interop.PresentInfo* MarshalTo()
        {
            return (Interop.PresentInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
