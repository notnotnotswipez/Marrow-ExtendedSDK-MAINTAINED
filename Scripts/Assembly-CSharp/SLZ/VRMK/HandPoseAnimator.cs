using SLZ.Data;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.VRMK
{
	public class HandPoseAnimator : MonoBehaviour
	{
		public Handedness handedness;

		[Range(0f, 2f)]
		public float radius;

		[Range(-90f, 90f)]
		public float pitch;

		[Range(-90f, 90f)]
		public float roll;

		[Range(-90f, 90f)]
		public float yaw;

		public HandPose defaultHandPose;

		private float _minThumb;

		private float _maxThumb;

		private float _minIndex;

		private float _maxIndex;

		private float _minMiddle;

		private float _maxMiddle;

		private float _minRing;

		private float _maxRing;

		private float _minPinky;

		private float _maxPinky;

		private float _currentThumb;

		private float _currentIndex;

		private float _currentMiddle;

		private float _currentRing;

		private float _currentPinky;

		private float[] overrides;

		private int _radMaxIndex;

		private int _radMinIndex;

		public Transform hand2Art;

		[FormerlySerializedAs("thumbArt")]
		public Transform thumb1;

		public Transform thumb2;

		public Transform thumb3;

		[FormerlySerializedAs("indexArt")]
		public Transform index1;

		public Transform index2;

		public Transform index3;

		[FormerlySerializedAs("middleArt")]
		public Transform middle1;

		public Transform middle2;

		public Transform middle3;

		[FormerlySerializedAs("ringArt")]
		public Transform ring1;

		public Transform ring2;

		public Transform ring3;

		[FormerlySerializedAs("pinkyArt")]
		public Transform pinky1;

		public Transform pinky2;

		public Transform pinky3;

		public Transform handle;

		private HandPose.PoseData _transitionCache;

		private HandPose.PoseData _currentPoseData;

		public HandPose pose;

		private HandPose _lastPose;

		private float _transitionFloat;

		private float _transitionTime;

		private float _lastRadius;

		private float _lastPitch;

		private float _lastRoll;

		private float _lastYaw;

		private float _radiusT;

		private Vector3[] _datapoints;

		private float[] _magCache;

		private Vector2[] _vec_ijCache;

		private HandPose.PoseData[] _dataArray;

		private HandPose.PoseData _openPose;

		private float _handSizeMult;

		private float _handSizeMultInv;

		private Vector3 _palmLfPosOffset;

		private Vector3 _palmRtPosOffset;

		private float[] weights;

		public bool hoverFingers;

		public bool debugCountSolveIterations;

		private const float kDirScale = 2f;

		public Quaternion WristOffset => default(Quaternion);

		private void Awake()
		{
		}

		public void Initialize()
		{
		}

		public void SetArtRefs(Animator animator)
		{
		}

		public void SetHandSize(Avatar avatar)
		{
		}

		public void SetDefaultHandPose()
		{
		}

		public void ForceBlend(float transitionTime = 0.1f)
		{
		}

		public SimpleTransform GetArtHandleInHand()
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetHandleInHand()
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetHandleInHandNeutral()
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetHandleInHandNeutral(HandPose sourcePose)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetHandInHandle()
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetHandInHandleNeutral()
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetHandInHandleNeutral(HandPose sourcePose)
		{
			return default(SimpleTransform);
		}

		public void SetFingers(float thumb, float index, float middle, float ring, float pinky)
		{
		}

		public void CurlOverride(float thumb = -1f, float index = -1f, float middle = -1f, float ring = -1f, float pinky = -1f)
		{
		}

		public void SetHandPose(HandPose newPose, float transitionTime = 0.1f)
		{
		}

		public void ApplyRotationAnimationBlend(Quaternion deltaRot)
		{
		}

		public void SolvePoseForHandle()
		{
		}

		public void SolvePose()
		{
		}

		private bool DetermineMinMax(float value, HandPose.PoseDataGroup[] radiusGroup, ref int min, ref int max, out float t)
		{
			t = default(float);
			return false;
		}

		private void RefreshRadius(float[] weights, float radiusT)
		{
		}

		private Vector3[] GenerateDataPoints(HandPose.PoseDataGroup dataGroup)
		{
			return null;
		}

		public void SetCylinderRadius(float newRadius)
		{
		}

		private bool CalculateWeights(Vector3 sample, Vector3[] nativePoints, ref float[] weights)
		{
			return false;
		}

		private bool CalculateWeightsPolar(Vector3 sample, Vector3[] nativePoints, float[] magCache, ref float[] weights)
		{
			return false;
		}

		private HandPose.PoseData BlendPose(HandPose.PoseData[] poseArray, float[] weights)
		{
			return default(HandPose.PoseData);
		}

		private Vector4 QuatTimesFloat(Quaternion q, float f, Vector4 dotCheck)
		{
			return default(Vector4);
		}

		private HandPose.PoseData LerpPose(HandPose.PoseData from, HandPose.PoseData to, float t, bool handleFullTo = false)
		{
			return default(HandPose.PoseData);
		}

		private HandPose.PoseData BlendOpenPose(HandPose.PoseData closed, HandPose.PoseData open)
		{
			return default(HandPose.PoseData);
		}

		public void ApplyPoseToTransforms()
		{
		}
	}
}
