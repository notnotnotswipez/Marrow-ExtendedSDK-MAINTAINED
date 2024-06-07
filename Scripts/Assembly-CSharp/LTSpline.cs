using System;
using UnityEngine;

[Serializable]
public class LTSpline
{
	public static int DISTANCE_COUNT;

	public static int SUBLINE_COUNT;

	public float distance;

	public bool constantSpeed;

	public Vector3[] pts;

	[NonSerialized]
	public Vector3[] ptsAdj;

	public int ptsAdjLength;

	public bool orientToPath;

	public bool orientToPath2d;

	private int numSections;

	private int currPt;

	public LTSpline(Vector3[] pts)
	{
	}

	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	public float ratioAtPoint(Vector3 pt)
	{
		return 0f;
	}

	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	public void place2d(Transform transform, float ratio)
	{
	}

	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	public void place(Transform transform, float ratio)
	{
	}

	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	public void placeLocal(Transform transform, float ratio)
	{
	}

	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	public void gizmoDraw(float t = -1f)
	{
	}

	public void drawGizmo(Color color)
	{
	}

	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	public Vector3[] generateVectors()
	{
		return null;
	}
}
