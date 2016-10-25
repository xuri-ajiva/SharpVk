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
    /// Specifies the tiling arrangement of data in an image.
    /// </para>
    /// <para>
    /// ename:VK_IMAGE_TILING_OPTIMAL specifies optimal tiling (texels are laid
    /// out in an implementation-dependent arrangement, for more optimal memory
    /// access), and ename:VK_IMAGE_TILING_LINEAR specifies linear tiling
    /// (texels are laid out in memory in row-major order, possibly with some
    /// padding on each row).
    /// </para>
    /// </summary>
    public enum ImageTiling
    {
        /// <summary>
        /// -
        /// </summary>
        Optimal = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Linear = 1, 
    }
}
