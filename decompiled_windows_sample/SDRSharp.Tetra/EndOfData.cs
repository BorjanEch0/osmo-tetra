using System;

namespace SDRSharp.Tetra
{
	public enum EndOfData
	{
		NullPDU,
		FragStart,
		FragEnd,
		Unknow,
		NoMoreData,
		NeedFix
	}
}