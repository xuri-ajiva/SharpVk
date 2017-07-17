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
    /// Structure specifying a image subresource range.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ImageSubresourceRange
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageSubresourceRange(SharpVk.ImageAspectFlags aspectMask, uint baseMipLevel, uint levelCount, uint baseArrayLayer, uint layerCount)
        {
            this.AspectMask = aspectMask;
            this.BaseMipLevel = baseMipLevel;
            this.LevelCount = levelCount;
            this.BaseArrayLayer = baseArrayLayer;
            this.LayerCount = layerCount;
        }
        
        /// <summary>
        /// pname:aspectMask is a bitmask indicating which aspect(s) of the
        /// image are included in the view. See elink:VkImageAspectFlagBits.
        /// </summary>
        public SharpVk.ImageAspectFlags AspectMask; 
        
        /// <summary>
        /// pname:baseMipLevel is the first mipmap level accessible to the
        /// view.
        /// </summary>
        public uint BaseMipLevel; 
        
        /// <summary>
        /// pname:levelCount is the number of mipmap levels (starting from
        /// pname:baseMipLevel) accessible to the view.
        /// </summary>
        public uint LevelCount; 
        
        /// <summary>
        /// pname:baseArrayLayer is the first array layer accessible to the
        /// view.
        /// </summary>
        public uint BaseArrayLayer; 
        
        /// <summary>
        /// pname:layerCount is the number of array layers (starting from
        /// pname:baseArrayLayer) accessible to the view.
        /// </summary>
        public uint LayerCount; 
    }
}
