using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class ObstacleRayPenalty : MonoBehaviour
	{
		public RayPerceptionSensorComponent3D eye_reference;

		[HideInInspector]
		public RayPerceptionOutput eyes_output;

		public Agent agent;

		public float distance_penalty;

		private int nb_rays;

		public int[] penaltyTags;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
