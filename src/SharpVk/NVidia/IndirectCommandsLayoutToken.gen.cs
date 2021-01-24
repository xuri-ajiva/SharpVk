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
    public struct IndirectCommandsLayoutToken
    {
        /// <summary>
        /// </summary>
        public IndirectCommandsTokenType TokenType
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint Stream
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint Offset
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint VertexBindingUnit
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public bool VertexDynamicStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public PipelineLayout PushconstantPipelineLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ShaderStageFlags? PushconstantShaderStageFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint PushconstantOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint PushconstantSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public IndirectStateFlags? IndirectStateFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public IndexType[] IndexTypes
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint[] IndexTypeValues
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.IndirectCommandsLayoutToken* pointer)
        {
            pointer->SType = StructureType.IndirectCommandsLayoutToken;
            pointer->Next = null;
            pointer->TokenType = TokenType;
            pointer->Stream = Stream;
            pointer->Offset = Offset;
            pointer->VertexBindingUnit = VertexBindingUnit;
            pointer->VertexDynamicStride = VertexDynamicStride;
            pointer->PushconstantPipelineLayout = PushconstantPipelineLayout?.Handle ?? default;
            if (PushconstantShaderStageFlags != null)
            {
                pointer->PushconstantShaderStageFlags = PushconstantShaderStageFlags.Value;
            }
            else
            {
                pointer->PushconstantShaderStageFlags = default;
            }
            pointer->PushconstantOffset = PushconstantOffset;
            pointer->PushconstantSize = PushconstantSize;
            if (IndirectStateFlags != null)
            {
                pointer->IndirectStateFlags = IndirectStateFlags.Value;
            }
            else
            {
                pointer->IndirectStateFlags = default;
            }
            pointer->IndexTypeCount = (uint)(Interop.HeapUtil.GetLength(IndexTypes));
            if (IndexTypes != null)
            {
                var fieldPointer = (IndexType*)(Interop.HeapUtil.AllocateAndClear<IndexType>(IndexTypes.Length).ToPointer());
                for(int index = 0; index < (uint)(IndexTypes.Length); index++)
                {
                    fieldPointer[index] = IndexTypes[index];
                }
                pointer->IndexTypes = fieldPointer;
            }
            else
            {
                pointer->IndexTypes = null;
            }
            if (IndexTypeValues != null)
            {
                var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(IndexTypeValues.Length).ToPointer());
                for(int index = 0; index < (uint)(IndexTypeValues.Length); index++)
                {
                    fieldPointer[index] = IndexTypeValues[index];
                }
                pointer->IndexTypeValues = fieldPointer;
            }
            else
            {
                pointer->IndexTypeValues = null;
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe IndirectCommandsLayoutToken MarshalFrom(SharpVk.Interop.NVidia.IndirectCommandsLayoutToken* pointer)
        {
            IndirectCommandsLayoutToken result = default;
            result.TokenType = pointer->TokenType;
            result.Stream = pointer->Stream;
            result.Offset = pointer->Offset;
            result.VertexBindingUnit = pointer->VertexBindingUnit;
            result.VertexDynamicStride = pointer->VertexDynamicStride;
            result.PushconstantPipelineLayout = new PipelineLayout(default, pointer->PushconstantPipelineLayout);
            result.PushconstantShaderStageFlags = pointer->PushconstantShaderStageFlags;
            result.PushconstantOffset = pointer->PushconstantOffset;
            result.PushconstantSize = pointer->PushconstantSize;
            result.IndirectStateFlags = pointer->IndirectStateFlags;
            if (pointer->IndexTypes != null)
            {
                var fieldPointer = new IndexType[(uint)(pointer->IndexTypeCount)];
                for(int index = 0; index < (uint)(pointer->IndexTypeCount); index++)
                {
                    fieldPointer[index] = pointer->IndexTypes[index];
                }
                result.IndexTypes = fieldPointer;
            }
            else
            {
                result.IndexTypes = null;
            }
            if (pointer->IndexTypeValues != null)
            {
                var fieldPointer = new uint[(uint)(pointer->IndexTypeCount)];
                for(int index = 0; index < (uint)(pointer->IndexTypeCount); index++)
                {
                    fieldPointer[index] = pointer->IndexTypeValues[index];
                }
                result.IndexTypeValues = fieldPointer;
            }
            else
            {
                result.IndexTypeValues = null;
            }
            return result;
        }
    }
}
