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

namespace SharpVk.Amd
{
    /// <summary>
    /// 
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// Perform an indirect draw with the draw count sourced from a buffer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void DrawIndirectCount(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer buffer, DeviceSize offset, SharpVk.Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Amd.VkCommandBufferDrawIndirectCountDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Amd.VkCommandBufferDrawIndirectCountDelegate>("vkCmdDrawIndirectCountAMD", "instance");
                commandDelegate(extendedHandle.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, countBuffer?.handle ?? default(SharpVk.Interop.Buffer), countBufferOffset, maxDrawCount, stride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Perform an indexed indirect draw with the draw count sourced from a
        /// buffer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void DrawIndexedIndirectCount(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer buffer, DeviceSize offset, SharpVk.Buffer countBuffer, DeviceSize countBufferOffset, uint maxDrawCount, uint stride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Amd.VkCommandBufferDrawIndexedIndirectCountDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Amd.VkCommandBufferDrawIndexedIndirectCountDelegate>("vkCmdDrawIndexedIndirectCountAMD", "instance");
                commandDelegate(extendedHandle.handle, buffer?.handle ?? default(SharpVk.Interop.Buffer), offset, countBuffer?.handle ?? default(SharpVk.Interop.Buffer), countBufferOffset, maxDrawCount, stride);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
