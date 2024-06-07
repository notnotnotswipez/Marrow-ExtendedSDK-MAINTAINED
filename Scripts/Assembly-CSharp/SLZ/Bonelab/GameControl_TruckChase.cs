using SLZ.MLAgents;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GameControl_TruckChase : MonoBehaviour
	{
		[SerializeField]
		private Seat heroCarSeat;

		[SerializeField]
		private Seat truckSeat;

		public UnityEvent OnHeroCarSeated;

		public UnityEvent OnTruckSeated;

		[Header("AI Stuff")]
		public BarracudaModelManagerMono truckBMM;

		public ModelManagerConfig truckBMMConfig;

		public VehicleContextConfig truckContextConfig;

		public GameObject truck;

		public BarracudaModelManagerMono carBMM;

		public ModelManagerConfig carBMMConfig;

		public VehicleContextConfig carContextConfig;

		public GameObject car;

		public FollowObjective truckGoal;

		public FollowObjective carGoal;

		private void Start()
		{
		}

		private void WarmStartModelManagers()
		{
		}

		private void AgentSetup(GameObject vehicle, VehicleContextConfig config, FollowObjective objective)
		{
		}

		private void AssignContextParams(BaseVehicle_SlicedInference infAgent, VehicleContextConfig config)
		{
		}

		private float[] GetRndmContextParams(VehicleContextConfig config)
		{
			return null;
		}
	}
}
