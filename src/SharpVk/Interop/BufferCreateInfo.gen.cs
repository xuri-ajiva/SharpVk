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
    public unsafe struct BufferCreateInfo
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
        /// buffer. See elink:VkBufferCreateFlagBits below for a description of
        /// the supported bits.
        /// </summary>
        public SharpVk.BufferCreateFlags Flags; 
        
        /// <summary>
        /// pname:size is the size in bytes of the buffer to be created.
        /// </summary>
        public DeviceSize Size; 
        
        /// <summary>
        /// pname:usage is a bitmask describing the allowed usages of the
        /// buffer. See elink:VkBufferUsageFlagBits below for a description of
        /// the supported bits.
        /// </summary>
        public SharpVk.BufferUsageFlags Usage; 
        
        /// <summary>
        /// pname:sharingMode is the sharing mode of the buffer when it will be
        /// accessed by multiple queue families, see elink:VkSharingMode in the
        /// &lt;&lt;resources-sharing,Resource Sharing&gt;&gt; section below
        /// for supported values.
        /// </summary>
        public SharpVk.SharingMode SharingMode; 
        
        /// <summary>
        /// pname:queueFamilyIndexCount is the number of entries in the
        /// pname:pQueueFamilyIndices array.
        /// </summary>
        public uint QueueFamilyIndexCount; 
        
        /// <summary>
        /// pname:pQueueFamilyIndices is a list of queue families that will
        /// access this buffer (ignored if pname:sharingMode is not
        /// ename:VK_SHARING_MODE_CONCURRENT).
        /// </summary>
        public uint* QueueFamilyIndices; 
    }
}
