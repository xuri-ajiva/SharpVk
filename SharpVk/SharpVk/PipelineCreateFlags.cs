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
    /// <para>
    /// Bitmask controlling how a pipeline is generated.
    /// </para>
    /// <para>
    /// It is valid to set both ename:VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT
    /// and ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT. This allows a pipeline to
    /// be both a parent and possibly a child in a pipeline hierarchy. See
    /// &lt;&lt;pipelines-pipeline-derivatives,Pipeline Derivatives&gt;&gt; for
    /// more information.
    /// </para>
    /// <para>
    /// pname:pDynamicState points to a structure of type
    /// sname:VkPipelineDynamicStateCreateInfo.
    /// </para>
    /// <para>
    /// ifdef::VK_NV_glsl_shader[] If any shader stage fails to compile,
    /// ifdef::VK_EXT_debug_report[] the compile log will be reported back to
    /// the application, and endif::VK_EXT_debug_report[]
    /// ename:VK_ERROR_INVALID_SHADER_NV will be generated.
    /// endif::VK_NV_glsl_shader[]
    /// </para>
    /// </summary>
    [Flags]
    public enum PipelineCreateFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT specifies that
        /// the created pipeline will not be optimized. Using this flag may:
        /// reduce the time taken to create the pipeline.
        /// </summary>
        DisableOptimization = 1 << 0, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT specifies that the
        /// pipeline to be created is allowed to be the parent of a pipeline
        /// that will be created in a subsequent call to
        /// flink:vkCreateGraphicsPipelines.
        /// </summary>
        AllowDerivatives = 1 << 1, 
        
        /// <summary>
        /// ename:VK_PIPELINE_CREATE_DERIVATIVE_BIT specifies that the pipeline
        /// to be created will be a child of a previously created parent
        /// pipeline.
        /// </summary>
        Derivative = 1 << 2, 
    }
}
