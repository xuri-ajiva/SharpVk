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

namespace SharpVk.Interop
{
    /// <summary>
    /// <para>
    /// Opaque handle to a fence object.
    /// </para>
    /// <para>
    /// Fences are a synchronization primitive that can: be used to insert a
    /// dependency from a queue to the host. Fences have two states - signaled
    /// and unsignaled. A fence can: be signaled as part of the execution of a
    /// &lt;&lt;devsandqueues-submission, queue submission&gt;&gt; command.
    /// Fences can: be unsignaled on the host with flink:vkResetFences. Fences
    /// can: be waited on by the host with the flink:vkWaitForFences command,
    /// and the current state can: be queried with flink:vkGetFenceStatus.
    /// </para>
    /// </summary>
    public struct Fence
    {
        internal ulong handle; 
        
        /// <summary>
        /// 
        /// </summary>
        public Fence(ulong handle)
        {
            this.handle = handle;
        }
        
        /// <summary>
        /// A read-only property that returns a null Fence handle.
        /// </summary>
        public static Fence Null
        {
            get
            {
                return new Fence
                {
                    handle = default(ulong)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle;
        }
    }
}
