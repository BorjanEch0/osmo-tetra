using System;

namespace SDRSharp.Tetra
{
	public class LogicChannel
	{
		public unsafe byte* Ptr;

		public int Length;

		public bool CrcIsOk;

		public int TimeSlot;

		public int Frame;

		public int crcGen;

		public LogicChannel()
		{
		}
	}
}