using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

public class VFXDecorator : SpawnDecorator
{
	[SerializeField]
	public SpawnableCrateReference spawnableCrateReference;

	public bool despawnOnJointBreak;

	public override void OnSpawn(GameObject go)
	{
	}

	public void SpawnSpawnable(GameObject attachObj)
	{
	}
}
