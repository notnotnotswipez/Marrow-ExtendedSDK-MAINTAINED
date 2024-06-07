using UnityEngine;

namespace SLZ.MLAgents
{
	public class RigidBodyDamageDealer : MonoBehaviour
	{
		public float dmg_val;

		public float impact_force_requirement;

		public bool block_dmg;

		public float max_force;

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
