using UnityEngine;

namespace SLZ.Bonelab
{
	[ExecuteInEditMode]
	public class TempTextureRef : MonoBehaviour
	{
		[SerializeField]
		private Texture2DArray NoiseTextureArray;

		[SerializeField]
		private Texture2DArray iconArray;

		private int NoiseID;

		private int NoisePixels;

		private int currentTex;

		private int arraySize;

		private void Update()
		{
		}

		private void Awake()
		{
		}

		private void AssignNoiseTexture()
		{
		}

		private void NextNoise()
		{
		}
	}
}
