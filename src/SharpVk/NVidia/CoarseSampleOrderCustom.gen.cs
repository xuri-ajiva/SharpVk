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
    public struct CoarseSampleOrderCustom
    {
        /// <summary>
        /// </summary>
        public ShadingRatePaletteEntry ShadingRate
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public uint SampleCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public CoarseSampleLocation[] SampleLocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.CoarseSampleOrderCustom* pointer)
        {
            pointer->ShadingRate = ShadingRate;
            pointer->SampleCount = SampleCount;
            pointer->SampleLocationCount = (uint)(Interop.HeapUtil.GetLength(SampleLocations));
            if (SampleLocations != null)
            {
                var fieldPointer = (CoarseSampleLocation*)(Interop.HeapUtil.AllocateAndClear<CoarseSampleLocation>(SampleLocations.Length).ToPointer());
                for(int index = 0; index < (uint)(SampleLocations.Length); index++)
                {
                    fieldPointer[index] = SampleLocations[index];
                }
                pointer->SampleLocations = fieldPointer;
            }
            else
            {
                pointer->SampleLocations = null;
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe CoarseSampleOrderCustom MarshalFrom(SharpVk.Interop.NVidia.CoarseSampleOrderCustom* pointer)
        {
            CoarseSampleOrderCustom result = default;
            result.ShadingRate = pointer->ShadingRate;
            result.SampleCount = pointer->SampleCount;
            if (pointer->SampleLocations != null)
            {
                var fieldPointer = new CoarseSampleLocation[(uint)(pointer->SampleLocationCount)];
                for(int index = 0; index < (uint)(pointer->SampleLocationCount); index++)
                {
                    fieldPointer[index] = pointer->SampleLocations[index];
                }
                result.SampleLocations = fieldPointer;
            }
            else
            {
                result.SampleLocations = null;
            }
            return result;
        }
    }
}
