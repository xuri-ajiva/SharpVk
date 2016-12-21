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
    /// Structure specifying a global memory barrier.
    /// </para>
    /// <para>
    /// The first &lt;&lt;synchronization-dependencies-access-scopes, access
    /// scope&gt;&gt; is limited to access types in the
    /// &lt;&lt;synchronization-access-masks, source access mask&gt;&gt;
    /// specified by pname:srcAccessMask.
    /// </para>
    /// <para>
    /// The second &lt;&lt;synchronization-dependencies-access-scopes, access
    /// scope&gt;&gt; is limited to access types in the
    /// &lt;&lt;synchronization-access-masks, destination access mask&gt;&gt;
    /// specified by pname:dstAccessMask.
    /// </para>
    /// </summary>
    public struct MemoryBarrier
    {
        /// <summary>
        /// pname:srcAccessMask defines a &lt;&lt;synchronization-access-masks,
        /// source access mask&gt;&gt;.
        /// </summary>
        public AccessFlags SourceAccessMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstAccessMask defines a &lt;&lt;synchronization-access-masks,
        /// destination access mask&gt;&gt;.
        /// </summary>
        public AccessFlags DestinationAccessMask
        {
            get;
            set;
        }
        
        internal unsafe Interop.MemoryBarrier* MarshalTo()
        {
            var result = (Interop.MemoryBarrier*)Interop.HeapUtil.AllocateAndClear<Interop.MemoryBarrier>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.MemoryBarrier* pointer)
        {
            pointer->SType = StructureType.MemoryBarrier;
            pointer->SourceAccessMask = this.SourceAccessMask;
            pointer->DestinationAccessMask = this.DestinationAccessMask;
        }
    }
}
