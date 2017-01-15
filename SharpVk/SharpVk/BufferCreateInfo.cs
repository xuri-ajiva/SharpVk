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
    /// Structure specifying the parameters of a newly created buffer object.
    /// </para>
    /// <para>
    /// Bits which can: be set in pname:usage are:
    /// </para>
    /// </summary>
    public struct BufferCreateInfo
    {
        /// <summary>
        /// pname:flags is a bitmask describing additional parameters of the
        /// buffer. See elink:VkBufferCreateFlagBits below for a description of
        /// the supported bits.
        /// </summary>
        public BufferCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:size is the size in bytes of the buffer to be created.
        /// </summary>
        public ulong Size
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:usage is a bitmask describing the allowed usages of the
        /// buffer. See elink:VkBufferUsageFlagBits below for a description of
        /// the supported bits.
        /// </summary>
        public BufferUsageFlags Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:sharingMode is the sharing mode of the buffer when it will be
        /// accessed by multiple queue families, see elink:VkSharingMode in the
        /// &lt;&lt;resources-sharing,Resource Sharing&gt;&gt; section below
        /// for supported values.
        /// </summary>
        public SharingMode SharingMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pQueueFamilyIndices is a list of queue families that will
        /// access this buffer (ignored if pname:sharingMode is not
        /// ename:VK_SHARING_MODE_CONCURRENT).
        /// </summary>
        public uint[] QueueFamilyIndices
        {
            get;
            set;
        }
        
        internal unsafe Interop.BufferCreateInfo* MarshalTo()
        {
            var result = (Interop.BufferCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.BufferCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.BufferCreateInfo* pointer)
        {
            pointer->SType = StructureType.BufferCreateInfo;
            pointer->Next = null;
            pointer->QueueFamilyIndices = this.QueueFamilyIndices == null ? null : Interop.HeapUtil.MarshalTo(this.QueueFamilyIndices);
            pointer->QueueFamilyIndexCount = (uint)(this.QueueFamilyIndices?.Length ?? 0);
            pointer->Flags = this.Flags;
            pointer->Size = this.Size;
            pointer->Usage = this.Usage;
            pointer->SharingMode = this.SharingMode;
        }
    }
}
