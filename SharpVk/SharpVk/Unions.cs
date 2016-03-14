
namespace SharpVk
{
	public struct ClearColorValue
	{
		public float Float32;
		public int Int32;
		public uint Uint32;
	}

	public struct ClearValue
	{
		public ClearColorValue Color;
		public Interop.ClearDepthStencilValue DepthStencil;
	}

}