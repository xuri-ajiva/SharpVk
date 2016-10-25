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
    /// Opaque handle to a pipeline layout object.
    /// </para>
    /// <para>
    /// Access to descriptor sets from a pipeline is accomplished through a
    /// _pipeline layout_. Zero or more descriptor set layouts and zero or more
    /// push constant ranges are combined to form a pipeline layout object
    /// which describes the complete set of resources that can: be accessed by
    /// a pipeline. The pipeline layout represents a sequence of descriptor
    /// sets with each having a specific layout. This sequence of layouts is
    /// used to determine the interface between shader stages and shader
    /// resources. Each pipeline is created using a pipeline layout.
    /// </para>
    /// </summary>
    public struct PipelineLayout
    {
        internal ulong handle; 
        
        /// <summary>
        /// A read-only property that returns a null PipelineLayout handle.
        /// </summary>
        public static PipelineLayout Null
        {
            get
            {
                return new PipelineLayout
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
