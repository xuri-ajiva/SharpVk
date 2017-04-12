using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SamplerCreateInfo
    {
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
        public SamplerCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Filter MagFilter; 
        
        /// <summary>
        /// 
        /// </summary>
        public Filter MinFilter; 
        
        /// <summary>
        /// 
        /// </summary>
        public SamplerMipmapMode MipmapMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public SamplerAddressMode AddressModeU; 
        
        /// <summary>
        /// 
        /// </summary>
        public SamplerAddressMode AddressModeV; 
        
        /// <summary>
        /// 
        /// </summary>
        public SamplerAddressMode AddressModeW; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MipLodBias; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 AnisotropyEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxAnisotropy; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 CompareEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public CompareOp CompareOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MinLod; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxLod; 
        
        /// <summary>
        /// 
        /// </summary>
        public BorderColor BorderColor; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 UnnormalizedCoordinates; 
    }
}
