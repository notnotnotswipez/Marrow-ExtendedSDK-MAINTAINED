using System;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SpawnableDoorStateSetter : MonoBehaviour
	{
		[Serializable]
		public class SpawnableDoorGroup
		{
			public GameObject door;

			public CrateSpawner[] items;

			public string saveVar;

			public bool overrideOpen;
		}

		public float doorHighOffset;

		public float doorLowOffset;

		public SpawnableDoorGroup[] doors;

		public void Start()
		{
		}

		public void OVERRIDEALLOPEN()
		{
		}

		public void OPENDOOR(int i)
		{
		}
	}
}
