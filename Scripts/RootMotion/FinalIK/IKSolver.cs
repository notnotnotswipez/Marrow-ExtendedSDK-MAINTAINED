using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public abstract class IKSolver
	{
		// Token: 0x06000222 RID: 546
		public abstract bool IsValid(ref string message);

		// Token: 0x06000223 RID: 547 RVA: 0x0000264A File Offset: 0x0000084A
		public void Initiate(Transform root)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000264C File Offset: 0x0000084C
		public void Update()
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000365C File Offset: 0x0000185C
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000264E File Offset: 0x0000084E
		public void SetIKPosition(Vector3 position)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002650 File Offset: 0x00000850
		public float GetIKPositionWeight()
		{
			return 0f;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002657 File Offset: 0x00000857
		public void SetIKPositionWeight(float weight)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002659 File Offset: 0x00000859
		public Transform GetRoot()
		{
			return null;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000265C File Offset: 0x0000085C
		// (set) Token: 0x0600022B RID: 555 RVA: 0x0000265F File Offset: 0x0000085F
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

		// Token: 0x0600022C RID: 556
		public abstract IKSolver.Point[] GetPoints();

		// Token: 0x0600022D RID: 557
		public abstract IKSolver.Point GetPoint(Transform transform);

		// Token: 0x0600022E RID: 558
		public abstract void FixTransforms();

		// Token: 0x0600022F RID: 559
		public abstract void StoreDefaultLocalState();

		// Token: 0x06000230 RID: 560
		protected abstract void OnInitiate();

		// Token: 0x06000231 RID: 561
		protected abstract void OnUpdate();

		// Token: 0x06000232 RID: 562 RVA: 0x00002661 File Offset: 0x00000861
		protected void LogWarning(string message)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002663 File Offset: 0x00000863
		public static Transform ContainsDuplicateBone(IKSolver.Bone[] bones)
		{
			return null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002666 File Offset: 0x00000866
		public static bool HierarchyIsValid(IKSolver.Bone[] bones)
		{
			return false;
		}

		// Token: 0x040001F2 RID: 498
		[HideInInspector]
		public Vector3 IKPosition;

		// Token: 0x040001F3 RID: 499
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		// Token: 0x040001F5 RID: 501
		public IKSolver.UpdateDelegate OnPreInitiate;

		// Token: 0x040001F6 RID: 502
		public IKSolver.UpdateDelegate OnPostInitiate;

		// Token: 0x040001F7 RID: 503
		public IKSolver.UpdateDelegate OnPreUpdate;

		// Token: 0x040001F8 RID: 504
		public IKSolver.UpdateDelegate OnPostUpdate;

		// Token: 0x040001F9 RID: 505
		protected bool firstInitiation;

		// Token: 0x040001FA RID: 506
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		// Token: 0x02000088 RID: 136
		[Serializable]
		public class Point
		{
			// Token: 0x06000497 RID: 1175 RVA: 0x00002D08 File Offset: 0x00000F08
			public void StoreDefaultLocalState()
			{
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x00002D0A File Offset: 0x00000F0A
			public void FixTransform()
			{
			}

			// Token: 0x0400042D RID: 1069
			public Transform transform;

			// Token: 0x0400042E RID: 1070
			[Range(0f, 1f)]
			public float weight;

			// Token: 0x0400042F RID: 1071
			public Vector3 solverPosition;

			// Token: 0x04000430 RID: 1072
			public Quaternion solverRotation;

			// Token: 0x04000431 RID: 1073
			public Vector3 defaultLocalPosition;

			// Token: 0x04000432 RID: 1074
			public Quaternion defaultLocalRotation;
		}

		// Token: 0x02000089 RID: 137
		[Serializable]
		public class Bone : IKSolver.Point
		{
			// Token: 0x17000068 RID: 104
			// (get) Token: 0x0600049A RID: 1178 RVA: 0x00002D14 File Offset: 0x00000F14
			public RotationLimit rotationLimit
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0600049B RID: 1179 RVA: 0x00002D17 File Offset: 0x00000F17
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			// Token: 0x0600049C RID: 1180 RVA: 0x00002D19 File Offset: 0x00000F19
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			// Token: 0x04000433 RID: 1075
			public float length;

			// Token: 0x04000434 RID: 1076
			public float sqrMag;

			// Token: 0x04000435 RID: 1077
			public Vector3 axis;

			// Token: 0x04000436 RID: 1078
			private RotationLimit _rotationLimit;

			// Token: 0x04000437 RID: 1079
			private bool isLimited;
		}

		// Token: 0x0200008A RID: 138
		[Serializable]
		public class Node : IKSolver.Point
		{
			// Token: 0x0600049E RID: 1182 RVA: 0x00002D23 File Offset: 0x00000F23
			public Node()
			{
			}

			// Token: 0x0600049F RID: 1183 RVA: 0x00002D2B File Offset: 0x00000F2B
			public Node(Transform transform)
			{
			}

			// Token: 0x04000438 RID: 1080
			public float length;

			// Token: 0x04000439 RID: 1081
			public float effectorPositionWeight;

			// Token: 0x0400043A RID: 1082
			public float effectorRotationWeight;

			// Token: 0x0400043B RID: 1083
			public Vector3 offset;
		}

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x060004A1 RID: 1185
		public delegate void UpdateDelegate();

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x060004A3 RID: 1187
		public delegate void IterationDelegate(int i);
	}
}
