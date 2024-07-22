using System.Collections.Generic;
using UnityEngine;

namespace SplineMesh
{
	[RequireComponent(typeof(MeshFilter))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class MeshBender : MonoBehaviour
	{
		public enum FillingMode
		{
			Once = 0,
			Repeat = 1,
			StretchToInterval = 2
		}

		private bool isDirty;

		private Mesh result;

		private bool useSpline;

		private Spline spline;

		private float intervalStart;

		private float intervalEnd;

		private CubicBezierCurve curve;

		private Dictionary<float, CurveSample> sampleCache;

		private SourceMesh source;

		private FillingMode mode;

		public SourceMesh Source
		{
			get
			{
				return default(SourceMesh);
			}
			set
			{
			}
		}

		public FillingMode Mode
		{
			get
			{
				return default(FillingMode);
			}
			set
			{
			}
		}

		public void SetInterval(CubicBezierCurve curve)
		{
		}

		public void SetInterval(Spline spline, float intervalStart, float intervalEnd = 0f)
		{
		}

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}

		public void ComputeIfNeeded()
		{
		}

		private void SetDirty()
		{
		}

		private void Compute()
		{
		}

		private void OnDestroy()
		{
		}

		private void FillOnce()
		{
		}

		private void FillRepeat()
		{
		}

		private void FillStretch()
		{
		}
	}
}
