using UnityEngine;

namespace SLZ.Bonelab
{
	public class PinTracker : MonoBehaviour
	{
		public LayerMask layersToIgnore;

		public BowlingResetMechanism pinManager;

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
