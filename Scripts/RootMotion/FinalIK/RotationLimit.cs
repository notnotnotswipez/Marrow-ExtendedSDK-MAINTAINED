using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005B RID: 91
	public abstract class RotationLimit : MonoBehaviour
	{
		// Token: 0x060003BE RID: 958 RVA: 0x00002AAD File Offset: 0x00000CAD
		public void SetDefaultLocalRotation()
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000038BC File Offset: 0x00001ABC
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			changed = default(bool);
			return default(Quaternion);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002AAF File Offset: 0x00000CAF
		public bool Apply()
		{
			return false;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002AB2 File Offset: 0x00000CB2
		public void Disable()
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x000038DC File Offset: 0x00001ADC
		public Vector3 secondaryAxis
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x000038F4 File Offset: 0x00001AF4
		public Vector3 crossAxis
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060003C4 RID: 964
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		// Token: 0x060003C5 RID: 965 RVA: 0x00002AB4 File Offset: 0x00000CB4
		private void Awake()
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002AB6 File Offset: 0x00000CB6
		private void LateUpdate()
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002AB8 File Offset: 0x00000CB8
		public void LogWarning(string message)
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000390C File Offset: 0x00001B0C
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00003924 File Offset: 0x00001B24
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002ABA File Offset: 0x00000CBA
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return 0f;
		}

		// Token: 0x0400031A RID: 794
		public Vector3 axis;

		// Token: 0x0400031B RID: 795
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		// Token: 0x0400031C RID: 796
		private bool initiated;

		// Token: 0x0400031D RID: 797
		private bool applicationQuit;

		// Token: 0x0400031E RID: 798
		private bool defaultLocalRotationSet;
	}
}
