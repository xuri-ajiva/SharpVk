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
        public IndirectCommandsToken(IndirectCommandsTokenType tokenType, Buffer buffer, DeviceSize offset)
        {
            this.TokenType = tokenType;
            this.Buffer = buffer;
            this.Offset = offset;
        }
        
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
