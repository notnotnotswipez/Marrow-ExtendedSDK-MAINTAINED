using System;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Terrain))]
	public class PlatformTerrain : MonoBehaviour
	{
		[Serializable]
		public struct TerrainSettings
		{
			[Range(1f, 200f)]
			public float PixelError;

			[Range(1f, 20000f)]
			public float basemapDistance;
		}

		[SerializeField]
		private Terrain terrain;

		public TerrainSettings AndroidTerrainSettings;

		public TerrainSettings PCTerrainSettings;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
