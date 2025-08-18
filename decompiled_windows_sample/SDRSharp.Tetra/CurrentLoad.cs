using System;
using System.Runtime.CompilerServices;

namespace SDRSharp.Tetra
{
	public class CurrentLoad
	{
		public int Callid
		{
			get;
			set;
		}

		public string GroupName
		{
			get;
			set;
		}

		public int GroupPriority
		{
			get;
			set;
		}

		public int GSSI
		{
			get;
			set;
		}

		public bool IsClear
		{
			get;
			set;
		}

		public int ISSI
		{
			get;
			set;
		}

		public string ModeOfOperation
		{
			get;
			set;
		}

		public CurrentLoad()
		{
		}
	}
}