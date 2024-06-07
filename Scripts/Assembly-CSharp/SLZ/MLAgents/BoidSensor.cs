using Unity.MLAgents.Sensors;
using Unity.MLAgentsExamples;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BoidSensor : MonoBehaviour
	{
		public OrientationCubeController orientation_cube;

		public Rigidbody[] boidBuffer;

		public Vector3[] boidBufferPositions;

		public float neighbor_radius;

		public int maxObservations;

		public int bufferDelay;

		private int bufferCounter;

		public float goal_radius_distance;

		public int enemyColLayer;

		public string bufferSearchString;

		public int[] detectableLayers;

		public float ray_val;

		public float personalSpaceRadius;

		private Vector3 tempBufferPosition;

		public float[] rayData;

		public bool seeBumperRays;

		public int ray_layer_mask;

		private int buffer_layer_mask;

		public bool debugGizmos;

		public bool log_distances;

		public bool useDebugArray;

		public float[] obs_array;

		public int obs_counter;

		private float from_center_distance;

		public float prox_radius;

		public float goal_radius;

		[HideInInspector]
		public bool being_shot;

		public bool squish_mode;

		public bool blockRadiusChange;

		public bool logSensors;

		private Vector3 avg_pos;

		private Vector3 avg_pspace;

		private Vector3 avg_alignment;

		private Vector3 avg_velocity;

		private Vector3 avg_vel_distance;

		public int current_in_buffer;

		public BoidController boidController;

		private int processed;

		private int num_added;

		private float radiusCheckVal;

		private Vector3 cubeForward;

		private float from_radius_distance;

		private float norm_goal_radius_distance;

		private Collider[] overlapColliders;

		private float orientationAngle;

		private Quaternion orientationRotation;

		private float radiusValue;

		private Vector3 proximityDelta;

		private Vector3 neighborPos;

		private float neighborAlignment;

		public Vector3 Cohesion
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Alignment
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3[] Separation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 GroupVelocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 AvgPersonalSpace
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		private void OnDrawGizmos()
		{
		}

		public void SetProxRadius(float prox_radius)
		{
		}

		public void SetGoalRadius(float goal_radius)
		{
		}

		public void SetSquishMode(bool squish_mode)
		{
		}

		public void SetBeingShot(bool being_shot)
		{
		}

		public void BoidBufferLoop()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		public void UpdateOrientationObjects()
		{
		}

		private void CallBoidBuffer()
		{
		}

		private float StandardCheck(float from_radius_distance)
		{
			return 0f;
		}

		public float SquishCheck()
		{
			return 0f;
		}

		public void TransformObservations(VectorSensor sensor, OrientationCubeController orientation_cube, Rigidbody _rb)
		{
		}

		public void TransformObservations(InferenceAgent agent, OrientationCubeController orientation_cube, Rigidbody _rb)
		{
		}

		public void RayObservations(ref float ray_val, VectorSensor sensor)
		{
		}

		public void RayObservations(ref float ray_val, InferenceAgent agent)
		{
		}

		public void CentroidObservations(VectorSensor sensor)
		{
		}

		public void CentroidObservations(InferenceAgent agent)
		{
		}

		public void BoidObservations(VectorSensor sensor)
		{
		}

		public void BoidObservations(InferenceAgent agent)
		{
		}

		public void BoidBallHitObservations(VectorSensor sensor)
		{
		}

		public void BoidBallHitObservations(InferenceAgent agent)
		{
		}
	}
}
