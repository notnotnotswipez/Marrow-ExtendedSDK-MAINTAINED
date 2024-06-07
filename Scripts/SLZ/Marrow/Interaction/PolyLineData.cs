using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000147 RID: 327
	[Serializable]
	public class PolyLineData : ScriptableObject
	{
		// Token: 0x06000BE7 RID: 3047 RVA: 0x00004859 File Offset: 0x00002A59
		public float SegmentDistance()
		{
			return 0f;
		}

		// Token: 0x04000739 RID: 1849
		[SerializeField]
		public PolyLineData.SegmentResolution segmentResolution;

		// Token: 0x0400073A RID: 1850
		[SerializeField]
		public PolyLineVert[] polyVerts;

		// Token: 0x0400073B RID: 1851
		[SerializeField]
		public float totalDistance;

		// Token: 0x02000272 RID: 626
		[Serializable]
		public enum SegmentResolution
		{
			// Token: 0x04000FC2 RID: 4034
			Millimeter,
			// Token: 0x04000FC3 RID: 4035
			Centimeter,
			// Token: 0x04000FC4 RID: 4036
			Decimeter,
			// Token: 0x04000FC5 RID: 4037
			Meter
		}
	}
}
