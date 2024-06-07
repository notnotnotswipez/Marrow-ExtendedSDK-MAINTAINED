using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace PuppetMasta
{
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourTemplate")]
	public class BehaviourTemplate : BehaviourBase
	{
		public SubBehaviourCOM centerOfMass;

		public LayerMask groundLayers;

		public PuppetEvent onLoseBalance;

		public float loseBalanceAngle;

		protected override void OnInitiate()
		{
		}

		protected override void OnActivate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		protected override void OnDeactivate()
		{
		}

		protected override void OnFixedUpdate()
		{
		}

		protected override void OnLateUpdate()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}
	}
}
