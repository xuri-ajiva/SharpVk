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

	public static class KhrDisplay
	{
		public const uint SpecVersion = 21;
		public const string ExtensionName = "VK_KHR_display";
	}

	public static class KhrDisplaySwapchain
	{
		public const uint SpecVersion = 9;
		public const string ExtensionName = "VK_KHR_display_swapchain";
	}

	public static class KhrXlibSurface
	{
		public const uint SpecVersion = 6;
		public const string ExtensionName = "VK_KHR_xlib_surface";
	}

	public static class KhrXcbSurface
	{
		public const uint SpecVersion = 6;
		public const string ExtensionName = "VK_KHR_xcb_surface";
	}

	public static class KhrWaylandSurface
	{
		public const uint SpecVersion = 5;
		public const string ExtensionName = "VK_KHR_wayland_surface";
	}

	public static class KhrMirSurface
	{
		public const uint SpecVersion = 4;
		public const string ExtensionName = "VK_KHR_mir_surface";
	}

	public static class KhrAndroidSurface
	{
		public const uint SpecVersion = 6;
		public const string ExtensionName = "VK_KHR_android_surface";
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

	public static class NvGlslShader
	{
		public const uint SpecVersion = 1;
		public const string ExtensionName = "VK_NV_glsl_shader";
	}

	public static class KhrSamplerMirrorClampToEdge
	{
		public const uint SpecVersion = 1;
		public const string ExtensionName = "VK_KHR_sampler_mirror_clamp_to_edge";
	}

	public static class ImgFilterCubic
	{
		public const uint SpecVersion = 1;
		public const string ExtensionName = "VK_IMG_filter_cubic";
	}

	public static class AmdRasterizationOrder
	{
		public const uint SpecVersion = 1;
		public const string ExtensionName = "VK_AMD_rasterization_order";
	}

	public static class AmdShaderTrinaryMinmax
	{
		public const uint SpecVersion = 1;
		public const string ExtensionName = "VK_AMD_shader_trinary_minmax";
	}

	public static class AmdShaderExplicitVertexParameter
	{
		public const uint SpecVersion = 1;
		public const string ExtensionName = "VK_AMD_shader_explicit_vertex_parameter";
	}

	public static class ExtDebugMarker
	{
		public const uint SpecVersion = 3;
		public const string ExtensionName = "VK_EXT_debug_marker";
	}

	public static class AmdGcnShader
	{
		public const uint SpecVersion = 1;
		public const string ExtensionName = "VK_AMD_gcn_shader";
	}

	public static class NvDedicatedAllocation
	{
		public const uint SpecVersion = 1;
		public const string ExtensionName = "VK_NV_dedicated_allocation";
	}

	public static class ImgFormatPvrtc
	{
		public const uint SpecVersion = 1;
		public const string ExtensionName = "VK_IMG_format_pvrtc";
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