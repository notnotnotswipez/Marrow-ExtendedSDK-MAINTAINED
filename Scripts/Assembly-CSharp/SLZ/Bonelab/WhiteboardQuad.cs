using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(MeshRenderer))]
	[RequireComponent(typeof(Collider))]
	[RequireComponent(typeof(MeshFilter))]
	public class WhiteboardQuad : MonoBehaviour
	{
		private struct penInfo
		{
			public WhiteboardPen penData;

			public Transform transform;

			public Vector3 position;

			public Vector3 prevPosition;

			public Vector3 prevPosition2;
		}

		[SerializeField]
		private ComputeShader WhiteboardCompute;

		[SerializeField]
		private Shader BlitShader;

		public Texture2D SeedTexture;

		private Vector2Int textureDim;

		public Vector2Int textureDimPC;

		public Vector2Int textureDimAndroid;

		public bool lowBitPC;

		public bool lowBitQ;

		public Color MonoColor;

		private bool lowBit;

		private LocalKeyword lowBitKW;

		private Mesh mesh;

		public bool flipX;

		public bool flipY;

		public bool flipZ;

		private Vector3 FlipAxis;

		private int prevPenPosProp;

		private int prevPenPos2Prop;

		private int penPosProp;

		private int penWidthFProp;

		private int resultDimProp;

		private int colorProp;

		private int strokeBoundsProp;

		private int quadBoundsProp;

		private Material blitMaterial;

		private Shader resultCopy;

		private int inputProp;

		private bool materialSet;

		private int WBInitKern;

		private int WBUpdateKern;

		private int WBInitEraseKern;

		private int WBUpdateEraseKern;

		private int ResultProp;

		private Vector4 resultDim;

		private List<penInfo> pens;

		private RenderTexture Result;

		[SerializeField]
		private bool initBounds;

		public Bounds boardBounds;

		private Vector4 quadBounds;

		private Vector3 objectScale;

		private Vector3 objectScale2;

		private Matrix4x4 WorldToUniformObj;

		private int mipTimer;

		private void SetSharedComputeProps()
		{
		}

		public void UpdateObjectScale()
		{
		}

		public void UpdateFlippedAxes()
		{
		}

		public Bounds GetMeshBounds()
		{
			return default(Bounds);
		}

		private Vector4 StrokeBounds(Vector3 prevPos, Vector3 currPos, Vector2Int textureDim1, Vector4 quadBounds1, float radius)
		{
			return default(Vector4);
		}

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision colData)
		{
		}

		private void OnCollisionExit(Collision colData)
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
