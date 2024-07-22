using SLZ.Marrow;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GachaShot : MonoBehaviour
	{
		public Transform firePoint;

		public Spawnable gachaProjectile;

		public Spawnable spawnable;

		public Transform throwPoint;

		public Grip gachaGrip;

		public InteractableHost host;

		private bool _isArmed;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void OnAttachedToHand(Hand hand)
		{
		}

		private void OnDetachedFromHand(Hand hand)
		{
		}
	}
}
