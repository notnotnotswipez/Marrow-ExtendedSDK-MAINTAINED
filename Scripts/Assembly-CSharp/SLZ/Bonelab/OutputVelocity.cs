using SLZ.Combat;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class OutputVelocity : MonoBehaviour
	{
		public bool runThis;

		public InteractableHost host;

		public Rigidbody rb;

		public Transform measurePoint;

		public UnityEventFloat eventFloatSqrMag;

		public UnityEventFloat eventFloatMag;

		public Vector4 range_out_sm;

		[HideInInspector]
		public float cur_sm;

		[HideInInspector]
		public float cur_m;

		[HideInInspector]
		public float output_sqrMag;

		private void Start()
		{
		}

		private Vector3 CalcTransformVelocity(Vector3 transformPos)
		{
			return default(Vector3);
		}

		private void FixedUpdate()
		{
		}
	}
}
