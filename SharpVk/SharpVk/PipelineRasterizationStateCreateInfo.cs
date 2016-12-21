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
    /// Structure specifying parameters of a newly created pipeline
    /// rasterization state.
    /// </para>
    /// <para>
    /// ifdef::VK_AMD_rasterization_order[] The application can: also chain a
    /// sname:VkPipelineRasterizationStateRasterizationOrderAMD structure to
    /// the sname:VkPipelineRasterizationStateCreateInfo structure through its
    /// pname:pNext member. This structure enables selecting the rasterization
    /// order to use when rendering with the corresponding graphics pipeline as
    /// described in &lt;&lt;primrast-order, Rasterization Order&gt;&gt;.
    /// endif::VK_AMD_rasterization_order[]
    /// </para>
    /// </summary>
    public struct PipelineRasterizationStateCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public PipelineRasterizationStateCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthClampEnable controls whether to clamp the fragment's
        /// depth values instead of clipping primitives to the z planes of the
        /// frustum, as described in &lt;&lt;vertexpostproc-clipping,Primitive
        /// Clipping&gt;&gt;.
        /// </summary>
        public Bool32 DepthClampEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:rasterizerDiscardEnable controls whether primitives are
        /// discarded immediately before the rasterization stage.
        /// </summary>
        public Bool32 RasterizerDiscardEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:polygonMode is the triangle rendering mode. See
        /// elink:VkPolygonMode.
        /// </summary>
        public PolygonMode PolygonMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:cullMode is the triangle facing direction used for primitive
        /// culling. See elink:VkCullModeFlagBits.
        /// </summary>
        public CullModeFlags CullMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:frontFace is the front-facing triangle orientation to be used
        /// for culling. See elink:VkFrontFace.
        /// </summary>
        public FrontFace FrontFace
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthBiasEnable controls whether to bias fragment depth
        /// values.
        /// </summary>
        public Bool32 DepthBiasEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthBiasConstantFactor is a scalar factor controlling the
        /// constant depth value added to each fragment.
        /// </summary>
        public float DepthBiasConstantFactor
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthBiasClamp is the maximum (or minimum) depth bias of a
        /// fragment.
        /// </summary>
        public float DepthBiasClamp
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:depthBiasSlopeFactor is a scalar factor applied to a
        /// fragment's slope in depth bias calculations.
        /// </summary>
        public float DepthBiasSlopeFactor
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:lineWidth is the width of rasterized line segments.
        /// </summary>
        public float LineWidth
        {
            get;
            set;
        }
        
        internal unsafe Interop.PipelineRasterizationStateCreateInfo* MarshalTo()
        {
            var result = (Interop.PipelineRasterizationStateCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.PipelineRasterizationStateCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.PipelineRasterizationStateCreateInfo* pointer)
        {
            pointer->SType = StructureType.PipelineRasterizationStateCreateInfo;
            pointer->Flags = this.Flags;
            pointer->DepthClampEnable = this.DepthClampEnable;
            pointer->RasterizerDiscardEnable = this.RasterizerDiscardEnable;
            pointer->PolygonMode = this.PolygonMode;
            pointer->CullMode = this.CullMode;
            pointer->FrontFace = this.FrontFace;
            pointer->DepthBiasEnable = this.DepthBiasEnable;
            pointer->DepthBiasConstantFactor = this.DepthBiasConstantFactor;
            pointer->DepthBiasClamp = this.DepthBiasClamp;
            pointer->DepthBiasSlopeFactor = this.DepthBiasSlopeFactor;
            pointer->LineWidth = this.LineWidth;
        }
    }
}
