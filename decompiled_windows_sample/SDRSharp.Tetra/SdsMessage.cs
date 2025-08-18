using System;
using System.Runtime.CompilerServices;

namespace SDRSharp.Tetra
{
	public class SdsMessage
	{
		public string BinaryString
		{
			get;
			set;
		}

		public string TextString
		{
			get;
			set;
		}

		public SdsMessage()
		{
		}
	}
}