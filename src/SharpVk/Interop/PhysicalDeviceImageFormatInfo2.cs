using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceImageFormatInfo2
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceImageFormatInfo2(StructureType sType, void* next, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags)
        {
            this.SType = sType;
            this.Next = next;
            this.Format = format;
            this.Type = type;
            this.Tiling = tiling;
            this.Usage = usage;
            this.Flags = flags;
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
        public Format Format; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageType Type; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageTiling Tiling; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageUsageFlags Usage; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageCreateFlags Flags; 
    }
}
