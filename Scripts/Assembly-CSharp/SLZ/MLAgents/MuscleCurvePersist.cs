using UnityEngine;

namespace SLZ.MLAgents
{
	[CreateAssetMenu(fileName = "MuscleCurvePersist", menuName = "MuscleCurves/LearnedCurves", order = 1)]
	public class MuscleCurvePersist : ScriptableObject
	{
		[SerializeField]
		private AnimationCurve curve;

		[SerializeField]
		private float hipL_drive_strength;

		[SerializeField]
		private float hipR_drive_strength;

		[SerializeField]
		private float kneeL_drive_strength;

		[SerializeField]
		private float kneeR_drive_strength;

		[SerializeField]
		private float ankleL_drive_strength;

		[SerializeField]
		private float ankleR_drive_strength;

		public float HipL_Drive_Strength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float HipR_Drive_Strength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float KneeL_Drive_Strength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float KneeR_Drive_Strength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AnkleL_Drive_Strength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AnkleR_Drive_Strength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimationCurve Curve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
