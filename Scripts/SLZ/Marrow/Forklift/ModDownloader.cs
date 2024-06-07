using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;
using SLZ.Marrow.Forklift.Model;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Forklift
{
	// Token: 0x0200017C RID: 380
	[PublicAPI]
	public static class ModDownloader
	{
		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00004F28 File Offset: 0x00003128
		public static bool VerboseLogging
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00004F2B File Offset: 0x0000312B
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x00004F2E File Offset: 0x0000312E
		public static ModIOManager ModIOManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x000081C4 File Offset: 0x000063C4
		public static UniTask LoadModSettings()
		{
			return default(UniTask);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00004F30 File Offset: 0x00003130
		public static Dictionary<long, long> GetInvalidMods()
		{
			return null;
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x000081DC File Offset: 0x000063DC
		public static UniTask AddInvalidModFile(long modID, long fileID, CancellationToken cancelToken)
		{
			return default(UniTask);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000081F4 File Offset: 0x000063F4
		public static UniTask RemoveInvalidModFile(long modID, CancellationToken cancelToken)
		{
			return default(UniTask);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0000820C File Offset: 0x0000640C
		public static UniTask WriteModSettings()
		{
			return default(UniTask);
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00004F33 File Offset: 0x00003133
		private static string ModSettingsPath
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00008224 File Offset: 0x00006424
		public static UniTask<Pallet> DownloadMod(ModListing listing, ModTarget target, [CanBeNull] IProgress<FileDownloadProgress> progress, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Pallet>);
		}


		// Token: 0x04000A00 RID: 2560
		private const bool SPAMMY_UPDATES = false;

		// Token: 0x04000A01 RID: 2561
		private const bool STRICT_VERSION_EQUALITY_CHECK = false;

		// Token: 0x04000A02 RID: 2562
		[CanBeNull]
		private static JObject ModSettingsJSON;

		// Token: 0x04000A03 RID: 2563
		private static Dictionary<long, long> invalidMods;
	}
}
