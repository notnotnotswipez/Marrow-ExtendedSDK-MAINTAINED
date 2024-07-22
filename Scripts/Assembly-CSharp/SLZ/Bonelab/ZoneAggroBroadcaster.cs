using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ZoneAggroBroadcaster : MonoBehaviour
	{
		private float _broadcastFrequencySeconds;

		private readonly Collider[] _colliers;

		private float _lastTimeEventWasBroadcasted;

		private void Start()
		{
		}

		private void OnGunFired(Gun gun)
		{
		}
	}
}
