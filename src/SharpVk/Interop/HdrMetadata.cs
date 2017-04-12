using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct HdrMetadata
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
        public XYColor DisplayPrimaryRed; 
        
        /// <summary>
        /// 
        /// </summary>
        public XYColor DisplayPrimaryGreen; 
        
        /// <summary>
        /// 
        /// </summary>
        public XYColor DisplayPrimaryBlue; 
        
        /// <summary>
        /// 
        /// </summary>
        public XYColor WhitePoint; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxLuminance; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MinLuminance; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxContentLightLevel; 
        
        /// <summary>
        /// 
        /// </summary>
        public float MaxFrameAverageLightLevel; 
    }
}
