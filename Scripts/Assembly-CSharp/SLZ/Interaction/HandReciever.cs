using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class HandReciever : MonoBehaviour
	{
		private static ComponentCache<HandReciever> _cache;

		private bool _isEnabled;

		[HideInInspector]
		private HandJointConfiguration _handJointConfig;

		public static ComponentCache<HandReciever> Cache => null;

		public IGrippable Host
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsFarHoverEnabled => false;

		public bool IsStatic => false;

		public bool HasRigidbody => false;

		public bool HasHost => false;

		public HandJointConfiguration HandJointConfig => null;

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public SimpleTransform GetHostTransform()
		{
			return default(SimpleTransform);
		}

		public virtual void DisableInteraction()
		{
		}

		public virtual void EnableInteraction()
		{
		}

		public virtual (float, float, Vector3, Vector3) ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default((float, float, Vector3, Vector3));
		}

		public virtual void OnAttachedToHand(Hand hand)
		{
		}

		public virtual void OnJointAttached(Hand hand)
		{
		}

		public virtual void OnHandAttachedUpdate(Hand hand)
		{
		}

		public virtual void OnHandHoverEnd(Hand hand)
		{
		}

		public virtual void OnHandHoverBegin(Hand hand)
		{
		}

		public virtual void OnFarHandHoverEnd(Hand hand)
		{
		}

		public virtual void OnFarHandHoverBegin(Hand hand)
		{
		}

		public virtual void OnHandHoverUpdate(Hand hand)
		{
		}

		public virtual void OnFarHandHoverUpdate(Hand hand)
		{
		}

		public virtual void OnDetachedFromHand(Hand hand)
		{
		}
	}
}
