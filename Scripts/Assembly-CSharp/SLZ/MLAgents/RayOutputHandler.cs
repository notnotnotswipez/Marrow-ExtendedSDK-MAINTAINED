using Unity.MLAgents.Sensors;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class RayOutputHandler : MonoBehaviour
	{
		public RayPerceptionSensorComponent3D eye_reference;

		[HideInInspector]
		public RayPerceptionOutput eyes_output;

		private void FixedUpdate()
		{
		}
	}
}
