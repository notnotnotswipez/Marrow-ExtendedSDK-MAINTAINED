using UnityEngine;

namespace SLZ.MLAgents
{
	public class InfiniteTrackClass : TrackClass
	{
		[Header("Infinite Track Section")]
		[Tooltip("List containing all track chunks")]
		public GameObject[] partitionList;

		[Tooltip("Number of chunks to load infront and behind current")]
		public int windowSize;

		[Tooltip("Current inds of active partitions")]
		public int[] windowInds;

		private int currentPartition;

		private bool hasInit;

		private void OnValidate()
		{
		}

		public void ReverseChunkTriggers()
		{
		}

		public override void RemoveTrackObjects()
		{
		}

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
