using UnityEngine;

namespace SLZ.Bonelab
{
	public class ForcePlatform : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody rb;

		[SerializeField]
		private Vector3 dir;

		[SerializeField]
		private float forceMult;

		[SerializeField]
		private ConfigurableJoint joint;

		[SerializeField]
		private float linLimit;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		[ContextMenu("GetComponents")]
		public void GetComponents()
		{
		}
	}
}
