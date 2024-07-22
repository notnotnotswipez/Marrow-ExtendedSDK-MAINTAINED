using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000055 RID: 85
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	public class InteractionTarget : MonoBehaviour
	{
		// Token: 0x06000384 RID: 900 RVA: 0x00002A13 File Offset: 0x00000C13
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002A15 File Offset: 0x00000C15
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002A17 File Offset: 0x00000C17
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002A19 File Offset: 0x00000C19
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002A1B File Offset: 0x00000C1B
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002A1D File Offset: 0x00000C1D
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002A1F File Offset: 0x00000C1F
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return 0f;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002A26 File Offset: 0x00000C26
		public void ResetRotation()
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002A28 File Offset: 0x00000C28
		public void RotateTo(Vector3 position)
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002A2A File Offset: 0x00000C2A
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002A2C File Offset: 0x00000C2C
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x040002F4 RID: 756
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		// Token: 0x040002F5 RID: 757
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public InteractionTarget.Multiplier[] multipliers;

		// Token: 0x040002F6 RID: 758
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		// Token: 0x040002F7 RID: 759
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		// Token: 0x040002F8 RID: 760
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		// Token: 0x040002F9 RID: 761
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		// Token: 0x040002FA RID: 762
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		// Token: 0x040002FB RID: 763
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		// Token: 0x040002FC RID: 764
		private Quaternion defaultLocalRotation;

		// Token: 0x040002FD RID: 765
		private Transform lastPivot;

		// Token: 0x020000A1 RID: 161
		[Serializable]
		public class Multiplier
		{
			// Token: 0x0400050E RID: 1294
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			// Token: 0x0400050F RID: 1295
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;
		}
	}
}
