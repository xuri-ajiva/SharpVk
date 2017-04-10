using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineShaderStageCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public PipelineShaderStageCreateInfo(StructureType sType, void* next, PipelineShaderStageCreateFlags flags, ShaderStageFlags stage, ShaderModule module, char* name, SpecializationInfo* specializationInfo)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.Stage = stage;
            this.Module = module;
            this.Name = name;
            this.SpecializationInfo = specializationInfo;
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
        public PipelineShaderStageCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public ShaderStageFlags Stage; 
        
        /// <summary>
        /// 
        /// </summary>
        public ShaderModule Module; 
        
        /// <summary>
        /// 
        /// </summary>
        public char* Name; 
        
        /// <summary>
        /// 
        /// </summary>
        public SpecializationInfo* SpecializationInfo; 
    }
}
