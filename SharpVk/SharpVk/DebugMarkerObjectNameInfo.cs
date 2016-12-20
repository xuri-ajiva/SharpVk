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
    /// <para>
    /// Specify parameters of a name to give to an object.
    /// </para>
    /// <para>
    /// Applications may: change the name associated with an object simply by
    /// calling fname:vkDebugMarkerSetObjectNameEXT again with a new string. To
    /// remove a previously set name, pname:pName should: be set to an empty
    /// string.
    /// </para>
    /// </summary>
    public struct DebugMarkerObjectNameInfo
    {
        /// <summary>
        /// pname:objectType is a elink:VkDebugReportObjectTypeEXT specifying
        /// the type of the object to be named.
        /// </summary>
        public DebugReportObjectType ObjectType
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:object is the object to be named.
        /// </summary>
        public ulong Object
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pObjectName is a null-terminated UTF-8 string specifying the
        /// name to apply to pname:object.
        /// </summary>
        public string ObjectName
        {
            get;
            set;
        }
        
        internal unsafe Interop.DebugMarkerObjectNameInfo Pack()
        {
            Interop.DebugMarkerObjectNameInfo result = default(Interop.DebugMarkerObjectNameInfo);
            return result;
        }
        
        internal unsafe Interop.DebugMarkerObjectNameInfo* MarshalTo()
        {
            var result = (Interop.DebugMarkerObjectNameInfo*)Interop.HeapUtil.Allocate<Interop.DebugMarkerObjectNameInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.DebugMarkerObjectNameInfo* pointer)
        {
            pointer->SType = StructureType.DebugMarkerObjectNameInfo;
            pointer->ObjectName = Interop.HeapUtil.MarshalTo(this.ObjectName);
            pointer->ObjectType = this.ObjectType;
            pointer->Object = this.Object;
        }
    }
}
