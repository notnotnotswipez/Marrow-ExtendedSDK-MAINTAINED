using UnityEngine;

public class MeshColoringRam : MonoBehaviour
{
	public float height;

	public float threshold;

	public bool autoColor;

	public bool newMesh;

	public Vector3 oldPosition;

	public bool colorMeshLive;

	public LayerMask layer;

	private MeshFilter[] meshFilters;

	private bool colored;

	private static RamSpline[] ramSplines;

	private static LakePolygon[] lakePolygons;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ColorMeshLive()
	{
	}
}
