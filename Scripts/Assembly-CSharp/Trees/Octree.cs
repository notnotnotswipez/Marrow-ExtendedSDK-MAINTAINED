using UnityEngine;
using Voxelization;

namespace Trees
{
	public class Octree
	{
		public int maxDepth;

		public int detectedDepth;

		public float rootSize;

		public int collisionMask;

		public int queryTriggerCols;

		public QueryTriggerInteraction triggerInteration;

		public Node rootNode;

		private Collider[] detectedColliders;

		private Cube tempCube;

		private bool stop;

		public Octree(int depth, float size, Vector3 location, int mask = 1, QueryTriggerInteraction interactWithTriggers = QueryTriggerInteraction.Ignore)
		{
		}

		public void Run()
		{
		}

		public bool CheckInCube(Vector3 checkPoint, Vector3 centerPoint, float area, bool debugDraw = false)
		{
			return false;
		}

		public void DetectObjectsOverlap(Node treeNode, Collider collider)
		{
		}

		public void InsertNode(Node currentNode, Collider col)
		{
		}

		public Node SearchTree(Vector3 startLocation, Vector3 endLocation)
		{
			return null;
		}
	}
}
