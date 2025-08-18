using System;

namespace SDRSharp.Tetra
{
	public class Burst
	{
		public SDRSharp.Tetra.Mode Mode;

		public BurstType Type;

		public unsafe byte* Ptr;

		public int Length;

		public int DisplayReady;

		public int Slot;

		public int UsageMarker;

		public ChannelType channelType;

		public Burst()
		{
		}
	}
}