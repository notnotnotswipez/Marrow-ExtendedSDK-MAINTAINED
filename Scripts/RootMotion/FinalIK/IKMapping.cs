using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003C RID: 60
	[Serializable]
	public class IKMapping
	{
		// Token: 0x06000201 RID: 513 RVA: 0x000025EB File Offset: 0x000007EB
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return false;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000025EE File Offset: 0x000007EE
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000025F0 File Offset: 0x000007F0
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger = null)
		{
			return false;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00003644 File Offset: 0x00001844
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		// Token: 0x02000086 RID: 134
		[Serializable]
		public class BoneMap
		{
			// Token: 0x0600047E RID: 1150 RVA: 0x00002CD7 File Offset: 0x00000ED7
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600047F RID: 1151 RVA: 0x00003B34 File Offset: 0x00001D34
			public Vector3 swingDirection
			{
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x00002CD9 File Offset: 0x00000ED9
			public void StoreDefaultLocalState()
			{
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x00002CDB File Offset: 0x00000EDB
			public void FixTransform(bool position)
			{
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000482 RID: 1154 RVA: 0x00002CDD File Offset: 0x00000EDD
			public bool isNodeBone
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06000483 RID: 1155 RVA: 0x00002CE0 File Offset: 0x00000EE0
			public void SetLength(IKMapping.BoneMap nextBone)
			{
			}

			// Token: 0x06000484 RID: 1156 RVA: 0x00002CE2 File Offset: 0x00000EE2
			public void SetLocalSwingAxis(IKMapping.BoneMap swingTarget)
			{
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x00002CE4 File Offset: 0x00000EE4
			public void SetLocalSwingAxis(IKMapping.BoneMap bone1, IKMapping.BoneMap bone2)
			{
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x00002CE6 File Offset: 0x00000EE6
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			// Token: 0x06000487 RID: 1159 RVA: 0x00002CE8 File Offset: 0x00000EE8
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			// Token: 0x06000488 RID: 1160 RVA: 0x00002CEA File Offset: 0x00000EEA
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			// Token: 0x06000489 RID: 1161 RVA: 0x00002CEC File Offset: 0x00000EEC
			public void SetIKPosition()
			{
			}

			// Token: 0x0600048A RID: 1162 RVA: 0x00002CEE File Offset: 0x00000EEE
			public void MaintainRotation()
			{
			}

			// Token: 0x0600048B RID: 1163 RVA: 0x00002CF0 File Offset: 0x00000EF0
			public void SetToIKPosition()
			{
			}

			// Token: 0x0600048C RID: 1164 RVA: 0x00002CF2 File Offset: 0x00000EF2
			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = null)
			{
			}

			// Token: 0x0600048D RID: 1165 RVA: 0x00003B4C File Offset: 0x00001D4C
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			// Token: 0x0600048E RID: 1166 RVA: 0x00002CF4 File Offset: 0x00000EF4
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			// Token: 0x0600048F RID: 1167 RVA: 0x00002CF6 File Offset: 0x00000EF6
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			// Token: 0x06000490 RID: 1168 RVA: 0x00002CF8 File Offset: 0x00000EF8
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x00002CFA File Offset: 0x00000EFA
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			// Token: 0x06000492 RID: 1170 RVA: 0x00002CFC File Offset: 0x00000EFC
			public void RotateToMaintain(float weight)
			{
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x00002CFE File Offset: 0x00000EFE
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			// Token: 0x06000494 RID: 1172 RVA: 0x00003B64 File Offset: 0x00001D64
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000495 RID: 1173 RVA: 0x00003B7C File Offset: 0x00001D7C
			private Quaternion lastAnimatedTargetRotation
			{
				get
				{
					return default(Quaternion);
				}
			}

			// Token: 0x04000412 RID: 1042
			public Transform transform;

			// Token: 0x04000413 RID: 1043
			public int chainIndex;

			// Token: 0x04000414 RID: 1044
			public int nodeIndex;

			// Token: 0x04000415 RID: 1045
			public Vector3 defaultLocalPosition;

			// Token: 0x04000416 RID: 1046
			public Quaternion defaultLocalRotation;

			// Token: 0x04000417 RID: 1047
			public Vector3 localSwingAxis;

			// Token: 0x04000418 RID: 1048
			public Vector3 localTwistAxis;

			// Token: 0x04000419 RID: 1049
			public Vector3 planePosition;

			// Token: 0x0400041A RID: 1050
			public Vector3 ikPosition;

			// Token: 0x0400041B RID: 1051
			public Quaternion defaultLocalTargetRotation;

			// Token: 0x0400041C RID: 1052
			private Quaternion maintainRotation;

			// Token: 0x0400041D RID: 1053
			public float length;

			// Token: 0x0400041E RID: 1054
			public Quaternion animatedRotation;

			// Token: 0x0400041F RID: 1055
			private Transform planeBone1;

			// Token: 0x04000420 RID: 1056
			private Transform planeBone2;

			// Token: 0x04000421 RID: 1057
			private Transform planeBone3;

			// Token: 0x04000422 RID: 1058
			private int plane1ChainIndex;

			// Token: 0x04000423 RID: 1059
			private int plane1NodeIndex;

			// Token: 0x04000424 RID: 1060
			private int plane2ChainIndex;

			// Token: 0x04000425 RID: 1061
			private int plane2NodeIndex;

			// Token: 0x04000426 RID: 1062
			private int plane3ChainIndex;

			// Token: 0x04000427 RID: 1063
			private int plane3NodeIndex;
		}
	}
}
