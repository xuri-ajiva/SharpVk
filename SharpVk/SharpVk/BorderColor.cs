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
    /// Specify border color used for texture lookups.
    /// </para>
    /// <para>
    /// [NOTE] .Mapping of OpenGL to Vulkan filter modes ==================
    /// pname:magFilter values of ename:VK_FILTER_NEAREST and
    /// ename:VK_FILTER_LINEAR directly correspond to code:GL_NEAREST and
    /// code:GL_LINEAR magnification filters. pname:minFilter and
    /// pname:mipmapMode combine to correspond to the similarly named OpenGL
    /// minification filter of code:GL_minFilter_MIPMAP_mipmapMode (e.g.
    /// pname:minFilter of ename:VK_FILTER_LINEAR and pname:mipmapMode of
    /// ename:VK_SAMPLER_MIPMAP_MODE_NEAREST correspond to
    /// code:GL_LINEAR_MIPMAP_NEAREST).
    /// </para>
    /// <para>
    /// There are no Vulkan filter modes that directly correspond to OpenGL
    /// minification filters of code:GL_LINEAR or code:GL_NEAREST, but they
    /// can: be emulated using ename:VK_SAMPLER_MIPMAP_MODE_NEAREST,
    /// pname:minLod = 0, and pname:maxLod = 0.25, and using pname:minFilter =
    /// ename:VK_FILTER_LINEAR or pname:minFilter = ename:VK_FILTER_NEAREST,
    /// respectively.
    /// </para>
    /// <para>
    /// Note that using a pname:maxLod of zero would cause
    /// &lt;&lt;textures-texel-filtering,magnification&gt;&gt; to always be
    /// performed, and the pname:magFilter to always be used. This is valid,
    /// just not an exact match for OpenGL behavior. Clamping the maximum LOD
    /// to 0.25 allows the [eq]#{lambda}# value to be non-zero and minification
    /// to be performed, while still always rounding down to the base level. If
    /// the pname:minFilter and pname:magFilter are equal, then using a
    /// pname:maxLod of zero also works. ==================
    /// </para>
    /// <para>
    /// pname:addressModeU, pname:addressModeV, and pname:addressModeW must:
    /// each have one of the following values:
    /// </para>
    /// </summary>
    public enum BorderColor
    {
        /// <summary>
        /// -
        /// </summary>
        FloatTransparentBlack = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        IntTransparentBlack = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        FloatOpaqueBlack = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        IntOpaqueBlack = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        FloatOpaqueWhite = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        IntOpaqueWhite = 5, 
    }
}
