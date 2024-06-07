using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace SLZ.Marrow.Forklift.Model
{
	// Token: 0x02000187 RID: 391
	public static class ModTargetResolver
	{
		// Token: 0x06000EB2 RID: 3762 RVA: 0x00005062 File Offset: 0x00003262
		[PublicAPI]
		public static void SetModTargetPreferenceOrder(params string[] targetNames)
		{
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00005064 File Offset: 0x00003264
		[PublicAPI]
		public static bool TrySelectModTarget<TModTarget>(ModListing mod, out string targetName, out TModTarget modTarget) where TModTarget : ModTarget
		{
			targetName = null;
			modTarget = default(TModTarget);
			return false;
		}

		// Token: 0x04000A26 RID: 2598
		private static List<string> _targetPreferenceOrder;
	}
}
