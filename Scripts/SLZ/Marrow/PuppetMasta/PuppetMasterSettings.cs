using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000EA RID: 234
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/PuppetMaster Settings")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x000040BC File Offset: 0x000022BC
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x000040BF File Offset: 0x000022BF
		public int currentlyActivePuppets
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x000040C1 File Offset: 0x000022C1
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x000040C4 File Offset: 0x000022C4
		public int currentlyKinematicPuppets
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x000040C6 File Offset: 0x000022C6
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x000040C9 File Offset: 0x000022C9
		public int currentlyDisabledPuppets
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x000040CB File Offset: 0x000022CB
		public List<PuppetMaster> puppets
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x000040CE File Offset: 0x000022CE
		public void Register(PuppetMaster puppetMaster)
		{
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x000040D0 File Offset: 0x000022D0
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000040D2 File Offset: 0x000022D2
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return false;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000040D5 File Offset: 0x000022D5
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return false;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000040D8 File Offset: 0x000022D8
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return false;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000040DB File Offset: 0x000022DB
		private void Update()
		{
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000040DD File Offset: 0x000022DD
		private void FixedUpdate()
		{
		}

		// Token: 0x040005D6 RID: 1494
		[Header("Optimizations")]
		public PuppetMasterSettings.PuppetUpdateLimit kinematicCollidersUpdateLimit;

		// Token: 0x040005D7 RID: 1495
		public PuppetMasterSettings.PuppetUpdateLimit freeUpdateLimit;

		// Token: 0x040005D8 RID: 1496
		public PuppetMasterSettings.PuppetUpdateLimit fixedUpdateLimit;

		// Token: 0x040005D9 RID: 1497
		public bool collisionStayMessages;

		// Token: 0x040005DA RID: 1498
		public bool collisionExitMessages;

		// Token: 0x040005DB RID: 1499
		public float activePuppetCollisionThresholdMlp;

		// Token: 0x040005DF RID: 1503
		private List<PuppetMaster> _puppets;

		// Token: 0x02000253 RID: 595
		[Serializable]
		public class PuppetUpdateLimit
		{
			// Token: 0x0600115E RID: 4446 RVA: 0x00005798 File Offset: 0x00003998
			public void Step(int puppetCount)
			{
			}

			// Token: 0x0600115F RID: 4447 RVA: 0x0000579A File Offset: 0x0000399A
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return false;
			}

			// Token: 0x04000F09 RID: 3849
			[Range(1f, 100f)]
			public int puppetsPerFrame;

			// Token: 0x04000F0A RID: 3850
			private int index;
		}
	}

	public class Singleton<T>
	{
	}
}
