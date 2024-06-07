using SLZ.Marrow.AI;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class AutoAgroBoid : MonoBehaviour
	{
		public MLZoneSpawner_Child boidSpawner;

		private BehaviourBoid boid;

		public bool findBall;

		[Range(0f, 1f)]
		public float attackProbability;

		public bool useCordForceChange;

		public GameObject[] betweenAgroWaypoints;

		public bool setBumperRate;

		public int bumperUpdateRate;

		private void Awake()
		{
		}

		private void SetAgro(Behaviour go, TriggerRefProxy playerTrp)
		{
		}
	}
}
