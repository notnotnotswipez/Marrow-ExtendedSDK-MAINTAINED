using UnityEngine;

public class ApplyProceduralTextureProperties : MonoBehaviour
{
	[Space(5f)]
	public Material m_Material;

	[Space(5f)]
	public ProceduralTexture2D proceduralTexAssetAlbedo;

	public ProceduralTexture2D proceduralTexAssetNormal;

	public ProceduralTexture2D proceduralTexAssetMask;

	public void SyncMatWithProceduralTextureAsset()
	{
	}
}
