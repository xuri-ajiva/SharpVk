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
