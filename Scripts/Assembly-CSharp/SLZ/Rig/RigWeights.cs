using System;

namespace SLZ.Rig
{
	[Serializable]
	public class RigWeights
	{
		public float head;

		public float eyeGaze;

		public float handLf;

		public float handRt;

		public float shoulderLf;

		public float shoulderRt;

		public float elbowLf;

		public float elbowRt;

		public float chest;

		public float pelvis;

		public float kneeLf;

		public float kneeRt;

		public float footLf;

		public float footRt;

		public float rootPosition;

		public float rootRotation;

		public static RigWeights one => null;

		public static RigWeights zero => null;
	}
}
