// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir & xuri 2021
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

using System.Runtime.InteropServices;

namespace SharpVk.NVidia
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceDeviceGeneratedCommandsProperties
    {
        /// <summary>
        /// </summary>
        public uint MaxGraphicsShaderGroupCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint MaxIndirectSequenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint MaxIndirectCommandsTokenCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint MaxIndirectCommandsStreamCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint MaxIndirectCommandsTokenOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint MaxIndirectCommandsStreamStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint MinSequencesCountBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint MinSequencesIndexBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint MinIndirectCommandsBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceDeviceGeneratedCommandsProperties MarshalFrom(SharpVk.Interop.NVidia.PhysicalDeviceDeviceGeneratedCommandsProperties* pointer)
        {
            PhysicalDeviceDeviceGeneratedCommandsProperties result = default;
            result.MaxGraphicsShaderGroupCount = pointer->MaxGraphicsShaderGroupCount;
            result.MaxIndirectSequenceCount = pointer->MaxIndirectSequenceCount;
            result.MaxIndirectCommandsTokenCount = pointer->MaxIndirectCommandsTokenCount;
            result.MaxIndirectCommandsStreamCount = pointer->MaxIndirectCommandsStreamCount;
            result.MaxIndirectCommandsTokenOffset = pointer->MaxIndirectCommandsTokenOffset;
            result.MaxIndirectCommandsStreamStride = pointer->MaxIndirectCommandsStreamStride;
            result.MinSequencesCountBufferOffsetAlignment = pointer->MinSequencesCountBufferOffsetAlignment;
            result.MinSequencesIndexBufferOffsetAlignment = pointer->MinSequencesIndexBufferOffsetAlignment;
            result.MinIndirectCommandsBufferOffsetAlignment = pointer->MinIndirectCommandsBufferOffsetAlignment;
            return result;
        }
    }
}
