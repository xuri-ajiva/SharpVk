// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2019
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

namespace SharpVk.Intel
{
    /// <summary>
    /// 
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// Set markers into the command buffer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="markerInfo">
        /// The performance markers to set.
        /// </param>
        public static unsafe void SetPerformanceMarker(this SharpVk.CommandBuffer extendedHandle, SharpVk.Intel.PerformanceMarkerInfo markerInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Intel.PerformanceMarkerInfo* marshalledMarkerInfo = default(SharpVk.Interop.Intel.PerformanceMarkerInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledMarkerInfo = (SharpVk.Interop.Intel.PerformanceMarkerInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Intel.PerformanceMarkerInfo>());
                markerInfo.MarshalTo(marshalledMarkerInfo);
                SharpVk.Interop.Intel.VkCommandBufferSetPerformanceMarkerDelegate commandDelegate = commandCache.Cache.vkCmdSetPerformanceMarkerINTEL;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledMarkerInfo);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void SetPerformanceStreamMarker(this SharpVk.CommandBuffer extendedHandle, SharpVk.Intel.PerformanceStreamMarkerInfo markerInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Intel.PerformanceStreamMarkerInfo* marshalledMarkerInfo = default(SharpVk.Interop.Intel.PerformanceStreamMarkerInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledMarkerInfo = (SharpVk.Interop.Intel.PerformanceStreamMarkerInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Intel.PerformanceStreamMarkerInfo>());
                markerInfo.MarshalTo(marshalledMarkerInfo);
                SharpVk.Interop.Intel.VkCommandBufferSetPerformanceStreamMarkerDelegate commandDelegate = commandCache.Cache.vkCmdSetPerformanceStreamMarkerINTEL;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledMarkerInfo);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void SetPerformanceOverride(this SharpVk.CommandBuffer extendedHandle, SharpVk.Intel.PerformanceOverrideInfo overrideInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Intel.PerformanceOverrideInfo* marshalledOverrideInfo = default(SharpVk.Interop.Intel.PerformanceOverrideInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledOverrideInfo = (SharpVk.Interop.Intel.PerformanceOverrideInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Intel.PerformanceOverrideInfo>());
                overrideInfo.MarshalTo(marshalledOverrideInfo);
                SharpVk.Interop.Intel.VkCommandBufferSetPerformanceOverrideDelegate commandDelegate = commandCache.Cache.vkCmdSetPerformanceOverrideINTEL;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledOverrideInfo);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
