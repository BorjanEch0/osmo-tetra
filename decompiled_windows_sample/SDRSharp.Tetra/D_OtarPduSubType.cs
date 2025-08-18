using System;

namespace SDRSharp.Tetra
{
	public enum D_OtarPduSubType
	{
		CCK_Provide,
		CCK_Reject,
		SCK_Provide,
		SCK_Reject,
		GCK_Provide,
		GCK_Reject,
		Key_associate_Demand,
		OTAR_NEWCELL,
		GSKO_Provide,
		GSKO_Reject,
		Key_delete_demand,
		Key_status_demand,
		CMG_GTSI_provide,
		DM_SCK_Activate,
		Reserved_14,
		Reserved_15
	}
}