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
    /// Specify parameters of a tag to attach to an object.
    /// </para>
    /// <para>
    /// The pname:tagName parameter gives a name or identifier to the type of
    /// data being tagged. This can be used by debugging layers to easily
    /// filter for only data that can be used by that implementation.
    /// </para>
    /// </summary>
    public struct DebugMarkerObjectTagInfo
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
        /// pname:object is the object to be tagged.
        /// </summary>
        public ulong Object
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:tagName is a numerical identifier of the tag.
        /// </summary>
        public ulong TagName
        {
            get;
            set;
        }
        
        /// <summary>
        /// pname:pTag is an array of pname:tagSize bytes containing the data
        /// to be associated with the object.
        /// </summary>
        public byte[] Tag
        {
            get;
            set;
        }
        
        internal unsafe Interop.DebugMarkerObjectTagInfo* MarshalTo()
        {
            var result = (Interop.DebugMarkerObjectTagInfo*)Interop.HeapUtil.AllocateAndClear<Interop.DebugMarkerObjectTagInfo>().ToPointer();
            this.MarshalTo(result);
            return result;
        }
        
        internal unsafe void MarshalTo(Interop.DebugMarkerObjectTagInfo* pointer)
        {
            pointer->SType = StructureType.DebugMarkerObjectTagInfo;
            pointer->Tag = this.Tag == null ? null : Interop.HeapUtil.MarshalTo(this.Tag);
            pointer->TagSize = (Size)(this.Tag?.Length ?? 0);
            pointer->ObjectType = this.ObjectType;
            pointer->Object = this.Object;
            pointer->TagName = this.TagName;
        }
    }
}
