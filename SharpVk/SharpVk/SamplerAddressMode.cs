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
    /// Specify behavior of sampling with texture coordinates outside an image.
    /// </para>
    /// <para>
    /// The maximum number of sampler objects which can: be simultaneously
    /// created on a device is implementation-dependent and specified by the
    /// &lt;&lt;features-limits-maxSamplerAllocationCount,pname:maxSamplerAllocationCount&gt;&gt; member
    /// of the sname:VkPhysicalDeviceLimits structure. If
    /// pname:maxSamplerAllocationCount is exceeded, fname:vkCreateSampler will
    /// return ename:VK_ERROR_TOO_MANY_OBJECTS.
    /// </para>
    /// <para>
    /// Since sname:VkSampler is a non-dispatchable handle type,
    /// implementations may: return the same handle for sampler state vectors
    /// that are identical. In such cases, all such objects would only count
    /// once against the pname:maxSamplerAllocationCount limit.
    /// </para>
    /// <para>
    /// .Valid Usage **** * The absolute value of pname:mipLodBias must: be
    /// less than or equal to
    /// sname:VkPhysicalDeviceLimits::pname:maxSamplerLodBias * If the
    /// &lt;&lt;features-features-samplerAnisotropy,anisotropic sampling&gt;&gt;
    /// feature is not enabled, pname:anisotropyEnable must: be ename:VK_FALSE
    /// * If pname:anisotropyEnable is ename:VK_TRUE, pname:maxAnisotropy must:
    /// be between `1.0` and
    /// sname:VkPhysicalDeviceLimits::pname:maxSamplerAnisotropy, inclusive *
    /// If pname:unnormalizedCoordinates is ename:VK_TRUE, pname:minFilter and
    /// pname:magFilter must: be equal * If pname:unnormalizedCoordinates is
    /// ename:VK_TRUE, pname:mipmapMode must: be
    /// ename:VK_SAMPLER_MIPMAP_MODE_NEAREST * If pname:unnormalizedCoordinates
    /// is ename:VK_TRUE, pname:minLod and pname:maxLod must: be zero * If
    /// pname:unnormalizedCoordinates is ename:VK_TRUE, pname:addressModeU and
    /// pname:addressModeV must: each be either
    /// ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE or
    /// ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER * If
    /// pname:unnormalizedCoordinates is ename:VK_TRUE, pname:anisotropyEnable
    /// must: be ename:VK_FALSE * If pname:unnormalizedCoordinates is
    /// ename:VK_TRUE, pname:compareEnable must: be ename:VK_FALSE * If any of
    /// pname:addressModeU, pname:addressModeV or pname:addressModeW are
    /// ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER, pname:borderColor must:
    /// be a valid elink:VkBorderColor value * If the
    /// +VK_KHR_sampler_mirror_clamp_to_edge+ extension is not enabled,
    /// pname:addressModeU, pname:addressModeV and pname:addressModeW must: not
    /// be ename:VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE * If
    /// pname:compareEnable is ename:VK_TRUE, pname:compareOp must: be a valid
    /// elink:VkCompareOp value ifdef::VK_IMG_filter_cubic[] * If either
    /// pname:magFilter or pname:minFilter is ename:VK_FILTER_CUBIC_IMG,
    /// pname:anisotropyEnable must: be ename:VK_FALSE
    /// endif::VK_IMG_filter_cubic[] ****
    /// </para>
    /// </summary>
    public enum SamplerAddressMode
    {
        /// <summary>
        /// ename:VK_SAMPLER_ADDRESS_MODE_REPEAT indicates that the repeat wrap
        /// mode will be used.
        /// </summary>
        Repeat = 0, 
        
        /// <summary>
        /// ename:VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT indicates that the
        /// mirrored repeat wrap mode will be used.
        /// </summary>
        MirroredRepeat = 1, 
        
        /// <summary>
        /// ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE indicates that the
        /// clamp to edge wrap mode will be used.
        /// </summary>
        ClampToEdge = 2, 
        
        /// <summary>
        /// ename:VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER indicates that the
        /// clamp to border wrap mode will be used.
        /// </summary>
        ClampToBorder = 3, 
        
        /// <summary>
        /// ename:VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE indicates that
        /// the mirror clamp to edge wrap mode will be used. This is only valid
        /// if the +VK_KHR_mirror_clamp_to_edge+ extension is enabled.
        /// </summary>
        MirrorClampToEdge = 4, 
    }
}
