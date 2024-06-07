using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public interface IGrippable
	{
		VirtualController VirtualController { get; }

		Collider[] Colliders { get; }

		bool IsInteractionDisabled { get; }

		bool IsFarHoverEnabled { get; }

		bool IsStatic { get; set; }

		bool IsAttached { get; }

		bool IsPulling { get; }

		bool HasRigidbody { get; }

		Rigidbody Rb { get; }

		void RemoveProxy();

		void SetProxy(GameObject proxyObject);

		void EnableFarHover();

		void AttachHand(Hand handObject);

		void DetachHand(Hand handObject);

		int HandCount();

		SimpleTransform GetHostTransform();

		Transform GetTransform();

		void ForceDetach(bool isQuick = false);

		void Freeze();

		void Unfreeze();

		GameObject GetHostGameObject();

		Hand GetLastHand();

		Grip GetGrip();

		void DisableInteraction();

		void DisableColliders();

		void EnableInteraction();

		void EnableColliders();
	}
}
