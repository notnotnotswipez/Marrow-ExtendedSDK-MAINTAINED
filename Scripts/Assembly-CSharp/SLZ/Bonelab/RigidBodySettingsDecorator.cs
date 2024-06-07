using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class RigidBodySettingsDecorator : SpawnDecorator
	{
		[Tooltip("Ignore Colliders")]
		[SerializeField]
		private Collider[] ignoreColliders;

		public override void OnSpawn(GameObject go)
		{
		}
	}
}
