using System;
using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class TextureStreamingDebugTool : MonoBehaviour
	{
		[Serializable]
		public struct ObjectDebug
		{
			public GameObject gameObject;

			public List<ObjectRendererDebug> rendererDebugs;

			public ulong totalTextureMemory;

			public ulong totalMemory;

			private List<Texture2D> totalTextureSet;


			public void CalcTotalMemory()
			{
			}
		}

		[Serializable]
		public struct ObjectRendererDebug
		{
			public GameObject gameObject;

			public Renderer renderer;

			public MeshFilter filter;

			public List<ObjectMaterialDebug> materials;

			public ulong totalTextureMemory;

			private List<Texture2D> totalTextureSet;


			public void CalcTotalMemory()
			{
			}
		}

		[Serializable]
		public struct ObjectMaterialDebug
		{
			public string materialName;

			public Material material;

			public List<MaterialTexture> materialTextures;

			public MaterialTexture? mainTexture;

			public ulong totalTextureMemory;

			private List<Texture2D> totalTextureSet;


			public void CalcTotalMemory()
			{
			}

			public bool IsMainTexture(Texture tex)
			{
				return false;
			}

			public bool IsMainTexture(MaterialTexture matTex)
			{
				return false;
			}
		}

		[Serializable]
		public struct MaterialTexture
		{
			public string shaderPropertyName;

			public Texture2D texture;

			public ulong textureMemory;

			public bool customMip;

			private int lastMipLevel;


			public void SetCustomMip(int level)
			{
			}

			public void ResetCustomMip()
			{
			}

			public void CalcMemory()
			{
			}
		}

		[Serializable]
		public struct CachedBoundBox
		{
			public GameObject boundBox;

			public MeshRenderer boxRenderer;

			public MeshRenderer outerBoxRenderer;

			public MeshRenderer innerBoxRenderer;

			public TextMeshPro[] mipTexts;
		}

		[Serializable]
		public struct TexturePreviewBox
		{
			public GameObject gameObject;

			public RawImage image;

			public Image desiredMipImage;

			public Image loadedMipImage;

		}

		private enum Modes
		{
			NextRenderer = 0,
			PreviousRenderer = 1,
			ToggleStreaming = 2,
			IncreaseBudget = 3,
			DecreaseBudget = 4,
			IncreaseMaxLevelReduction = 5,
			DecreaseMaxLevelReduction = 6,
			DiscardUnusedMips = 7,
			IncreaseMaxFileRequests = 8,
			DecreaseMaxFileRequests = 9
		}

		[Header("Text Display Options")]
		public bool lockPosition;

		public bool lockOffhandPosition;

		public bool lockControls;

		public bool fullLock;

		[Header("References")]
		public GameObject boundBoxPrefab;

		public GameObject pointer;

		public Transform offhand;

		public Transform globalPanel;

		public Transform globalPanelDock;

		[FormerlySerializedAs("textMesh")]
		public TextMeshPro debugTextMesh;

		public TextMeshPro globalDebugTextMesh;

		public TextMeshPro modeDebugTextMesh;

		public float totalV;

		public float budgetV;

		public float desiredV;

		public float currentV;

		public TMP_Text totalText;

		public TMP_Text budgetText;

		public TMP_Text desiredText;

		public TMP_Text currentText;

		public RectTransform budgetBar;

		public RectTransform desiredBar;

		public RectTransform currentBar;

		public TMP_Text systemMemText;

		public TMP_Text appMemText;

		public TMP_Text textureMemText;

		public RectTransform appMemBar;

		public RectTransform textureMemBar;

		public GameObject texturePreviews;

		public RawImage mainTexturePreview;

		public RawImage texturePreviewTemplate;

		[Header("Pointer Options")]
		public float zOffset;

		public float zMax;

		public bool enablePointer;

		public bool forcePointerOn;

		public bool pointerOnOffhand;

		public LayerMask layerMask;

		[SerializeField]
		[ReadOnly(false)]
		[Header("Selected Texture Tools")]
		private Texture2D selectedTexture;

		[ReadOnly(false)]
		public int currentMipLevel;

		public bool resetMipLevel;

		public bool customMip;

		[Range(0f, 7f)]
		public int customMipLevel;

		public bool selectNextRenderer;

		[Header("Runtime Values")]
		[ReadOnly(false)]
		[SerializeField]
		private Camera activeCamera;

		[SerializeField]
		[TextArea(2, 20)]
		private string debugText;

		[SerializeField]
		[TextArea(2, 20)]
		private string debugGlobalText;

		[SerializeField]
		[TextArea(2, 20)]
		private string debugModeText;

		[SerializeField]
		private ObjectDebug selectedObjectInspector;

		[SerializeField]
		private ObjectRendererDebug? selectedRenderer;

		[ReadOnly(false)]
		[SerializeField]
		private int selectedRendererIndex;

		[ReadOnly(false)]
		[SerializeField]
		private int budget;

		[ReadOnly(false)]
		[SerializeField]
		private int maxLevelReduction;

		[ReadOnly(false)]
		[SerializeField]
		private int maxFileRequests;

		[SerializeField]
		private Modes mode;

		[SerializeField]
		private List<CachedBoundBox> boundBoxes;

		[SerializeField]
		private List<TexturePreviewBox> texturePreviewBoxes;

		private bool hideEmptyTextureProperties;

		private ObjectDebug? selectedObjectDebug;

		private GameObject textDisplayObject;

		private MeshRenderer pointerMeshRenderer;

		private Material pointerTrailMaterial;

		private float lastOnGUITime;

		private float[] bars;

		private TexturePreviewBox? mainTexturePreviewBox;

		private readonly Color darkGray;

		private readonly Color orange;

		private static readonly int CachedColorProperty;

		private static readonly int CachedBaseColorProperty;

		private static readonly int EmissionColor;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Reset()
		{
		}

		private void OnDestroy()
		{
		}

		private void WriteTextLine(string text)
		{
		}

		private void WriteGlobalTextLine(string text)
		{
		}

		private void WriteModeTextLine(string text)
		{
		}

		private void Update()
		{
		}

		private void DrawBoundBoxes(List<ObjectRendererDebug> debugs)
		{
		}

		private void DrawBoundBox(CachedBoundBox boundBox, int boundBoxIndex, ObjectRendererDebug rendererDebug)
		{
		}

		private void ClearSelected()
		{
		}

		private void SelectGameObject(GameObject go, Collider collider)
		{
		}

		private void SetTexturePreviewMips()
		{
		}

		private void SetTexturePreviews()
		{
		}

		private void ClearCustomMip()
		{
		}

		private void SelectRenderer(ObjectRendererDebug debugRenderer)
		{
		}

		private void SelectRenderer(int index)
		{
		}

		private void SelectNextRenderer()
		{
		}

		private void SelectPreviousRenderer()
		{
		}

		private void ToggleStreaming()
		{
		}

		private void IncreaseBudget()
		{
		}

		private void DecreaseBudget()
		{
		}

		private void IncreaseCustomMip()
		{
		}

		private void DecreaseCustomMip()
		{
		}

		private void IncreaseMaxLevelReduction()
		{
		}

		private void DecreaseMaxLevelReduction()
		{
		}

		private void DiscardUnusedMips()
		{
		}

		private void IncreaseMaxFileRequests()
		{
		}

		private void DecreaseMaxFileRequests()
		{
		}

		[ContextMenu("Set Next Mode")]
		private void SetNextMode()
		{
		}

		[ContextMenu("Activate Mode")]
		private void ActivateMode()
		{
		}

		private string GetModeState(Modes mode)
		{
			return null;
		}

		private string GetBoolColor(bool input)
		{
			return null;
		}

		private string GetFloatColor(float input, float min, float max)
		{
			return null;
		}

		private TexturePreviewBox GetTexturePreviewBox(int index = 0)
		{
			return default(TexturePreviewBox);
		}

		private CachedBoundBox GetBoundBox(int index = 0)
		{
			return default(CachedBoundBox);
		}

		private void SetPointerLength(float length)
		{
		}

		private void SetPointerColor(Color color)
		{
		}

		private void ManageInput()
		{
		}

		private void DrawBars()
		{
		}

		private float InverseLerpUnclamped(float x, float y, float value)
		{
			return 0f;
		}

		private string GenerateColorText(string text, Color color)
		{
			return null;
		}

		private void GenerateDebugText()
		{
		}

		public static string HumanReadableNumber(ulong number)
		{
			return null;
		}

		public static string HumanReadableSizeBytes(ulong size)
		{
			return null;
		}

		public static string HumanReadableSize(ulong size)
		{
			return null;
		}

		private Color MipLevelToColor(int mipLevel)
		{
			return default(Color);
		}
	}
}
