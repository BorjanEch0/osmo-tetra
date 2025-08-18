using System;

namespace SDRSharp.Tetra
{
	public struct Rules
	{
		public GlobalNames GlobalName;

		public int Length;

		public RulesType Type;

		public int Ext1;

		public int Ext2;

		public int Ext3;

		public Rules(GlobalNames globalName, int num, RulesType rulesType = 0, int num = 0, int num = 0, int num = 0)
		{
			this.GlobalName = globalName;
			this.Length = num;
			this.Type = rulesType;
			this.Ext1 = num;
			this.Ext2 = num;
			this.Ext3 = num;
		}
	}
}