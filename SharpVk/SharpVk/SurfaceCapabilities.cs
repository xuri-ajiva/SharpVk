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
    /// Structure describing capabilities of a surface.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Formulas such as [eq]#min(N, pname:maxImageCount)#
    /// are not correct, since pname:maxImageCount may: be zero. ====
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SurfaceCapabilities
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
        /// pname:minImageCount is the minimum number of images the specified
        /// device supports for a swapchain created for the surface, and will
        /// be at least one.
        /// </summary>
        public uint MinImageCount; 
        
        /// <summary>
        /// pname:maxImageCount is the maximum number of images the specified
        /// device supports for a swapchain created for the surface, and will
        /// be either 0, or greater than or equal to pname:minImageCount. A
        /// value of 0 means that there is no limit on the number of images,
        /// though there may: be limits related to the total amount of memory
        /// used by swapchain images.
        /// </summary>
        public uint MaxImageCount; 
        
        /// <summary>
        /// pname:currentExtent is the current width and height of the surface,
        /// or the special value [eq]#(0xFFFFFFFF, 0xFFFFFFFF)# indicating that
        /// the surface size will be determined by the extent of a swapchain
        /// targeting the surface.
        /// </summary>
        public Extent2D CurrentExtent; 
        
        /// <summary>
        /// pname:minImageExtent contains the smallest valid swapchain extent
        /// for the surface on the specified device. The pname:width and
        /// pname:height of the extent will each be less than or equal to the
        /// corresponding pname:width and pname:height of pname:currentExtent,
        /// unless pname:currentExtent has the special value described above.
        /// </summary>
        public Extent2D MinImageExtent; 
        
        /// <summary>
        /// pname:maxImageExtent contains the largest valid swapchain extent
        /// for the surface on the specified device. The pname:width and
        /// pname:height of the extent will each be greater than or equal to
        /// the corresponding pname:width and pname:height of
        /// pname:minImageExtent. The pname:width and pname:height of the
        /// extent will each be greater than or equal to the corresponding
        /// pname:width and pname:height of pname:currentExtent, unless
        /// pname:currentExtent has the special value described above.
        /// </summary>
        public Extent2D MaxImageExtent; 
        
        /// <summary>
        /// pname:maxImageArrayLayers is the maximum number of layers swapchain
        /// images can: have for a swapchain created for this device and
        /// surface, and will be at least one.
        /// </summary>
        public uint MaxImageArrayLayers; 
        
        /// <summary>
        /// pname:supportedTransforms is a bitmask of
        /// elink:VkSurfaceTransformFlagBitsKHR, describing the presentation
        /// transforms supported for the surface on the specified device, and
        /// at least one bit will be set.
        /// </summary>
        public SurfaceTransformFlags SupportedTransforms; 
        
        /// <summary>
        /// pname:currentTransform is the surface's current transform relative
        /// to the presentation engine's natural orientation, as described by
        /// elink:VkSurfaceTransformFlagBitsKHR.
        /// </summary>
        public SurfaceTransformFlags CurrentTransform; 
        
        /// <summary>
        /// pname:supportedCompositeAlpha is a bitmask of
        /// elink:VkCompositeAlphaFlagBitsKHR, representing the alpha
        /// compositing modes supported by the presentation engine for the
        /// surface on the specified device, and at least one bit will be set.
        /// Opaque composition can: be achieved in any alpha compositing mode
        /// by either using a swapchain image format that has no alpha
        /// component, or by ensuring that all pixels in the swapchain images
        /// have an alpha value of 1.0.
        /// </summary>
        public CompositeAlphaFlags SupportedCompositeAlpha; 
        
        /// <summary>
        /// pname:supportedUsageFlags is a bitmask of
        /// elink:VkImageUsageFlagBits representing the ways the application
        /// can: use the presentable images of a swapchain created for the
        /// surface on the specified device.
        /// ename:VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT must: be included in the
        /// set but implementations may: support additional usages.
        /// </summary>
        public ImageUsageFlags SupportedUsageFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("SurfaceCapabilities");
            builder.AppendLine("{");
            builder.AppendLine($"MinImageCount: {this.MinImageCount}");
            builder.AppendLine($"MaxImageCount: {this.MaxImageCount}");
            builder.AppendLine($"CurrentExtent: {this.CurrentExtent}");
            builder.AppendLine($"MinImageExtent: {this.MinImageExtent}");
            builder.AppendLine($"MaxImageExtent: {this.MaxImageExtent}");
            builder.AppendLine($"MaxImageArrayLayers: {this.MaxImageArrayLayers}");
            builder.AppendLine($"SupportedTransforms: {this.SupportedTransforms}");
            builder.AppendLine($"CurrentTransform: {this.CurrentTransform}");
            builder.AppendLine($"SupportedCompositeAlpha: {this.SupportedCompositeAlpha}");
            builder.AppendLine($"SupportedUsageFlags: {this.SupportedUsageFlags}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
