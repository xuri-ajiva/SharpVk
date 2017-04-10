using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ImageFormatProperties2
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageFormatProperties2(StructureType sType, void* next, ImageFormatProperties imageFormatProperties)
        {
            this.SType = sType;
            this.Next = next;
            this.ImageFormatProperties = imageFormatProperties;
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
        public ImageFormatProperties ImageFormatProperties; 
    }
}
