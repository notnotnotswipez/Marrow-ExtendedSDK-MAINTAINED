using SLZ.MLAgents;
using UnityEngine;

namespace PathCreation.Examples
{
	public class RoadPartitionTrigger : MonoBehaviour
	{
		public RoadMeshCreator_Custom rmc;

		public TrackGenerator generator;

		public BoxCollider col;

		public float windowSize;

		public bool isListening;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
