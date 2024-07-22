using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace SLZ.Data
{
	[Serializable]
	[CreateAssetMenu(fileName = "LightingDataGroup", menuName = "Variables/LightingDataGroup")]
	public class LightingDataGroup : ScriptableObject
	{
		public SerializedDictionary<string, Texture2D> lightmapDir;

		public SerializedDictionary<string, Texture2D> lightmapColor;

		public Texture[] reflectionProbes;

		public SphericalHarmonicsL2[] bakedProbes;

		public Texture3D[] bakedFog;
	}
}
