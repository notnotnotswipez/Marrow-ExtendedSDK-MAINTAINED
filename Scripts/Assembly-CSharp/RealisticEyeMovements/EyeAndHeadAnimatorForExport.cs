using System;

namespace RealisticEyeMovements
{
	[Serializable]
	public class EyeAndHeadAnimatorForExport
	{
		public string headBonePath;

		public float headSpeedModifier;

		public float headWeight;

		public bool useMicroSaccades;

		public bool useMacroSaccades;

		public bool kDrawSightlinesInEditor;

		public ControlData.ControlDataForExport controlData;

		public float kMinNextBlinkTime;

		public float kMaxNextBlinkTime;

		public bool eyelidsFollowEyesVertically;

		public float maxEyeHorizAngle;

		public float maxEyeHorizAngleTowardsNose;

		public float crossEyeCorrection;

		public float nervousness;

		public float limitHeadAngle;
	}
}
