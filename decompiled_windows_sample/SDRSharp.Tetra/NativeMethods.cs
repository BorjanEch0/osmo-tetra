using System;
using System.Runtime.InteropServices;

namespace SDRSharp.Tetra
{
	public static class NativeMethods
	{
		// ⁭⁮‪⁭⁮⁮⁯‎‬‍‌​‍⁪‭⁪⁬‬‏‫‬‪⁮‫​⁫⁯⁭‬‮⁫‏⁭⁯‮​‬‪⁬‮
		private const string u206d⁮‪⁭⁮⁮⁯‎‬‍‌​‍⁪‭⁪⁬‬‏‫‬‪⁮‫​⁫⁯⁭‬‮⁫‏⁭⁯‮​‬‪⁬‮ = "libtetradec";

		[DllImport("libtetradec", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.None, ExactSpelling=false)]
		public static extern unsafe int tetra_cdec(int fp, byte* inp, short* outp, int frame_stealing, int bfi_beep);

		[DllImport("libtetradec", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.None, ExactSpelling=false)]
		public static extern void tetra_decode_init();

		[DllImport("libtetradec", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.None, ExactSpelling=false)]
		public static extern unsafe int tetra_sdec(short* inp, short* outp, int ts);
	}
}