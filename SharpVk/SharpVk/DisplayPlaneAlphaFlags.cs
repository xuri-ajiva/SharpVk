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
    /// Alpha blending type.
    /// </summary>
    [Flags]
    public enum DisplayPlaneAlphaFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// ename:VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR: The source image will
        /// be treated as opaque.
        /// </summary>
        Opaque = 1 << 0, 
        
        /// <summary>
        /// ename:VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR: A global alpha value
        /// must: be specified that will be applied to all pixels in the source
        /// image.
        /// </summary>
        Global = 1 << 1, 
        
        /// <summary>
        /// ename:VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR: The alpha value
        /// will be determined by the alpha channel of the source image's
        /// pixels. If the source format contains no alpha values, no blending
        /// will be applied. The source alpha values are not premultiplied into
        /// the source image's other color channels.
        /// </summary>
        PerPixel = 1 << 2, 
        
        /// <summary>
        /// ename:VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR: This
        /// is equivalent to ename:VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR
        /// except the source alpha values are assumed to be premultiplied into
        /// the source image's other color channels.
        /// </summary>
        PerPixelPremultiplied = 1 << 3, 
    }
}
