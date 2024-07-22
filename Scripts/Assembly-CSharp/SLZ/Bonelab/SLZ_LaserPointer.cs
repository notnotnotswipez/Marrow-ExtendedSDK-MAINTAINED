using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SLZ_LaserPointer : MarrowBehaviour
	{
		public Transform laserLine;

		public Transform glowingPoint;

		private Vector3 lastframepoint;

		private Vector3 lastposition;

		private MeshFilter LineTrailMesher;

		public Renderer[] renderers;

		public TrailRenderer trail;

		public bool MotionBlurMesh;

		public float RaycastDistance;

		[SerializeField]
		private LayerMask Masks;

		private Vector3 preV3;

		private Color startcolor;

		private Vector3 tempzero;

		[ColorUsage(false, true)]
		public Color LaserColor;

		public Renderer[] LaserPointerMeshs;

		private MaterialPropertyBlock LaserMaterialPropertyBlock;

		private int LaserVector3ID;

		private int IntensityID;

		private int ColorID;

		private Mesh laserTrailMesh;

		private Vector3[] vertices;

		private int[] triangles;

		private Vector3 forwardV3;

		private Vector3 AirPoint;

		[SerializeField]
		[Range(0f, 6f)]
		private int FrameSkip;

		private int frame;

		private bool justEnabled;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void InitializeMesh()
		{
		}

		private void MeshUpdate(Vector3 hitpoint, Vector3 lasthit)
		{
		}
	}
}
