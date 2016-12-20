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
    /// Structure specifying descriptor image info.
    /// </para>
    /// <para>
    /// Members of sname:VkDescriptorImageInfo that are not used in an update
    /// (as described above) are ignored.
    /// </para>
    /// </summary>
    public struct DescriptorImageInfo
    {
        /// <summary>
        /// pname:sampler is a sampler handle, and is used in descriptor
        /// updates for types ename:VK_DESCRIPTOR_TYPE_SAMPLER and
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER if the binding
        /// being updated does not use immutable samplers.
        /// </summary>
        public Sampler Sampler
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageView is an image view handle, and is used in descriptor
        /// updates for types ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
        /// ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER,
        /// and ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT.
        /// </summary>
        public ImageView ImageView
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageLayout is the layout that the image will be in at the
        /// time this descriptor is accessed. pname:imageLayout is used in
        /// descriptor updates for types
        /// ename:VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, ename:VK_DESCRIPTOR_TYPE_STORAGE_IMAGE,
        /// ename:VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and
        /// ename:VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT.
        /// </summary>
        public ImageLayout ImageLayout
        {
            get;
            set;
        }
        
        internal unsafe Interop.DescriptorImageInfo Pack()
        {
            Interop.DescriptorImageInfo result = default(Interop.DescriptorImageInfo);
            return result;
        }
        
        internal unsafe Interop.DescriptorImageInfo* MarshalTo()
        {
            var result = (Interop.DescriptorImageInfo*)Interop.HeapUtil.Allocate<Interop.DescriptorImageInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.DescriptorImageInfo* pointer)
        {
            pointer->Sampler = this.Sampler?.Pack() ?? Interop.Sampler.Null;
            pointer->ImageView = this.ImageView?.Pack() ?? Interop.ImageView.Null;
            pointer->ImageLayout = this.ImageLayout;
        }
    }
}
