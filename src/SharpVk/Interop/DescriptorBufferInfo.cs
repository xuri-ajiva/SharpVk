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
        public DescriptorBufferInfo(Buffer buffer, DeviceSize offset, DeviceSize range)
        {
            this.Buffer = buffer;
            this.Offset = offset;
            this.Range = range;
        }
        
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
