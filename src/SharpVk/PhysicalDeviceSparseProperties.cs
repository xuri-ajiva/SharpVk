using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct PhysicalDeviceSparseProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceSparseProperties(Bool32 residencyStandard2DBlockShape, Bool32 residencyStandard2DMultisampleBlockShape, Bool32 residencyStandard3DBlockShape, Bool32 residencyAlignedMipSize, Bool32 residencyNonResidentStrict)
        {
            this.ResidencyStandard2DBlockShape = residencyStandard2DBlockShape;
            this.ResidencyStandard2DMultisampleBlockShape = residencyStandard2DMultisampleBlockShape;
            this.ResidencyStandard3DBlockShape = residencyStandard3DBlockShape;
            this.ResidencyAlignedMipSize = residencyAlignedMipSize;
            this.ResidencyNonResidentStrict = residencyNonResidentStrict;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ResidencyStandard2DBlockShape; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ResidencyStandard2DMultisampleBlockShape; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ResidencyStandard3DBlockShape; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ResidencyAlignedMipSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ResidencyNonResidentStrict; 
    }
}
