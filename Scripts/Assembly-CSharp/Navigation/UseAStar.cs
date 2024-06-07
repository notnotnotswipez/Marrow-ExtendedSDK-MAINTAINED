using Trees;
using UnityEngine;

namespace Navigation
{
	public class UseAStar : MonoBehaviour
	{
		public SVOManager svoManager;

		public GameObject startObj;

		public GameObject endObj;

		public int agentSize;

		public int maxIterCount;

		public bool debugDrawPath;

		public float debugDrawTime;

		public bool debugDrawNeighbors;

		private GreedyAStar aStar;

		private bool isInit;

		public bool constantUpdate;

		public float updateTick;

		private float tickTimer;

		public int maxCounter;

		[ContextMenu("Clear A Star")]
		public void ClearAStar()
		{
		}

		[ContextMenu("Stop Update")]
		public void StopUpdate()
		{
		}

		private void Start()
		{
		}

		[ContextMenu("Create AStar")]
		public void CreateAStar()
		{
		}

		[ContextMenu("Query AStar")]
		public void QueryAStar()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
