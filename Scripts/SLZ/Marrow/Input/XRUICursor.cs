using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000166 RID: 358
	public class XRUICursor : MonoBehaviour, IUIInteractor
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x00008134 File Offset: 0x00006334
		private static TrackedDeviceModel _invalidTrackedDeviceModel
		{
			[CompilerGenerated]
			get
			{
				return default(TrackedDeviceModel);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0000814C File Offset: 0x0000634C
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x00004E02 File Offset: 0x00003002
		public Vector3 HitPoint
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00004E04 File Offset: 0x00003004
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x00004E07 File Offset: 0x00003007
		public bool IsHit
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

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00004E09 File Offset: 0x00003009
		protected void OnEnable()
		{
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00004E0B File Offset: 0x0000300B
		protected void OnDisable()
		{
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00004E0D File Offset: 0x0000300D
		public virtual void UpdateUIModel(ref TrackedDeviceModel model)
		{
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00004E0F File Offset: 0x0000300F
		public bool TryGetUIModel(out TrackedDeviceModel model)
		{
			model = default(TrackedDeviceModel);
			return false;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00004E19 File Offset: 0x00003019
		public void Click(bool isClicked)
		{
		}

		// Token: 0x040009D4 RID: 2516
		[SerializeField]
		private float _maxRaycastDistance;

		// Token: 0x040009D5 RID: 2517
		[SerializeField]
		private LayerMask _raycastMask;

		// Token: 0x040009D6 RID: 2518
		private bool _isClicked;

		// Token: 0x040009D7 RID: 2519
		private XRUIInputModule _inputModule;
	}

	public class TrackedDeviceModel
	{
	}

	public class XRUIInputModule
	{
	}

	public interface IUIInteractor
	{
	}
}
