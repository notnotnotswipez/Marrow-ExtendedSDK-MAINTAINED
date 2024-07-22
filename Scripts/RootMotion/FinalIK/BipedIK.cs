using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000017 RID: 23
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class BipedIK : SolverManager
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00002250 File Offset: 0x00000450
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002252 File Offset: 0x00000452
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002254 File Offset: 0x00000454
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002256 File Offset: 0x00000456
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002258 File Offset: 0x00000458
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return 0f;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000225F File Offset: 0x0000045F
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return 0f;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002266 File Offset: 0x00000466
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002268 File Offset: 0x00000468
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000226A File Offset: 0x0000046A
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000226C File Offset: 0x0000046C
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000333C File Offset: 0x0000153C
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003354 File Offset: 0x00001554
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000226E File Offset: 0x0000046E
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002270 File Offset: 0x00000470
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002272 File Offset: 0x00000472
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002274 File Offset: 0x00000474
		public void SetSpineWeight(float weight)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002276 File Offset: 0x00000476
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002279 File Offset: 0x00000479
		public void InitiateBipedIK()
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000227B File Offset: 0x0000047B
		public void UpdateBipedIK()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000227D File Offset: 0x0000047D
		public void SetToDefaults()
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000227F File Offset: 0x0000047F
		protected override void FixTransforms()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002281 File Offset: 0x00000481
		protected override void InitiateSolver()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002283 File Offset: 0x00000483
		protected override void UpdateSolver()
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002285 File Offset: 0x00000485
		public void LogWarning(string message)
		{
		}

		// Token: 0x04000068 RID: 104
		public BipedReferences references;

		// Token: 0x04000069 RID: 105
		public BipedIKSolvers solvers;
	}
}
