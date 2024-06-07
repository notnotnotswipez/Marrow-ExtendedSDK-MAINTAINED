using System;
using SLZ.Interaction;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class GameWorldSkeletonRig : HeptaRig
	{
		public Action OnPreFixedUpdate;

		[Header("VirtualHeptaRig")]
		public VirtualController virtualController;

		public VirtualControllerOverride bodyVCOverride;

		[SerializeField]
		private SkeletonHand _leftSkeletonHand;

		[SerializeField]
		private SkeletonHand _rightSkeletonHand;

		private float _lfCurlLerp;

		private float _rtCurlLerp;

		public override void Reset()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
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

		public SkeletonHand GetSkeletonHand(Handedness handedness)
		{
			return null;
		}
	}
}
