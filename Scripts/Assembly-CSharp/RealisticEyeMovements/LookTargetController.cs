using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace RealisticEyeMovements
{
	public class LookTargetController : MonoBehaviour
	{
		private enum State
		{
			LookingAtPlayer = 0,
			LookingAroundIdly = 1,
			LookingAtPoiDirectly = 2,
			LookingAwayFromPlayer = 3
		}

		[Tooltip("Drag objects here for the actor to look at. If empty, actor will look in random directions.")]
		public Transform[] pointsOfInterest;

		[Tooltip("Ratio of how often to look at player vs elsewhere. 0: never, 1: always")]
		[Range(0f, 1f)]
		public float lookAtPlayerRatio;

		[Range(0f, 1f)]
		[Tooltip("How likely the actor is to look back at the player when player stares at actor.")]
		public float stareBackFactor;

		[Tooltip("If player is closer than this, notice him")]
		[Range(0f, 100f)]
		public float noticePlayerDistance;

		[Tooltip("If player is closer than this, look away (overrides noticing him)")]
		[Range(0f, 4f)]
		public float personalSpaceDistance;

		[Tooltip("Minimum time to look at a target")]
		[Range(1f, 100f)]
		public float minLookTime;

		[Tooltip("Maximum time to look at a target")]
		[Range(1f, 100f)]
		public float maxLookTime;

		[FormerlySerializedAs("playerEyeCenter")]
		[Tooltip("For 3rd person games, set this to the player's eye center transform")]
		public Transform thirdPersonPlayerEyeCenter;

		[Tooltip("Keep trying to track target even when it moves out of sight")]
		public bool keepTargetEvenWhenLost;

		[Header("Events")]
		public UnityEvent OnStartLookingAtPlayer;

		public UnityEvent OnStopLookingAtPlayer;

		public UnityEvent OnPlayerEntersPersonalSpace;

		public UnityEvent OnLookAwayFromShyness;

		private EyeAndHeadAnimator eyeAndHeadAnimator;

		private const float minLookAtMeTimeToReact = 4f;

		private Transform targetPOI;

		private Transform mainCameraXform;

		private Transform mainCameraParentXform;

		private Transform playerEyeCenterXform;

		private Transform playerLeftEyeXform;

		private Transform playerRightEyeXform;

		private Transform usedThirdPersonPlayerEyeCenter;

		private GameObject createdVRParentGO;

		private GameObject createdPlayerEyeCenterGO;

		private GameObject createdPlayerLeftEyeGO;

		private GameObject createdPlayerRightEyeGO;

		private float lastDistanceToPlayer;

		private float playerLookingAtMeTime;

		private float nextChangePOITime;

		private float stareBackDeadtime;

		private float timeOfLastNoticeCheck;

		private float timeOfLastLookBackCheck;

		private float timeOutsideOfAwarenessZone;

		private float timeInsidePersonalSpace;

		private bool useNativeVRSupport;

		private bool useVR;

		private bool isInitialized;

		private bool wasInPersonalSpaceLastFrame;

		private State state;

		private void Awake()
		{
		}

		public void Blink()
		{
		}

		private void ChangeStateTo(State newState)
		{
		}

		private Vector3 ChooseNextHeadTargetPoint()
		{
			return default(Vector3);
		}

		private Transform ChooseNextHeadTargetPOI()
		{
			return null;
		}

		public void ClearLookTarget()
		{
		}

		private Transform FindPlayerCamera()
		{
			return null;
		}

		public void Initialize(bool lookAroundIdly = true)
		{
		}

		public bool IsLookingAtPlayer()
		{
			return false;
		}

		public bool IsPlayerInView()
		{
			return false;
		}

		public void LookAtPlayerSimple()
		{
		}

		public void LookAtPlayer(float duration = -1f, float headLatency = 0.075f)
		{
		}

		public void LookAroundIdly()
		{
		}

		public void LookAtPoiDirectly(Transform poiXform, float duration = -1f, float headLatency = 0.075f)
		{
		}

		public void LookAtPoiDirectly(Vector3 poi, float duration = -1f, float headLatency = 0.075f)
		{
		}

		private void LookAwayFromPlayer()
		{
		}

		private void OnCannotGetTargetIntoView()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnPlayerEyesParentDestroyed(DestroyNotifier destroyNotifier)
		{
		}

		private void OnTargetDestroyed()
		{
		}

		private void OnTargetLost()
		{
		}

		private void OnTargetOutOfSight()
		{
		}

		private void Start()
		{
		}

		private void UpdateNativeVREyePositions()
		{
		}

		private void UpdatePlayerEyeTransformReferences()
		{
		}

		private void VeryLateUpdate()
		{
		}
	}
}
