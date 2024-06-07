using System;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class PoolWarmupProfile : ScriptableObject
	{
		[Serializable]
		public struct SpawnableCrateGroup
		{
			public SpawnableCrateReference spawnableCrateReference;

			public int warmupCount;
		}

		[SerializeField]
		public SpawnableCrateGroup[] warmupGroups;
	}
}
