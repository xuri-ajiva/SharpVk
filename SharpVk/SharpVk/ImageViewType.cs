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
    /// Image view types.
    /// </para>
    /// <para>
    /// The exact image view type is partially implicit, based on the image's
    /// type and sample count, as well as the view creation parameters as
    /// described in the &lt;&lt;resources-image-views-compatibility,table
    /// below&gt;&gt;. This table also shows which SPIR-V OpTypeImage Dim and
    /// Arrayed parameters correspond to each image view type.
    /// </para>
    /// </summary>
    public enum ImageViewType
    {
        /// <summary>
        /// -
        /// </summary>
        ImageView1d = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageView2d = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageView3d = 2, 
        
        /// <summary>
        /// -
        /// </summary>
        Cube = 3, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageView1dArray = 4, 
        
        /// <summary>
        /// -
        /// </summary>
        ImageView2dArray = 5, 
        
        /// <summary>
        /// -
        /// </summary>
        CubeArray = 6, 
    }
}
