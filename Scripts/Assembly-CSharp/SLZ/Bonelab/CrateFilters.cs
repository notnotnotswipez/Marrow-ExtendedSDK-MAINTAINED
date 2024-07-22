using System.Collections.Generic;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CrateFilters : MonoBehaviour
	{
		public class UnlockedNotUnlockableAndNotRedactedFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class UnlockableNotUnlockedAndNotRedactedFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class UnlockableAndNotRedactedCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class UnlockedAndNotRedactedCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class UnlockedCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class NonAvatarCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class NonRedactedCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class NonUnlockableCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class RedactedCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class UnlockableCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class BlackListCrateFilter : ICrateFilter<Crate>
		{
			private List<Barcode> blackList;

			public BlackListCrateFilter(List<Barcode> blackList)
			{
			}

			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class DevToolCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class FavoritesCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class GunCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		public class NPCCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return false;
			}
		}

		private static PlayerUnlocks u => null;

		private static PlayerSettings p => null;
	}
}
