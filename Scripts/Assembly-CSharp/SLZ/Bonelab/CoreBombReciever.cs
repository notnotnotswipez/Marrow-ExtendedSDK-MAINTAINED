using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class CoreBombReciever : MonoBehaviour
	{
		private static MaterialPropertyBlock _propertyBlock;

		private static int _colorID;

		public Color activeColor;

		public Color deactiveColor;

		public MeshRenderer meshRenderer;

		public Transform jointTarget;

		public SphereCollider sphereCollider;

		public Rigidbody rb;

		public bool hasCore;

		[Tooltip("Force over Distance")]
		public AnimationCurve forcePercentageFalloff;

		public UnityEvent OnCoreAttached;

		private ConfigurableJoint _joint;

		private CoreBomb _activeCore;

		private float _sqrRadius;

		private void Awake()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void FixedUpdate()
		{
		}

		private void AttachCore()
		{
		}
	}
}
