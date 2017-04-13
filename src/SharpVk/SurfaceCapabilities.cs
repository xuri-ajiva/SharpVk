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
    /// 
    /// </summary>
    public struct SurfaceCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public SurfaceCapabilities(uint minImageCount, uint maxImageCount, Extent2D currentExtent, Extent2D minImageExtent, Extent2D maxImageExtent, uint maxImageArrayLayers, SurfaceTransformFlags supportedTransforms, SurfaceTransformFlags currentTransform, CompositeAlphaFlags supportedCompositeAlpha, ImageUsageFlags supportedUsageFlags)
        {
            this.MinImageCount = minImageCount;
            this.MaxImageCount = maxImageCount;
            this.CurrentExtent = currentExtent;
            this.MinImageExtent = minImageExtent;
            this.MaxImageExtent = maxImageExtent;
            this.MaxImageArrayLayers = maxImageArrayLayers;
            this.SupportedTransforms = supportedTransforms;
            this.CurrentTransform = currentTransform;
            this.SupportedCompositeAlpha = supportedCompositeAlpha;
            this.SupportedUsageFlags = supportedUsageFlags;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinImageCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D CurrentExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D MinImageExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D MaxImageExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxImageArrayLayers; 
        
        /// <summary>
        /// 
        /// </summary>
        public SurfaceTransformFlags SupportedTransforms; 
        
        /// <summary>
        /// 
        /// </summary>
        public SurfaceTransformFlags CurrentTransform; 
        
        /// <summary>
        /// 
        /// </summary>
        public CompositeAlphaFlags SupportedCompositeAlpha; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageUsageFlags SupportedUsageFlags; 
    }
}
