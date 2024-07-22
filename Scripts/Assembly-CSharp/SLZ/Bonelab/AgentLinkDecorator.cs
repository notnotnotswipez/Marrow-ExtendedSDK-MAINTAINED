using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class AgentLinkDecorator : SpawnDecorator
	{
		public bool enableAgentLinking;

	}
}
