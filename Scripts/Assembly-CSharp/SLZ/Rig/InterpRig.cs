using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class InterpRig : Rig
	{
		[Header("InterpRig")]
		[SerializeField]
		private Rig _lastRig;

		private BodyPose _lastUpdateBodyPose;

		private BodyPose _updateBodyPose;

		private double _lastFixedTime;

		public Rig lastRig => null;

		public override void Reset()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnEarlyUpdate()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		public override void OnAfterFixedUpdate()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void Teleport(SimpleTransform displace, bool zeroVelocity = false)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}
	}
}
