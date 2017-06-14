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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayPlaneCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public DisplayPlaneCapabilities(SharpVk.Khronos.DisplayPlaneAlphaFlags supportedAlpha, SharpVk.Offset2D minSourcePosition, SharpVk.Offset2D maxSourcePosition, SharpVk.Extent2D minSourceExtent, SharpVk.Extent2D maxSourceExtent, SharpVk.Offset2D minDestinationPosition, SharpVk.Offset2D maxDestinationPosition, SharpVk.Extent2D minDestinationExtent, SharpVk.Extent2D maxDestinationExtent)
        {
            this.SupportedAlpha = supportedAlpha;
            this.MinSourcePosition = minSourcePosition;
            this.MaxSourcePosition = maxSourcePosition;
            this.MinSourceExtent = minSourceExtent;
            this.MaxSourceExtent = maxSourceExtent;
            this.MinDestinationPosition = minDestinationPosition;
            this.MaxDestinationPosition = maxDestinationPosition;
            this.MinDestinationExtent = minDestinationExtent;
            this.MaxDestinationExtent = maxDestinationExtent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DisplayPlaneAlphaFlags SupportedAlpha; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Offset2D MinSourcePosition; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Offset2D MaxSourcePosition; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MinSourceExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MaxSourceExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Offset2D MinDestinationPosition; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Offset2D MaxDestinationPosition; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MinDestinationExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MaxDestinationExtent; 
    }
}
