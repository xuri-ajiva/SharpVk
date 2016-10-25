// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2016
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
    /// Structure describing display plane properties.
    /// </summary>
    public struct DisplayPlaneProperties
    {
        /// <summary>
        /// pname:currentDisplay is the handle of the display the plane is
        /// currently associated with. If the plane is not currently attached
        /// to any displays, this will be sname:VK_NULL_HANDLE.
        /// </summary>
        public Display CurrentDisplay
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:currentStackIndex is the current z-order of the plane. This
        /// will be between 0 and the value returned by
        /// fname:vkGetPhysicalDeviceDisplayPlanePropertiesKHR() in
        /// pname:pPropertyCount.
        /// </summary>
        public uint CurrentStackIndex
        {
            get;
            set;
        }
        
        internal static unsafe DisplayPlaneProperties MarshalFrom(Interop.DisplayPlaneProperties* value)
        {
            DisplayPlaneProperties result = new DisplayPlaneProperties();
            result.CurrentStackIndex = value->CurrentStackIndex;
            return result;
        }
    }
}
