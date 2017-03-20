using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct VertexInputAttributeDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public VertexInputAttributeDescription(uint location, uint binding, Format format, uint offset)
        {
            this.Location = location;
            this.Binding = binding;
            this.Format = format;
            this.Offset = offset;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Location; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Binding; 
        
        /// <summary>
        /// 
        /// </summary>
        public Format Format; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Offset; 
    }
}
