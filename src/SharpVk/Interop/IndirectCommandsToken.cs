using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct IndirectCommandsToken
    {
        /// <summary>
        /// 
        /// </summary>
        public IndirectCommandsTokenType TokenType; 
        
        /// <summary>
        /// 
        /// </summary>
        public Buffer Buffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceSize Offset; 
    }
}
