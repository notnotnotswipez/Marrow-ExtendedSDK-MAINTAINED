using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PathCreation;
using PathCreation.Examples;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class TrackGenerator : PathCreator
	{
		[Header("Full Track Section")]
		[Tooltip("TrackGenerator gets reference values from the TrackClass/InfTrackClass")]
		public TrackClass trackClass;

		[SerializeField]
		public RoadMeshCreator_Custom rmc;

		[Tooltip("List of all road mesh chunks")]
		public List<RoadMeshCreator_Custom> rmcs;

		[Tooltip("List of all inner wall mesh chunks")]
		public List<RoadMeshCreator_Custom> innerWalls;

		[Tooltip("List of all outer wall mesh chunks")]
		public List<RoadMeshCreator_Custom> outerWalls;

		[Tooltip("Reference for predefined path")]
		public PathCreator pathCreator;

		[HideInInspector]
		[Header("Partition Section")]
		public bool usePartitions;

		[Tooltip("Length of bez path that designates a partition (as a fraction of total)")]
		public float partitionLengthPercent;

		[Tooltip("How many chunks to have active before and after current chunk")]
		public float windowSize;

		[Tooltip("What is used to keep track of what partitions to load")]
		public GameObject heroObject;

		[Tooltip("False for chunked tracks, true for a single track")]
		public bool continuousTrack;

		[Header("MISC Section")]
		[Tooltip("For triggering regeneration event")]
		public bool regen_bool;

		[Tooltip("Display debug objects (vertex path points)")]
		public bool debug_mode;

		[HideInInspector]
		public bool collision_free;

		private string assetPath;

		private float inner_scale;

		private float outer_scale;

		private float vertDistance;

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

		public event Action TrackGenerated
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

		private void Start()
		{
		}

		private void OnValidate()
		{
		}

		public void DisplacePoints(ref Vector3[] points)
		{
		}

		private BezierPath MakeBezPath()
		{
			return null;
		}

		private void MakeVertexPath()
		{
		}

		private void DisplayMasterPath(ref VertexPath innerVp, ref VertexPath outerVp)
		{
		}

		private void MakeWalls(ref VertexPath innerVp, ref Vector3[] innerWallVerts, ref VertexPath outerVp, ref Vector3[] outerWallVerts)
		{
		}

		private void MakeWallPartitions(int i, GameObject road_partition_go, float nb_splits, int bp_counter, float pointsPerPartition, float finalLeftover, bool lastPart, VertexPath innerVp = null, Vector3[] innerWallVerts = null, VertexPath outerVp = null, Vector3[] outerWallVerts = null)
		{
		}

		private void MakeChunkTriggers(int i, GameObject road_partition_go, float nb_splits, int bp_counter)
		{
		}

		private void MakePartitions(VertexPath innerVp = null, Vector3[] innerWallVerts = null, VertexPath outerVp = null, Vector3[] outerWallVerts = null)
		{
		}

		[ContextMenu("Generate Path")]
		public void GeneratePath()
		{
		}

		private void MaterializeRMC(RoadMeshCreator_Custom rmc, GameObject temp_part_go, PathCreator pathCreator, VertexPath vp, Material top, Material bottom, float width, float thickness, float tileVal, VertexPath innerVp = null, VertexPath outerVp = null, PhysicMaterial roadPhysMat = null)
		{
		}

		private Vector3[] PaddedPoint(VertexPath vp, float width, int inner_outer)
		{
			return null;
		}

		private Vector3[] GenerateWallVerts(Vector3[] roadPoints, float s)
		{
			return null;
		}
	}
}
