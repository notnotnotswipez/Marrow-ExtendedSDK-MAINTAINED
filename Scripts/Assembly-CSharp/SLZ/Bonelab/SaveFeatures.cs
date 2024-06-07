using System;

namespace SLZ.Bonelab
{
	[Serializable]
	[Flags]
	public enum SaveFeatures
	{
		Completion = 1,
		PartialProgress = 2,
		Ammo = 4,
		Inventory = 8,
		Everything = 0xF
	}
}
