using UnityEngine;

namespace SLZ.MLAgents
{
	public class GenericFollowController : MonoBehaviour
	{
		public BarracudaModelManagerMono truckBMM;

		public ModelManagerConfig truckBMMConfig;

		public VehicleContextConfig truckContextConfig;

		public GameObject truckPrefab;

		public BarracudaModelManagerMono carBMM;

		public ModelManagerConfig carBMMConfig;

		public VehicleContextConfig carContextConfig;

		public GameObject carPrefab;

		public FollowObjective truckGoal;

		public FollowObjective npcGoal;

		private void Awake()
		{
		}

		private void SpawnTruck()
		{
		}

		private void SpawnCars()
		{
		}

		private void HandleObjectives()
		{
		}

		private void WarmStartModelManagers()
		{
		}
	}
}
