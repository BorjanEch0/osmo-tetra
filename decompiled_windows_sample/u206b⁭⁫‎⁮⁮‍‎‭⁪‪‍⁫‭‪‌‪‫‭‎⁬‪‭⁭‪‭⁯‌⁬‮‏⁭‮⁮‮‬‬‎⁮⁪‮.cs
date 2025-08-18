using SDRSharp.Tetra;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// ⁫⁭⁫‎⁮⁮‍‎‭⁪‪‍⁫‭‪‌‪‫‭‎⁬‪‭⁭‪‭⁯‌⁬‮‏⁭‮⁮‮‬‬‎⁮⁪‮
internal class u206b⁭⁫‎⁮⁮‍‎‭⁪‪‍⁫‭‪‌‪‫‭‎⁬‪‭⁭‪‭⁯‌⁬‮‏⁭‮⁮‮‬‬‎⁮⁪‮
{
	// ‌​‌‎‬⁬‌‏⁬⁬‎‎⁮⁬⁭‬‌‭‎‍‬‍‌‫‎‍‭‮‮‎⁯‏‏‌⁭‬⁮‌⁪‫‮
	public static List<Dictionary<int, string>> u200c​‌‎‬⁬‌‏⁬⁬‎‎⁮⁬⁭‬‌‭‎‍‬‍‌‫‎‍‭‮‮‎⁯‏‏‌⁭‬⁮‌⁪‫‮;

	// ⁮⁮‪‮⁫‬‌⁫⁮‎⁯‭‫‪‬‎⁫‏⁮‪‌⁭‬‍⁭⁯‮⁫⁯‪‏⁯⁪⁭‎⁫⁯⁪‬⁮‮
	private u206d⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮ u206e⁮‪‮⁫‬‌⁫⁮‎⁯‭‫‪‬‎⁫‏⁮‪‌⁭‬‍⁭⁯‮⁫⁯‪‏⁯⁪⁭‎⁫⁯⁪‬⁮‮ = new u206d⁮‮‎‪‮‫‪‍⁬⁬‬‭‮‫⁮‎‎‪‏‌​‭​⁮⁬‭⁫‫‏​⁯⁯⁮‪​‪‌⁮⁭‮();

	// ⁬⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮
	private bool u206c⁭⁭‍⁮​⁮⁪⁮‍‍‌‍‪‭‬‫⁪‪‍​⁯‪‌⁪⁭‎‏⁮‭‪⁫⁫⁭‭‏‪⁭​⁭‮;

	// ⁪⁫‫⁮‮⁮‪‏⁭‮‌‏⁭‍‫‭‪‌‭‏‌⁬‍‌‬‍⁫‍‮‪‎​‪⁯⁫‎‎‏‍‬‮
	private readonly Rules[] u206a⁫‫⁮‮⁮‪‏⁭‮‌‏⁭‍‫‭‪‌‭‏‌⁬‍‌‬‍⁫‍‮‪‎​‪⁯⁫‎‎‏‍‬‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Call_time_out_setup_phase, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 1, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Simplex_duplex, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Call_queued, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 5, 0, 0), new Rules(GlobalNames.Basic_service_Circuit_mode_type, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Encryption_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Communication_type, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Slots_per_frame, 2, RulesType.SwitchNot, 38, 0, 0), new Rules(GlobalNames.Basic_service_Speech_service, 2, RulesType.Switch, 38, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0) };

	// ‪‭⁭‎⁫⁭​⁭‌⁪‭​‬‌‌‍‎‏‎‬‬​‫‭‮⁭‭‏‬‌⁫⁯‌⁯‮‍⁬‎‫⁪‮
	private readonly Rules[] u202a‭⁭‎⁫⁭​⁭‌⁪‭​‬‌‌‍‎‏‎‬‬​‫‭‮⁭‭‏‬‌⁫⁯‌⁯‮‍⁬‎‫⁪‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Call_time_out_setup_phase, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Hook_method, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Simplex_duplex, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 5, 0, 0), new Rules(GlobalNames.Basic_service_Circuit_mode_type, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Encryption_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Communication_type, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Slots_per_frame, 2, RulesType.SwitchNot, 38, 0, 0), new Rules(GlobalNames.Basic_service_Speech_service, 2, RulesType.Switch, 38, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Call_status, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0) };

	// ​⁫⁫⁪‍⁭⁬‮‪‬‍‬⁮‮‮‬‬‭‏‏‌⁫‌‮⁯‎⁮‬⁮‬‫‎‬⁭‫‏‬⁮‎‍‮
	private readonly Rules[] u200b⁫⁫⁪‍⁭⁬‮‪‬‍‬⁮‮‮‬‬‭‏‏‌⁫‌‮⁯‎⁮‬⁮‬‫‎‬⁭‫‏‬⁮‎‍‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Call_time_out, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Hook_method, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Simplex_duplex, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_grant, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_request_permission, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Call_ownership, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Call_priority, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 5, 0, 0), new Rules(GlobalNames.Basic_service_Circuit_mode_type, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Encryption_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Communication_type, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Slots_per_frame, 2, RulesType.SwitchNot, 38, 0, 0), new Rules(GlobalNames.Basic_service_Speech_service, 2, RulesType.Switch, 38, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Temporary_address, 24, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0) };

	// ‍⁬⁭‫⁭⁪⁪‎‌‎​‪‍‏⁮⁯⁬‬​‏‎⁮‬⁮⁮‪‭⁯⁫‪‫⁫‭‌‭‬‌⁬‭‮
	private readonly Rules[] u200d⁬⁭‫⁭⁪⁪‎‌‎​‪‍‏⁮⁯⁬‬​‏‎⁮‬⁮⁮‪‭⁯⁫‪‫⁫‭‌‭‬‌⁬‭‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Call_time_out, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_grant, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_request_permission, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0) };

	// ⁬‪⁯⁬‮⁯⁫‫⁭⁮‫‭⁯‌‍⁮‬​​‌‎⁮⁮⁯⁮⁭⁯⁭⁮⁭⁭‭‫‮‌‎‭‌‬‬‮
	private readonly Rules[] u206c‪⁯⁬‮⁯⁫‫⁭⁮‫‭⁯‌‍⁮‬​​‌‎⁮⁮⁯⁮⁭⁯⁭⁮⁭⁭‭‫‮‌‎‭‌‬‬‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Disconnect_cause, 5, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0) };

	// ⁫‍⁯‬‪⁭⁪‍‏‫‬⁭⁭⁬‬‮‍‏⁭‬‍‬‮‎⁯⁯‪‭‫‫‏‍⁪​‬⁬‭⁭​‍‮
	private readonly Rules[] u206b‍⁯‬‪⁭⁪‍‏‫‬⁭⁭⁬‬‮‍‏⁭‬‍‬‮‎⁯⁯‪‭‫‫‏‍⁪​‬⁬‭⁭​‍‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reset_Call_time_out, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Poll_request, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.New_Call_Identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Call_time_out, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Call_time_out_setup_phase, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Call_ownership, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 7, 0, 0), new Rules(GlobalNames.Modify, 0, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Simplex_duplex, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Circuit_mode_type, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Encryption_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Communication_type, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Slots_per_frame, 2, RulesType.SwitchNot, 38, 0, 0), new Rules(GlobalNames.Basic_service_Speech_service, 2, RulesType.Switch, 38, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Call_status, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Temporary_address, 24, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Poll_response_percentage, 6, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Poll_response_number, 6, RulesType.Direct, 0, 0, 0) };

	// ‭‏⁬⁯‮‪⁭‬‭‍‏‎‬⁬‪⁯‏‍⁪⁯⁯​⁬‬⁭‮‍⁭⁮⁯‏⁭‫‎⁪‭‮‮​⁪‮
	private readonly Rules[] u202d‏⁬⁯‮‪⁭‬‭‍‏‎‬⁬‪⁯‏‍⁪⁯⁯​⁬‬⁭‮‍⁭⁮⁯‏⁭‫‎⁪‭‮‮​⁪‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Disconnect_cause, 5, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0) };

	// ‪⁪‬‍⁮⁭‮‫‏​‏‏‭⁭‬‌‏‌‮‏⁭‫‪⁭​‎‪⁯⁬⁪⁯‫‭⁯​‬‬⁫‫‌‮
	private readonly Rules[] u202a⁪‬‍⁮⁭‮‫‏​‏‏‭⁭‬‌‏‌‮‏⁭‫‪⁭​‎‪⁯⁬⁪⁯‫‭⁯​‬‬⁫‫‌‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Call_time_out, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Hook_method, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Simplex_duplex, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Circuit_mode_type, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Encryption_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Communication_type, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Slots_per_frame, 2, RulesType.SwitchNot, 38, 0, 0), new Rules(GlobalNames.Basic_service_Speech_service, 2, RulesType.Switch, 38, 0, 0), new Rules(GlobalNames.Transmission_grant, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_request_permission, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Call_priority, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Temporary_address, 24, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 4, 0, 0), new Rules(GlobalNames.Calling_party_type_identifier, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Calling_party_address_SSI, 24, RulesType.Switch, 34, 1, 0), new Rules(GlobalNames.Calling_party_address_SSI, 24, RulesType.Switch, 34, 2, 0), new Rules(GlobalNames.Calling_party_extension, 24, RulesType.Switch, 34, 2, 0) };

	// ‫‍‬‪‪⁭⁬‎⁪‬​‌⁯‭​⁮⁫‫‭⁫⁯‫‬‭‏‏⁫⁭⁯⁬⁪‫‫‬⁫⁫⁮‌‬⁬‮
	private readonly Rules[] u202b‍‬‪‪⁭⁬‎⁪‬​‌⁯‭​⁮⁫‫‭⁫⁯‫‬‭‏‏⁫⁭⁯⁬⁪‫‫‬⁫⁫⁮‌‬⁬‮ = new Rules[] { new Rules(GlobalNames.Calling_party_type_identifier, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Calling_party_address_SSI, 24, RulesType.Switch, 34, 1, 0), new Rules(GlobalNames.Calling_party_address_SSI, 24, RulesType.Switch, 34, 2, 0), new Rules(GlobalNames.Calling_party_extension, 24, RulesType.Switch, 34, 2, 0), new Rules(GlobalNames.Pre_coded_status, 16, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0) };

	// ‫⁮‭​‍‍‌‪‫⁮‫⁬⁫‏⁮​‪‮‍‏⁬‌‫‬⁬‫‌‌⁮‬⁪⁬‫‎‏⁬‪‪‭⁭‮
	private readonly Rules[] u202b⁮‭​‍‍‌‪‫⁮‫⁬⁫‏⁮​‪‮‍‏⁬‌‫‬⁬‫‌‌⁮‬⁪⁬‫‎‏⁬‪‪‭⁭‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_request_permission, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0) };

	// ‪⁫‏​‫⁯‍⁭​​⁭‎⁯‮‮‍‮‎‮​⁯⁫‏​‎​‮‫⁬‎⁭‪‎‌‪⁭‭‭⁬‎‮
	private readonly Rules[] u202a⁫‏​‫⁯‍⁭​​⁭‎⁯‮‮‍‮‎‮​⁯⁫‏​‎​‮‫⁬‎⁭‪‎‌‪⁭‭‭⁬‎‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Continue, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_request_permission, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0) };

	// ‪‫⁭‬‫‏⁯‭‫‭‬‭‪​⁫⁫‭‫‎​‫⁪⁯⁫‎⁭⁭‬‎‍⁮‬⁮‭‏‫‏‮‭‮‮
	private readonly Rules[] u202a‫⁭‬‫‏⁯‭‫‭‬‭‪​⁫⁫‭‫‎​‫⁪⁯⁫‎⁭⁭‬‎‍⁮‬⁮‭‏‫‏‮‭‮‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_grant, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_request_permission, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Encryption_control, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 1, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 4, 0, 0), new Rules(GlobalNames.Transmitting_party_type_identifier, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmitting_party_address_SSI, 24, RulesType.Switch, 26, 1, 0), new Rules(GlobalNames.Transmitting_party_address_SSI, 24, RulesType.Switch, 26, 2, 0), new Rules(GlobalNames.Transmitting_party_extension, 24, RulesType.Switch, 26, 2, 0) };

	// ‏⁭⁯‏⁬‌‬‍‏‫‍‪⁪‫⁭⁯⁭⁬⁯‌⁯‫‍⁬‍‪‌⁮⁭​‪⁫​⁬‫⁬‫⁬‍‮‮
	private readonly Rules[] u200f⁭⁯‏⁬‌‬‍‏‫‍‪⁪‫⁭⁯⁭⁬⁯‌⁯‫‍⁬‍‪‌⁮⁭​‪⁫​⁬‫⁬‫⁬‍‮‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_request_permission, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0) };

	// ‪‬‫​‌⁭⁭⁭⁪⁫⁯‎‭‎‌​‌‏⁬⁫‭⁯⁭‮‎‬⁮⁪‪‬‏⁪⁬⁬‪‬⁯‎‪‪‮
	private readonly Rules[] u202a‬‫​‌⁭⁭⁭⁪⁫⁯‎‭‎‌​‌‏⁬⁫‭⁯⁭‮‎‬⁮⁪‪‬‏⁪⁬⁬‪‬⁯‎‪‪‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_grant, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_request_permission, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Encryption_control, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reserved, 1, RulesType.Reserved, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 4, 0, 0), new Rules(GlobalNames.Transmitting_party_type_identifier, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmitting_party_address_SSI, 24, RulesType.Switch, 26, 1, 0), new Rules(GlobalNames.Transmitting_party_address_SSI, 24, RulesType.Switch, 26, 2, 0), new Rules(GlobalNames.Transmitting_party_extension, 24, RulesType.Switch, 26, 2, 0) };

	// ‪‬⁫‌⁭‬⁭⁫‮‫⁫‮‏‮‍⁮⁭‭⁪⁪⁪‫‭​‭⁯⁭​⁪‮‌⁬⁮⁯‬⁯⁪‏⁪‌‮
	private readonly Rules[] u202a‬⁫‌⁭‬⁭⁫‮‫⁫‮‏‮‍⁮⁭‭⁪⁪⁪‫‭​‭⁯⁭​⁪‮‌⁬⁮⁯‬⁯⁪‏⁪‌‮ = new Rules[] { new Rules(GlobalNames.Call_identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_grant, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Transmission_request_permission, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Reset_Call_time_out, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Options_bit, 1, RulesType.Options_bit, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.New_Call_Identifier, 14, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Call_time_out, 4, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Call_status, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 7, 0, 0), new Rules(GlobalNames.Modify, 0, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Simplex_duplex, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Circuit_mode_type, 3, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Encryption_flag, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Communication_type, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Basic_service_Slots_per_frame, 2, RulesType.SwitchNot, 38, 0, 0), new Rules(GlobalNames.Basic_service_Speech_service, 2, RulesType.Switch, 38, 0, 0), new Rules(GlobalNames.Presence_bit, 1, RulesType.Presence_bit, 1, 0, 0), new Rules(GlobalNames.Notification_indicator, 6, RulesType.Direct, 0, 0, 0) };

	// ⁭‭‬⁯‭‏⁭‪‫‎‭‎‮‏‫⁪‍⁪⁬⁯​‍‮‎‏⁭‌​⁭‌‫‌​⁭‎‍⁭‎⁬⁭‮
	private readonly Rules[] u206d‭‬⁯‭‏⁭‪‫‎‭‎‮‏‫⁪‍⁪⁬⁯​‍‮‎‏⁭‌​⁭‌‫‌​⁭‎‍⁭‎⁬⁭‮ = new Rules[] { new Rules(GlobalNames.Calling_party_type_identifier, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Calling_party_address_SSI, 24, RulesType.Switch, 34, 1, 0), new Rules(GlobalNames.Calling_party_address_SSI, 24, RulesType.Switch, 34, 2, 0), new Rules(GlobalNames.Calling_party_extension, 24, RulesType.Switch, 34, 2, 0), new Rules(GlobalNames.Short_data_type_identifier, 2, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.User_Defined_Data_16, 16, RulesType.Switch, 59, 0, 0), new Rules(GlobalNames.User_Defined_Data_32, 32, RulesType.Switch, 59, 1, 0), new Rules(GlobalNames.User_Defined_Data_64_1, 32, RulesType.Switch, 59, 2, 0), new Rules(GlobalNames.User_Defined_Data_64_2, 32, RulesType.Switch, 59, 2, 0), new Rules(GlobalNames.User_Defined_Data4_Length_Indicator, 11, RulesType.Switch, 59, 3, 0), new Rules(GlobalNames.User_Defined_Data4, 0, RulesType.Switch, 59, 3, 0) };

	// ⁬‫‮‭⁫⁬‮⁪⁮⁫‌⁬⁪‌‪‭‌⁪⁬‭⁮‌‎⁪‭⁫​‌‪​‏‍‮​⁫‫‫‌​‮‮
	private readonly Rules[] u206c‫‮‭⁫⁬‮⁪⁮⁫‌⁬⁪‌‪‭‌⁪⁬‭⁮‌‎⁪‭⁫​‌‪​‏‍‮​⁫‫‫‌​‮‮ = new Rules[] { new Rules(GlobalNames.Number_of_SS_PDUs, 4, RulesType.Direct, 0, 0, 0) };

	// ‌⁮⁬⁬⁬‪‬‌‮‏‌‌‏⁪⁭⁫​‌⁯‎‮‍‫‌‍⁬⁪⁭‫‏‭⁭‭⁮⁪‫‭⁪‮‭‮
	private readonly Rules[] u200c⁮⁬⁬⁬‪‬‌‮‏‌‌‏⁪⁭⁫​‌⁯‎‮‍‫‌‍⁬⁪⁭‫‏‭⁭‭⁮⁪‫‭⁪‮‭‮ = new Rules[] { new Rules(GlobalNames.CMCE_Not_supported_PDU_type, 5, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Call_identifier_present, 1, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Call_identifier, 14, RulesType.Switch, 55, 1, 0), new Rules(GlobalNames.Function_not_supported_pointer, 8, RulesType.Direct, 0, 0, 0), new Rules(GlobalNames.Length_of_received_PDU_extract, 8, RulesType.SwitchNot, 56, 0, 0) };

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‮‮‬‮⁪‭‫‎‭⁭​⁫‌⁭⁫⁪​‎‎‬⁬‫‮‬‌⁬⁪⁮‏⁪‎⁮⁮‪‮‎‭⁬⁬⁪‮
	public void u202e‮‬‮⁪‭‫‎‭⁭​⁫‌⁭⁫⁪​‎‎‬⁬‫‮‬‌⁬⁪⁮‏⁪‎⁮⁮‪‮‎‭⁬⁬⁪‮(LogicChannel , ref int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ⁫⁭⁫‎⁮⁮‍‎‭⁪‪‍⁫‭‪‌‪‫‭‎⁬‪‭⁭‪‭⁯‌⁬‮‏⁭‮⁮‮‬‬‎⁮⁪‮::‮‮‬‮⁪‭‫‎‭⁭​⁫‌⁭⁫⁪​‎‎‬⁬‫‮‬‌⁬⁪⁮‏⁪‎⁮⁮‪‮‎‭⁬⁬⁪‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‮‮‬‮⁪‭‫‎‭⁭​⁫‌⁭⁫⁪​‎‎‬⁬‫‮‬‌⁬⁪⁮‏⁪‎⁮⁮‪‮‎‭⁬⁬⁪‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‭⁫‌⁯‭⁭‭‍‏‏⁮‫‌​‎‭‪⁯‫⁮‌‏‬⁫⁯⁬‬‎‭‭‍⁬⁭‏⁮‪‫‍⁬⁪‮
	private void u202d⁫‌⁯‭⁭‭‍‏‏⁮‫‌​‎‭‪⁯‫⁮‌‏‬⁫⁯⁬‬‎‭‭‍⁬⁭‏⁮‪‫‍⁬⁪‮(LogicChannel , ref int , Dictionary<GlobalNames, int> )
	{
		// 
		// Current member / type: System.Void ⁫⁭⁫‎⁮⁮‍‎‭⁪‪‍⁫‭‪‌‪‫‭‎⁬‪‭⁭‪‭⁯‌⁬‮‏⁭‮⁮‮‬‬‎⁮⁪‮::‭⁫‌⁯‭⁭‭‍‏‏⁮‫‌​‎‭‪⁯‫⁮‌‏‬⁫⁯⁬‬‎‭‭‍⁬⁭‏⁮‪‫‍⁬⁪‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‭⁫‌⁯‭⁭‭‍‏‏⁮‫‌​‎‭‪⁯‫⁮‌‏‬⁫⁯⁬‬‎‭‭‍⁬⁭‏⁮‪‫‍⁬⁪‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	// ‏⁮‭‏⁯‮‪‮​‬​‍‌‪⁮⁭‏⁬‏‌⁮⁪⁮‫‬‏‪‬‏⁮‎⁫‮⁫‍⁬‌⁬⁮‭‮
	private void u200f⁮‭‏⁯‮‪‮​‬​‍‌‪⁮⁭‏⁬‏‌⁮⁪⁮‫‬‏‪‬‏⁮‎⁫‮⁫‍⁬‌⁬⁮‭‮(LogicChannel , ref int , Dictionary<GlobalNames, int> , int , int )
	{
		// 
		// Current member / type: System.Void ⁫⁭⁫‎⁮⁮‍‎‭⁪‪‍⁫‭‪‌‪‫‭‎⁬‪‭⁭‪‭⁯‌⁬‮‏⁭‮⁮‮‬‬‎⁮⁪‮::‏⁮‭‏⁯‮‪‮​‬​‍‌‪⁮⁭‏⁬‏‌⁮⁪⁮‫‬‏‪‬‏⁮‎⁫‮⁫‍⁬‌⁬⁮‭‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary`2<SDRSharp.Tetra.GlobalNames,System.Int32>,System.Int32,System.Int32)
		// File path: C:\SDRSharp\Plugins\Tetra\SDRSharp.Tetra.dll
		// 
		// Product version: 0.0.0.0
		// Exception in: System.Void ‏⁮‭‏⁯‮‪‮​‬​‍‌‪⁮⁭‏⁬‏‌⁮⁪⁮‫‬‏‪‬‏⁮‎⁫‮⁫‍⁬‌⁬⁮‭‮(SDRSharp.Tetra.LogicChannel,System.Int32&,System.Collections.Generic.Dictionary<SDRSharp.Tetra.GlobalNames,System.Int32>,System.Int32,System.Int32)
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

	// ⁮‪‏‪‫⁭⁪⁮⁪⁯‬⁮‫‍⁬‭‏⁯⁬‪‪‮‎⁪⁪‭‍‍⁭​⁯‎⁪‬‍‍‏⁯‍‭‮
	// privatescope
	internal static string u206e‪‏‪‫⁭⁪⁮⁪⁯‬⁮‫‍⁬‭‏⁯⁬‪‪‮‎⁪⁪‭‍‍⁭​⁯‎⁪‬‍‍‏⁯‍‭‮(string str, string str)
	{
		return string.Concat(str, str);
	}

	// ‌‌⁬‬‏‬⁭‏‬‍‬⁯‪⁫‏⁫‮‮⁫‬⁬‏‍⁪⁫‮⁬‌⁬‬‮⁯⁪‏⁬​‮‫⁬‮
	// privatescope
	internal static string u200c‌⁬‬‏‬⁭‏‬‍‬⁯‪⁫‏⁫‮‮⁫‬⁬‏‍⁪⁫‮⁬‌⁬‬‮⁯⁪‏⁬​‮‫⁬‮(object obj, object obj, object obj)
	{
		return string.Concat(obj, obj, obj);
	}

	// ⁯‎​​‬‭‫‍‮⁪‏‎⁪‪‎⁪​‎‎⁪‫‎⁮​⁮‬‍‍⁯‏‭​⁯‫‫⁭‬‍‏⁫‮
	// privatescope
	internal static bool u206f‎​​‬‭‫‍‮⁪‏‎⁪‪‎⁪​‎‎⁪‫‎⁮​⁮‬‍‍⁯‏‭​⁯‫‫⁭‬‍‏⁫‮(string str, string str)
	{
		return str != str;
	}

	static u206b⁭⁫‎⁮⁮‍‎‭⁪‪‍⁫‭‪‌‪‫‭‎⁬‪‭⁭‪‭⁯‌⁬‮‏⁭‮⁮‮‬‬‎⁮⁪‮()
	{
		u206b⁭⁫‎⁮⁮‍‎‭⁪‪‍⁫‭‪‌‪‫‭‎⁬‪‭⁭‪‭⁯‌⁬‮‏⁭‮⁮‮‬‬‎⁮⁪‮.u200c​‌‎‬⁬‌‏⁬⁬‎‎⁮⁬⁭‬‌‭‎‍‬‍‌‫‎‍‭‮‮‎⁯‏‏‌⁭‬⁮‌⁪‫‮ = new List<Dictionary<int, string>>();
	}

	public u206b⁭⁫‎⁮⁮‍‎‭⁪‪‍⁫‭‪‌‪‫‭‎⁬‪‭⁭‪‭⁯‌⁬‮‏⁭‮⁮‮‬‬‎⁮⁪‮()
	{
	}
}