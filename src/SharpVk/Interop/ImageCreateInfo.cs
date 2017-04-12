using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ImageCreateInfo
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
        public ImageCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageType ImageType; 
        
        /// <summary>
        /// 
        /// </summary>
        public Format Format; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent3D Extent; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MipLevels; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ArrayLayers; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags Samples; 
        
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
        public SharingMode SharingMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint QueueFamilyIndexCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* QueueFamilyIndices; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageLayout InitialLayout; 
    }
}
