using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ZipGrip : MonoBehaviour
	{
		[SerializeField]
		private Grip grip;

		[SerializeField]
		private Vector3 startPos;

		[SerializeField]
		private Quaternion startRot;

		[SerializeField]
		private Rigidbody body;

		[SerializeField]
		private ConfigurableJoint joint;

		[SerializeField]
		private Transform com;

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnAttached(Hand hand)
		{
		}

		public void OnDettached(Hand hand)
		{
		}

		public void ResetToStart()
		{
		}
	}
}
