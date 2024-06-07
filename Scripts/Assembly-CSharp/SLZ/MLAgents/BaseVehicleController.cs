using Unity.MLAgents;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BaseVehicleController : MonoBehaviour
	{
		[Header("Component Section")]
		[Tooltip("The vehicle the controller is connected to")]
		public BaseVehicle vehicle;

		[Tooltip("The sensor to pull values from for certain reward calculations")]
		public BaseVehicleSensors sensors;

		[Tooltip("Util class that has extra functions used in control and reward calculation")]
		private BaseVehicleUtils vehicleUtils;

		[Header("Reward Bools")]
		[Tooltip("General Suffering Penalty to incentivise doing anything")]
		public bool use_passive_penalty;

		[Tooltip("TaskObjective Velocity Reward")]
		public bool use_velocity;

		[Tooltip("Valocity value sent for reward is literally the magnitude")]
		public bool use_simple_velocity;

		[Tooltip("Penalty on generic collision enter")]
		public bool use_collision_enter;

		[Tooltip("Penalty on generic collision stay")]
		public bool use_collision_stay;

		[Tooltip("Penalty for jerking the wheel (hasnt been fully tested/implemented)")]
		public bool use_jerk;

		[Tooltip("Penalty for not being first to finish the final race")]
		public bool use_countdown;

		[Tooltip("Penalty for timing out on objective")]
		public bool use_timeout;

		[Tooltip("Penalty for falling off the map")]
		public bool use_falling_penalty;

		[Tooltip("Reward for forward pointing towards current objective")]
		public bool use_facing_direction;

		[Tooltip("Reward for bing inside objective volume")]
		public bool use_invol;

		[Tooltip("Penalty for never starting an attempt")]
		public bool use_attempt_penalty;

		[Header("Reward Value/Coef Section")]
		public float passivePenaltVal;

		[Tooltip("What percentage of velocity to use for reward")]
		public float velocity_reward_coef;

		[Tooltip("Discount value on velocity based rewards for whatever conditions")]
		public float velocity_discount;

		[Tooltip("Reward scaling for being in or driving through objective volume")]
		public float throughStayMod;

		[Tooltip("Reward scaling volume based rewards")]
		public float volMod;

		[Tooltip("Reward scaling for making an attempt or not")]
		public float attemptMod;

		[Tooltip("Reward for forward pointing towards current objective")]
		public float facingMod;

		[Tooltip("Penalty for jerking the wheel (hasnt been fully tested/implemented)")]
		public float jerkCoef;

		[Tooltip("Penalty on generic collision enter")]
		public float collisionPenalty;

		[Tooltip("Penalty mod for generic collision enter")]
		public float collisionPenaltyMod;

		[Tooltip("Penalty on generic collision stay")]
		public float collisionStayPenalty;

		[Tooltip("Penalty mod for generic collision enter")]
		public float collisionStayPenaltyMod;

		[Tooltip("End agent episode when it collides into anything")]
		public bool endEpOnCollide;

		[Tooltip("Penalty for falling off the map")]
		public float fallingPenalty;

		[Tooltip("Penalty for not being first to finish the final race")]
		public float count_down_penalty;

		[Tooltip("End agent episode when it falls of track")]
		public bool endEpOnFall;

		[Header("Handling Section")]
		public bool discreteControl;

		public bool lerpSteering;

		public float steerInput;

		[Header("Status Switches")]
		private bool hasTimedOut;

		public bool hasFallen;

		public bool handleCurrentFall;

		public string collisionString;

		public bool logRewards;

		[HideInInspector]
		public EnvironmentParameters envParams;

		public void RegisterCollisionEvents()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public float RewardLoop()
		{
			return 0f;
		}

		private float OutOfVolumePenalty()
		{
			return 0f;
		}

		private float AttemptPenalty()
		{
			return 0f;
		}

		private float NotMovingPenalty()
		{
			return 0f;
		}

		private float FallenPenalty()
		{
			return 0f;
		}

		public float FacingDirectionReward()
		{
			return 0f;
		}

		public float FallingPenalty()
		{
			return 0f;
		}

		public float PassivePenalty()
		{
			return 0f;
		}

		public float CountdownPenalty()
		{
			return 0f;
		}

		public float ObjectiveLosses()
		{
			return 0f;
		}

		public float VelocityLosses()
		{
			return 0f;
		}

		public float ThroughStayCheck()
		{
			return 0f;
		}

		public float RadiusLoss()
		{
			return 0f;
		}

		public float ProximityVolumeLoss()
		{
			return 0f;
		}

		public float JerkReward()
		{
			return 0f;
		}

		public float CollisionEnterReward()
		{
			return 0f;
		}

		public float CollisionStayReward()
		{
			return 0f;
		}

		public void Timeout()
		{
		}

		public float TimeoutReward()
		{
			return 0f;
		}

		public virtual void CollisionEnter(string goString)
		{
		}

		public virtual void CollisionStay(string goString)
		{
		}

		public virtual void CollisionExit(string goString)
		{
		}

		public void Fallen()
		{
		}

		public void Drive(float motorInput, float steerInput, int handBrake)
		{
		}

		public void Drive(float motorInput, float steerInput, float handBrake)
		{
		}
	}
}
