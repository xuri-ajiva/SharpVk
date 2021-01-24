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
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SemaphoreWaitInfo
    {
        /// <summary>
        /// </summary>
        public SemaphoreWaitFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public Semaphore[] Semaphores
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ulong[] Values
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.SemaphoreWaitInfo* pointer)
        {
            pointer->SType = StructureType.SemaphoreWaitInfoVersion;
            pointer->Next = null;
            if (Flags != null)
            {
                pointer->Flags = Flags.Value;
            }
            else
            {
                pointer->Flags = default;
            }
            pointer->SemaphoreCount = (uint)(Interop.HeapUtil.GetLength(Semaphores));
            if (Semaphores != null)
            {
                var fieldPointer = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Semaphore>(Semaphores.Length).ToPointer());
                for(int index = 0; index < (uint)(Semaphores.Length); index++)
                {
                    fieldPointer[index] = Semaphores[index]?.Handle ?? default;
                }
                pointer->Semaphores = fieldPointer;
            }
            else
            {
                pointer->Semaphores = null;
            }
            if (Values != null)
            {
                var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Values.Length).ToPointer());
                for(int index = 0; index < (uint)(Values.Length); index++)
                {
                    fieldPointer[index] = Values[index];
                }
                pointer->Values = fieldPointer;
            }
            else
            {
                pointer->Values = null;
            }
        }
    }
}
