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
    /// Structure specifying parameters of a newly created buffer view.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BufferViewCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public SharpVk.BufferViewCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:buffer is a sname:VkBuffer on which the view will be created.
        /// </summary>
        public SharpVk.Buffer Buffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:format is a elink:VkFormat describing the format of the data
        /// elements in the buffer.
        /// </summary>
        public SharpVk.Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:offset is an offset in bytes from the base address of the
        /// buffer. Accesses to the buffer view from shaders use addressing
        /// that is relative to this starting offset.
        /// </summary>
        public DeviceSize Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:range is a size in bytes of the buffer view. If pname:range
        /// is equal to ename:VK_WHOLE_SIZE, the range from pname:offset to the
        /// end of the buffer is used. If ename:VK_WHOLE_SIZE is used and the
        /// remaining size of the buffer is not a multiple of the element size
        /// of pname:format, then the nearest smaller multiple is used.
        /// </summary>
        public DeviceSize Range
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.BufferViewCreateInfo* pointer)
        {
            pointer->SType = StructureType.BufferViewCreateInfo;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.BufferViewCreateFlags);
            }
            pointer->Buffer = this.Buffer?.handle ?? default(SharpVk.Interop.Buffer);
            pointer->Format = this.Format;
            pointer->Offset = this.Offset;
            pointer->Range = this.Range;
        }
    }
}
