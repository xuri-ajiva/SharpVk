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

namespace SharpVk.Khr
{
    /// <summary>
    /// 
    /// </summary>
    public struct PresentInfo
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
        public Khr.Swapchain[] Swapchains
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] ImageIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Result[] Results
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.Khr.PresentInfo* pointer)
        {
            pointer->SType = StructureType.PresentInfoKhr;
            pointer->Next = null;
            pointer->WaitSemaphoreCount = (uint)this.WaitSemaphores.Length;
            if (this.WaitSemaphores != null)
            {
                var fieldPointer = (Interop.Semaphore*)Interop.HeapUtil.AllocateAndClear<Interop.Semaphore>(this.WaitSemaphores.Length).ToPointer();
                for(int index = 0; index < this.WaitSemaphores.Length; index++)
                {
                    fieldPointer[index] = this.WaitSemaphores[index].handle;
                }
                pointer->WaitSemaphores = fieldPointer;
            }
            else
            {
                pointer->WaitSemaphores = null;
            }
            pointer->SwapchainCount = (uint)this.Swapchains.Length;
            if (this.Swapchains != null)
            {
                var fieldPointer = (Interop.Khr.Swapchain*)Interop.HeapUtil.AllocateAndClear<Interop.Khr.Swapchain>(this.Swapchains.Length).ToPointer();
                for(int index = 0; index < this.Swapchains.Length; index++)
                {
                    fieldPointer[index] = this.Swapchains[index].handle;
                }
                pointer->Swapchains = fieldPointer;
            }
            else
            {
                pointer->Swapchains = null;
            }
            if (this.ImageIndices != null)
            {
                var fieldPointer = (uint*)Interop.HeapUtil.AllocateAndClear<uint>(this.ImageIndices.Length).ToPointer();
                for(int index = 0; index < this.ImageIndices.Length; index++)
                {
                    fieldPointer[index] = this.ImageIndices[index];
                }
                pointer->ImageIndices = fieldPointer;
            }
            else
            {
                pointer->ImageIndices = null;
            }
            if (this.Results != null)
            {
                var fieldPointer = (Result*)Interop.HeapUtil.AllocateAndClear<Result>(this.Results.Length).ToPointer();
                for(int index = 0; index < this.Results.Length; index++)
                {
                    fieldPointer[index] = this.Results[index];
                }
                pointer->Results = fieldPointer;
            }
            else
            {
                pointer->Results = null;
            }
        }
    }
}
