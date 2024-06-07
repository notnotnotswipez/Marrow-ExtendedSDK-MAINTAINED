using System;
using System.Runtime.CompilerServices;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.LateReferences
{
	// Token: 0x0200012B RID: 299
	[Serializable]
	public class LateReference<T> : LateReference where T : UnityEngine.Object
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x00007B4C File Offset: 0x00005D4C
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x00004472 File Offset: 0x00002672
		public T Object
		{
			[CompilerGenerated]
			get
			{
				return default(T);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x00004474 File Offset: 0x00002674
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x00004477 File Offset: 0x00002677
		public UltEvent<ExportTable, LateReference> OnLateReferenceLinked
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

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00004479 File Offset: 0x00002679
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x0000447C File Offset: 0x0000267C
		[Obsolete("For internal use. Use Object instead")]
		public override UnityEngine.Object InternalObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0000447E File Offset: 0x0000267E
		public override void OnBeforeSerialize()
		{
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00004480 File Offset: 0x00002680
		public override void OnAfterDeserialize()
		{
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00004482 File Offset: 0x00002682
		public override void LateReferenceDidLink(ExportTable exportTable, UnityEngine.Object obj)
		{
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00004484 File Offset: 0x00002684
		public override Type GetStaticType()
		{
			return null;
		}
	}
}
