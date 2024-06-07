using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.VFX
{
	public class ParticleSpreadManager : MonoBehaviour
	{
		private class Info
		{
			public Vector3 normal;

			public Vector3 direction;

			public Vector3 reflect;

			public float spread;

			public string name;

			public Info(Vector3 normal, Vector3 direction, Vector3 reflect, float spread, string name)
			{
			}
		}

		private static ComponentCache<ParticleSpreadManager> _cache;

		public ParticleSpread[] particleSpreads;

		public ParticleSFX SoundEffect;

		private List<Info> infos;

		public static ComponentCache<ParticleSpreadManager> Cache => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void StartSound()
		{
		}

		public void AutoOrient(Vector3 normal, Vector3 direction)
		{
		}

		private void SetSettings(ParticleSpread particleSpread, Vector3 normal, Vector3 direction)
		{
		}
	}
}
