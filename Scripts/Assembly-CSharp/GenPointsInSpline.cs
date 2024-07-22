using System;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Splines;

public class GenPointsInSpline : MonoBehaviour
{
	[Serializable]
	public struct SpawnPoint
	{
		public float3 pos;

		public float3 right;

		public float3 up;
	}

	[SerializeField]
	private SplineContainer m_SplineContainer;

	[SerializeField]
	private float spacing;

	[SerializeField]
	private int maxIterations;

	[SerializeField]
	private bool lerpChildPoints;

	private List<Vector2> m_ParentPointSegments;

	private List<SpawnPoint> spawnPointsToRemove;

	private List<SpawnPoint> pointsToKeep;

	[SerializeField]
	private bool isDrawing;

	public List<SpawnPoint> ParentSpawnPoints;

	public List<SpawnPoint> ChildSpawnPoints;

	private SpawnPoint[] moverPoints;

	[ContextMenu("Generate Points")]
	public void GeneratePointsOnSpline()
	{
	}

	private void GenerateInnerPoints()
	{
	}

	[ContextMenu("CheckWithinBounds")]
	public void CheckWithinBounds()
	{
	}

	[ContextMenu("RemovePoints")]
	public void RemovePoints()
	{
	}

	[ContextMenu("CheckSpacing")]
	public void CheckSpacing()
	{
	}

	[ContextMenu("Get40RandomPoints")]
	public void Get40RandomPoints()
	{
	}

	public void GetNRandomPoints(int count)
	{
	}

	private bool PointInsidePolygon(Vector2 point, List<Vector2> polygon)
	{
		return false;
	}

	private void OnDrawGizmos()
	{
	}
}
