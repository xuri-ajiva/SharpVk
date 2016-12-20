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
    /// Structure specifying parameters of a newly created Wayland surface
    /// object.
    /// </summary>
    public struct WaylandSurfaceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public WaylandSurfaceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:display and pname:surface are pointers to the Wayland
        /// code:wl_display and code:wl_surface to associate the surface with.
        /// </summary>
        public IntPtr Display
        {
            get;
            set;
        }
        
        /// <summary>
        /// -
        /// </summary>
        public IntPtr Surface
        {
            get;
            set;
        }
        
        internal unsafe Interop.WaylandSurfaceCreateInfo Pack()
        {
            Interop.WaylandSurfaceCreateInfo result = default(Interop.WaylandSurfaceCreateInfo);
            return result;
        }
        
        internal unsafe Interop.WaylandSurfaceCreateInfo* MarshalTo()
        {
            var result = (Interop.WaylandSurfaceCreateInfo*)Interop.HeapUtil.Allocate<Interop.WaylandSurfaceCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.WaylandSurfaceCreateInfo* pointer)
        {
            pointer->SType = StructureType.WaylandSurfaceCreateInfo;
            pointer->Flags = this.Flags;
            pointer->Display = this.Display;
            pointer->Surface = this.Surface;
        }
    }
}
