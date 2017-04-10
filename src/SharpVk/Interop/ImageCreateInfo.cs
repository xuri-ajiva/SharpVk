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
        public ImageCreateInfo(StructureType sType, void* next, ImageCreateFlags flags, ImageType imageType, Format format, Extent3D extent, uint mipLevels, uint arrayLayers, SampleCountFlags samples, ImageTiling tiling, ImageUsageFlags usage, SharingMode sharingMode, uint queueFamilyIndexCount, uint* queueFamilyIndices, ImageLayout initialLayout)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.ImageType = imageType;
            this.Format = format;
            this.Extent = extent;
            this.MipLevels = mipLevels;
            this.ArrayLayers = arrayLayers;
            this.Samples = samples;
            this.Tiling = tiling;
            this.Usage = usage;
            this.SharingMode = sharingMode;
            this.QueueFamilyIndexCount = queueFamilyIndexCount;
            this.QueueFamilyIndices = queueFamilyIndices;
            this.InitialLayout = initialLayout;
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
