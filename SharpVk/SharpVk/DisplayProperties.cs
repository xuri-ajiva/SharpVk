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
    /// Structure describing an available display device.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== For devices which have no natural value to return
    /// here, implementations should: return the maximum resolution supported.
    /// ====
    /// </para>
    /// <para>
    /// * pname:supportedTransforms tells which transforms are supported by
    /// this display. This will contain one or more of the bits from
    /// sname:VkSurfaceTransformFlagsKHR. * pname:planeReorderPossible tells
    /// whether the planes on this display can: have their z order changed. If
    /// this is ename:VK_TRUE, the application can: re-arrange the planes on
    /// this display in any order relative to each other. *
    /// pname:persistentContent tells whether the display supports
    /// self-refresh/internal buffering. If this is true, the application can:
    /// submit persistent present operations on swapchains created against this
    /// display.
    /// </para>
    /// <para>
    /// [NOTE] .Note ==== Persistent presents may: have higher latency, and
    /// may: use less power when the screen content is updated infrequently, or
    /// when only a portion of the screen needs to be updated in most frames.
    /// ====
    /// </para>
    /// </summary>
    public struct DisplayProperties
    {
        /// <summary>
        /// pname:display is a handle that is used to refer to the display
        /// described here. This handle will be valid for the lifetime of the
        /// Vulkan instance.
        /// </summary>
        public Display Display
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:displayName is a pointer to a NULL-terminated string
        /// containing the name of the display. Generally, this will be the
        /// name provided by the display's EDID. It can: be `NULL` if no
        /// suitable name is available.
        /// </summary>
        public string DisplayName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:physicalDimensions describes the physical width and height of
        /// the visible portion of the display, in millimeters.
        /// </summary>
        public Extent2D PhysicalDimensions
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:physicalResolution describes the physical, native, or
        /// preferred resolution of the display.
        /// </summary>
        public Extent2D PhysicalResolution
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public SurfaceTransformFlags SupportedTransforms
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 PlaneReorderPossible
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public Bool32 PersistentContent
        {
            get;
            set;
        }
        
        internal static unsafe DisplayProperties MarshalFrom(Interop.DisplayProperties* value)
        {
            DisplayProperties result = new DisplayProperties();
            result.DisplayName = Interop.HeapUtil.MarshalFrom(value->DisplayName);
            result.PhysicalDimensions = value->PhysicalDimensions;
            result.PhysicalResolution = value->PhysicalResolution;
            result.SupportedTransforms = value->SupportedTransforms;
            result.PlaneReorderPossible = value->PlaneReorderPossible;
            result.PersistentContent = value->PersistentContent;
            return result;
        }
    }
}
