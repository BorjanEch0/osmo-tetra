using System;
using System.Windows.Forms;

namespace SDRSharp.Tetra
{
	public class DataGridViewEx : DataGridView
	{
		public DataGridViewEx()
		{
			base.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}
	}
}