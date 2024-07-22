using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[DisallowMultipleComponent]
	public class EntityPoseDecorator : SpawnDecorator
	{
		public EntityPoseData _poseData;

		public MarrowEntity _entity;

	}
}
