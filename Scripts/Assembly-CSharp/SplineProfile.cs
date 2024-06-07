using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "SplineProfile", menuName = "SplineProfile", order = 1)]
public class SplineProfile : ScriptableObject
{
	public Material splineMaterial;

	public AnimationCurve meshCurve;

	public float minVal;

	public float maxVal;

	public int vertsInShape;

	public float traingleDensity;

	public float uvScale;

	public bool uvRotation;

	public bool receiveShadows;

	public ShadowCastingMode shadowCastingMode;

	public AnimationCurve flowFlat;

	public AnimationCurve flowWaterfall;

	public bool noiseflowMap;

	public float noiseMultiplierflowMap;

	public float noiseSizeXflowMap;

	public float noiseSizeZflowMap;

	public float floatSpeed;

	public AnimationCurve terrainCarve;

	public float distSmooth;

	public float distSmoothStart;

	public AnimationCurve terrainPaintCarve;

	public LayerMask maskCarve;

	public bool noiseCarve;

	public float noiseMultiplierInside;

	public float noiseMultiplierOutside;

	public float noiseSizeX;

	public float noiseSizeZ;

	public float terrainSmoothMultiplier;

	public int currentSplatMap;

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

	public bool noisePaint;

	public float noiseMultiplierInsidePaint;

	public float noiseMultiplierOutsidePaint;

	public float noiseSizeXPaint;

	public float noiseSizeZPaint;

	public float simulatedRiverLength;

	public int simulatedRiverPoints;

	public float simulatedMinStepSize;

	public bool simulatedNoUp;

	public bool simulatedBreakOnUp;

	public bool noiseWidth;

	public float noiseMultiplierWidth;

	public float noiseSizeWidth;

	public int biomeType;
}
