using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct BindImageMemoryInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public BindImageMemoryInfo(StructureType sType, void* next, Image image, DeviceMemory memory, DeviceSize memoryOffset, uint deviceIndexCount, uint* deviceIndices, uint sFRRectCount, Rect2D* sFRRects)
        {
            this.SType = sType;
            this.Next = next;
            this.Image = image;
            this.Memory = memory;
            this.MemoryOffset = memoryOffset;
            this.DeviceIndexCount = deviceIndexCount;
            this.DeviceIndices = deviceIndices;
            this.SFRRectCount = sFRRectCount;
            this.SFRRects = sFRRects;
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
        public Image Image; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceMemory Memory; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize MemoryOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DeviceIndexCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* DeviceIndices; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SFRRectCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Rect2D* SFRRects; 
    }
}
