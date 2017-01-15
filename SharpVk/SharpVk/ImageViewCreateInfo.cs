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
    /// <para>
    /// Structure specifying parameters of a newly created image view.
    /// </para>
    /// <para>
    /// If pname:image was created with the
    /// ename:VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT flag, pname:format can: be
    /// different from the image's format, but if they are not equal they must:
    /// be _compatible_. Image format compatibility is defined in the
    /// &lt;&lt;features-formats-compatibility-classes,Format Compatibility
    /// Classes&gt;&gt; section.
    /// </para>
    /// </summary>
    public struct ImageViewCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public ImageViewCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:image is a sname:VkImage on which the view will be created.
        /// </summary>
        public Image Image
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:viewType is the type of the image view.
        /// </summary>
        public ImageViewType ViewType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:format is a elink:VkFormat describing the format and type
        /// used to interpret data elements in the image.
        /// </summary>
        public Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:components specifies a remapping of color components (or of
        /// depth or stencil components after they have been converted into
        /// color components). See slink:VkComponentMapping.
        /// </summary>
        public ComponentMapping Components
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:subresourceRange is a slink:VkImageSubresourceRange selecting
        /// the set of mipmap levels and array layers to be accessible to the
        /// view.
        /// </summary>
        public ImageSubresourceRange SubresourceRange
        {
            get;
            set;
        }
        
        internal unsafe Interop.ImageViewCreateInfo* MarshalTo()
        {
            var result = (Interop.ImageViewCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.ImageViewCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.ImageViewCreateInfo* pointer)
        {
            pointer->SType = StructureType.ImageViewCreateInfo;
            pointer->Next = null;
            this.Image?.MarshalTo(&pointer->Image);
            pointer->Flags = this.Flags;
            pointer->ViewType = this.ViewType;
            pointer->Format = this.Format;
            pointer->Components = this.Components;
            pointer->SubresourceRange = this.SubresourceRange;
        }
    }
}
