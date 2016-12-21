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
    /// Specify that an image is bound to a dedicated memory resource.
    /// </para>
    /// <para>
    /// If the pname:pNext list includes a
    /// sname:VkDedicatedAllocationImageCreateInfoNV structure, then that
    /// structure includes an enable controlling whether the image will have a
    /// dedicated memory allocation bound to it.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Using a dedicated allocation for color and
    /// depth/stencil attachments or other large images may: improve
    /// performance on some devices. ====
    /// </para>
    /// </summary>
    public struct DedicatedAllocationImageCreateInfo
    {
        /// <summary>
        /// pname:dedicatedAllocation indicates whether the image will have a
        /// dedicated allocation bound to it.
        /// </summary>
        public Bool32 DedicatedAllocation
        {
            get;
            set;
        }
        
        internal unsafe Interop.DedicatedAllocationImageCreateInfo* MarshalTo()
        {
            var result = (Interop.DedicatedAllocationImageCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.DedicatedAllocationImageCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.DedicatedAllocationImageCreateInfo* pointer)
        {
            pointer->SType = StructureType.DedicatedAllocationImageCreateInfo;
            pointer->DedicatedAllocation = this.DedicatedAllocation;
        }
    }
}
