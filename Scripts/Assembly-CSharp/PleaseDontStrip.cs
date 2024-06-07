using TMPro;
using UnityEngine;

public class PleaseDontStrip : MonoBehaviour
{
	[SerializeField]
	private Mesh mesh;

	[SerializeField]
	private LineRenderer lineRend;

	[SerializeField]
	private MeshRenderer meshRend;

	[SerializeField]
	private Mesh replacementMesh;

	private TextMeshPro textmesh;

	private MeshFilter mf;

	private void Reset()
	{
	}

	private void Start()
	{
	}
}
