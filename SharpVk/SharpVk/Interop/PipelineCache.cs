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
    /// Opaque handle to a pipeline cache object.
    /// </para>
    /// <para>
    /// Pipeline cache objects allow the result of pipeline construction to be
    /// reused between pipelines and between runs of an application. Reuse
    /// between pipelines is achieved by passing the same pipeline cache object
    /// when creating multiple related pipelines. Reuse across runs of an
    /// application is achieved by retrieving pipeline cache contents in one
    /// run of an application, saving the contents, and using them to
    /// preinitialize a pipeline cache on a subsequent run. The contents of the
    /// pipeline cache objects are managed by the implementation. Applications
    /// can: manage the host memory consumed by a pipeline cache object and
    /// control the amount of data retrieved from a pipeline cache object.
    /// </para>
    /// </summary>
    public struct PipelineCache
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null PipelineCache handle.
        /// </summary>
        public static PipelineCache Null
        {
            get
            {
                return new PipelineCache
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
