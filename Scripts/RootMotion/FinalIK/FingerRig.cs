using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200001B RID: 27
	public class FingerRig : SolverManager
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000022C7 File Offset: 0x000004C7
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000022CA File Offset: 0x000004CA
		public bool initiated
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000022CC File Offset: 0x000004CC
		public bool IsValid(ref string errorMessage)
		{
			return false;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000022CF File Offset: 0x000004CF
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000022D1 File Offset: 0x000004D1
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000022D3 File Offset: 0x000004D3
		public void RemoveFinger(int index)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000022D5 File Offset: 0x000004D5
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000022D7 File Offset: 0x000004D7
		protected override void InitiateSolver()
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000022D9 File Offset: 0x000004D9
		public void UpdateFingerSolvers()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000022DB File Offset: 0x000004DB
		public void FixFingerTransforms()
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000022DD File Offset: 0x000004DD
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000022DF File Offset: 0x000004DF
		protected override void UpdateSolver()
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000022E1 File Offset: 0x000004E1
		protected override void FixTransforms()
		{
		}

		// Token: 0x0400008B RID: 139
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight;

		// Token: 0x0400008C RID: 140
		public Finger[] fingers;
	}
}
