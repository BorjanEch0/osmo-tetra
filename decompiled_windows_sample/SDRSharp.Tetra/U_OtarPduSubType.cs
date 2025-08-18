using System;

namespace SDRSharp.Tetra
{
	public enum U_OtarPduSubType
	{
		CCK_Demand,
		CCK_Result,
		SCK_Demand,
		SCK_Result,
		GCK_Demand,
		GCK_Result,
		Key_associate_Status,
		OTAR_Prepare,
		GSKO_Demand,
		GSKO_Result,
		Key_delete_result,
		Key_status_response,
		CMG_GTSI_result,
		DM_SCK_Activate_Result,
		Reserved_14,
		Reserved_15
	}
}