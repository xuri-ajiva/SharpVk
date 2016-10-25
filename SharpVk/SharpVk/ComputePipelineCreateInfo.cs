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
    /// Structure specifying parameters of a newly created compute pipeline.
    /// </para>
    /// <para>
    /// The parameters pname:basePipelineHandle and pname:basePipelineIndex are
    /// described in more detail in
    /// &lt;&lt;pipelines-pipeline-derivatives,Pipeline Derivatives&gt;&gt;.
    /// </para>
    /// <para>
    /// pname:stage points to a structure of type
    /// sname:VkPipelineShaderStageCreateInfo.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If pname:flags contains the
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineIndex is not `-1`, pname:basePipelineHandle must: be
    /// dlink:VK_NULL_HANDLE * If pname:flags contains the
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineIndex is not `-1`, it must: be a valid index into the
    /// calling command's pname:pCreateInfos parameter * If pname:flags
    /// contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineHandle is not dlink:VK_NULL_HANDLE,
    /// pname:basePipelineIndex must: be `-1` * If pname:flags contains the
    /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag, and
    /// pname:basePipelineHandle is not dlink:VK_NULL_HANDLE,
    /// pname:basePipelineHandle must: be a valid sname:VkPipeline handle * If
    /// pname:flags contains the ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT flag,
    /// and pname:basePipelineHandle is not dlink:VK_NULL_HANDLE, it must: be a
    /// valid handle to a compute sname:VkPipeline * The pname:stage member of
    /// pname:stage must: be ename:VK_SHADER_STAGE_COMPUTE_BIT * The shader
    /// code for the entry point identified by pname:stage and the rest of the
    /// state identified by this structure must: adhere to the pipeline linking
    /// rules described in the &lt;&lt;interfaces,Shader Interfaces&gt;&gt;
    /// chapter * pname:layout must: be
    /// &lt;&lt;descriptorsets-pipelinelayout-consistency,consistent&gt;&gt; with
    /// the layout of the compute shader specified in pname:stage ****
    /// </para>
    /// </summary>
    public struct ComputePipelineCreateInfo
    {
        /// <summary>
        /// pname:flags provides options for pipeline creation, and is of type
        /// elink:VkPipelineCreateFlagBits.
        /// </summary>
        public PipelineCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:stage is a slink:VkPipelineShaderStageCreateInfo describing
        /// the compute shader.
        /// </summary>
        public PipelineShaderStageCreateInfo Stage
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:layout is the description of binding locations used by both
        /// the pipeline and descriptor sets used with the pipeline.
        /// </summary>
        public PipelineLayout Layout
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:basePipelineHandle is a pipeline to derive from
        /// </summary>
        public Pipeline BasePipelineHandle
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:basePipelineIndex is an index into the pname:pCreateInfos
        /// parameter to use as a pipeline to derive from
        /// </summary>
        public int BasePipelineIndex
        {
            get;
            set;
        }
        
        internal unsafe Interop.ComputePipelineCreateInfo Pack()
        {
            Interop.ComputePipelineCreateInfo result = default(Interop.ComputePipelineCreateInfo);
            result.SType = StructureType.ComputePipelineCreateInfo;
            result.Stage = this.Stage.Pack();
            result.Layout = this.Layout?.Pack() ?? Interop.PipelineLayout.Null;
            result.BasePipelineHandle = this.BasePipelineHandle?.Pack() ?? Interop.Pipeline.Null;
            result.Flags = this.Flags;
            result.BasePipelineIndex = this.BasePipelineIndex;
            return result;
        }
        
        internal unsafe Interop.ComputePipelineCreateInfo* MarshalTo()
        {
            return (Interop.ComputePipelineCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
