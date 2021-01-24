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

using System.Runtime.InteropServices;

namespace SharpVk.Multivendor
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RenderPassSampleLocationsBeginInfo
    {
        /// <summary>
        /// </summary>
        public AttachmentSampleLocations[] AttachmentInitialSampleLocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public SubpassSampleLocations[] PostSubpassSampleLocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.RenderPassSampleLocationsBeginInfo* pointer)
        {
            pointer->SType = StructureType.RenderPassSampleLocationsBeginInfo;
            pointer->Next = null;
            pointer->AttachmentInitialSampleLocationsCount = (uint)(Interop.HeapUtil.GetLength(AttachmentInitialSampleLocations));
            if (AttachmentInitialSampleLocations != null)
            {
                var fieldPointer = (SharpVk.Interop.Multivendor.AttachmentSampleLocations*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.AttachmentSampleLocations>(AttachmentInitialSampleLocations.Length).ToPointer());
                for(int index = 0; index < (uint)(AttachmentInitialSampleLocations.Length); index++)
                {
                    AttachmentInitialSampleLocations[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->AttachmentInitialSampleLocations = fieldPointer;
            }
            else
            {
                pointer->AttachmentInitialSampleLocations = null;
            }
            pointer->PostSubpassSampleLocationsCount = (uint)(Interop.HeapUtil.GetLength(PostSubpassSampleLocations));
            if (PostSubpassSampleLocations != null)
            {
                var fieldPointer = (SharpVk.Interop.Multivendor.SubpassSampleLocations*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Multivendor.SubpassSampleLocations>(PostSubpassSampleLocations.Length).ToPointer());
                for(int index = 0; index < (uint)(PostSubpassSampleLocations.Length); index++)
                {
                    PostSubpassSampleLocations[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->PostSubpassSampleLocations = fieldPointer;
            }
            else
            {
                pointer->PostSubpassSampleLocations = null;
            }
        }
    }
}
