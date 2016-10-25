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
    /// Structure describing capabilities of a mode and plane combination.
    /// </para>
    /// <para>
    /// The minimum and maximum position and extent fields describe the
    /// hardware limits, if any, as they apply to the specified display mode
    /// and plane. Vendors may: support displaying a subset of a swapchain's
    /// presentable images on the specified display plane. This is expressed by
    /// returning pname:minSrcPosition, pname:maxSrcPosition,
    /// pname:minSrcExtent, and pname:maxSrcExtent values that indicate a range
    /// of possible positions and sizes may: be used to specify the region
    /// within the presentable images that source pixels will be read from when
    /// creating a swapchain on the specified display mode and plane.
    /// </para>
    /// <para>
    /// Vendors may: also support mapping the presentable images' content to a
    /// subset or superset of the visible region in the specified display mode.
    /// This is expressed by returning pname:minDstPosition,
    /// pname:maxDstPosition, pname:minDstExtent and pname:maxDstExtent values
    /// that indicate a range of possible positions and sizes may: be used to
    /// describe the region within the display mode that the source pixels will
    /// be mapped to.
    /// </para>
    /// <para>
    /// Other vendors may: support only a 1-1 mapping between pixels in the
    /// presentable images and the display mode. This may: be indicated by
    /// returning [eq]#(0,0)# for pname:minSrcPosition, pname:maxSrcPosition,
    /// pname:minDstPosition, and pname:maxDstPosition, and (display mode
    /// width, display mode height) for pname:minSrcExtent, pname:maxSrcExtent,
    /// pname:minDstExtent, and pname:maxDstExtent.
    /// </para>
    /// <para>
    /// These values indicate the limits of the hardware's individual fields.
    /// Not all combinations of values within the offset and extent ranges
    /// returned in sname:VkDisplayPlaneCapabilitiesKHR are guaranteed to be
    /// supported. Vendors may: still fail presentation requests that specify
    /// unsupported combinations.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DisplayPlaneCapabilities
    {
        /// <summary>
        /// pname:supportedAlpha is a bitmask of
        /// elink:VkDisplayPlaneAlphaFlagBitsKHR describing the supported alpha
        /// blending modes.
        /// </summary>
        public DisplayPlaneAlphaFlags SupportedAlpha; 
        
        /// <summary>
        /// pname:minSrcPosition is the minimum source rectangle offset
        /// supported by this plane using the specified mode.
        /// </summary>
        public Offset2D MinSourcePosition; 
        
        /// <summary>
        /// pname:maxSrcPosition is the maximum source rectangle offset
        /// supported by this plane using the specified mode. The pname:x and
        /// pname:y components of pname:maxSrcPosition must: each be greater
        /// than or equal to the pname:x and pname:y components of
        /// pname:minSrcPosition, respectively.
        /// </summary>
        public Offset2D MaxSourcePosition; 
        
        /// <summary>
        /// pname:minSrcExtent is the minimum source rectangle size supported
        /// by this plane using the specified mode.
        /// </summary>
        public Extent2D MinSourceExtent; 
        
        /// <summary>
        /// pname:maxSrcExtent is the maximum source rectangle size supported
        /// by this plane using the specified mode.
        /// </summary>
        public Extent2D MaxSourceExtent; 
        
        /// <summary>
        /// pname:minDstPosition, pname:maxDstPosition, pname:minDstExtent,
        /// pname:maxDstExtent all have similar semantics to their
        /// corresponding "Src" equivalents, but apply to the output region
        /// within the mode rather than the input region within the source
        /// image. Unlike the "Src" offsets, pname:minDstPosition and
        /// pname:maxDstPosition may: contain negative values.
        /// </summary>
        public Offset2D MinDestinationPosition; 
        
        /// <summary>
        /// -
        /// </summary>
        public Offset2D MaxDestinationPosition; 
        
        /// <summary>
        /// -
        /// </summary>
        public Extent2D MinDestinationExtent; 
        
        /// <summary>
        /// -
        /// </summary>
        public Extent2D MaxDestinationExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("DisplayPlaneCapabilities");
            builder.AppendLine("{");
            builder.AppendLine($"SupportedAlpha: {this.SupportedAlpha}");
            builder.AppendLine($"MinSourcePosition: {this.MinSourcePosition}");
            builder.AppendLine($"MaxSourcePosition: {this.MaxSourcePosition}");
            builder.AppendLine($"MinSourceExtent: {this.MinSourceExtent}");
            builder.AppendLine($"MaxSourceExtent: {this.MaxSourceExtent}");
            builder.AppendLine($"MinDestinationPosition: {this.MinDestinationPosition}");
            builder.AppendLine($"MaxDestinationPosition: {this.MaxDestinationPosition}");
            builder.AppendLine($"MinDestinationExtent: {this.MinDestinationExtent}");
            builder.AppendLine($"MaxDestinationExtent: {this.MaxDestinationExtent}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
