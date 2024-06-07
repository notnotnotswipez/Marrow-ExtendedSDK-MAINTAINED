using System.Threading;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AnalogClock : MonoBehaviour
	{
		public MarrowEntity entity;

		public Transform hours;

		public Transform minutes;

		public Transform seconds;

		public AnimationCurve curve_Pendulum;

		public Transform[] pendulum;

		public float mod_pendulum;

		private CancellationTokenSource loopCancelToken;

		private Vector3 pendulumRot;

		private float cur_penTime;

		private const float hoursToDegrees = 30f;

		private const float minutesToDegrees = 6f;

		private const float secondsToDegrees = 6f;

		private void Reset()
		{
		}

		private void Update()
		{
		}
	}
}
