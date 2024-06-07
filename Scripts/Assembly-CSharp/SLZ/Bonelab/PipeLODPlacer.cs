using UnityEngine;

namespace SLZ.Bonelab
{
	public class PipeLODPlacer : MonoBehaviour
	{
		public PipeLODMap lodMap;

		public MB3_MeshCombinerSettings meshCombinerSettings;

		public GameObject LOD0Root;

		[SerializeField]
		private GameObject LOD1Root;

		[SerializeField]
		private GameObject LOD2Root;
	}

	public class MB3_MeshCombinerSettings
	{
	}
}
