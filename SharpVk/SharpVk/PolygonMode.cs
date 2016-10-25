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
    /// Control polygon rasterization mode.
    /// </para>
    /// <para>
    /// The pname:polygonMode selects which method of rasterization is used for
    /// polygons. If pname:polygonMode is ename:VK_POLYGON_MODE_POINT, then the
    /// vertices of polygons are treated, for rasterization purposes, as if
    /// they had been drawn as points. ename:VK_POLYGON_MODE_LINE causes
    /// polygon edges to be drawn as line segments. ename:VK_POLYGON_MODE_FILL
    /// causes polygons to render using the polygon rasterization rules in this
    /// section.
    /// </para>
    /// <para>
    /// Note that these modes affect only the final rasterization of polygons:
    /// in particular, a polygon's vertices are shaded and the polygon is
    /// clipped and possibly culled before these modes are applied.
    /// </para>
    /// </summary>
    public enum PolygonMode
    {
        /// <summary>
        /// -
        /// </summary>
        Fill = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Line = 1, 
        
        /// <summary>
        /// -
        /// </summary>
        Point = 2, 
    }
}
