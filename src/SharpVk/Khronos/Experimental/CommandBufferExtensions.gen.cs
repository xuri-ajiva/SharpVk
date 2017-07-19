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

namespace SharpVk.Khronos.Experimental
{
    /// <summary>
    /// 
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// Modify device mask of a command buffer.
        /// </summary>
        public static unsafe void SetDeviceMask(this SharpVk.CommandBuffer extendedHandle, uint deviceMask)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.Experimental.VkCommandBufferSetDeviceMaskDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkCommandBufferSetDeviceMaskDelegate>("vkCmdSetDeviceMaskKHX", "instance");
                commandDelegate(extendedHandle.handle, deviceMask);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Dispatch compute work items.
        /// </summary>
        public static unsafe void DispatchBase(this SharpVk.CommandBuffer extendedHandle, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.Experimental.VkCommandBufferDispatchBaseDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.Experimental.VkCommandBufferDispatchBaseDelegate>("vkCmdDispatchBaseKHX", "instance");
                commandDelegate(extendedHandle.handle, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
