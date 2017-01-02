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
    /// Opaque handle to a semaphore object.
    /// </para>
    /// <para>
    /// Semaphores are a synchronization primitive that can: be used to insert
    /// a dependency between batches submitted to queues. Semaphores have two
    /// states - signaled and unsignaled. The state of a semaphore can: be
    /// signaled after execution of a batch of commands is completed. A batch
    /// can: wait for a semaphore to become signaled before it begins
    /// execution, and the semaphore is also unsignaled before the batch begins
    /// execution.
    /// </para>
    /// </summary>
    public struct Semaphore
    {
        internal ulong handle; 
        
        /// <summary>
        /// 
        /// </summary>
        public Semaphore(ulong handle)
        {
            this.handle = handle;
        }
        
        /// <summary>
        /// A read-only property that returns a null Semaphore handle.
        /// </summary>
        public static Semaphore Null
        {
            get
            {
                return new Semaphore
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
