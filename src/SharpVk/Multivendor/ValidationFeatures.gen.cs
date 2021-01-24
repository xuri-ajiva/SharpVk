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
    public struct ValidationFeatures
    {
        /// <summary>
        /// </summary>
        public ValidationFeatureEnable[] EnabledValidationFeatures
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        public ValidationFeatureDisable[] DisabledValidationFeatures
        {
            get;
            set;
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.ValidationFeatures* pointer)
        {
            pointer->SType = StructureType.ValidationFeatures;
            pointer->Next = null;
            pointer->EnabledValidationFeatureCount = (uint)(Interop.HeapUtil.GetLength(EnabledValidationFeatures));
            if (EnabledValidationFeatures != null)
            {
                var fieldPointer = (ValidationFeatureEnable*)(Interop.HeapUtil.AllocateAndClear<ValidationFeatureEnable>(EnabledValidationFeatures.Length).ToPointer());
                for(int index = 0; index < (uint)(EnabledValidationFeatures.Length); index++)
                {
                    fieldPointer[index] = EnabledValidationFeatures[index];
                }
                pointer->EnabledValidationFeatures = fieldPointer;
            }
            else
            {
                pointer->EnabledValidationFeatures = null;
            }
            pointer->DisabledValidationFeatureCount = (uint)(Interop.HeapUtil.GetLength(DisabledValidationFeatures));
            if (DisabledValidationFeatures != null)
            {
                var fieldPointer = (ValidationFeatureDisable*)(Interop.HeapUtil.AllocateAndClear<ValidationFeatureDisable>(DisabledValidationFeatures.Length).ToPointer());
                for(int index = 0; index < (uint)(DisabledValidationFeatures.Length); index++)
                {
                    fieldPointer[index] = DisabledValidationFeatures[index];
                }
                pointer->DisabledValidationFeatures = fieldPointer;
            }
            else
            {
                pointer->DisabledValidationFeatures = null;
            }
        }
        
        /// <summary>
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe ValidationFeatures MarshalFrom(SharpVk.Interop.Multivendor.ValidationFeatures* pointer)
        {
            ValidationFeatures result = default;
            if (pointer->EnabledValidationFeatures != null)
            {
                var fieldPointer = new ValidationFeatureEnable[(uint)(pointer->EnabledValidationFeatureCount)];
                for(int index = 0; index < (uint)(pointer->EnabledValidationFeatureCount); index++)
                {
                    fieldPointer[index] = pointer->EnabledValidationFeatures[index];
                }
                result.EnabledValidationFeatures = fieldPointer;
            }
            else
            {
                result.EnabledValidationFeatures = null;
            }
            if (pointer->DisabledValidationFeatures != null)
            {
                var fieldPointer = new ValidationFeatureDisable[(uint)(pointer->DisabledValidationFeatureCount)];
                for(int index = 0; index < (uint)(pointer->DisabledValidationFeatureCount); index++)
                {
                    fieldPointer[index] = pointer->DisabledValidationFeatures[index];
                }
                result.DisabledValidationFeatures = fieldPointer;
            }
            else
            {
                result.DisabledValidationFeatures = null;
            }
            return result;
        }
    }
}
