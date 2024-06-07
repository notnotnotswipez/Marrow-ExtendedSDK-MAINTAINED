using Unity.MLAgents.Sensors;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class EyeJitter : MonoBehaviour
	{
		private RayPerceptionSensorComponent3D ray_caster;

		private int rays_per_dir;

		private float max_ray_deg;

		private float deg_per_ray;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
