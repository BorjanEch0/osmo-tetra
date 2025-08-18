using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SDRSharp.Tetra
{
	public class TetraSettings
	{
		public bool AfcEnabled
		{
			get;
			set;
		}

		public int AgcDecay
		{
			get;
			set;
		}

		public int AgcSlope
		{
			get;
			set;
		}

		public int AgcThresh
		{
			get;
			set;
		}

		public bool AlternativeCallListGeneration
		{
			get;
			set;
		}

		public bool AudioAGCEnabled
		{
			get;
			set;
		}

		public bool AutoPlay
		{
			get;
			set;
		}

		public bool BeepBfi
		{
			get;
			set;
		}

		public int BlockedLevel
		{
			get;
			set;
		}

		public bool BpfEnabled
		{
			get;
			set;
		}

		public int BpfLowCuttoff
		{
			get;
			set;
		}

		public bool DiagramUseSyncOnly
		{
			get;
			set;
		}

		public bool DmoMode
		{
			get;
			set;
		}

		public bool ElementVerbosity
		{
			get;
			set;
		}

		public bool EncryptedDetailsVc
		{
			get;
			set;
		}

		public string FileNameRules
		{
			get;
			set;
		}

		public int GssiDisplayType
		{
			get;
			set;
		}

		public bool IgnoreEncodedData
		{
			get;
			set;
		}

		public bool IgnoreEncodedSpeech
		{
			get;
			set;
		}

		public bool IsCc
		{
			get;
			set;
		}

		public bool LogEnabled
		{
			get;
			set;
		}

		public string LogEntryRules
		{
			get;
			set;
		}

		public string LogFileNameRules
		{
			get;
			set;
		}

		public bool LogMmRegistrations
		{
			get;
			set;
		}

		public string LogSeparator
		{
			get;
			set;
		}

		public string LogWriteFolder
		{
			get;
			set;
		}

		public List<GroupsEntries> NetworkBase
		{
			get;
			set;
		}

		public bool ShowEncryptedCallDetails
		{
			get;
			set;
		}

		public bool ShowSdsBinaryString
		{
			get;
			set;
		}

		public bool StrongerBusrtDetection
		{
			get;
			set;
		}

		public bool TopMostInfo
		{
			get;
			set;
		}

		public bool TttModeEnabled
		{
			get;
			set;
		}

		public int TttUdpPort
		{
			get;
			set;
		}

		public bool UseSpectrumLabel
		{
			get;
			set;
		}

		public TetraSettings()
		{
		}
	}
}