using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PathCreation;
using PathCreation.Examples;
using Unity.MLAgents;
using UnityEngine;
using UnityEngine.AI;

namespace SLZ.MLAgents
{
	[RequireComponent(typeof(TrackUtils))]
	public class TrackClass : MonoBehaviour
	{
		public delegate void RegenDelegate();

		public TrackUtils utils;

		[Header("Generation Params")]
		[Tooltip("Mask used for navmesh generation")]
		public int roadMask;

		[Tooltip("Radius of track or used to derive length of straight track")]
		public float radius;

		[Tooltip("Percent of length to chunk the track")]
		public float partitionLengthPercent;

		[Tooltip("Connect final segment to first segment (used in circular tracks)")]
		public bool continuousTrack;

		[Tooltip("Amount of points used to generate initial track (pre bez path)")]
		public int nb_verts;

		[Tooltip("Smaller values = more smooth")]
		public float pathSmoothScale;

		[Tooltip("Percent of vertex point distance to spawn checkpoints at")]
		public float cpVertPercent;

		[Tooltip("Amount of checkpoints to be evenly distributed throughout track / within partitions")]
		public int nbCheckpoints;

		[Tooltip("Full width of track - /2 for half")]
		public float road_width;

		[Tooltip("Thickness of Road Mesh")]
		public float road_thickness;

		[Tooltip("Max alowable twist (normal) when track is generated [0-1]")]
		public float maxTrackTwist;

		[Tooltip("Source of noise in displacing points (x & z)")]
		public float origin_range;

		[Tooltip("Source of noise in displacing points (y)")]
		public float m_SlopeScale;

		[Tooltip("Whether to prevent curves from overlapping")]
		public bool displacePoints;

		[Tooltip("Radius of effect for each point - used in preventing curves from overlapping")]
		public float track_point_rad;

		[Tooltip("Distance to move point on each tick of displacement")]
		public float adjust_dist;

		[Header("Road Components")]
		private RoadMeshCreator_Custom rmc;

		[Tooltip("For adding more or less friction on the road")]
		public PhysicMaterial roadPhysMaterial;

		[Tooltip("Material to applied to top of the track")]
		public Material roadMaterial;

		[Tooltip("Material to applied to bottom of the track")]
		public Material roadUndersideMaterial;

		[Tooltip("Tiling factor to apply to each material")]
		public int texture_tiling;

		[SerializeField]
		[Tooltip("Master path data used to generate mesh and query where things are on track")]
		public VertexPath vp;

		[Tooltip("Original bez path that created the track")]
		public BezierPath bp;

		[Tooltip("Switch used to fire off a regeneration event")]
		public bool regen_bool;

		public RegenDelegate regenDelegate;

		[Tooltip("Generate Walls on Side of Track")]
		[Header("Track Objects Section")]
		public bool useWalls;

		[Tooltip("(unused) Game Object reference for instancing single walls")]
		public GameObject wallPrefab;

		[Tooltip("All walls placed on track")]
		public List<GameObject> wallsList;

		[Tooltip("Spawn checkpoints on track")]
		public bool use_checkpoints;

		[Tooltip("Game Object reference for track utils functions")]
		public GameObject checkpointPrefab;

		[HideInInspector]
		[Tooltip("All checkpoints placed on track")]
		public bool cp_reverse_switch;

		public GameObject[] checkpointArray;

		[Tooltip("Spawn obstacles on track")]
		public bool useObstacles;

		[Tooltip("List of different types of obstacles to use")]
		public GameObject[] obstacleVariants;

		[Tooltip("Probability of selecting each type of obstacle (should add to 1)")]
		public float[] obstacleProbs;

		[Tooltip("List of all obstacles placed on track")]
		public List<GameObject> obsList;

		[Tooltip("Instantiate a navmesh (primarily use is nav buffer sensor)")]
		public bool useNavmesh;

		[Tooltip("Trigger collider spawned at lowest point of track used for despawning enemies that have fallen")]
		public bool use_fall_collider;

		[Tooltip("Game Object reference debugging vertex points on path")]
		public GameObject vertPrefab;

		[Tooltip("Reference array")]
		public List<GameObject> new_cp_arr;

		[Tooltip("Name of component on vehicle that is checked on passthrough of checkpoint")]
		public string vehicleComponentCpName;

		[Tooltip("Size of obstacles on track (set by env params)")]
		public float obs_size;

		[Tooltip("Size of obstacles on track (set by env params)")]
		public float min_obs_size;

		[Tooltip("Size of obstacles on track (set by env params)")]
		public float max_obs_size;

		[Tooltip("Min and Max obstacle weight to sample from when spawning obs")]
		public float minObsWeight;

		public float maxObsWeight;

		[Tooltip("0-1 normalized percentage of all obstacle zones on track to spawn obstacles in")]
		public float nb_obstacle_zones;

		[Tooltip("integer number of obstacles to place in a zone")]
		public float obstacles_per_zone;

		[Tooltip("List of jumps placed on track")]
		public GameObject[] jumpArray;

		[Tooltip("Prefab reference")]
		public GameObject jump;

		[Tooltip("Total number of jumps to place on track")]
		public float nb_jumps;

		[Tooltip("Debug mode displays vertex points and the radii used for moving points that are too close")]
		[Header("MISC")]
		public bool debug_mode;

		[Tooltip("Debug mode displays points in bez path generation")]
		public bool debug_track_gen;

		[Tooltip("Constructs an additional RMC for displaying the non-partitioned representation of the path")]
		public bool showMasterTrack;

		[HideInInspector]
		public Vector3[] dbgTrackPoints;

		[Tooltip("Whether to use env params to set the track gen attributes")]
		public bool inferenceSwitch;

		[Tooltip("Whether to use env params or default vals")]
		public bool use_cur;

		[HideInInspector]
		public float cpSpacing;

		[Tooltip("Previously used as source of noise in displacing points")]
		[HideInInspector]
		public float perlinMod;

		[HideInInspector]
		public float m_CurveScale;

		[HideInInspector]
		public Vector3 start_pos;

		[HideInInspector]
		public float length;

		[HideInInspector]
		public GameObject meshHolder;

		[HideInInspector]
		public MeshFilter holder_mf;

		[HideInInspector]
		public TrackGenerator trackGenerator;

		[HideInInspector]
		public GameObject spawn;

		[HideInInspector]
		public NavMeshSurface surface;

		[HideInInspector]
		public EnvironmentParameters envParams;

		[Tooltip("Array used for debugging the vertex points")]
		public Vector3[] masterPoints;

		[Tooltip("To use a bez path reference and not generate a new bez path")]
		public bool trackPremade;

		[Tooltip("Path Data Object that stores a premade bezier path")]
		public PathCreator pathData;

		[Tooltip("To split the master path into partitions that can be set active and inactive")]
		public bool usePartitions;

		public static bool Regen
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public event Action OnReset
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void OnDrawGizmos()
		{
		}

		private void OnValidate()
		{
		}

		public void SetFromEnvParams()
		{
		}

		[ContextMenu("OnReset")]
		public void ResetListener()
		{
		}

		public void PlaceTrackObjects()
		{
		}

		public virtual void RemoveTrackObjects()
		{
		}

		public Vector3 GetVPBetweenCheckpoints(Vector3 first_pos, Vector3 second_pos)
		{
			return default(Vector3);
		}

		public Vector3 GetRotBetweenCheckpoints(Vector3 pos, GameObject first)
		{
			return default(Vector3);
		}
	}
}
