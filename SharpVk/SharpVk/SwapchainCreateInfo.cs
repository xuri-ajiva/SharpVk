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
    /// Structure specifying parameters of a newly created swapchain object.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Applications should: set this value to ename:VK_TRUE
    /// if they do not expect to read back the content of presentable images
    /// before presenting them or after reacquiring them and if their pixel
    /// shaders do not have any side effects that require them to run for all
    /// pixels in the presentable image. ====
    /// </para>
    /// <para>
    /// * pname:oldSwapchain, if not code:VK_NULL_HANDLE, specifies the
    /// swapchain that will be replaced by the new swapchain being created. The
    /// new swapchain will be a descendant of pname:oldSwapchain. Further, any
    /// descendants of the new swapchain will also be descendants of
    /// pname:oldSwapchain. Upon calling fname:vkCreateSwapchainKHR with a
    /// pname:oldSwapchain that is not code:VK_NULL_HANDLE, any images not
    /// acquired by the application may: be freed by the implementation, which
    /// may: occur even if creation of the new swapchain fails. The application
    /// must: destroy the old swapchain to free all memory associated with the
    /// old swapchain. The application must: wait for the completion of any
    /// outstanding rendering to images it currently has acquired at the time
    /// the swapchain is destroyed. The application can: continue to present
    /// any images it acquired and has not yet presented using the old
    /// swapchain, as long as it has not entered a state that causes it to
    /// return ename:VK_ERROR_OUT_OF_DATE_KHR. However, the application cannot:
    /// acquire any more images from the old swapchain regardless of whether or
    /// not creation of the new swapchain succeeds.
    /// </para>
    /// </summary>
    public struct SwapchainCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use, and must: be zero.
        /// </summary>
        public SwapchainCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:surface is the surface that the swapchain will present images
        /// to.
        /// </summary>
        public Surface Surface
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minImageCount is the minimum number of presentable images
        /// that the application needs. The platform will either create the
        /// swapchain with at least that many images, or will fail to create
        /// the swapchain.
        /// </summary>
        public uint MinImageCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageFormat is a slink:VkFormat that is valid for swapchains
        /// on the specified surface.
        /// </summary>
        public Format ImageFormat
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageColorSpace is a slink:VkColorSpaceKHR that is valid for
        /// swapchains on the specified surface.
        /// </summary>
        public ColorSpace ImageColorSpace
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageExtent is the size (in pixels) of the swapchain.
        /// Behavior is platform-dependent when the image extent does not match
        /// the surface's pname:currentExtent as returned by
        /// fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR.
        /// </summary>
        public Extent2D ImageExtent
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageArrayLayers is the number of views in a multiview/stereo
        /// surface. For non-stereoscopic-3D applications, this value is 1.
        /// </summary>
        public uint ImageArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageUsage is a bitmask of elink:VkImageUsageFlagBits,
        /// indicating how the application will use the swapchain's presentable
        /// images.
        /// </summary>
        public ImageUsageFlags ImageUsage
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:imageSharingMode is the sharing mode used for the images of
        /// the swapchain.
        /// </summary>
        public SharingMode ImageSharingMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pQueueFamilyIndices is an array of queue family indices
        /// having access to the images of the swapchain in case
        /// pname:imageSharingMode is ename:VK_SHARING_MODE_CONCURRENT.
        /// </summary>
        public uint[] QueueFamilyIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:preTransform is a bitmask of
        /// elink:VkSurfaceTransformFlagBitsKHR, describing the transform,
        /// relative to the presentation engine's natural orientation, applied
        /// to the image content prior to presentation. If it does not match
        /// the pname:currentTransform value returned by
        /// fname:vkGetPhysicalDeviceSurfaceCapabilitiesKHR, the presentation
        /// engine will transform the image content as part of the presentation
        /// operation.
        /// </summary>
        public SurfaceTransformFlags PreTransform
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:compositeAlpha is a bitmask of
        /// elink:VkCompositeAlphaFlagBitsKHR, indicating the alpha compositing
        /// mode to use when this surface is composited together with other
        /// surfaces on certain window systems.
        /// </summary>
        public CompositeAlphaFlags CompositeAlpha
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:presentMode is the presentation mode the swapchain will use.
        /// A swapchain's present mode determines how incoming present requests
        /// will be processed and queued internally.
        /// </summary>
        public PresentMode PresentMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:clipped indicates whether the Vulkan implementation is
        /// allowed to discard rendering operations that affect regions of the
        /// surface which are not visible.
        /// </summary>
        public Bool32 Clipped
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public Swapchain OldSwapchain
        {
            get;
            set;
        }
        
        internal unsafe Interop.SwapchainCreateInfo Pack()
        {
            Interop.SwapchainCreateInfo result = default(Interop.SwapchainCreateInfo);
            result.SType = StructureType.SwapchainCreateInfo;
            result.Surface = this.Surface?.Pack() ?? Interop.Surface.Null;
            result.QueueFamilyIndices = this.QueueFamilyIndices == null ? null : Interop.HeapUtil.MarshalTo(this.QueueFamilyIndices);
            result.OldSwapchain = this.OldSwapchain?.Pack() ?? Interop.Swapchain.Null;
            result.QueueFamilyIndexCount = (uint)(this.QueueFamilyIndices?.Length ?? 0);
            result.Flags = this.Flags;
            result.MinImageCount = this.MinImageCount;
            result.ImageFormat = this.ImageFormat;
            result.ImageColorSpace = this.ImageColorSpace;
            result.ImageExtent = this.ImageExtent;
            result.ImageArrayLayers = this.ImageArrayLayers;
            result.ImageUsage = this.ImageUsage;
            result.ImageSharingMode = this.ImageSharingMode;
            result.PreTransform = this.PreTransform;
            result.CompositeAlpha = this.CompositeAlpha;
            result.PresentMode = this.PresentMode;
            result.Clipped = this.Clipped;
            return result;
        }
        
        internal unsafe Interop.SwapchainCreateInfo* MarshalTo()
        {
            return (Interop.SwapchainCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
