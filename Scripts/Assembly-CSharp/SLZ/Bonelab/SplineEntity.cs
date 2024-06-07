using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SplineEntity : MonoBehaviour
	{
		public enum ContactCount
		{
			ONE = 1,
			TWO = 2,
			FOUR = 4
		}

		[Header("Configuration")]
		public ContactCount contactCount;

		public Vector3 axis;

		public Vector3 secondaryAxis;

		[SerializeField]
		protected Vector2 _size;

		public Vector3 anchor;

		[Header("References")]
		public SplineJoint splineJoint;

		[HideInInspector]
		public int lastSegmentIdx;

		[HideInInspector]
		public Vector3 lastPosition;

		public Quaternion AnchorRotation => default(Quaternion);

		public Vector3 Size => default(Vector3);

		public Vector3 FrontContact => default(Vector3);

		public Vector3 RightContact => default(Vector3);

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public void AttachToSplineJoint(SplineJoint splineJoint)
		{
		}

		public SimpleTransform GetContactOriginInWorld()
		{
			return default(SimpleTransform);
		}

		public static Quaternion GetJointSpace(Vector3 priAxis, Vector3 secAxis)
		{
			return default(Quaternion);
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
