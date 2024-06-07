using System.Collections.Generic;
using Trees;
using UnityEngine;

namespace Navigation
{
	public class SvoAgent : MonoBehaviour
	{
		public SVOManager svoManager;

		private ICostStrategy _costStrategy;

		public GameObject bodyReference;

		public GameObject destObj;

		public int maxIterCount;

		public float agentHeight;

		public float agentRadius;

		public float agentSize;

		public bool debugDrawAgentSize;

		public int agentSizeDrawResolution;

		private float _agentResStepSize;

		public bool debugDrawPath;

		public float debugDrawTime;

		public bool debugDrawNeighbors;

		private GreedyAStar _aStar;

		public bool limitNavHeight;

		private bool _isInit;

		public bool constantUpdate;

		public float updateTick;

		public bool skipFirstPoint;

		private float _tickTimer;

		private List<Vector3> _pathList;

		private Vector3 _nextPosition;

		public ICostStrategy CostStrategy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SparseVoxelOctree SVO => null;

		public Vector3 NextPosition => default(Vector3);

		public Vector3 StartPosition => default(Vector3);

		public Vector3 EndPosition => default(Vector3);

		public int PathSize => 0;

		[ContextMenu("Clear A Star")]
		public void ClearAStar()
		{
		}

		[ContextMenu("Clear Path List")]
		public void ClearPathList()
		{
		}

		[ContextMenu("Stop Update")]
		public void StopUpdate()
		{
		}

		private void Awake()
		{
		}

		[ContextMenu("Create AStar")]
		public void CreateAStar(ICostStrategy costStrategy)
		{
		}

		[ContextMenu("Query AStar")]
		public void QueryAStar()
		{
		}

		public void GetPath(Vector3 start, Vector3 end)
		{
		}

		public void SetConstraints(Vector3 refWorldPoint, float minHeight = float.MinValue, float maxHeight = float.MaxValue)
		{
		}

		public void ReplaceEndpoint(Vector3 point)
		{
		}

		public Vector3 GetPointInVolume(Vector3 center, Vector3 area)
		{
			return default(Vector3);
		}

		public void RequestPathPosition()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
