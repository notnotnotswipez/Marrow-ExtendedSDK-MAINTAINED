using PathCreation;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class PartitionSlider : MonoBehaviour
	{
		[Range(0f, 1f)]
		public float trackPercentage;

		public TrackClass trackClass;

		private VertexPath masterVp;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
