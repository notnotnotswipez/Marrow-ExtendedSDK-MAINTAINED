using UnityEngine;

namespace PathCreation.Examples
{
	public class PathFollower : MonoBehaviour
	{
		public PathCreator pathCreator;

		public EndOfPathInstruction endOfPathInstruction;

		public float speed;

		private float distanceTravelled;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnPathChanged()
		{
		}
	}
}
