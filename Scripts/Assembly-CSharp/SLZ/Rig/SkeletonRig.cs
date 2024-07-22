using SLZ.Marrow;
using SLZ.Marrow.Mechanics;
using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class SkeletonRig : HeptaRig
	{
		[Header("AnimationRig")]
		[SerializeField]
		private LiteLoco _liteLoco;

		[SerializeField]
		private SLZ_Body _body;

		private SimpleTransform _pelvisLocalAnimOff;

		private new const float accelLeanWeight = 0.35f;

		private new const float dragWeight = 4f;

		private new const float pACdProduct = 2f;

		private float _accelDragTan;

		private float _dragTan;

		private new float _angularVelocity;

		[HideInInspector]
		public Vector3 velocitySanGrav;

		[HideInInspector]
		public Vector3 accelerationSanGrav;

		[HideInInspector]
		public Vector3 velocitySanGravNormal;

		[HideInInspector]
		public Vector3 accelerationSanGravNormal;

		[HideInInspector]
		public float velocitySanGravMag;

		[HideInInspector]
		public float accelSanGravMag;

		private float _deltaLerpTime;

		private new Vector3 _lastAngularFwd;

		private Quaternion _feetAngleSlerp;

		public SLZ_Body body => null;

		public SimpleTransform pelvisLocalAnimOff => default(SimpleTransform);

		public override void Reset()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void Teleport(SimpleTransform displace, bool zeroVelocity = false)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		internal void BodyVelocity(Vector3 vel, Vector3 accel, Quaternion feetCenterRot, float deltaTime)
		{
		}

		private void FeetCenter(SimpleTransform pelvis, float deltaTime)
		{
		}

		private new void LimbLimit(float limbMag, float upperLength, float lowerLength, out float newLimbMag)
		{
			newLimbMag = default(float);
		}
	}
}
