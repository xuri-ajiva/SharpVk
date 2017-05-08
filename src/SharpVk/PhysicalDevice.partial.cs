namespace SharpVk
{
    public partial class PhysicalDevice
    {
        /// <summary>
        /// Returns properties of a physical device.
        /// </summary>
        public PhysicalDeviceProperties _GetProperties()
        {
            unsafe
            {
                try
                {
                    PhysicalDeviceProperties result = default(PhysicalDeviceProperties);
                    Interop.PhysicalDeviceProperties marshalledProperties;
                    Interop.Commands.vkGetPhysicalDeviceProperties(this.handle, &marshalledProperties);
                    result = PhysicalDeviceProperties.MarshalFrom(&marshalledProperties);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeAll();
                }
            }
        }
    }
}
