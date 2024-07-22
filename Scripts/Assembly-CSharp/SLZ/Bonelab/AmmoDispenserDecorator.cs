using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AmmoDispenserDecorator : SpawnDecorator
	{
		[Header("Default dispenser is infinite, single dispense")]
		public bool infiniteLight;

		public bool infiniteMedium;

		public bool infiniteHeavy;

		public int countLight;

		public int countMedium;

		public int countHeavy;

		public bool rateSingle;


		private void SetUpDispenser(AmmoDispenser aD)
		{
		}
	}
}
