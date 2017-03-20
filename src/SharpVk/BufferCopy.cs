using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct BufferCopy
    {
        /// <summary>
        /// 
        /// </summary>
        public BufferCopy(DeviceSize sourceOffset, DeviceSize destinationOffset, DeviceSize size)
        {
            this.SourceOffset = sourceOffset;
            this.DestinationOffset = destinationOffset;
            this.Size = size;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize SourceOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize DestinationOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Size; 
    }
}
