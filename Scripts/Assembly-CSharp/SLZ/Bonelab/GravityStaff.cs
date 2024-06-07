using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GravityStaff : MonoBehaviour
	{
		private static MaterialPropertyBlock _propertyBlock;

		private static int _colorID;

		[ColorUsage(true, true)]
		public Color defaultColor;

		[ColorUsage(true, true)]
		public Color activeColor;

		public Transform target;

		public MeshRenderer[] meshRenderer;

		public InteractableHost host;

		public GravityManipulatorJob gravityManipulator;

		public GravityStaffReciever reciever;

		private void Awake()
		{
		}

		private void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		private void OnHandDetached(InteractableHost host, Hand hand)
		{
		}
	}
}
