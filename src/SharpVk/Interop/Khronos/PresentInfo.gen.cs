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

namespace SharpVk.Interop.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PresentInfo
    {
        /// <summary>
        /// pname:sType is the type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// pname:pNext is `NULL` or a pointer to an extension-specific
        /// structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// pname:waitSemaphoreCount is the number of semaphores to wait for
        /// before issuing the present request. The number may: be zero.
        /// </summary>
        public uint WaitSemaphoreCount; 
        
        /// <summary>
        /// pname:pWaitSemaphores, if not `NULL`, is an array of
        /// sname:VkSemaphore objects with pname:waitSemaphoreCount entries,
        /// and specifies the semaphores to wait for before issuing the present
        /// request.
        /// </summary>
        public SharpVk.Interop.Semaphore* WaitSemaphores; 
        
        /// <summary>
        /// pname:swapchainCount is the number of swapchains being presented to
        /// by this command.
        /// </summary>
        public uint SwapchainCount; 
        
        /// <summary>
        /// pname:pSwapchains is an array of sname:VkSwapchainKHR objects with
        /// pname:swapchainCount entries. A given swapchain must: not appear in
        /// this list more than once.
        /// </summary>
        public SharpVk.Interop.Khronos.Swapchain* Swapchains; 
        
        /// <summary>
        /// pname:pImageIndices is an array of indices into the array of each
        /// swapchain's presentable images, with pname:swapchainCount entries.
        /// Each entry in this array identifies the image to present on the
        /// corresponding entry in the pname:pSwapchains array.
        /// </summary>
        public uint* ImageIndices; 
        
        /// <summary>
        /// pname:pResults is an array of ename:VkResult typed elements with
        /// pname:swapchainCount entries. Applications that do not need
        /// per-swapchain results can: use `NULL` for pname:pResults. If
        /// non-`NULL`, each entry in pname:pResults will be set to the
        /// ename:VkResult for presenting the swapchain corresponding to the
        /// same index in pname:pSwapchains.
        /// </summary>
        public SharpVk.Result* Results; 
    }
}
