using System.Runtime.CompilerServices;
using SplineMesh;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CurveSegment
	{
		private CurveSample _sampleA;

		private Vector3 _binormalA;

		private Vector3 _normalA;

		private CurveSample _sampleB;

		private Vector3 _binormalB;

		private Vector3 _normalB;

		private float _scale;

		public float Distance
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 Direction
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 Location => default(Vector3);

		public Vector3 Normal => default(Vector3);

		public Vector3 Tangent => default(Vector3);

		public CurveSample SampleA => default(CurveSample);

		public CurveSegment(CurveSample sampleA, CurveSample sampleB)
		{
		}

		public CurveSample GetFirstSample(Transform parent = null)
		{
			return default(CurveSample);
		}

		public CurveSample GetSampleFromPoint(Vector3 position, Transform parent = null)
		{
			return default(CurveSample);
		}
	}
}
