using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct QueueFamilyProperties2
    {
        /// <summary>
        /// 
        /// </summary>
        public QueueFamilyProperties2(StructureType sType, void* next, QueueFamilyProperties queueFamilyProperties)
        {
            this.SType = sType;
            this.Next = next;
            this.QueueFamilyProperties = queueFamilyProperties;
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
        public QueueFamilyProperties QueueFamilyProperties; 
    }
}
