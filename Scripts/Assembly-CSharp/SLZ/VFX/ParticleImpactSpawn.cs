using System;
using System.Collections.Generic;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.VFX
{
	[RequireComponent(typeof(ParticleSystem))]
	public class ParticleImpactSpawn : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem PS;

		public Spawnable spawnable;

		public float Scaler;

		public float Scaler2;

		private List<ParticleCollisionEvent> collisionEvents;

		private Action<GameObject> _onParticleSpawnCallback;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnParticleSpawn(GameObject go)
		{
		}

		private void OnParticleCollision(GameObject Other)
		{
		}
	}
}
