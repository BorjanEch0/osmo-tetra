using System;

namespace SDRSharp.Tetra
{
	public enum LLCPduType
	{
		BL_ADATA,
		BL_DATA,
		BL_UDATA,
		BL_ACK,
		BL_ADATA_FCS,
		BL_DATA_FCS,
		BL_UDATA_FCS,
		BL_ACK_FCS,
		AL_SETUP,
		AL_DATA_AR_FINAL,
		AL_UDATA_UFINAL,
		AL_ACK_RNR,
		AL_RECONNECT,
		Supplementary_LLC_PDU,
		Layer_2_signalling_PDU,
		AL_DISC
	}
}