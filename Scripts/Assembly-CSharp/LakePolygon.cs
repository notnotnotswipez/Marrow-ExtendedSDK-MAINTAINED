using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(MeshFilter))]
public class LakePolygon : MonoBehaviour
{
	public int toolbarInt;

	public LakePolygonProfile currentProfile;

	public LakePolygonProfile oldProfile;

	public List<Vector3> points;

	public List<Vector3> splinePoints;

	public AnimationCurve terrainCarve;

	public float distSmooth;

	public float terrainSmoothMultiplier;

	public bool overrideLakeRender;

	public float uvScale;

	public bool receiveShadows;

	public ShadowCastingMode shadowCastingMode;

	public AnimationCurve terrainPaintCarve;

	public int currentSplatMap;

	public float distanceClearFoliage;

	public float distanceClearFoliageTrees;

	public bool mixTwoSplatMaps;

	public int secondSplatMap;

	public bool addCliffSplatMap;

	public int cliffSplatMap;

	public float cliffAngle;

	public float cliffBlend;

	public int cliffSplatMapOutside;

	public float cliffAngleOutside;

	public float cliffBlendOutside;

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

	public float maximumTriangleSize;

	public float traingleDensity;

	public float height;

	public bool lockHeight;

	public float yOffset;

	public float trianglesGenerated;

	public float vertsGenerated;

	public Mesh currentMesh;

	public MeshFilter meshfilter;

	public bool showVertexColors;

	public bool showFlowMap;

	public bool overrideFlowMap;

	public float automaticFlowMapScale;

	public bool noiseflowMap;

	public float noiseMultiplierflowMap;

	public float noiseSizeXflowMap;

	public float noiseSizeZflowMap;

	public bool drawOnMesh;

	public bool drawOnMeshFlowMap;

	public Color drawColor;

	public bool drawColorR;

	public bool drawColorG;

	public bool drawColorB;

	public bool drawColorA;

	public bool drawOnMultiple;

	public float opacity;

	public float drawSize;

	public Material oldMaterial;

	public Color[] colors;

	public List<Vector2> colorsFlowMap;

	public float floatSpeed;

	public float flowSpeed;

	public float flowDirection;

	public float closeDistanceSimulation;

	public int angleSimulation;

	public float checkDistanceSimulation;

	public bool removeFirstPointSimulation;

	public bool normalFromRaycast;

	public bool snapToTerrain;

	public LayerMask snapMask;

	public LakePolygonCarveData lakePolygonCarveData;

	public LakePolygonCarveData lakePolygonPaintData;

	public LakePolygonCarveData lakePolygonClearData;

	public List<GameObject> meshGOs;

	public void AddPoint(Vector3 position)
	{
	}

	public void AddPointAfter(int i)
	{
	}

	public void ChangePointPosition(int i, Vector3 position)
	{
	}

	public void RemovePoint(int i)
	{
	}

	public void RemovePoints(int fromID = -1)
	{
	}

	private void CenterPivot()
	{
	}

	public void GeneratePolygon(bool quick = false)
	{
	}

	public static LakePolygon CreatePolygon(Material material, List<Vector3> positions = null)
	{
		return null;
	}

	private void CalculateCatmullRomSpline(int pos)
	{
	}

	public int ClampListPos(int pos)
	{
		return 0;
	}

	private Vector3 GetCatmullRomPosition(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	public float DistancePointLine(Vector2 point, Vector2 lineStart, Vector2 lineEnd, out Vector2 pointProject)
	{
		pointProject = default(Vector2);
		return 0f;
	}

	public Vector2 ProjectPointLine(Vector2 point, Vector2 lineStart, Vector2 lineEnd)
	{
		return default(Vector2);
	}

	public void TerrainCarve(bool terrainShow = false)
	{
	}

	public void TerrainPaint(bool terrainShow = false)
	{
	}

	public void TerrainClearTrees(bool details = true)
	{
	}

	public void Simulation()
	{
	}

	public static bool AreLinesIntersecting(Vector3 l1_p1, Vector3 l1_p2, Vector3 l2_p1, Vector3 l2_p2, bool shouldIncludeEndPoints = true)
	{
		return false;
	}

	public static float DistancePointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd)
	{
		return 0f;
	}

	public static Vector3 ProjectPointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd)
	{
		return default(Vector3);
	}
}
