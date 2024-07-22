using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(ConfigurableJoint))]
	[RequireComponent(typeof(Rigidbody))]
	public class SlideObjectControl : MonoBehaviour
	{
		private Vector3 SlideDirection;

		public ConfigurableJoint m_configJoint;

		public Rigidbody m_rb;

		[Header("Drawer Movement")]
		private bool flippedDir;

		private float openGap;

		private float closeGap;

		public float parentScale;

		public bool FreeDrawer;

		[Tooltip("is the drawer set in an open position? this will stop it from closing at start")]
		public bool startOpen;

		private bool previousIsOpen;

		private Vector3 axis_Anchor;

		private Vector3 axis_slide;

		private float limit_Linear;

		private float bounce;

		private float contactDistance;

		public float springPower;

		public float damperPower;

		public float maxForce;

		private float slideOpenThreshold;

		[Space(5f)]
		public float targetPosition_closed;

		public float targetPosition_open;

		private Vector3 desiredClosedPosition;

		private Vector3 desiredOpenPosition;

		[Space(10f)]
		[Header("Lock")]
		public bool Locked;

		private void Reset()
		{
		}

		private void Start()
		{
		}

		public void SetUpJoint()
		{
		}

		private void ANCHOR()
		{
		}

		public void LOCKLIMITS()
		{
		}

		public void SETDRIVE()
		{
		}

		public void OPENCLOSE(bool isOpening)
		{
		}

		private void FixedUpdate()
		{
		}

		private bool CalculateOpening()
		{
			return false;
		}
	}
}
