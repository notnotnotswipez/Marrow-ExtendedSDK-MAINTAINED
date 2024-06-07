using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AddConfigJoint : MonoBehaviour
	{
		[SerializeField]
		private MarrowBody _marrowBody;

		[SerializeField]
		private MarrowBody _connectedBody;

		private ConfigurableJoint _trapJoint;

		[SerializeField]
		private ConfigurableJointInfo _jointInfo;

		public float breakForce;

		public float breakTorque;

		private void Start()
		{
		}

		private void Reset()
		{
		}

		private void BuildJoints()
		{
		}

		public void SetBreakForce()
		{
		}

		public void SetBreakForceAndTorque()
		{
		}

		public void SetBreakTorque()
		{
		}
	}
}
