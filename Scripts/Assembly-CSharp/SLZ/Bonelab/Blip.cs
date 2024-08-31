using System;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Blip : SpawnEvents
	{
		public static ComponentCache<Blip> Cache
		{
			get
			{
				return null;
			}
		}

		public void CallSpawnEffect()
		{
		}

		public void CallDespawnEffect()
		{
		}

		public Blip()
		{
		}

		private static ComponentCache<Blip> _cache;

		[SerializeField]
		private Renderer[] Renderers;

		[Tooltip("Multi-Rigidbody setups will bypass the preview mesh and use the skinmesh, mesh, or colliders. Checking this forces the use of the preview mesh if possible")]
		public bool ForceUsePreviewMesh;

		public SpawnableCrate ThisCrate;

		public MarrowEntity ThisEntity;

		[SerializeField]
		private Spawnable fizzlerSpawnable;

		[SerializeField]
		private Spawnable spawnSpawnable;

		[HideInInspector]
		[Header("DO NOT SET IN INSPECTOR")]
		public Vector3 velocity;

		private bool isDestructible;

		[HideInInspector]
		[Header("DO NOT SET IN INSPECTOR")]
		public bool forceBlip;

		private bool sfxPlayed;
	}
}
