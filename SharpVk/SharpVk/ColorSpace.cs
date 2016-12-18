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
    /// Supported color space of the presentation engine.
    /// </para>
    /// <para>
    /// If pname:pSurfaceFormats includes an entry whose value for
    /// pname:colorSpace is ename:VK_COLOR_SPACE_SRGB_NONLINEAR_KHR and whose
    /// value for pname:format is a UNORM (or SRGB) format and the
    /// corresponding SRGB (or UNORM) format is a color renderable format for
    /// ename:VK_IMAGE_TILING_OPTIMAL, then pname:pSurfaceFormats must: also
    /// contain an entry with the same value for pname:colorSpace and
    /// pname:format equal to the corresponding SRGB (or UNORM) format.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== If pname:pSurfaceFormats includes just one entry,
    /// whose value for pname:format is ename:VK_FORMAT_UNDEFINED,
    /// pname:surface has no preferred format. In this case, the application
    /// can: use any valid ename:VkFormat value. ====
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== In the initial release of the +VK_KHR_surface+ and
    /// +VK_KHR_swapchain+ extensions, the token
    /// ename:VK_COLORSPACE_SRGB_NONLINEAR_KHR was used. Starting in the May
    /// 13, 2016 updates to the extension branches, matching release 1.0.13 of
    /// the core API specification, ename:VK_COLOR_SPACE_SRGB_NONLINEAR_KHR is
    /// used instead for consistency with Vulkan naming rules. The older enum
    /// is still available for backwards compatibility. ====
    /// </para>
    /// </summary>
    public enum ColorSpace
    {
        /// <summary>
        /// ename:VK_COLOR_SPACE_SRGB_NONLINEAR_KHR: The presentation engine
        /// supports the sRGB color space.
        /// </summary>
        SrgbNonlinear = 0, 
    }
}
