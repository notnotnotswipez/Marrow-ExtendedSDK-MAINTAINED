using UnityEngine;

namespace Ara
{
	[RequireComponent(typeof(AraTrail))]
	public class ElectricalArc : MonoBehaviour
	{
		private AraTrail trail;

		public Transform source;

		public Transform target;

		public int points;

		public float burstInterval;

		public float burstRandom;

		public float speedRandom;

		public float positionRandom;

		private float accum;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void ChangeArc()
		{
		}
	}
}
