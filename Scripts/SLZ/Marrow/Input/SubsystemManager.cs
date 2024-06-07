using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	// Token: 0x0200015A RID: 346
	public class SubsystemManager<TIntegratedSubsystem, TIntegratedSubsystemDescriptor> where TIntegratedSubsystem : IntegratedSubsystem where TIntegratedSubsystemDescriptor : IntegratedSubsystemDescriptor
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x00007F6C File Offset: 0x0000616C
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x00004B66 File Offset: 0x00002D66
		public TIntegratedSubsystem ActiveSubsystem
		{
			get
			{
				return default(TIntegratedSubsystem);
			}
			private set
			{
			}
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00004B70 File Offset: 0x00002D70
		public bool IsValid()
		{
			return false;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00007F84 File Offset: 0x00006184
		public TIntegratedSubsystem GetCurrentSubsystem()
		{
			return default(TIntegratedSubsystem);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00004B73 File Offset: 0x00002D73
		public string ListActiveSubsystems()
		{
			return null;
		}

		// Token: 0x040008F2 RID: 2290
		private readonly List<TIntegratedSubsystem> _displaySubsystems;

		// Token: 0x040008F3 RID: 2291
		private readonly List<TIntegratedSubsystemDescriptor> _displaySubsystemDescriptors;

		// Token: 0x040008F4 RID: 2292
		private TIntegratedSubsystem _activeSubsystem;
	}
}
