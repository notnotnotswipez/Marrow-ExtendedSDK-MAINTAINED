using System;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class DiceResults : MonoBehaviour
	{
		[Serializable]
		public class DiceResultObject
		{
			public UnityEvent resultEvent;

			public Spawnable vfxSpawnable;

			public float sfxVolume;

			public AudioClip[] sfx;
		}

		public DiceResultObject[] resultObjects;

		public void Awake()
		{
		}

		public void RollComplete(int results)
		{
		}
	}
}
