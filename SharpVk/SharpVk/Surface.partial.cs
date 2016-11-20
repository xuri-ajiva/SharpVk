namespace SharpVk
{
    public partial class Surface
    {
        /// <summary>
        /// Create a new Surface instance from an externally created handle.
        /// </summary>
        /// <param name="instance">
        /// The Vulkan Instance against which the handle was created.
        /// </param>
        /// <param name="handle">
        /// An unsigned 64-bit integer representing the created Surface.
        /// </param>
        /// <returns>
        /// A Surface instance.
        /// </returns>
        public static Surface CreateFromHandle(Instance instance, ulong handle)
        {
            return new Surface(new Interop.Surface(handle), instance, instance.commandCache);
        }
    }
}
