using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(MeshFilter))]
public class RamSpline : MonoBehaviour
{
	public SplineProfile currentProfile;

	public SplineProfile oldProfile;

	public List<RamSpline> beginnigChildSplines;

	public List<RamSpline> endingChildSplines;

	public RamSpline beginningSpline;

	public RamSpline endingSpline;

	public int beginningConnectionID;

	public int endingConnectionID;

	public float beginningMinWidth;

	public float beginningMaxWidth;

	public float endingMinWidth;

	public float endingMaxWidth;

	public int toolbarInt;

	public bool invertUVDirection;

	public bool uvRotation;

	public MeshFilter meshfilter;

	public List<Vector4> controlPoints;

	public List<Quaternion> controlPointsRotations;

	public List<Quaternion> controlPointsOrientation;

	public List<Vector3> controlPointsUp;

	public List<Vector3> controlPointsDown;

	public List<float> controlPointsSnap;

	public AnimationCurve meshCurve;

	public List<AnimationCurve> controlPointsMeshCurves;

	public bool normalFromRaycast;

	public bool snapToTerrain;

	public LayerMask snapMask;

	public List<Vector3> points;

	public List<Vector3> pointsUp;

	public List<Vector3> pointsDown;

	public List<Vector3> points2;

	public List<Vector3> verticesBeginning;

	public List<Vector3> verticesEnding;

	public List<Vector3> normalsBeginning;

	public List<Vector3> normalsEnding;

	public List<float> widths;

	public List<float> snaps;

	public List<float> lerpValues;

	public List<Quaternion> orientations;

	public List<Vector3> tangents;

	public List<Vector3> normalsList;

	public Color[] colors;

	public List<Vector2> colorsFlowMap;

	public List<Vector3> verticeDirection;

	public float floatSpeed;

	public bool generateOnStart;

	public float minVal;

	public float maxVal;

	public float width;

	public int vertsInShape;

	public float traingleDensity;

	public float uvScale;

	public Material oldMaterial;

	public bool showVertexColors;

	public bool showFlowMap;

	public bool overrideFlowMap;

	public bool drawOnMesh;

	public bool drawOnMeshFlowMap;

	public bool uvScaleOverride;

	public bool debug;

	public bool debugNormals;

	public bool debugTangents;

	public bool debugBitangent;

	public bool debugFlowmap;

	public bool debugPoints;

	public bool debugPointsConnect;

	public bool debugMesh;

	public float distanceToDebug;

	public Color drawColor;

	public bool drawColorR;

	public bool drawColorG;

	public bool drawColorB;

	public bool drawColorA;

	public bool drawOnMultiple;

	public float flowSpeed;

	public float flowDirection;

	public AnimationCurve flowFlat;

	public AnimationCurve flowWaterfall;

	public bool noiseflowMap;

	public float noiseMultiplierflowMap;

	public float noiseSizeXflowMap;

	public float noiseSizeZflowMap;

	public float opacity;

	public float drawSize;

	public float length;

	public float fulllength;

	public float uv3length;

	public float minMaxWidth;

	public float uvWidth;

	public float uvBeginning;

	public bool receiveShadows;

	public ShadowCastingMode shadowCastingMode;

	public bool generateMeshParts;

	public int meshPartsCount;

	public List<Transform> meshesPartTransforms;

	public float simulatedRiverLength;

	public int simulatedRiverPoints;

	public float simulatedMinStepSize;

	public bool simulatedNoUp;

	public bool simulatedBreakOnUp;

	public int detailTerrain;

	public int detailTerrainForward;

	public float terrainAdditionalWidth;

	public float terrainSmoothMultiplier;

	public bool overrideRiverRender;

	public bool noiseWidth;

	public float noiseMultiplierWidth;

	public float noiseSizeWidth;

	public bool noiseCarve;

	public float noiseMultiplierInside;

	public float noiseMultiplierOutside;

	public float noiseSizeX;

	public float noiseSizeZ;

	public bool noisePaint;

	public float noiseMultiplierInsidePaint;

	public float noiseMultiplierOutsidePaint;

	public float noiseSizeXPaint;

	public float noiseSizeZPaint;

	public Terrain workTerrain;

	public List<Terrain> terrainsUnder;

	public int currentWorkTerrain;

	public LayerMask maskCarve;

	public AnimationCurve terrainCarve;

	public float distSmooth;

	public float distSmoothStart;

	public AnimationCurve terrainPaintCarve;

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

	public GameObject meshGO;

	public void Start()
	{
	}

	public static RamSpline CreateSpline(Material splineMaterial = null, List<Vector4> positions = null, string name = "RamSpline")
	{
		return null;
	}

	public void AddPoint(Vector4 position)
	{
	}

	public void AddPointAfter(int i)
	{
	}

	public void ChangePointPosition(int i, Vector3 position)
	{
	}

	public void ChangePointPosition(int i, Vector4 position)
	{
	}

	public void RemovePoint(int i)
	{
	}

	public void RemovePoints(int fromID = -1)
	{
	}

	public void GenerateBeginningParentBased()
	{
	}

	public void GenerateEndingParentBased()
	{
	}

	public void GenerateSpline(List<RamSpline> generatedSplines = null)
	{
	}

	private void CalculateCatmullRomSideSplines(List<Vector4> controlPoints, int pos)
	{
	}

	private void CalculateCatmullRomSplineParameters(List<Vector4> controlPoints, int pos, bool initialPoints = false)
	{
	}

	private void CalculateCatmullRomSpline(List<Vector3> controlPoints, int pos, ref List<Vector3> points)
	{
	}

	private void CalculatePointPosition(List<Vector3> controlPoints, int pos, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t, ref List<Vector3> points)
	{
	}

	private void CalculatePointParameters(List<Vector4> controlPoints, int pos, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
	}

	private int ClampListPos(int pos)
	{
		return 0;
	}

	private Vector3 GetCatmullRomPosition(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	private Vector3 GetCatmullRomTangent(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	private Vector3 CalculateNormal(Vector3 tangent, Vector3 up)
	{
		return default(Vector3);
	}

	private void GenerateMesh(ref Mesh mesh)
	{
	}

	public void GenerateMeshParts(Mesh baseMesh)
	{
	}

	public void AddNoiseToWidths()
	{
	}

	public void SimulateRiver(bool generate = true)
	{
	}

	public void ShowTerrainCarve(float differentSize = 0f)
	{
	}

	public void TerrainCarve(Terrain singleTerrain = null)
	{
	}

	public void TerrainPaintMeshBased(Terrain singleTerrain = null)
	{
	}

	public void TerrainClearFoliage(bool details = true)
	{
	}

	private float FlowCalculate(float u, float normalY, Vector3 vertice)
	{
		return 0f;
	}
}
