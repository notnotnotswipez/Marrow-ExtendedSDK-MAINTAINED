using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using ILogger = UnityEngine.ILogger;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000106 RID: 262
	public static class MarrowLogger
	{
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x000042B8 File Offset: 0x000024B8
		private static ILoggerFactory _loggerFactory
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x000042BB File Offset: 0x000024BB
		[PublicAPI]
		public static ILogger Logger
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000042BE File Offset: 0x000024BE
		[PublicAPI]
		public static ILogger GetLogger<T>() where T : class
		{
			return null;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000042C1 File Offset: 0x000024C1
		[PublicAPI]
		public static ILogger GetLogger(string categoryName)
		{
			return null;
		}
	}

	internal interface ILoggerFactory
	{
	}
}
