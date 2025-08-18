using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SDRSharp.Tetra
{
	public class NetworkEntry
	{
		public Dictionary<int, GroupsEntry> KnowGroups
		{
			get;
			set;
		}

		public NetworkEntry()
		{
		}
	}
}