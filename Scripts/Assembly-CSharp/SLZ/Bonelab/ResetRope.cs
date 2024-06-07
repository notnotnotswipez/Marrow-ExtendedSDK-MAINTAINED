using System;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ResetRope : MonoBehaviour
	{
		[Serializable]
		private struct RopeSegments
		{
			public GameObject gameObject;

			public ConfigurableJoint joint;

			public Rigidbody rigidBody;
		}

		private struct RopeSegementCache
		{
			public Vector3 position;

			public Quaternion rotation;

			public ConfigurableJointMotion xMotion;

			public ConfigurableJointMotion yMotion;

			public ConfigurableJointMotion zMotion;

			public ConfigurableJointMotion angularXMotion;

			public ConfigurableJointMotion angularYMotion;

			public ConfigurableJointMotion angularZMotion;

			public Rigidbody connectedBody;
		}

		[SerializeField]
		private RopeSegments[] _ropeSegments;

		private RopeSegementCache[] _ropeSegmentCache;

		private void Start()
		{
		}

		public void CacheSegements()
		{
		}

		[ContextMenu("ResetRope")]
		public void RopeReset()
		{
		}
	}
}
