using System;
using System.ComponentModel;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x0200013C RID: 316
	[Serializable]
	public class TrackerSettings
	{
		// Token: 0x04000701 RID: 1793
		[SerializeField]
		public bool isActive;

		// Token: 0x04000702 RID: 1794
		[SerializeField]
		public int layer;

		// Token: 0x04000703 RID: 1795
		[SerializeField]
		public TrackerSettings.Type type;

		// Token: 0x04000704 RID: 1796
		[SerializeField]
		public Vector3 center;

		// Token: 0x04000705 RID: 1797
		[SerializeField]
		public Vector3 size;

		// Token: 0x04000706 RID: 1798
		[SerializeField]
		public float radius;

		// Token: 0x04000707 RID: 1799
		[SerializeField]
		public float height;

		// Token: 0x04000708 RID: 1800
		[SerializeField]
		public TrackerSettings.Direction direction;

		// Token: 0x0200026F RID: 623
		[Serializable]
		public enum Type
		{
			// Token: 0x04000FB6 RID: 4022
			Bounds,
			// Token: 0x04000FB7 RID: 4023
			Box,
			// Token: 0x04000FB8 RID: 4024
			Sphere,
			// Token: 0x04000FB9 RID: 4025
			Capsule
		}

		// Token: 0x02000270 RID: 624
		[Serializable]
		public enum Direction
		{
			// Token: 0x04000FBB RID: 4027
			[Description("X-Axis")]
			XAxis,
			// Token: 0x04000FBC RID: 4028
			[Description("Y-Axis")]
			YAxis,
			// Token: 0x04000FBD RID: 4029
			[Description("Z-Axis")]
			ZAxis
		}
	}
}
