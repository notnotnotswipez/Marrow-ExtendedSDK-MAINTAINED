using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class WhiteboardMesh : MonoBehaviour
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

		public Material copyTextureMaterial;

		public Material initBlitMaterial;

		public Material blitMaterial;

		private int prevPenPosProp;

		private int penPosProp;

		private int penWidthFProp;

		private int resultDimProp;

		private int colorProp;

		private int baseMapProp;

		private Shader resultCopy;

		private int inputProp;

		private Shader blitInit;

		private Shader blitMain;

		private RenderTexture Intermediate;

		private List<penInfo> pens;

		private RenderTexture Result;

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
