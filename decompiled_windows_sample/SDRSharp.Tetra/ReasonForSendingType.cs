using System;

namespace SDRSharp.Tetra
{
	public enum ReasonForSendingType
	{
		Subscriber_unit_is_powered_ON = 0,
		Subscriber_unit_is_powered_OFF = 1,
		Emergency_condition_is_detected = 2,
		Push_to_talk_condition_is_detected = 3,
		Status = 4,
		Transmit_inhibit_mode_ON = 5,
		Transmit_inhibit_mode_OFF = 6,
		System_access_TMO_ON = 7,
		DMO_ON = 8,
		Enter_service_after_being_out_of_service = 9,
		Service_loss = 10,
		Cell_reselection_or_change_of_serving_cell = 11,
		Low_battery = 12,
		Subscriber_unit_is_connected_to_a_car_kit = 13,
		Subscriber_unit_is_disconnected_from_a_car_kit = 14,
		Subscriber_unit_asks_for_transfer_initialization_configuration = 15,
		Arrival_at_destination = 16,
		Arrival_at_a_defined_location = 17,
		Approaching_a_defined_location = 18,
		SDS_type_1_entered = 19,
		User_application_initiated = 20,
		Lost_ability_to_determine_location = 21,
		Regained_ability_to_determine_location = 22,
		Leaving_point = 23,
		Ambience_Listening_call_is_detected = 24,
		Start_of_temporary_reporting = 25,
		Return_to_normal_reporting = 26,
		Reserved_27 = 27,
		Reserved_28 = 28,
		Reserved_29 = 29,
		Reserved_30 = 30,
		Reserved_31 = 31,
		Response_to_an_immediate_location_request = 32,
		Reserved_33 = 33,
		Reserved_128 = 128,
		Maximum_reporting_interval_exceeded_since_the_last_location_information_report = 129,
		Maximum_reporting_distance_limit_travelled_since_last_location_information_report = 130,
		Reserved_131 = 131,
		Reserved_255 = 255
	}
}