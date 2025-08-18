using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// ⁪‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮
internal class u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮
{
	// ⁫⁮‬⁯‎‭⁭​‎⁬⁬‫⁮‫⁬⁯⁮‫‬⁮‪‬‫⁮⁭‮​⁫‌‭⁯‫‭‬‫⁮‏⁮‪⁬‮
	public void u206b⁮‬⁯‎‭⁭​‎⁬⁬‫⁮‫⁬⁯⁮‫‬⁮‪‬‫⁮⁭‮​⁫‌‭⁯‫‭‬‫⁮‏⁮‪⁬‮(string str, string str)
	{
		StreamWriter streamWriter = u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮.u200c‫‍‬‌‮‭⁫‬‏⁯⁯‫⁪‎⁭‫‍‌⁭​⁪‭​​‍⁯‫⁪‫⁬⁯‏⁫‭⁮‍‏‮‫‮(str, true, u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮.u206d‌⁮‍⁬⁯‍⁮⁯‫‪⁪​⁬‏⁯⁯​⁪‍⁬⁮⁬‌⁯⁮⁬⁪⁫⁭⁮‌⁯⁬⁬‌‏‌‭‮‮());
		try
		{
			u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮.u206f⁪‫‭‍‬⁮‫‬⁭‭‏‌⁪⁮‫‪‏‫‬‪⁮⁬‏‬‌⁬‏‎‌‏‏⁯⁬⁫⁪‎‏‪⁮‮(streamWriter, str);
		}
		finally
		{
			if (streamWriter == null)
			{
				goto Label0;
			}
		Label1:
			int num = -655959259;
			while (true)
			{
				int num1 = num ^ -488212060;
				uint num2 = (uint)num1;
				switch (num1 % 3)
				{
					case 0:
					{
						goto Label1;
					}
					case 1:
					{
						u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮.u206b⁫‎⁯‏‌​‪‏‎⁫‌⁬‬‫‬⁭⁮‌​⁮⁫‌​‌​‍⁫‍⁬‪⁯‬‫⁬⁭‏⁭‎‮‮(streamWriter);
						num = (int)(num2 * 2007212921 ^ -1195006542);
						continue;
					}
					case 2:
					{
						goto Label0;
					}
				}
			}
		Label0:
		}
	}

	// ‭‭⁯⁮​‬‭‍​⁫‌⁮⁯⁬⁯⁬⁮⁭⁭‭‮​⁪‮⁫⁪⁪⁯‏‍‭‬⁫‭‏‪‪⁫‭‮
	public List<string> u202d‭⁯⁮​‬‭‍​⁫‌⁮⁯⁬⁯⁬⁮⁭⁭‭‮​⁪‮⁫⁪⁪⁯‏‍‭‬⁫‭‏‪‪⁫‭‮(string str)
	{
		uint num;
		int num1;
		List<string> strs = new List<string>();
		StreamReader streamReader = u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮.u200b‪‬‭⁪‫⁬‌⁯‪⁯‎‬‌‫​⁪‭‬‫​‌‭‏‍‌‍⁬‫​⁯‌‮⁬‪‎‭⁭​‏‮(str, u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮.u206d‌⁮‍⁬⁯‍⁮⁯‫‪⁪​⁬‏⁯⁯​⁪‍⁬⁮⁬‌⁯⁮⁬⁪⁫⁭⁮‌⁯⁬⁬‌‏‌‭‮‮());
		try
		{
			while (true)
			{
			Label1:
				num1 = (u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮.u206d‍​‭⁫‬‮‫‮⁮‎‏⁬‌‬‪‌⁪⁬⁭‍‪‪‭⁯⁬‏‎‮⁮‌‪‍‮⁯‌⁯​⁭‫‮(streamReader) >= 0 ? 42361743 : 1909914836);
				while (true)
				{
					int num2 = num1 ^ 1800171442;
					num = (uint)num2;
					switch (num2 % 4)
					{
						case 0:
						{
							goto Label1;
						}
						case 1:
						{
							strs.Add(u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮.u206a‏⁫⁭⁮‫‏‬‪‭⁫⁪‫​‎⁪‫⁪⁭⁫‌‮‮‫⁬⁪‫​‭‬​⁪⁫‌⁯‭‎⁫‏‎‮(streamReader));
							num1 = 85985598;
							continue;
						}
						case 2:
						{
							goto Label0;
						}
						case 3:
						{
							num1 = 42361743;
							continue;
						}
					}
				}
			}
		Label0:
		}
		finally
		{
			if (streamReader == null)
			{
				goto Label2;
			}
		Label3:
			int num3 = 1581887770;
			while (true)
			{
				int num4 = num3 ^ 1800171442;
				num = (uint)num4;
				switch (num4 % 3)
				{
					case 0:
					{
						goto Label3;
					}
					case 1:
					{
						u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮.u206b⁫‎⁯‏‌​‪‏‎⁫‌⁬‬‫‬⁭⁮‌​⁮⁫‌​‌​‍⁫‍⁬‪⁯‬‫⁬⁭‏⁭‎‮‮(streamReader);
						num3 = (int)(num * -1771400534 ^ 1049732938);
						continue;
					}
					case 2:
					{
						goto Label2;
					}
				}
			}
		Label2:
		}
		return strs;
	}

	// ⁭‌⁮‍⁬⁯‍⁮⁯‫‪⁪​⁬‏⁯⁯​⁪‍⁬⁮⁬‌⁯⁮⁬⁪⁫⁭⁮‌⁯⁬⁬‌‏‌‭‮‮
	// privatescope
	internal static Encoding u206d‌⁮‍⁬⁯‍⁮⁯‫‪⁪​⁬‏⁯⁯​⁪‍⁬⁮⁬‌⁯⁮⁬⁪⁫⁭⁮‌⁯⁬⁬‌‏‌‭‮‮()
	{
		return Encoding.Default;
	}

	// ‌‫‍‬‌‮‭⁫‬‏⁯⁯‫⁪‎⁭‫‍‌⁭​⁪‭​​‍⁯‫⁪‫⁬⁯‏⁫‭⁮‍‏‮‫‮
	// privatescope
	internal static StreamWriter u200c‫‍‬‌‮‭⁫‬‏⁯⁯‫⁪‎⁭‫‍‌⁭​⁪‭​​‍⁯‫⁪‫⁬⁯‏⁫‭⁮‍‏‮‫‮(string str, bool flag, Encoding encoding)
	{
		return new StreamWriter(str, flag, encoding);
	}

	// ⁯⁪‫‭‍‬⁮‫‬⁭‭‏‌⁪⁮‫‪‏‫‬‪⁮⁬‏‬‌⁬‏‎‌‏‏⁯⁬⁫⁪‎‏‪⁮‮
	// privatescope
	internal static void u206f⁪‫‭‍‬⁮‫‬⁭‭‏‌⁪⁮‫‪‏‫‬‪⁮⁬‏‬‌⁬‏‎‌‏‏⁯⁬⁫⁪‎‏‪⁮‮(TextWriter textWriter, string str)
	{
		textWriter.WriteLine(str);
	}

	// ⁫⁫‎⁯‏‌​‪‏‎⁫‌⁬‬‫‬⁭⁮‌​⁮⁫‌​‌​‍⁫‍⁬‪⁯‬‫⁬⁭‏⁭‎‮‮
	// privatescope
	internal static void u206b⁫‎⁯‏‌​‪‏‎⁫‌⁬‬‫‬⁭⁮‌​⁮⁫‌​‌​‍⁫‍⁬‪⁯‬‫⁬⁭‏⁭‎‮‮(IDisposable disposable)
	{
		disposable.Dispose();
	}

	// ​‪‬‭⁪‫⁬‌⁯‪⁯‎‬‌‫​⁪‭‬‫​‌‭‏‍‌‍⁬‫​⁯‌‮⁬‪‎‭⁭​‏‮
	// privatescope
	internal static StreamReader u200b‪‬‭⁪‫⁬‌⁯‪⁯‎‬‌‫​⁪‭‬‫​‌‭‏‍‌‍⁬‫​⁯‌‮⁬‪‎‭⁭​‏‮(string str, Encoding encoding)
	{
		return new StreamReader(str, encoding);
	}

	// ⁪‏⁫⁭⁮‫‏‬‪‭⁫⁪‫​‎⁪‫⁪⁭⁫‌‮‮‫⁬⁪‫​‭‬​⁪⁫‌⁯‭‎⁫‏‎‮
	// privatescope
	internal static string u206a‏⁫⁭⁮‫‏‬‪‭⁫⁪‫​‎⁪‫⁪⁭⁫‌‮‮‫⁬⁪‫​‭‬​⁪⁫‌⁯‭‎⁫‏‎‮(TextReader textReader)
	{
		return textReader.ReadLine();
	}

	// ⁭‍​‭⁫‬‮‫‮⁮‎‏⁬‌‬‪‌⁪⁬⁭‍‪‪‭⁯⁬‏‎‮⁮‌‪‍‮⁯‌⁯​⁭‫‮
	// privatescope
	internal static int u206d‍​‭⁫‬‮‫‮⁮‎‏⁬‌‬‪‌⁪⁬⁭‍‪‪‭⁯⁬‏‎‮⁮‌‪‍‮⁯‌⁯​⁭‫‮(TextReader textReader)
	{
		return textReader.Peek();
	}

	public u206a‭⁫⁪‏⁫‬‏⁬​‏‌‏​⁬‫‮⁯⁫‎‌‮‫‎‮‎‬⁪​‍⁮‏‭‌‌⁬‌⁯‎⁪‮()
	{
	}
}