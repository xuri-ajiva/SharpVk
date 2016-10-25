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
    /// Structure specifying parameters of a newly created shader module.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:codeSize must: be greater than 0 *
    /// pname:codeSize must: be a multiple of 4. If the +VK_NV_glsl_shader
    /// extension+ is enabled and pname:pCode references GLSL code
    /// pname:codeSize can be a multiple of 1 * pname:pCode must: point to
    /// valid SPIR-V code, formatted and packed as described by the
    /// &lt;&lt;spirv-spec,Khronos SPIR-V Specification&gt;&gt;. If the
    /// +VK_NV_glsl_shader+ extension is enabled pname:pCode can instead
    /// reference valid GLSL code and must: be written to the
    /// +GL_KHR_vulkan_glsl+ extension specification * pname:pCode must: adhere
    /// to the validation rules described by the
    /// &lt;&lt;spirvenv-module-validation, Validation Rules within a
    /// Module&gt;&gt; section of the &lt;&lt;spirvenv-capabilities,SPIR-V
    /// Environment&gt;&gt; appendix. If the +VK_NV_glsl_shader+ extension is
    /// enabled pname:pCode can be valid GLSL code with respect to the
    /// +GL_KHR_vulkan_glsl+ GLSL extension specification * pname:pCode must:
    /// declare the code:Shader capability for SPIR-V code * pname:pCode must:
    /// not declare any capability that is not supported by the API, as
    /// described by the &lt;&lt;spirvenv-module-validation,
    /// Capabilities&gt;&gt; section of the
    /// &lt;&lt;spirvenv-capabilities,SPIR-V Environment&gt;&gt; appendix * If
    /// pname:pCode declares any of the capabilities that are listed as not
    /// required by the implementation, the relevant feature must: be enabled,
    /// as listed in the &lt;&lt;spirvenv-capabilities-table,SPIR-V
    /// Environment&gt;&gt; appendix ****
    /// </para>
    /// </summary>
    public struct ShaderModuleCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public ShaderModuleCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:codeSize is the size, in bytes, of the code pointed to by
        /// pname:pCode.
        /// </summary>
        public Size CodeSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pCode points to code that is used to create the shader
        /// module. The type and format of the code is determined from the
        /// content of the memory addressed by pname:pCode.
        /// </summary>
        public uint[] Code
        {
            get;
            set;
        }
        
        internal unsafe Interop.ShaderModuleCreateInfo Pack()
        {
            Interop.ShaderModuleCreateInfo result = default(Interop.ShaderModuleCreateInfo);
            result.SType = StructureType.ShaderModuleCreateInfo;
            result.Code = this.Code == null ? null : Interop.HeapUtil.MarshalTo(this.Code);
            result.Flags = this.Flags;
            result.CodeSize = this.CodeSize;
            return result;
        }
        
        internal unsafe Interop.ShaderModuleCreateInfo* MarshalTo()
        {
            return (Interop.ShaderModuleCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
