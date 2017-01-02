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
    /// Interpret polygon front-facing orientation.
    /// </para>
    /// <para>
    /// The first step of polygon rasterization is to determine whether the
    /// triangle is _back-facing_ or _front-facing_. This determination is made
    /// based on the sign of the (clipped or unclipped) polygon's area computed
    /// in framebuffer coordinates. One way to compute this area is:
    /// </para>
    /// <para>
    /// [latexmath]
    /// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ \[
    /// a = -{1 \over 2}\sum_{i=0}^{n-1} x_f^i y_f^{i \oplus 1} - x_f^{i \oplus
    /// 1} y_f^i \]
    /// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    /// </para>
    /// <para>
    /// where latexmath:[$x_f^i$] and latexmath:[$y_f^i$] are the [eq]#x# and
    /// [eq]#y# framebuffer coordinates of the [eq]##i##th vertex of the
    /// [eq]#n#-vertex polygon (vertices are numbered starting at zero for the
    /// purposes of this computation) and [eq]#i {oplus} 1# is [eq]#(i + 1) mod
    /// n#.
    /// </para>
    /// <para>
    /// If pname:frontFace is set to ename:VK_FRONT_FACE_COUNTER_CLOCKWISE, a
    /// triangle with positive area is considered front-facing. If it is set to
    /// ename:VK_FRONT_FACE_CLOCKWISE, a triangle with negative area is
    /// considered front-facing. Any triangle which is not front-facing is
    /// back-facing, including zero-area triangles.
    /// </para>
    /// </summary>
    public enum FrontFace
    {
        /// <summary>
        /// -
        /// </summary>
        CounterClockwise = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Clockwise = 1, 
    }
}
