using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DescriptorBufferInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public Buffer Buffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Offset; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Range; 
    }
}
