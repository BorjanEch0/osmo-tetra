using System;

namespace SDRSharp.Tetra
{
	public enum TransmissionGranted
	{
		Granted,
		Not_granted,
		Request_queued,
		Granted_to_another_user
	}
}