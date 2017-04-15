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
    /// 
    /// </summary>
    public enum AccessFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        IndirectCommandRead = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        IndexRead = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexAttributeRead = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        UniformRead = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        InputAttachmentRead = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderRead = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderWrite = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentRead = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentWrite = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencilAttachmentRead = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencilAttachmentWrite = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        TransferRead = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        TransferWrite = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        HostRead = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        HostWrite = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryRead = 1 << 15, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryWrite = 1 << 16, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandProcessReadBitNvx = 1 << 17, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandProcessWriteBitNvx = 1 << 18, 
    }
}
