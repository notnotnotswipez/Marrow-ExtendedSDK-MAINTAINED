using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PathCreation;
using PathCreation.Examples;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class StrippedTrackGenerator : PathCreator
	{
		[HideInInspector]
		public VertexPath vp;

		public bool regen_bool;

		public GameObject meshHolder;

		public GameObject checkpointPrefab;

		public float spacing;

		private GameObject[] new_cp_arr;

		public float radius;

		public int nb_verts;

		public bool useWalls;

		public float max_amp;

		public float max_ang_freq;

		public int max_phase;

		public float perlinMod;

		public float road_width;

		public float min_point_distance;

		public float origin_range;

		private List<GameObject> debugObjArr;

		[Tooltip("Curvature noise scale.")]
		[SerializeField]
		private float m_CurveScale;

		[SerializeField]
		[Tooltip("Slope noise scale.")]
		private float m_SlopeScale;

		[SerializeField]
		private float m_NoiseBias;

		private int m_StepCount;

		private Vector2 m_CurveOffset;

		private Vector2 m_SlopeOffset;

		private Vector3 m_NextPos;

		private Vector3 m_DefPos;

		public GameObject vertPrefab;

		public GameObject wallPrefab;

		private List<GameObject> wallsList;

		[SerializeField]
		public RoadMeshCreator_Custom rmc;

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

		[HideInInspector]
		public event Action OnGenerated
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

		public Vector3[] NoiseCircle(Vector3[] circle)
		{
			return null;
		}

		public Vector3[] OriginCircle(Vector3[] circle)
		{
			return null;
		}

		public void DisplayVecArr(Vector3[] arr)
		{
		}

		public Vector3[] VectorArrMult(Vector3[] a, Vector3[] b)
		{
			return null;
		}

		public Vector3[] VectorArrSum(Vector3[] a, Vector3[] b)
		{
			return null;
		}

		public Vector3[] GetCircleVerts()
		{
			return null;
		}

		public Vector3[] GetSineWave()
		{
			return null;
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

		private void DestroyArrObjs(GameObject[] arr)
		{
		}

		private void DestroyArrListObjs(List<GameObject> arr)
		{
		}

		public void GeneratePath()
		{
		}
	}
}
