using SLZ.Marrow.PuppetMasta;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Unity.MLAgentsExamples;
using UnityEngine;

namespace SLZ.MLAgents
{
	[RequireComponent(typeof(BehaviourDriveController))]
	public class BehaviourArmWormAgent_SlicedTrainer : Agent
	{
		public BehaviourArmWorm behaviour;

		public PuppetMaster puppetMaster;

		public StatsRecorder statsRecorder;

		private EnvironmentParameters m_EnvParams;

		public bool use_upsidedown_penalty;

		public float jumpRewardOnly;

		public bool inference_switch;

		public GameObject arm_parent;

		public GameObject training_area;

		public float m_MaxWalkingSpeed;

		private ImpactTargetController target_controller;

		[Header("Target Prefabs")]
		public Transform TargetPrefab;

		private Transform m_Target;

		[SerializeField]
		private float goal_height;

		[SerializeField]
		private float goal_impact;

		[SerializeField]
		private float target_move_speed;

		[SerializeField]
		private float target_move_radius;

		[SerializeField]
		private float target_scale;

		[SerializeField]
		private float target_spawn_radius;

		[Header("Body Parts")]
		public Transform bodySegment0;

		public Transform bodySegment1;

		public Transform bodySegment2;

		public BoxCollider frictionCollider;

		public PhysicMaterial high_friction;

		public PhysicMaterial low_friction;

		public float jump_cd_time;

		public float jump_cd_max;

		private bool jump_cooldown;

		public OrientationCubeController m_OrientationCube;

		public GameObject forward_reference;

		private DirectionIndicator m_DirectionIndicator;

		public BehaviourDriveController m_JdController;

		private Vector3 m_StartingPos;

		public bool shoulder_rotation;

		public float shoulder_rotation_value;

		public float shoulder_rot_lerp_scale;

		public bool elbow_x_rot_heur;

		public bool wrist_x_rot_heur;

		public bool wrist_y_rot_heur;

		public bool wrist_z_rot_heur;

		public bool friction_switch;

		public int nb_updates;

		private int current_updates;

		private bool observation_ready;

		private ActionBuffers delayed_buffers;

		private int sensor_counter;

		public bool log_cum_reward;

		private Vector3 ref_vel;

		private Vector3 previous_loc;

		private Vector3 parent_previous_loc;

		private Vector3 avg_joint_pos;

		private Vector3 prev_avg_joint_pos;

		private Vector3 avg_joint_vel;

		private bool upsidedown;

		public float spawnRadiusPercent;

		public float areaXZMax;

		public float areaXZMin;

		public float areaYMax;

		public float areaYMin;

		private void OnDrawGizmos()
		{
		}

		private void Awake()
		{
		}

		private void UpdateOrientationObjects()
		{
		}

		private void SetTargetProperties()
		{
		}

		private void SetPosition()
		{
		}


		private void SpawnTarget(Transform prefab, Vector3 pos)
		{
		}


		public void CollectObservationBodyPart(ArtBodyPart bp, VectorSensor sensor)
		{
		}


		public float GetMatchingVelocityReward(Vector3 velocityGoal, Vector3 actualVelocity)
		{
			return 0f;
		}

		public void TouchedTarget(float impact_force)
		{
		}

		private void ArmJump()
		{
		}

		private void QueueDelayedAction(ActionBuffers actionBuffers)
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
