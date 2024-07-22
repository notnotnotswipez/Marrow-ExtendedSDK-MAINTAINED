using SLZ.Marrow;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class SeatEvent : MonoBehaviour
	{
		[InspectorDisplayName("Seat")]
		[Tooltip("Seat script goes here")]
		public Seat seat;

		[Header("Events")]
		[Tooltip("Event to fire on player seated")]
		[SerializeField]
		private UnityEvent OnSeat;

		[Tooltip("Event to fire on player unseated")]
		[SerializeField]
		private UnityEvent OnUnseat;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSeated()
		{
		}

		private void OnUnSeated()
		{
		}
	}
}
