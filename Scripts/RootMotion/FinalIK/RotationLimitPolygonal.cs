using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005E RID: 94
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		// Token: 0x060003DA RID: 986 RVA: 0x00002AE9 File Offset: 0x00000CE9
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002AEB File Offset: 0x00000CEB
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002AED File Offset: 0x00000CED
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002AEF File Offset: 0x00000CEF
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002AF1 File Offset: 0x00000CF1
		public void SetLimitPoints(RotationLimitPolygonal.LimitPoint[] points)
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000399C File Offset: 0x00001B9C
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002AF3 File Offset: 0x00000CF3
		private void Start()
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002AF5 File Offset: 0x00000CF5
		public void ResetToDefault()
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002AF7 File Offset: 0x00000CF7
		public void BuildReachCones()
		{
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002AF9 File Offset: 0x00000CF9
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002AFC File Offset: 0x00000CFC
		private float GetScalar(int k)
		{
			return 0f;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000039B4 File Offset: 0x00001BB4
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000039CC File Offset: 0x00001BCC
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000039E4 File Offset: 0x00001BE4
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002B03 File Offset: 0x00000D03
		private int GetReachCone(Vector3 L)
		{
			return 0;
		}

		// Token: 0x04000327 RID: 807
		[Range(0f, 180f)]
		public float twistLimit;

		// Token: 0x04000328 RID: 808
		[Range(0f, 3f)]
		public int smoothIterations;

		// Token: 0x04000329 RID: 809
		[SerializeField]
		[HideInInspector]
		public RotationLimitPolygonal.LimitPoint[] points;

		// Token: 0x0400032A RID: 810
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		// Token: 0x0400032B RID: 811
		[HideInInspector]
		[SerializeField]
		public RotationLimitPolygonal.ReachCone[] reachCones;

		// Token: 0x020000A9 RID: 169
		[Serializable]
		public class ReachCone
		{
			// Token: 0x17000086 RID: 134
			// (get) Token: 0x0600053E RID: 1342 RVA: 0x00003D7C File Offset: 0x00001F7C
			public Vector3 a
			{
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x0600053F RID: 1343 RVA: 0x00003D94 File Offset: 0x00001F94
			public Vector3 b
			{
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x06000540 RID: 1344 RVA: 0x00003DAC File Offset: 0x00001FAC
			public Vector3 c
			{
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x06000541 RID: 1345 RVA: 0x00002F07 File Offset: 0x00001107
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x06000542 RID: 1346 RVA: 0x00002F0F File Offset: 0x0000110F
			public bool isValid
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06000543 RID: 1347 RVA: 0x00002F12 File Offset: 0x00001112
			public void Calculate()
			{
			}

			// Token: 0x04000536 RID: 1334
			public Vector3[] tetrahedron;

			// Token: 0x04000537 RID: 1335
			public float volume;

			// Token: 0x04000538 RID: 1336
			public Vector3 S;

			// Token: 0x04000539 RID: 1337
			public Vector3 B;
		}

		// Token: 0x020000AA RID: 170
		[Serializable]
		public class LimitPoint
		{
			// Token: 0x0400053A RID: 1338
			public Vector3 point;

			// Token: 0x0400053B RID: 1339
			public float tangentWeight;
		}
	}
}
