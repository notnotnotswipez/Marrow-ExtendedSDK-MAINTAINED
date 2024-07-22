using System.Collections.Generic;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.SaveData;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class Control_UI_InGameData : MonoBehaviour
	{
		public static List<Control_UI_InGameData> gameDatas;

		private static BaseController _activeController;

		[Tooltip("check this if UI is not attached to player, it will cause this script to grab relevant components")]
		public bool isEnvironmentUI;

		[Header("UI DISPLAY - General")]
		public TextMeshProUGUI txt_PleaseSave;

		public GameObject obj_PleaseSave;

		[Header("UI DISPLAY - Control")]
		public TextMeshProUGUI txt_ControllerDirection;

		public TextMeshProUGUI txt_ControllerCurve;

		public Image img_ControllerCurve;

		public TextMeshProUGUI txt_SnapTurnDegrees;

		public TextMeshProUGUI txt_SnapTurnRate;

		public TextMeshProUGUI txt_handedness;

		public TextMeshProUGUI txt_hapticMod;

		[Header("UI DISPLAY - Body")]
		public Control_Player controlPlayer;

		public TextMeshProUGUI txt_beltSidedness;

		public TextMeshProUGUI txt_bodyLogSide;

		[Header("UI DISPLAY - Graphics")]
		public TextMeshProUGUI txt_GraphicsQuality;

		public TextMeshProUGUI txt_ambientOcclusion;

		public TextMeshProUGUI txt_bloom;

		public TextMeshProUGUI txt_adaptiveResolution;

		public TextMeshProUGUI txt_renderscale;

		public TextMeshProUGUI txt_textureResolution;

		public TextMeshProUGUI txt_antiAliasing;

		public TextMeshProUGUI txt_SMAA;

		public TextMeshProUGUI txt_SSR;

		public TextMeshProUGUI txt_ShadowCascade;

		public TextMeshProUGUI txt_shadowQuality;

		public TextMeshProUGUI txt_physicsUpdate;

		public TextMeshProUGUI txt_LODBias;

		public TextMeshProUGUI txt_Volumetrics;

		public GameObject[] OnlyOnForCustom;

		public GameObject button_graphicsDown;

		public GameObject button_graphicsUp;

		public Scrollbar scroller;

		[Header("UI DISPLAY - Variable Rate Shading")]
		public GameObject AdvFovSettingsMenuButton;

		public GameObject SimpleFovSettings;

		public TextMeshProUGUI txt_simplefoveatedQualityPreset;

		[Space(5f)]
		public TextMeshProUGUI txt_foveatedRendering;

		public TextMeshProUGUI txt_foveatedQualityPreset;

		public TextMeshProUGUI txt_foveatedRadius;

		public TextMeshProUGUI txt_foveatedAnisotropy;

		public TextMeshProUGUI txt_foveatedInnerRatio;

		public TextMeshProUGUI txt_foveatedRDMOuterRadius;

		public TextMeshProUGUI txt_foveatedRDMInnerRatio;

		public VRSInfoSwitch vrsInfoPanel;

		public GameObject[] CustomFoveatedSettings;

		public GameObject[] CustomVRSSettings;

		public GameObject[] CustomRDMSettings;

		[Header("UI DISPLAY - Spectator")]
		public TextMeshProUGUI txt_SpectatorCam;

		public TextMeshProUGUI txt_SpectatorCamLocation;

		public TextMeshProUGUI txt_postEffects;

		[Header("UI DISPLAY - Audio")]
		public TextMeshProUGUI txt_MasterVolume;

		public TextMeshProUGUI txt_MusicVolume;

		public TextMeshProUGUI txt_SFXVolume;

		[Header("UI DISPLAY - OTHER")]
		public TextMeshProUGUI txt_ToolTips;

		[Header("MAIN MENU LOAD")]
		public LevelCrateReference MenuHollowCrateRef;

		public LevelCrateReference VoidG114CrateRef;

		public GameObject button_Quit;

		public GameObject button_MainMenu;

		public GameObject button_DeleteData;

		public Sprite[] sprite_CurveMap;

		private bool somethingChanged;

		private string string_Changed;

		private string string_LoadDrop;

		private string string_SaveDrop;

		private int cur_shadowQuality;

		private int cur_fishEyeLocation;

		private static PlayerProgression p => null;

		public static BaseController GetActiveController()
		{
			return null;
		}

		public static void SetActiveController(BaseController controller)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		public void GetPlayerFromZone(MarrowEntity playerEntity)
		{
		}

		public void Initialize_Player()
		{
		}

		public void AUTOCALIBRATE_HEIGHT()
		{
		}

		public void AUTOCALIBRATE_SITTINGOFFSET()
		{
		}

		public void AUTOCALIBRATE_FLOOROFFSET()
		{
		}

		public void BUTTON_Change_PlayerInfo(int buttonNumber)
		{
		}

		public void BUTTON_SeatedStanding()
		{
		}

		public void BUTTON_Seated(bool isSeated)
		{
		}

		public void BUTTON_Save_PlayerInfo()
		{
		}

		public void BUTTON_AmbientOcclusion(int buttonNumber)
		{
		}

		public void BUTTON_Bloom(int buttonNumber)
		{
		}

		public void BUTTON_ScreenSpaceReflections(int buttonNumber)
		{
		}

		public void BUTTON_antiAliasing(int buttonNumber)
		{
		}

		public void BUTTON_SMAA(int buttonNumber)
		{
		}

		public void BUTTON_Volumetrics(int buttonNumber)
		{
		}

		public void BUTTON_ShadowCascade(int buttonNumber)
		{
		}

		public void BUTTON_GraphicsQuality(int buttonNumber)
		{
		}

		public void BUTTON_foveatedRendering(int buttonNumber)
		{
		}

		public void BUTTON_foveatedPreset(int buttonNumber)
		{
		}

		public void BUTTON_IncreaseFoveatedRadius(int radius)
		{
		}

		public void BUTTON_DecreaseFoveatedRadius(int radius)
		{
		}

		public void BUTTON_AdditionalLighting()
		{
		}

		public void BUTTON_AdaptiveResolution()
		{
		}

		public void BUTTON_TextureResolution()
		{
		}

		public void BUTTON_RenderScale(int buttonNumber)
		{
		}

		public void BUTTON_LODBias(int buttonNumber)
		{
		}

		public void BUTTON_shadowQuality(int buttonNumber)
		{
		}

		public void BUTTON_PhysicsUpdate(int buttonNumber)
		{
		}

		public void BUTTON_SPECTATOR(int val)
		{
		}

		public void BUTTON_volume(int buttonNumber)
		{
		}

		public void BUTTON_Global_Reset()
		{
		}

		public void BUTTON_QUIT()
		{
		}

		public void BUTTON_MAINMENU()
		{
		}

		public void BUTTON_Control_Direction()
		{
		}

		public void BUTTON_Control_Curve()
		{
		}

		public void BUTTON_VirtualCrouching()
		{
		}

		public void BUTTON_Control_SnapTurnSwitch()
		{
		}

		public void BUTTON_Control_SnapTurn(int val)
		{
		}

		public void BUTTON_Control_Handed()
		{
		}

		public void BUTTON_Control_Belt()
		{
		}

		public void BUTTON_Control_Bodylog()
		{
		}

		public void BUTTON_Control_Haptics(int val)
		{
		}

		public void BUTTON_UNSTICKCONTROLLERS()
		{
		}

		public void BUTTON_TOOLTIPS()
		{
		}

		private void CONFIRMER()
		{
		}

		protected void SOMETHINGCHANGED()
		{
		}

		public static void UPDATEALLDISPLAYUIS()
		{
		}

		protected void DISPLAYUI()
		{
		}

		private string EnabledDisabled(bool input)
		{
			return null;
		}

		private string GetSettingLevelName(SettingLevel level)
		{
			return null;
		}

		public void DATA_DELETE()
		{
		}

		public void DATA_DELETE_ALL()
		{
		}
	}
}
