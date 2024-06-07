using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class AnimationRig : HeptaRig
	{
		[Header("AnimationRig")]
		public float spineCrouchOffset;

		[SerializeField]
		private AnimationCurve _t1UpOffsetCurveVelocity;

		[SerializeField]
		private AnimationCurve _t1UpOffsetCurveClimb;

		[SerializeField]
		private AnimationCurve _t1UpOffsetCurveMantle;

		[SerializeField]
		private AnimationCurve _sacrumUpOffsetCurveVelocity;

		[SerializeField]
		private AnimationCurve _sacrumUpOffsetCurveClimb;

		[SerializeField]
		private AnimationCurve _sacrumUpOffsetCurveMantle;

		public AnimationCurve SwingCounterCurve;

		private float _lfCurlLerp;

		private float _rtCurlLerp;

		private Vector3 _dragUp;

		[SerializeField]
		private SLZ_Body _body;

		private SimpleTransform _pelvisLocalAnimOff;

		private float _t1ToVelLerp;

		private float _t1ToVelVel;

		private float _sacrumToVelLerp;

		private float _sacrumToVelVel;

		private float _t1UpOffsetLerp;

		private float _t1UpOffsetVel;

		private float _sacrumUpOffsetLerp;

		private float _sacrumUpOffsetVel;

		private Vector2 _lastT1FwdV2;

		private Vector2 _lastSacrumFwdV2;

		protected float _suppressChestVelocityTwist;

		private bool _suppressionDirty;

		private bool _suppressionFreshlyFilthy;

		public SLZ_Body body => null;

		public SimpleTransform pelvisLocalAnimOff => default(SimpleTransform);

		public float suppressChestVelocityTwist
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void OnStart()
		{
		}

		public override void OnRigEnable(bool reEnable)
		{
		}

		public override void OnEarlyUpdate()
		{
		}

		private void UpdateHeptaBody2(Rig inRig, float deltaTime, Vector2 velocity, Vector2 accel)
		{
		}

		public override void Teleport(SimpleTransform displace, bool zeroVelocity = false)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		protected Vector3 BodyVelocity(Rig inRig, Vector2 vel, Vector2 accel, float deltaTime)
		{
			return default(Vector3);
		}

		private SimpleTransform AdditiveChest(SLZ.VRMK.Avatar avatar, SimpleTransform head, Rig inRig, float deltaTime, out SimpleTransform outNeck, float mantle = 0f, float footSupported = 1f, float handSupported = 0f, float physKneeOffset = 0f)
		{
			outNeck = default(SimpleTransform);
			return default(SimpleTransform);
		}

		private float SolveT1UpOffset(float heightWeight, float mantle, float footSupported, float handSupported, float velocityInLegs)
		{
			return 0f;
		}

		protected SimpleTransform AdditivePelvis(SLZ.VRMK.Avatar avatar, SimpleTransform chest, Rig inRig, float deltaTime, out SimpleTransform outSpine, Quaternion pelvisLocalAnimOff, float mantle = 0f, float footSupported = 1f, float handSupported = 0f, float physKneeOffset = 0f)
		{
			outSpine = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected float SolveSacrumUpOffset(float heightWeight, float mantle, float footSupported, float handSupported, float velocityInLegs)
		{
			return 0f;
		}
	}
}
