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
using System.Runtime.InteropServices;
using System.Text;

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure specifying a viewport.
    /// </para>
    /// <para>
    /// The framebuffer depth coordinate [eq]#pname:z~f~# may: be represented
    /// using either a fixed-point or floating-point representation. However, a
    /// floating-point representation must: be used if the depth/stencil
    /// attachment has a floating-point depth component. If an [eq]#m#-bit
    /// fixed-point representation is used, we assume that it represents each
    /// value latexmath:[$\frac{k}{2^m - 1}$], where [eq]#k {elem} { 0, 1, ...,
    /// 2^m^-1 }#, as [eq]#k# (e.g. 1.0 is represented in binary as a string of
    /// all ones).
    /// </para>
    /// <para>
    /// The viewport parameters shown in the above equations are found from
    /// these values as
    /// </para>
    /// <para>
    /// :: [eq]#o~x~ = pname:x + pname:width / 2# :: [eq]#o~y~ = pname:y +
    /// pname:height / 2# :: [eq]#o~z~ = pname:minDepth# :: [eq]#p~x~ =
    /// pname:width# :: [eq]#p~y~ = pname:height# :: [eq]#p~z~ = pname:maxDepth
    /// - pname:minDepth#.
    /// </para>
    /// <para>
    /// The width and height of the
    /// &lt;&lt;features-limits-maxViewportDimensions, implementation-dependent
    /// maximum viewport dimensions&gt;&gt; must: be greater than or equal to
    /// the width and height of the largest image which can: be created and
    /// attached to a framebuffer.
    /// </para>
    /// <para>
    /// The floating-point viewport bounds are represented with an
    /// &lt;&lt;features-limits-viewportSubPixelBits,implementation-dependent precision&gt;&gt;.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Viewport
    {
        /// <summary>
        /// 
        /// </summary>
        public Viewport(float x, float y, float width, float height, float minDepth, float maxDepth)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.MinDepth = minDepth;
            this.MaxDepth = maxDepth;
        }
        
        /// <summary>
        /// pname:x and pname:y are the viewport's upper left corner
        /// [eq]#(x,y)#.
        /// </summary>
        public float X; 
        
        /// <summary>
        /// -
        /// </summary>
        public float Y; 
        
        /// <summary>
        /// pname:width and pname:height are the viewport's width and height,
        /// respectively.
        /// </summary>
        public float Width; 
        
        /// <summary>
        /// -
        /// </summary>
        public float Height; 
        
        /// <summary>
        /// pname:minDepth and pname:maxDepth are the depth range for the
        /// viewport. It is valid for pname:minDepth to be greater than or
        /// equal to pname:maxDepth.
        /// </summary>
        public float MinDepth; 
        
        /// <summary>
        /// -
        /// </summary>
        public float MaxDepth; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Viewport");
            builder.AppendLine("{");
            builder.AppendLine($"X: {this.X}");
            builder.AppendLine($"Y: {this.Y}");
            builder.AppendLine($"Width: {this.Width}");
            builder.AppendLine($"Height: {this.Height}");
            builder.AppendLine($"MinDepth: {this.MinDepth}");
            builder.AppendLine($"MaxDepth: {this.MaxDepth}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
