using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct QueueFamilyProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public QueueFamilyProperties(QueueFlags queueFlags, uint queueCount, uint timestampValidBits, Extent3D minImageTransferGranularity)
        {
            this.QueueFlags = queueFlags;
            this.QueueCount = queueCount;
            this.TimestampValidBits = timestampValidBits;
            this.MinImageTransferGranularity = minImageTransferGranularity;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public QueueFlags QueueFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint QueueCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint TimestampValidBits; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent3D MinImageTransferGranularity; 
    }
}
