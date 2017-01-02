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
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// -
    /// </summary>
    public partial class DisplayMode
    {
        internal readonly Interop.DisplayMode handle; 
        
        internal readonly CommandCache commandCache; 
        
        private readonly PhysicalDevice parent; 
        
        internal AllocationCallbacks? Allocator
        {
            get
            {
                return this.parent.Allocator;
            }
        }
        
        internal DisplayMode(Interop.DisplayMode handle, PhysicalDevice parent, CommandCache commandCache)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = commandCache;
        }
        
        /// <summary>
        /// Query capabilities of a mode and plane combination.
        /// </summary>
        public DisplayPlaneCapabilities GetDisplayPlaneCapabilities(uint planeIndex)
        {
            unsafe
            {
                try
                {
                    var commandDelegate = this.commandCache.GetCommandDelegate<Interop.vkGetDisplayPlaneCapabilitiesKHR>("vkGetDisplayPlaneCapabilitiesKHR", "instance");
                    DisplayPlaneCapabilities result = default(DisplayPlaneCapabilities);
                    Result commandResult;
                    commandResult = commandDelegate(this.parent.handle, this.handle, planeIndex, &result);
                    if (SharpVkException.IsError(commandResult))
                    {
                        throw SharpVkException.Create(commandResult);
                    }
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeLog();
                }
            }
        }
        
        internal unsafe void MarshalTo(Interop.DisplayMode* pointer)
        {
            *pointer = this.handle;
        }
        
        /// <summary>
        /// The interop handle for this DisplayMode.
        /// </summary>
        public Interop.DisplayMode RawHandle => this.handle;
    }
}
