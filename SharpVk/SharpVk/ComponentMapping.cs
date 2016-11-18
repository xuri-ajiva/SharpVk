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
using System.Runtime.InteropServices;
using System.Text;

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure specifying a color component mapping.
    /// </para>
    /// <para>
    /// Each of pname:r, pname:g, pname:b, and pname:a is one of the values:
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ComponentMapping
    {
        /// <summary>
        /// 
        /// </summary>
        public ComponentMapping(ComponentSwizzle r, ComponentSwizzle g, ComponentSwizzle b, ComponentSwizzle a)
        {
            this.R = r;
            this.G = g;
            this.B = b;
            this.A = a;
        }
        
        /// <summary>
        /// pname:r determines the component value placed in the R component of
        /// the output vector.
        /// </summary>
        public ComponentSwizzle R; 
        
        /// <summary>
        /// pname:g determines the component value placed in the G component of
        /// the output vector.
        /// </summary>
        public ComponentSwizzle G; 
        
        /// <summary>
        /// pname:b determines the component value placed in the B component of
        /// the output vector.
        /// </summary>
        public ComponentSwizzle B; 
        
        /// <summary>
        /// pname:a determines the component value placed in the A component of
        /// the output vector.
        /// </summary>
        public ComponentSwizzle A; 
        
        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("ComponentMapping");
            builder.AppendLine("{");
            builder.AppendLine($"R: {this.R}");
            builder.AppendLine($"G: {this.G}");
            builder.AppendLine($"B: {this.B}");
            builder.AppendLine($"A: {this.A}");
            builder.Append("}");
            return builder.ToString();
        }
    }
}
