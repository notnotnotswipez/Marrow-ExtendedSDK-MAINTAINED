using UnityEngine;
using UnityEngine.AI;

namespace SLZ.Bonelab
{
	public class NavSurfBakery : MonoBehaviour
	{
		[Space(20f)]
		[Header("ContextMenu: Click Bake All Navs,Then Rename All Navs")]
		public GameObject[] enableObjs;

		public GameObject[] disableObjs;

		private NavMeshSurface[] navMeshSurfaces;
	}
}
