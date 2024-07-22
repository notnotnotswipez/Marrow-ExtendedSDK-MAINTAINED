using PuppetMasta;
using SLZ.Marrow.Mechanics;
using SLZ.Marrow.PuppetMasta;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;
using UnityEngine.AI;

namespace SLZ.MLAgents
{
	public class MuscleTrainer_Deltas : Agent
	{
		public GameObject locoPoint;

		private bool walking_bool;

		public bool debug_loss;

		public bool debug_gizmos;

		public bool override_curve;

		public bool set_bkm;

		public bool collect_running_mean;

		public MuscleCurvePersist bkm_curve;

		private float running_total;

		private float area_under_curve;

		private float running_mean;

		private int total_iterations;

		public float episodeTime;

		[SerializeField]
		private float currentEpTime;

		[SerializeField]
		private int nb_fixed_calls;

		public float moveCooldown;

		public float currentMoveTime;

		public GameObject NullBody;

		public LiteLoco loco;

		public BehaviourPowerLegs powerLegs;

		public NavMeshAgent navAgent;

		public PuppetMaster puppetMaster;

		public GameObject ai_root;

		public GameObject joint_root;

		public Rigidbody joint_rb;

		public GameObject ai_hip_L;

		public GameObject ai_hip_R;

		public GameObject ai_foot_L;

		public GameObject ai_foot_R;

		public GameObject joint_hip_L;

		public GameObject joint_hip_R;

		public GameObject joint_foot_L;

		public GameObject joint_foot_R;

		public float error_coef;

		private float delta_loss;

		private float avg_delta_loss;

		private AnimationCurve muscleCurve;

		private LiteLoco.StepGroup stepGroup;

		private int current_gear;

		public float anim_curve_x_max;

		public float anim_curve_x_min;

		public float angle_dif_max;

		public float anim_curve_y_max;

		public float anim_curve_y_min;

		private int nb_key_inds;

		public float roam_speed;

		public float roam_freq;

		public bool roam_wanders;

		public float max_slerp_drive;

		private AnimationCurve og_curve;

		private EnvironmentParameters m_EnvParams;

		[SerializeField]
		private AnimationCurve best_curve;

		[SerializeField]
		private MuscleCurvePersist persist_curve;

		private float best_curve_loss;

		private bool is_first_ep;

		private float root_delta;

		private float root_delta_avg;

		private float hipL_delta;

		private float hipR_delta;

		private float hipL_delta_avg;

		private float hipR_delta_avg;

		private float delta_sum;

		private float delta_avg;

		private float leg_angle_sum;

		private float leg_angle_avg;

		private float foot_angle_sum;

		private float foot_angle_avg;

		private float foot_position_sum;

		private float foot_position_avg;

		private float combined_loss;

		private Vector3 ai_hip_foot_vec_L;

		private Vector3 ai_hip_foot_vec_R;

		private Vector3 joint_hip_foot_vec_L;

		private Vector3 joint_hip_foot_vec_R;

		private float left_leg_angle;

		private float left_leg_angle_avg;

		private float right_leg_angle;

		private float right_leg_angle_avg;

		private float left_joint_foot_angle;

		private float left_ai_foot_angle;

		private float right_joint_foot_angle;

		private float right_ai_foot_angle;

		private float left_foot_delta;

		private float right_foot_delta;

		private float left_foot_delta_avg;

		private float right_foot_delta_avg;

		private float left_foot_angle_delta;

		private float right_foot_angle_delta;

		private float left_foot_angle_avg;

		private float right_foot_angle_avg;

		private float[] previous_maxforces;

		public void Start()
		{
		}

		public void FixedUpdate()
		{
		}

		private void OnDrawGizmos()
		{
		}
		private void SetEnvParams()
		{
		}

		private float AnimationCurveAUC(AnimationCurve curve)
		{
			return 0f;
		}
		private void ResetAvgLosses()
		{
		}

		private void AverageLosses()
		{
		}

		private void AccumulateDelta()
		{
		}

		private void HandleTimeout()
		{
		}

		private void HandleFall()
		{
		}

		private void RandomWalkingHandler()
		{
		}

		private void WalkToPointHandler()
		{
		}

		private void HandlePuppetState()
		{
		}

		private void HandleGearShift()
		{
		}

		private void RandomizeAnimationCurve(ref AnimationCurve animCurve, float nb_inds)
		{
		}

		private void ZeroAnimationCurve(ref AnimationCurve animCurve, float nb_inds)
		{
		}
	}
}
