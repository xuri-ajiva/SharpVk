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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Viewport
    {
        /// <summary>
        /// 
        /// </summary>
        public Viewport(float x, float y, float width, float height, float minDepth, float maxDepth)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.MinDepth = minDepth;
            this.MaxDepth = maxDepth;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public float X; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Y; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Width; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Height; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MinDepth; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxDepth; 
    }
}
