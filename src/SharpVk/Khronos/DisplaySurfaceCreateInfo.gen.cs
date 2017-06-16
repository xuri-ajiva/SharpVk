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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplaySurfaceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DisplaySurfaceCreateFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DisplayMode DisplayMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PlaneIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PlaneStackIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.SurfaceTransformFlags Transform
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float GlobalAlpha
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.DisplayPlaneAlphaFlags AlphaMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D ImageExtent
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.DisplaySurfaceCreateInfo* pointer)
        {
            pointer->SType = StructureType.DisplaySurfaceCreateInfoKhr;
            pointer->Next = null;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Khronos.DisplaySurfaceCreateFlags);
            }
            pointer->DisplayMode = this.DisplayMode?.handle ?? default(SharpVk.Interop.Khronos.DisplayMode);
            pointer->PlaneIndex = this.PlaneIndex;
            pointer->PlaneStackIndex = this.PlaneStackIndex;
            pointer->Transform = this.Transform;
            pointer->GlobalAlpha = this.GlobalAlpha;
            pointer->AlphaMode = this.AlphaMode;
            pointer->ImageExtent = this.ImageExtent;
        }
    }
}
