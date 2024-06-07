using UnityEngine;

namespace SLZ.MLAgents
{
	[CreateAssetMenu(fileName = "VehicleContextConfig", menuName = "ContextConfigs/VehicleContextConfigs", order = 1)]
	public class VehicleContextConfig : ScriptableObject
	{
		[SerializeField]
		private float taskFloat;

		[SerializeField]
		private bool driveThrough;

		[SerializeField]
		private float preSpeedMin;

		[SerializeField]
		private float preSpeedMax;

		[SerializeField]
		private float inSpeedMin;

		[SerializeField]
		private float inSpeedMax;

		[SerializeField]
		private float goalRadius;

		[SerializeField]
		private float proxRadius;

		public float TaskFloat
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool DriveThrough
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float PreSpeedMin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float PreSpeedMax
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float InSpeedMin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float InSpeedMax
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float GoalRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ProxRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
