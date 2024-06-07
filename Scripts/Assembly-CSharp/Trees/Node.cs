using UnityEngine;

namespace Trees
{
	public class Node
	{
		public int depth;

		public Vector3 position;

		public bool empty;

		public int heuristicWeight;

		public float area;

		public Node parentNode;

		public Node[] children;

		public bool pointNode;

		public bool init;

		private Vector3 tempChildLocation;

		private Quaternion quat;

		private float hypot;

		public void InitNode(int level, Node parent, Vector3 location, float size, int weight = 0, int nbNodes = 8)
		{
		}

		public void CreateChildren(int depth, int maxDepth, int nbNodes)
		{
		}
	}
}
