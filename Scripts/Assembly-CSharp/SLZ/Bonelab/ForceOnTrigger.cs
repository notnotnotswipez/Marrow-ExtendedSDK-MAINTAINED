using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ForceOnTrigger : MonoBehaviour
	{
		public Rigidbody rigidbody;

		public Vector3 velocity;

		public Vector3 angularVelocity;

		public List<Nail> nails;

		private void Start()
		{
		}

		[ContextMenu("TestForceInPlayMode")]
		public void APPLYFORCE()
		{
		}
	}
}
