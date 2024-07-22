using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class RigidBodySettingsDecorator : SpawnDecorator
	{
		[SerializeField]
		[Tooltip("Ignore Colliders")]
		private Collider[] ignoreColliders;

	}
}
