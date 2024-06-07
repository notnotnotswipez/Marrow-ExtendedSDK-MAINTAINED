using UnityEngine;

namespace SLZ.Bonelab
{
	[ExecuteInEditMode]
	public class ZipLinkSetup : MonoBehaviour
	{
		public LinkDataManager linkManager;

		public float zipTotalLength;

		public float zipMechLength;

		public GameObject[] zipObjs;

		[Header("Zip Up Vars")]
		public GameObject zipUpParentObj;

		public ZipJointMover zipJointMover;

		public GenGameControl_Trigger zipUpTrigger;

		public GameObject upStartObj;

		public GameObject upEndObj;

		[HideInInspector]
		public Vector3 upZipStartPoint;

		[HideInInspector]
		public Vector3 upZipEndPoint;

		[Header("Zip Down Vars")]
		public GameObject zipDownPrefab;

		public GenGameControl_Trigger zipDownTrigger;

		public GameObject downStartObj;

		public GameObject downEndObj;

		public Transform zipSpawn;

		[HideInInspector]
		public GameObject zipStickPrefab;

		[HideInInspector]
		public Mesh zipStickMesh;

		[HideInInspector]
		public Vector3 downZipStartPoint;

		[HideInInspector]
		public Vector3 downZipEndPoint;
	}
}
