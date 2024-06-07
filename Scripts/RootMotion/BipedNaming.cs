using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000004 RID: 4
	public static class BipedNaming
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002060 File Offset: 0x00000260
		public static Transform[] GetBonesOfType(BipedNaming.BoneType boneType, Transform[] bones)
		{
			return null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002063 File Offset: 0x00000263
		public static Transform[] GetBonesOfSide(BipedNaming.BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		public static Transform[] GetBonesOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002069 File Offset: 0x00000269
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000310C File Offset: 0x0000130C
		public static BipedNaming.BoneType GetBoneType(string boneName)
		{
			return BipedNaming.BoneType.Unassigned;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00003124 File Offset: 0x00001324
		public static BipedNaming.BoneSide GetBoneSide(string boneName)
		{
			return BipedNaming.BoneSide.Center;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000206C File Offset: 0x0000026C
		public static Transform GetBone(Transform[] transforms, BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide = BipedNaming.BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000206F File Offset: 0x0000026F
		private static bool isLeft(string boneName)
		{
			return false;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002072 File Offset: 0x00000272
		private static bool isRight(string boneName)
		{
			return false;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002075 File Offset: 0x00000275
		private static bool isSpine(string boneName)
		{
			return false;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002078 File Offset: 0x00000278
		private static bool isHead(string boneName)
		{
			return false;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000207B File Offset: 0x0000027B
		private static bool isArm(string boneName)
		{
			return false;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000207E File Offset: 0x0000027E
		private static bool isLeg(string boneName)
		{
			return false;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002081 File Offset: 0x00000281
		private static bool isTail(string boneName)
		{
			return false;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002084 File Offset: 0x00000284
		private static bool isEye(string boneName)
		{
			return false;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002087 File Offset: 0x00000287
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return false;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000208A File Offset: 0x0000028A
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return false;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000208D File Offset: 0x0000028D
		private static string firstLetter(string boneName)
		{
			return null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002090 File Offset: 0x00000290
		private static string lastLetter(string boneName)
		{
			return null;
		}

		// Token: 0x04000005 RID: 5
		public static string[] typeLeft;

		// Token: 0x04000006 RID: 6
		public static string[] typeRight;

		// Token: 0x04000007 RID: 7
		public static string[] typeSpine;

		// Token: 0x04000008 RID: 8
		public static string[] typeHead;

		// Token: 0x04000009 RID: 9
		public static string[] typeArm;

		// Token: 0x0400000A RID: 10
		public static string[] typeLeg;

		// Token: 0x0400000B RID: 11
		public static string[] typeTail;

		// Token: 0x0400000C RID: 12
		public static string[] typeEye;

		// Token: 0x0400000D RID: 13
		public static string[] typeExclude;

		// Token: 0x0400000E RID: 14
		public static string[] typeExcludeSpine;

		// Token: 0x0400000F RID: 15
		public static string[] typeExcludeHead;

		// Token: 0x04000010 RID: 16
		public static string[] typeExcludeArm;

		// Token: 0x04000011 RID: 17
		public static string[] typeExcludeLeg;

		// Token: 0x04000012 RID: 18
		public static string[] typeExcludeTail;

		// Token: 0x04000013 RID: 19
		public static string[] typeExcludeEye;

		// Token: 0x04000014 RID: 20
		public static string[] pelvis;

		// Token: 0x04000015 RID: 21
		public static string[] hand;

		// Token: 0x04000016 RID: 22
		public static string[] foot;

		// Token: 0x02000071 RID: 113
		[Serializable]
		public enum BoneType
		{
			// Token: 0x04000397 RID: 919
			Unassigned,
			// Token: 0x04000398 RID: 920
			Spine,
			// Token: 0x04000399 RID: 921
			Head,
			// Token: 0x0400039A RID: 922
			Arm,
			// Token: 0x0400039B RID: 923
			Leg,
			// Token: 0x0400039C RID: 924
			Tail,
			// Token: 0x0400039D RID: 925
			Eye
		}

		// Token: 0x02000072 RID: 114
		[Serializable]
		public enum BoneSide
		{
			// Token: 0x0400039F RID: 927
			Center,
			// Token: 0x040003A0 RID: 928
			Left,
			// Token: 0x040003A1 RID: 929
			Right
		}
	}
}
