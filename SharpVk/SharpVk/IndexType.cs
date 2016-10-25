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
    /// Type of index buffer indices.
    /// </para>
    /// <para>
    /// .Valid Usage **** * pname:offset must: be less than the size of
    /// pname:buffer * The sum of pname:offset and the address of the range of
    /// sname:VkDeviceMemory object that is backing pname:buffer, must: be a
    /// multiple of the type indicated by pname:indexType * pname:buffer must:
    /// have been created with the ename:VK_BUFFER_USAGE_INDEX_BUFFER_BIT flag
    /// ****
    /// </para>
    /// </summary>
    public enum IndexType
    {
        /// <summary>
        /// -
        /// </summary>
        UInt16 = 0, 
        
        /// <summary>
        /// -
        /// </summary>
        UInt32 = 1, 
    }
}
