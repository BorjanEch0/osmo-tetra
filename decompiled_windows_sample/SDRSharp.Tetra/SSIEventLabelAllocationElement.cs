using System;
using System.Runtime.CompilerServices;

namespace SDRSharp.Tetra
{
	public struct SSIEventLabelAllocationElement
	{
		public int channel
		{
			get;
			set;
		}

		public int EventLabel
		{
			get;
			set;
		}

		public int SSI
		{
			get;
			set;
		}
	}
}