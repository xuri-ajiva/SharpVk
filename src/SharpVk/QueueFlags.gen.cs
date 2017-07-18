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

namespace SharpVk
{
    /// <summary>
    /// Bitmask specifying capabilities of queues in a queue family.
    /// </summary>
    [System.Flags]
    public enum QueueFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// if ename:VK_QUEUE_GRAPHICS_BIT is set, then the queues in this
        /// queue family support graphics operations.
        /// </summary>
        Graphics = 1 << 0, 
        
        /// <summary>
        /// if ename:VK_QUEUE_COMPUTE_BIT is set, then the queues in this queue
        /// family support compute operations.
        /// </summary>
        Compute = 1 << 1, 
        
        /// <summary>
        /// if ename:VK_QUEUE_TRANSFER_BIT is set, then the queues in this
        /// queue family support transfer operations.
        /// </summary>
        Transfer = 1 << 2, 
        
        /// <summary>
        /// if ename:VK_QUEUE_SPARSE_BINDING_BIT is set, then the queues in
        /// this queue family support sparse memory management operations (see
        /// &lt;&lt;sparsememory,Sparse Resources&gt;&gt;). If any of the
        /// sparse resource features are enabled, then at least one queue
        /// family must: support this bit.
        /// </summary>
        SparseBinding = 1 << 3, 
    }
}
