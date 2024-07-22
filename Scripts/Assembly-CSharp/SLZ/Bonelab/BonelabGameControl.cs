using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BonelabGameControl : MonoBehaviour
	{
		public static readonly LevelCrateReference HubLevel;

		protected bool _isLoadCalled;

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

		[Tooltip("Does this level save completion/progress/ammo/inventory?")]
		public SaveFeatures SaveFeatures
		{
			[CompilerGenerated]
			get
			{
				return default(SaveFeatures);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Tooltip("Crate reference to a fadeout VFX override, if any")]
		public SpawnableCrateReference FadeoutVFXOverride
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

		protected List<string> PriorLevels
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

		protected string NextLevel
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

		protected List<ResumePoint> ProgressionPoint
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

		public InventorySaveFilter InventorySaveFilter
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

		public bool IsResuming
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

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public void TeleportToProgress()
		{
		}

		private void ResumeProgress()
		{
		}

		public void SetCompleted()
		{
		}

		public void SetProgress(int progress)
		{
		}

		public void FinalizeInventory()
		{
		}

		public void JustSave()
		{
		}

		public void JustJumpToLevelAtIndex(int levelIndex = 0)
		{
		}

		public void FinalizeThenJumpToLevelAtIndex(int levelIndex = 0)
		{
		}
	}
}
