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
    /// Structure specifying parameters of a newly created pipeline shader
    /// stage.
    /// </summary>
    public struct PipelineShaderStageCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineShaderStageCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:stage names a single pipeline stage. Bits which can: be set
        /// include: + --
        /// </summary>
        public ShaderStageFlags Stage
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public ShaderModule Module
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public SpecializationInfo? SpecializationInfo
        {
            get;
            set;
        }
        
        internal unsafe Interop.PipelineShaderStageCreateInfo* MarshalTo()
        {
            var result = (Interop.PipelineShaderStageCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.PipelineShaderStageCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.PipelineShaderStageCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineShaderStageCreateInfo;
            pointer->Next = null;
            this.Module?.MarshalTo(&pointer->Module);
            pointer->Name = Interop.HeapUtil.MarshalTo(this.Name);
            pointer->SpecializationInfo = this.SpecializationInfo == null ? null : this.SpecializationInfo.Value.MarshalTo();
            pointer->Flags = this.Flags;
            pointer->Stage = this.Stage;
        }
    }
}
