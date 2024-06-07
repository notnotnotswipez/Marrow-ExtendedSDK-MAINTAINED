using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.VoidLogic;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using SLZ.Rig;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GameControl_Hub : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CBWBoxSequence_003Ed__156 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

			private float _003CbarInterval_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CBWBoxSequence_003Ed__156(int _003C_003E1__state)
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
		private sealed class _003CKlaxonLight_003Ed__157 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

			private float _003CorginalIntensity_003E5__2;

			private float _003CsmoothTime_003E5__3;

			private float _003CvelRef_003E5__4;

			private float _003CalarmTime_003E5__5;

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
			public _003CKlaxonLight_003Ed__157(int _003C_003E1__state)
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
		private sealed class _003CBackUpYoinkLoad_003Ed__161 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

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
			public _003CBackUpYoinkLoad_003Ed__161(int _003C_003E1__state)
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
		private sealed class _003CGeneratorStartSequence_003Ed__165 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

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
			public _003CGeneratorStartSequence_003Ed__165(int _003C_003E1__state)
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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAirlockEnter_003Ed__176 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GameControl_Hub _003C_003E4__this;

			public int side;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAirlockExitCycle_003Ed__177 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GameControl_Hub _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003COpenSmallDoor_003Ed__178 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameControl_Hub _003C_003E4__this;

			public CancellationToken cancelToken;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCloseSmallDoor_003Ed__179 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameControl_Hub _003C_003E4__this;

			public CancellationToken cancelToken;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003COpenBigDoors_003Ed__180 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameControl_Hub _003C_003E4__this;

			public CancellationToken cancelToken;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCloseBigDoors_003Ed__181 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameControl_Hub _003C_003E4__this;

			public CancellationToken cancelToken;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CBlinkAirLockCycleLight_003Ed__182 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_Hub _003C_003E4__this;

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
			public _003CBlinkAirLockCycleLight_003Ed__182(int _003C_003E1__state)
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

		public const string OneTrueLevelKey = "Hub";

		public const string LevelKeyA = "Hub_A";

		public const string LevelKeyB = "Hub_B";

		public const string LevelKeyC = "Hub_C";

		public static readonly string[] PriorLevelsA;

		public static readonly string[] PriorLevelsB;

		public static readonly string[] PriorLevelsC;

		public const string VoidG114AmmoOffset = "SLZ.Bonelab.VoidG114AmmoOffset";

		public const string HubSpawnLocation = "SLZ.Bonelab.HubSpawnLocation";

		public const string ElevatorBroken = "SLZ.Bonelab.ElevatorBroken";

		public const string TacTrialKeyUnlocked = "SLZ.Bonelab.TacTrialKeyUnlocked";

		public const string ArenaKeyUnlocked = "SLZ.Bonelab.ArenaKeyUnlocked";

		public const string SandboxKeyUnlocked = "SLZ.Bonelab.SandboxKeyUnlocked";

		public const string ParkourKeyUnlocked = "SLZ.Bonelab.ParkourKeyUnlocked";

		public const string ExperimentalKeyUnlocked = "SLZ.Bonelab.ExperimentalKeyUnlocked";

		public const string ModKeyUnlocked = "SLZ.Bonelab.ModKeyUnlocked";

		public const string JimmyKeyUnlocked = "SLZ.Bonelab.JimmyKeyUnlocked";

		public const string TacTrialKeyPlaced = "SLZ.Bonelab.TacTrialKeyPlaced";

		public const string ArenaKeyPlaced = "SLZ.Bonelab.ArenaKeyPlaced";

		public const string SandboxKeyPlaced = "SLZ.Bonelab.SandboxKeyPlaced";

		public const string ParkourKeyPlaced = "SLZ.Bonelab.ParkourKeyPlaced";

		public const string ExperimentalKeyPlaced = "SLZ.Bonelab.ExperimentalKeyPlaced";

		public const string ModKeyPlaced = "SLZ.Bonelab.ModKeyPlaced";

		public const string JimmyKeyPlaced = "SLZ.Bonelab.JimmyKeyPlaced";

		public const string BatteryAPlaced = "SLZ.Bonelab.BatteryAPlaced";

		public const string BatteryBPlaced = "SLZ.Bonelab.BatteryBPlaced";

		public const string LabPoweredOn = "SLZ.Bonelab.LabPoweredOn";

		[Header("Hub reverts to the old hub key core unlocking progression behavior")]
		public bool useOldHubMode;

		[Header("References")]
		public Control_UI_ProgressBoard progressBoard;

		public GameObject[] sceneExitTriggers;

		public UI_LabModule[] labModuleUIs;

		[Header("Keys")]
		public MarrowEntity[] key_Modules;

		public MarrowEntity[] key_Inserted;

		public MarrowEntity battery1;

		public MarrowEntity battery2;

		public CrateSpawner battery1_Inserted;

		public CrateSpawner battery2_Inserted;

		public MarrowEntity jimmyKey;

		public MarrowEntity jimmyKey_Inserted;

		[Header("Key Bools")]
		public bool[] isKeyUnlock;

		public bool[] isKeyInserted;

		public bool isJimmyKeyUnlocked;

		public bool isJimmyKeyInserted;

		public bool isBattery1Inserted;

		public bool isBattery2Inserted;

		public bool isGateUnlock;

		public bool isAllInserted;

		public bool isGameFinished;

		public int keyCount;

		[HideInInspector]
		public int keyUnlock;

		public bool isLabPowered;

		[Header("Renderer")]
		public GameObject[] render_Lamp;

		public MeshRenderer[] render_LockLamp;

		public MeshRenderer[] bigDoors_LockLamp;

		public MeshRenderer[] render_StripLight;

		public MeshRenderer[] generator_Lamp;

		public MeshRenderer airlock_LockLamp;

		public MeshRenderer[] airlock_cycle_N_Lamps;

		public MeshRenderer[] airlock_cycle_M_Lamps;

		public MeshRenderer[] airlock_cycle_S_Lamps;

		public Material[] mat_Lamp;

		public Material[] mat_StripLight;

		[Header("Game Objects")]
		public GameObject[] lockBar;

		private ConfigurableJoint[] lockBarJoints;

		private Rigidbody[] lockBarRB;

		public GameObject[] keyStopperLocks;

		public GameObject[] bigDoors;

		public GameObject smallDoor;

		public Vector3 smallDoorOffSettings;

		public Vector3 smallDoorOnSettings;

		public GameObject doorStopper;

		public MarrowEntity BWBox;

		public GameObject flooring;

		public GameObject backUpBWBoxCollider;

		public BasicSeatTrigger seatTrigger;

		public GauntletElevator gauntletElevator;

		public MarrowEntity breakableDoorsGroup;

		public MarrowEntity workingDoorsGroup;

		public bool isInBWBoxVolume;

		public bool isBWBoxBroken;

		private bool isBWDoorOpen;

		[Header("AudioClips")]
		public AudioClip intoMusic;

		public AudioClip[] bwClunk;

		public AudioClip[] bwWarning;

		public AudioClip[] klaxon;

		public AudioClip[] radiation;

		public AudioClip[] barRetraction;

		public AudioClip[] doorSeal;

		public PrismaticSFX bwDoorPismatic;

		private AudioPlayer apMain;

		private AudioPlayer apKlaxon;

		private AudioPlayer apRadiation;

		public PowerSource generatorPower;

		public PowerSource slzSign;

		public PowerSource slzSignBypass;

		public ParticleSystem[] steamParticles;

		public Light klaxonLight;

		public Rigidbody klaxonRB;

		public ConfigurableJoint klaxonJoint;

		[Header("Locations")]
		public List<ResumePoint> hubSpawnPoints;

		[Header("Level Loader")]
		public LevelCrateReference longRun;

		public LevelCrateReference ascent;

		public LevelCrateReference loadScreenLevel;

		public Spawnable vfxFadeOutSpawnable;

		public InventorySaveFilter inventorySaveFilter;

		public RigManager rm;

		private int _loadedTeleportSpot;

		private CancellationTokenSource doorCycle;

		private CancellationTokenSource airlockCoroutine;

		private IEnumerator generatorStartCoroutine;

		private IEnumerator airlockBlinkLoop;

		private bool airLockExitCycle;

		private bool bigDoorsOpening;

		private bool bigDoorsClosing;

		private bool smallDoorsOpening;

		private bool smallDoorsClosing;

		private bool airLockOccupied;

		private bool inAirLockProxy;

		private bool hasPlayedAirlockProxy;

		private bool blockGeneratorDisable;

		private bool battery1Placed;

		private bool battery2Placed;

		public SceneChunk labFloorChunk;

		public SceneChunk airlockChunk;

		public SceneChunk funicularChunk;

		public UnityEvent bwDoorLocked;

		public UnityEvent quarantineDoorLocked;

		public UnityEvent quarantineDoorUnlocked;

		public UnityEvent generatorStart1;

		public UnityEvent generatorStart2;

		public UnityEvent generatorStart3;

		private AvatarCrateReference[] avatarCrates;

		public static string LevelKey => null;

		public static string[] PriorLevels => null;

		private static PlayerProgression p => null;

		private static PlayerUnlocks u => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void SceneStreamerCallback()
		{
		}

		public void DataRead()
		{
		}

		public void DataWrite()
		{
		}

		public void ELEVATORBREAKOUT()
		{
		}

		private void Teleport()
		{
		}

		private void SetupKeys()
		{
		}

		public void SETUPELEVATOR()
		{
		}

		public void UNLOCKKEY(int keyInt)
		{
		}

		public void KEYINSERTED(int keyInt)
		{
		}

		public void UNLOCKJIMMYKEY(bool fromSave = false)
		{
		}

		public void JIMMYKEYINSERTED(bool fromSave = false)
		{
		}

		public void BATTERYINSERTED(int i, bool fromSave = false)
		{
		}

		public void LABPOWERED()
		{
		}

		public void OPENBWDOOR()
		{
		}

		[IteratorStateMachine(typeof(_003CBWBoxSequence_003Ed__156))]
		public IEnumerator BWBoxSequence()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CKlaxonLight_003Ed__157))]
		public IEnumerator KlaxonLight()
		{
			return null;
		}

		public void ENTERBWBOXVOL()
		{
		}

		public void EXITBWBOXVOL()
		{
		}

		public void BWBOXDESTROYED()
		{
		}

		[IteratorStateMachine(typeof(_003CBackUpYoinkLoad_003Ed__161))]
		private IEnumerator BackUpYoinkLoad()
		{
			return null;
		}

		private void CheckTotal()
		{
		}

		private void DisplayKeys()
		{
		}

		public void CheckGeneratorStatus(bool startStop)
		{
		}

		[IteratorStateMachine(typeof(_003CGeneratorStartSequence_003Ed__165))]
		private IEnumerator GeneratorStartSequence()
		{
			return null;
		}

		public void InAirLockProxyVolume(bool inOut = false)
		{
		}

		private void CheckAirLockOpenAnimStatus()
		{
		}

		private void GameDone()
		{
		}

		public void GOTOSCENE(int gameStage = 0)
		{
		}

		private int CountKeys()
		{
			return 0;
		}

		public void AIRLOCKENTERNORTH()
		{
		}

		public void AIRLOCKENTERSOUTH()
		{
		}

		public void AIRLOCKOCCUPIED(bool b)
		{
		}

		public void AIRLOCKCYCLE()
		{
		}

		public void CANCELCYCLE()
		{
		}

		[AsyncStateMachine(typeof(_003CAirlockEnter_003Ed__176))]
		private UniTaskVoid AirlockEnter(int side)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CAirlockExitCycle_003Ed__177))]
		private UniTaskVoid AirlockExitCycle()
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003COpenSmallDoor_003Ed__178))]
		private UniTask OpenSmallDoor(CancellationToken cancelToken)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CCloseSmallDoor_003Ed__179))]
		private UniTask CloseSmallDoor(CancellationToken cancelToken)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003COpenBigDoors_003Ed__180))]
		private UniTask OpenBigDoors(CancellationToken cancelToken)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CCloseBigDoors_003Ed__181))]
		private UniTask CloseBigDoors(CancellationToken cancelToken)
		{
			return default(UniTask);
		}

		[IteratorStateMachine(typeof(_003CBlinkAirLockCycleLight_003Ed__182))]
		private IEnumerator BlinkAirLockCycleLight()
		{
			return null;
		}

		private void LoadFXAndLevel(LevelCrateReference level)
		{
		}

		private static void UpgradeHubInventoryToPush()
		{
		}
	}
}
