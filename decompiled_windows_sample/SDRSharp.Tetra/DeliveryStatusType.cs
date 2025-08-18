using System;

namespace SDRSharp.Tetra
{
	public enum DeliveryStatusType
	{
		SDS_receipt_acknowledged_by_destination_Destination_Success = 0,
		SDS_receipt_report_acknowledgement_SwMI_Source_Success = 1,
		SDS_consumed_by_destination_Destination_Success = 2,
		SDS_consumed_report_acknowledgement_SwMI_Source_Success = 3,
		SDS_message_forwarded_to_external_network_SwMI_Success = 4,
		SDS_sent_to_group_acknowledgements_prevented_SwMI_Success = 5,
		Concatenation_part_receipt_acknowledged_by_destination_Destination_Success = 6,
		Reserved_7 = 7,
		Reserved_31 = 31,
		Congestion_message_stored_by_SwMI_SwMI = 32,
		message_stored_by_SwMI_SwMI = 33,
		Destination_not_reachable_message_stored_by_SwMI_SwMI = 34,
		Reserved_35 = 35,
		Reserved_63 = 63,
		Network_overload_SwMI_Temporary = 64,
		Service_permanently_not_available_on_BS_SwMI_Permanent = 65,
		Service_temporary_not_available_on_BS_SwMI_Temporary = 66,
		Source_is_not_authorized_for_SDS_SwMI_Temporary = 67,
		Destination_is_not_authorized_for_SDS_SwMI_Temporary = 68,
		Unknown_destination_gateway_or_service_centre_address_SwMI_Permanent = 69,
		Unknown_forward_address_SwMI_Permanent = 70,
		Group_address_with_individual_service_SwMI_Permanent = 71,
		Validity_period_expired_message_not_received_by_far_end = 72
	}
}