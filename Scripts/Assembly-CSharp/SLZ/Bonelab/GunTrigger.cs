using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GunTrigger : MonoBehaviour
	{
		[SerializeField]
		private Gun gun;

		[SerializeField]
		private Grip triggerGrip;

		[SerializeField]
		private Transform triggerObj;

		[SerializeField]
		private float triggerObjMaxAngle;

		[SerializeField]
		private Vector3 triggerObjAxis;

		[SerializeField]
		private Gun.FireMode fireMode;

		[SerializeField]
		private float pullDistance;

		[SerializeField]
		private float returnDistance;

		private bool hasFiredOnce;

		private void Update()
		{
		}
	}
}
