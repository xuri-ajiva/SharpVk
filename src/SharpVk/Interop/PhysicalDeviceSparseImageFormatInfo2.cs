using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceSparseImageFormatInfo2
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceSparseImageFormatInfo2(StructureType sType, void* next, Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling)
        {
            this.SType = sType;
            this.Next = next;
            this.Format = format;
            this.Type = type;
            this.Samples = samples;
            this.Usage = usage;
            this.Tiling = tiling;
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
        public SampleCountFlags Samples; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageUsageFlags Usage; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageTiling Tiling; 
    }
}
