using PathCreation;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BezPathGenerator : MonoBehaviour
	{
		public PathCreator pathCreator;

		[Tooltip("Resolution of track - literally how many points are used to define shape")]
		public int nb_verts;

		[Tooltip("Size of initial circle")]
		public float radius;

		[Tooltip("Maximum height of hills on track")]
		public float m_SlopeScale;

		[Tooltip("Amount of initial curves to put into the track")]
		public float origin_range;

		[Tooltip("Whether to connect the beginning and end of track or not")]
		public bool continuousTrack;

		[Tooltip("Use adjustments or not")]
		public bool adjustPoints;

		[Tooltip("See if there are potential collisions with radius points")]
		public float collisionRadius;

		[Tooltip("How much to adjust when there is a collision (larger vals will be quicker to solve but create big gaps)")]
		public float collisionAdjustDistance;

		[Tooltip("How many attempts at getting points collision free (to prevent infinite while loop)")]
		public int maxAdjustments;

		[Tooltip("Are the verticies going to collide (given the above collision radius)")]
		public bool collisionFree;

		[Tooltip("Display gizmos or not")]
		public bool useDebugGizmos;

		private Vector3[] origin_points;
	}
}
