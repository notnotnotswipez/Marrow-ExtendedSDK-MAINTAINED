using System;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Data
{
	// Token: 0x02000015 RID: 21
	[CreateAssetMenu(fileName = "Surface", menuName = "Variables/Surface", order = 10)]
	[Serializable]
	public class SurfaceData : ScriptableObject
	{
		// Token: 0x040000EF RID: 239
		[Header("Options")]
		[Range(0.001f, 1f)]
		public float PenetrationResistance;

		// Token: 0x040000F0 RID: 240
		public float megaPascal;

		// Token: 0x040000F1 RID: 241
		public bool isFlammable;

		// Token: 0x040000F2 RID: 242
		public float fireResistance;

		// Token: 0x040000F3 RID: 243
		[ColorUsage(true, true)]
		public Color ParicleColorTint;

		// Token: 0x040000F4 RID: 244
		[Header("References")]
		public PhysicMaterial physicMaterial;

		// Token: 0x040000F5 RID: 245
		public Spawnable impactEffectSpawnable;

		// Token: 0x040000F6 RID: 246
		public Spawnable bulletDecalSpawnable;

		// Token: 0x040000F7 RID: 247
		public SurfaceData.MaterialLevel[] BulletDecal;

		// Token: 0x040000F8 RID: 248
		public SurfaceData.MaterialLevel[] BluntDecal;

		// Token: 0x020001DA RID: 474
		[Serializable]
		public struct MaterialLevel
		{
			// Token: 0x04000CC4 RID: 3268
			public Material material;

			// Token: 0x04000CC5 RID: 3269
			public float size;

			// Token: 0x04000CC6 RID: 3270
			public DecalAtlasData atlasData;

			// Token: 0x04000CC7 RID: 3271
			public bool useVertexColor;
		}
	}

	public class DecalAtlasData
	{
	}
}
