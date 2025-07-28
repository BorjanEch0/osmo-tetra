#include <stdint.h>
#include <stdio.h>
#include <unistd.h>
#include <string.h>

#include <osmocom/core/msgb.h>
#include <osmocom/core/talloc.h>
#include <osmocom/core/bits.h>

#include "tetra_mle_pdu.h"
#include "tetra_mle.h"
#include "tetra_mm_pdu.h"
#include "tetra_cmce_pdu.h"
#include "tetra_sndcp_pdu.h"
#include "tetra_mle_pdu.h"
#include "tetra_common.h"
#include "tetra_gsmtap.h"



/* Receive TL-SDU (LLC SDU == MLE PDU) */
int rx_tl_sdu(struct tetra_mac_state *tms, struct msgb *msg, unsigned int len)
{
	uint8_t *bits = msg->l3h;
	uint8_t mle_pdisc = bits_to_uint(bits, 3);

	printf("TL-SDU(%s): %s ", tetra_get_mle_pdisc_name(mle_pdisc),
		osmo_ubit_dump(bits, len));
       switch (mle_pdisc) {
       case TMLE_PDISC_MM:
       {
               uint8_t mm_pdut = bits_to_uint(bits+3, 4);
               printf("%s\n", tetra_get_mm_pdut_name(mm_pdut, 0));

               if (mm_pdut == TMM_PDU_T_D_AUTH) {
                       enum tetra_log_chan lchan;
                       struct msgb *gsmtap_msg;

                       lchan = tms->cur_burst.is_traffic ? TETRA_LC_TCH : TETRA_LC_STCH;
                       gsmtap_msg = tetra_gsmtap_makemsg(&t_phy_state.time, lchan,
                                                       tms->tsn - 1, 0, 0, 0,
                                                       bits, len, tms);
                       if (gsmtap_msg)
                               tetra_gsmtap_sendmsg(gsmtap_msg);
               }
               break;
       }
	case TMLE_PDISC_CMCE:
		printf("%s\n", tetra_get_cmce_pdut_name(bits_to_uint(bits+3, 5), 0));
		break;
	case TMLE_PDISC_SNDCP:
		printf("%s ", tetra_get_sndcp_pdut_name(bits_to_uint(bits+3, 4), 0));
		printf(" NSAPI=%u PCOMP=%u, DCOMP=%u",
			bits_to_uint(bits+3+4, 4),
			bits_to_uint(bits+3+4+4, 4),
			bits_to_uint(bits+3+4+4+4, 4));
		printf(" V%u, IHL=%u",
			bits_to_uint(bits+3+4+4+4+4, 4),
			4*bits_to_uint(bits+3+4+4+4+4+4, 4));
		printf(" Proto=%u\n",
			bits_to_uint(bits+3+4+4+4+4+4+4+64, 8));
		break;
	case TMLE_PDISC_MLE:
		printf("%s\n", tetra_get_mle_pdut_name(bits_to_uint(bits+3, 3), 0));
		break;
	default:
		break;
	}
	return len;
}
