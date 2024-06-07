using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class DebugCheats : MonoBehaviour
	{
		public UnityEvent cheatsOn;

		public UnityEvent cheatsOff;

		public GenericCrateReference crate_Nimbus;

		public GenericCrateReference crate_SpawnGun;

		private static PlayerProgression Progression => null;

		private static PlayerUnlocks u => null;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void DebugCheatModeStuff(bool shouldCheck = true)
		{
		}

		public void BIGCHEAT()
		{
		}
	}
}
