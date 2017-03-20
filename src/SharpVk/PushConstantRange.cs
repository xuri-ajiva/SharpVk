using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct PushConstantRange
    {
        /// <summary>
        /// 
        /// </summary>
        public PushConstantRange(ShaderStageFlags stageFlags, uint offset, uint size)
        {
            this.StageFlags = stageFlags;
            this.Offset = offset;
            this.Size = size;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ShaderStageFlags StageFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Offset; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Size; 
    }
}
