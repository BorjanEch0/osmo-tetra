using SDRSharp.Tetra;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// ⁭‎​⁪⁪‎‫‪​‭‫⁮‌‍‬⁭⁯‏‌⁭​‌‪‌‬⁭⁫‮‬⁪‏⁫⁪‫‫‬‬‬‪‪‮
internal class u206d‎​⁪⁪‎‫‪​‭‫⁮‌‍‬⁭⁯‏‌⁭​‌‪‌‬⁭⁫‮‬⁪‏⁫⁪‫‫‬‬‬‪‪‮
{
	// ⁮⁮‪‮⁫‬‌⁫⁮‎⁯‭‫‪‬‎⁫‏⁮‪‌⁭‬‍⁭⁯‮⁫⁯‪‏⁯⁪⁭‎⁫⁯⁪‬⁮‮
	private u206d⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮ u206e⁮‪‮⁫‬‌⁫⁮‎⁯‭‫‪‬‎⁫‏⁮‪‌⁭‬‍⁭⁯‮⁫⁯‪‏⁯⁪⁭‎⁫⁯⁪‬⁮‮ = new u206d⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮();

	// ‮‪‭‪⁫‎⁯‭‬⁪⁮‫⁯⁬⁭⁬‌‎‮⁮​‪⁮‏​⁬​‪‎⁪⁪​⁪‭‬⁮‫‬‌⁬‮
	private bool u202e‪‭‪⁫‎⁯‭‬⁪⁮‫⁯⁬⁭⁬‌‎‮⁮​‪⁮‏​⁬​‪‎⁪⁪​⁪‭‬⁮‫‬‌⁬‮;

	// ⁪‏⁮​⁬⁯⁪⁮⁫‫‌⁬‏‭‬⁬⁮⁫‎⁫‬‍⁯‎​‮‌⁭‌‎‎‮‏⁪‏⁪‏⁫⁬⁯‮
	private readonly Rules[] u206a‏⁮​⁬⁯⁪⁮⁫‫‌⁬‏‭‬⁬⁮⁫‎⁫‬‍⁯‎​‮‌⁭‌‎‎‮‏⁪‏⁪‏⁫⁬⁯‮ = new Rules[] { new Rules(GlobalNames.Channel_reservation_type, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reservation_time_remaining, 6, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Timing_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Requests_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Changeover_requests_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Requests_bitmap, 8, RulesType.Switch, 564, 1, 0), new Rules(GlobalNames.Power_class, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Power_control_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Priority_level, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Dual_watch_synchronization_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Two_frequency_call_flag, 1, RulesType.Direct, 0, 0, 0) };

	// ⁪⁫‭⁬⁮‮‍⁯‬‭‮‮‮⁪‎‌‮‍‭⁬‮⁬⁯⁪‭‪‌⁪‎​⁫⁬‎‪‫⁬⁫⁪‬‪‮
	private readonly Rules[] u206a⁫‭⁬⁮‮‍⁯‬‭‮‮‮⁪‎‌‮‍‭⁬‮⁬⁯⁪‭‪‌⁪‎​⁫⁬‎‪‫⁬⁫⁪‬‪‮ = new Rules[] { new Rules(GlobalNames.SDS_time_remaining, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.SDS_transaction_type, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Priority_level, 2, RulesType.Direct, 0, 0, 0) };

	// ‎‮⁬‮‫‍⁮‎⁯⁭‪‪‬⁫‭⁬⁯⁬⁬⁬‎⁮⁬‪‎⁫‪​‮⁭‏⁭‫‌⁫‮‏‎⁮‮
	private readonly Rules[] u200e‮⁬‮‫‍⁮‎⁯⁭‪‪‬⁫‭⁬⁯⁬⁬⁬‎⁮⁬‪‎⁫‪​‮⁭‏⁭‫‌⁫‮‏‎⁮‮ = new Rules[] { new Rules(GlobalNames.Timing_adjustment, 12, RulesType.Direct, 0, 0, 0) };

	// ⁭⁪‪⁪‮⁬‫‍‎‭‮‫‬‭⁭‍⁫⁯‬‬⁬‫‫‌⁫⁯‮​‌‮⁯‌⁬‬‏‪⁪⁪‪‮‮
	private readonly Rules[] u206d⁪‪⁪‮⁬‫‍‎‭‮‫‬‭⁭‍⁫⁯‬‬⁬‫‫‌⁫⁯‮​‌‮⁯‌⁬‬‏‪⁪⁪‪‮‮ = new Rules[] { new Rules(GlobalNames.Timing_acceptance_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Timing_change_announced, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Timing_adjustment, 12, RulesType.Switch, 568, 1, 0) };

	// ‎⁯‮‌‫‬​⁬‌‮⁯‍⁪⁫‮‍⁯‬‭⁫⁫⁬⁬‌⁯⁯​​‍‍‭‮⁫⁪‫‮‮⁮⁭⁫‮
	private readonly Rules[] u200e⁯‮‌‫‬​⁬‌‮⁯‍⁪⁫‮‍⁯‬‭⁫⁫⁬⁬‌⁯⁯​​‍‍‭‮⁫⁪‫‮‮⁮⁭⁫‮ = new Rules[] { new Rules(GlobalNames.Timing_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.LCH_in_frame_3, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Pre_emption_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Power_class, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Power_control_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 2, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Dual_watch_synchronization_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Two_frequency_call_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Circuit_mode_type, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 4, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Priority_level, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.End_to_end_encryption_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Call_type_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.External_source_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 2, RulesType.Reserved, 0, 0, 0) };

	// ⁮‭‍⁯‬‭‏⁫‎‍‭‎⁫⁮​‏‏​⁫⁭⁪⁬‪‫‬⁪‮‎⁬‮‏‍⁪‏⁪​‍‭⁯‎‮
	private readonly Rules[] u206e‭‍⁯‬‭‏⁫‎‍‭‎⁫⁮​‏‏​⁫⁭⁪⁬‪‫‬⁪‮‎⁬‮‏‍⁪‏⁪​‍‭⁯‎‮ = new Rules[] { new Rules(GlobalNames.Reserved, 3, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Power_class, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Power_control_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 2, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Dual_watch_synchronization_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Two_frequency_call_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Circuit_mode_type, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 4, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Priority_level, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.End_to_end_encryption_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Call_type_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.External_source_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 2, RulesType.Reserved, 0, 0, 0) };

	// ‭⁪‫‍⁫⁭⁭⁫‮⁭⁪‍⁬​‏⁭⁪⁪‍‎⁯‮‭‭‭‏‌⁯⁪‭⁫‮⁫⁯‭‮‌‌‏‫‮
	private readonly Rules[] u202d⁪‫‍⁫⁭⁭⁫‮⁭⁪‍⁬​‏⁭⁪⁪‍‎⁯‮‭‭‭‏‌⁯⁪‭⁫‮⁫⁯‭‮‌‌‏‫‮ = new Rules[] { new Rules(GlobalNames.Circuit_mode_type, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 4, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Reserved, 4, RulesType.Reserved, 0, 0, 0) };

	// ⁬⁯‭⁮⁯‌​⁬⁪‫‏‌‪‪⁯‍‭​‫‭‍‫⁫‏‫⁯⁪‫⁪​⁮⁬⁫‮‌⁫⁫‪⁯‏‮
	private readonly Rules[] u206c⁯‭⁮⁯‌​⁬⁪‫‏‌‪‪⁯‍‭​‫‭‍‫⁫‏‫⁯⁪‫⁪​⁮⁬⁫‮‌⁫⁫‪⁯‏‮ = new Rules[] { new Rules(GlobalNames.Disconnect_cause, 4, RulesType.Direct, 0, 0, 0) };

	// ‭⁮⁬‏⁮⁫‪⁫⁫‌‎‍‭‫‪‏‮⁭‫⁭‬‫⁭‍⁯‏⁪⁮‪‫⁯‌‪⁪‌⁮⁮‬⁫‮
	private readonly Rules[] u202d⁮⁬‏⁮⁫‪⁫⁫‌‎‍‭‫‪‏‮⁭‫⁭‬‫⁭‍⁯‏⁪⁮‪‫⁯‌‪⁪‌⁮⁮‬⁫‮ = new Rules[] { new Rules(GlobalNames.Release_cause, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Release_cause_extension, 5, RulesType.Switch, 572, 15, 0) };

	// ‍⁯⁪‎⁭‬‫⁫‬⁬⁭⁫‫‪‎⁯‭‎‪‎‪‬‍⁫⁬​⁮⁭‬‎‎‎‍‮⁭‮‎⁭⁫⁯‮
	private readonly Rules[] u200d⁯⁪‎⁭‬‫⁫‬⁬⁭⁫‫‪‎⁯‭‎‪‎‪‬‍⁫⁬​⁮⁭‬‎‎‎‍‮⁭‮‎⁭⁫⁯‮ = new Rules[] { new Rules(GlobalNames.Reservation_time_remaining, 6, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Timing_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Requests_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Changeover_requests_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Requests_bitmap, 8, RulesType.Switch, 564, 1, 0), new Rules(GlobalNames.Recent_user_priority_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Timing_change_announced, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Timing_adjustment, 12, RulesType.Switch, 568, 1, 0), new Rules(GlobalNames.Priority_level, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Cease_cause, 4, RulesType.Direct, 0, 0, 0) };

	// ⁫‭‍‍‎⁫⁬⁬‌‏‪‌⁯‭⁮​⁯⁮‎⁪⁯‮⁭‬‫‬‍‬‬‏‪⁪‫⁭‌​⁭‎‪‭‮
	private readonly Rules[] u206b‭‍‍‎⁫⁬⁬‌‏‪‌⁯‭⁮​⁯⁮‎⁪⁯‮⁭‬‫‬‍‬‬‏‪⁪‫⁭‌​⁭‎‪‭‮ = new Rules[] { new Rules(GlobalNames.Timing_adjustment_required, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Timing_adjustment, 12, RulesType.Switch, 576, 1, 0), new Rules(GlobalNames.Priority_level, 2, RulesType.Direct, 0, 0, 0) };

	// ⁫‪⁬‎⁪‬‌‫⁪‫​‬‪⁫‍⁪‮‌‎‫⁮‏⁯⁭‎⁪‍⁭‌‎‫⁫⁪⁭‎​⁯⁫‫⁮‮
	private readonly Rules[] u206b‪⁬‎⁪‬‌‫⁪‫​‬‪⁫‍⁪‮‌‎‫⁮‏⁯⁭‎⁪‍⁭‌‎‫⁫⁪⁭‎​⁯⁫‫⁮‮ = new Rules[] { new Rules(GlobalNames.Timing_adjustment_announced, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Timing_adjustment, 12, RulesType.Switch, 577, 1, 0) };

	// ⁫‏‎​‍‮⁪‌⁭⁫⁬‫‮‭‍‪⁬‪‬⁪⁬⁮‍‪‎‏⁮‮⁭⁫⁯⁭⁬⁭⁬⁯⁮⁬‎⁫‮
	private readonly Rules[] u206b‏‎​‍‮⁪‌⁭⁫⁬‫‮‭‍‪⁬‪‬⁪⁬⁮‍‪‎‏⁮‮⁭⁫⁯⁭⁬⁭⁬⁯⁮⁬‎⁫‮ = new Rules[] { new Rules(GlobalNames.Perceived_channel_state, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Timing_change_required, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Timing_adjustment, 12, RulesType.Switch, 579, 1, 0), new Rules(GlobalNames.New_call_pre_emption, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Type_of_pre_emption, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Priority_level, 2, RulesType.Direct, 0, 0, 0) };

	// ‭⁬​‭‍‭⁮⁬⁯⁫⁮⁭‏‪‪⁭⁭​⁫⁫⁭‪⁮‭‍⁮⁭⁯​‫‬⁮⁮‌⁮‪‭⁮⁯‫‮
	private readonly Rules[] u202d⁬​‭‍‭⁮⁬⁯⁫⁮⁭‏‪‪⁭⁭​⁫⁫⁭‪⁮‭‍⁮⁭⁯​‫‬⁮⁮‌⁮‪‭⁮⁯‫‮ = new Rules[] { new Rules(GlobalNames.Timing_change_announced, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Timing_adjustment, 12, RulesType.Switch, 568, 1, 0), new Rules(GlobalNames.New_call_pre_emption, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Type_of_pre_emption, 4, RulesType.Direct, 0, 0, 0) };

	// ‬‭⁮​‮⁪⁬‌⁭‭⁮​‪⁭‌‮‭‮‪‎‍⁬‪‏‌‬‫​‮⁬‍​‫⁮‮⁬‬⁭⁯⁭‮
	private readonly Rules[] u202c‭⁮​‮⁪⁬‌⁭‭⁮​‪⁭‌‮‭‮‪‎‍⁬‪‏‌‬‫​‮⁬‍​‫⁮‮⁬‬⁭⁯⁭‮ = new Rules[] { new Rules(GlobalNames.Reject_cause, 4, RulesType.Direct, 0, 0, 0) };

	// ‏⁯‬⁭‫⁪⁫‌‫​‍⁯‪​‍‫‭‎‏⁫⁬‍‌‌⁪⁯‭‎⁪⁮⁭‎‎‫‮⁭‌‏‪⁭‮
	private readonly Rules[] u200f⁯‬⁭‫⁪⁫‌‫​‍⁯‪​‍‫‭‎‏⁫⁬‍‌‌⁪⁯‭‎⁪⁮⁭‎‎‫‮⁭‌‏‪⁭‮ = new Rules[] { new Rules(GlobalNames.Information_type, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Calling_party_TSI, 48, RulesType.Switch, 574, 0, 0) };

	// ⁪‎‮⁫​‫‪‫⁫⁬‮‬​‍⁯‪‬⁮‫​⁯‎​⁫‏‏‍‌‬‍⁬‭‍⁯‮⁮‍⁫‫⁯‮
	private readonly Rules[] u206a‎‮⁫​‫‪‫⁫⁬‮‬​‍⁯‪‬⁮‫​⁯‎​⁫‏‏‍‌‬‍⁬‭‍⁯‮⁮‍⁫‫⁯‮ = new Rules[] { new Rules(GlobalNames.SDS_time_remaining, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.SDS_transaction_type, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Priority_level, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.FCS_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Additional_addressing_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 0, RulesType.Jamp, 534, 0, 9), new Rules(GlobalNames.Additional_address_types, 4, RulesType.Switch, 534, 1, 0), new Rules(GlobalNames.MCC, 10, RulesType.Switch, 535, 1, 0), new Rules(GlobalNames.MNC, 14, RulesType.Switch, 535, 1, 0), new Rules(GlobalNames.SDS_SSI, 24, RulesType.Switch, 535, 1, 0), new Rules(GlobalNames.Area_selection, 4, RulesType.Switch, 535, 2, 0), new Rules(GlobalNames.Area_selection, 4, RulesType.Switch, 535, 3, 0), new Rules(GlobalNames.MCC, 10, RulesType.Switch, 535, 3, 0), new Rules(GlobalNames.MNC, 14, RulesType.Switch, 535, 3, 0), new Rules(GlobalNames.SDS_SSI, 24, RulesType.Switch, 535, 3, 0) };

	// ‭​​‮⁯⁭‮⁫⁪‍‮‭‌‌⁭⁫⁮‬‎‪‎‏⁯‍‪⁪‎‮⁬⁯⁪⁪⁬​‫‬‭⁪⁯‭‮
	private readonly Rules[] u202d​​‮⁯⁭‮⁫⁪‍‮‭‌‌⁭⁫⁮‬‎‪‎‏⁯‍‪⁪‎‮⁬⁯⁪⁪⁬​‫‬‭⁪⁯‭‮ = new Rules[] { new Rules(GlobalNames.Short_data_type_identifier, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.User_Defined_Data_16, 16, RulesType.Switch, 59, 0, 0), new Rules(GlobalNames.User_Defined_Data_32, 32, RulesType.Switch, 59, 1, 0), new Rules(GlobalNames.User_Defined_Data_64_1, 32, RulesType.Switch, 59, 2, 0), new Rules(GlobalNames.User_Defined_Data_64_2, 32, RulesType.Switch, 59, 2, 0), new Rules(GlobalNames.User_Defined_Data4_Length_Indicator, 11, RulesType.Switch, 59, 3, 0), new Rules(GlobalNames.User_Defined_Data4, 0, RulesType.Switch, 59, 3, 0) };

	// ‭‬‫⁪‪⁬⁫‬⁪‭⁪⁫⁭⁭⁪⁬⁫⁫⁭⁫‬‮⁯‬‭‍⁪⁫⁬⁯⁮⁪⁮‏‪‎⁮‍‏‭‮
	private readonly Rules[] u202d‬‫⁪‪⁬⁫‬⁪‭⁪⁫⁭⁭⁪⁬⁫⁫⁭⁫‬‮⁯‬‭‍⁪⁫⁬⁯⁮⁪⁮‏‪‎⁮‍‏‭‮ = new Rules[] { new Rules(GlobalNames.FCS_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Acknowledgement_type, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 0, RulesType.JampNot, 531, 1, 7), new Rules(GlobalNames.Short_data_type_identifier, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.User_Defined_Data_16, 16, RulesType.Switch, 59, 0, 0), new Rules(GlobalNames.User_Defined_Data_32, 32, RulesType.Switch, 59, 1, 0), new Rules(GlobalNames.User_Defined_Data_64_1, 32, RulesType.Switch, 59, 2, 0), new Rules(GlobalNames.User_Defined_Data_64_2, 32, RulesType.Switch, 59, 2, 0), new Rules(GlobalNames.User_Defined_Data4_Length_Indicator, 11, RulesType.Switch, 59, 3, 0), new Rules(GlobalNames.User_Defined_Data4, 0, RulesType.Switch, 59, 3, 0) };

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‭‌‪‬‭‪⁫⁬‍⁬‮‫‌‬⁮‮⁪‬‏‭‮⁪​‭⁫⁪‬‍⁭‬‪‎‮⁭‎‪⁭​‭‮
	public void u202d‌‪‬‭‪⁫⁬‍⁬‮‫‌‬⁮‮⁪‬‏‭‮⁪​‭⁫⁪‬‍⁭‬‪‎‮⁭‎‪⁭​‭‮(LogicChannel , int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ⁭‎​⁪⁪‎‫‪​‭‫⁮‌‍‬⁭⁯‏‌⁭​‌‪‌‬⁭⁫‮‬⁪‏⁫⁪‫‫‬‬‬‪‪‮::‭‌‪‬‭‪⁫⁬‍⁬‮‫‌‬⁮‮⁪‬‏‭‮⁪​‭⁫⁪‬‍⁭‬‪‎‮⁭‎‪⁭​‭‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‭‌‪‬‭‪⁫⁬‍⁬‮‫‌‬⁮‮⁪‬‏‭‮⁪​‭⁫⁪‬‍⁭‬‪‎‮⁭‎‪⁭​‭‮(SDRSharp.Tetra.LogicChannel,System.Int32,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// 
		// Not supported type System.Object.
		//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetTypeIndex(TypeDefinition type) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 684
		//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetContainingType(TypeDefinition leftType, TypeDefinition rightType) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 608
		//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.GetExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 492
		//    at Telerik.JustDecompiler.Ast.Expressions.BinaryExpression.get_ExpressionType() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Ast\Expressions\BinaryExpression.cs:line 414
		//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddAssignmentCastIfNeeded(Expression expr) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 112
		//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.FixAssignmentInList(IList`1 expressionList, Expression value) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 75
		//    at Telerik.JustDecompiler.Decompiler.TypeInference.TypeInferer.AddCasts() in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\TypeInference\TypeInferer.cs:line 38
		//    at Telerik.JustDecompiler.Decompiler.ExpressionDecompilerStep.Process(DecompilationContext theContext, BlockStatement body) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\ExpressionDecompilerStep.cs:line 68
		//    at Telerik.JustDecompiler.Decompiler.DecompilationPipeline.RunInternal(MethodBody body, BlockStatement block, ILanguage language) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\DecompilationPipeline.cs:line 100
		//    at Telerik.JustDecompiler.Decompiler.WriterContextServices.BaseWriterContextService.DecompileMethod(ILanguage language, MethodDefinition method, TypeSpecificContext typeContext) in D:\a\CodemerxDecompile\CodemerxDecompile\src\JustDecompileEngine\src\JustDecompiler.Shared\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 133
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	// ​⁫⁯⁯‬‪‫‬⁫⁭⁪‬‭⁯‮‌‪⁭‍‭‫‭‪‬‌⁭⁬​‎‎⁬‮​⁯‬‪​​‪‎‮
	// privatescope
	internal static string u200b⁫⁯⁯‬‪‫‬⁫⁭⁪‬‭⁯‮‌‪⁭‍‭‫‭‪‬‌⁭⁬​‎‎⁬‮​⁯‬‪​​‪‎‮(object obj, object obj)
	{
		return string.Concat(obj, obj);
	}

	public u206d‎​⁪⁪‎‫‪​‭‫⁮‌‍‬⁭⁯‏‌⁭​‌‪‌‬⁭⁫‮‬⁪‏⁫⁪‫‫‬‬‬‪‪‮()
	{
	}
}