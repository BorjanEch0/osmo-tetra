#include <stdint.h>
#include <stdio.h>
#include <unistd.h>
#include <string.h>

#include <osmocom/core/msgb.h>
#include <osmocom/core/talloc.h>
#include <osmocom/core/bits.h>
#include <osmocom/core/utils.h>

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
        case TMLE_PDISC_MM: {
                uint8_t pdut = bits_to_uint(bits+3, 4);
                printf("%s\n", tetra_get_mm_pdut_name(pdut, 0));
               if (pdut == TMM_PDU_T_D_AUTH) {
                        struct msgb *gsmtap_msg;
                        struct tetra_tdma_time tm = t_phy_state.time;
                        uint8_t auth_sub_type;
                        uint8_t rand1[10];
                        uint8_t ra[10];

                        const uint8_t *cur = bits + 3 + 4; /* skip PDISC and PDU type */

                        auth_sub_type = bits_to_uint(cur, 2);
                        cur += 2;

                        for (int i = 0; i < 10; i++) {
                                rand1[i] = bits_to_uint(cur, 8);
                                cur += 8;
                        }
                        for (int i = 0; i < 10; i++) {
                                ra[i] = bits_to_uint(cur, 8);
                                cur += 8;
                        }

                        printf(" RAND1=%s RA=%s\n", osmo_hexdump(rand1, sizeof(rand1)),
                               osmo_hexdump(ra, sizeof(ra)));


                        /* Provide a timestamp close to the burst that carried
                         * the last fragment and ensure the timeslot is in the
                         * expected 0..3 range for GSMTAP. */
                        gsmtap_msg = tetra_gsmtap_makemsg(&tm, TETRA_LC_STCH,
                                                         tms->tsn - 1, 0,
                                                         0, 0, bits, len, tms);
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
