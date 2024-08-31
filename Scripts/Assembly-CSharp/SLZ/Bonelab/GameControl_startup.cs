using System;
using System.Collections;
using Cysharp.Threading.Tasks;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_startup : MonoBehaviour
	{
		private static PlayerProgression Progression
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void SetupPlayerReferences()
		{
		}

		private void OnDestroy()
		{
		}

		private void PullLocalizedText()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private IEnumerator IntoTimeUpdateLoop()
		{
			return null;
		}

		public void PLAYMENUMUSIC(int song = 0)
		{
		}

		public void NEXCTLEVELLOADED()
		{
		}

		public void NEXTSTEP()
		{
		}

		public void BUTTON_QUICKPLAY()
		{
		}

		public void BUTTON_PLAYNEWGAME()
		{
		}

		public void BUTTON_PLAYHUB()
		{
		}

		public void BUTTON_PLAYCONTINUE()
		{
		}

		public IEnumerator DissolveBoneLab()
		{
			return null;
		}

		private void LoadLevel()
		{
		}

		private LevelCrateReference ContinueDestination()
		{
			return null;
		}

		public void BUTTON_OPTIONS()
		{
		}

		public void BUTTON_LOADCUSTOM(string sceneName)
		{
		}

		public UniTask LoadAvatarFromSaveDataAsync()
		{
			return default(UniTask);
		}

		private void SetPreviewMesh(AvatarCrate crate)
		{
		}

		public GameControl_startup()
		{
		}

		[Header("BUILD INFO")]
		public string buildTitle;

		public string buildState;

		private string buildDate;

		public TextMeshPro tmp_Title;

		public TextMeshPro tmp_BuildInfo;

		[Header("TITLE")]
		public LaserCursor mainMenuUIController;

		public GameObject logoSLZ;

		public GameObject logoCredits;

		public GameObject logoGameTitle;

		public GameObject rootSLZ;

		public GameObject rootCredits;

		public GameObject rootGameTitle;

		public GameObject animGameTitle;

		public float holdTime_Rest;

		public float holdTime_SLZ;

		public float holdTime_Credits;

		public float holdTime_GameTitle;

		public AudioClip sfx_slzLogo;

		public AudioClip sfx_marrow;

		public AudioClip sfx_bonelab;

		public AudioClip clip_menu;

		public AudioClip clip_kegen;

		public GameObject particles_elements;

		public GameObject particles_elementsALL;

		public ParticleSystem particles_Fireflies;

		private Material[] logoSLZMaterial;

		private Renderer[] logoSLZTextRenderer;

		private Renderer logoCreditsRenders;

		private Renderer logoGameTitleBeakerRenderer;

		private Renderer logoGameTitleBoneLabRenderer;

		public AnimationCurve curve_title;

		public float titleLerpTime;

		private float m_curTitleLerpTime;

		public Transform logoGameTitleStartTrans;

		private Vector3 m_logoPos;

		private Vector3 m_logoScale;

		public Transform logoGameTitleTargetTrans;

		public GameObject[] panels_ProfileSelect;

		public GameObject[] uiGroups;

		public FadeAndDisableVolume fadeVolume;

		public GameObject avatarTransform;

		public MeshFilter avatarMeshFilter;

		public TextMeshProUGUI avatarName;

		public float avatarMeshScaleTune;

		private AvatarCrate avatarCrate;

		private IEnumerator timeUpdateLoop;

		[HideInInspector]
		[Header("CONTROL")]
		public BodyVitals ctrl_bodyVitals;

		private bool m_waitForConfirm;

		private bool m_waitForLevelLoad;

		private WaitForSeconds frameWait;

		[Header("INPUT")]
		private float startHoldTime;

		private float timerHold;

		public float holdTime;

		private bool buttonHeld;

		private string heldKey;

		[HideInInspector]
		public Control_Player controlPlayer;

		[Header("LEVEL PROGRESS")]
		public LevelCrateReference level_quickPlay;

		public LevelCrateReference descentLevelCrate;

		public LevelCrateReference hubLevelCrate;

		public LevelCrateReference longRunLevelCrate;

		public LevelCrateReference mineDiveLevelCrate;

		public LevelCrateReference bigAnomalyLevelCrate;

		public LevelCrateReference streetPuncherLevelCrate;

		public LevelCrateReference sprintBridgeLevelCrate;

		public LevelCrateReference magmaGateLevelCrate;

		public LevelCrateReference moonBaseLevelCrate;

		public LevelCrateReference motorwayLevelCrate;

		public LevelCrateReference pillarLevelCrate;

		public LevelCrateReference ascentLevelCrate;

		public LevelCrateReference outroLevelCrate;

		public LevelCrateReference voidG114LevelCrate;

		private LevelCrateReference _loadcrate;

		private bool canClick;
	}
}
