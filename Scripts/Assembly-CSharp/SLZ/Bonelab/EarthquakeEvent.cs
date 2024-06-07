using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class EarthquakeEvent : MonoBehaviour
	{
		[Serializable]
		public class Events
		{
			public float time;

			public Rigidbody rb;

			public Transform atPosition;

			public float magnitude;

			public ConfigurableJoint joint;
		}

		public List<Events> events;

		public AudioClip earthquakeStart;

		private float _startTime;

		private int _index;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}
	}
}
