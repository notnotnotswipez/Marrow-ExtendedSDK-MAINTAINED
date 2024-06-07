using System;
using System.Diagnostics;
using SLZ.Marrow.Utilities;
using Unity.Mathematics;
using UnityEngine;

namespace SLZ.Marrow
{
	// Token: 0x02000024 RID: 36
	public class LineMesh : MonoBehaviour
	{
		// Token: 0x06000202 RID: 514 RVA: 0x00002CC7 File Offset: 0x00000EC7
		[Conditional("UNITY_EDITOR")]
		private static void Initialize()
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002CC9 File Offset: 0x00000EC9
		[Conditional("UNITY_EDITOR")]
		private static void Uninitialize()
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002CCB File Offset: 0x00000ECB
		[Conditional("UNITY_EDITOR")]
		public static void DrawLine(Vector3 startPos, Vector3 endPos, Color color, float duration = 0f)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002CCD File Offset: 0x00000ECD
		[Conditional("UNITY_EDITOR")]
		public static void DrawLine(Vector3 startPos, Vector3 endPos, Color color, float time, float duration)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002CCF File Offset: 0x00000ECF
		[Conditional("UNITY_EDITOR")]
		public static void DrawTransform(Vector3 position, Quaternion rotation, float duration = 0f)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002CD1 File Offset: 0x00000ED1
		[Conditional("UNITY_EDITOR")]
		public static void DrawTransform(RigidTransform t, float duration = 0f)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002CD3 File Offset: 0x00000ED3
		[Conditional("UNITY_EDITOR")]
		public static void DrawBox(Vector3 position, Quaternion rotation, Vector3 halfExtends, Color color = default(Color), float duration = 0f)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002CD5 File Offset: 0x00000ED5
		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 position, Vector3 normal, float radius, Color color, int segments = 16, float duration = 0f)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002CD7 File Offset: 0x00000ED7
		[Conditional("UNITY_EDITOR")]
		public static void DrawConfigJoint(ConfigurableJoint joint, Quaternion startRotation, float scale = 1f)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002CD9 File Offset: 0x00000ED9
		[Conditional("UNITY_EDITOR")]
		private static void DrawJointAnchor(SimpleTransform anchorT, float scale)
		{
		}
	}
}
