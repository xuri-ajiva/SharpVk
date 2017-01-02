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
    /// Opaque handle to a shader module object.
    /// </para>
    /// <para>
    /// _Shader modules_ contain _shader code_ and one or more entry points.
    /// Shaders are selected from a shader module by specifying an entry point
    /// as part of &lt;&lt;pipelines,pipeline&gt;&gt; creation. The stages of a
    /// pipeline can: use shaders that come from different modules. The shader
    /// code defining a shader module must: be in the SPIR-V format, as
    /// described by the &lt;&lt;spirvenv,Vulkan Environment for SPIR-V&gt;&gt;
    /// appendix.
    /// </para>
    /// </summary>
    public struct ShaderModule
    {
        internal ulong handle; 
        
        /// <summary>
        /// 
        /// </summary>
        public ShaderModule(ulong handle)
        {
            this.handle = handle;
        }
        
        /// <summary>
        /// A read-only property that returns a null ShaderModule handle.
        /// </summary>
        public static ShaderModule Null
        {
            get
            {
                return new ShaderModule
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
