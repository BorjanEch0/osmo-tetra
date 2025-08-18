using System;
using System.Runtime.CompilerServices;

namespace SDRSharp.Tetra
{
	public class CellDisplay
	{
		public string Comment
		{
			get;
			set;
		}

		public GlobalNames Parameter
		{
			get;
			set;
		}

		public int Value
		{
			get;
			set;
		}

		public CellDisplay()
		{
		}
	}
}