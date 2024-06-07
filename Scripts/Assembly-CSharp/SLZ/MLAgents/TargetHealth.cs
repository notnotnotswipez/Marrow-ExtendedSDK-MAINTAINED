using UnityEngine;

namespace SLZ.MLAgents
{
	public class TargetHealth : MonoBehaviour
	{
		public float baseHealth;

		[HideInInspector]
		public float currentHealth;

		private void Awake()
		{
		}

		public bool TakeDamage(float dmg)
		{
			return false;
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
