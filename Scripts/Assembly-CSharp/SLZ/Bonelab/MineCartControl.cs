using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Playables;

namespace SLZ.Bonelab
{
	public class MineCartControl : MonoBehaviour
	{
		public enum RideSpeed
		{
			Off = 0,
			Station = 1,
			Lift = 2,
			Coast = 3,
			Brake = 4,
			Boost = 5,
			SuperBoost = 6,
			MatchSpeed1 = 7,
			MatchSpeed2 = 8
		}

		[Tooltip("timeline playable director goes here")]
		[SerializeField]
		private PlayableDirector director;

		[Tooltip("spline body script goes here")]
		public SplineBody splineBody;

		public RideSpeed rideSpeed;

		[InspectorDisplayName("Target Velocity")]
		[Header("Off  -  0")]
		public float velocity_off;

		[InspectorDisplayName("Position Damper")]
		public float damper_off;

		[InspectorDisplayName("Maximum Force")]
		public float force_off;

		[Header("Station  -  1")]
		[InspectorDisplayName("Target Velocity")]
		public float velocity_station;

		[InspectorDisplayName("Position Damper")]
		public float damper_station;

		[InspectorDisplayName("Maximum Force")]
		public float force_station;

		[InspectorDisplayName("Target Velocity")]
		[Header("Lift Hill  -  2")]
		public float velocity_lift;

		[InspectorDisplayName("Position Damper")]
		public float damper_lift;

		[InspectorDisplayName("Maximum Force")]
		public float force_lift;

		[Header("Coast  -  3")]
		[InspectorDisplayName("Target Velocity")]
		public float velocity_coast;

		[InspectorDisplayName("Position Damper")]
		public float damper_coast;

		[InspectorDisplayName("Maximum Force")]
		public float force_coast;

		[InspectorDisplayName("Target Velocity")]
		[Header("Brake  -  4")]
		public float velocity_brake;

		[InspectorDisplayName("Position Damper")]
		public float damper_brake;

		[InspectorDisplayName("Maximum Force")]
		public float force_brake;

		[Header("Boost  -  5")]
		[InspectorDisplayName("Target Velocity")]
		public float velocity_boost;

		[InspectorDisplayName("Position Damper")]
		public float damper_boost;

		[InspectorDisplayName("Maximum Force")]
		public float force_boost;

		[Header("Super Boost  -  6")]
		[InspectorDisplayName("Target Velocity")]
		public float velocity_sboost;

		[InspectorDisplayName("Position Damper")]
		public float damper_sboost;

		[InspectorDisplayName("Maximum Force")]
		public float force_sboost;

		[Header("Match Speed 1  -  7")]
		[InspectorDisplayName("Target Velocity")]
		public float velocity_mspeed1;

		[InspectorDisplayName("Position Damper")]
		public float damper_mspeed1;

		[InspectorDisplayName("Maximum Force")]
		public float force_mspeed1;

		[Header("Match Speed 2  -  8")]
		[InspectorDisplayName("Target Velocity")]
		public float velocity_mspeed2;

		[InspectorDisplayName("Position Damper")]
		public float damper_mspeed2;

		[InspectorDisplayName("Maximum Force")]
		public float force_mspeed2;

		private float velocity_current;

		private float damper_current;

		private float force_current;

		private bool hasShot;

		private bool hasShot2;

		public void UpdateSpeedOneShot(int oneShotSpeed)
		{
		}

		public void UpdateSpeedOneShot2(int oneShotSpeed2)
		{
		}

		public void UpdateSpeed(int rs)
		{
		}
	}
}
