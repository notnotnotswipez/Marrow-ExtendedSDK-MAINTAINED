using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class FreezeBlast : MonoBehaviour
	{
		public List<ConfigurableJoint> ConfigJoints;

		public float breakForce;

		public float breakTorque;

		public float BlastRadius;

		public ConfigurableJointMotion jointMotion;

		public Collider selfCollider;

		private Collider[] cols;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
