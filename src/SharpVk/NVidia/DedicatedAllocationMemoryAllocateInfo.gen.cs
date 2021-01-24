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

namespace SharpVk.NVidia
{
    /// <summary>
    /// Specify a dedicated memory allocation resource.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DedicatedAllocationMemoryAllocateInfo
    {
        /// <summary>
        /// image is null or a handle of an image which this memory will be
        /// bound to.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// buffer is null or a handle of a buffer which this memory will be
        /// bound to.
        /// </summary>
        public Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.DedicatedAllocationMemoryAllocateInfo* pointer)
        {
            pointer->SType = StructureType.DedicatedAllocationMemoryAllocateInfo;
            pointer->Next = null;
            pointer->Image = Image?.Handle ?? default;
            pointer->Buffer = Buffer?.Handle ?? default;
        }
    }
}
