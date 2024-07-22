using SLZ.Marrow;
using SLZ.Marrow.AI;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SuperSeeker : MonoBehaviour
	{
		[SerializeField]
		private GameObject targetObj;

		public RigManager rigManager;

		private bool scaleChild;

		private float scaleFactor;

		[SerializeField]
		private GameObject childObj;

		public ProfileSpawner spawner;

		[SerializeField]
		private AIManager aiBrain;

		private void OnSpawnerDeath(AIBrain brain)
		{
		}

		public void SetSeekerTarget(AIBrain brain)
		{
		}

		public void SeekCompletion()
		{
		}

		public void FixedUpdate()
		{
		}
	}
}
