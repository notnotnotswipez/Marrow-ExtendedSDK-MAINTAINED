using UnityEngine;

namespace SLZ.MLAgents
{
	public class TerrainTaskClass : TaskClass
	{
		private GenerateTerrainMesh terrainGen;

		private VehicleSceneContextManager context;

		public float[] currentContextParams;

		public TaskObjective objective;

		public GameObject objectiveObj;

		private int objectiveInd;

		private int spawnInd;

		private GameObject wallParent;

		private GameObject obstacleParent;

		protected override void Awake()
		{
		}

		private void HandleTaskCompleted(bool successful)
		{
		}

		protected override void PlaceWalls()
		{
		}

		private int BorderPadInd(int currentInd, int squareSize)
		{
			return 0;
		}

		protected override void PlaceObjective()
		{
		}

		protected override void PlaceObstacles()
		{
		}

		protected override void PlaceAndRegisterContestants()
		{
		}

		private void ClearObjective()
		{
		}

		private void ClearWalls()
		{
		}

		private void ClearTask()
		{
		}

		public override void GenerateTask()
		{
		}

		private void PopulateTask()
		{
		}

		[ContextMenu("ResetTask")]
		public override void ResetTask()
		{
		}

		protected override void FixedUpdate()
		{
		}

		protected override void Start()
		{
		}
	}
}
