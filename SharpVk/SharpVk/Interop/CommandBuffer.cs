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

namespace SharpVk.Interop
{
    /// <summary>
    /// <para>
    /// Opaque handle to a command buffer object.
    /// </para>
    /// <para>
    /// Command buffers are objects used to record commands which can: be
    /// subsequently submitted to a device queue for execution. There are two
    /// levels of command buffers - _primary command buffers_, which can:
    /// execute secondary command buffers, and which are submitted to queues,
    /// and _secondary command buffers_, which can: be executed by primary
    /// command buffers, and which are not directly submitted to queues.
    /// </para>
    /// </summary>
    public struct CommandBuffer
    {
        internal UIntPtr handle; 
        
        /// <summary>
        /// A read-only property that returns a null CommandBuffer handle.
        /// </summary>
        public static CommandBuffer Null
        {
            get
            {
                return new CommandBuffer
                {
                    handle = default(UIntPtr)
                };
            }
        }
        
        /// <summary>
        /// Returns the marshalled value of this handle as an unsigned 64-bit
        /// integer.
        /// </summary>
        public ulong ToUInt64()
        {
            return this.handle.ToUInt64();
        }
    }
}