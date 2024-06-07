using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_MoonBase : BonelabAvatarLevelGameControl
	{
		public bool overrideMoonGrav;

		private Vector3 _cachedGrav;

		private readonly Vector3 _moonGrav;

		private int _cur_location;

		public ConfigurableJoint jnt_launchTowerRotator;

		public ConfigurableJoint jnt_launchTowerPlate;

		public PowerSource[] pwr_effects;

		public override void DoLevelComplete()
		{
		}

		public override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		[ContextMenu("MoonMode")]
		public void MoonMode(bool moonGrav = true)
		{
		}

		public void Stepper()
		{
		}

		public void SetLauncher(int location = 0)
		{
		}
	}
}
