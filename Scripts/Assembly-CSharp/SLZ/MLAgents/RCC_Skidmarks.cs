using UnityEngine;

namespace SLZ.MLAgents
{
	public class RCC_Skidmarks : MonoBehaviour
	{
		public class markSection
		{
			public Vector3 pos;

			public Vector3 normal;

			public Vector4 tangent;

			public Vector3 posl;

			public Vector3 posr;

			public float intensity;

			public int lastIndex;
		}

		private MeshFilter meshFilter;

		private Mesh mesh;

		public int maxMarks;

		public float markWidth;

		public float groundOffset;

		public float minDistance;

		private int indexShift;

		private int numMarks;

		public markSection[] skidmarks;

		private bool updated;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public int AddSkidMark(Vector3 pos, Vector3 normal, float intensity, int lastIndex)
		{
			return 0;
		}

		private void LateUpdate()
		{
		}

		public void Clean()
		{
		}
	}
}
