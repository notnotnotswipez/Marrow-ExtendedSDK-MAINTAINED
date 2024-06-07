using SLZ.Marrow.Utilities;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class SeatEvent : MonoBehaviour
	{
		[InspectorDisplayName("Seat")]
		[Tooltip("Seat script goes here")]
		public Seat seat;

		[SerializeField]
		[Tooltip("Event to fire on player seated")]
		[Header("Events")]
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
