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

namespace SharpVk.Khr
{
    /// <summary>
    /// 
    /// </summary>
    public struct DisplaySurfaceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khr.DisplaySurfaceCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Khr.DisplayMode DisplayMode
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
        public SharpVk.Khr.SurfaceTransformFlags Transform
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
        public SharpVk.Khr.DisplayPlaneAlphaFlags AlphaMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D ImageExtent
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.Khr.DisplaySurfaceCreateInfo* pointer)
        {
            pointer->SType = StructureType.DisplaySurfaceCreateInfoKhr;
            pointer->Next = null;
            pointer->Flags = this.Flags;
            pointer->DisplayMode = this.DisplayMode.handle;
            pointer->PlaneIndex = this.PlaneIndex;
            pointer->PlaneStackIndex = this.PlaneStackIndex;
            pointer->Transform = this.Transform;
            pointer->GlobalAlpha = this.GlobalAlpha;
            pointer->AlphaMode = this.AlphaMode;
            pointer->ImageExtent = this.ImageExtent;
        }
    }
}
