//The MIT License (MIT)
//
//Copyright (c) Andrew Armstrong/FacticiusVir 2016
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

namespace SharpVk
{
	public static class KhrSurface
	{
		public const uint SpecVersion = 25;
		public const string ExtensionName = "VK_KHR_surface";
	}

	public static class KhrSwapchain
	{
		public const uint SpecVersion = 68;
		public const string ExtensionName = "VK_KHR_swapchain";
	}

	public static class KhrWin32Surface
	{
		public const uint SpecVersion = 5;
		public const string ExtensionName = "VK_KHR_win32_surface";
	}

	public static class ExtDebugReport
	{
		public const uint SpecVersion = 3;
		public const string ExtensionName = "VK_EXT_debug_report";
	}

	public static class Constants
	{
		public const float LodClampNone = 1000.0f;
		public const uint RemainingMipLevels = ~0U;
		public const uint RemainingArrayLayers = ~0U;
		public const ulong WholeSize = ~0UL;
		public const uint AttachmentUnused = ~0U;
		public const uint True = 1;
		public const uint False = 0;
		public const uint QueueFamilyIgnored = ~0U;
		public const uint SubpassExternal = ~0U;
		public const uint MaxExtensionNameSize = 256;
		public const uint MaxDescriptionSize = 256;
		public const uint MaxMemoryTypes = 32;
		public const uint MaxMemoryHeaps = 16;
		public const uint MaxPhysicalDeviceNameSize = 256;
		public const uint UuidSize = 16;
	}

}