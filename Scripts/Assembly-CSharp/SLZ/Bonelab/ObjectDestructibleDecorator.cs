using SLZ.Marrow.Data;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ObjectDestructibleDecorator : SpawnDecorator
	{
		[Header("DO NOT USE on pooled assets")]
		public LootTableData lootTable;

	}
}
