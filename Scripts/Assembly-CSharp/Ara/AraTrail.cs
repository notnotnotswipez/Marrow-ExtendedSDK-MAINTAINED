using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace Ara
{
	[ExecuteInEditMode]
	public class AraTrail : MonoBehaviour
	{
		public enum TrailAlignment
		{
			View = 0,
			Velocity = 1,
			Local = 2
		}

		public enum TrailSpace
		{
			World = 0,
			Self = 1,
			Custom = 2
		}

		public enum TrailSorting
		{
			OlderOnTop = 0,
			NewerOnTop = 1
		}

		public enum Timescale
		{
			Normal = 0,
			Unscaled = 1
		}

		public enum TextureMode
		{
			Stretch = 0,
			Tile = 1,
			WorldTile = 2
		}

		public struct CurveFrame
		{
			public Vector3 position;

			public Vector3 normal;

			public Vector3 bitangent;

			public Vector3 tangent;


			public Vector3 Transport(Vector3 newTangent, Vector3 newPosition)
			{
				return default(Vector3);
			}
		}

		public struct Point
		{
			public Vector3 position;

			public Vector3 velocity;

			public Vector3 tangent;

			public Vector3 normal;

			public Color color;

			public float thickness;

			public float life;

			public float texcoord;

			public bool discontinuous;


			public static float CatmullRom(float p0, float p1, float p2, float p3, float t)
			{
				return 0f;
			}

			public static Point operator +(Point p1, Point p2)
			{
				return default(Point);
			}

			public static Point operator -(Point p1, Point p2)
			{
				return default(Point);
			}
		}

		public const float epsilon = 1E-05f;

		[Header("Overall")]
		[Tooltip("Trail cross-section asset, determines the shape of the emitted trail. If no asset is specified, the trail will be a simple strip.")]
		public TrailSection section;

		[Tooltip("Whether to use world or local space to generate and simulate the trail.")]
		public TrailSpace space;

		[Tooltip("Custom space to use when generating and simulating the trail")]
		public Transform customSpace;

		[Tooltip("Whether to use regular time.")]
		public Timescale timescale;

		[Tooltip("How to align the trail geometry: facing the camera (view) of using the transform's rotation (local).")]
		public TrailAlignment alignment;

		[Tooltip("Determines the order in which trail points will be rendered.")]
		public TrailSorting sorting;

		[Tooltip("Thickness multiplier, in meters.")]
		public float thickness;

		[Range(1f, 8f)]
		[Tooltip("Amount of smoothing iterations applied to the trail shape.")]
		public int smoothness;

		[Tooltip("Calculate accurate thickness at sharp corners.")]
		public bool highQualityCorners;

		[Range(0f, 12f)]
		public int cornerRoundness;

		[Header("Length")]
		[Tooltip("How should the thickness of the curve evolve over its lenght. The horizontal axis is normalized lenght (in the [0,1] range) and the vertical axis is a thickness multiplier.")]
		[FormerlySerializedAs("thicknessOverLenght")]
		public AnimationCurve thicknessOverLength;

		[Tooltip("How should vertex color evolve over the trail's length.")]
		[FormerlySerializedAs("colorOverLenght")]
		public Gradient colorOverLength;

		[Tooltip("How should the thickness of the curve evolve with its lifetime. The horizontal axis is normalized lifetime (in the [0,1] range) and the vertical axis is a thickness multiplier.")]
		[Header("Time")]
		public AnimationCurve thicknessOverTime;

		[Tooltip("How should vertex color evolve over the trail's lifetime.")]
		public Gradient colorOverTime;

		[Header("Emission")]
		public bool emit;

		[Tooltip("Initial thickness of trail points when they are first spawned.")]
		public float initialThickness;

		[Tooltip("Initial color of trail points when they are first spawned.")]
		public Color initialColor;

		[Tooltip("Initial velocity of trail points when they are first spawned.")]
		public Vector3 initialVelocity;

		[Tooltip("Minimum amount of time (in seconds) that must pass before spawning a new point.")]
		public float timeInterval;

		[Tooltip("Minimum distance (in meters) that must be left between consecutive points in the trail.")]
		public float minDistance;

		[Tooltip("Duration of the trail (in seconds).")]
		public float time;

		[Header("Physics")]
		[Tooltip("Toggles trail physics.")]
		public bool enablePhysics;

		[Tooltip("Amount of seconds pre-simulated before the trail appears. Useful when you want a trail to be already simulating when the game starts.")]
		public float warmup;

		[Tooltip("Gravity affecting the trail.")]
		public Vector3 gravity;

		[Tooltip("Amount of speed transferred from the transform to the trail. 0 means no velocity is transferred, 1 means 100% of the velocity is transferred.")]
		[Range(0f, 1f)]
		public float inertia;

		[Tooltip("Amount of temporal smoothing applied to the velocity transferred from the transform to the trail.")]
		[Range(0f, 1f)]
		public float velocitySmoothing;

		[Tooltip("Amount of damping applied to the trail's velocity. Larger values will slow down the trail more as time passes.")]
		[Range(0f, 1f)]
		public float damping;

		[Header("Rendering")]
		public Material[] materials;

		public ShadowCastingMode castShadows;

		public bool receiveShadows;

		public bool useLightProbes;

		[Tooltip("Quad mapping will send the shader an extra coordinate for each vertex, that can be used to correct UV distortion using tex2Dproj.")]
		[Header("Texture")]
		public bool quadMapping;

		[Tooltip("How to apply the texture over the trail: stretch it all over its lenght, or tile it.")]
		public TextureMode textureMode;

		[Tooltip("Defines how many times are U coords repeated across the length of the trail.")]
		public float uvFactor;

		[Tooltip("Defines how many times are V coords repeated trough the width of the trail.")]
		public float uvWidthFactor;

		[Tooltip("When the texture mode is set to 'Tile', defines where to begin tiling from: 0 means the start of the trail, 1 means the end.")]
		[Range(0f, 1f)]
		public float tileAnchor;

		[HideInInspector]
		public ElasticArray<Point> points;

		private ElasticArray<Point> renderablePoints;

		private List<int> discontinuities;

		private Mesh mesh_;

		private Vector3 velocity;

		private Vector3 prevPosition;

		private float accumTime;

		private List<Vector3> vertices;

		private List<Vector3> normals;

		private List<Vector4> tangents;

		private List<Vector4> uvs;

		private List<Color> vertColors;

		private List<int> tris;

		private Vector3 nextV;

		private Vector3 prevV;

		private Vector3 vertex;

		private Vector3 normal;

		private Vector3 bitangent;

		private Vector4 tangent;

		private Vector4 texTangent;

		private Vector4 uv;

		private Color color;

		private Action<ScriptableRenderContext, Camera> renderCallback;

		public Vector3 Velocity => default(Vector3);

		private float DeltaTime => 0f;

		private float FixedDeltaTime => 0f;

		public Mesh mesh => null;

		public Matrix4x4 worldToTrail => default(Matrix4x4);

		public event Action onUpdatePoints
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

		public void OnValidate()
		{
		}

		public void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void AttachToCameraRendering()
		{
		}

		private void DetachFromCameraRendering()
		{
		}

		public void Clear()
		{
		}

		private void UpdateVelocity()
		{
		}

		private void LateUpdate()
		{
		}

		private void EmissionStep(float time)
		{
		}

		private void Warmup()
		{
		}

		private void PhysicsStep(float timestep)
		{
		}

		private void FixedUpdate()
		{
		}

		public void EmitPoint(Vector3 position)
		{
		}

		private void SnapLastPointToTransform()
		{
		}

		private void UpdatePointsLifecycle()
		{
		}

		private void ClearMeshData()
		{
		}

		private void CommitMeshData()
		{
		}

		private void RenderMesh(Camera cam)
		{
		}

		public float GetLenght(ElasticArray<Point> input)
		{
			return 0f;
		}

		private ElasticArray<Point> GetRenderablePoints(int start, int end)
		{
			return null;
		}

		private CurveFrame InitializeCurveFrame(Vector3 point, Vector3 nextPoint)
		{
			return default(CurveFrame);
		}

		private void UpdateTrailMesh(Camera cam)
		{
		}

		private void UpdateSegmentMesh(int start, int end, Vector3 localCamPosition)
		{
		}

		private void AppendSection(Point[] data, ref CurveFrame frame, int i, int count, float sectionThickness, float vCoord)
		{
		}

		private void AppendFlatTrail(Point[] data, ref CurveFrame frame, int i, int count, float sectionThickness, float vCoord, ref int va, ref int vb)
		{
		}
	}
}
