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
    /// Opaque handle to a command pool object.
    /// </para>
    /// <para>
    /// Command pools are opaque objects that command buffer memory is
    /// allocated from, and which allow the implementation to amortize the cost
    /// of resource creation across multiple command buffers. Command pools are
    /// application-synchronized, meaning that a command pool must: not be used
    /// concurrently in multiple threads. That includes use via recording
    /// commands on any command buffers allocated from the pool, as well as
    /// operations that allocate, free, and reset command buffers or the pool
    /// itself.
    /// </para>
    /// </summary>
    public struct CommandPool
    {
        internal ulong handle; 
        
        /// <summary>
        /// 
        /// </summary>
        public CommandPool(ulong handle)
        {
            this.handle = handle;
        }
        
        /// <summary>
        /// A read-only property that returns a null CommandPool handle.
        /// </summary>
        public static CommandPool Null
        {
            get
            {
                return new CommandPool
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
