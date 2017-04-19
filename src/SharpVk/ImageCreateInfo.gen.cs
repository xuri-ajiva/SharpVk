// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ImageCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageCreateFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageType ImageType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Format Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Extent3D Extent
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MipLevels
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ArrayLayers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags Samples
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageTiling Tiling
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageUsageFlags Usage
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharingMode SharingMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint[] QueueFamilyIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ImageLayout InitialLayout
        {
            get;
            set;
        }
        
        internal unsafe void MarshalTo(Interop.ImageCreateInfo* pointer)
        {
            pointer->SType = StructureType.ImageCreateInfo;
            pointer->Next = null;
            pointer->Flags = this.Flags;
            pointer->ImageType = this.ImageType;
            pointer->Format = this.Format;
            pointer->Extent = this.Extent;
            pointer->MipLevels = this.MipLevels;
            pointer->ArrayLayers = this.ArrayLayers;
            pointer->Samples = this.Samples;
            pointer->Tiling = this.Tiling;
            pointer->Usage = this.Usage;
            pointer->SharingMode = this.SharingMode;
            pointer->QueueFamilyIndexCount = (uint)this.QueueFamilyIndices.Length;
            if (this.QueueFamilyIndices != null)
            {
                var fieldPointer = (uint*)Interop.HeapUtil.AllocateAndClear<uint>(this.QueueFamilyIndices.Length).ToPointer();
                for(int index = 0; index < this.QueueFamilyIndices.Length; index++)
                {
                    fieldPointer[index] = this.QueueFamilyIndices[index];
                }
                pointer->QueueFamilyIndices = fieldPointer;
            }
            else
            {
                pointer->QueueFamilyIndices = null;
            }
            pointer->InitialLayout = this.InitialLayout;
        }
    }
}
