using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct ImageFormatProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageFormatProperties(Extent3D maxExtent, uint maxMipLevels, uint maxArrayLayers, SampleCountFlags sampleCounts, DeviceSize maxResourceSize)
        {
            this.MaxExtent = maxExtent;
            this.MaxMipLevels = maxMipLevels;
            this.MaxArrayLayers = maxArrayLayers;
            this.SampleCounts = sampleCounts;
            this.MaxResourceSize = maxResourceSize;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Extent3D MaxExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMipLevels; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxArrayLayers; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags SampleCounts; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize MaxResourceSize; 
    }
}
