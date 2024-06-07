using System.Collections.Generic;
using SLZ.Marrow.AI;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[RequireComponent(typeof(ZoneLink), typeof(Zone))]
	public class ZoneAggro : MonoBehaviour, IZoneEntityListenable
	{
		private static ComponentCache<ZoneAggro> _cache;

		[SerializeField]
		private Zone _zone;

		[SerializeField]
		private ZoneLink _zoneLink;

		public MarrowQuery beingTags;

		public MarrowQuery playerTag;

		private TriggerRefProxy playerProxy;

		private MarrowEntity playerEntity;

		private List<MarrowEntity> _entities;

		public static ComponentCache<ZoneAggro> Cache => null;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnZoneEntityEnter(MarrowEntity entity)
		{
		}

		public void OnZoneEntityExit(MarrowEntity entity)
		{
		}

		[ContextMenu("AggroOnPlayer")]
		public void AggroOnPlayer()
		{
		}

		public void AggroOn(TriggerRefProxy trp, bool isSecondary = false)
		{
		}
	}
}
