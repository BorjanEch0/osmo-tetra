using System;

namespace SDRSharp.Tetra
{
	public struct Calls
	{
		public int CallIdent;

		public int TXer;

		public int SSI1;

		public int SSI2;

		public bool IsEncrypted;

		public bool Duplex;

		public int AssignedSlot;
	}
}