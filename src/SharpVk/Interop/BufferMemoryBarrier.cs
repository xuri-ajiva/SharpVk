using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct BufferMemoryBarrier
    {
        /// <summary>
        /// 
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public AccessFlags SourceAccessMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public AccessFlags DestinationAccessMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SourceQueueFamilyIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DestinationQueueFamilyIndex; 
        
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
        public DeviceSize Size; 
    }
}
