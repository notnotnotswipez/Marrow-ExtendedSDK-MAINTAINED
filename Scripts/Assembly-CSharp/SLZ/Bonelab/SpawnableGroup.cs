using System;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class SpawnableGroup
	{
		public Spawnable spawnable;

		public GameObject[] spawnPoints;

		public float minVel;
	}
}
