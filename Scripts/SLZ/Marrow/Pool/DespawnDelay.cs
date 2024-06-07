using System;

namespace SLZ.Marrow.Pool
{
	// Token: 0x020000EE RID: 238
	public class DespawnDelay : SpawnEvents
	{
		// Token: 0x06000943 RID: 2371 RVA: 0x00004124 File Offset: 0x00002324
		public override void OnPoolInitialize()
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00004126 File Offset: 0x00002326
		private void Update()
		{
		}

		// Token: 0x040005F0 RID: 1520
		public float secondsUntilDisable;

		// Token: 0x040005F1 RID: 1521
		private float _timeEnabled;

		// Token: 0x040005F2 RID: 1522
		private bool _wasInitialize;
	}
}
