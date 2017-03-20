using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct SubresourceLayout
    {
        /// <summary>
        /// 
        /// </summary>
        public SubresourceLayout(DeviceSize offset, DeviceSize size, DeviceSize rowPitch, DeviceSize arrayPitch, DeviceSize depthPitch)
        {
            this.Offset = offset;
            this.Size = size;
            this.RowPitch = rowPitch;
            this.ArrayPitch = arrayPitch;
            this.DepthPitch = depthPitch;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Offset; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Size; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize RowPitch; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize ArrayPitch; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize DepthPitch; 
    }
}
