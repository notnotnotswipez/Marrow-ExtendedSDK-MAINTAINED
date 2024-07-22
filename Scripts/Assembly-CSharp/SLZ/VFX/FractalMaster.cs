using UnityEngine;

namespace SLZ.VFX
{
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	public class FractalMaster : MonoBehaviour
	{
		public ComputeShader fractalShader;

		[Range(0.1f, 1.5f)]
		public float ResolutionScaler;

		public Vector3 offset;

		public float nearClip;

		[Range(1f, 20f)]
		public float fractalPower;

		public float darkness;

		[Range(0f, 1f)]
		[Header("Colour mixing")]
		public float blackAndWhite;

		[Range(0f, 1f)]
		public float redA;

		[Range(0f, 1f)]
		public float greenA;

		[Range(0f, 1f)]
		public float blueA;

		[Range(0f, 1f)]
		public float redB;

		[Range(0f, 1f)]
		public float greenB;

		[Range(0f, 1f)]
		public float blueB;

		private RenderTexture target;

		private Camera cam;

		private Light directionalLight;

		private Vector2Int res;

		[Header("Animation Settings")]
		public float powerIncreaseSpeed;

		private void Start()
		{
		}

		private void Init()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void RunFunction()
		{
		}

		private void SetParameters()
		{
		}

		private void InitRenderTexture()
		{
		}
	}
}
