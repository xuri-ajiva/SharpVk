using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ShaderModuleCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public ShaderModuleCreateInfo(StructureType sType, void* next, ShaderModuleCreateFlags flags, HostSize codeSize, uint* code)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.CodeSize = codeSize;
            this.Code = code;
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
        public ShaderModuleCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize CodeSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* Code; 
    }
}
