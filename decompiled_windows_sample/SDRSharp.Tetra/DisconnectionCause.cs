using System;

namespace SDRSharp.Tetra
{
	public enum DisconnectionCause
	{
		Cause_not_defined_or_unknown,
		User_requested_disconnection,
		Called_party_busy,
		Called_party_not_reachable,
		Called_party_does_not_support_encryption,
		Congestion_in_infrastructure,
		Not_allowed_traffic_case,
		Incompatible_traffic_case,
		Requested_service_not_available,
		Pre_emptive_use_of_resource,
		Invalid_call_identifier,
		Call_rejected_by_the_called_party,
		No_idle_CC_entity,
		Expiry_of_timer,
		SwMI_requested_disconnection,
		Acknowledged_service_not_completed,
		Unknown_TETRA_identity,
		SS_specific_disconnection,
		Unknown_external_subscriber_identity,
		Call_restoration_of_the_other_user_failed,
		Called_party_requires_encryption,
		Concurrent_setup_not_supported,
		Called_party_is_under_the_same_DM_GATE_of_the_calling_party,
		Non_call_owner_requested_disconnection,
		Reserved24,
		Reserved25,
		Reserved26,
		Reserved27,
		Reserved28,
		Reserved29,
		Reserved30,
		Reserved31
	}
}