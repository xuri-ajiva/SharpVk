using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ExternalBufferProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public ExternalBufferProperties(StructureType sType, void* next, ExternalMemoryProperties externalMemoryProperties)
        {
            this.SType = sType;
            this.Next = next;
            this.ExternalMemoryProperties = externalMemoryProperties;
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
        public ExternalMemoryProperties ExternalMemoryProperties; 
    }
}
