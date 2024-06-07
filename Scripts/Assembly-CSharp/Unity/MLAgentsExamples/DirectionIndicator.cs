using UnityEngine;

namespace Unity.MLAgentsExamples
{
	public class DirectionIndicator : MonoBehaviour
	{
		public bool updatedByAgent;

		public Transform transformToFollow;

		public Transform targetToLookAt;

		public float heightOffset;

		private float m_StartingYPos;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public void MatchOrientation(Transform t)
		{
		}
	}
}
