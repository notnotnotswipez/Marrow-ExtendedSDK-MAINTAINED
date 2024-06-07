using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Combat;
using SLZ.Marrow.PuppetMasta;
using SLZ.Player;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SLZ.Bonelab
{
	public class Player_Health : Health
	{
		public delegate void PlayerDeathImminent(bool isDying);

		public delegate void PlayerDeath();

		public delegate void PlayerDamageReceived(float damageAmount);

		[CompilerGenerated]
		private sealed class _003CCoBrightenDeathSave_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Player_Health _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003ClerpVal_003E5__4;

			private float _003CstartShut_003E5__5;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoBrightenDeathSave_003Ed__78(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoUpdateHealthUI_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Player_Health _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoUpdateHealthUI_003Ed__79(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoFadeVignette_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Player_Health _003C_003E4__this;

			private float _003CinnerValue_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoFadeVignette_003Ed__80(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoFadeDeathVignette_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Player_Health _003C_003E4__this;

			public float deathTime;

			private float _003Cshuteye_003E5__2;

			private float _003Ctimer_003E5__3;

			private float _003CstartTime_003E5__4;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoFadeDeathVignette_003Ed__81(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoRegenHealth_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float waitSeconds;

			public Player_Health _003C_003E4__this;

			private float _003Ctimer_003E5__2;

			private float _003CstartHealth_003E5__3;

			private float _003CgoalHealth_003E5__4;

			private float _003CstartTime_003E5__5;

			private float _003Cendtime_003E5__6;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoRegenHealth_003Ed__82(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoLowPassFilter_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool enableLow;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003ClerpVal_003E5__4;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoLowPassFilter_003Ed__83(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoWaitAndReloadScene_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoWaitAndReloadScene_003Ed__87(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoWaitAndGoToRespawn_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Player_Health _003C_003E4__this;

			private float _003Ctimer_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoWaitAndGoToRespawn_003Ed__88(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public bool reloadLevelOnDeath;

		[Space(2f)]
		[Header("IMPACT")]
		[Tooltip("Can be damaged by physical impacts")]
		public bool damageFromImpact;

		[Tooltip("Modifier multiplier to collision")]
		public float mod_Impact;

		[Tooltip("Threshold of impact magnitude required to damage")]
		public float thr_Impact;

		[Tooltip("Can this use a mask to ignore damage")]
		public bool useMask;

		[Tooltip("Layer to Minimal Hit")]
		public LayerMask msk_Impact;

		[Tooltip("Amount of Minimal Mod")]
		public float mod_Minimal;

		[Tooltip("Spawnable hero props")]
		public GameObject[] prop_Hero;

		[Tooltip("Spawn hero props?")]
		public bool spawnHeroProps;

		public Transform[] spawn_points;

		[Tooltip("FX for death")]
		public GameObject fx_death;

		public SceneManager boneworks_SceneManager;

		[Header("Regen & Imminent Death")]
		[SerializeField]
		private bool visDebug;

		private bool slowMoOnDeath;

		private bool regenerating;

		private bool isFadingVignette;

		[HideInInspector]
		public bool isInstaDying;

		[Tooltip("Time until regen starts after hit")]
		public float wait_Regen_t;

		[Range(0.05f, 15f)]
		[Tooltip("Time in seconds to regnerate health from 0 - maxHealth")]
		public float totalRegenDuration;

		private float currentHealthRegenDuration;

		[Tooltip("Time player has (in seconds) to score damage after health reaches 0, if no attack is scored player dies")]
		public float deathTimeAmount;

		private float currDeathTime;

		[Tooltip("Time player has (in seconds) before instant death")]
		public float instaDeathTimeAmount;

		[Tooltip("Once player reached death state any additional hits will reduce deathTime left by this amount in seconds")]
		public float deathTimeReduction;

		private float routineTickRate;

		public AnimationCurve shutEyeCurve;

		private Coroutine vignetteRoutine;

		private Coroutine regenRoutine;

		private Coroutine lowPassAudioRoutine;

		public Color darkRed;

		public Color brightRed;

		private float highLPF;

		private float lowLPF;

		private float currLPF;

		public int playerDamageScore;

		public int playerDeathSaves;

		[Header("VisDebug Canvas")]
		public GameObject healthCanvasPrefab;

		public Transform uiTarget;

		public PlayerHealthCanvas healthCanvas;

		private Vector3 canvasOffset;

		private MaterialPropertyBlock matPropBlock;

		public GameObject Vignetter;

		private SkinnedMeshRenderer vigRend;

		private int shutEyesID;

		private int brightenID;

		private int innerID;

		private int outerID;

		private int colorID;

		public static event PlayerDeathImminent OnDeathImminent
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

		public static event PlayerDeath OnPlayerDeath
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

		public static event PlayerDamageReceived OnPlayerDamageReceived
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected override void Awake()
		{
		}

		public void MakeVignette()
		{
		}

		private void CreateHealthCanvas()
		{
		}

		private void Start()
		{
		}

		public void ToggleInstantDeathMode(bool toggleOn)
		{
		}

		public void OnPuppetDeath(PuppetMaster puppet)
		{
		}

		public override void OnReceivedDamage(Attack attack, PlayerDamageReceiver.BodyPart part)
		{
		}

		[ContextMenu("LfeSavingDamageDealt")]
		public void LifeSavingDamgeDealt()
		{
		}

		private void ResetVigMaterial()
		{
		}

		public void UpdateHealth(float perc)
		{
		}

		public override void SetFullHealth()
		{
		}

		private void PlayerDamageScore(float damage)
		{
		}

		public override void TAKEDAMAGE(float damage)
		{
		}

		[ContextMenu("Apply kill damage")]
		public void ApplyKillDamage()
		{
		}

		public void ShowHealthInstaDeathMode()
		{
		}

		public void StartHealthRegnerationAndVignette(float regenWait)
		{
		}

		[IteratorStateMachine(typeof(_003CCoBrightenDeathSave_003Ed__78))]
		private IEnumerator CoBrightenDeathSave()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoUpdateHealthUI_003Ed__79))]
		private IEnumerator CoUpdateHealthUI()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoFadeVignette_003Ed__80))]
		private IEnumerator CoFadeVignette()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoFadeDeathVignette_003Ed__81))]
		private IEnumerator CoFadeDeathVignette(float deathTime)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoRegenHealth_003Ed__82))]
		private IEnumerator CoRegenHealth(float waitSeconds)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoLowPassFilter_003Ed__83))]
		private IEnumerator CoLowPassFilter(bool enableLow)
		{
			return null;
		}

		public override void Dying(float damage)
		{
		}

		public override void Death()
		{
		}

		public void TELEPORTONESECOND()
		{
		}

		[IteratorStateMachine(typeof(_003CCoWaitAndReloadScene_003Ed__87))]
		private IEnumerator CoWaitAndReloadScene()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoWaitAndGoToRespawn_003Ed__88))]
		public IEnumerator CoWaitAndGoToRespawn()
		{
			return null;
		}

		public void STARTDATA()
		{
		}
	}
}
