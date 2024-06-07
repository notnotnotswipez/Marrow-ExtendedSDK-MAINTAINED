using System;
using System.Collections.Generic;
using SLZ.Data;
using UnityEngine;

namespace SLZ.VFX
{
	// Token: 0x02000011 RID: 17
	public class DecalProjector : MonoBehaviour
	{
		// Token: 0x06000084 RID: 132 RVA: 0x000027EC File Offset: 0x000009EC
		private void Reset()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000027EE File Offset: 0x000009EE
		[ContextMenu("Apply Decal")]
		public void ApplyDecal()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005EF4 File Offset: 0x000040F4
		public static Vector2 LerpVector2Components(Vector2 a, Vector2 b, Vector2 t)
		{
			return default(Vector2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00005F0C File Offset: 0x0000410C
		public static Vector2 LerpVector2Components(Vector2 a, Vector2 b, float t1, float t2)
		{
			return default(Vector2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000027F0 File Offset: 0x000009F0
		private void CreateConformedMesh(float size)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000027F2 File Offset: 0x000009F2
		private void ApplyToMesh()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000027F4 File Offset: 0x000009F4
		private void CreateRadialLayout(float size)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000027F6 File Offset: 0x000009F6
		public void FindCollider()
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000027F8 File Offset: 0x000009F8
		public void RandomizeSelection()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005F24 File Offset: 0x00004124
		private DecalProjector.DebugRayInfo DefineRayInfo(Vector3 point1, Vector3 point2)
		{
			return default(DecalProjector.DebugRayInfo);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000027FA File Offset: 0x000009FA
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x04000023 RID: 35
		[Header("General Settings")]
		public Material decalMaterial;

		// Token: 0x04000024 RID: 36
		[Tooltip("Offset from surface normal (m)")]
		public float offset;

		// Token: 0x04000025 RID: 37
		[Tooltip("Vertex Color")]
		[ColorUsage(true, true)]
		public Color vertexColor;

		// Token: 0x04000026 RID: 38
		[Tooltip("Collider that will be raycast to")]
		[Header("Raycast Settings")]
		public Collider targetCollider;

		// Token: 0x04000027 RID: 39
		[Tooltip("Diameter or width (m)")]
		public float decalSize;

		// Token: 0x04000028 RID: 40
		[Tooltip("The distance the raycasts (m)")]
		public float raycastDistance;

		// Token: 0x04000029 RID: 41
		[Header("Mesh mode Settings")]
		public DecalProjector.DecalProjectionMethod projectionMethod;

		// Token: 0x0400002A RID: 42
		[Range(1f, 8f)]
		[Header("Grid Settings")]
		public int decalResolution;

		// Token: 0x0400002B RID: 43
		[Range(3f, 16f)]
		[Header("Radial Settings")]
		public int radialSegments;

		// Token: 0x0400002C RID: 44
		[Range(1f, 5f)]
		public int radialSubdivisions;

		// Token: 0x0400002D RID: 45
		[Header("Atlas Settings")]
		public DecalAtlasData atlasData;

		// Token: 0x0400002E RID: 46
		public int atlasSelection;

		// Token: 0x0400002F RID: 47
		public bool randomizeSelection;

		// Token: 0x04000030 RID: 48
		[SerializeField]
		[Header("Generated Decal")]
		private MeshFilter meshFilter;

		// Token: 0x04000031 RID: 49
		[SerializeField]
		private MeshRenderer meshRenderer;

		// Token: 0x04000032 RID: 50
		private readonly List<Vector3> _vertices;

		// Token: 0x04000033 RID: 51
		private readonly List<Vector2> _uvs;

		// Token: 0x04000034 RID: 52
		private readonly List<Color> _colorsz;

		// Token: 0x04000035 RID: 53
		private readonly List<int> _triangles;

		// Token: 0x04000036 RID: 54
		private readonly List<bool> _hits;

		// Token: 0x04000037 RID: 55
		private readonly List<Vector3> _positionGrid;

		// Token: 0x04000038 RID: 56
		private readonly List<bool> _hitGrid;

		// Token: 0x04000039 RID: 57
		private Dictionary<int, Mesh> _meshes;

		// Token: 0x0400003A RID: 58
		private List<DecalProjector.DebugRayInfo> debugRayInfos;

		// Token: 0x020001D0 RID: 464
		public enum DecalProjectionMethod
		{
			// Token: 0x04000C10 RID: 3088
			GridRaycastProjection,
			// Token: 0x04000C11 RID: 3089
			RadialRaycastProjection
		}

		// Token: 0x020001D1 RID: 465
		private struct DebugRayInfo
		{
			// Token: 0x04000C12 RID: 3090
			public Vector3 Origin;

			// Token: 0x04000C13 RID: 3091
			public Vector3 HitPoint;
		}
	}
}
