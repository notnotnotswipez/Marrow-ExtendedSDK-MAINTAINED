using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using SLZ.Marrow.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow
{
	// Token: 0x02000018 RID: 24
	public class MarrowGameControl<TDataManager, TSave, TSettings, TProgression, TUnlocks, TResumePoint> : MonoBehaviour where TDataManager : MarrowDataManager<TDataManager, TSave, TSettings, TProgression, TUnlocks> where TSave : class, ISave<TProgression, TUnlocks>, new() where TSettings : class, ISettings, new() where TProgression : class, IProgression, new() where TUnlocks : class, IUnlocks, new() where TResumePoint : IResumePoint
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00002B88 File Offset: 0x00000D88
		public static void ThisLoadShouldResumeProgress()
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00002B8A File Offset: 0x00000D8A
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002B8D File Offset: 0x00000D8D
		private static bool ShouldResumeProgressForThisLoad
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00002B8F File Offset: 0x00000D8F
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002B92 File Offset: 0x00000D92
		[Tooltip("Name of the level in the save data")]
		public string LevelKey
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00002B94 File Offset: 0x00000D94
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002B97 File Offset: 0x00000D97
		[Tooltip("Mark level complete after level load")]
		public bool CompleteOnLoad
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00002B99 File Offset: 0x00000D99
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002B9C File Offset: 0x00000D9C
		public bool EnableSavingCompletion
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00002B9E File Offset: 0x00000D9E
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002BA1 File Offset: 0x00000DA1
		public bool EnableSavingPartialProgress
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002BA3 File Offset: 0x00000DA3
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002BA6 File Offset: 0x00000DA6
		[Tooltip("Crate reference to the loading screen level")]
		public LevelCrateReference LoadScreenLevel
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00002BA8 File Offset: 0x00000DA8
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002BAB File Offset: 0x00000DAB
		[Tooltip("Crate references to levels to possibly load")]
		public List<LevelCrateReference> LevelJumpList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00002BAD File Offset: 0x00000DAD
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002BB0 File Offset: 0x00000DB0
		protected List<TResumePoint> ProgressionPoint
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00002BB2 File Offset: 0x00000DB2
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002BB5 File Offset: 0x00000DB5
		public List<RegisteredSaveableInfo> RegisteredSaveables
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00002BB7 File Offset: 0x00000DB7
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002BBA File Offset: 0x00000DBA
		public int Progress
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00002BBC File Offset: 0x00000DBC
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002BBF File Offset: 0x00000DBF
		public bool IsResumingFromProgress
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002BC1 File Offset: 0x00000DC1
		public virtual void Awake()
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002BC3 File Offset: 0x00000DC3
		public virtual void Start()
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002BC5 File Offset: 0x00000DC5
		private void TeleportToProgress()
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002BC7 File Offset: 0x00000DC7
		private protected virtual void OnLevelResumingFromProgress()
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002BC9 File Offset: 0x00000DC9
		private protected virtual void OnLevelLoaded()
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002BCB File Offset: 0x00000DCB
		[PublicAPI]
		public void SetCompleted()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002BCD File Offset: 0x00000DCD
		[PublicAPI]
		public void SetProgress(int progress)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002BCF File Offset: 0x00000DCF
		[PublicAPI]
		public void JustSave()
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002BD1 File Offset: 0x00000DD1
		[PublicAPI]
		public void JustJumpToLevelAtIndex(int levelIndex = 0)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002BD3 File Offset: 0x00000DD3
		[PublicAPI]
		public void FinalizeThenJumpToLevelAtIndex(int levelIndex = 0)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002BD5 File Offset: 0x00000DD5
		private protected virtual void PerformJump(int levelIndex)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002BD7 File Offset: 0x00000DD7
		private protected virtual void OnLevelProgressSet()
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002BD9 File Offset: 0x00000DD9
		private protected virtual void OnLevelFinalize()
		{
		}
	}
}
