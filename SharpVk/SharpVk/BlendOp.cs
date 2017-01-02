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
    /// Framebuffer blending operations.
    /// </para>
    /// <para>
    /// &lt;&lt;&lt;
    /// </para>
    /// <para>
    /// The semantics of each enum value is described in the table below:
    /// </para>
    /// <para>
    /// .Blend Operations
    /// [width="100%",cols="45%,30%,25%",options="header",align="center"] |====
    /// |VkBlendOp | RGB Components | Alpha Component
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_ADD | [eq]#R = R~s0~ {times} S~r~ + R~d~ {times}
    /// D~r~# + [eq]#G = G~s0~ {times} S~g~ + G~d~ {times} D~g~# + [eq]#B =
    /// B~s0~ {times} S~b~ + B~d~ {times} D~b~# | [eq]#A = A~s0~ {times} S~a~ +
    /// A~d~ {times} D~a~#
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_SUBTRACT | [eq]#R = R~s0~ {times} S~r~ - R~d~
    /// {times} D~r~# + [eq]#G = G~s0~ {times} S~g~ - G~d~ {times} D~g~# +
    /// [eq]#B = B~s0~ {times} S~b~ - B~d~ {times} D~b~# | [eq]#A = A~s0~
    /// {times} S~a~ - A~d~ {times} D~a~#
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_REVERSE_SUBTRACT | [eq]#R = R~d~ {times} D~r~ -
    /// R~s0~ {times} S~r~# + [eq]#G = G~d~ {times} D~g~ - G~s0~ {times} S~g~#
    /// + [eq]#B = B~d~ {times} D~b~ - B~s0~ {times} S~b~# | [eq]#A = A~d~
    /// {times} D~a~ - A~s0~ {times} S~a~#
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_MIN | [eq]#R = min(R~s0~,R~d~)# + [eq]#G =
    /// min(G~s0~,G~d~)# + [eq]#B = min(B~s0~,B~d~)# | [eq]#A =
    /// min(A~s0~,A~d~)#
    /// </para>
    /// <para>
    /// |ename:VK_BLEND_OP_MAX | [eq]#R = max(R~s0~,R~d~)# + [eq]#G =
    /// max(G~s0~,G~d~)# + [eq]#B = max(B~s0~,B~d~)# | [eq]#A =
    /// max(A~s0~,A~d~)# |====
    /// </para>
    /// <para>
    /// In this table, the following conventions are used:
    /// </para>
    /// <para>
    /// * [eq]#R~s0~, G~s0~, B~s0~# and [eq]#A~s0~# represent the first source
    /// color R, G, B, and A components, respectively. * [eq]#R~d~, G~d~, B~d~#
    /// and [eq]#A~d~# represent the R, G, B, and A components of the
    /// destination color. That is, the color currently in the corresponding
    /// color attachment for this fragment/sample. * [eq]#S~r~, S~g~, S~b~# and
    /// [eq]#S~a~# represent the source blend factor R, G, B, and A components,
    /// respectively. * [eq]#D~r~, D~g~, D~b~# and [eq]#D~a~# represent the
    /// destination blend factor R, G, B, and A components, respectively.
    /// </para>
    /// </summary>
    public enum BlendOp
    {
        /// <summary>
        /// -
        /// </summary>
        Add = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Subtract = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        ReverseSubtract = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        Min = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        Max = 4, 
    }
}
