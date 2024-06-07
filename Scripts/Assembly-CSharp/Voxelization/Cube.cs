using UnityEngine;

namespace Voxelization
{
	public class Cube
	{
		public Vector3 centerPoint;

		public float area;

		public bool debugDraw;

		private Vector3 p1;

		private Vector3 p2;

		private Vector3 p3;

		private Vector3 p4;

		private Vector3 p5;

		private Vector3 p6;

		private Vector3 p7;

		private Vector3 p8;

		private Vector3 i;

		private Vector3 j;

		private Vector3 k;

		private Vector3 v;

		private float q;

		private float w;

		private float r;

		public Cube(Vector3 centerPoint, float area, bool debugDraw = false)
		{
		}

		public void DrawCube()
		{
		}

		public bool CheckInCube(Vector3 itemPosition)
		{
			return false;
		}
	}
}
