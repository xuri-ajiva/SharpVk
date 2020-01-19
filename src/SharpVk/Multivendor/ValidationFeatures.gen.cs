// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2020
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
using System.Runtime.InteropServices;

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ValidationFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.ValidationFeatureEnable[] EnabledValidationFeatures
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.ValidationFeatureDisable[] DisabledValidationFeatures
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.ValidationFeatures* pointer)
        {
            pointer->SType = StructureType.ValidationFeatures;
            pointer->Next = null;
            pointer->EnabledValidationFeatureCount = (uint)(Interop.HeapUtil.GetLength(this.EnabledValidationFeatures));
            if (this.EnabledValidationFeatures != null)
            {
                var fieldPointer = (SharpVk.Multivendor.ValidationFeatureEnable*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Multivendor.ValidationFeatureEnable>(this.EnabledValidationFeatures.Length).ToPointer());
                for(int index = 0; index < (uint)(this.EnabledValidationFeatures.Length); index++)
                {
                    fieldPointer[index] = this.EnabledValidationFeatures[index];
                }
                pointer->EnabledValidationFeatures = fieldPointer;
            }
            else
            {
                pointer->EnabledValidationFeatures = null;
            }
            pointer->DisabledValidationFeatureCount = (uint)(Interop.HeapUtil.GetLength(this.DisabledValidationFeatures));
            if (this.DisabledValidationFeatures != null)
            {
                var fieldPointer = (SharpVk.Multivendor.ValidationFeatureDisable*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Multivendor.ValidationFeatureDisable>(this.DisabledValidationFeatures.Length).ToPointer());
                for(int index = 0; index < (uint)(this.DisabledValidationFeatures.Length); index++)
                {
                    fieldPointer[index] = this.DisabledValidationFeatures[index];
                }
                pointer->DisabledValidationFeatures = fieldPointer;
            }
            else
            {
                pointer->DisabledValidationFeatures = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal static unsafe ValidationFeatures MarshalFrom(SharpVk.Interop.Multivendor.ValidationFeatures* pointer)
        {
            ValidationFeatures result = default(ValidationFeatures);
            if (pointer->EnabledValidationFeatures != null)
            {
                var fieldPointer = new SharpVk.Multivendor.ValidationFeatureEnable[(uint)(pointer->EnabledValidationFeatureCount)];
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
                var fieldPointer = new SharpVk.Multivendor.ValidationFeatureDisable[(uint)(pointer->DisabledValidationFeatureCount)];
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
