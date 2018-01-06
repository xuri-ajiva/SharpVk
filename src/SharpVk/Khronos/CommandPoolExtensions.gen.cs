// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2018
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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    public static class CommandPoolExtensions
    {
        /// <summary>
        /// Trim a command pool.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandPool handle to extend.
        /// </param>
        public static unsafe void Trim(this SharpVk.CommandPool extendedHandle, SharpVk.Khronos.CommandPoolTrimFlags? flags = default(SharpVk.Khronos.CommandPoolTrimFlags?))
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.CommandPoolTrimFlags marshalledFlags = default(SharpVk.Khronos.CommandPoolTrimFlags);
                commandCache = extendedHandle.commandCache;
                if (flags != null)
                {
                    marshalledFlags = flags.Value;
                }
                else
                {
                    marshalledFlags = default(SharpVk.Khronos.CommandPoolTrimFlags);
                }
                SharpVk.Interop.Khronos.VkCommandPoolTrimDelegate commandDelegate = commandCache.GetCommandDelegate<SharpVk.Interop.Khronos.VkCommandPoolTrimDelegate>("vkTrimCommandPoolKHR", "device");
                commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, marshalledFlags);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
