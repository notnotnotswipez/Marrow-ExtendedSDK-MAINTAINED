using UnityEngine;

namespace SLZ.Interaction
{
	public class PhysicsMaterialSwap : MonoBehaviour
	{
		public PhysicMaterial materialWhenDetached;

		public PhysicMaterial materialWhenAttached;

		private Collider[] colliders;

		private void Awake()
		{
		}

		private void OnDetachedFromHand(Hand hand)
		{
		}

		private void OnAttachedToHand(Hand hand)
		{
		}
	}
}
