using System;
using SLZ.Marrow.Data;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourHandPose : SubBehaviourBase
	{
		public enum HandPose
		{
			Fist = 0,
			LooseFist = 1,
			RelaxedOpen = 2,
			WideOpen = 3,
			ThumbsUp = 4,
			IndexPoint = 5,
			FingerGun = 6,
			MiddleFinger = 7,
			Custom = 8
		}

		private struct LocalPoseData
		{
			public Quaternion hand2;

			public Vector3 handleInHandPos;

			public Quaternion handleInHandRot;

			public Quaternion thumb1;

			public Vector3 thumb23;

			public Quaternion index1;

			public Vector3 index23;

			public Quaternion middle1;

			public Vector3 middle23;

			public Quaternion ring1;

			public Vector3 ring23;

			public Quaternion pinky1;

			public Vector3 pinky23;
		}

		public float updateFps;

		public HandPoseData OpenHand;

		public HandPoseData Fist;

		public HandPoseData Pistol;

		public HandPoseData PistolOffhand;

		public Transform[] leftHandRefs;

		public Transform[] rightHandRefs;

		private HandPose _leftPose;

		private HandPose _rightPose;

		private LocalPoseData _leftCurrent;

		private LocalPoseData _rightCurrent;

		private LocalPoseData _leftSnapshot;

		private LocalPoseData _rightSnapshot;

		private LocalPoseData _leftTarget;

		private LocalPoseData _rightTarget;

		private float _updateSeconds;

		private float _deltaTime;

		private float _blendingWeightLeft;

		private float _blendingWeightRight;

		private float _deltaMultLeft;

		private float _deltaMultRight;

		private float[] _fingerCurls;

		public void Initiate(BehaviourBase b)
		{
		}

		private void CopyPoseData(HandPoseData data, ref LocalPoseData destination)
		{
		}

		public void SetTargetPose(HandPoseData targetPose, int handIndex, float blendTime = 0.25f)
		{
		}

		public void SetHandPose(HandPose targetPose, int handIndex, float blendTime = 0.25f, float thumb = 1f, float index = 1f, float middle = 1f, float ring = 1f, float pinky = 1f)
		{
		}

		public void CapturePose(Transform[] captureRefs, HandPoseData storeDataTo)
		{
		}

		public void OnUpdate()
		{
		}

		private void LerpPose(LocalPoseData from, LocalPoseData to, ref LocalPoseData saveTo, float t)
		{
		}

		private void PoseFingerCurl(HandPoseData open, HandPoseData closed, ref LocalPoseData saveTo, float thumbT, float indexT, float middleT, float ringT, float pinkyT)
		{
		}

		private void ApplyPoseToTransforms(LocalPoseData pose, Transform[] trans)
		{
		}
	}
}
