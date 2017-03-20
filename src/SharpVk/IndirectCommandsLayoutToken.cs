using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct IndirectCommandsLayoutToken
    {
        /// <summary>
        /// 
        /// </summary>
        public IndirectCommandsLayoutToken(IndirectCommandsTokenType tokenType, uint bindingUnit, uint dynamicCount, uint divisor)
        {
            this.TokenType = tokenType;
            this.BindingUnit = bindingUnit;
            this.DynamicCount = dynamicCount;
            this.Divisor = divisor;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IndirectCommandsTokenType TokenType; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint BindingUnit; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DynamicCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Divisor; 
    }
}
