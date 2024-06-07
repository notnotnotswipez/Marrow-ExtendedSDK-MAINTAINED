using SLZ.Interaction;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DevManipulatorGun : MonoBehaviour
	{
		public ConfigurableJoint slingBallJoint;

		public Grip triggerGrip;

		public Grip ballGrip;

		public InteractableHost host;

		[SerializeField]
		[Header("AudioExtra")]
		private AudioClip _blastPistonOut;

		[SerializeField]
		private AudioClip _blastPistonIn;

		[Header("References")]
		public Transform slingSpringGroup;

		public GameObject ballArt;

		public GameObject ballArtLines;

		public Transform firePoint;

		public GravityManipulatorJob gravityManipulator;

		public GameObject blastVFXObject;

		public Transform fanBladesTransform;

		public LineRenderer slingFXLine;

		public PrismaticSFX ballPrismatic;

		public GameObject fxGroup;

		public Transform _ballLocalStartTrans;

		[Header("Settings")]
		public float kickForce;

		public float slingDisplacementThresholdHigh;

		public float slingDisplacementThresholdLow;

		public float slingFXLineNear;

		public float slingFXLineFar;

		public float slingFXLineMin;

		private Rigidbody m_GrabbedRigidbody;

		private Animator animator;

		private GravGunSFX sfx;

		private bool m_IsPulling;

		private bool m_IsGrabbed;

		private HandJointConfiguration _handJointConfiguration;

		private SimpleTransform _initalSphereBallTransform;

		private bool _isBlast;

		private bool _wasBlast;

		private float _blastPistonFloat;

		private Quaternion _jointStartRotation;

		private Quaternion _ballGrabStartRotation;

		private float _ballGrabStartPosition;

		private float _fanRPS;

		private float _blastPistonCooldown;

		private ManagedAudioPlayer _mapBlastPiston;

		private float _initialDistanceDelta;

		private float _disOffVel;

		private bool _captureInitialDelta;

		private Hand heldHand;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetFanRPM(float rpm)
		{
		}

		private void OnTriggerGripUpdate()
		{
		}

		private void Blast()
		{
		}

		private void UpdateBlastPiston()
		{
		}

		private void OnBallGripUpdate(Hand hand)
		{
		}

		private void OnBallGripAttached(Hand hand)
		{
		}

		private void OnBallGripDetached(Hand hand)
		{
		}

		private void OnTriggerGripAttached(Hand hand)
		{
		}

		private void OnTriggerGripDetached(Hand hand)
		{
		}

		private void ResetSlingBall()
		{
		}

		private void DisableSlingBall()
		{
		}

		private void EnableSlingBall()
		{
		}
	}
}
