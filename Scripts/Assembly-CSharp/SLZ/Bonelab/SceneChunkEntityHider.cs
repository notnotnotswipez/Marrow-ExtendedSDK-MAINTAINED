using System.Collections.Generic;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SceneChunkEntityHider : MonoBehaviour
	{
		[Tooltip("Batch of how many entities to hide per-frame")]
		public int batchCount;

		public SceneChunk[] sceneChunks;

		private List<MarrowEntity> _entities;

		private bool _isHiding;
	}
}
