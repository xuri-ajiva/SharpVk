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

namespace SharpVk.Khronos
{
    /// <summary>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct AccelerationStructureInstance
    {
        /// <summary>
        /// </summary>
        public TransformMatrix Transform
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public (uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint) InstanceCustomIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public (uint, uint, uint, uint, uint, uint, uint, uint) Mask
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public (uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint) InstanceShaderBindingTableRecordOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public (GeometryInstanceFlags, GeometryInstanceFlags, GeometryInstanceFlags, GeometryInstanceFlags, GeometryInstanceFlags, GeometryInstanceFlags, GeometryInstanceFlags, GeometryInstanceFlags) Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ulong AccelerationStructureReference
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.AccelerationStructureInstance* pointer)
        {
            Transform.MarshalTo(&pointer->Transform);
            pointer->InstanceCustomIndex[0] = InstanceCustomIndex.Item1;
            pointer->InstanceCustomIndex[1] = InstanceCustomIndex.Item2;
            pointer->InstanceCustomIndex[2] = InstanceCustomIndex.Item3;
            pointer->InstanceCustomIndex[3] = InstanceCustomIndex.Item4;
            pointer->InstanceCustomIndex[4] = InstanceCustomIndex.Item5;
            pointer->InstanceCustomIndex[5] = InstanceCustomIndex.Item6;
            pointer->InstanceCustomIndex[6] = InstanceCustomIndex.Item7;
            pointer->InstanceCustomIndex[7] = InstanceCustomIndex.Item8;
            pointer->InstanceCustomIndex[8] = InstanceCustomIndex.Item9;
            pointer->InstanceCustomIndex[9] = InstanceCustomIndex.Item10;
            pointer->InstanceCustomIndex[10] = InstanceCustomIndex.Item11;
            pointer->InstanceCustomIndex[11] = InstanceCustomIndex.Item12;
            pointer->InstanceCustomIndex[12] = InstanceCustomIndex.Item13;
            pointer->InstanceCustomIndex[13] = InstanceCustomIndex.Item14;
            pointer->InstanceCustomIndex[14] = InstanceCustomIndex.Item15;
            pointer->InstanceCustomIndex[15] = InstanceCustomIndex.Item16;
            pointer->InstanceCustomIndex[16] = InstanceCustomIndex.Item17;
            pointer->InstanceCustomIndex[17] = InstanceCustomIndex.Item18;
            pointer->InstanceCustomIndex[18] = InstanceCustomIndex.Item19;
            pointer->InstanceCustomIndex[19] = InstanceCustomIndex.Item20;
            pointer->InstanceCustomIndex[20] = InstanceCustomIndex.Item21;
            pointer->InstanceCustomIndex[21] = InstanceCustomIndex.Item22;
            pointer->InstanceCustomIndex[22] = InstanceCustomIndex.Item23;
            pointer->InstanceCustomIndex[23] = InstanceCustomIndex.Item24;
            pointer->Mask[0] = Mask.Item1;
            pointer->Mask[1] = Mask.Item2;
            pointer->Mask[2] = Mask.Item3;
            pointer->Mask[3] = Mask.Item4;
            pointer->Mask[4] = Mask.Item5;
            pointer->Mask[5] = Mask.Item6;
            pointer->Mask[6] = Mask.Item7;
            pointer->Mask[7] = Mask.Item8;
            pointer->InstanceShaderBindingTableRecordOffset[0] = InstanceShaderBindingTableRecordOffset.Item1;
            pointer->InstanceShaderBindingTableRecordOffset[1] = InstanceShaderBindingTableRecordOffset.Item2;
            pointer->InstanceShaderBindingTableRecordOffset[2] = InstanceShaderBindingTableRecordOffset.Item3;
            pointer->InstanceShaderBindingTableRecordOffset[3] = InstanceShaderBindingTableRecordOffset.Item4;
            pointer->InstanceShaderBindingTableRecordOffset[4] = InstanceShaderBindingTableRecordOffset.Item5;
            pointer->InstanceShaderBindingTableRecordOffset[5] = InstanceShaderBindingTableRecordOffset.Item6;
            pointer->InstanceShaderBindingTableRecordOffset[6] = InstanceShaderBindingTableRecordOffset.Item7;
            pointer->InstanceShaderBindingTableRecordOffset[7] = InstanceShaderBindingTableRecordOffset.Item8;
            pointer->InstanceShaderBindingTableRecordOffset[8] = InstanceShaderBindingTableRecordOffset.Item9;
            pointer->InstanceShaderBindingTableRecordOffset[9] = InstanceShaderBindingTableRecordOffset.Item10;
            pointer->InstanceShaderBindingTableRecordOffset[10] = InstanceShaderBindingTableRecordOffset.Item11;
            pointer->InstanceShaderBindingTableRecordOffset[11] = InstanceShaderBindingTableRecordOffset.Item12;
            pointer->InstanceShaderBindingTableRecordOffset[12] = InstanceShaderBindingTableRecordOffset.Item13;
            pointer->InstanceShaderBindingTableRecordOffset[13] = InstanceShaderBindingTableRecordOffset.Item14;
            pointer->InstanceShaderBindingTableRecordOffset[14] = InstanceShaderBindingTableRecordOffset.Item15;
            pointer->InstanceShaderBindingTableRecordOffset[15] = InstanceShaderBindingTableRecordOffset.Item16;
            pointer->InstanceShaderBindingTableRecordOffset[16] = InstanceShaderBindingTableRecordOffset.Item17;
            pointer->InstanceShaderBindingTableRecordOffset[17] = InstanceShaderBindingTableRecordOffset.Item18;
            pointer->InstanceShaderBindingTableRecordOffset[18] = InstanceShaderBindingTableRecordOffset.Item19;
            pointer->InstanceShaderBindingTableRecordOffset[19] = InstanceShaderBindingTableRecordOffset.Item20;
            pointer->InstanceShaderBindingTableRecordOffset[20] = InstanceShaderBindingTableRecordOffset.Item21;
            pointer->InstanceShaderBindingTableRecordOffset[21] = InstanceShaderBindingTableRecordOffset.Item22;
            pointer->InstanceShaderBindingTableRecordOffset[22] = InstanceShaderBindingTableRecordOffset.Item23;
            pointer->InstanceShaderBindingTableRecordOffset[23] = InstanceShaderBindingTableRecordOffset.Item24;
            pointer->Flags_0 = Flags.Item1;
            pointer->Flags_1 = Flags.Item2;
            pointer->Flags_2 = Flags.Item3;
            pointer->Flags_3 = Flags.Item4;
            pointer->Flags_4 = Flags.Item5;
            pointer->Flags_5 = Flags.Item6;
            pointer->Flags_6 = Flags.Item7;
            pointer->Flags_7 = Flags.Item8;
            pointer->AccelerationStructureReference = AccelerationStructureReference;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe AccelerationStructureInstance MarshalFrom(SharpVk.Interop.Khronos.AccelerationStructureInstance* pointer)
        {
            AccelerationStructureInstance result = default;
            result.Transform = TransformMatrix.MarshalFrom(&pointer->Transform);
            result.InstanceCustomIndex = (pointer->InstanceCustomIndex[0], pointer->InstanceCustomIndex[1], pointer->InstanceCustomIndex[2], pointer->InstanceCustomIndex[3], pointer->InstanceCustomIndex[4], pointer->InstanceCustomIndex[5], pointer->InstanceCustomIndex[6], pointer->InstanceCustomIndex[7], pointer->InstanceCustomIndex[8], pointer->InstanceCustomIndex[9], pointer->InstanceCustomIndex[10], pointer->InstanceCustomIndex[11], pointer->InstanceCustomIndex[12], pointer->InstanceCustomIndex[13], pointer->InstanceCustomIndex[14], pointer->InstanceCustomIndex[15], pointer->InstanceCustomIndex[16], pointer->InstanceCustomIndex[17], pointer->InstanceCustomIndex[18], pointer->InstanceCustomIndex[19], pointer->InstanceCustomIndex[20], pointer->InstanceCustomIndex[21], pointer->InstanceCustomIndex[22], pointer->InstanceCustomIndex[23]);
            result.Mask = (pointer->Mask[0], pointer->Mask[1], pointer->Mask[2], pointer->Mask[3], pointer->Mask[4], pointer->Mask[5], pointer->Mask[6], pointer->Mask[7]);
            result.InstanceShaderBindingTableRecordOffset = (pointer->InstanceShaderBindingTableRecordOffset[0], pointer->InstanceShaderBindingTableRecordOffset[1], pointer->InstanceShaderBindingTableRecordOffset[2], pointer->InstanceShaderBindingTableRecordOffset[3], pointer->InstanceShaderBindingTableRecordOffset[4], pointer->InstanceShaderBindingTableRecordOffset[5], pointer->InstanceShaderBindingTableRecordOffset[6], pointer->InstanceShaderBindingTableRecordOffset[7], pointer->InstanceShaderBindingTableRecordOffset[8], pointer->InstanceShaderBindingTableRecordOffset[9], pointer->InstanceShaderBindingTableRecordOffset[10], pointer->InstanceShaderBindingTableRecordOffset[11], pointer->InstanceShaderBindingTableRecordOffset[12], pointer->InstanceShaderBindingTableRecordOffset[13], pointer->InstanceShaderBindingTableRecordOffset[14], pointer->InstanceShaderBindingTableRecordOffset[15], pointer->InstanceShaderBindingTableRecordOffset[16], pointer->InstanceShaderBindingTableRecordOffset[17], pointer->InstanceShaderBindingTableRecordOffset[18], pointer->InstanceShaderBindingTableRecordOffset[19], pointer->InstanceShaderBindingTableRecordOffset[20], pointer->InstanceShaderBindingTableRecordOffset[21], pointer->InstanceShaderBindingTableRecordOffset[22], pointer->InstanceShaderBindingTableRecordOffset[23]);
            result.Flags = (pointer->Flags_0, pointer->Flags_1, pointer->Flags_2, pointer->Flags_3, pointer->Flags_4, pointer->Flags_5, pointer->Flags_6, pointer->Flags_7);
            result.AccelerationStructureReference = pointer->AccelerationStructureReference;
            return result;
        }
    }
}
