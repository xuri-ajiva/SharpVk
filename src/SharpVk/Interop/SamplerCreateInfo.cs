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
        public SamplerCreateInfo(StructureType sType, void* next, SamplerCreateFlags flags, Filter magFilter, Filter minFilter, SamplerMipmapMode mipmapMode, SamplerAddressMode addressModeU, SamplerAddressMode addressModeV, SamplerAddressMode addressModeW, float mipLodBias, Bool32 anisotropyEnable, float maxAnisotropy, Bool32 compareEnable, CompareOp compareOp, float minLod, float maxLod, BorderColor borderColor, Bool32 unnormalizedCoordinates)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.MagFilter = magFilter;
            this.MinFilter = minFilter;
            this.MipmapMode = mipmapMode;
            this.AddressModeU = addressModeU;
            this.AddressModeV = addressModeV;
            this.AddressModeW = addressModeW;
            this.MipLodBias = mipLodBias;
            this.AnisotropyEnable = anisotropyEnable;
            this.MaxAnisotropy = maxAnisotropy;
            this.CompareEnable = compareEnable;
            this.CompareOp = compareOp;
            this.MinLod = minLod;
            this.MaxLod = maxLod;
            this.BorderColor = borderColor;
            this.UnnormalizedCoordinates = unnormalizedCoordinates;
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
