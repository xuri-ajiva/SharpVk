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
    /// Structure specifying a clear rectangle.
    /// </para>
    /// <para>
    /// The layers [eq]#[pname:baseArrayLayer, pname:baseArrayLayer {plus}
    /// pname:layerCount)# counting from the base layer of the attachment image
    /// view are cleared.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ClearRect
    {
        /// <summary>
        /// 
        /// </summary>
        public ClearRect(Rect2D rect, uint baseArrayLayer, uint layerCount)
        {
            this.Rect = rect;
            this.BaseArrayLayer = baseArrayLayer;
            this.LayerCount = layerCount;
        }
        
        /// <summary>
        /// pname:rect is the two-dimensional region to be cleared.
        /// </summary>
        public Rect2D Rect; 
        
        /// <summary>
        /// pname:baseArrayLayer is the first layer to be cleared.
        /// </summary>
        public uint BaseArrayLayer; 
        
        /// <summary>
        /// pname:layerCount is the number of layers to clear.
        /// </summary>
        public uint LayerCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("ClearRect");
            builder.AppendLine("{");
            builder.AppendLine($"Rect: {this.Rect}");
            builder.AppendLine($"BaseArrayLayer: {this.BaseArrayLayer}");
            builder.AppendLine($"LayerCount: {this.LayerCount}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
