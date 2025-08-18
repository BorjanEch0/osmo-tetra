using System;
using System.Runtime.InteropServices;

// ⁭​⁪‫‌⁭‬⁯‏‌⁪‪‬‬‬‪⁯⁬‪‪‌‏‌‎‪‫‏‍‭‬‎⁪⁪‎‬⁯⁭‎⁫‏‮
internal struct u206d​⁪‫‌⁭‬⁯‏‌⁪‪‬‬‬‪⁯⁬‪‪‌‏‌‎‪‫‏‍‭‬‎⁪⁪‎‬⁯⁭‎⁫‏‮
{
	// ‏‭‌‭⁪‏‮⁭⁯⁬‫‮​⁬‮⁫⁭‮‪⁭‌‍⁬⁬‍‍‌⁯‫‮⁬​‍​‮⁭‪⁪‍‫‮
	private uint u200f‭‌‭⁪‏‮⁭⁯⁬‫‮​⁬‮⁫⁭‮‪⁭‌‍⁬⁬‍‍‌⁯‫‮⁬​‍​‮⁭‪⁪‍‫‮;

	// ‎⁭‭⁪⁬‎⁭⁯‎⁮⁪‍⁬⁪‍‪‭⁭‌‫⁬‌⁮‫‏⁫⁬⁪⁮⁮‎⁬‭‪‮‬⁭‏‭⁫‮
	private uint u200e⁭‭⁪⁬‎⁭⁯‎⁮⁪‍⁬⁪‍‪‭⁭‌‫⁬‌⁮‫‏⁫⁬⁪⁮⁮‎⁬‭‪‮‬⁭‏‭⁫‮;

	// ​‪⁯‫⁬⁪⁮⁬‫⁪‏⁯‌‭‭‏⁬⁪⁮‮⁬​‬⁭‭‫‎⁬⁯⁪‏‌‫⁮⁯‬‌⁯⁮⁯‮
	private uint u200b‪⁯‫⁬⁪⁮⁬‫⁪‏⁯‌‭‭‏⁬⁪⁮‮⁬​‬⁭‭‫‎⁬⁯⁪‏‌‫⁮⁯‬‌⁯⁮⁯‮;

	// ⁭⁪⁫‪‪‭⁬‌​‮⁪⁫‏‌‮⁬⁮‍‪⁬⁯‭⁮‮​‏​⁯⁭‫⁭⁮⁭⁯‮‌⁬⁭‭⁪‮
	private uint u206d⁪⁫‪‪‭⁬‌​‮⁪⁫‏‌‮⁬⁮‍‪⁬⁯‭⁮‮​‏​⁯⁭‫⁭⁮⁭⁯‮‌⁬⁭‭⁪‮;

	// ‭‬⁯‌⁯‍‏‪⁮‏‍⁬‍‏⁭‍⁫‭‍‫‍‫⁮⁬‍​⁪‬‫‪‍‪⁯⁮⁮‮⁯‌‭‪‮
	public byte[] u202d‬⁯‌⁯‍‏‪⁮‏‍⁬‍‏⁭‍⁫‭‍‫‍‫⁮⁬‍​⁪‬‫‪‍‪⁯⁮⁮‮⁯‌‭‪‮()
	{
		byte[] numArray = new byte[Marshal.SizeOf<u206d​⁪‫‌⁭‬⁯‏‌⁪‪‬‬‬‪⁯⁬‪‪‌‏‌‎‪‫‏‍‭‬‎⁪⁪‎‬⁯⁭‎⁫‏‮>(this)];
		GCHandle gCHandle = GCHandle.Alloc(numArray, GCHandleType.Pinned);
		Marshal.StructureToPtr<u206d​⁪‫‌⁭‬⁯‏‌⁪‪‬‬‬‪⁯⁬‪‪‌‏‌‎‪‫‏‍‭‬‎⁪⁪‎‬⁯⁭‎⁫‏‮>(this, gCHandle.AddrOfPinnedObject(), false);
		gCHandle.Free();
		return numArray;
	}

	public u206d​⁪‫‌⁭‬⁯‏‌⁪‪‬‬‬‪⁯⁬‪‪‌‏‌‎‪‫‏‍‭‬‎⁪⁪‎‬⁯⁭‎⁫‏‮(uint num, uint num, uint num)
	{
		uint num1 = num;
		uint num2 = num1;
		this.u206d⁪⁫‪‪‭⁬‌​‮⁪⁫‏‌‮⁬⁮‍‪⁬⁯‭⁮‮​‏​⁯⁭‫⁭⁮⁭⁯‮‌⁬⁭‭⁪‮ = num1;
		this.u200b‪⁯‫⁬⁪⁮⁬‫⁪‏⁯‌‭‭‏⁬⁪⁮‮⁬​‬⁭‭‫‎⁬⁯⁪‏‌‫⁮⁯‬‌⁯⁮⁯‮ = num2;
		this.u200f‭‌‭⁪‏‮⁭⁯⁬‫‮​⁬‮⁫⁭‮‪⁭‌‍⁬⁬‍‍‌⁯‫‮⁬​‍​‮⁭‪⁪‍‫‮ = num;
		this.u200e⁭‭⁪⁬‎⁭⁯‎⁮⁪‍⁬⁪‍‪‭⁭‌‫⁬‌⁮‫‏⁫⁬⁪⁮⁮‎⁬‭‪‮‬⁭‏‭⁫‮ = num;
	}
}