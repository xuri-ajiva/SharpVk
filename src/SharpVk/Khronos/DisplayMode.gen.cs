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

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    public class DisplayMode
    {
        internal readonly SharpVk.Interop.Khronos.DisplayMode Handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly Display parent; 
        
        internal DisplayMode(Display parent, SharpVk.Interop.Khronos.DisplayMode handle)
        {
            Handle = handle;
            this.parent = parent;
            commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Khronos.DisplayMode RawHandle => Handle;
        
        /// <summary>
        /// Query capabilities of a mode and plane combination.
        /// </summary>
        /// <param name="planeIndex">
        /// </param>
        public unsafe DisplayPlaneCapabilities GetDisplayPlaneCapabilities(uint planeIndex)
        {
            try
            {
                DisplayPlaneCapabilities result = default;
                DisplayPlaneCapabilities marshalledCapabilities = default;
                SharpVk.Interop.Khronos.VkDisplayModeKHRGetDisplayPlaneCapabilitiesDelegate commandDelegate = commandCache.Cache.vkGetDisplayPlaneCapabilitiesKHR;
                Result methodResult = commandDelegate(parent.parent.Handle, Handle, planeIndex, &marshalledCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledCapabilities;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
