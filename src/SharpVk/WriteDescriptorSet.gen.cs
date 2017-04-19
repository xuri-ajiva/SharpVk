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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct WriteDescriptorSet
    {
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
        public DescriptorType DescriptorType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorImageInfo[] ImageInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorBufferInfo[] BufferInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public BufferView[] TexelBufferView
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.WriteDescriptorSet* pointer)
        {
            pointer->SType = StructureType.WriteDescriptorSet;
            pointer->Next = null;
            pointer->DestinationSet = this.DestinationSet.handle;
            pointer->DestinationBinding = this.DestinationBinding;
            pointer->DestinationArrayElement = this.DestinationArrayElement;
            pointer->DescriptorCount = (uint)this.ImageInfo.Length;
            pointer->DescriptorType = this.DescriptorType;
            if (this.ImageInfo != null)
            {
                var fieldPointer = (Interop.DescriptorImageInfo*)Interop.HeapUtil.AllocateAndClear<Interop.DescriptorImageInfo>(this.ImageInfo.Length).ToPointer();
                for(int index = 0; index < this.ImageInfo.Length; index++)
                {
                    this.ImageInfo[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ImageInfo = fieldPointer;
            }
            else
            {
                pointer->ImageInfo = null;
            }
            if (this.BufferInfo != null)
            {
                var fieldPointer = (Interop.DescriptorBufferInfo*)Interop.HeapUtil.AllocateAndClear<Interop.DescriptorBufferInfo>(this.BufferInfo.Length).ToPointer();
                for(int index = 0; index < this.BufferInfo.Length; index++)
                {
                    this.BufferInfo[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->BufferInfo = fieldPointer;
            }
            else
            {
                pointer->BufferInfo = null;
            }
            if (this.TexelBufferView != null)
            {
                var fieldPointer = (Interop.BufferView*)Interop.HeapUtil.AllocateAndClear<Interop.BufferView>(this.TexelBufferView.Length).ToPointer();
                for(int index = 0; index < this.TexelBufferView.Length; index++)
                {
                    fieldPointer[index] = this.TexelBufferView[index].handle;
                }
                pointer->TexelBufferView = fieldPointer;
            }
            else
            {
                pointer->TexelBufferView = null;
            }
        }
    }
}
