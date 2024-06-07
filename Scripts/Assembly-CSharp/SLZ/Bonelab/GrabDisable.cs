using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GrabDisable : MonoBehaviour
	{
		public GameObject disableObject;

		public Grip grip;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnAttached(Hand hand)
		{
		}
	}
}
