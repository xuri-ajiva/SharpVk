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
    /// Structure specifying parameters of a newly created pipeline color blend
    /// state.
    /// </para>
    /// <para>
    /// Each element of the pname:pAttachments array is a
    /// slink:VkPipelineColorBlendAttachmentState structure specifying
    /// per-target blending state for each individual color attachment. If the
    /// &lt;&lt;features-features-independentBlend,independent blending&gt;&gt;
    /// feature is not enabled on the device, all
    /// slink:VkPipelineColorBlendAttachmentState elements in the
    /// pname:pAttachments array must: be identical.
    /// </para>
    /// </summary>
    public struct PipelineColorBlendStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineColorBlendStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:logicOpEnable controls whether to apply
        /// &lt;&lt;framebuffer-logicop, Logical Operations&gt;&gt;.
        /// </summary>
        public Bool32 LogicOpEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:logicOp selects which logical operation to apply.
        /// </summary>
        public LogicOp LogicOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pAttachments: is a pointer to array of per target attachment
        /// states.
        /// </summary>
        public PipelineColorBlendAttachmentState[] Attachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:blendConstants is an array of four values used as the R, G,
        /// B, and A components of the blend constant that are used in
        /// blending, depending on the &lt;&lt;framebuffer-blendfactors,blend
        /// factor&gt;&gt;.
        /// </summary>
        public float[] BlendConstants
        {
            get;
            set;
        }
        
        internal unsafe Interop.PipelineColorBlendStateCreateInfo Pack()
        {
            Interop.PipelineColorBlendStateCreateInfo result = default(Interop.PipelineColorBlendStateCreateInfo);
            result.SType = StructureType.PipelineColorBlendStateCreateInfo;
            
            //Attachments
            if (this.Attachments != null)
            {
                result.Attachments = (PipelineColorBlendAttachmentState*)Interop.HeapUtil.Allocate<PipelineColorBlendAttachmentState>(this.Attachments.Length).ToPointer();
                for (int index = 0; index < this.Attachments.Length; index++)
                {
                    result.Attachments[index] = this.Attachments[index];
                }
            }
            else
            {
                result.Attachments = null;
            }
            Validate.CheckLength(this.BlendConstants, 4, "BlendConstants");
            MemUtil.WriteToPtr((IntPtr)(result.BlendConstants), this.BlendConstants, 0, 4);
            result.AttachmentCount = (uint)(this.Attachments?.Length ?? 0);
            result.Flags = this.Flags;
            result.LogicOpEnable = this.LogicOpEnable;
            result.LogicOp = this.LogicOp;
            return result;
        }
        
        internal unsafe Interop.PipelineColorBlendStateCreateInfo* MarshalTo()
        {
            return (Interop.PipelineColorBlendStateCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
