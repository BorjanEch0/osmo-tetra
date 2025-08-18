using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SDRSharp.Tetra
{
	public class CallsEntry
	{
		public int AssignedSlot
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

		public int Duplex
		{
			get;
			set;
		}

		public int Group
		{
			get;
			set;
		}

		public int IsClear
		{
			get;
			set;
		}

		public int SSI
		{
			get;
			set;
		}

		public int TXer
		{
			get;
			set;
		}

		public int UsageMarker1
		{
			get;
			set;
		}

		public int UsageMarker2
		{
			get;
			set;
		}

		public List<int> Users
		{
			get;
			set;
		}

		public int WatchDog
		{
			get;
			set;
		}

		public CallsEntry()
		{
		}
	}
}