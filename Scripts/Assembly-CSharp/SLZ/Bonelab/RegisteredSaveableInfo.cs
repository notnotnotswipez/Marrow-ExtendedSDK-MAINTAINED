using System;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class RegisteredSaveableInfo
	{
		[ReadOnly(false)]
		[SerializeField]
		private Saveable _saveable;

		[SerializeField]
		[ReadOnly(false)]
		private string _uniqueId;

		public Saveable Saveable => null;

		public string UniqueId => null;

		public RegisteredSaveableInfo(string uniqueId, Saveable saveable)
		{
		}
	}
}
