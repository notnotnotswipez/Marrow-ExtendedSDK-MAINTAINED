using JetBrains.Annotations;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class DataManager : MarrowDataManager<DataManager, Save, Settings, PlayerSettings, PlayerProgression, PlayerUnlocks>
	{
        public DataManager(int settingsVersion, int saveVersion) : base(settingsVersion, saveVersion)
        {
        }

        [PublicAPI]
		public static DataManager Instance => null;

		public static Settings Settings => null;

		public static Save ActiveSave => null;
		

		public new static bool TrySaveSettings()
		{
			return false;
		}

		public new static bool TryLoadActiveSave(SaveFlags flags)
		{
			return false;
		}

		public new static bool TrySaveActiveSave(SaveFlags flags)
		{
			return false;
		}

		public new static bool TryAutosaveAndSetActive(Save save, SaveFlags flags)
		{
			return false;
		}

		public static void MSAFAIGE()
		{
		}

		private void _MSAFAIGE()
		{
		}
	}
}
