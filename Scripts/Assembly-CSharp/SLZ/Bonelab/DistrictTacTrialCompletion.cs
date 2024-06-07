using System;

namespace SLZ.Bonelab
{
	[Obsolete("Replace with a LevelCompletion instance with the LevelKey set")]
	public class DistrictTacTrialCompletion : LevelCompletion
	{
		protected override string LevelKey => null;
	}
}
