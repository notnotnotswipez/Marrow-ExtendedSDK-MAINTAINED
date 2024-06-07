using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Interaction
{
	public class SlotContainer : MonoBehaviour
	{
		public enum BodyRegion
		{
			Torso = 0,
			ArmUpperLf = 1,
			ArmLowerLf = 2,
			ArmUpperRt = 3,
			ArmLowerRt = 4,
			LegUpperLf = 5,
			LegLowerLf = 6,
			LegUpperRt = 7,
			LegLowerRt = 8
		}

		[FormerlySerializedAs("child")]
		public Transform child;

		[FormerlySerializedAs("hideObject")]
		public GameObject art;

		public InventorySlotReceiver inventorySlotReceiver;

		public Rigidbody rootRb;

		public BodyRegion bodyRegion;

		[Range(0f, 2f)]
		[Tooltip("Torso Y location of slot. 0 is between the shoulders, 1 is between the hips")]
		public float regionY;

		[Range(-180f, 180f)]
		[Tooltip("0 is straight in front, sternum to belly button. 180 is straight in back along the spine. 90/-90 is along the side")]
		public float degreesFromCenter;

		public Vector2 hardDimentions;

		private float _cachedDegrees;

		public bool flippable;

		[HideInInspector]
		public bool ready;

		private InventorySlotReceiver _inventorySlot;

		private SimpleTransform _defaultLocalOffset;

		private Vector3 _cachedChildScale;

		private void Awake()
		{
		}

		public void FlipSagittal(bool flipped = false)
		{
		}

		public void MoveToTemporaryParent(Transform parent)
		{
		}

		public void Return()
		{
		}

		public void SetRootRb(Rigidbody rb)
		{
		}

		public void FlipSpecialItem(bool flipped)
		{
		}
	}
}
