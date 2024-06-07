using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BakeAndWeldVerts : MonoBehaviour
	{
		public class Cluster
		{
			public List<int> vertIndexes;

			public Vector3 averagePostion;

			public Vector3[] averageNormals;

			public void CalcAveragePos(Vector3[] vs)
			{
			}

			public void CalcAverageNorm(Vector3[] vNs, float AngleThreshold)
			{
			}
		}

		public float DistanceThreshold;

		public float AngleThreshold;

		[ContextMenu("Bake And Weld Verts")]
		private void DoBakeAndWeldVerts()
		{
		}
	}
}
