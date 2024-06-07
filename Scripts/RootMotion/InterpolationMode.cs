using System;

namespace RootMotion
{
	// Token: 0x02000009 RID: 9
	[Serializable]
	public enum InterpolationMode
	{
		// Token: 0x0400002C RID: 44
		None,
		// Token: 0x0400002D RID: 45
		InOutCubic,
		// Token: 0x0400002E RID: 46
		InOutQuintic,
		// Token: 0x0400002F RID: 47
		InOutSine,
		// Token: 0x04000030 RID: 48
		InQuintic,
		// Token: 0x04000031 RID: 49
		InQuartic,
		// Token: 0x04000032 RID: 50
		InCubic,
		// Token: 0x04000033 RID: 51
		InQuadratic,
		// Token: 0x04000034 RID: 52
		InElastic,
		// Token: 0x04000035 RID: 53
		InElasticSmall,
		// Token: 0x04000036 RID: 54
		InElasticBig,
		// Token: 0x04000037 RID: 55
		InSine,
		// Token: 0x04000038 RID: 56
		InBack,
		// Token: 0x04000039 RID: 57
		OutQuintic,
		// Token: 0x0400003A RID: 58
		OutQuartic,
		// Token: 0x0400003B RID: 59
		OutCubic,
		// Token: 0x0400003C RID: 60
		OutInCubic,
		// Token: 0x0400003D RID: 61
		OutInQuartic,
		// Token: 0x0400003E RID: 62
		OutElastic,
		// Token: 0x0400003F RID: 63
		OutElasticSmall,
		// Token: 0x04000040 RID: 64
		OutElasticBig,
		// Token: 0x04000041 RID: 65
		OutSine,
		// Token: 0x04000042 RID: 66
		OutBack,
		// Token: 0x04000043 RID: 67
		OutBackCubic,
		// Token: 0x04000044 RID: 68
		OutBackQuartic,
		// Token: 0x04000045 RID: 69
		BackInCubic,
		// Token: 0x04000046 RID: 70
		BackInQuartic
	}
}
