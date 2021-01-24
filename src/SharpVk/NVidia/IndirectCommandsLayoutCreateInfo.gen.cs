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

namespace SharpVk.NVidia
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IndirectCommandsLayoutCreateInfo
    {
        /// <summary>
        /// </summary>
        public IndirectCommandsLayoutUsageFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public IndirectCommandsLayoutToken[] Tokens
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint[] StreamStrides
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.IndirectCommandsLayoutCreateInfo* pointer)
        {
            pointer->SType = StructureType.IndirectCommandsLayoutCreateInfo;
            pointer->Next = null;
            pointer->Flags = Flags;
            pointer->PipelineBindPoint = PipelineBindPoint;
            pointer->TokenCount = (uint)(Interop.HeapUtil.GetLength(Tokens));
            if (Tokens != null)
            {
                var fieldPointer = (SharpVk.Interop.NVidia.IndirectCommandsLayoutToken*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.IndirectCommandsLayoutToken>(Tokens.Length).ToPointer());
                for(int index = 0; index < (uint)(Tokens.Length); index++)
                {
                    Tokens[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Tokens = fieldPointer;
            }
            else
            {
                pointer->Tokens = null;
            }
            pointer->StreamCount = (uint)(Interop.HeapUtil.GetLength(StreamStrides));
            if (StreamStrides != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(StreamStrides.Length).ToPointer());
                for(int index = 0; index < (uint)(StreamStrides.Length); index++)
                {
                    fieldPointer[index] = StreamStrides[index];
                }
                pointer->StreamStrides = fieldPointer;
            }
            else
            {
                pointer->StreamStrides = null;
            }
        }
    }
}
