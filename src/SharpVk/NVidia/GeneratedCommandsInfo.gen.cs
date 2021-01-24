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
    public struct GeneratedCommandsInfo
    {
        /// <summary>
        /// </summary>
        public PipelineBindPoint PipelineBindPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public Pipeline Pipeline
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public IndirectCommandsLayout IndirectCommandsLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public IndirectCommandsStream[] Streams
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint SequencesCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public Buffer PreprocessBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ulong PreprocessOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ulong PreprocessSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public Buffer SequencesCountBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ulong? SequencesCountOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public Buffer SequencesIndexBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ulong? SequencesIndexOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.GeneratedCommandsInfo* pointer)
        {
            pointer->SType = StructureType.GeneratedCommandsInfo;
            pointer->Next = null;
            pointer->PipelineBindPoint = PipelineBindPoint;
            pointer->Pipeline = Pipeline?.Handle ?? default;
            pointer->IndirectCommandsLayout = IndirectCommandsLayout?.Handle ?? default;
            pointer->StreamCount = (uint)(Interop.HeapUtil.GetLength(Streams));
            if (Streams != null)
            {
                var fieldPointer = (SharpVk.Interop.NVidia.IndirectCommandsStream*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.NVidia.IndirectCommandsStream>(Streams.Length).ToPointer());
                for(int index = 0; index < (uint)(Streams.Length); index++)
                {
                    Streams[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Streams = fieldPointer;
            }
            else
            {
                pointer->Streams = null;
            }
            pointer->SequencesCount = SequencesCount;
            pointer->PreprocessBuffer = PreprocessBuffer?.Handle ?? default;
            pointer->PreprocessOffset = PreprocessOffset;
            pointer->PreprocessSize = PreprocessSize;
            pointer->SequencesCountBuffer = SequencesCountBuffer?.Handle ?? default;
            if (SequencesCountOffset != null)
            {
                pointer->SequencesCountOffset = SequencesCountOffset.Value;
            }
            else
            {
                pointer->SequencesCountOffset = default;
            }
            pointer->SequencesIndexBuffer = SequencesIndexBuffer?.Handle ?? default;
            if (SequencesIndexOffset != null)
            {
                pointer->SequencesIndexOffset = SequencesIndexOffset.Value;
            }
            else
            {
                pointer->SequencesIndexOffset = default;
            }
        }
    }
}
