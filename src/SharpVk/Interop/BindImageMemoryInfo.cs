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
