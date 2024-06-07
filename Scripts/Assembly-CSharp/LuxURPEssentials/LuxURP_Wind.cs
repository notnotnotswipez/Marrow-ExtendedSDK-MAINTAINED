using UnityEngine;

namespace LuxURPEssentials
{
	[RequireComponent(typeof(WindZone))]
	[ExecuteInEditMode]
	public class LuxURP_Wind : MonoBehaviour
	{
		[Space(-5f)]
		[Space(5f)]
		[LuxURP_HelpBtn("h.wnnhm4pxp610")]
		public bool UpdateInEditMode;

		[Header("Render Texture Settings")]
		public RTSize Resolution;

		public RTFormat Format;

		public Texture WindBaseTex;

		public Shader WindCompositeShader;

		[Header("Wind Multipliers")]
		public float Grass;

		public float Foliage;

		[Tooltip("Base Wind Speed in km/h at Main = 1 (WindZone)")]
		[Header("Wind Speed and Size")]
		public float BaseWindSpeed;

		[Tooltip("Size of the Wind RenderTexture in World Space")]
		public float SizeInWorldSpace;

		[Space(5f)]
		public float speedLayer0;

		public float speedLayer1;

		public float speedLayer2;

		[Header("Noise")]
		public int GrassGustTiling;

		public float GrassGustSpeed;

		public GustMixLayer LayerToMixWith;

		[Header("Jitter")]
		public float JitterFrequency;

		public float JitterHighFrequency;

		private RenderTexture WindRenderTexture;

		private Material m_material;

		private Vector2 uvs;

		private Vector2 uvs1;

		private Vector2 uvs2;

		private Vector2 uvs3;

		private int WindRTPID;

		private Transform trans;

		private WindZone windZone;

		private float mainWind;

		private float turbulence;

		private int LuxLWRPWindDirSizePID;

		private int LuxLWRPWindStrengthMultipliersPID;

		private int LuxLWRPSinTimePID;

		private int LuxLWRPGustPID;

		private int LuxLWRPGustMixLayerPID;

		private int LuxLWRPWindUVsPID;

		private int LuxLWRPWindUVs1PID;

		private int LuxLWRPWindUVs2PID;

		private int LuxLWRPWindUVs3PID;

		private int previousRTSize;

		private int previousRTFormat;

		private Vector4 WindDirectionSize;

		private static Vector3[] MixLayers;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupRT()
		{
		}

		private void GetPIDs()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}
	}
}
