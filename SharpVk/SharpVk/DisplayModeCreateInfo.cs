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
    /// Structure specifying parameters of a newly created display mode object.
    /// </summary>
    public struct DisplayModeCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use, and must: be zero.
        /// </summary>
        public DisplayModeCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:parameters is a sname:VkDisplayModeParametersKHR structure
        /// describing the display parameters to use in creating the new mode.
        /// If the parameters are not compatible with the specified display,
        /// the implementation must: return
        /// ename:VK_ERROR_INITIALIZATION_FAILED.
        /// </summary>
        public DisplayModeParameters Parameters
        {
            get;
            set;
        }
        
        internal unsafe Interop.DisplayModeCreateInfo Pack()
        {
            Interop.DisplayModeCreateInfo result = default(Interop.DisplayModeCreateInfo);
            return result;
        }
        
        internal unsafe Interop.DisplayModeCreateInfo* MarshalTo()
        {
            var result = (Interop.DisplayModeCreateInfo*)Interop.HeapUtil.Allocate<Interop.DisplayModeCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.DisplayModeCreateInfo* pointer)
        {
            pointer->SType = StructureType.DisplayModeCreateInfo;
            pointer->Flags = this.Flags;
            pointer->Parameters = this.Parameters;
        }
    }
}
