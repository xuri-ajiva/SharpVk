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
    public unsafe struct ImageCreateInfo
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
        /// pname:flags is a bitmask describing additional parameters of the
        /// image. See elink:VkImageCreateFlagBits below for a description of
        /// the supported bits.
        /// </summary>
        public SharpVk.ImageCreateFlags Flags; 
        
        /// <summary>
        /// pname:imageType is a elink:VkImageType specifying the basic
        /// dimensionality of the image, as described below. Layers in array
        /// textures do not count as a dimension for the purposes of the image
        /// type.
        /// </summary>
        public SharpVk.ImageType ImageType; 
        
        /// <summary>
        /// pname:format is a elink:VkFormat describing the format and type of
        /// the data elements that will be contained in the image.
        /// </summary>
        public SharpVk.Format Format; 
        
        /// <summary>
        /// pname:extent is a slink:VkExtent3D describing the number of data
        /// elements in each dimension of the base level.
        /// </summary>
        public SharpVk.Extent3D Extent; 
        
        /// <summary>
        /// pname:mipLevels describes the number of levels of detail available
        /// for minified sampling of the image.
        /// </summary>
        public uint MipLevels; 
        
        /// <summary>
        /// pname:arrayLayers is the number of layers in the image.
        /// </summary>
        public uint ArrayLayers; 
        
        /// <summary>
        /// pname:samples is the number of sub-data element samples in the
        /// image as defined in elink:VkSampleCountFlagBits. See
        /// &lt;&lt;primsrast-multisampling,Multisampling&gt;&gt;.
        /// </summary>
        public SharpVk.SampleCountFlags Samples; 
        
        /// <summary>
        /// pname:tiling is a elink:VkImageTiling specifying the tiling
        /// arrangement of the data elements in memory, as described below.
        /// </summary>
        public SharpVk.ImageTiling Tiling; 
        
        /// <summary>
        /// pname:usage is a bitmask describing the intended usage of the
        /// image. See elink:VkImageUsageFlagBits below for a description of
        /// the supported bits.
        /// </summary>
        public SharpVk.ImageUsageFlags Usage; 
        
        /// <summary>
        /// pname:sharingMode is the sharing mode of the image when it will be
        /// accessed by multiple queue families, and must: be one of the values
        /// described for elink:VkSharingMode in the
        /// &lt;&lt;resources-sharing,Resource Sharing&gt;&gt; section below.
        /// </summary>
        public SharpVk.SharingMode SharingMode; 
        
        /// <summary>
        /// pname:queueFamilyIndexCount is the number of entries in the
        /// pname:pQueueFamilyIndices array.
        /// </summary>
        public uint QueueFamilyIndexCount; 
        
        /// <summary>
        /// pname:pQueueFamilyIndices is a list of queue families that will
        /// access this image (ignored if pname:sharingMode is not
        /// ename:VK_SHARING_MODE_CONCURRENT).
        /// </summary>
        public uint* QueueFamilyIndices; 
        
        /// <summary>
        /// pname:initialLayout selects the initial elink:VkImageLayout state
        /// of all image subresources of the image. See
        /// &lt;&lt;resources-image-layouts,Image Layouts&gt;&gt;.
        /// pname:initialLayout must: be ename:VK_IMAGE_LAYOUT_UNDEFINED or
        /// ename:VK_IMAGE_LAYOUT_PREINITIALIZED.
        /// </summary>
        public SharpVk.ImageLayout InitialLayout; 
    }
}
