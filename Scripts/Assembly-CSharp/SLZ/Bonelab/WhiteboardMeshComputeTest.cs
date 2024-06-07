using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class WhiteboardMeshComputeTest : MonoBehaviour
	{
		private struct penInfo
		{
			public WhiteboardPen penData;

			public Transform transform;

			public Vector3 position;

			public Vector3 prevPosition;
		}

		[SerializeField]
		private ComputeShader WhiteboardCompute;

		public Texture2D ObjPosTex;

		public Vector2Int textureDim;

		public Mesh mesh;

		private int prevPenPosProp;

		private int penPosProp;

		private int penWidthFProp;

		private int resultDimProp;

		private int colorProp;

		private Material blitMaterial;

		private Shader resultCopy;

		private int inputProp;

		private int WBInitKern;

		private int WBUpdateKern;

		private int ObjSpaceTexProp;

		private int ResultProp;

		private int bbMinProp;

		private int bbExtentsProp;

		private Vector4 resultDim;

		private List<penInfo> pens;

		private RenderTexture Result;

		private Vector3 meshBoundsMin;

		private Vector3 meshBoundsExtents;

		private int mipTimer;

		private void Start()
		{
		}

		private void SetSharedComputeProps()
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
