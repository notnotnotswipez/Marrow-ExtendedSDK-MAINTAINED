using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200001C RID: 28
	public abstract class Grounder : MonoBehaviour
	{
		// Token: 0x060000D0 RID: 208
		public abstract void ResetPosition();

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000022EB File Offset: 0x000004EB
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000022EE File Offset: 0x000004EE
		public bool initiated
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003384 File Offset: 0x00001584
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000022F0 File Offset: 0x000004F0
		protected void LogWarning(string message)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000339C File Offset: 0x0000159C
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000033B4 File Offset: 0x000015B4
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		// Token: 0x060000D7 RID: 215
		protected abstract void OpenUserManual();

		// Token: 0x060000D8 RID: 216
		protected abstract void OpenScriptReference();

		// Token: 0x0400008E RID: 142
		[Range(0f, 1f)]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		public float weight;

		// Token: 0x0400008F RID: 143
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		// Token: 0x04000090 RID: 144
		public Grounder.GrounderDelegate OnPreGrounder;

		// Token: 0x04000091 RID: 145
		public Grounder.GrounderDelegate OnPostGrounder;

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x06000445 RID: 1093
		public delegate void GrounderDelegate();
	}
}
