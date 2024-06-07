using UnityEngine;

namespace Trees
{
	public class UseOctree : MonoBehaviour
	{
		public int treeDepth;

		public float size;

		public bool debugDraw;

		public float refreshRate;

		private float refreshTime;

		private Octree octree;

		private Color rootColor;

		private Color regionColor;

		private Color occupiedColor;

		private void OnDrawGizmos()
		{
		}

		private Node GetChildren(Node node)
		{
			return null;
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		[ContextMenu("Run Octree")]
		public void RunOctree()
		{
		}

		[ContextMenu("Clear Octree")]
		public void ClearOctree()
		{
		}
	}
}
