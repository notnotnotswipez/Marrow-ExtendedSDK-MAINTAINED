using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ArticulatedArmController : MonoBehaviour
	{
		public HandPoseAnimator handAnimator;

		public Transform scapulaLf;

		public Transform shoulderLf;

		public Transform elbowLf;

		public Transform wristLf;

		public Transform carpalLf;

		public Transform handLf;

		public Transform twistUpLf;

		public Transform twistLowLf;

		public Transform targetHand;

		[Tooltip("Maximum factor the arms can be stretched by. Default 1.05")]
		[Range(1.001f, 3f)]
		public float maxStretchFactor;

		[Tooltip("Percentage of arm length where stretching starts. Default 0.8")]
		[Range(0f, 1f)]
		public float stretchThreshold;

		[Range(1f, 4f)]
		[Tooltip("Ratio of hyperextention to resulting arm length. Default 2")]
		public float stretchRatio;

		private float _oldMaxStretchFactor;

		private float _oldStretchThreshold;

		private float _oldStretchRatio;

		public AnimationCurve ArmStretchCurve;

		public AnimationCurve WristElbowIsNotCurve;

		[Range(0f, 1f)]
		[Header("HandAnimator")]
		public float thumb;

		[Range(0f, 1f)]
		public float index;

		[Range(0f, 1f)]
		public float middle;

		[Range(0f, 1f)]
		public float ring;

		[Range(0f, 1f)]
		public float pinky;

		public ConfigurableJoint thumb1;

		public ConfigurableJoint thumb2;

		public ConfigurableJoint thumb3;

		public ConfigurableJoint index1;

		public ConfigurableJoint index2;

		public ConfigurableJoint index3;

		public ConfigurableJoint middle1;

		public ConfigurableJoint middle2;

		public ConfigurableJoint middle3;

		public ConfigurableJoint ring1;

		public ConfigurableJoint ring2;

		public ConfigurableJoint ring3;

		public ConfigurableJoint pinky1;

		public ConfigurableJoint pinky2;

		public ConfigurableJoint pinky3;

		private Vector3 _leftHandVector3;

		private float _upperArmLength;

		private float _forearmLength;

		private float _carpalLength;

		private float _handTwistLf;

		private float _wristRelaxLerpLf;

		private Quaternion _neutHumLf;

		private Quaternion _initialThumb1;

		private Quaternion _initialThumb2;

		private Quaternion _initialThumb3;

		private Quaternion _initialIndex1;

		private Quaternion _initialIndex2;

		private Quaternion _initialIndex3;

		private Quaternion _initialMiddle1;

		private Quaternion _initialMiddle2;

		private Quaternion _initialMiddle3;

		private Quaternion _initialRing1;

		private Quaternion _initialRing2;

		private Quaternion _initialRing3;

		private Quaternion _initialPinky1;

		private Quaternion _initialPinky2;

		private Quaternion _initialPinky3;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void SolveArm()
		{
		}

		private void LimbStretch(float limbMag, float upperLength, float lowerLength, AnimationCurve stretchCurve, float stretchThreshold, out float newLimbMag, out float newUpperLength, out float newLowerLength)
		{
			newLimbMag = default(float);
			newUpperLength = default(float);
			newLowerLength = default(float);
		}

		private void LimbStretch2(float limbMag, float upperLength, float lowerLength, AnimationCurve stretchCurve, float stretchThreshold, out float newLimbMag, out float newUpperLength, out float newLowerLength)
		{
			newLimbMag = default(float);
			newUpperLength = default(float);
			newLowerLength = default(float);
		}

		private void WristRelax()
		{
		}

		public float ElbowIsNot(Vector3 neutralGh, float twistFloat, out float newTwistFloat)
		{
			newTwistFloat = default(float);
			return 0f;
		}

		private void CarpalHand(Transform wrist, Transform carpal, Transform hand, Quaternion targetRot, float segmentLength)
		{
		}

		private void CalibrateArmStretch()
		{
		}

		private void SolveHandPose()
		{
		}
	}
}
