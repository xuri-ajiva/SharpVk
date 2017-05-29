namespace SharpVk
{
    public partial class Instance
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="createInfo"></param>
        /// <param name="allocator"></param>
        /// <returns></returns>
        public static Instance _Create(InstanceCreateInfo createInfo, AllocationCallbacks? allocator = null)
        {
            unsafe
            {
                try
                {
                    Instance result = default(Instance);
                    Result commandResult;
                    Interop.InstanceCreateInfo marshalledCreateInfo;
                    createInfo.MarshalTo(&marshalledCreateInfo);
                    Interop.AllocationCallbacks marshalledAllocator;
                    allocator?.MarshalTo(&marshalledAllocator);
                    Interop.Instance marshalledInstance;
                    commandResult = Interop.Commands.vkCreateInstance(&marshalledCreateInfo, allocator == null ? null : &marshalledAllocator, &marshalledInstance);
                    
                    result = new Instance(marshalledInstance);
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeAll();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public PhysicalDevice[] _EnumeratePhysicalDevices()
        {
            unsafe
            {
                try
                {
                    PhysicalDevice[] result = default(PhysicalDevice[]);
                    Result commandResult;
                    uint physicalDeviceCount;
                    Interop.PhysicalDevice* marshalledPhysicalDevices = null;
                    commandResult = Interop.Commands.vkEnumeratePhysicalDevices(this.handle, &physicalDeviceCount, null);

                    marshalledPhysicalDevices = (Interop.PhysicalDevice*)Interop.HeapUtil.Allocate<Interop.PhysicalDevice>((uint)physicalDeviceCount);
                    commandResult = Interop.Commands.vkEnumeratePhysicalDevices(this.handle, &physicalDeviceCount, marshalledPhysicalDevices);

                    result = new PhysicalDevice[(uint)physicalDeviceCount];
                    for (int index = 0; index < (uint)physicalDeviceCount; index++)
                    {
                        result[index] = new PhysicalDevice(marshalledPhysicalDevices[index]);
                    }
                    return result;
                }
                finally
                {
                    Interop.HeapUtil.FreeAll();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static LayerProperties[] _EnumerateLayerProperties()
        {
            unsafe
            {
                try
                {
                    LayerProperties[] result = default(LayerProperties[]);
                    Result commandResult;
                    uint propertyCount;
                    Interop.LayerProperties* marshalledProperties = null;
                    commandResult = Interop.Commands.vkEnumerateInstanceLayerProperties(&propertyCount, null);

                    marshalledProperties = (Interop.LayerProperties*)Interop.HeapUtil.Allocate<Interop.LayerProperties>((uint)propertyCount);
                    commandResult = Interop.Commands.vkEnumerateInstanceLayerProperties(&propertyCount, marshalledProperties);

                    result = new LayerProperties[(uint)propertyCount];
                    for (int index = 0; index < (uint)propertyCount; index++)
                    {
                        result[index] = LayerProperties.MarshalFrom(&marshalledProperties[index]);
                    }
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
