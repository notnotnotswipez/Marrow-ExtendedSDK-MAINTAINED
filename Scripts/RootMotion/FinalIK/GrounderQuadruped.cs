using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000020 RID: 32
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	public class GrounderQuadruped : Grounder
	{
		// Token: 0x06000100 RID: 256 RVA: 0x0000235B File Offset: 0x0000055B
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000235D File Offset: 0x0000055D
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000235F File Offset: 0x0000055F
		public override void ResetPosition()
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002361 File Offset: 0x00000561
		private bool IsReadyToInitiate()
		{
			return false;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002364 File Offset: 0x00000564
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return false;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002367 File Offset: 0x00000567
		private void OnDisable()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002369 File Offset: 0x00000569
		private void Update()
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000236B File Offset: 0x0000056B
		private void Initiate()
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000236D File Offset: 0x0000056D
		private Transform[] InitiateFeet(IK[] ikComponents, ref GrounderQuadruped.Foot[] f, int indexOffset)
		{
			return null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002370 File Offset: 0x00000570
		private void LateUpdate()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002372 File Offset: 0x00000572
		private void RootRotation()
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002374 File Offset: 0x00000574
		private void OnSolverUpdate()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002376 File Offset: 0x00000576
		private void UpdateForefeetRoot()
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002378 File Offset: 0x00000578
		private void SetFootIK(GrounderQuadruped.Foot foot, float maxOffset)
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000237A File Offset: 0x0000057A
		private void OnPostSolverUpdate()
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000237C File Offset: 0x0000057C
		private void OnDestroy()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000237E File Offset: 0x0000057E
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		// Token: 0x040000B1 RID: 177
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		// Token: 0x040000B2 RID: 178
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		// Token: 0x040000B3 RID: 179
		[Range(-90f, 0f)]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		public float minRootRotation;

		// Token: 0x040000B4 RID: 180
		[Range(0f, 90f)]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		public float maxRootRotation;

		// Token: 0x040000B5 RID: 181
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		// Token: 0x040000B6 RID: 182
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		// Token: 0x040000B7 RID: 183
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		// Token: 0x040000B8 RID: 184
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight;

		// Token: 0x040000B9 RID: 185
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		// Token: 0x040000BA RID: 186
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		// Token: 0x040000BB RID: 187
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		// Token: 0x040000BC RID: 188
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		// Token: 0x040000BD RID: 189
		public IK[] legs;

		// Token: 0x040000BE RID: 190
		public IK[] forelegs;

		// Token: 0x040000BF RID: 191
		[HideInInspector]
		public Vector3 gravity;

		// Token: 0x040000C0 RID: 192
		private GrounderQuadruped.Foot[] feet;

		// Token: 0x040000C1 RID: 193
		private Vector3 animatedPelvisLocalPosition;

		// Token: 0x040000C2 RID: 194
		private Quaternion animatedPelvisLocalRotation;

		// Token: 0x040000C3 RID: 195
		private Quaternion animatedHeadLocalRotation;

		// Token: 0x040000C4 RID: 196
		private Vector3 solvedPelvisLocalPosition;

		// Token: 0x040000C5 RID: 197
		private Quaternion solvedPelvisLocalRotation;

		// Token: 0x040000C6 RID: 198
		private Quaternion solvedHeadLocalRotation;

		// Token: 0x040000C7 RID: 199
		private int solvedFeet;

		// Token: 0x040000C8 RID: 200
		private bool solved;

		// Token: 0x040000C9 RID: 201
		private float angle;

		// Token: 0x040000CA RID: 202
		private Transform forefeetRoot;

		// Token: 0x040000CB RID: 203
		private Quaternion headRotation;

		// Token: 0x040000CC RID: 204
		private float lastWeight;

		// Token: 0x040000CD RID: 205
		private Rigidbody characterRootRigidbody;

		// Token: 0x0200007E RID: 126
		public struct Foot
		{

			// Token: 0x040003CB RID: 971
			public IKSolver solver;

			// Token: 0x040003CC RID: 972
			public Transform transform;

			// Token: 0x040003CD RID: 973
			public Quaternion rotation;

			// Token: 0x040003CE RID: 974
			public Grounding.Leg leg;
		}
	}
}
