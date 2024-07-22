using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CollisionFilterZoneItem : ZoneItem
	{
		[SerializeField]
		private Collider[] _collidersToIgnore;

	}
}
