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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// Open a command buffer marker region.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void DebugMarkerBegin(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.DebugMarkerMarkerInfo markerInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugMarkerMarkerInfo* marshalledMarkerInfo = default(SharpVk.Interop.Multivendor.DebugMarkerMarkerInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledMarkerInfo = (SharpVk.Interop.Multivendor.DebugMarkerMarkerInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugMarkerMarkerInfo>());
                markerInfo.MarshalTo(marshalledMarkerInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferDebugMarkerBeginDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Multivendor.VkCommandBufferDebugMarkerBeginDelegate>("vkCmdDebugMarkerBeginEXT", "instance");
                commandDelegate(extendedHandle.handle, marshalledMarkerInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Close a command buffer marker region.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void DebugMarkerEnd(this SharpVk.CommandBuffer extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkCommandBufferDebugMarkerEndDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Multivendor.VkCommandBufferDebugMarkerEndDelegate>("vkCmdDebugMarkerEndEXT", "instance");
                commandDelegate(extendedHandle.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Insert a marker label into a command buffer.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void DebugMarkerInsert(this SharpVk.CommandBuffer extendedHandle, SharpVk.Multivendor.DebugMarkerMarkerInfo markerInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugMarkerMarkerInfo* marshalledMarkerInfo = default(SharpVk.Interop.Multivendor.DebugMarkerMarkerInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledMarkerInfo = (SharpVk.Interop.Multivendor.DebugMarkerMarkerInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugMarkerMarkerInfo>());
                markerInfo.MarshalTo(marshalledMarkerInfo);
                SharpVk.Interop.Multivendor.VkCommandBufferDebugMarkerInsertDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Multivendor.VkCommandBufferDebugMarkerInsertDelegate>("vkCmdDebugMarkerInsertEXT", "instance");
                commandDelegate(extendedHandle.handle, marshalledMarkerInfo);
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
        public static unsafe void SetDiscardRectangle(this SharpVk.CommandBuffer extendedHandle, uint firstDiscardRectangle, SharpVk.Rect2D[] discardRectangles)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Rect2D* marshalledDiscardRectangles = default(SharpVk.Rect2D*);
                commandCache = extendedHandle.commandCache;
                if (discardRectangles != null)
                {
                    var fieldPointer = (SharpVk.Rect2D*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Rect2D>(discardRectangles.Length).ToPointer());
                    for(int index = 0; index < (uint)(discardRectangles.Length); index++)
                    {
                        fieldPointer[index] = discardRectangles[index];
                    }
                    marshalledDiscardRectangles = fieldPointer;
                }
                else
                {
                    marshalledDiscardRectangles = null;
                }
                SharpVk.Interop.Multivendor.VkCommandBufferSetDiscardRectangleDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Multivendor.VkCommandBufferSetDiscardRectangleDelegate>("vkCmdSetDiscardRectangleEXT", "instance");
                commandDelegate(extendedHandle.handle, firstDiscardRectangle, (uint)(discardRectangles?.Length ?? 0), marshalledDiscardRectangles);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
