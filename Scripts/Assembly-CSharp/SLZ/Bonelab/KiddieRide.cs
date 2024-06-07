using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace SLZ.Bonelab
{
	public class KiddieRide : MarrowBehaviour, IMarrowEntityCullable
	{
		[SerializeField]
		private ConfigurableJoint rideJoint;

		[SerializeField]
		private Vector3 rideAxis;

		[SerializeField]
		private PlayableDirector director;

		[SerializeField]
		private float amplitude;

		[SerializeField]
		private float omega;

		[SerializeField]
		private UnityEvent toggleOnEvent;

		[SerializeField]
		private UnityEvent toggleOffEvent;

		private float index;

		private bool isPowered;

		private void FixedUpdate()
		{
		}

		public void TogglePower()
		{
		}

		public void OnEntityCull()
		{
		}

		public void OnEntityUncull()
		{
		}
	}
}
