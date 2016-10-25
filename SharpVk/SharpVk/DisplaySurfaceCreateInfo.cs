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
    /// Structure specifying parameters of a newly created display plane
    /// surface object.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Creating a display surface must: not modify the state
    /// of the displays, planes, or other resources it names. For example, it
    /// must: not apply the specified mode to be set on the associated display.
    /// Application of display configuration occurs as a side effect of
    /// presenting to a display surface. ====
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:planeIndex must: be less than the number of
    /// display planes supported by the device as determined by calling
    /// fname:vkGetPhysicalDeviceDisplayPlanePropertiesKHR * If the
    /// pname:planeReorderPossible member of the sname:VkDisplayPropertiesKHR
    /// structure returned by fname:vkGetPhysicalDeviceDisplayPropertiesKHR for
    /// the display corresponding to pname:displayMode is ename:VK_TRUE then
    /// pname:planeStackIndex must: be less than the number of display planes
    /// supported by the device as determined by calling
    /// fname:vkGetPhysicalDeviceDisplayPlanePropertiesKHR; otherwise
    /// pname:planeStackIndex must: equal the pname:currentStackIndex member of
    /// sname:VkDisplayPlanePropertiesKHR returned by
    /// fname:vkGetPhysicalDeviceDisplayPlanePropertiesKHR for the display
    /// plane corresponding to pname:displayMode * If pname:alphaMode is
    /// ename:VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR then pname:globalAlpha
    /// must: be between `0` and `1`, inclusive * pname:alphaMode must: be `0`
    /// or one of the bits present in the pname:supportedAlpha member of
    /// sname:VkDisplayPlaneCapabilitiesKHR returned by
    /// fname:vkGetDisplayPlaneCapabilitiesKHR for the display plane
    /// corresponding to pname:displayMode * The pname:width and pname:height
    /// members of pname:imageExtent must: be less than the
    /// pname:maxImageDimensions2D member of sname:VkPhysicalDeviceLimits ****
    /// </para>
    /// </summary>
    public struct DisplaySurfaceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use, and must: be zero.
        /// </summary>
        public DisplaySurfaceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:displayMode is the mode to use when displaying this surface.
        /// </summary>
        public DisplayMode DisplayMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:planeIndex is the plane on which this surface appears.
        /// </summary>
        public uint PlaneIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:planeStackIndex is the z-order of the plane.
        /// </summary>
        public uint PlaneStackIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:transform is the transform to apply to the images as part of
        /// the scanout operation.
        /// </summary>
        public SurfaceTransformFlags Transform
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:globalAlpha is the global alpha value. This value is ignored
        /// if pname:alphaMode is not
        /// ename:VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR.
        /// </summary>
        public float GlobalAlpha
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:alphaMode is the type of alpha blending to use.
        /// </summary>
        public DisplayPlaneAlphaFlags AlphaMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public Extent2D ImageExtent
        {
            get;
            set;
        }
        
        internal unsafe Interop.DisplaySurfaceCreateInfo Pack()
        {
            Interop.DisplaySurfaceCreateInfo result = default(Interop.DisplaySurfaceCreateInfo);
            result.SType = StructureType.DisplaySurfaceCreateInfo;
            result.DisplayMode = this.DisplayMode?.Pack() ?? Interop.DisplayMode.Null;
            result.Flags = this.Flags;
            result.PlaneIndex = this.PlaneIndex;
            result.PlaneStackIndex = this.PlaneStackIndex;
            result.Transform = this.Transform;
            result.GlobalAlpha = this.GlobalAlpha;
            result.AlphaMode = this.AlphaMode;
            result.ImageExtent = this.ImageExtent;
            return result;
        }
        
        internal unsafe Interop.DisplaySurfaceCreateInfo* MarshalTo()
        {
            return (Interop.DisplaySurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
