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
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// Structure specifying an image resolve operation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ImageResolve
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageResolve(SharpVk.ImageSubresourceLayers sourceSubresource, SharpVk.Offset3D sourceOffset, SharpVk.ImageSubresourceLayers destinationSubresource, SharpVk.Offset3D destinationOffset, SharpVk.Extent3D extent)
        {
            this.SourceSubresource = sourceSubresource;
            this.SourceOffset = sourceOffset;
            this.DestinationSubresource = destinationSubresource;
            this.DestinationOffset = destinationOffset;
            this.Extent = extent;
        }
        
        /// <summary>
        /// srcSubresource and dstSubresource are ImageSubresourceLayers
        /// structures specifying the image subresources of the images used for
        /// the source and destination image data, respectively. Resolve of
        /// depth/stencil images is not supported.
        /// </summary>
        public SharpVk.ImageSubresourceLayers SourceSubresource; 
        
        /// <summary>
        /// srcOffset and dstOffset select the initial x, y, and z offsets in
        /// texels of the sub-regions of the source and destination image data.
        /// </summary>
        public SharpVk.Offset3D SourceOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageSubresourceLayers DestinationSubresource; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Offset3D DestinationOffset; 
        
        /// <summary>
        /// The size in texels of the source image to resolve in width, height
        /// and depth.
        /// </summary>
        public SharpVk.Extent3D Extent; 
    }
}
