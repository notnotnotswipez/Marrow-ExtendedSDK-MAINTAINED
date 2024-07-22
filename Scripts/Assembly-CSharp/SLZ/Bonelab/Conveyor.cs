using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Conveyor : MonoBehaviour
	{
		private enum Mode
		{
			zTranslation = 0,
			xRotation = 1
		}

		public Rigidbody primaryRb;

		public ConfigurableJoint primaryJoint;

		public float resetHalfThreshold;

		[SerializeField]
		private Mode mode;

		public float velocity;

		public InteractableHost host;

		private Vector3 _initialLocalPos;

		private Quaternion _initialLocalRot;

		private void Reset()
		{
		}

		private void Start()
		{
		}

		public void OnFixedUpdate()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
