using System;
using System.Diagnostics;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow
{
	// Token: 0x02000020 RID: 32
	public class DebugDraw : MonoBehaviour
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x00002CA1 File Offset: 0x00000EA1
		[Conditional("UNITY_EDITOR")]
		public static void DrawText(string text, Vector3 position, Color color, int size = 36)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002CA3 File Offset: 0x00000EA3
		[Conditional("UNITY_EDITOR")]
		public static void DrawLine(Vector3 start, Vector3 end, Color color, float time = 0f)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002CA5 File Offset: 0x00000EA5
		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 position, Vector3 normal, float radius, Color color, int segments = 16, float time = 0f)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002CA7 File Offset: 0x00000EA7
		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 position, Color color = default(Color), float time = 0f)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002CA9 File Offset: 0x00000EA9
		[Conditional("UNITY_EDITOR")]
		public static void DrawTransform(Transform transform, float time = 0f)
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002CAB File Offset: 0x00000EAB
		[Conditional("UNITY_EDITOR")]
		public static void DrawTransform(SimpleTransform st, float time = 0f)
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002CAD File Offset: 0x00000EAD
		[Conditional("UNITY_EDITOR")]
		public static void DrawTransform(Vector3 position, Quaternion rotation, float time = 0f)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002CAF File Offset: 0x00000EAF
		[Conditional("UNITY_EDITOR")]
		public static void DrawLog(string text, Vector3 position, float time = 1f, float scale = 1f)
		{
		}
	}
}
