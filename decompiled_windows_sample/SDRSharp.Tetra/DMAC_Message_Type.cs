using System;

namespace SDRSharp.Tetra
{
	public enum DMAC_Message_Type
	{
		DM_RESERVED,
		DM_SDS_OCCUPIED,
		DM_TIMING_REQUEST,
		DM_TIMING_ACK,
		Reserved4,
		Reserved5,
		Reserved6,
		Reserved7,
		DM_SETUP,
		DM_SETUP_PRES,
		DM_CONNECT,
		DM_DISCONNECT,
		DM_CONNECT_ACK,
		DM_OCCUPIED,
		DM_RELEASE,
		DM_TX_CEASED,
		DM_TX_REQUEST,
		DM_TX_ACCEPT,
		DM_PREEMPT,
		DM_PRE_ACCEPT,
		DM_REJECT,
		DM_INFO,
		DM_SDS_UDATA,
		DM_SDS_DATA,
		DM_SDS_ACK,
		Gateway_specific_messages,
		Reserved26,
		Reserved27,
		Reserved28,
		Reserved29,
		Proprietary30,
		Proprietary31,
		PDU_Error
	}
}