using UnityEngine;

namespace SLZ.MLAgents
{
	public class VehicleSceneContextManager : SceneContextManager
	{
		private float contextType;

		private bool driveThrough;

		private float preSpeedMin;

		private float preSpeedMax;

		private float inSpeedMin;

		private float inSpeedMax;

		private float goalRadius;

		private float proxRadius;

		[Tooltip("make sure the order is the same as the tasks in desired scene contexts")]
		public TaskObjective[] objectivePrefabs;

		public float[][] sceneParams;

		public bool paramOverride;

		private void Reset()
		{
		}

		protected override void Awake()
		{
		}

		public void UpdateParams()
		{
		}
	}
}
