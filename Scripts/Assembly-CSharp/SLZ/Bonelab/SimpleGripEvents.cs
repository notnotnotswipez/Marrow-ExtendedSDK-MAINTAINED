using SLZ.Marrow;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class SimpleGripEvents : MonoBehaviour
	{
		public UnityEvent OnIndexDown;

		public UnityEvent OnMenuTapDown;

		public UnityEvent OnAttach;

		public UnityEvent OnDetach;

		public Grip[] Grips;

		[Header("When enabled OnAttach will only fire on the first hand attach and OnDetach will only fire when both hands are detached.")]
		public bool doNotRetriggerOnMultiGirp;

		private bool leftHand;

		private bool rightHand;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnAttachedUpdateDelegate(Hand hand)
		{
		}

		public void OnAttachedDelegate(Hand hand)
		{
		}

		public void OnDetachedDelegate(Hand hand)
		{
		}
	}
}
