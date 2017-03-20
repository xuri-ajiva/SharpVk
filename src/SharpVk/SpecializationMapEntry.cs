using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct SpecializationMapEntry
    {
        /// <summary>
        /// 
        /// </summary>
        public SpecializationMapEntry(uint constantID, uint offset, HostSize size)
        {
            this.ConstantID = constantID;
            this.Offset = offset;
            this.Size = size;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ConstantID; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Offset; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize Size; 
    }
}
