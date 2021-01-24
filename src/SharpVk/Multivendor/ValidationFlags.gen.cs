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
    /// Specify validation checks to disable for a Vulkan instance.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ValidationFlags
    {
        /// <summary>
        /// An array of values specifying the validation checks to be disabled.
        /// Checks which may be specified include: + --
        /// </summary>
        public ValidationCheck[] DisabledValidationChecks
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.ValidationFlags* pointer)
        {
            pointer->SType = StructureType.ValidationFlags;
            pointer->Next = null;
            pointer->DisabledValidationCheckCount = (uint)(Interop.HeapUtil.GetLength(DisabledValidationChecks));
            if (DisabledValidationChecks != null)
            {
                var fieldPointer = (ValidationCheck*)(Interop.HeapUtil.AllocateAndClear<ValidationCheck>(DisabledValidationChecks.Length).ToPointer());
                for(int index = 0; index < (uint)(DisabledValidationChecks.Length); index++)
                {
                    fieldPointer[index] = DisabledValidationChecks[index];
                }
                pointer->DisabledValidationChecks = fieldPointer;
            }
            else
            {
                pointer->DisabledValidationChecks = null;
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe ValidationFlags MarshalFrom(SharpVk.Interop.Multivendor.ValidationFlags* pointer)
        {
            ValidationFlags result = default;
            if (pointer->DisabledValidationChecks != null)
            {
                var fieldPointer = new ValidationCheck[(uint)(pointer->DisabledValidationCheckCount)];
                for(int index = 0; index < (uint)(pointer->DisabledValidationCheckCount); index++)
                {
                    fieldPointer[index] = pointer->DisabledValidationChecks[index];
                }
                result.DisabledValidationChecks = fieldPointer;
            }
            else
            {
                result.DisabledValidationChecks = null;
            }
            return result;
        }
    }
}
