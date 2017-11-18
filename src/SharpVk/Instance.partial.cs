namespace SharpVk
{
    partial class Instance
    {
        /// <summary>
        /// Create a new Vulkan instance.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="applicationInfo">
        /// Null or an instance of ApplicationInfo. If not Null, this
        /// information helps implementations recognize behavior inherent to
        /// classes of applications. ApplicationInfo is defined in detail
        /// below.
        /// </param>
        /// <param name="enabledLayerNames">
        /// An array of enabledLayerCount strings containing the names of
        /// layers to enable for the created instance. See the Layers section
        /// for further details.
        /// </param>
        /// <param name="enabledExtensionNames">
        /// An array of enabledExtensionCount strings containing the names of
        /// extensions to enable.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Instance Create(ArrayProxy<string>? enabledLayerNames, ArrayProxy<string>? enabledExtensionNames, SharpVk.InstanceCreateFlags? flags = default(SharpVk.InstanceCreateFlags?), SharpVk.ApplicationInfo? applicationInfo = default(SharpVk.ApplicationInfo?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            return Instance.Create(new CommandCache(new SharpVk.Interop.NativeLibrary(), "", null), enabledLayerNames, enabledExtensionNames, flags, applicationInfo, allocator);
        }

        /// <summary>
        /// Returns up to requested number of global extension properties.
        /// </summary>
        public static unsafe SharpVk.ExtensionProperties[] EnumerateExtensionProperties(string layerName)
        {
            return Instance.EnumerateExtensionProperties(new CommandCache(new SharpVk.Interop.NativeLibrary(), "", null), layerName);
        }

        /// <summary>
        /// Returns up to requested number of global layer properties.
        /// </summary>
        public static unsafe SharpVk.LayerProperties[] EnumerateLayerProperties()
        {
            return Instance.EnumerateLayerProperties(new CommandCache(new SharpVk.Interop.NativeLibrary(), "", null));
        }
    }
}
