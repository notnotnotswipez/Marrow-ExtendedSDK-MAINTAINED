using System.Collections.Generic;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class MaterialDecorator : SpawnDecorator
	{
		public List<MatDecoratorGroup> materialGroups;

		public override void OnSpawn(GameObject go)
		{
		}

		private void ApplyMaterials(MatDecReciever matDecReciever, int index)
		{
		}
	}
}
