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
    /// Bitmask specifying a pipeline stage.
    /// </para>
    /// <para>
    /// .Valid Usage **** * If the
    /// &lt;&lt;features-features-geometryShader,geometry shaders&gt;&gt;
    /// feature is not enabled, pname:stage must: not be
    /// ename:VK_SHADER_STAGE_GEOMETRY_BIT * If the
    /// &lt;&lt;features-features-tessellationShader,tessellation shaders&gt;&gt;
    /// feature is not enabled, pname:stage must: not be
    /// ename:VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT or
    /// ename:VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT * pname:stage must:
    /// not be ename:VK_SHADER_STAGE_ALL_GRAPHICS, or ename:VK_SHADER_STAGE_ALL
    /// * pname:pName must: be the name of an code:OpEntryPoint in pname:module
    /// with an execution model that matches pname:stage * If the identified
    /// entry point includes any variable in its interface that is declared
    /// with the code:ClipDistance code:BuiltIn decoration, that variable must:
    /// not have an array size greater than
    /// sname:VkPhysicalDeviceLimits::pname:maxClipDistances * If the
    /// identified entry point includes any variable in its interface that is
    /// declared with the code:CullDistance code:BuiltIn decoration, that
    /// variable must: not have an array size greater than
    /// sname:VkPhysicalDeviceLimits::pname:maxCullDistances * If the
    /// identified entry point includes any variables in its interface that are
    /// declared with the code:ClipDistance or code:CullDistance code:BuiltIn
    /// decoration, those variables must: not have array sizes which sum to
    /// more than
    /// sname:VkPhysicalDeviceLimits::pname:maxCombinedClipAndCullDistances *
    /// If the identified entry point includes any variable in its interface
    /// that is declared with the code:SampleMask code:BuiltIn decoration, that
    /// variable must: not have an array size greater than
    /// sname:VkPhysicalDeviceLimits::pname:maxSampleMaskWords * If pname:stage
    /// is ename:VK_SHADER_STAGE_VERTEX_BIT, the identified entry point must:
    /// not include any input variable in its interface that is decorated with
    /// code:CullDistance * If pname:stage is
    /// ename:VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT or
    /// ename:VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT, and the identified
    /// entry point has an code:OpExecutionMode instruction that specifies a
    /// patch size with code:OutputVertices, the patch size must: be greater
    /// than `0` and less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxTessellationPatchSize * If
    /// pname:stage is ename:VK_SHADER_STAGE_GEOMETRY_BIT, the identified entry
    /// point must: have an code:OpExecutionMode instruction that specifies a
    /// maximum output vertex count that is greater than `0` and less than or
    /// equal to sname:VkPhysicalDeviceLimits::pname:maxGeometryOutputVertices
    /// * If pname:stage is ename:VK_SHADER_STAGE_GEOMETRY_BIT, the identified
    /// entry point must: have an code:OpExecutionMode instruction that
    /// specifies an invocation count that is greater than `0` and less than or
    /// equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxGeometryShaderInvocations * If
    /// pname:stage is ename:VK_SHADER_STAGE_GEOMETRY_BIT, and the identified
    /// entry point writes to code:Layer for any primitive, it must: write the
    /// same value to code:Layer for all vertices of a given primitive * If
    /// pname:stage is ename:VK_SHADER_STAGE_GEOMETRY_BIT, and the identified
    /// entry point writes to code:ViewportIndex for any primitive, it must:
    /// write the same value to code:ViewportIndex for all vertices of a given
    /// primitive * If pname:stage is ename:VK_SHADER_STAGE_FRAGMENT_BIT, the
    /// identified entry point must: not include any output variables in its
    /// interface decorated with code:CullDistance * If pname:stage is
    /// ename:VK_SHADER_STAGE_FRAGMENT_BIT, and the identified entry point
    /// writes to code:FragDepth in any execution path, it must: write to
    /// code:FragDepth in all execution paths ****
    /// </para>
    /// </summary>
    [Flags]
    public enum ShaderStageFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Vertex = 1 << 0, 
        
        /// <summary>
        /// -
        /// </summary>
        TessellationControl = 1 << 1, 
        
        /// <summary>
        /// -
        /// </summary>
        TessellationEvaluation = 1 << 2, 
        
        /// <summary>
        /// -
        /// </summary>
        Geometry = 1 << 3, 
        
        /// <summary>
        /// -
        /// </summary>
        Fragment = 1 << 4, 
        
        /// <summary>
        /// -
        /// </summary>
        Compute = 1 << 5, 
        
        /// <summary>
        /// -
        /// </summary>
        AllGraphics = 0x0000001F, 
        
        /// <summary>
        /// -
        /// </summary>
        All = 0x7FFFFFFF, 
    }
}
