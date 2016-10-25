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
    /// Structure describing parameters of a queue presentation to a swapchain.
    /// </para>
    /// <para>
    /// If the extent of the pname:srcRect and pname:dstRect are not equal, the
    /// presented pixels will be scaled accordingly.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:srcRect must: specify a rectangular region
    /// that is a subset of the image being presented * pname:dstRect must:
    /// specify a rectangular region that is a subset of the
    /// pname:visibleRegion parameter of the display mode the swapchain being
    /// presented uses * If the pname:persistentContent member of the
    /// sname:VkDisplayPropertiesKHR structure returned by
    /// fname:vkGetPhysicalDeviceDisplayPropertiesKHR for the display the
    /// present operation targets then pname:persistent must: be ename:VK_FALSE
    /// ****
    /// </para>
    /// </summary>
    public struct DisplayPresentInfo
    {
        /// <summary>
        /// pname:srcRect is a rectangular region of pixels to present. It
        /// must: be a subset of the image being presented. If
        /// sname:VkDisplayPresentInfoKHR is not specified, this region will be
        /// assumed to be the entire presentable image.
        /// </summary>
        public Rect2D SourceRect
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dstRect is a rectangular region within the visible region of
        /// the swapchain's display mode. If sname:VkDisplayPresentInfoKHR is
        /// not specified, this region will be assumed to be the entire visible
        /// region of the visible region of the swapchain's mode. If the
        /// specified rectangle is a subset of the display mode's visible
        /// region, content from display planes below the swapchain's plane
        /// will be visible outside the rectangle. If there are no planes below
        /// the swapchain's, the area outside the specified rectangle will be
        /// black. If portions of the specified rectangle are outside of the
        /// display's visible region, pixels mapping only to those portions of
        /// the rectangle will be discarded.
        /// </summary>
        public Rect2D DestinationRect
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:persistent: If this is ename:VK_TRUE, the display engine will
        /// enable buffered mode on displays that support it. This allows the
        /// display engine to stop sending content to the display until a new
        /// image is presented. The display will instead maintain a copy of the
        /// last presented image. This allows less power to be used, but may:
        /// increase presentation latency. If sname:VkDisplayPresentInfoKHR is
        /// not specified, persistent mode will not be used.
        /// </summary>
        public Bool32 Persistent
        {
            get;
            set;
        }
        
        internal unsafe Interop.DisplayPresentInfo Pack()
        {
            Interop.DisplayPresentInfo result = default(Interop.DisplayPresentInfo);
            result.SType = StructureType.DisplayPresentInfo;
            result.SourceRect = this.SourceRect;
            result.DestinationRect = this.DestinationRect;
            result.Persistent = this.Persistent;
            return result;
        }
        
        internal unsafe Interop.DisplayPresentInfo* MarshalTo()
        {
            return (Interop.DisplayPresentInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
