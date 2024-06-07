using System;
using UnityEngine;

namespace SLZ.Rig
{
	[Serializable]
	public class BodyPose
	{
		public Quaternion headRotationInRoot;

		public Quaternion neckRotationInRoot;

		public Quaternion chestRotationInRoot;

		public Quaternion spineRotationInRoot;

		public Quaternion pelvisRotationInRoot;

		public Quaternion clavLfRotationInRoot;

		public Quaternion clavRtRotationInRoot;

		public Quaternion armLfRotationInRoot;

		public Quaternion armRtRotationInRoot;

		public float armLfExtension;

		public float armRtExtension;

		public Quaternion handLfRotationInRoot;

		public Quaternion handRtRotationInRoot;

		public Quaternion legLfRotationInRoot;

		public Quaternion legRtRotationInRoot;

		public float legLfExtension;

		public float legRtExtension;

		public Quaternion footLfRotationInRoot;

		public Quaternion footRtRotationInRoot;

		public Vector3 palmRtToLfDirInRoot;

		public float handSeparation;

		public float torsoYHandLf;

		public float torsoTHandLf;

		public Vector2 torsoSinHandLf;

		public Quaternion torsoRotInWorldHandLf;

		public Vector3 spineInPalmLfNormed;

		public float torsoYHandRt;

		public float torsoTHandRt;

		public Vector2 torsoSinHandRt;

		public Quaternion torsoRotInWorldHandRt;

		public Vector3 spineInPalmRtNormed;

		public Vector3 rootPosition;

		public Quaternion rootRotation;

		public Vector3 headPosition;

		public Vector3 headPositionInRoot;

		public double timestamp;

		public void LerpPoseUnclamped(BodyPose from, BodyPose to, float t)
		{
		}

		public void CopyPose(BodyPose from)
		{
		}

		public void AddPose(BodyPose addPose, RigWeights weights)
		{
		}
	}
}
