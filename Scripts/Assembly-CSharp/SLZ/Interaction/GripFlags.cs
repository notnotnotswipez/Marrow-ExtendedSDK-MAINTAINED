using System;

namespace SLZ.Interaction
{
	[Flags]
	public enum GripFlags
	{
		HOVER = 1,
		FARHOVER = 2,
		ATTACH = 4,
		PULLING = 8
	}
}
