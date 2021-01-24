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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    public static class QueueExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Queue handle to extend.
        /// </param>
        /// <param name="labelInfo">
        /// </param>
        public static unsafe void BeginDebugUtilsLabel(this Queue extendedHandle, DebugUtilsLabel labelInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DebugUtilsLabel* marshalledLabelInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledLabelInfo = (SharpVk.Interop.Multivendor.DebugUtilsLabel*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsLabel>());
                labelInfo.MarshalTo(marshalledLabelInfo);
                SharpVk.Interop.Multivendor.VkQueueBeginDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkQueueBeginDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.Handle, marshalledLabelInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Queue handle to extend.
        /// </param>
        public static unsafe void EndDebugUtilsLabel(this Queue extendedHandle)
        {
            try
            {
                CommandCache commandCache = default;
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkQueueEndDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkQueueEndDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.Handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="extendedHandle">
        /// The Queue handle to extend.
        /// </param>
        /// <param name="labelInfo">
        /// </param>
        public static unsafe void InsertDebugUtilsLabel(this Queue extendedHandle, DebugUtilsLabel labelInfo)
        {
            try
            {
                CommandCache commandCache = default;
                SharpVk.Interop.Multivendor.DebugUtilsLabel* marshalledLabelInfo = default;
                commandCache = extendedHandle.commandCache;
                marshalledLabelInfo = (SharpVk.Interop.Multivendor.DebugUtilsLabel*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsLabel>());
                labelInfo.MarshalTo(marshalledLabelInfo);
                SharpVk.Interop.Multivendor.VkQueueInsertDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkQueueInsertDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.Handle, marshalledLabelInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
