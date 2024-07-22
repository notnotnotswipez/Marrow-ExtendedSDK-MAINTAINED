using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000051 RID: 81
	[Serializable]
	public class InteractionEffector
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000314 RID: 788 RVA: 0x000038A4 File Offset: 0x00001AA4
		// (set) Token: 0x06000315 RID: 789 RVA: 0x000028BD File Offset: 0x00000ABD
		public FullBodyBipedEffector effectorType
		{
			[CompilerGenerated]
			get
			{
				return FullBodyBipedEffector.Body;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000316 RID: 790 RVA: 0x000028BF File Offset: 0x00000ABF
		// (set) Token: 0x06000317 RID: 791 RVA: 0x000028C2 File Offset: 0x00000AC2
		public bool isPaused
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

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000318 RID: 792 RVA: 0x000028C4 File Offset: 0x00000AC4
		// (set) Token: 0x06000319 RID: 793 RVA: 0x000028C7 File Offset: 0x00000AC7
		public InteractionObject interactionObject
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600031A RID: 794 RVA: 0x000028C9 File Offset: 0x00000AC9
		public bool inInteraction
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000028CC File Offset: 0x00000ACC
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000028D4 File Offset: 0x00000AD4
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000028D6 File Offset: 0x00000AD6
		private void StoreDefaults()
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000028D8 File Offset: 0x00000AD8
		public bool ResetToDefaults(float speed)
		{
			return false;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000028DB File Offset: 0x00000ADB
		public bool Pause()
		{
			return false;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000028DE File Offset: 0x00000ADE
		public bool Resume()
		{
			return false;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000028E1 File Offset: 0x00000AE1
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return false;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000028E4 File Offset: 0x00000AE4
		public void Update(Transform root, float speed)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000323 RID: 803 RVA: 0x000028E6 File Offset: 0x00000AE6
		public float progress
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000028ED File Offset: 0x00000AED
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
			pickUp = default(bool);
			pause = default(bool);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000028FD File Offset: 0x00000AFD
		private void PickUp(Transform root)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000028FF File Offset: 0x00000AFF
		public bool Stop()
		{
			return false;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002902 File Offset: 0x00000B02
		public void OnPostFBBIK()
		{
		}

		// Token: 0x040002AC RID: 684
		private Poser poser;

		// Token: 0x040002AD RID: 685
		private IKEffector effector;

		// Token: 0x040002AE RID: 686
		private float timer;

		// Token: 0x040002AF RID: 687
		private float length;

		// Token: 0x040002B0 RID: 688
		private float weight;

		// Token: 0x040002B1 RID: 689
		private float fadeInSpeed;

		// Token: 0x040002B2 RID: 690
		private float defaultPositionWeight;

		// Token: 0x040002B3 RID: 691
		private float defaultRotationWeight;

		// Token: 0x040002B4 RID: 692
		private float defaultPull;

		// Token: 0x040002B5 RID: 693
		private float defaultReach;

		// Token: 0x040002B6 RID: 694
		private float defaultPush;

		// Token: 0x040002B7 RID: 695
		private float defaultPushParent;

		// Token: 0x040002B8 RID: 696
		private float resetTimer;

		// Token: 0x040002B9 RID: 697
		private bool positionWeightUsed;

		// Token: 0x040002BA RID: 698
		private bool rotationWeightUsed;

		// Token: 0x040002BB RID: 699
		private bool pullUsed;

		// Token: 0x040002BC RID: 700
		private bool reachUsed;

		// Token: 0x040002BD RID: 701
		private bool pushUsed;

		// Token: 0x040002BE RID: 702
		private bool pushParentUsed;

		// Token: 0x040002BF RID: 703
		private bool pickedUp;

		// Token: 0x040002C0 RID: 704
		private bool defaults;

		// Token: 0x040002C1 RID: 705
		private bool pickUpOnPostFBBIK;

		// Token: 0x040002C2 RID: 706
		private Vector3 pickUpPosition;

		// Token: 0x040002C3 RID: 707
		private Vector3 pausePositionRelative;

		// Token: 0x040002C4 RID: 708
		private Quaternion pickUpRotation;

		// Token: 0x040002C5 RID: 709
		private Quaternion pauseRotationRelative;

		// Token: 0x040002C6 RID: 710
		private InteractionTarget interactionTarget;

		// Token: 0x040002C7 RID: 711
		private Transform target;

		// Token: 0x040002C8 RID: 712
		private List<bool> triggered;

		// Token: 0x040002C9 RID: 713
		private InteractionSystem interactionSystem;

		// Token: 0x040002CA RID: 714
		private bool started;
	}
}
