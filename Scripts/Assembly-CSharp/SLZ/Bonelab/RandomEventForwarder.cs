using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class RandomEventForwarder : MonoBehaviour
	{
		public UnityEvent randomEvent;

		[Range(0f, 1f)]
		public float probability;

		public float minCoolDownTime;

		private float lastTime;

		public void CallEvent()
		{
		}
	}
}
