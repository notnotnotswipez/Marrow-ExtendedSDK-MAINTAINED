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
	public class MuscleTrainer : Agent
	{
		public GameObject locoPoint;

		private bool walking_bool;

		public bool debug_loss;

		public bool override_curve;

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

		private float root_delta;

		private float avg_root_delta;

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

		private AnimationCurve og_curve;

		private EnvironmentParameters m_EnvParams;

		[SerializeField]
		private AnimationCurve best_curve;

		private float best_curve_loss;

		public void Start()
		{
		}

		public void FixedUpdate()
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


		private void SetEnvParams()
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
