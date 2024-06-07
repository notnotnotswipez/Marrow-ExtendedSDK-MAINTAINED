using System;
using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000151 RID: 337
	public sealed class HandActionMap : XRHand
	{
		// Token: 0x06000CC1 RID: 3265 RVA: 0x00004AD2 File Offset: 0x00002CD2
		public HandActionMap(bool left)
		{
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00004ADA File Offset: 0x00002CDA
		private bool TryPickBestHandDevice(bool left)
		{
			return false;
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00004ADD File Offset: 0x00002CDD
		public override void OnPostNewInputUpdate()
		{
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00004ADF File Offset: 0x00002CDF
		private bool CopyPoseToBuffer(Bone bone, HandBone handBone)
		{
			return false;
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00004AE2 File Offset: 0x00002CE2
		private void ProcessesHand()
		{
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00004AE4 File Offset: 0x00002CE4
		private void CalcLocalPose(HandBone parentBone, HandBone childBone)
		{
		}

		// Token: 0x040007A7 RID: 1959
		private Dictionary<HandFinger, List<Bone>> _bones;

		// Token: 0x040007A8 RID: 1960
		private readonly bool _isLeft;

		// Token: 0x040007A9 RID: 1961
		private bool _hasFeature;

		// Token: 0x040007AA RID: 1962
		public static Quaternion LeftAnimSpace;

		// Token: 0x040007AB RID: 1963
		public static Quaternion RightAnimSpace;

		// Token: 0x040007AC RID: 1964
		private readonly SimpleTransform[] _worldBuffer;

		// Token: 0x040007AD RID: 1965
		private readonly List<Bone> _indexFinger;

		// Token: 0x040007AE RID: 1966
		private readonly List<Bone> _middleFinger;

		// Token: 0x040007AF RID: 1967
		private readonly List<Bone> _pinkyFinger;

		// Token: 0x040007B0 RID: 1968
		private readonly List<Bone> _ringFinger;

		// Token: 0x040007B1 RID: 1969
		private readonly List<Bone> _thumbFinger;

		// Token: 0x040007B2 RID: 1970
		private Hand _hand;
	}
}
