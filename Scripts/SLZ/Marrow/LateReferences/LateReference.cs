using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.LateReferences
{
	// Token: 0x0200012A RID: 298
	public abstract class LateReference : ISerializationCallbackReceiver
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00004456 File Offset: 0x00002656
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00004459 File Offset: 0x00002659
		public string StaticType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private protected set
			{
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x0000445B File Offset: 0x0000265B
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x0000445E File Offset: 0x0000265E
		public string DynamicType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private protected set
			{
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00004460 File Offset: 0x00002660
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x00004463 File Offset: 0x00002663
		public string UniqueId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00004465 File Offset: 0x00002665
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00004468 File Offset: 0x00002668
		public bool ReferenceLinked
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private protected set
			{
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000A73 RID: 2675
		// (set) Token: 0x06000A74 RID: 2676
		public abstract UnityEngine.Object InternalObject { get; set; }

		// Token: 0x06000A75 RID: 2677
		public abstract void OnBeforeSerialize();

		// Token: 0x06000A76 RID: 2678
		public abstract void OnAfterDeserialize();

		// Token: 0x06000A77 RID: 2679
		public abstract void LateReferenceDidLink(ExportTable exportTable, UnityEngine.Object obj);

		// Token: 0x06000A78 RID: 2680
		public abstract Type GetStaticType();
	}
}
