using System;

namespace SLZ.Marrow.Zones
{
	// Token: 0x0200002C RID: 44
	internal interface IDisableCallbackHandler
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000229 RID: 553
		bool IsActiveSelf { get; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600022A RID: 554
		bool AllowDisableOnCull { get; }

		// Token: 0x0600022B RID: 555
		void SetActive(bool isActive);

		// Token: 0x0600022C RID: 556
		void OnDisableStateChanged(DisableTypes type, bool isDisabled);

		// Token: 0x0600022D RID: 557
		void OnHide();

		// Token: 0x0600022E RID: 558
		void OnShow();

		// Token: 0x0600022F RID: 559
		void OnCull();

		// Token: 0x06000230 RID: 560
		void OnUncull();

		// Token: 0x06000231 RID: 561
		void OnDespawn();

		// Token: 0x06000232 RID: 562
		void OnSpawn();
	}
}
