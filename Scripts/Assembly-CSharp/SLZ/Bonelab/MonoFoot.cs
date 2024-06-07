using UnityEngine;

namespace SLZ.Bonelab
{
	public class MonoFoot : MonoBehaviour
	{
		public Rigidbody foot;

		public ConfigurableJoint joint;

		public LayerMask mask;

		private Vector3 _displaceCache;

		private Vector3 _originLocal;

		private float _yOffset;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
