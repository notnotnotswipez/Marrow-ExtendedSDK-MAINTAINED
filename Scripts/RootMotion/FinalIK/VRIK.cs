using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002F RID: 47
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		// Token: 0x06000189 RID: 393 RVA: 0x000024D2 File Offset: 0x000006D2
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000024D4 File Offset: 0x000006D4
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000024D6 File Offset: 0x000006D6
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000024D8 File Offset: 0x000006D8
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000024DA File Offset: 0x000006DA
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000024DC File Offset: 0x000006DC
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000024DF File Offset: 0x000006DF
		protected override void InitiateSolver()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000024E1 File Offset: 0x000006E1
		protected override void UpdateSolver()
		{
		}

		// Token: 0x040000F6 RID: 246
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		public VRIK.References references;

		// Token: 0x040000F7 RID: 247
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		// Token: 0x02000082 RID: 130
		[Serializable]
		public class References
		{
			// Token: 0x0600046E RID: 1134 RVA: 0x00002C98 File Offset: 0x00000E98
			public Transform[] GetTransforms()
			{
				return null;
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600046F RID: 1135 RVA: 0x00002C9B File Offset: 0x00000E9B
			public bool isFilled
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000470 RID: 1136 RVA: 0x00002C9E File Offset: 0x00000E9E
			public bool isEmpty
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x00002CA1 File Offset: 0x00000EA1
			public static bool AutoDetectReferences(Transform root, out VRIK.References references)
			{
				references = null;
				return false;
			}

			// Token: 0x040003EB RID: 1003
			public Transform root;

			// Token: 0x040003EC RID: 1004
			public Transform pelvis;

			// Token: 0x040003ED RID: 1005
			public Transform spine;

			// Token: 0x040003EE RID: 1006
			[Tooltip("Optional")]
			public Transform chest;

			// Token: 0x040003EF RID: 1007
			[Tooltip("Optional")]
			public Transform neck;

			// Token: 0x040003F0 RID: 1008
			public Transform head;

			// Token: 0x040003F1 RID: 1009
			[Tooltip("Optional")]
			public Transform leftShoulder;

			// Token: 0x040003F2 RID: 1010
			public Transform leftUpperArm;

			// Token: 0x040003F3 RID: 1011
			public Transform leftForearm;

			// Token: 0x040003F4 RID: 1012
			public Transform leftHand;

			// Token: 0x040003F5 RID: 1013
			[Tooltip("Optional")]
			public Transform rightShoulder;

			// Token: 0x040003F6 RID: 1014
			public Transform rightUpperArm;

			// Token: 0x040003F7 RID: 1015
			public Transform rightForearm;

			// Token: 0x040003F8 RID: 1016
			public Transform rightHand;

			// Token: 0x040003F9 RID: 1017
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			// Token: 0x040003FA RID: 1018
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			// Token: 0x040003FB RID: 1019
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			// Token: 0x040003FC RID: 1020
			[Tooltip("Optional")]
			public Transform leftToes;

			// Token: 0x040003FD RID: 1021
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			// Token: 0x040003FE RID: 1022
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			// Token: 0x040003FF RID: 1023
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			// Token: 0x04000400 RID: 1024
			[Tooltip("Optional")]
			public Transform rightToes;
		}
	}
}
