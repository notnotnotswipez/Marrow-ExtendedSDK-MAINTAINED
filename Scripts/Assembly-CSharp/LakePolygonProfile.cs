using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "LakePolygonProfile", menuName = "LakePolygonProfile", order = 1)]
public class LakePolygonProfile : ScriptableObject
{
	public Material lakeMaterial;

	public float distSmooth;

	public float uvScale;

	public float maximumTriangleSize;

	public float traingleDensity;

	public bool receiveShadows;

	public ShadowCastingMode shadowCastingMode;

	public float automaticFlowMapScale;

	public bool noiseflowMap;

	public float noiseMultiplierflowMap;

	public float noiseSizeXflowMap;

	public float noiseSizeZflowMap;

	public AnimationCurve terrainCarve;

	public float terrainSmoothMultiplier;

	public AnimationCurve terrainPaintCarve;

	public bool noiseCarve;

	public float noiseMultiplierInside;

	public float noiseMultiplierOutside;

	public float noiseSizeX;

	public float noiseSizeZ;

	public int currentSplatMap;

	public bool noisePaint;

	public float noiseMultiplierInsidePaint;

	public float noiseMultiplierOutsidePaint;

	public float noiseSizeXPaint;

	public float noiseSizeZPaint;

	public bool mixTwoSplatMaps;

	public int secondSplatMap;

	public bool addCliffSplatMap;

	public int cliffSplatMap;

	public float cliffAngle;

	public float cliffBlend;

	public int cliffSplatMapOutside;

	public float cliffAngleOutside;

	public float cliffBlendOutside;

	public float distanceClearFoliage;

	public float distanceClearFoliageTrees;

	public int biomeType;
}
