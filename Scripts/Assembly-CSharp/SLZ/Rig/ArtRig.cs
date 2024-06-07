using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class ArtRig : MonoBehaviour
	{
		public Transform m_handLf;

		public Transform m_handRt;

		[Header("ArtRig")]
		public Transform l3Vert;

		public Transform l1Vert;

		public Transform t7Vert;

		public Transform eyeLf;

		public Transform eyeRt;

		public Transform scapLf;

		public Transform wristLf;

		public Transform carpalLf;

		public Transform scapRt;

		public Transform wristRt;

		public Transform carpalRt;

		public Transform toeLf;

		public Transform toeRt;

		public Transform breastLf;

		public Transform breastRt;

		public Transform buttLf;

		public Transform buttRt;

		public Transform armUpperTwistLf;

		public Transform armUpperTwistRt;

		public Transform armLowerTwistLf;

		public Transform armLowerTwistRt;

		public Transform legUpperTwistLf;

		public Transform legUpperTwistRt;

		[Header("Art Offsets")]
		public Transform artHips;

		public Transform artSpine;

		public Transform artChest;

		public Transform artUpperChest;

		public Transform artNeck;

		public Transform artHead;

		public Transform artEyeLf;

		public Transform artEyeRt;

		public Transform artJaw;

		public Transform artShoulderLf;

		public Transform artScapLf;

		public Transform artUpperArmLf;

		public Transform artUpperArmTwistLf;

		public Transform artLowerArmLf;

		public Transform artLowerArmTwistLf;

		public Transform artWristLf;

		public Transform artHandLf;

		public Transform artCarpalLf;

		public Transform artShoulderRt;

		public Transform artScapRt;

		public Transform artUpperArmRt;

		public Transform artUpperArmTwistRt;

		public Transform artLowerArmRt;

		public Transform artLowerArmTwistRt;

		public Transform artWristRt;

		public Transform artHandRt;

		public Transform artCarpalRt;

		public Transform artUpperLegLf;

		public Transform artUpperLegTwistLf;

		public Transform artLowerLegLf;

		public Transform artFootLf;

		public Transform artToeLf;

		public Transform artUpperLegRt;

		public Transform artUpperLegTwistRt;

		public Transform artLowerLegRt;

		public Transform artFootRt;

		public Transform artToeRt;

		public Transform artThumbLf1;

		public Transform artThumbLf2;

		public Transform artThumbLf3;

		public Transform artThumbRt1;

		public Transform artThumbRt2;

		public Transform artThumbRt3;

		public Transform artFingerLf11;

		public Transform artFingerLf12;

		public Transform artFingerLf13;

		public Transform artFingerLf21;

		public Transform artFingerLf22;

		public Transform artFingerLf23;

		public Transform artFingerLf31;

		public Transform artFingerLf32;

		public Transform artFingerLf33;

		public Transform artFingerLf41;

		public Transform artFingerLf42;

		public Transform artFingerLf43;

		public Transform artFingerRt11;

		public Transform artFingerRt12;

		public Transform artFingerRt13;

		public Transform artFingerRt21;

		public Transform artFingerRt22;

		public Transform artFingerRt23;

		public Transform artFingerRt31;

		public Transform artFingerRt32;

		public Transform artFingerRt33;

		public Transform artFingerRt41;

		public Transform artFingerRt42;

		public Transform artFingerRt43;

		public Transform artBreastLf;

		public Transform artBreastRt;

		public Transform artButtLf;

		public Transform artButtRt;

		[SerializeField]
		private HandPoseAnimator _leftAnimatorHand;

		[SerializeField]
		private HandPoseAnimator _rightAnimatorHand;

		private float _eyeDamper;

		public HandPoseAnimator LeftAnimatorHand => null;

		public HandPoseAnimator RightAnimatorHand => null;

		public void Reset()
		{
		}

		public void ArtOutputAwake(PhysicsRig rig)
		{
		}

		public void MountRig(PhysicsRig rig)
		{
		}

		public void UnmountRig()
		{
		}

		public void ArtOutputUpdate(PhysicsRig inRig)
		{
		}

		private void SolveCarpal(SimpleTransform wrist, SimpleTransform hand, Transform carpal, float segmentLength)
		{
		}

		public void ArtOutputLateUpdate(PhysicsRig inRig)
		{
		}

		public void SetArtOutputAvatar(PhysicsRig inRig, SLZ.VRMK.Avatar avatar)
		{
		}

		private void ApplyRotationOffsetsToRig(SLZ.VRMK.Avatar avatar)
		{
		}
	}
}
