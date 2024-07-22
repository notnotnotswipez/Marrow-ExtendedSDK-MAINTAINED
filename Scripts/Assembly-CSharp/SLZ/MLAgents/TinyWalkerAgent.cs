using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Unity.MLAgentsExamples;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class TinyWalkerAgent : Agent
	{
		[Range(0.1f, 10f)]
		[SerializeField]
		[Header("Walk Speed")]
		private float m_TargetWalkingSpeed;

		public float newSpeed;

		public bool continuousSpeedChange;

		public float speedChangeProb;

		private const float m_maxWalkingSpeed = 10f;

		public bool randomizeWalkSpeedEachEpisode;

		private Vector3 m_WorldDirToWalk;

		[Header("Target To Walk Towards")]
		public Transform target;

		[Header("Body Parts")]
		public Transform hips;

		public Transform thighL;

		public Transform shinL;

		public Transform footL;

		public Transform thighR;

		public Transform shinR;

		public Transform footR;

		public bool l_thigh_x_rot_heur;

		public bool l_thigh_z_rot_heur;

		public bool r_thigh_x_rot_heur;

		public bool r_thigh_z_rot_heur;

		public bool l_shin_x_rot_heur;

		public bool r_shin_x_rot_heur;

		public bool r_foot_x_rot_heur;

		public bool r_foot_y_rot_heur;

		public bool r_foot_z_rot_heur;

		public bool l_foot_x_rot_heur;

		public bool l_foot_y_rot_heur;

		public bool l_foot_z_rot_heur;

		private OrientationCubeController m_OrientationCube;

		private DirectionIndicator m_DirectionIndicator;

		private JointDriveController m_JdController;

		private EnvironmentParameters m_ResetParams;

		public float MTargetWalkingSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void FixedUpdate()
		{
		}


		public void CollectObservationBodyPart(BodyPart bp, VectorSensor sensor)
		{
		}

		private void UpdateOrientationObjects()
		{
		}

		private Vector3 GetAvgVelocity()
		{
			return default(Vector3);
		}

		private void UpdateSpeedTarget()
		{
		}

		public float GetMatchingVelocityReward(Vector3 velocityGoal, Vector3 actualVelocity)
		{
			return 0f;
		}

		public void TouchedTarget()
		{
		}

		public void SetTorsoMass()
		{
		}

		public void SetResetParameters()
		{
		}
	}
}
