using System;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnVFX : SpawnDecorator
	{

		private UniTaskVoid WaitForHibernation()
		{
			return default(UniTaskVoid);
		}

		public SpawnVFX()
		{
		}

		private MarrowEntity entity;
	}
}
