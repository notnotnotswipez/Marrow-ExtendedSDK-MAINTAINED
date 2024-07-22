using System.Collections.Generic;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

[RequireComponent(typeof(Zone))]
public class HomeCleanupVolume : ZoneItem
{
	[Header("This is explicitly for use in Home to deal with the top of the arm tube.  Use elsewhere is unwise.")]
	public List<MarrowEntity> _entities;

	public void DespawnObjects()
	{
	}

	public void HideObjects()
	{
	}

	public void PrintList()
	{
	}
}
