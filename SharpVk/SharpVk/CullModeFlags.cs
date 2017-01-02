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

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Bitmask controlling triangle culling.
    /// </para>
    /// <para>
    /// If the pname:cullMode is set to ename:VK_CULL_MODE_NONE no triangles
    /// are discarded, if it is set to ename:VK_CULL_MODE_FRONT_BIT
    /// front-facing triangles are discarded, if it is set to
    /// ename:VK_CULL_MODE_BACK_BIT then back-facing triangles are discarded
    /// and if it is set to ename:VK_CULL_MODE_FRONT_AND_BACK then all
    /// triangles are discarded. Following culling, fragments are produced for
    /// any triangles which have not been discarded.
    /// </para>
    /// </summary>
    [Flags]
    public enum CullModeFlags
    {
        /// <summary>
        /// -
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Front = 1 << 0, 
        
        /// <summary>
        /// -
        /// </summary>
        Back = 1 << 1, 
        
        /// <summary>
        /// -
        /// </summary>
        FrontAndBack = 0x00000003, 
    }
}
