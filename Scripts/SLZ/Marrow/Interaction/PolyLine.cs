using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Splines;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000146 RID: 326
	[RequireComponent(typeof(SplineContainer))]
	public class PolyLine : MonoBehaviour
	{
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x000047CF File Offset: 0x000029CF
		public SplineContainer SplineContainer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000047D2 File Offset: 0x000029D2
		private void Awake()
		{
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000047D4 File Offset: 0x000029D4
		public int GetNearestPoint(float3 worldPos, out float3 position, out float3 tangent, out float3 normal)
		{
			position = default(float3);
			tangent = default(float3);
			normal = default(float3);
			return 0;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x000047ED File Offset: 0x000029ED
		public int GetPointAtLinearDistance(float3 worldPos, float distance, out float3 position, out float3 tangent, out float3 normal, int startIndex = 0)
		{
			position = default(float3);
			tangent = default(float3);
			normal = default(float3);
			return 0;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00004807 File Offset: 0x00002A07
		public int GetNearestPointFromIndex(float3 worldPos, out float3 position, out float3 tangent, out float3 normal, int startIndex = 0)
		{
			position = default(float3);
			tangent = default(float3);
			normal = default(float3);
			return 0;
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00004820 File Offset: 0x00002A20
		public bool IsACappedIndex(int index)
		{
			return false;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00004823 File Offset: 0x00002A23
		public void GetPointAtIndex(int index, out float3 position, out float3 tangent, out float3 normal)
		{
			position = default(float3);
			tangent = default(float3);
			normal = default(float3);
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0000483B File Offset: 0x00002A3B
		private int GetNearestVertWithinRange(float3 localPos, int start, int end, out int interval, uint intervalDivision = 1U)
		{
			interval = 0;
			return 0;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00004846 File Offset: 0x00002A46
		public static int Mod(int i, int max)
		{
			return 0;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00004849 File Offset: 0x00002A49
		private void Reset()
		{
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0000484B File Offset: 0x00002A4B
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0000484D File Offset: 0x00002A4D
		private void DrawSplineGizmo()
		{
		}

		// Token: 0x04000732 RID: 1842
		private static readonly float LINEAR_LOOKUP_MIN_DIST;

		// Token: 0x04000733 RID: 1843
		[SerializeField]
		public PolyLineData lineData;

		// Token: 0x04000734 RID: 1844
		private PolyLineVert[] _polyVerts;

		// Token: 0x04000735 RID: 1845
		private float _segmentDistance;

		// Token: 0x04000736 RID: 1846
		private float _totalDistance;

		// Token: 0x04000737 RID: 1847
		private bool _isBaked;

		// Token: 0x04000738 RID: 1848
		[SerializeField]
		private SplineContainer _splineContainer;
	}
}
