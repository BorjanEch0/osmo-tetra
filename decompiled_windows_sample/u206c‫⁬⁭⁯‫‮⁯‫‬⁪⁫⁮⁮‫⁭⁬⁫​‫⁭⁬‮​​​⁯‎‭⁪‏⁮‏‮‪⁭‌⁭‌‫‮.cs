using SDRSharp.Tetra;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

// ⁬‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮
internal class u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮
{
	// ⁪‬‭⁮‫‭⁯‪⁮⁬‎⁫‮⁯​⁬‏‭‪⁯‫​⁯‬​⁪‍‮‏‫⁫‎⁯‏‌​⁫⁪⁫‬‮
	private u206b⁭⁫‎⁮⁮‍‎‭⁪‪‍⁫‭‪‌‪‫‭‎⁬‪‭⁭‪‭⁯‌⁬‮‏⁭‮⁮‮‬‬‎⁮⁪‮ u206a‬‭⁮‫‭⁯‪⁮⁬‎⁫‮⁯​⁬‏‭‪⁯‫​⁯‬​⁪‍‮‏‫⁫‎⁯‏‌​⁫⁪⁫‬‮ = new u206b⁭⁫‎⁮⁮‍‎‭⁪‪‍⁫‭‪‌‪‫‭‎⁬‪‭⁭‪‭⁯‌⁬‮‏⁭‮⁮‮‬‬‎⁮⁪‮();

	// ⁮⁭‌‍⁬‍‌⁬‎⁮⁪‎⁯‮‭⁪‮‏⁫‬‌‌‌⁮‮⁪⁯⁮‏​‍⁮⁫‭⁬‎‍⁯‌‌‮
	private u206d⁬‭⁬‌‍⁭⁫⁬⁪‮‌‫‎‎‎⁫‎‭⁬‮‫‮⁮⁬⁭‫‌‮‪‭⁭⁪⁪‫⁫‫‫‭‮ u206e⁭‌‍⁬‍‌⁬‎⁮⁪‎⁯‮‭⁪‮‏⁫‬‌‌‌⁮‮⁪⁯⁮‏​‍⁮⁫‭⁬‎‍⁯‌‌‮ = new u206d⁬‭⁬‌‍⁭⁫⁬⁪‮‌‫‎‎‎⁫‎‭⁬‮‫‮⁮⁬⁭‫‌‮‪‭⁭⁪⁪‫⁫‫‫‭‮();

	// ⁬⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮
	private bool u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮;

	// ‪‭⁮​⁪‎‍⁮⁯‍‎⁯‬‮‏​‭⁫⁬‪⁮⁭‎‍‫‪⁭‍‎‎‪⁯‫⁮‮‪⁭‭‪‎‮
	public static List<Dictionary<GlobalNames, int>> u202a‭⁮​⁪‎‍⁮⁯‍‎⁯‬‮‏​‭⁫⁬‪⁮⁭‎‍‫‪⁭‍‎‎‪⁯‫⁮‮‪⁭‭‪‎‮;

	// ⁯⁫​‮⁪‬⁯⁭‮‏⁮⁪‍⁯‪⁯‬‏‮‌⁫⁪⁮​⁬‫‏‌⁯⁬⁪‬⁮⁪⁬‬‬⁬‏‮
	private readonly Rules[] u206f⁫​‮⁪‬⁯⁭‮‏⁮⁪‍⁯‪⁯‬‏‮‌⁫⁪⁮​⁬‫‏‌⁯⁬⁪‬⁮⁪⁬‬‬⁬‏‮ = new Rules[] { new Rules(GlobalNames.Cell_reselect_parameters, 16, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Cell_service_level, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 3, 0, 0), new Rules(GlobalNames.Network_time, 24, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Local_time_offset_sign, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Local_time_offset, 23, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Number_of_Neighbour_cells_element, 3, RulesType.Direct, 0, 0, 0) };

	// ⁬‫‫‏⁬‪‌‎‏​⁪‮⁯‫‏⁫‭‍‬⁭⁭‮‏‏‏⁯​⁪‭‫⁫​⁭⁫‍⁫‪‮‭‎‮
	private readonly Rules[] u206c‫‫‏⁬‪‌‎‏​⁪‮⁯‫‏⁫‭‍‬⁭⁭‮‏‏‏⁯​⁪‭‫⁫​⁭⁫‍⁫‪‮‭‎‮ = new Rules[] { new Rules(GlobalNames.Cell_identifier, 5, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Cell_reselection_types_supported, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Neighbour_cell_synchronised, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Neighbour_cell_service_level, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Main_carrier_number, 12, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Main_carrier_number_extension, 10, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Neighbour_MCC, 10, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Neighbour_MNC, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Neighbour_LA, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Maximum_MS_transmit_power, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Minimum_RX_access_level, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Subscriber_class, 16, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 12, 0, 0), new Rules(GlobalNames.Registration_required, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.De_registration_required, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Priority_cell, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Cell_never_uses_minimum_mode, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Migration_supported, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.System_wide_services, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.TETRA_voice_service, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Circuit_mode_data_service, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 1, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.SNDCP_Service, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Air_interface_encryption, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Advanced_link_supported, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Timeshare_cell_and_AI_encryption, 5, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.TDMA_frame_offset, 6, RulesType.Direct, 0, 0, 0) };

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‬‬⁮⁪⁭⁭‮⁬‬‎‮‍⁫‎⁪‪‫⁬‮‍‫⁭‪‌‌‮⁬⁬⁬‭‭⁫⁭‬‍‌‎​‎‌‮
	public void u202c‬⁮⁪⁭⁭‮⁬‬‎‮‍⁫‎⁪‪‫⁬‮‍‫⁭‪‌‌‮⁬⁬⁬‭‭⁫⁭‬‍‌‎​‎‌‮(LogicChannel logicChannel, ref int numPointer, Dictionary<GlobalNames, int> globalNames)
	{
		int num = 0;
		int num1 = 0;
		string empty = null;
		MlePduType mlePduType = (MlePduType)0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		Dictionary<GlobalNames, int> globalNames1 = null;
		int num10;
		List<Dictionary<GlobalNames, int>> dictionaries = null;
		uint num11;
		int num12;
		int num13;
		int num14;
		int num15;
		int num16;
		int num17;
		int num18;
		int num19 = 3;
	Label0:
		int num20 = -2041520678;
		while (true)
		{
			int num21 = num20 ^ -1732052048;
			num11 = (uint)num21;
			switch (num21 % 6)
			{
				case 0:
				{
					goto Label0;
				}
				case 1:
				{
					break;
				}
				case 2:
				{
					num = 0;
					num20 = (int)(num11 * 1589736028 ^ 530585719);
					continue;
				}
				case 4:
				{
					num17 = (!this.u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮ ? -329648437 : -766633209);
					num20 = (int)(num17 ^ num11 * -369512640);
					continue;
				}
				case 5:
				{
					num1 = 0;
					empty = string.Empty;
					num20 = (int)(num11 * 1427244089 ^ 2077526827);
					continue;
				}
				default:
				{
					goto Label1;
				}
			}
		}
		return;
	Label1:
		try
		{
			empty = u003cModuleu003e.u200d​‍⁮‏‭⁮⁪‌‪‬‬‬‪⁬⁭⁫⁫‬⁪⁬⁬⁬‏⁮⁭‌‍‏‍‏‎‬⁬​‪‎​‎⁭‮<string>(-1150315394);
		Label4:
			num12 = -1444827199;
		Label27:
			while (true)
			{
				int num22 = num12 ^ -1732052048;
				num11 = (uint)num22;
				switch (num22 % 34)
				{
					case 0:
					{
						numPointer += 2;
						globalNames.Add(GlobalNames.Fail_cause, num3);
						num12 = (int)(num11 * -709999198 ^ 698877379);
						continue;
					}
					case 1:
					{
					Label20:
						numPointer++;
						empty = u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮.u202e‌⁮‪‫⁬‎‫‪⁫‌​‏‬‬‮⁫‪⁫‌⁪⁯⁯⁫‫‭‮‎‌⁬‍‍‎‏⁭‬⁮⁫‎⁯‮(empty, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-1373126066));
						num12 = -1331594860;
						continue;
					}
					case 2:
					{
						goto Label3;
					}
					case 3:
					{
						break;
					}
					case 4:
					{
						numPointer += num19;
						globalNames.Add(GlobalNames.MLE_PDU_Type, mlePduType);
						empty = u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮.u202e‌⁮‪‫⁬‎‫‪⁫‌​‏‬‬‮⁫‪⁫‌⁪⁯⁯⁫‫‭‮‎‌⁬‍‍‎‏⁭‬⁮⁫‎⁯‮(empty, mlePduType.ToString());
						num12 = (int)(num11 * -687241652 ^ 1889307442);
						continue;
					}
					case 5:
					{
						numPointer = u206b⁯⁬‫⁬⁬‎‭⁪‫‎‭‍‎‪⁬‪⁭‬⁬‬‍⁪‭‌⁬⁯⁯‌⁯⁮‪‍‍‫‮​‎⁭‎‮.u200e‮⁯‫⁫‎‎‭⁭⁪‌‪⁪‪⁭‎‬‏‬‌‭‬‌⁪​‪‏‍‮⁪⁪‎⁮‫‫⁪‫‏⁬‎‮(logicChannel, numPointer, this.u206c‫‫‏⁬‪‌‎‏​⁪‮⁯‫‏⁫‭‍‬⁭⁭‮‏‏‏⁯​⁪‭‫⁫​⁭⁫‍⁫‪‮‭‎‮, globalNames1);
						num12 = (int)(num11 * 178172838 ^ 869667102);
						continue;
					}
					case 6:
					{
						bool flag = false;
						try
						{
							u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮.u200e‌‮​‪‍‭⁪⁭‭⁭⁪‬⁭⁬‏‪⁯⁭​⁫‌‪⁬⁪‬⁯​‫‏​⁪⁭‬⁬‫⁮‫‍‮‮(dictionaries, ref flag);
						Label12:
							int num23 = -2017241951;
							while (true)
							{
								int num24 = num23 ^ -1732052048;
								num11 = (uint)num24;
								switch (num24 % 4)
								{
									case 0:
									{
										goto Label12;
									}
									case 1:
									{
										num13 = (u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮.u202a‭⁮​⁪‎‍⁮⁯‍‎⁯‬‮‏​‭⁫⁬‪⁮⁭‎‍‫‪⁭‍‎‎‪⁯‫⁮‮‪⁭‭‪‎‮.Count < 32 ? 1685072951 : 944618170);
										num23 = (int)(num13 ^ num11 * -2137539588);
										continue;
									}
									case 2:
									{
										goto Label8;
									}
									case 3:
									{
										u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮.u202a‭⁮​⁪‎‍⁮⁯‍‎⁯‬‮‏​‭⁫⁬‪⁮⁭‎‍‫‪⁭‍‎‎‪⁯‫⁮‮‪⁭‭‪‎‮.Add(globalNames1);
										num23 = (int)(num11 * 941459086 ^ -2054244420);
										continue;
									}
								}
							}
							goto Label8;
						}
						finally
						{
							if (!flag)
							{
								goto Label14;
							}
						Label15:
							int num25 = -1761124414;
							while (true)
							{
								int num26 = num25 ^ -1732052048;
								num11 = (uint)num26;
								switch (num26 % 3)
								{
									case 0:
									{
										goto Label15;
									}
									case 1:
									{
										u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮.u200c⁭‏​‫⁯‪‌⁬⁪⁮⁭⁭⁭‎‫‌‏‏⁭‌⁭⁬⁭‪‎​⁭⁫⁫⁭⁮‫​‎‮​​‬‬‮(dictionaries);
										num25 = (int)(num11 * -820710301 ^ 121901904);
										continue;
									}
									case 2:
									{
										goto Label14;
									}
								}
							}
						Label14:
						}
						break;
					}
					case 7:
					{
						num15 = (num != numPointer - num1 ? -537687777 : -1747313573);
						num12 = (int)(num15 ^ num11 * -848729887);
						continue;
					}
					case 8:
					{
					Label18:
						num3 = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, numPointer, 2);
						num12 = -422817446;
						continue;
					}
					case 9:
					{
						mlePduType = (MlePduType)u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, numPointer, num19);
						num12 = (int)(num11 * -630273372 ^ 1743522762);
						continue;
					}
					case 10:
					{
						num10 = 0;
						num12 = (int)(num11 * 2014796782 ^ 1106407970);
						continue;
					}
					case 11:
					{
						dictionaries = u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮.u202a‭⁮​⁪‎‍⁮⁯‍‎⁯‬‮‏​‭⁫⁬‪⁮⁭‎‍‫‪⁭‍‎‎‪⁯‫⁮‮‪⁭‭‪‎‮;
						num12 = (int)(num11 * -889021783 ^ 775331541);
						continue;
					}
					case 12:
					{
						if (!globalNames.TryGetValue(GlobalNames.PduStartOffset, out num1))
						{
							goto Label16;
						}
						num12 = (int)(num11 * -2066838062 ^ -1536185629);
						continue;
					}
					case 13:
					{
						numPointer++;
						if (!globalNames.TryGetValue(GlobalNames.MacPduRealSize, out num))
						{
							goto Label16;
						}
						num12 = (int)(num11 * 1098805072 ^ 2068250335);
						continue;
					}
					case 14:
					{
						num9 = 0;
						goto Label9;
					}
					case 15:
					{
						empty = u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮.u202e‌⁮‪‫⁬‎‫‪⁫‌​‏‬‬‮⁫‪⁫‌⁪⁯⁯⁫‫‭‮‎‌⁬‍‍‎‏⁭‬⁮⁫‎⁯‮(empty, u003cModuleu003e.u202a‮‫‏‫‬‬‪⁫⁬​‏⁫⁭‍‪‪‎⁬​‪​‌⁮‮‌​⁫​⁬‪‫⁪⁯⁪‎‫⁭‎⁪‮<string>(1145986334));
						num12 = -897551943;
						continue;
					}
					case 16:
					{
						this.u206a‬‭⁮‫‭⁯‪⁮⁬‎⁫‮⁯​⁬‏‭‪⁯‫​⁯‬​⁪‍‮‏‫⁫‎⁯‏‌​⁫⁪⁫‬‮.u202e‮‬‮⁪‭‫‎‭⁭​⁫‌⁭⁫⁪​‎‎‬⁬‫‮‬‌⁬⁪⁮‏⁪‎⁮⁮‪‮‎‭⁬⁬⁪‮(logicChannel, ref numPointer, globalNames);
						num12 = (int)(num11 * -611234362 ^ 1046347427);
						continue;
					}
					case 17:
					{
					Label19:
						numPointer = u206b⁯⁬‫⁬⁬‎‭⁪‫‎‭‍‎‪⁬‪⁭‬⁬‬‍⁪‭‌⁬⁯⁯‌⁯⁮‪‍‍‫‮​‎⁭‎‮.u200e‮⁯‫⁫‎‎‭⁭⁪‌‪⁪‪⁭‎‬‏‬‌‭‬‌⁪​‪‏‍‮⁪⁪‎⁮‫‫⁪‫‏⁬‎‮(logicChannel, numPointer, this.u206f⁫​‮⁪‬⁯⁭‮‏⁮⁪‍⁯‪⁯‬‏‮‌⁫⁪⁮​⁬‫‏‌⁯⁬⁪‬⁮⁪⁬‬‬⁬‏‮, globalNames);
						num12 = -806747285;
						continue;
					}
					case 18:
					{
						return;
					}
					case 19:
					{
						num16 = (num != numPointer - num1 ? 1301574589 : 656349470);
						num12 = (int)(num16 ^ num11 * -47175016);
						continue;
					}
					case 20:
					{
						switch (mlePduType)
						{
							case MlePduType.D_NEW_CELL:
							{
								goto Label17;
							}
							case MlePduType.D_PREPARE_FAIL:
							{
								goto Label18;
							}
							case MlePduType.D_NWRK_BROADCAST:
							{
								goto Label19;
							}
							case MlePduType.D_NWRK_BROADCAST_EXTENSION:
							{
								break;
							}
							case MlePduType.D_RESTORE_ACK:
							{
								goto Label20;
							}
							case MlePduType.D_RESTORE_FAIL:
							{
								goto Label5;
							}
							case MlePduType.D_CHANNEL_RESPONSE:
							{
								goto Label6;
							}
							case MlePduType.Extended_PDU:
							{
								goto Label7;
							}
							default:
							{
								num12 = (int)(num11 * -810759713 ^ 265289882);
								continue;
							}
						}
						break;
					}
					case 21:
					{
						numPointer++;
						num12 = (int)(num11 * -1445074552 ^ 1043415888);
						continue;
					}
					case 22:
					{
						goto Label11;
					}
					case 23:
					{
						this.u206e⁭‌‍⁬‍‌⁬‎⁮⁪‎⁯‮‭⁪‮‏⁫‬‌‌‌⁮‮⁪⁯⁮‏​‍⁮⁫‭⁬‎‍⁯‌‌‮.u200c‌‫‮‮⁭‭‬⁭‍⁫‍⁯‫‭⁭⁯‎‭‏‭⁭‪⁫⁮‌‪‏‍‭‫⁮‏⁯⁭‬‪‪‍‌‮(logicChannel, ref numPointer, globalNames);
						break;
					}
					case 24:
					{
						return;
					}
					case 25:
					{
						if (!globalNames.TryGetValue(GlobalNames.PduStartOffset, out num1))
						{
							goto Label16;
						}
						num12 = (int)(num11 * 1213505532 ^ -1847301089);
						continue;
					}
					case 26:
					{
						if (!globalNames1.TryGetValue(GlobalNames.Cell_identifier, out num10))
						{
							goto Label8;
						}
						num12 = (int)(num11 * -675268152 ^ -1954658035);
						continue;
					}
					case 27:
					{
						if (!globalNames.TryGetValue(GlobalNames.Number_of_Neighbour_cells_element, out num4))
						{
							goto Label16;
						}
						num12 = (int)(num11 * 1406215217 ^ -1889589221);
						continue;
					}
					case 28:
					{
					Label17:
						num2 = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, numPointer, 2);
						num12 = -1955639823;
						continue;
					}
					case 29:
					{
						goto Label4;
					}
					case 30:
					{
						if (!globalNames.TryGetValue(GlobalNames.MacPduRealSize, out num))
						{
							goto Label16;
						}
						num12 = (int)(num11 * 2115025687 ^ -455035992);
						continue;
					}
					case 31:
					{
						numPointer += 2;
						globalNames.Add(GlobalNames.Channel_command_valid, num2);
						num12 = (int)(num11 * -1315685417 ^ 2136217950);
						continue;
					}
					case 32:
					{
						empty = u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮.u202e‌⁮‪‫⁬‎‫‪⁫‌​‏‬‬‮⁫‪⁫‌⁪⁯⁯⁫‫‭‮‎‌⁬‍‍‎‏⁭‬⁮⁫‎⁯‮(empty, u003cModuleu003e.u206f⁮​‌‪‮‎‭‏‮‎⁮⁮‮⁬⁫‍‍⁪‍⁫⁮‏​‎⁬⁯⁪‪‍⁪⁮‎⁬⁪⁫​⁮⁪⁮‮<string>(-455488553));
						this.u206e⁭‌‍⁬‍‌⁬‎⁮⁪‎⁯‮‭⁪‮‏⁫‬‌‌‌⁮‮⁪⁯⁮‏​‍⁮⁫‭⁬‎‍⁯‌‌‮.u200c‌‫‮‮⁭‭‬⁭‍⁫‍⁯‫‭⁭⁯‎‭‏‭⁭‪⁫⁮‌‪‏‍‭‫⁮‏⁯⁭‬‪‪‍‌‮(logicChannel, ref numPointer, globalNames);
						break;
					}
					case 33:
					{
						num4 = 0;
						num12 = (int)(num11 * 216235216 ^ 1395464335);
						continue;
					}
					default:
					{
						goto case 6;
					}
				}
			}
		Label16:
		}
		catch (Exception exception1)
		{
			Exception exception = exception1;
			this.u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮ = true;
			u206b⁯⁬‫⁬⁬‎‭⁪‫‎‭‍‎‪⁬‪⁭‬⁬‬‍⁪‭‌⁬⁯⁯‌⁯⁮‪‍‍‫‮​‎⁭‎‮.u200b‪‪‭‎‎​‏‬‭‏⁪⁬‬‭‎⁭⁬⁮⁬‭⁪⁭⁭‬‮⁪‮‎‍‫‭⁪‮‫‌⁯⁭‬⁭‮(logicChannel, exception, u003cModuleu003e.u200f⁫‌​⁬‌‎‎‏‍‍⁫‎​‌‬⁯‬‫‭‎‏​‌​⁪‭‬⁬‮⁬​‌⁬⁪‫‫‎⁪⁮‮<string>(-212956987), empty, globalNames);
			if (globalNames.ContainsKey(GlobalNames.ErrWithPDU))
			{
				goto Label22;
			}
		Label23:
			num18 = -824265742;
		Label26:
			while (true)
			{
				int num27 = num18 ^ -1732052048;
				num11 = (uint)num27;
				switch (num27 % 4)
				{
					case 0:
					{
						goto Label23;
					}
					case 1:
					{
						return;
					}
					case 2:
					{
						globalNames.Add(GlobalNames.ErrWithPDU, 4);
						num18 = (int)(num11 * 1143980798 ^ 306837815);
						continue;
					}
					case 3:
					{
						break;
					}
					default:
					{
						return;
					}
				}
			}
		Label22:
			this.u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮ = false;
			num18 = -191526063;
			goto Label26;
		}
		return;
	Label3:
		globalNames1 = new Dictionary<GlobalNames, int>();
		num12 = -57702909;
		goto Label27;
	Label5:
		num7 = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, numPointer, 2);
		numPointer += 2;
		num14 = -2128538113;
		goto Label28;
	Label6:
		num5 = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, numPointer, 1);
		numPointer++;
		num14 = -1993738477;
		goto Label28;
	Label7:
		num8 = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, numPointer, 4);
		numPointer += 4;
		num14 = -1048794057;
		goto Label28;
	Label8:
		num9++;
	Label29:
		num14 = -745379006;
	Label28:
		while (true)
		{
			int num28 = num14 ^ -1732052048;
			num11 = (uint)num28;
			switch (num28 % 15)
			{
				case 0:
				{
					globalNames.Add(GlobalNames.Reason_for_the_channel_request, num6);
					num14 = (int)(num11 * 1776229482 ^ 1154860535);
					continue;
				}
				case 1:
				{
					break;
				}
				case 2:
				{
					goto Label11;
				}
				case 3:
				{
					goto Label5;
				}
				case 4:
				{
					num14 = (int)(num11 * 853802768 ^ -2048564787);
					continue;
				}
				case 5:
				{
					goto Label29;
				}
				case 6:
				{
					globalNames.Add(GlobalNames.PDU_type_extension, num8);
					num14 = (int)(num11 * 181647861 ^ 1388530094);
					continue;
				}
				case 7:
				{
					globalNames.Add(GlobalNames.Channel_response_type, num5);
					num14 = (int)(num11 * -408248259 ^ 162980621);
					continue;
				}
				case 8:
				{
					goto Label7;
				}
				case 9:
				{
					numPointer += 3;
					num14 = (int)(num11 * -589638281 ^ -2144077182);
					continue;
				}
				case 11:
				{
					int num29 = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, numPointer, 4);
					numPointer += 4;
					globalNames.Add(GlobalNames.Channel_request_retry_delay, num29);
					num14 = (int)(num11 * 583622622 ^ 759014211);
					continue;
				}
				case 12:
				{
					num6 = u206c‪‬⁭‭⁯‏​‪⁭‍⁫‍‫⁮‎⁭‭⁪‮‎‭‏‬⁮⁮‍⁭‎⁪‮⁯​‎‎‌⁯⁯⁭⁯‮.u200b‌⁫‏‮‌‭​​⁮‫⁪⁮‏⁫⁯⁫‪⁬⁭‫⁮‏⁪‭⁮⁯​​‎‍‍‎​⁭‏⁫‌‏⁭‮(logicChannel.Ptr, numPointer, 3);
					num14 = (int)(num11 * 1223443591 ^ 1148499061);
					continue;
				}
				case 13:
				{
					goto Label6;
				}
				case 14:
				{
					globalNames.Add(GlobalNames.Fail_cause, num7);
					num14 = (int)(num11 * -3381970 ^ -1551767633);
					continue;
				}
				default:
				{
					goto Label16;
				}
			}
		}
	Label9:
		if (num9 < num4)
		{
			goto Label3;
		}
		num14 = -1608768587;
		goto Label28;
	Label11:
		globalNames.Add(GlobalNames.UnknownData, 4);
		num14 = -2006181219;
		goto Label28;
	}

	// ‮‌⁮‪‫⁬‎‫‪⁫‌​‏‬‬‮⁫‪⁫‌⁪⁯⁯⁫‫‭‮‎‌⁬‍‍‎‏⁭‬⁮⁫‎⁯‮
	// privatescope
	internal static string u202e‌⁮‪‫⁬‎‫‪⁫‌​‏‬‬‮⁫‪⁫‌⁪⁯⁯⁫‫‭‮‎‌⁬‍‍‎‏⁭‬⁮⁫‎⁯‮(string str, string str)
	{
		return string.Concat(str, str);
	}

	// ‎‌‮​‪‍‭⁪⁭‭⁭⁪‬⁭⁬‏‪⁯⁭​⁫‌‪⁬⁪‬⁯​‫‏​⁪⁭‬⁬‫⁮‫‍‮‮
	// privatescope
	internal static void u200e‌‮​‪‍‭⁪⁭‭⁭⁪‬⁭⁬‏‪⁯⁭​⁫‌‪⁬⁪‬⁯​‫‏​⁪⁭‬⁬‫⁮‫‍‮‮(object obj, ref bool flagPointer)
	{
		Monitor.Enter(obj, ref flagPointer);
	}

	// ‌⁭‏​‫⁯‪‌⁬⁪⁮⁭⁭⁭‎‫‌‏‏⁭‌⁭⁬⁭‪‎​⁭⁫⁫⁭⁮‫​‎‮​​‬‬‮
	// privatescope
	internal static void u200c⁭‏​‫⁯‪‌⁬⁪⁮⁭⁭⁭‎‫‌‏‏⁭‌⁭⁬⁭‪‎​⁭⁫⁫⁭⁮‫​‎‮​​‬‬‮(object obj)
	{
		Monitor.Exit(obj);
	}

	static u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮()
	{
		u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮.u202a‭⁮​⁪‎‍⁮⁯‍‎⁯‬‮‏​‭⁫⁬‪⁮⁭‎‍‫‪⁭‍‎‎‪⁯‫⁮‮‪⁭‭‪‎‮ = new List<Dictionary<GlobalNames, int>>();
	}

	public u206c‫⁬⁭⁯‫‮⁯‫‬⁪⁫⁮⁮‫⁭⁬⁫​‫⁭⁬‮​​​⁯‎‭⁪‏⁮‏‮‪⁭‌⁭‌‫‮()
	{
	}
}