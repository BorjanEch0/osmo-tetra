using System;
using System.Runtime.CompilerServices;

namespace SDRSharp.Tetra
{
	public class CallsDisplay
	{
		public string AssignedSlot
		{
			get;
			set;
		}

		public int CallID
		{
			get;
			set;
		}

		public int Carrier
		{
			get;
			set;
		}

		public string Duplex
		{
			get;
			set;
		}

		public string Encrypted
		{
			get;
			set;
		}

		public int Group
		{
			get;
			set;
		}

		public int TXer
		{
			get;
			set;
		}

		public string Users
		{
			get;
			set;
		}

		public CallsDisplay()
		{
		}
	}
}