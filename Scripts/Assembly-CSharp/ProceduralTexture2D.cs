using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "New Procedural Texture 2D", menuName = null, order = 1)]
public class ProceduralTexture2D : ScriptableObject
{
	public enum TextureType
	{
		Color,
		Normal = 1,
		Other = 2
	}

	public enum CompressionLevel
	{
		None = -1,
		LowQuality = 0,
		NormalQuality = 50,
		HighQuality = 100
	}

	public Texture2D input;

	public TextureType type;

	public bool includeAlpha;

	public bool generateMipMaps;

	public FilterMode filterMode;

	public int anisoLevel;

	public CompressionLevel compressionQuality;

	public Texture2D Tinput;

	public Texture2D invT;

	public Vector3 colorSpaceOrigin;

	public Vector3 colorSpaceVector1;

	public Vector3 colorSpaceVector2;

	public Vector3 colorSpaceVector3;

	public Vector4 compressionScalers;

	public long memoryUsageBytes;

	public Texture2D currentInput;

	public TextureType currentType;

	public bool currentIncludeAlpha;

	public bool currentGenerateMipMaps;

	public FilterMode currentFilterMode;

	public int currentAnisoLevel;

	public CompressionLevel currentCompressionQuality;
}
