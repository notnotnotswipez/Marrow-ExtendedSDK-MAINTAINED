using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgentsExamples;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BaseVehicleSensors : MonoBehaviour
	{
		[Tooltip("The vehicle the senors connected to")]
		public BaseVehicle vehicle;

		protected int nbObjectiveParams;

		protected float[] objectiveParams;

		[Tooltip("Each objective can have its own desired speed, sometimes you may want to ignore this")]
		public bool ignoreObjectiveSpeed;

		[HideInInspector]
		public VehicleSceneContextManager contextManager;

		[Tooltip("Currently only works for unity wheel colliders, sphere colliders need their own raycast to check this")]
		public int nb_wheels_off_ground;

		[Tooltip("Switch controlled via a velocity threshold")]
		public bool notMoving;

		[Tooltip("Time till the vehicle is reset for not moving")]
		public float noMoveMaxTime;

		[Tooltip("Clock counting how long vehicle hasnt moved")]
		private float noMoveTimer;

		[Tooltip("Critical AI component that is used as a point of reference for observations")]
		public OrientationCubeController orientation_cube;

		[Header("Observation Switches")]
		public bool use_context;

		[Tooltip("Observations wrt current objective")]
		public bool use_tansform_observations;

		[Tooltip("Extra observation component for obstacles as well as other vehicles")]
		public bool use_obstacle_buffer;

		public bool use_wheels_grounded;

		[Tooltip("Velocity wrt to current objective and desired velocity")]
		public bool use_vel_vector;

		[Tooltip("Velocity wrt to current objective and desired velocity")]
		public bool use_vel_magnitude;

		[Tooltip("Velocity wrt to current objective and desired velocity")]
		public bool useMaxSpeedEver;

		[Tooltip("See reference to previous steering val")]
		public bool use_steering;

		[Tooltip("See if colliding")]
		public bool use_colliding;

		public string[] detectableColliders;

		[Tooltip("See angle relative from car to objective")]
		public bool use_norm_angle;

		[Tooltip("Signed bool if forward is pointing within angle range of current objective")]
		public bool use_euler_facing;

		[Tooltip("Observe weight of car and center of mass")]
		public bool use_weight;

		[Tooltip("Sum of masses from all children rigidbodies")]
		public float total_mass;

		[Tooltip("Average center of mass from all rigidbodies")]
		public Vector3 com;

		[Tooltip("Whether to continually update the mass values for the observation")]
		public bool updateMassObs;

		[Tooltip("Size of nav mesh path segment to observe if using navbuffer")]
		public int nav_window_size;

		[Tooltip("Reference to nav buffer sensor component")]
		public BufferSensorComponent nav_buffer;

		[Tooltip("Whether to debug draw the nav path as its calculated for buffer component")]
		public bool display_navpath;

		[Tooltip("Threshold values for euler facing observation")]
		public float euler_lower;

		[Tooltip("Threshold values for euler facing observation")]
		public float euler_upper;

		[Header("Radius Section")]
		[Tooltip("Degree at which the forward vector is pointing towards the current objective")]
		public float facing_objective;

		[Tooltip("Outer Radius Size for Objective object")]
		public float prox_radius;

		[Tooltip("Inner Radius Size for Objective object")]
		public float goal_radius;

		[Tooltip("Distance from center of objective")]
		public float goal_radius_distance;

		private float from_center_distance;

		[Tooltip("Squish mode is when the objective is to be between the two radii, while off the objective is to be within the inner radius")]
		public bool squish_mode;

		[Tooltip("May want to prevent the sensor from knowing when the radii values are changed on the current objective")]
		public bool blockRadiusChange;

		[Tooltip("Whether the goal is to stay in or drive through objective")]
		public bool driveThrough;

		public bool hasAttempted;

		[Tooltip("Value used in normalization of the distances read in by the sensor")]
		public float max_lim;

		[Tooltip("Value used in normalization of the distances read in by the sensor")]
		public float min_lim;

		[Tooltip("Max velocity values for normalizing Velocity Vector Observations")]
		public float max_vel;

		[Tooltip("Max velocity values for normalizing Velocity Vector Observations")]
		public float max_ang_vel;

		[HideInInspector]
		public float euler_facing;

		[HideInInspector]
		public float norm_angle;

		[Tooltip("Vector distance between desired and actual velocity vectors")]
		public float targetSpeedDistance;

		[Tooltip("Desired velocity vector (used temporarily in calculations)")]
		public Vector3 velGoal;

		[Tooltip("Current velocity vector")]
		public float curVelMag;

		[Tooltip("Desired velocity vector")]
		public float desiredVelMag;

		public Vector3 velVec;

		public float velMag;

		[Tooltip("If the car is in center bubble")]
		public bool inVolume;

		[Tooltip("If the car is in outer bubble")]
		public bool inProx;

		[Header("Log Section")]
		[Tooltip("Log all sensor values")]
		public bool logSensors;

		[Tooltip("Log the distances from the radii")]
		public bool log_distances;

		[Tooltip("List used for debugging/easily viewing sensor values in editor")]
		public List<float> dbgInput;

		private StatsRecorder statsRecorder;

		public string collisionString;

		public bool statsRecording;

		private float euler_sign;

		private Vector2 oc;

		private Vector2 frwd;

		private float sign;

		private Vector3 norm_ball;

		private Vector3 norm_boid;

		public float[] ObjectiveParams
		{
			get
			{
				return null;
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

		private void CheckSquishMode()
		{
		}

		private void Awake()
		{
		}

		private void EulerFacing()
		{
		}

		private void GetFacingObjective()
		{
		}

		private void CheckNoMove()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		public void CollectObservations(VectorSensor sensor)
		{
		}

		public void CollectObservations(VectorSensor sensor, BaseInferenceSensor[] customSensors = null)
		{
		}

		public void CollectObservations(InferenceAgent agent)
		{
		}

		private void CustomSensors(BaseInferenceSensor[] baseSensors, InferenceAgent agent)
		{
		}

		private void CustomSensors(BaseInferenceSensor[] baseSensors, VectorSensor sensor)
		{
		}

		private void ContextObservations(VectorSensor sensor)
		{
		}

		private void ContextObservations(InferenceAgent agent)
		{
		}

		public void MassObservations(VectorSensor sensor)
		{
		}

		public void MassObservations(InferenceAgent agent)
		{
		}

		public void CheckWheelsGrounded(VectorSensor sensor)
		{
		}

		public void CheckWheelsGrounded(InferenceAgent agent)
		{
		}

		public void ObserveVelocity(VectorSensor sensor)
		{
		}

		public void ObserveVelocity(InferenceAgent agent)
		{
		}

		public void ObserveVelVector(VectorSensor sensor)
		{
		}

		public void ObserveVelVector(InferenceAgent agent)
		{
		}

		public void ObserveVelMagnitude(VectorSensor sensor)
		{
		}

		public void ObserveVelMagnitude(InferenceAgent agent)
		{
		}

		public void ObserveSteeringDelta(VectorSensor sensor)
		{
		}

		public void ObserveSteeringDelta(InferenceAgent agent)
		{
		}

		public void ObserveEulerFacing(VectorSensor sensor)
		{
		}

		public void ObserveEulerFacing(InferenceAgent agent)
		{
		}

		public void ObserveColliding(VectorSensor sensor)
		{
		}

		public void ObserveColliding(InferenceAgent agent)
		{
		}

		private void AttemptCheck()
		{
		}

		private void InProxCheck()
		{
		}

		public float SquishCheck()
		{
			return 0f;
		}

		private float StandardCheck(float from_radius_distance)
		{
			return 0f;
		}

		public void TransformObservations(VectorSensor sensor, OrientationCubeController orientation_cube, Rigidbody _rb)
		{
		}

		public void TransformObservations(InferenceAgent agent, OrientationCubeController orientation_cube, Rigidbody _rb)
		{
		}

		public Vector3 ProximityDelta()
		{
			return default(Vector3);
		}

		private float MinMaxNorm(float val, float max, float min)
		{
			return 0f;
		}
	}
}
