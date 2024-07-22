using SLZ.Data;
using UnityEngine;

public class LightmapSwapper : MonoBehaviour
{
	public LightingDataGroup lighting_A;

	public LightingDataGroup lighting_B;

	private bool swaped;

	public MeshRenderer greenLamp;

	public MeshRenderer purpleLamp;

	public Material greenMat;

	public Material purpleMat;

	public Material offMat;

	public void SwapLightmaps()
	{
	}

	[ContextMenu("Mats On")]
	public void MatsOn()
	{
	}

	[ContextMenu("Mats Off")]
	public void MatsOff()
	{
	}

	private void Swapper(LightingDataGroup lightingDataGroup)
	{
	}
}
