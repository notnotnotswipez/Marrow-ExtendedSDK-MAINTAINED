using UnityEngine;

namespace SLZ.Combat
{
	public class CollisionStay : MonoBehaviour
	{
		[SerializeField]
		private CollisionCollector _collisionCollector;

		private void Reset()
		{
		}

		private void OnCollisionStay(Collision c)
		{
		}
	}
}
