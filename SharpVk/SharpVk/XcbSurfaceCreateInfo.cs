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
    /// Structure specifying parameters of a newly created Xcb surface object.
    /// </summary>
    public struct XcbSurfaceCreateInfo
    {
        /// <summary>
        /// pname:flags is reserved for future use.
        /// </summary>
        public XcbSurfaceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:connection is a pointer to an code:xcb_connection_t to the X
        /// server.
        /// </summary>
        public IntPtr Connection
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:window is the code:xcb_window_t for the X11 window to
        /// associate the surface with.
        /// </summary>
        public IntPtr Window
        {
            get;
            set;
        }
        
        internal unsafe Interop.XcbSurfaceCreateInfo* MarshalTo()
        {
            var result = (Interop.XcbSurfaceCreateInfo*)Interop.HeapUtil.AllocateAndClear<Interop.XcbSurfaceCreateInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.XcbSurfaceCreateInfo* pointer)
        {
            pointer->SType = StructureType.XcbSurfaceCreateInfo;
            pointer->Connection = (IntPtr*)Interop.HeapUtil.Allocate<IntPtr>();
            *pointer->Connection = this.Connection;
            pointer->Flags = this.Flags;
            pointer->Window = this.Window;
        }
    }
}
