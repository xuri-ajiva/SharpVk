using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct BufferViewCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public BufferViewCreateInfo(StructureType sType, void* next, BufferViewCreateFlags flags, Buffer buffer, Format format, DeviceSize offset, DeviceSize range)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Buffer = buffer;
            this.Format = format;
            this.Offset = offset;
            this.Range = range;
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
        public BufferViewCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Buffer Buffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public Format Format; 
        
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
