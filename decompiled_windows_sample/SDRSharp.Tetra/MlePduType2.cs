using System;

namespace SDRSharp.Tetra
{
	public enum MlePduType
	{
		D_NEW_CELL,
		D_PREPARE_FAIL,
		D_NWRK_BROADCAST,
		D_NWRK_BROADCAST_EXTENSION,
		D_RESTORE_ACK,
		D_RESTORE_FAIL,
		D_CHANNEL_RESPONSE,
		Extended_PDU
	}
}