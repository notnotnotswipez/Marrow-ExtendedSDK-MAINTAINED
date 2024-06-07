using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;
using SLZ.Marrow.Forklift.Model;

namespace SLZ.Marrow.Forklift
{
	// Token: 0x02000180 RID: 384
	public static class ModRepositoryWorkflow
	{
		// Token: 0x06000E7B RID: 3707 RVA: 0x00004FBF File Offset: 0x000031BF
		[PublicAPI]
		public static bool TryParseRepository(JObject repositoryJson, out ModRepository repo)
		{
			repo = null;
			return false;
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x000082CC File Offset: 0x000064CC
		[PublicAPI]
		public static UniTask<ModRepository[]> FetchRepositoriesAsync(string parent)
		{
			return default(UniTask<ModRepository[]>);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x000082E4 File Offset: 0x000064E4
		[PublicAPI]
		public static UniTask<List<ValueTuple<int, Uri>>> ReadValidUrlsAsync(string repositoriesList)
		{
			return default(UniTask<List<ValueTuple<int, Uri>>>);
		}

	}
}
