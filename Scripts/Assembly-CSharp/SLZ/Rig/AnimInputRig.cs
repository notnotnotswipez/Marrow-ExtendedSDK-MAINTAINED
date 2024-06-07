using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class AnimInputRig : ControllerRig
	{
		public SLZ.VRMK.Avatar avatarAnim;

		public Transform eyeLf;

		public Transform eyeRt;

		[Header("Art Offsets")]
		public Transform artHips;

		public Transform artSpine;

		public Transform artChest;

		public Transform artNeck;

		public Transform artHead;

		public Transform artEyeLf;

		public Transform artEyeRt;

		public Transform artJaw;

		public Transform artUpperArmLf;

		public Transform artLowerArmLf;

		public Transform artHandLf;

		public Transform artUpperArmRt;

		public Transform artLowerArmRt;

		public Transform artHandRt;

		public Transform artUpperLegLf;

		public Transform artLowerLegLf;

		public Transform artFootLf;

		public Transform artUpperLegRt;

		public Transform artLowerLegRt;

		public Transform artFootRt;

		[SerializeField]
		private HandPoseAnimator _leftAnimatorHand;

		[SerializeField]
		private HandPoseAnimator _rightAnimatorHand;

		private float _eyeDamper;

		private double _lastFixedTime;

		public HandPoseAnimator LeftAnimatorHand => null;

		public HandPoseAnimator RightAnimatorHand => null;

		public override void Reset()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnEarlyUpdate()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		private void ApplyRotationOffsetsToRig(SLZ.VRMK.Avatar avatar)
		{
		}
	}
}
