using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class NooseDaggerJoint : MonoBehaviour
	{
		[SerializeField]
		private MarrowBody _marrowBody;

		[SerializeField]
		private MarrowBody _connectedBody;

		[SerializeField]
		private ConfigurableJointInfo _jointInfo;

		private bool jointBuilt;

		private ConfigurableJoint _dj;

		[HideInInspector]
		public MarrowJoint _marrowJoint;

		private void OnEnable()
		{
		}

		private void BuildJoints()
		{
		}

		public void NooseCut()
		{
		}

		public void TurnOffDrives()
		{
		}

		public void RestoreDrives()
		{
		}
	}
}
