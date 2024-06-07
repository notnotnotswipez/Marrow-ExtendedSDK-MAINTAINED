using System.Collections.Generic;
using UnityEngine;

namespace PathCreation.Utility
{
	public static class VertexPathUtility
	{
		public class PathSplitData
		{
			public List<Vector3> vertices;

			public List<Vector3> tangents;

			public List<float> cumulativeLength;

			public List<int> anchorVertexMap;

			public MinMax3D minMax;
		}

		public static PathSplitData SplitBezierPathByAngleError(BezierPath bezierPath, float maxAngleError, float minVertexDst, float accuracy)
		{
			return null;
		}

		public static PathSplitData SplitBezierPathEvenly(BezierPath bezierPath, float spacing, float accuracy)
		{
			return null;
		}
	}
}
