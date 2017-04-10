using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct FormatProperties2
    {
        /// <summary>
        /// 
        /// </summary>
        public FormatProperties2(StructureType sType, void* next, FormatProperties formatProperties)
        {
            this.SType = sType;
            this.Next = next;
            this.FormatProperties = formatProperties;
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
        public FormatProperties FormatProperties; 
    }
}
