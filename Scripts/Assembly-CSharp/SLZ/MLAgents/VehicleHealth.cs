using UnityEngine;

namespace SLZ.MLAgents
{
	public class VehicleHealth : MonoBehaviour
	{
		[Tooltip("Master amount of health normalized between 0 and 1")]
		[Range(0f, 1f)]
		public float health;

		private void Awake()
		{
		}

		public void SubtractHealth(float val)
		{
		}
	}
}
