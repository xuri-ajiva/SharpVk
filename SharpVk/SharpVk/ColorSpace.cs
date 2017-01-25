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
    /// Supported color space of the presentation engine.
    /// </para>
    /// <para>
    /// The color components of Non-linear color space swap chain images have
    /// had the appropriate transfer function applied. Vulkan requires that all
    /// implementations support the sRGB OETF and EOTF transfer functions when
    /// using an SRGB pixel format. Other transfer functions, such as SMPTE
    /// 170M, must not: be performed by the implementation, but can: be
    /// performed by the application shader.
    /// endif::VK_EXT_swapchain_colorspace[]
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
        /// supports the sRGB color space. ifdef::VK_EXT_swapchain_colorspace[]
        /// </summary>
        SrgbNonlinear = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        DisplayP3Linear = 1000104001, 
        
        /// <summary>
        /// -
        /// </summary>
        DisplayP3Nonlinear = 1000104002, 
        
        /// <summary>
        /// * ename:VK_COLOR_SPACE_SCRGB_LINEAR_EXT - supports the scRGB color
        /// space and applies a linear OETF.
        /// </summary>
        ScrgbLinear = 1000104003, 
        
        /// <summary>
        /// * ename:VK_COLOR_SPACE_SCRGB_NONLINEAR_EXT - supports the scRGB
        /// color space and applies the scRGB OETF.
        /// </summary>
        ScrgbNonlinear = 1000104004, 
        
        /// <summary>
        /// * ename:VK_COLOR_SPACE_DCI_P3_LINEAR_EXT - supports the DCI-P3
        /// color space and applies a linear OETF.
        /// </summary>
        DciP3Linear = 1000104005, 
        
        /// <summary>
        /// * ename:VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT - supports the DCI-P3
        /// color space and applies the Gamma 2.6 OETF.
        /// </summary>
        DciP3Nonlinear = 1000104006, 
        
        /// <summary>
        /// * ename:VK_COLOR_SPACE_BT709_LINEAR_EXT - supports the BT709 color
        /// space and applies a linear OETF.
        /// </summary>
        Bt709Linear = 1000104007, 
        
        /// <summary>
        /// * ename:VK_COLOR_SPACE_BT709_NONLINEAR_EXT - supports the BT709
        /// color space and applies the SMPTE 170M OETF.
        /// </summary>
        Bt709Nonlinear = 1000104008, 
        
        /// <summary>
        /// * ename:VK_COLOR_SPACE_BT2020_LINEAR_EXT - supports the BT2020
        /// color space and applies a linear OETF.
        /// </summary>
        Bt2020Linear = 1000104009, 
        
        /// <summary>
        /// * ename:VK_COLOR_SPACE_BT2020_NONLINEAR_EXT - supports the BT2020
        /// color space and applies the SMPTE 170M OETF.
        /// </summary>
        Bt2020Nonlinear = 1000104010, 
        
        /// <summary>
        /// * ename:VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT - supports the AdobeRGB
        /// color space and applies a linear OETF.
        /// </summary>
        AdobergbLinear = 1000104011, 
        
        /// <summary>
        /// * ename:VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT - supports the
        /// AdobeRGB color space and applies the Gamma 2.2 OETF.
        /// </summary>
        AdobergbNonlinear = 1000104012, 
    }
}
