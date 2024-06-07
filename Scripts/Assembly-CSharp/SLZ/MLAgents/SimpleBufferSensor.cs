using Unity.MLAgents.Sensors;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class SimpleBufferSensor : BaseInferenceSensor
	{
		[Tooltip("The max number of objects that can be detected")]
		public int maxObservations;

		[Tooltip("The bitmask representation of the layers detectable by the overlap sphere call")]
		public int interactive_layer_mask;

		[Tooltip("Array that will be used to calculate the bitmask")]
		public int[] interactiveLayers;

		[Tooltip("Array of object tags that will be used designating the detected objects type in neural net reference")]
		public string[] interactiveTags;

		[Tooltip("The size of the overlap cast")]
		public float bufferRadius;

		[Tooltip("This value is for normalizing the weight of detected game object")]
		public float maxRbWeight;

		[Header("Switch Section")]
		public bool sortByDistance;

		public bool use_location;

		public bool use_distance;

		public bool use_angles;

		public bool use_weight;

		public bool use_kinematic;

		public bool use_tags;

		[Header("Data Section")]
		[Tooltip("The normalized positions of the detected objects")]
		public Vector3[] bufferPositions;

		[Tooltip("The normalized distance from the sensor ref point")]
		public float[] bufferDistances;

		[Tooltip("The normalized angle of the detected objects")]
		public float[] bufferAngles;

		[Tooltip("The normalized weight of the detected objects")]
		public float[] bufferWeights;

		[Tooltip("If the detected objects are kinematic or not")]
		public float[] bufferInteraction;

		[Tooltip("The normalized tag representations")]
		public float[] bufferTags;

		[Header("Debug Section")]
		public bool debugGizmos;

		public bool log_distances;

		private int obs_counter;

		private Collider[] allOverlappingColliders;

		private float tagInd;

		private Rigidbody temp_rb;

		private float temp_weight;

		private Vector3 locationVector;

		private float distance;

		private float angle;

		private float is_kinematic;

		private int mask;

		private int num_added;

		private Color goal_radius_color;

		private void OnDrawGizmos()
		{
		}

		private void Awake()
		{
		}

		public override void Get()
		{
		}

		public override void Send(VectorSensor sensor)
		{
		}
	}
}
