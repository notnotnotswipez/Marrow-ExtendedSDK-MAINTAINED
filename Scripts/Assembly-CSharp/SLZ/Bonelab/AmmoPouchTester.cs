using System.Collections.Generic;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AmmoPouchTester : MonoBehaviour
	{
		public Spawnable[] magazines;

		public CartridgeData cartridge;

		private List<Magazine> _magazineArts;

		private int _curMagIdx;

		private Spawnable _nextMagazine;

		private bool _isSwitching;

		private bool _hasMagazineInQueue;
	}
}
