using SDRSharp.Tetra;
using System;
using System.Collections.Generic;

// ‌‏‬⁭​‌‪⁬‬‮‏⁪⁯​‮‭‏‎⁪⁫‮⁪⁮‎‫‌⁪​⁫‌⁯⁮‌​‎‭‍‬‪⁯‮
internal class u200c‏‬⁭​‌‪⁬‬‮‏⁪⁯​‮‭‏‎⁪⁫‮⁪⁮‎‫‌⁪​⁫‌⁯⁮‌​‎‭‍‬‪⁯‮
{
	// ⁮⁭‌‍⁬‍‌⁬‎⁮⁪‎⁯‮‭⁪‮‏⁫‬‌‌‌⁮‮⁪⁯⁮‏​‍⁮⁫‭⁬‎‍⁯‌‌‮
	private u206d⁬‭⁬‌‍⁭⁫⁬⁪‮‌‫‎‎‎⁫‎‭⁬‮‫‮⁮⁬⁭‫‌‮‪‭⁭⁪⁪‫⁫‫‫‭‮ u206e⁭‌‍⁬‍‌⁬‎⁮⁪‎⁯‮‭⁪‮‏⁫‬‌‌‌⁮‮⁪⁯⁮‏​‍⁮⁫‭⁬‎‍⁯‌‌‮ = new u206d⁬‭⁬‌‍⁭⁫⁬⁪‮‌‫‎‎‎⁫‎‭⁬‮‫‮⁮⁬⁭‫‌‮‪‭⁭⁪⁪‫⁫‫‫‭‮();

	// ‎‏‪‬‌⁯⁪⁫⁯⁬‪‫⁪‍‭⁭⁬‭‫⁯‮⁫⁫‫‬‎⁬‫‎‭‪‭‪⁭⁪⁭‪⁯⁬⁪‮
	private u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮ u200e‏‪‬‌⁯⁪⁫⁯⁬‪‫⁪‍‭⁭⁬‭‫⁯‮⁫⁫‫‬‎⁬‫‎‭‪‭‪⁭⁪⁭‪⁯⁬⁪‮ = new u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮();

	// ⁪‬‭⁮‫‭⁯‪⁮⁬‎⁫‮⁯​⁬‏‭‪⁯‫​⁯‬​⁪‍‮‏‫⁫‎⁯‏‌​⁫⁪⁫‬‮
	private u206b⁭⁫‎⁮⁮‍‎‭⁪‪‍⁫‭‪‌‪‫‭‎⁬‪‭⁭‪‭⁯‌⁬‮‏⁭‮⁮‮‬‬‎⁮⁪‮ u206a‬‭⁮‫‭⁯‪⁮⁬‎⁫‮⁯​⁬‏‭‪⁯‫​⁯‬​⁪‍‮‏‫⁫‎⁯‏‌​⁫⁪⁫‬‮ = new u206b⁭⁫‎⁮⁮‍‎‭⁪‪‍⁫‭‪‌‪‫‭‎⁬‪‭⁭‪‭⁯‌⁬‮‏⁭‮⁮‮‬‬‎⁮⁪‮();

	// ‌⁭⁫‭⁯⁮‌‬‫‌‍‍‎‌‏‬⁭‮‮‭‍‮‌​‏‮⁮‍‭⁯​​⁭‍‮⁭⁫‫‭‏‮
	private u206a⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮ u200c⁭⁫‭⁯⁮‌‬‫‌‍‍‎‌‏‬⁭‮‮‭‍‮‌​‏‮⁮‍‭⁯​​⁭‍‮⁭⁫‫‭‏‮ = new u206a⁫‮‫‎‮‪‎‮‍‭‭⁭⁬‬⁬⁮​‍⁫‌‬‌⁫⁭​⁮‎⁬‍‎⁯‌⁯‌⁯‫⁭⁫‬‮();

	// ‬‏⁪‫⁯‮⁬‫‏⁫‍⁯‫⁭‮‭‫⁮‎‭⁬⁭⁮‭‍‏‍‏‎⁬‍‫⁬‌‏‎⁪⁭‌‎‮
	public void u202c‏⁪‫⁯‮⁬‫‏⁫‍⁯‫⁭‮‭‫⁮‎‭⁬⁭⁮‭‍‏‍‏‎⁬‍‫⁬‌‏‎⁪⁭‌‎‮(LogicChannel logicChannel, int num, Dictionary<GlobalNames, int> globalNames)
	{
		MLEPduType mLEPduType = (MLEPduType)u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, num, 3);
	Label0:
		int num1 = -1145563350;
		while (true)
		{
			int num2 = num1 ^ -82106591;
			uint num3 = (uint)num2;
			switch (num2 % 14)
			{
				case 0:
				{
					return;
				}
				case 1:
				{
				Label4:
					this.u200e‏‪‬‌⁯⁪⁫⁯⁬‪‫⁪‍‭⁭⁬‭‫⁯‮⁫⁫‫‬‎⁬‫‎‭‪‭‪⁭⁪⁭‪⁯⁬⁪‮.u202c‬⁮⁪⁭⁭‮⁬‬‎‮‍⁫‎⁪‪‫⁬‮‍‫⁭‪‌‌‮⁬⁬⁬‭‭⁫⁭‬‍‌‎​‎‌‮(logicChannel, ref num, globalNames);
					num1 = -2076504739;
					continue;
				}
				case 2:
				{
				Label2:
					globalNames.Add(GlobalNames.UnknownData, 3);
					num1 = -572276642;
					continue;
				}
				case 3:
				{
					return;
				}
				case 4:
				{
					globalNames.Add(GlobalNames.MLE_Protocol_Discriminator, mLEPduType);
					num1 = (int)(num3 * 2060579297 ^ 852354131);
					continue;
				}
				case 5:
				{
					num += 3;
					num1 = (int)(num3 * 1185330541 ^ -1127458432);
					continue;
				}
				case 6:
				{
					switch (mLEPduType)
					{
						case MLEPduType.MM:
						{
							goto Label1;
						}
						case MLEPduType.CMCE:
						{
							break;
						}
						case MLEPduType.Reserved2:
						{
							goto Label2;
						}
						case MLEPduType.SNDCP:
						{
							goto Label3;
						}
						case MLEPduType.MLE:
						{
							goto Label4;
						}
						default:
						{
							num1 = (int)(num3 * 1727729154 ^ 351792119);
							continue;
						}
					}
					break;
				}
				case 7:
				{
					return;
				}
				case 8:
				{
				Label1:
					this.u206e⁭‌‍⁬‍‌⁬‎⁮⁪‎⁯‮‭⁪‮‏⁫‬‌‌‌⁮‮⁪⁯⁮‏​‍⁮⁫‭⁬‎‍⁯‌‌‮.u200c‌‫‮‮⁭‭‬⁭‍⁫‍⁯‫‭⁭⁯‎‭‏‭⁭‪⁫⁮‌‪‏‍‭‫⁮‏⁯⁭‬‪‪‍‌‮(logicChannel, ref num, globalNames);
					num1 = -130184754;
					continue;
				}
				case 9:
				{
				Label3:
					this.u200c⁭⁫‭⁯⁮‌‬‫‌‍‍‎‌‏‬⁭‮‮‭‍‮‌​‏‮⁮‍‭⁯​​⁭‍‮⁭⁫‫‭‏‮.u206d⁭⁯‍‭‍⁫‫‪⁯‍​⁪‌⁮‫⁬⁯‫⁭‬‫⁬‌‫​‍⁮⁪‭⁯‭‎⁬‎‬‫‪‎‍‮(logicChannel, ref num, globalNames);
					num1 = -1019628188;
					continue;
				}
				case 10:
				{
					break;
				}
				case 11:
				{
					goto Label0;
				}
				case 12:
				{
					num1 = (int)(num3 * 1047780174 ^ -1867454529);
					continue;
				}
				case 13:
				{
					return;
				}
				default:
				{
					return;
				}
			}
		}
		this.u206a‬‭⁮‫‭⁯‪⁮⁬‎⁫‮⁯​⁬‏‭‪⁯‫​⁯‬​⁪‍‮‏‫⁫‎⁯‏‌​⁫⁪⁫‬‮.u202e‮‬‮⁪‭‫‎‭⁭​⁫‌⁭⁫⁪​‎‎‬⁬‫‮‬‌⁬⁪⁮‏⁪‎⁮⁮‪‮‎‭⁬⁬⁪‮(logicChannel, ref num, globalNames);
	}

	public u200c‏‬⁭​‌‪⁬‬‮‏⁪⁯​‮‭‏‎⁪⁫‮⁪⁮‎‫‌⁪​⁫‌⁯⁮‌​‎‭‍‬‪⁯‮()
	{
	}
}