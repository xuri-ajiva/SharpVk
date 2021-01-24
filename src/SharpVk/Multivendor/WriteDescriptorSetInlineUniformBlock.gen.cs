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
    public struct WriteDescriptorSetInlineUniformBlock
    {
        /// <summary>
        /// </summary>
        public byte[] Data
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.WriteDescriptorSetInlineUniformBlock* pointer)
        {
            pointer->SType = StructureType.WriteDescriptorSetInlineUniformBlock;
            pointer->Next = null;
            pointer->DataSize = (uint)(Interop.HeapUtil.GetLength(Data));
            if (Data != null)
            {
                var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Data.Length).ToPointer());
                for(int index = 0; index < (uint)(Data.Length); index++)
                {
                    fieldPointer[index] = Data[index];
                }
                pointer->Data = fieldPointer;
            }
            else
            {
                pointer->Data = null;
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe WriteDescriptorSetInlineUniformBlock MarshalFrom(SharpVk.Interop.Multivendor.WriteDescriptorSetInlineUniformBlock* pointer)
        {
            WriteDescriptorSetInlineUniformBlock result = default;
            if (pointer->Data != null)
            {
                var fieldPointer = new byte[(uint)(pointer->DataSize)];
                for(int index = 0; index < (uint)(pointer->DataSize); index++)
                {
                    fieldPointer[index] = pointer->Data[index];
                }
                result.Data = fieldPointer;
            }
            else
            {
                result.Data = null;
            }
            return result;
        }
    }
}
