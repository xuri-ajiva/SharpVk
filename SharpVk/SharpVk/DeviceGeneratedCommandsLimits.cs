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
    /// Structure specifying physical device limits.
    /// </summary>
    public struct DeviceGeneratedCommandsLimits
    {
        /// <summary>
        /// pname:maxIndirectCommandsLayoutTokenCount the maximum number of
        /// tokens in sname:VkIndirectCommandsLayoutNVX.
        /// </summary>
        public uint MaxIndirectCommandsLayoutTokenCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:maxObjectEntryCounts the maximum number of entries per
        /// resource type in sname:VkObjectTableNVX.
        /// </summary>
        public uint MaxObjectEntryCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minSequenceCountBufferOffsetAlignment the minimum alignment
        /// for memory addresses optionally used in
        /// fname:vkCmdProcessCommandsNVX.
        /// </summary>
        public uint MinSequenceCountBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minSequenceIndexBufferOffsetAlignment the minimum alignment
        /// for memory addresses optionally used in
        /// fname:vkCmdProcessCommandsNVX.
        /// </summary>
        public uint MinSequenceIndexBufferOffsetAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:minCommandsTokenBufferOffsetAlignment the minimum alignment
        /// for memory addresses optionally used in
        /// fname:vkCmdProcessCommandsNVX.
        /// </summary>
        public uint MinCommandsTokenBufferOffsetAlignment
        {
            get;
            set;
        }
        
        internal static unsafe DeviceGeneratedCommandsLimits MarshalFrom(Interop.DeviceGeneratedCommandsLimits* value)
        {
            DeviceGeneratedCommandsLimits result = new DeviceGeneratedCommandsLimits();
            result.MaxIndirectCommandsLayoutTokenCount = value->MaxIndirectCommandsLayoutTokenCount;
            result.MaxObjectEntryCounts = value->MaxObjectEntryCounts;
            result.MinSequenceCountBufferOffsetAlignment = value->MinSequenceCountBufferOffsetAlignment;
            result.MinSequenceIndexBufferOffsetAlignment = value->MinSequenceIndexBufferOffsetAlignment;
            result.MinCommandsTokenBufferOffsetAlignment = value->MinCommandsTokenBufferOffsetAlignment;
            return result;
        }
    }
}
