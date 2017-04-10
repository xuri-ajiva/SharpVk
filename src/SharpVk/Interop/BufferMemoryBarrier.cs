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
        public BufferMemoryBarrier(StructureType sType, void* next, AccessFlags sourceAccessMask, AccessFlags destinationAccessMask, uint sourceQueueFamilyIndex, uint destinationQueueFamilyIndex, Buffer buffer, DeviceSize offset, DeviceSize size)
        {
            this.SType = sType;
            this.Next = next;
            this.SourceAccessMask = sourceAccessMask;
            this.DestinationAccessMask = destinationAccessMask;
            this.SourceQueueFamilyIndex = sourceQueueFamilyIndex;
            this.DestinationQueueFamilyIndex = destinationQueueFamilyIndex;
            this.Buffer = buffer;
            this.Offset = offset;
            this.Size = size;
        }
        
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
