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
    public struct CopyDescriptorSet
    {
        /// <summary>
        /// 
        /// </summary>
        public DescriptorSet SourceSet
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SourceBinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SourceArrayElement
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorSet DestinationSet
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DestinationBinding
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DestinationArrayElement
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DescriptorCount
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.CopyDescriptorSet* pointer)
        {
            pointer->SType = StructureType.CopyDescriptorSet;
            pointer->Next = null;
            pointer->SourceSet = this.SourceSet?.handle ?? default(Interop.DescriptorSet);
            pointer->SourceBinding = this.SourceBinding;
            pointer->SourceArrayElement = this.SourceArrayElement;
            pointer->DestinationSet = this.DestinationSet?.handle ?? default(Interop.DescriptorSet);
            pointer->DestinationBinding = this.DestinationBinding;
            pointer->DestinationArrayElement = this.DestinationArrayElement;
            pointer->DescriptorCount = this.DescriptorCount;
        }
    }
}
