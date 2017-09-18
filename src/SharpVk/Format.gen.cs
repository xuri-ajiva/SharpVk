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

namespace SharpVk
{
    /// <summary>
    /// Available image formats.
    /// </summary>
    public enum Format
    {
        /// <summary>
        /// VK_FORMAT_UNDEFINED:: The format is not specified.
        /// </summary>
        Undefined = 0, 
        
        /// <summary>
        /// VK_FORMAT_R4G4_UNORM_PACK8:: A two-component, 8-bit packed unsigned
        /// normalized format that has a 4-bit R component in bits 4..7, and a
        /// 4-bit G component in bits 0..3.
        /// </summary>
        R4g4UnormPack8 = 1, 
        
        /// <summary>
        /// VK_FORMAT_R4G4B4A4_UNORM_PACK16:: A four-component, 16-bit packed
        /// unsigned normalized format that has a 4-bit R component in bits
        /// 12..15, a 4-bit G component in bits 8..11, a 4-bit B component in
        /// bits 4..7, and a 4-bit A component in bits 0..3.
        /// </summary>
        R4g4b4a4UnormPack16 = 2, 
        
        /// <summary>
        /// VK_FORMAT_B4G4R4A4_UNORM_PACK16:: A four-component, 16-bit packed
        /// unsigned normalized format that has a 4-bit B component in bits
        /// 12..15, a 4-bit G component in bits 8..11, a 4-bit R component in
        /// bits 4..7, and a 4-bit A component in bits 0..3.
        /// </summary>
        B4g4r4a4UnormPack16 = 3, 
        
        /// <summary>
        /// VK_FORMAT_R5G6B5_UNORM_PACK16:: A three-component, 16-bit packed
        /// unsigned normalized format that has a 5-bit R component in bits
        /// 11..15, a 6-bit G component in bits 5..10, and a 5-bit B component
        /// in bits 0..4.
        /// </summary>
        R5g6b5UnormPack16 = 4, 
        
        /// <summary>
        /// VK_FORMAT_B5G6R5_UNORM_PACK16:: A three-component, 16-bit packed
        /// unsigned normalized format that has a 5-bit B component in bits
        /// 11..15, a 6-bit G component in bits 5..10, and a 5-bit R component
        /// in bits 0..4.
        /// </summary>
        B5g6r5UnormPack16 = 5, 
        
        /// <summary>
        /// VK_FORMAT_R5G5B5A1_UNORM_PACK16:: A four-component, 16-bit packed
        /// unsigned normalized format that has a 5-bit R component in bits
        /// 11..15, a 5-bit G component in bits 6..10, a 5-bit B component in
        /// bits 1..5, and a 1-bit A component in bit 0.
        /// </summary>
        R5g5b5a1UnormPack16 = 6, 
        
        /// <summary>
        /// VK_FORMAT_B5G5R5A1_UNORM_PACK16:: A four-component, 16-bit packed
        /// unsigned normalized format that has a 5-bit B component in bits
        /// 11..15, a 5-bit G component in bits 6..10, a 5-bit R component in
        /// bits 1..5, and a 1-bit A component in bit 0.
        /// </summary>
        B5g5r5a1UnormPack16 = 7, 
        
        /// <summary>
        /// VK_FORMAT_A1R5G5B5_UNORM_PACK16:: A four-component, 16-bit packed
        /// unsigned normalized format that has a 1-bit A component in bit 15,
        /// a 5-bit R component in bits 10..14, a 5-bit G component in bits
        /// 5..9, and a 5-bit B component in bits 0..4.
        /// </summary>
        A1r5g5b5UnormPack16 = 8, 
        
        /// <summary>
        /// VK_FORMAT_R8_UNORM:: A one-component, 8-bit unsigned normalized
        /// format that has a single 8-bit R component.
        /// </summary>
        R8Unorm = 9, 
        
        /// <summary>
        /// VK_FORMAT_R8_SNORM:: A one-component, 8-bit signed normalized
        /// format that has a single 8-bit R component.
        /// </summary>
        R8Snorm = 10, 
        
        /// <summary>
        /// VK_FORMAT_R8_USCALED:: A one-component, 8-bit unsigned scaled
        /// integer format that has a single 8-bit R component.
        /// </summary>
        R8Uscaled = 11, 
        
        /// <summary>
        /// VK_FORMAT_R8_SSCALED:: A one-component, 8-bit signed scaled integer
        /// format that has a single 8-bit R component.
        /// </summary>
        R8Sscaled = 12, 
        
        /// <summary>
        /// VK_FORMAT_R8_UINT:: A one-component, 8-bit unsigned integer format
        /// that has a single 8-bit R component.
        /// </summary>
        R8Uint = 13, 
        
        /// <summary>
        /// VK_FORMAT_R8_SINT:: A one-component, 8-bit signed integer format
        /// that has a single 8-bit R component.
        /// </summary>
        R8Sint = 14, 
        
        /// <summary>
        /// VK_FORMAT_R8_SRGB:: A one-component, 8-bit unsigned normalized
        /// format that has a single 8-bit R component stored with sRGB
        /// nonlinear encoding.
        /// </summary>
        R8Srgb = 15, 
        
        /// <summary>
        /// VK_FORMAT_R8G8_UNORM:: A two-component, 16-bit unsigned normalized
        /// format that has an 8-bit R component in byte 0, and an 8-bit G
        /// component in byte 1.
        /// </summary>
        R8g8Unorm = 16, 
        
        /// <summary>
        /// VK_FORMAT_R8G8_SNORM:: A two-component, 16-bit signed normalized
        /// format that has an 8-bit R component in byte 0, and an 8-bit G
        /// component in byte 1.
        /// </summary>
        R8g8Snorm = 17, 
        
        /// <summary>
        /// VK_FORMAT_R8G8_USCALED:: A two-component, 16-bit unsigned scaled
        /// integer format that has an 8-bit R component in byte 0, and an
        /// 8-bit G component in byte 1.
        /// </summary>
        R8g8Uscaled = 18, 
        
        /// <summary>
        /// VK_FORMAT_R8G8_SSCALED:: A two-component, 16-bit signed scaled
        /// integer format that has an 8-bit R component in byte 0, and an
        /// 8-bit G component in byte 1.
        /// </summary>
        R8g8Sscaled = 19, 
        
        /// <summary>
        /// VK_FORMAT_R8G8_UINT:: A two-component, 16-bit unsigned integer
        /// format that has an 8-bit R component in byte 0, and an 8-bit G
        /// component in byte 1.
        /// </summary>
        R8g8Uint = 20, 
        
        /// <summary>
        /// VK_FORMAT_R8G8_SINT:: A two-component, 16-bit signed integer format
        /// that has an 8-bit R component in byte 0, and an 8-bit G component
        /// in byte 1.
        /// </summary>
        R8g8Sint = 21, 
        
        /// <summary>
        /// VK_FORMAT_R8G8_SRGB:: A two-component, 16-bit unsigned normalized
        /// format that has an 8-bit R component stored with sRGB nonlinear
        /// encoding in byte 0, and an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1.
        /// </summary>
        R8g8Srgb = 22, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8_UNORM:: A three-component, 24-bit unsigned
        /// normalized format that has an 8-bit R component in byte 0, an 8-bit
        /// G component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8g8b8Unorm = 23, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8_SNORM:: A three-component, 24-bit signed
        /// normalized format that has an 8-bit R component in byte 0, an 8-bit
        /// G component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8g8b8Snorm = 24, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8_USCALED:: A three-component, 24-bit unsigned
        /// scaled format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8g8b8Uscaled = 25, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8_SSCALED:: A three-component, 24-bit signed scaled
        /// format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8g8b8Sscaled = 26, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8_UINT:: A three-component, 24-bit unsigned integer
        /// format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8g8b8Uint = 27, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8_SINT:: A three-component, 24-bit signed integer
        /// format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8g8b8Sint = 28, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8_SRGB:: A three-component, 24-bit unsigned
        /// normalized format that has an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, and an 8-bit B component stored with
        /// sRGB nonlinear encoding in byte 2.
        /// </summary>
        R8g8b8Srgb = 29, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8_UNORM:: A three-component, 24-bit unsigned
        /// normalized format that has an 8-bit B component in byte 0, an 8-bit
        /// G component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8g8r8Unorm = 30, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8_SNORM:: A three-component, 24-bit signed
        /// normalized format that has an 8-bit B component in byte 0, an 8-bit
        /// G component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8g8r8Snorm = 31, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8_USCALED:: A three-component, 24-bit unsigned
        /// scaled format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8g8r8Uscaled = 32, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8_SSCALED:: A three-component, 24-bit signed scaled
        /// format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8g8r8Sscaled = 33, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8_UINT:: A three-component, 24-bit unsigned integer
        /// format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8g8r8Uint = 34, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8_SINT:: A three-component, 24-bit signed integer
        /// format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8g8r8Sint = 35, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8_SRGB:: A three-component, 24-bit unsigned
        /// normalized format that has an 8-bit B component stored with sRGB
        /// nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, and an 8-bit R component stored with
        /// sRGB nonlinear encoding in byte 2.
        /// </summary>
        B8g8r8Srgb = 36, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8A8_UNORM:: A four-component, 32-bit unsigned
        /// normalized format that has an 8-bit R component in byte 0, an 8-bit
        /// G component in byte 1, an 8-bit B component in byte 2, and an 8-bit
        /// A component in byte 3.
        /// </summary>
        R8g8b8a8Unorm = 37, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8A8_SNORM:: A four-component, 32-bit signed
        /// normalized format that has an 8-bit R component in byte 0, an 8-bit
        /// G component in byte 1, an 8-bit B component in byte 2, and an 8-bit
        /// A component in byte 3.
        /// </summary>
        R8g8b8a8Snorm = 38, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8A8_USCALED:: A four-component, 32-bit unsigned
        /// scaled format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        R8g8b8a8Uscaled = 39, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8A8_SSCALED:: A four-component, 32-bit signed scaled
        /// format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        R8g8b8a8Sscaled = 40, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8A8_UINT:: A four-component, 32-bit unsigned integer
        /// format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        R8g8b8a8Uint = 41, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8A8_SINT:: A four-component, 32-bit signed integer
        /// format that has an 8-bit R component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit B component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        R8g8b8a8Sint = 42, 
        
        /// <summary>
        /// VK_FORMAT_R8G8B8A8_SRGB:: A four-component, 32-bit unsigned
        /// normalized format that has an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, an 8-bit B component stored with sRGB
        /// nonlinear encoding in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8g8b8a8Srgb = 43, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8A8_UNORM:: A four-component, 32-bit unsigned
        /// normalized format that has an 8-bit B component in byte 0, an 8-bit
        /// G component in byte 1, an 8-bit R component in byte 2, and an 8-bit
        /// A component in byte 3.
        /// </summary>
        B8g8r8a8Unorm = 44, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8A8_SNORM:: A four-component, 32-bit signed
        /// normalized format that has an 8-bit B component in byte 0, an 8-bit
        /// G component in byte 1, an 8-bit R component in byte 2, and an 8-bit
        /// A component in byte 3.
        /// </summary>
        B8g8r8a8Snorm = 45, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8A8_USCALED:: A four-component, 32-bit unsigned
        /// scaled format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        B8g8r8a8Uscaled = 46, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8A8_SSCALED:: A four-component, 32-bit signed scaled
        /// format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        B8g8r8a8Sscaled = 47, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8A8_UINT:: A four-component, 32-bit unsigned integer
        /// format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        B8g8r8a8Uint = 48, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8A8_SINT:: A four-component, 32-bit signed integer
        /// format that has an 8-bit B component in byte 0, an 8-bit G
        /// component in byte 1, an 8-bit R component in byte 2, and an 8-bit A
        /// component in byte 3.
        /// </summary>
        B8g8r8a8Sint = 49, 
        
        /// <summary>
        /// VK_FORMAT_B8G8R8A8_SRGB:: A four-component, 32-bit unsigned
        /// normalized format that has an 8-bit B component stored with sRGB
        /// nonlinear encoding in byte 0, an 8-bit G component stored with sRGB
        /// nonlinear encoding in byte 1, an 8-bit R component stored with sRGB
        /// nonlinear encoding in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8g8r8a8Srgb = 50, 
        
        /// <summary>
        /// VK_FORMAT_A8B8G8R8_UNORM_PACK32:: A four-component, 32-bit packed
        /// unsigned normalized format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component
        /// in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8b8g8r8UnormPack32 = 51, 
        
        /// <summary>
        /// VK_FORMAT_A8B8G8R8_SNORM_PACK32:: A four-component, 32-bit packed
        /// signed normalized format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component
        /// in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8b8g8r8SnormPack32 = 52, 
        
        /// <summary>
        /// VK_FORMAT_A8B8G8R8_USCALED_PACK32:: A four-component, 32-bit packed
        /// unsigned scaled integer format that has an 8-bit A component in
        /// bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G
        /// component in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8b8g8r8UscaledPack32 = 53, 
        
        /// <summary>
        /// VK_FORMAT_A8B8G8R8_SSCALED_PACK32:: A four-component, 32-bit packed
        /// signed scaled integer format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component
        /// in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8b8g8r8SscaledPack32 = 54, 
        
        /// <summary>
        /// VK_FORMAT_A8B8G8R8_UINT_PACK32:: A four-component, 32-bit packed
        /// unsigned integer format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component in bits 16..23, an 8-bit G component
        /// in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8b8g8r8UintPack32 = 55, 
        
        /// <summary>
        /// VK_FORMAT_A8B8G8R8_SINT_PACK32:: A four-component, 32-bit packed
        /// signed integer format that has an 8-bit A component in bits 24..31,
        /// an 8-bit B component in bits 16..23, an 8-bit G component in bits
        /// 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8b8g8r8SintPack32 = 56, 
        
        /// <summary>
        /// VK_FORMAT_A8B8G8R8_SRGB_PACK32:: A four-component, 32-bit packed
        /// unsigned normalized format that has an 8-bit A component in bits
        /// 24..31, an 8-bit B component stored with sRGB nonlinear encoding in
        /// bits 16..23, an 8-bit G component stored with sRGB nonlinear
        /// encoding in bits 8..15, and an 8-bit R component stored with sRGB
        /// nonlinear encoding in bits 0..7.
        /// </summary>
        A8b8g8r8SrgbPack32 = 57, 
        
        /// <summary>
        /// VK_FORMAT_A2R10G10B10_UNORM_PACK32:: A four-component, 32-bit
        /// packed unsigned normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2r10g10b10UnormPack32 = 58, 
        
        /// <summary>
        /// VK_FORMAT_A2R10G10B10_SNORM_PACK32:: A four-component, 32-bit
        /// packed signed normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2r10g10b10SnormPack32 = 59, 
        
        /// <summary>
        /// VK_FORMAT_A2R10G10B10_USCALED_PACK32:: A four-component, 32-bit
        /// packed unsigned scaled integer format that has a 2-bit A component
        /// in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2r10g10b10UscaledPack32 = 60, 
        
        /// <summary>
        /// VK_FORMAT_A2R10G10B10_SSCALED_PACK32:: A four-component, 32-bit
        /// packed signed scaled integer format that has a 2-bit A component in
        /// bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2r10g10b10SscaledPack32 = 61, 
        
        /// <summary>
        /// VK_FORMAT_A2R10G10B10_UINT_PACK32:: A four-component, 32-bit packed
        /// unsigned integer format that has a 2-bit A component in bits
        /// 30..31, a 10-bit R component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2r10g10b10UintPack32 = 62, 
        
        /// <summary>
        /// VK_FORMAT_A2R10G10B10_SINT_PACK32:: A four-component, 32-bit packed
        /// signed integer format that has a 2-bit A component in bits 30..31,
        /// a 10-bit R component in bits 20..29, a 10-bit G component in bits
        /// 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2r10g10b10SintPack32 = 63, 
        
        /// <summary>
        /// VK_FORMAT_A2B10G10R10_UNORM_PACK32:: A four-component, 32-bit
        /// packed unsigned normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2b10g10r10UnormPack32 = 64, 
        
        /// <summary>
        /// VK_FORMAT_A2B10G10R10_SNORM_PACK32:: A four-component, 32-bit
        /// packed signed normalized format that has a 2-bit A component in
        /// bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2b10g10r10SnormPack32 = 65, 
        
        /// <summary>
        /// VK_FORMAT_A2B10G10R10_USCALED_PACK32:: A four-component, 32-bit
        /// packed unsigned scaled integer format that has a 2-bit A component
        /// in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2b10g10r10UscaledPack32 = 66, 
        
        /// <summary>
        /// VK_FORMAT_A2B10G10R10_SSCALED_PACK32:: A four-component, 32-bit
        /// packed signed scaled integer format that has a 2-bit A component in
        /// bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G
        /// component in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2b10g10r10SscaledPack32 = 67, 
        
        /// <summary>
        /// VK_FORMAT_A2B10G10R10_UINT_PACK32:: A four-component, 32-bit packed
        /// unsigned integer format that has a 2-bit A component in bits
        /// 30..31, a 10-bit B component in bits 20..29, a 10-bit G component
        /// in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2b10g10r10UintPack32 = 68, 
        
        /// <summary>
        /// VK_FORMAT_A2B10G10R10_SINT_PACK32:: A four-component, 32-bit packed
        /// signed integer format that has a 2-bit A component in bits 30..31,
        /// a 10-bit B component in bits 20..29, a 10-bit G component in bits
        /// 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2b10g10r10SintPack32 = 69, 
        
        /// <summary>
        /// VK_FORMAT_R16_UNORM:: A one-component, 16-bit unsigned normalized
        /// format that has a single 16-bit R component.
        /// </summary>
        R16Unorm = 70, 
        
        /// <summary>
        /// VK_FORMAT_R16_SNORM:: A one-component, 16-bit signed normalized
        /// format that has a single 16-bit R component.
        /// </summary>
        R16Snorm = 71, 
        
        /// <summary>
        /// VK_FORMAT_R16_USCALED:: A one-component, 16-bit unsigned scaled
        /// integer format that has a single 16-bit R component.
        /// </summary>
        R16Uscaled = 72, 
        
        /// <summary>
        /// VK_FORMAT_R16_SSCALED:: A one-component, 16-bit signed scaled
        /// integer format that has a single 16-bit R component.
        /// </summary>
        R16Sscaled = 73, 
        
        /// <summary>
        /// VK_FORMAT_R16_UINT:: A one-component, 16-bit unsigned integer
        /// format that has a single 16-bit R component.
        /// </summary>
        R16Uint = 74, 
        
        /// <summary>
        /// VK_FORMAT_R16_SINT:: A one-component, 16-bit signed integer format
        /// that has a single 16-bit R component.
        /// </summary>
        R16Sint = 75, 
        
        /// <summary>
        /// VK_FORMAT_R16_SFLOAT:: A one-component, 16-bit signed
        /// floating-point format that has a single 16-bit R component.
        /// </summary>
        R16Sfloat = 76, 
        
        /// <summary>
        /// VK_FORMAT_R16G16_UNORM:: A two-component, 32-bit unsigned
        /// normalized format that has a 16-bit R component in bytes 0..1, and
        /// a 16-bit G component in bytes 2..3.
        /// </summary>
        R16g16Unorm = 77, 
        
        /// <summary>
        /// VK_FORMAT_R16G16_SNORM:: A two-component, 32-bit signed normalized
        /// format that has a 16-bit R component in bytes 0..1, and a 16-bit G
        /// component in bytes 2..3.
        /// </summary>
        R16g16Snorm = 78, 
        
        /// <summary>
        /// VK_FORMAT_R16G16_USCALED:: A two-component, 32-bit unsigned scaled
        /// integer format that has a 16-bit R component in bytes 0..1, and a
        /// 16-bit G component in bytes 2..3.
        /// </summary>
        R16g16Uscaled = 79, 
        
        /// <summary>
        /// VK_FORMAT_R16G16_SSCALED:: A two-component, 32-bit signed scaled
        /// integer format that has a 16-bit R component in bytes 0..1, and a
        /// 16-bit G component in bytes 2..3.
        /// </summary>
        R16g16Sscaled = 80, 
        
        /// <summary>
        /// VK_FORMAT_R16G16_UINT:: A two-component, 32-bit unsigned integer
        /// format that has a 16-bit R component in bytes 0..1, and a 16-bit G
        /// component in bytes 2..3.
        /// </summary>
        R16g16Uint = 81, 
        
        /// <summary>
        /// VK_FORMAT_R16G16_SINT:: A two-component, 32-bit signed integer
        /// format that has a 16-bit R component in bytes 0..1, and a 16-bit G
        /// component in bytes 2..3.
        /// </summary>
        R16g16Sint = 82, 
        
        /// <summary>
        /// VK_FORMAT_R16G16_SFLOAT:: A two-component, 32-bit signed
        /// floating-point format that has a 16-bit R component in bytes 0..1,
        /// and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16g16Sfloat = 83, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16_UNORM:: A three-component, 48-bit unsigned
        /// normalized format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.
        /// </summary>
        R16g16b16Unorm = 84, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16_SNORM:: A three-component, 48-bit signed
        /// normalized format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.
        /// </summary>
        R16g16b16Snorm = 85, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16_USCALED:: A three-component, 48-bit unsigned
        /// scaled integer format that has a 16-bit R component in bytes 0..1,
        /// a 16-bit G component in bytes 2..3, and a 16-bit B component in
        /// bytes 4..5.
        /// </summary>
        R16g16b16Uscaled = 86, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16_SSCALED:: A three-component, 48-bit signed
        /// scaled integer format that has a 16-bit R component in bytes 0..1,
        /// a 16-bit G component in bytes 2..3, and a 16-bit B component in
        /// bytes 4..5.
        /// </summary>
        R16g16b16Sscaled = 87, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16_UINT:: A three-component, 48-bit unsigned
        /// integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, and a 16-bit B component in bytes
        /// 4..5.
        /// </summary>
        R16g16b16Uint = 88, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16_SINT:: A three-component, 48-bit signed integer
        /// format that has a 16-bit R component in bytes 0..1, a 16-bit G
        /// component in bytes 2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16g16b16Sint = 89, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16_SFLOAT:: A three-component, 48-bit signed
        /// floating-point format that has a 16-bit R component in bytes 0..1,
        /// a 16-bit G component in bytes 2..3, and a 16-bit B component in
        /// bytes 4..5.
        /// </summary>
        R16g16b16Sfloat = 90, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16A16_UNORM:: A four-component, 64-bit unsigned
        /// normalized format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16g16b16a16Unorm = 91, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16A16_SNORM:: A four-component, 64-bit signed
        /// normalized format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16g16b16a16Snorm = 92, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16A16_USCALED:: A four-component, 64-bit unsigned
        /// scaled integer format that has a 16-bit R component in bytes 0..1,
        /// a 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16g16b16a16Uscaled = 93, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16A16_SSCALED:: A four-component, 64-bit signed
        /// scaled integer format that has a 16-bit R component in bytes 0..1,
        /// a 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16g16b16a16Sscaled = 94, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16A16_UINT:: A four-component, 64-bit unsigned
        /// integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16g16b16a16Uint = 95, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16A16_SINT:: A four-component, 64-bit signed
        /// integer format that has a 16-bit R component in bytes 0..1, a
        /// 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16g16b16a16Sint = 96, 
        
        /// <summary>
        /// VK_FORMAT_R16G16B16A16_SFLOAT:: A four-component, 64-bit signed
        /// floating-point format that has a 16-bit R component in bytes 0..1,
        /// a 16-bit G component in bytes 2..3, a 16-bit B component in bytes
        /// 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16g16b16a16Sfloat = 97, 
        
        /// <summary>
        /// VK_FORMAT_R32_UINT:: A one-component, 32-bit unsigned integer
        /// format that has a single 32-bit R component.
        /// </summary>
        R32Uint = 98, 
        
        /// <summary>
        /// VK_FORMAT_R32_SINT:: A one-component, 32-bit signed integer format
        /// that has a single 32-bit R component.
        /// </summary>
        R32Sint = 99, 
        
        /// <summary>
        /// VK_FORMAT_R32_SFLOAT:: A one-component, 32-bit signed
        /// floating-point format that has a single 32-bit R component.
        /// </summary>
        R32Sfloat = 100, 
        
        /// <summary>
        /// VK_FORMAT_R32G32_UINT:: A two-component, 64-bit unsigned integer
        /// format that has a 32-bit R component in bytes 0..3, and a 32-bit G
        /// component in bytes 4..7.
        /// </summary>
        R32g32Uint = 101, 
        
        /// <summary>
        /// VK_FORMAT_R32G32_SINT:: A two-component, 64-bit signed integer
        /// format that has a 32-bit R component in bytes 0..3, and a 32-bit G
        /// component in bytes 4..7.
        /// </summary>
        R32g32Sint = 102, 
        
        /// <summary>
        /// VK_FORMAT_R32G32_SFLOAT:: A two-component, 64-bit signed
        /// floating-point format that has a 32-bit R component in bytes 0..3,
        /// and a 32-bit G component in bytes 4..7.
        /// </summary>
        R32g32Sfloat = 103, 
        
        /// <summary>
        /// VK_FORMAT_R32G32B32_UINT:: A three-component, 96-bit unsigned
        /// integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, and a 32-bit B component in bytes
        /// 8..11.
        /// </summary>
        R32g32b32Uint = 104, 
        
        /// <summary>
        /// VK_FORMAT_R32G32B32_SINT:: A three-component, 96-bit signed integer
        /// format that has a 32-bit R component in bytes 0..3, a 32-bit G
        /// component in bytes 4..7, and a 32-bit B component in bytes 8..11.
        /// </summary>
        R32g32b32Sint = 105, 
        
        /// <summary>
        /// VK_FORMAT_R32G32B32_SFLOAT:: A three-component, 96-bit signed
        /// floating-point format that has a 32-bit R component in bytes 0..3,
        /// a 32-bit G component in bytes 4..7, and a 32-bit B component in
        /// bytes 8..11.
        /// </summary>
        R32g32b32Sfloat = 106, 
        
        /// <summary>
        /// VK_FORMAT_R32G32B32A32_UINT:: A four-component, 128-bit unsigned
        /// integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, a 32-bit B component in bytes
        /// 8..11, and a 32-bit A component in bytes 12..15.
        /// </summary>
        R32g32b32a32Uint = 107, 
        
        /// <summary>
        /// VK_FORMAT_R32G32B32A32_SINT:: A four-component, 128-bit signed
        /// integer format that has a 32-bit R component in bytes 0..3, a
        /// 32-bit G component in bytes 4..7, a 32-bit B component in bytes
        /// 8..11, and a 32-bit A component in bytes 12..15.
        /// </summary>
        R32g32b32a32Sint = 108, 
        
        /// <summary>
        /// VK_FORMAT_R32G32B32A32_SFLOAT:: A four-component, 128-bit signed
        /// floating-point format that has a 32-bit R component in bytes 0..3,
        /// a 32-bit G component in bytes 4..7, a 32-bit B component in bytes
        /// 8..11, and a 32-bit A component in bytes 12..15.
        /// </summary>
        R32g32b32a32Sfloat = 109, 
        
        /// <summary>
        /// VK_FORMAT_R64_UINT:: A one-component, 64-bit unsigned integer
        /// format that has a single 64-bit R component.
        /// </summary>
        R64Uint = 110, 
        
        /// <summary>
        /// VK_FORMAT_R64_SINT:: A one-component, 64-bit signed integer format
        /// that has a single 64-bit R component.
        /// </summary>
        R64Sint = 111, 
        
        /// <summary>
        /// VK_FORMAT_R64_SFLOAT:: A one-component, 64-bit signed
        /// floating-point format that has a single 64-bit R component.
        /// </summary>
        R64Sfloat = 112, 
        
        /// <summary>
        /// VK_FORMAT_R64G64_UINT:: A two-component, 128-bit unsigned integer
        /// format that has a 64-bit R component in bytes 0..7, and a 64-bit G
        /// component in bytes 8..15.
        /// </summary>
        R64g64Uint = 113, 
        
        /// <summary>
        /// VK_FORMAT_R64G64_SINT:: A two-component, 128-bit signed integer
        /// format that has a 64-bit R component in bytes 0..7, and a 64-bit G
        /// component in bytes 8..15.
        /// </summary>
        R64g64Sint = 114, 
        
        /// <summary>
        /// VK_FORMAT_R64G64_SFLOAT:: A two-component, 128-bit signed
        /// floating-point format that has a 64-bit R component in bytes 0..7,
        /// and a 64-bit G component in bytes 8..15.
        /// </summary>
        R64g64Sfloat = 115, 
        
        /// <summary>
        /// VK_FORMAT_R64G64B64_UINT:: A three-component, 192-bit unsigned
        /// integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, and a 64-bit B component in
        /// bytes 16..23.
        /// </summary>
        R64g64b64Uint = 116, 
        
        /// <summary>
        /// VK_FORMAT_R64G64B64_SINT:: A three-component, 192-bit signed
        /// integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, and a 64-bit B component in
        /// bytes 16..23.
        /// </summary>
        R64g64b64Sint = 117, 
        
        /// <summary>
        /// VK_FORMAT_R64G64B64_SFLOAT:: A three-component, 192-bit signed
        /// floating-point format that has a 64-bit R component in bytes 0..7,
        /// a 64-bit G component in bytes 8..15, and a 64-bit B component in
        /// bytes 16..23.
        /// </summary>
        R64g64b64Sfloat = 118, 
        
        /// <summary>
        /// VK_FORMAT_R64G64B64A64_UINT:: A four-component, 256-bit unsigned
        /// integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, a 64-bit B component in bytes
        /// 16..23, and a 64-bit A component in bytes 24..31.
        /// </summary>
        R64g64b64a64Uint = 119, 
        
        /// <summary>
        /// VK_FORMAT_R64G64B64A64_SINT:: A four-component, 256-bit signed
        /// integer format that has a 64-bit R component in bytes 0..7, a
        /// 64-bit G component in bytes 8..15, a 64-bit B component in bytes
        /// 16..23, and a 64-bit A component in bytes 24..31.
        /// </summary>
        R64g64b64a64Sint = 120, 
        
        /// <summary>
        /// VK_FORMAT_R64G64B64A64_SFLOAT:: A four-component, 256-bit signed
        /// floating-point format that has a 64-bit R component in bytes 0..7,
        /// a 64-bit G component in bytes 8..15, a 64-bit B component in bytes
        /// 16..23, and a 64-bit A component in bytes 24..31.
        /// </summary>
        R64g64b64a64Sfloat = 121, 
        
        /// <summary>
        /// VK_FORMAT_B10G11R11_UFLOAT_PACK32:: A three-component, 32-bit
        /// packed unsigned floating-point format that has a 10-bit B component
        /// in bits 22..31, an 11-bit G component in bits 11..21, an 11-bit R
        /// component in bits 0..10. See &lt;&lt;fundamentals-fp10 and
        /// &lt;&lt;fundamentals-fp11.
        /// </summary>
        B10g11r11UfloatPack32 = 122, 
        
        /// <summary>
        /// VK_FORMAT_E5B9G9R9_UFLOAT_PACK32:: A three-component, 32-bit packed
        /// unsigned floating-point format that has a 5-bit shared exponent in
        /// bits 27..31, a 9-bit B component mantissa in bits 18..26, a 9-bit G
        /// component mantissa in bits 9..17, and a 9-bit R component mantissa
        /// in bits 0..8.
        /// </summary>
        E5b9g9r9UfloatPack32 = 123, 
        
        /// <summary>
        /// VK_FORMAT_D16_UNORM:: A one-component, 16-bit unsigned normalized
        /// format that has a single 16-bit depth component.
        /// </summary>
        D16Unorm = 124, 
        
        /// <summary>
        /// VK_FORMAT_X8_D24_UNORM_PACK32:: A two-component, 32-bit format that
        /// has 24 unsigned normalized bits in the depth component and,
        /// optionally:, 8 bits that are unused.
        /// </summary>
        X8D24UnormPack32 = 125, 
        
        /// <summary>
        /// VK_FORMAT_D32_SFLOAT:: A one-component, 32-bit signed
        /// floating-point format that has 32-bits in the depth component.
        /// </summary>
        D32Sfloat = 126, 
        
        /// <summary>
        /// VK_FORMAT_S8_UINT:: A one-component, 8-bit unsigned integer format
        /// that has 8-bits in the stencil component.
        /// </summary>
        S8Uint = 127, 
        
        /// <summary>
        /// VK_FORMAT_D16_UNORM_S8_UINT:: A two-component, 24-bit format that
        /// has 16 unsigned normalized bits in the depth component and 8
        /// unsigned integer bits in the stencil component.
        /// </summary>
        D16UnormS8Uint = 128, 
        
        /// <summary>
        /// VK_FORMAT_D24_UNORM_S8_UINT:: A two-component, 32-bit packed format
        /// that has 8 unsigned integer bits in the stencil component, and 24
        /// unsigned normalized bits in the depth component.
        /// </summary>
        D24UnormS8Uint = 129, 
        
        /// <summary>
        /// VK_FORMAT_D32_SFLOAT_S8_UINT:: A two-component format that has 32
        /// signed float bits in the depth component and 8 unsigned integer
        /// bits in the stencil component. There are optionally: 24-bits that
        /// are unused.
        /// </summary>
        D32SfloatS8Uint = 130, 
        
        /// <summary>
        /// VK_FORMAT_BC1_RGB_UNORM_BLOCK:: A three-component, block-compressed
        /// format where each 64-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGB texel data. This format has no
        /// alpha and is considered opaque.
        /// </summary>
        Bc1RgbUnormBlock = 131, 
        
        /// <summary>
        /// VK_FORMAT_BC1_RGB_SRGB_BLOCK:: A three-component, block-compressed
        /// format where each 64-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGB texel data with sRGB nonlinear
        /// encoding. This format has no alpha and is considered opaque.
        /// </summary>
        Bc1RgbSrgbBlock = 132, 
        
        /// <summary>
        /// VK_FORMAT_BC1_RGBA_UNORM_BLOCK:: A four-component, block-compressed
        /// format where each 64-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGB texel data, and provides 1 bit
        /// of alpha.
        /// </summary>
        Bc1RgbaUnormBlock = 133, 
        
        /// <summary>
        /// VK_FORMAT_BC1_RGBA_SRGB_BLOCK:: A four-component, block-compressed
        /// format where each 64-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGB texel data with sRGB nonlinear
        /// encoding, and provides 1 bit of alpha.
        /// </summary>
        Bc1RgbaSrgbBlock = 134, 
        
        /// <summary>
        /// VK_FORMAT_BC2_UNORM_BLOCK:: A four-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGBA texel data with the first 64
        /// bits encoding alpha values followed by 64 bits encoding RGB values.
        /// </summary>
        Bc2UnormBlock = 135, 
        
        /// <summary>
        /// VK_FORMAT_BC2_SRGB_BLOCK:: A four-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGBA texel data with the first 64
        /// bits encoding alpha values followed by 64 bits encoding RGB values
        /// with sRGB nonlinear encoding.
        /// </summary>
        Bc2SrgbBlock = 136, 
        
        /// <summary>
        /// VK_FORMAT_BC3_UNORM_BLOCK:: A four-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGBA texel data with the first 64
        /// bits encoding alpha values followed by 64 bits encoding RGB values.
        /// </summary>
        Bc3UnormBlock = 137, 
        
        /// <summary>
        /// VK_FORMAT_BC3_SRGB_BLOCK:: A four-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGBA texel data with the first 64
        /// bits encoding alpha values followed by 64 bits encoding RGB values
        /// with sRGB nonlinear encoding.
        /// </summary>
        Bc3SrgbBlock = 138, 
        
        /// <summary>
        /// VK_FORMAT_BC4_UNORM_BLOCK:: A one-component, block-compressed
        /// format where each 64-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized red texel data.
        /// </summary>
        Bc4UnormBlock = 139, 
        
        /// <summary>
        /// VK_FORMAT_BC4_SNORM_BLOCK:: A one-component, block-compressed
        /// format where each 64-bit compressed texel block encodes a 4x4
        /// rectangle of signed normalized red texel data.
        /// </summary>
        Bc4SnormBlock = 140, 
        
        /// <summary>
        /// VK_FORMAT_BC5_UNORM_BLOCK:: A two-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RG texel data with the first 64
        /// bits encoding red values followed by 64 bits encoding green values.
        /// </summary>
        Bc5UnormBlock = 141, 
        
        /// <summary>
        /// VK_FORMAT_BC5_SNORM_BLOCK:: A two-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of signed normalized RG texel data with the first 64 bits
        /// encoding red values followed by 64 bits encoding green values.
        /// </summary>
        Bc5SnormBlock = 142, 
        
        /// <summary>
        /// VK_FORMAT_BC6H_UFLOAT_BLOCK:: A three-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned floating-point RGB texel data.
        /// </summary>
        Bc6hUfloatBlock = 143, 
        
        /// <summary>
        /// VK_FORMAT_BC6H_SFLOAT_BLOCK:: A three-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of signed floating-point RGB texel data.
        /// </summary>
        Bc6hSfloatBlock = 144, 
        
        /// <summary>
        /// VK_FORMAT_BC7_UNORM_BLOCK:: A four-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Bc7UnormBlock = 145, 
        
        /// <summary>
        /// VK_FORMAT_BC7_SRGB_BLOCK:: A four-component, block-compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Bc7SrgbBlock = 146, 
        
        /// <summary>
        /// VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK:: A three-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGB texel data. This format
        /// has no alpha and is considered opaque.
        /// </summary>
        Etc2R8g8b8UnormBlock = 147, 
        
        /// <summary>
        /// VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK:: A three-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGB texel data with sRGB
        /// nonlinear encoding. This format has no alpha and is considered
        /// opaque.
        /// </summary>
        Etc2R8g8b8SrgbBlock = 148, 
        
        /// <summary>
        /// VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK:: A four-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGB texel data, and provides
        /// 1 bit of alpha.
        /// </summary>
        Etc2R8g8b8a1UnormBlock = 149, 
        
        /// <summary>
        /// VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK:: A four-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGB texel data with sRGB
        /// nonlinear encoding, and provides 1 bit of alpha.
        /// </summary>
        Etc2R8g8b8a1SrgbBlock = 150, 
        
        /// <summary>
        /// VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK:: A four-component, ETC2
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGBA texel data with the
        /// first 64 bits encoding alpha values followed by 64 bits encoding
        /// RGB values.
        /// </summary>
        Etc2R8g8b8a8UnormBlock = 151, 
        
        /// <summary>
        /// VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK:: A four-component, ETC2
        /// compressed format where each 64-bit compressed texel block encodes
        /// a 4x4 rectangle of unsigned normalized RGBA texel data with the
        /// first 64 bits encoding alpha values followed by 64 bits encoding
        /// RGB values with sRGB nonlinear encoding applied.
        /// </summary>
        Etc2R8g8b8a8SrgbBlock = 152, 
        
        /// <summary>
        /// VK_FORMAT_EAC_R11_UNORM_BLOCK:: A one-component, ETC2 compressed
        /// format where each 64-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized red texel data.
        /// </summary>
        EacR11UnormBlock = 153, 
        
        /// <summary>
        /// VK_FORMAT_EAC_R11_SNORM_BLOCK:: A one-component, ETC2 compressed
        /// format where each 64-bit compressed texel block encodes a 4x4
        /// rectangle of signed normalized red texel data.
        /// </summary>
        EacR11SnormBlock = 154, 
        
        /// <summary>
        /// VK_FORMAT_EAC_R11G11_UNORM_BLOCK:: A two-component, ETC2 compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RG texel data with the first 64
        /// bits encoding red values followed by 64 bits encoding green values.
        /// </summary>
        EacR11g11UnormBlock = 155, 
        
        /// <summary>
        /// VK_FORMAT_EAC_R11G11_SNORM_BLOCK:: A two-component, ETC2 compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of signed normalized RG texel data with the first 64 bits
        /// encoding red values followed by 64 bits encoding green values.
        /// </summary>
        EacR11g11SnormBlock = 156, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_4x4_UNORM_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc4x4UnormBlock = 157, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_4x4_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 4x4
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc4x4SrgbBlock = 158, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_5x4_UNORM_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 5x4
        /// rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc5x4UnormBlock = 159, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_5x4_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 5x4
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc5x4SrgbBlock = 160, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_5x5_UNORM_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 5x5
        /// rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc5x5UnormBlock = 161, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_5x5_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 5x5
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc5x5SrgbBlock = 162, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_6x5_UNORM_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 6x5
        /// rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc6x5UnormBlock = 163, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_6x5_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 6x5
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc6x5SrgbBlock = 164, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_6x6_UNORM_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 6x6
        /// rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc6x6UnormBlock = 165, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_6x6_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 6x6
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc6x6SrgbBlock = 166, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_8x5_UNORM_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes an 8x5
        /// rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc8x5UnormBlock = 167, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_8x5_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes an 8x5
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc8x5SrgbBlock = 168, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_8x6_UNORM_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes an 8x6
        /// rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc8x6UnormBlock = 169, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_8x6_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes an 8x6
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc8x6SrgbBlock = 170, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_8x8_UNORM_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes an 8x8
        /// rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc8x8UnormBlock = 171, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_8x8_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes an 8x8
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc8x8SrgbBlock = 172, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_10x5_UNORM_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 10x5
        /// rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc10x5UnormBlock = 173, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_10x5_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 10x5
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc10x5SrgbBlock = 174, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_10x6_UNORM_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 10x6
        /// rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc10x6UnormBlock = 175, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_10x6_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 10x6
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc10x6SrgbBlock = 176, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_10x8_UNORM_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 10x8
        /// rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc10x8UnormBlock = 177, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_10x8_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 10x8
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc10x8SrgbBlock = 178, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_10x10_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 10x10 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc10x10UnormBlock = 179, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_10x10_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 10x10
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc10x10SrgbBlock = 180, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_12x10_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 12x10 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc12x10UnormBlock = 181, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_12x10_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 12x10
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc12x10SrgbBlock = 182, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_12x12_UNORM_BLOCK:: A four-component, ASTC
        /// compressed format where each 128-bit compressed texel block encodes
        /// a 12x12 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc12x12UnormBlock = 183, 
        
        /// <summary>
        /// VK_FORMAT_ASTC_12x12_SRGB_BLOCK:: A four-component, ASTC compressed
        /// format where each 128-bit compressed texel block encodes a 12x12
        /// rectangle of unsigned normalized RGBA texel data with sRGB
        /// nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc12x12SrgbBlock = 184, 
        
        /// <summary>
        /// 
        /// </summary>
        Pvrtc12bppUnormBlockImg = 1000054000, 
        
        /// <summary>
        /// 
        /// </summary>
        Pvrtc14bppUnormBlockImg = 1000054001, 
        
        /// <summary>
        /// 
        /// </summary>
        Pvrtc22bppUnormBlockImg = 1000054002, 
        
        /// <summary>
        /// 
        /// </summary>
        Pvrtc24bppUnormBlockImg = 1000054003, 
        
        /// <summary>
        /// 
        /// </summary>
        Pvrtc12bppSrgbBlockImg = 1000054004, 
        
        /// <summary>
        /// 
        /// </summary>
        Pvrtc14bppSrgbBlockImg = 1000054005, 
        
        /// <summary>
        /// 
        /// </summary>
        Pvrtc22bppSrgbBlockImg = 1000054006, 
        
        /// <summary>
        /// 
        /// </summary>
        Pvrtc24bppSrgbBlockImg = 1000054007, 
        
        /// <summary>
        /// 
        /// </summary>
        G8b8g8r8422UnormKhr = 1000156000, 
        
        /// <summary>
        /// 
        /// </summary>
        B8g8r8g8422UnormKhr = 1000156001, 
        
        /// <summary>
        /// 
        /// </summary>
        G8B8R83plane420UnormKhr = 1000156002, 
        
        /// <summary>
        /// 
        /// </summary>
        G8B8r82plane420UnormKhr = 1000156003, 
        
        /// <summary>
        /// 
        /// </summary>
        G8B8R83plane422UnormKhr = 1000156004, 
        
        /// <summary>
        /// 
        /// </summary>
        G8B8r82plane422UnormKhr = 1000156005, 
        
        /// <summary>
        /// 
        /// </summary>
        G8B8R83plane444UnormKhr = 1000156006, 
        
        /// <summary>
        /// 
        /// </summary>
        R10x6UnormPack16Khr = 1000156007, 
        
        /// <summary>
        /// 
        /// </summary>
        R10x6g10x6Unorm2pack16Khr = 1000156008, 
        
        /// <summary>
        /// 
        /// </summary>
        R10x6g10x6b10x6a10x6Unorm4pack16Khr = 1000156009, 
        
        /// <summary>
        /// 
        /// </summary>
        G10x6b10x6g10x6r10x6422Unorm4pack16Khr = 1000156010, 
        
        /// <summary>
        /// 
        /// </summary>
        B10x6g10x6r10x6g10x6422Unorm4pack16Khr = 1000156011, 
        
        /// <summary>
        /// 
        /// </summary>
        G10x6B10x6R10x63plane420Unorm3pack16Khr = 1000156012, 
        
        /// <summary>
        /// 
        /// </summary>
        G10x6B10x6r10x62plane420Unorm3pack16Khr = 1000156013, 
        
        /// <summary>
        /// 
        /// </summary>
        G10x6B10x6R10x63plane422Unorm3pack16Khr = 1000156014, 
        
        /// <summary>
        /// 
        /// </summary>
        G10x6B10x6r10x62plane422Unorm3pack16Khr = 1000156015, 
        
        /// <summary>
        /// 
        /// </summary>
        G10x6B10x6R10x63plane444Unorm3pack16Khr = 1000156016, 
        
        /// <summary>
        /// 
        /// </summary>
        R12x4UnormPack16Khr = 1000156017, 
        
        /// <summary>
        /// 
        /// </summary>
        R12x4g12x4Unorm2pack16Khr = 1000156018, 
        
        /// <summary>
        /// 
        /// </summary>
        R12x4g12x4b12x4a12x4Unorm4pack16Khr = 1000156019, 
        
        /// <summary>
        /// 
        /// </summary>
        G12x4b12x4g12x4r12x4422Unorm4pack16Khr = 1000156020, 
        
        /// <summary>
        /// 
        /// </summary>
        B12x4g12x4r12x4g12x4422Unorm4pack16Khr = 1000156021, 
        
        /// <summary>
        /// 
        /// </summary>
        G12x4B12x4R12x43plane420Unorm3pack16Khr = 1000156022, 
        
        /// <summary>
        /// 
        /// </summary>
        G12x4B12x4r12x42plane420Unorm3pack16Khr = 1000156023, 
        
        /// <summary>
        /// 
        /// </summary>
        G12x4B12x4R12x43plane422Unorm3pack16Khr = 1000156024, 
        
        /// <summary>
        /// 
        /// </summary>
        G12x4B12x4r12x42plane422Unorm3pack16Khr = 1000156025, 
        
        /// <summary>
        /// 
        /// </summary>
        G12x4B12x4R12x43plane444Unorm3pack16Khr = 1000156026, 
        
        /// <summary>
        /// 
        /// </summary>
        G16b16g16r16422UnormKhr = 1000156027, 
        
        /// <summary>
        /// 
        /// </summary>
        B16g16r16g16422UnormKhr = 1000156028, 
        
        /// <summary>
        /// 
        /// </summary>
        G16B16R163plane420UnormKhr = 1000156029, 
        
        /// <summary>
        /// 
        /// </summary>
        G16B16r162plane420UnormKhr = 1000156030, 
        
        /// <summary>
        /// 
        /// </summary>
        G16B16R163plane422UnormKhr = 1000156031, 
        
        /// <summary>
        /// 
        /// </summary>
        G16B16r162plane422UnormKhr = 1000156032, 
        
        /// <summary>
        /// 
        /// </summary>
        G16B16R163plane444UnormKhr = 1000156033, 
    }
}
