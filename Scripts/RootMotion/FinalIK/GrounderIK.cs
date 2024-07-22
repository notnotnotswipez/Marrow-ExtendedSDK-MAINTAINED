using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200001F RID: 31
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class GrounderIK : Grounder
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x0000233C File Offset: 0x0000053C
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000233E File Offset: 0x0000053E
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002340 File Offset: 0x00000540
		public override void ResetPosition()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002342 File Offset: 0x00000542
		private bool IsReadyToInitiate()
		{
			return false;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002345 File Offset: 0x00000545
		private void OnDisable()
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002347 File Offset: 0x00000547
		private void Update()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002349 File Offset: 0x00000549
		private void Initiate()
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000234B File Offset: 0x0000054B
		private void OnSolverUpdate()
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000234D File Offset: 0x0000054D
		private void SetLegIK(int index)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000234F File Offset: 0x0000054F
		private void OnPostSolverUpdate()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002351 File Offset: 0x00000551
		private void OnDestroy()
		{
		}

		// Token: 0x040000A3 RID: 163
		public IK[] legs;

		// Token: 0x040000A4 RID: 164
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		// Token: 0x040000A5 RID: 165
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		// Token: 0x040000A6 RID: 166
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		public float rootRotationWeight;

		// Token: 0x040000A7 RID: 167
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		// Token: 0x040000A8 RID: 168
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		// Token: 0x040000A9 RID: 169
		private Transform[] feet;

		// Token: 0x040000AA RID: 170
		private Quaternion[] footRotations;

		// Token: 0x040000AB RID: 171
		private Vector3 animatedPelvisLocalPosition;

		// Token: 0x040000AC RID: 172
		private Vector3 solvedPelvisLocalPosition;

		// Token: 0x040000AD RID: 173
		private int solvedFeet;

		// Token: 0x040000AE RID: 174
		private bool solved;

		// Token: 0x040000AF RID: 175
		private float lastWeight;

		// Token: 0x040000B0 RID: 176
		private Rigidbody characterRootRigidbody;
	}
}
