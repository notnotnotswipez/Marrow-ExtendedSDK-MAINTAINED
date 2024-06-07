using UnityEngine;
using UnityEngine.AI;

namespace SLZ.Bonelab
{
	[ExecuteInEditMode]
	public class PartialZipLinkSetup : MonoBehaviour
	{
		[Range(0.1f, 0.9f)]
		public float zipLerpPerc;

		public GameObject startObj;

		public GameObject endObj;

		public Vector3 rayHitPoint;

		public ZipLinkManager zipManager;

		public NavMeshLink navLink;

		public LinkData linkData;

		public LinkData maxLinkData;

		public GenGameControl_Trigger trigger;

		[HideInInspector]
		public Vector3 startPoint;

		[HideInInspector]
		public Vector3 endPoint;

		[HideInInspector]
		public Vector3 maxLinkStartPoint;

		[HideInInspector]
		public Vector3 maxLinkEndPoint;

		public GameObject endRayHitObj;

		public ZipLinkSetup zipLinkSetup;

		[ContextMenu("Create Partial ZipLink Up")]
		public void CreatePartialZipLinkUp()
		{
		}

		[ContextMenu("Create Partial ZipLink Down")]
		public void CreatePartialZipLinkDown()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}
	}
}
