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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ImageViewCreateInfo
    {
        /// <summary>
        /// pname:sType is the type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// pname:pNext is `NULL` or a pointer to an extension-specific
        /// structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public SharpVk.ImageViewCreateFlags Flags; 
        
        /// <summary>
        /// pname:image is a sname:VkImage on which the view will be created.
        /// </summary>
        public SharpVk.Interop.Image Image; 
        
        /// <summary>
        /// pname:viewType is the type of the image view.
        /// </summary>
        public SharpVk.ImageViewType ViewType; 
        
        /// <summary>
        /// pname:format is a elink:VkFormat describing the format and type
        /// used to interpret data elements in the image.
        /// </summary>
        public SharpVk.Format Format; 
        
        /// <summary>
        /// pname:components specifies a remapping of color components (or of
        /// depth or stencil components after they have been converted into
        /// color components). See slink:VkComponentMapping.
        /// </summary>
        public SharpVk.ComponentMapping Components; 
        
        /// <summary>
        /// pname:subresourceRange is a slink:VkImageSubresourceRange selecting
        /// the set of mipmap levels and array layers to be accessible to the
        /// view.
        /// </summary>
        public SharpVk.ImageSubresourceRange SubresourceRange; 
    }
}
