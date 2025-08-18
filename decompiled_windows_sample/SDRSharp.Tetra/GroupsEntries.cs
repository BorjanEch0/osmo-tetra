using System;
using System.Runtime.CompilerServices;

namespace SDRSharp.Tetra
{
	public class GroupsEntries
	{
		public bool Blocked
		{
			get;
			set;
		}

		public int GSSI
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public int NMI
		{
			get;
			set;
		}

		public int Priopity
		{
			get;
			set;
		}

		public GroupsEntries()
		{
		}
	}
}