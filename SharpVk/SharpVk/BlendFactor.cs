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
    /// Framebuffer blending factors.
    /// </para>
    /// <para>
    /// The semantics of each enum value is described in the table below:
    /// </para>
    /// <para>
    /// .Blend Factors
    /// [width="100%",options="header",align="center",cols="59%,28%,13%"] |====
    /// |VkBlendFactor | RGB Blend Factors [eq]#(S~r~,S~g~,S~b~)# or
    /// [eq]#(D~r~,D~g~,D~b~)# | Alpha Blend Factor ([eq]#S~a~# or [eq]#D~a~#)
    /// |ename:VK_BLEND_FACTOR_ZERO | [eq]#(0,0,0)# | [eq]#0#
    /// |ename:VK_BLEND_FACTOR_ONE | [eq]#(1,1,1)# | [eq]#1#
    /// |ename:VK_BLEND_FACTOR_SRC_COLOR | [eq]#(R~s0~,G~s0~,B~s0~)# |
    /// [eq]#A~s0~# |ename:VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR |
    /// [eq]#(1-R~s0~,1-G~s0~,1-B~s0~)# | [eq]#1-A~s0~#
    /// |ename:VK_BLEND_FACTOR_DST_COLOR | [eq]#(R~d~,G~d~,B~d~)# | [eq]#A~d~#
    /// |ename:VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR |
    /// [eq]#(1-R~d~,1-G~d~,1-B~d~)# | [eq]#1-A~d~#
    /// |ename:VK_BLEND_FACTOR_SRC_ALPHA | [eq]#(A~s0~,A~s0~,A~s0~)# |
    /// [eq]#A~s0~# |ename:VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA |
    /// [eq]#(1-A~s0~,1-A~s0~,1-A~s0~)# | [eq]#1-A~s0~#
    /// |ename:VK_BLEND_FACTOR_DST_ALPHA | [eq]#(A~d~,A~d~,A~d~)# | [eq]#A~d~#
    /// |ename:VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA |
    /// [eq]#(1-A~d~,1-A~d~,1-A~d~)# | [eq]#1-A~d~#
    /// |ename:VK_BLEND_FACTOR_CONSTANT_COLOR | [eq]#(R~c~,G~c~,B~c~)# |
    /// [eq]#A~c~# |ename:VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR |
    /// [eq]#(1-R~c~,1-G~c~,1-B~c~)# | [eq]#1-A~c~#
    /// |ename:VK_BLEND_FACTOR_CONSTANT_ALPHA | [eq]#(A~c~,A~c~,A~c~)# |
    /// [eq]#A~c~# |ename:VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA |
    /// [eq]#(1-A~c~,1-A~c~,1-A~c~)# | [eq]#1-A~c~#
    /// |ename:VK_BLEND_FACTOR_SRC_ALPHA_SATURATE | [eq]#(f,f,f)#; [eq]#f =
    /// min(A~s0~,1-A~d~)# | [eq]#1# |ename:VK_BLEND_FACTOR_SRC1_COLOR |
    /// [eq]#(R~s1~,G~s1~,B~s1~)# | [eq]#A~s1~#
    /// |ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR |
    /// [eq]#(1-R~s1~,1-G~s1~,1-B~s1~)# | [eq]#1-A~s1~#
    /// |ename:VK_BLEND_FACTOR_SRC1_ALPHA | [eq]#(A~s1~,A~s1~,A~s1~)# |
    /// [eq]#A~s1~# |ename:VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA |
    /// [eq]#(1-A~s1~,1-A~s1~,1-A~s1~)# | [eq]#1-A~s1~# |====
    /// </para>
    /// <para>
    /// In this table, the following conventions are used:
    /// </para>
    /// <para>
    /// * [eq]#R~s0~,G~s0~,B~s0~# and [eq]#A~s0~# represent the first source
    /// color R, G, B, and A components, respectively, for the fragment output
    /// location corresponding to the color attachment being blended. *
    /// [eq]#R~s1~,G~s1~,B~s1~# and [eq]#A~s1~# represent the second source
    /// color R, G, B, and A components, respectively, used in dual source
    /// blending modes, for the fragment output location corresponding to the
    /// color attachment being blended. * [eq]#R~d~,G~d~,B~d~# and [eq]#A~d~#
    /// represent the R, G, B, and A components of the destination color. That
    /// is, the color currently in the corresponding color attachment for this
    /// fragment/sample. * [eq]#R~c~,G~c~,B~c~# and [eq]#A~c~# represent the
    /// blend constant R, G, B, and A components, respectively.
    /// </para>
    /// </summary>
    public enum BlendFactor
    {
        /// <summary>
        /// -
        /// </summary>
        Zero = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        One = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        SourceColor = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusSourceColor = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        DestinationColor = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusDestinationColor = 5, 
        
        /// <summary>
        /// -
        /// </summary>
        SourceAlpha = 6, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusSourceAlpha = 7, 
        
        /// <summary>
        /// -
        /// </summary>
        DestinationAlpha = 8, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusDestinationAlpha = 9, 
        
        /// <summary>
        /// -
        /// </summary>
        ConstantColor = 10, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusConstantColor = 11, 
        
        /// <summary>
        /// -
        /// </summary>
        ConstantAlpha = 12, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusConstantAlpha = 13, 
        
        /// <summary>
        /// -
        /// </summary>
        SourceAlphaSaturate = 14, 
        
        /// <summary>
        /// -
        /// </summary>
        Src1Color = 15, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusSrc1Color = 16, 
        
        /// <summary>
        /// -
        /// </summary>
        Src1Alpha = 17, 
        
        /// <summary>
        /// -
        /// </summary>
        OneMinusSrc1Alpha = 18, 
    }
}
