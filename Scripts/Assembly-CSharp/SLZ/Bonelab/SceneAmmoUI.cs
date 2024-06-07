using System;
using SLZ.Bonelab.SaveData;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SceneAmmoUI : MonoBehaviour
	{
		[Serializable]
		public struct SceneNames
		{
			public string prettyName;

			public string levelKey;

			public string levelTotalAmmo;
		}

		[Serializable]
		public struct TextFields
		{
			[SerializeField]
			public TextMeshProUGUI name;

			[SerializeField]
			public TextMeshProUGUI count;

			[SerializeField]
			public TextMeshProUGUI totalPossible;
		}

		public SceneNames[] scenesToList;

		public TextFields[] references;

		private Vector4[] ammoCounts;

		private bool[] displayLevel;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void updateBoard(PlayerProgression progression)
		{
		}

		private void updateAmmoCount(PlayerProgression progression, string _level, out Vector4 _ammoValues, out bool _isDisplayed)
		{
			_ammoValues = default(Vector4);
			_isDisplayed = default(bool);
		}

		private void updateTextFields()
		{
		}
	}
}
