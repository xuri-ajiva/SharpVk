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
    /// Structure specifying parameters of a newly created Xlib surface object.
    /// </summary>
    public struct XlibSurfaceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public XlibSurfaceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:dpy is a pointer to an Xlib code:Display connection to the X
        /// server.
        /// </summary>
        public IntPtr Dpy
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:window is an Xlib code:Window to associate the surface with.
        /// </summary>
        public IntPtr Window
        {
            get;
            set;
        }
        
        internal unsafe Interop.XlibSurfaceCreateInfo Pack()
        {
            Interop.XlibSurfaceCreateInfo result = default(Interop.XlibSurfaceCreateInfo);
            result.SType = StructureType.XlibSurfaceCreateInfo;
            result.Dpy = (IntPtr*)Interop.HeapUtil.AllocateAndMarshal(this.Dpy);
            result.Flags = this.Flags;
            result.Window = this.Window;
            return result;
        }
        
        internal unsafe Interop.XlibSurfaceCreateInfo* MarshalTo()
        {
            return (Interop.XlibSurfaceCreateInfo*)Interop.HeapUtil.AllocateAndMarshal(this.Pack()).ToPointer();
        }
    }
}
