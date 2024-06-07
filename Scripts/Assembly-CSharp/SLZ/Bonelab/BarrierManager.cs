using System.Collections.Generic;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BarrierManager : MonoBehaviour
	{
		private enum Direction
		{
			None = 0,
			Aonly = 1,
			Bonly = 2,
			AtoB = 3,
			BtoA = 4
		}

		[SerializeField]
		private BarrierZoneItem _zoneA;

		[SerializeField]
		private Collider _colliderA;

		private HashSet<MarrowEntity> _overlapsA;

		[SerializeField]
		private BarrierZoneItem _zoneB;

		[SerializeField]
		private Collider _colliderB;

		private HashSet<MarrowEntity> _overlapsB;

		public MarrowQuery allowedTags;

		private void Awake()
		{
		}

		private void OnAEnter(MarrowEntity entity)
		{
		}

		private void OnAExit(MarrowEntity entity)
		{
		}

		private void OnBEnter(MarrowEntity entity)
		{
		}

		private void OnBExit(MarrowEntity entity)
		{
		}

		private void ProcessesCollisionState(MarrowEntity entity, Direction direction)
		{
		}

		private void IgnoreCollisions(MarrowEntity entity, Collider colliderToIgnore, bool isIgnore)
		{
		}
	}
}
