using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Data;
using SLZ.Marrow;
using SLZ.Marrow.AI;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using TMPro;
using UltEvents;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class BaseGameController : MonoBehaviour
	{
		public enum GameMode
		{
			LINEAR = 0,
			ARENA = 1,
			TIME_TRIAL = 2
		}

		public enum TimerMode
		{
			COUNT_UP = 0,
			COUNT_DOWN = 1,
			REALTIME = 2,
			COUNT_UP_REALTIME = 3
		}

		public enum EndMode
		{
			LOAD_NEXT = 0,
			RELOAD_CURRENT = 1,
			NONE = 2,
			EXPLICIT = 3
		}

		public enum DebugMode
		{
			VERBOSE = 0,
			MINIMAL = 1,
			NONE = 2
		}

		[CompilerGenerated]
		private sealed class _003CCoDelayedStart_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BaseGameController _003C_003E4__this;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoDelayedStart_003Ed__114(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CCoTimerUp_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BaseGameController _003C_003E4__this;

			private float _003ClastTimeSent_003E5__2;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoTimerUp_003Ed__115(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CCoTimerUpRealtime_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BaseGameController _003C_003E4__this;

			private float _003ClastTimeSent_003E5__2;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoTimerUpRealtime_003Ed__116(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CCoTimerDown_003Ed__117 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BaseGameController _003C_003E4__this;

			private float _003ClastTimeSent_003E5__2;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoTimerDown_003Ed__117(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CCoTimerRealtime_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BaseGameController _003C_003E4__this;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoTimerRealtime_003Ed__118(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CCoDelayedEnd_003Ed__119 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BaseGameController _003C_003E4__this;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoDelayedEnd_003Ed__119(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CCoDelayedDespawn_003Ed__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float seconds;

			public BaseGameController _003C_003E4__this;

			public AIBrain brain;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoDelayedDespawn_003Ed__129(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CCoDelayedReload_003Ed__139 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public BaseGameController _003C_003E4__this;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoDelayedReload_003Ed__139(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		public string LevelKey;

		public GameMode gameMode;

		public TimerMode timerMode;

		public EndMode endMode;

		public DebugMode debugMode;

		[SerializeField]
		private LevelCrateReference explicitSceneCrate;

		protected bool isSessionOngoing;

		[SerializeField]
		[Header("Time Data")]
		private float timerValue;

		[SerializeField]
		protected TimeSpan tsTimerValue;

		[SerializeField]
		public string tsTimerString;

		[SerializeField]
		private float maxTime;

		[SerializeField]
		private float defaultMaxTime;

		[SerializeField]
		public bool isSlowTime;

		[SerializeField]
		private float delayedMaxTime;

		[SerializeField]
		private float defaultDelayedMaxTime;

		[SerializeField]
		private float delayedEndMaxTime;

		[SerializeField]
		private float defaultEndDelayedMaxTime;

		[Header("Stats")]
		[SerializeField]
		public int score;

		[SerializeField]
		public int enemiesKilled;

		[SerializeField]
		public int totalEnemiesKilled;

		[SerializeField]
		public int activeEnemyCount;

		[SerializeField]
		public int maxDeadDespawnLimit;

		[SerializeField]
		public int activeFriendlyCount;

		[SerializeField]
		public int friendlyRespawnAmount;

		public RigManager rigManager;

		public GameObject playerObject;

		public TriggerRefProxy playerProxy;

		public List<TMP_Text> modeTexts;

		public List<TMP_Text> timerTexts;

		public List<TMP_Text> aliveTexts;

		public List<TMP_Text> aliveFriendsTexts;

		public List<TMP_Text> killsTexts;

		public List<TMP_Text> totalKillsTexts;

		public List<TMP_Text> totalEnemiesTexts;

		public List<TMP_Text> collectiblesTotalTexts;

		public List<TMP_Text> collectiblesFoundTexts;

		private Coroutine timerRoutine;

		[Tooltip("Assuming all zones are the child of a single transform, will be used to grab all zone refs")]
		[SerializeField]
		private GameObject zoneParentObj;

		public List<Zone> zoneList;

		public List<ZoneDisplayEditor> zoneDisplayList;

		public Dictionary<Zone, ZoneDisplayEditor> zoneNPCLookup;

		public List<GameObject> nothingGOList;

		public List<ProfileSpawner> profileSpawnerList;

		public List<CrateSpawner> crateSpawnerList;

		[SerializeField]
		public ProfileSpawner safetyZoneSpawner;

		protected List<ProfileSpawner> removeSpawnerList;

		[HideInInspector]
		public bool isTrackingEnemies;

		[SerializeField]
		private bool isAutoDespawn;

		[SerializeField]
		private float despawnDelay;

		[SerializeField]
		[Tooltip("A list of all npcs that have been spawned since session began")]
		protected List<AIBrain> NPC_List;

		[Tooltip("A list of all living enemy NPC's")]
		[SerializeField]
		protected List<AIBrain> Alive_Enemy_List;

		[SerializeField]
		[Tooltip("A list of all dead enemy NPC's")]
		protected List<AIBrain> Dead_Enemy_List;

		[SerializeField]
		[Tooltip("A list of all the friendly npcs")]
		protected List<AIBrain> FriendlyNPC_List;

		[SerializeField]
		[Tooltip("A list of all living enemy NPC's")]
		protected List<AIBrain> Alive_Friendly_List;

		[SerializeField]
		[Tooltip("A list of all dead enemy NPC's")]
		protected List<AIBrain> Dead_Friendly_List;

		private int currFriendlyProxy;

		[SerializeField]
		protected List<TriggerRefProxy> friendlyProxyList;

		[SerializeField]
		protected List<NPC_Data> friendly_Data_List;

		[SerializeField]
		public List<NPC_Data> NPC_Data_List;

		[SerializeField]
		protected List<NPC_Data> dead_NPC_Data_List;

		[SerializeField]
		protected List<DeadData> despawnedDataList;

		[SerializeField]
		protected List<DeadData> despawnedDataWaveList;

		protected Dictionary<GameObject, NPC_Data> NPC_Data_Dict;

		protected Dictionary<ProfileSpawner, NPC_Data> NPC_Zone_Dict;

		public Action OnPlayerFound;

		public Action<NPC_Data> onNPCRegistration;

		public Action<NPC_Data> OnRegisteredNPCDeath;

		public BoneLeaderManager boneLeaderManager;

		public List<LinkData> linkList;

		public int crabletAgentID;

		[Tooltip("Session is initialized, timer routine starts")]
		[Header("SESSION EVENTS")]
		[Obsolete("Migrate Unity Event to Ult Event")]
		public UnityEvent onSessionBegin;

		[Tooltip("Session is initialized, timer routine starts")]
		public UltEvent sessionBegin;

		[Tooltip("Session is complete, timer routine ends")]
		[Obsolete("Migrate Unity Event to Ult Event")]
		public UnityEvent onSessionEnd;

		[Tooltip("Session is complete, timer routine ends")]
		public UltEvent sessionEnd;

		public StaticProfiles staticProfile;

		private bool isDevToolSpawned;

		public bool showUIData;

		public bool showPlayerData;

		public bool showEnemyDisplay;

		public bool showEnemyData;

		public bool showZoneData;

		public bool showDebugDisplay;

		public bool showWeaponsAmmo;

		public bool showEventData;

		public bool showLeaderboardData;

		public bool showCollectibles;

		public bool showArena;

		public bool showArenaProfile;

		public bool showArenaEvents;

		public bool showArenaAudio;

		public bool showArenaUI;

		public bool showArenaSpawning;

		public bool[] foldArray;

		public NPC_Data currNPC;

		public Texture soundIcon;

		public Texture settingsIcon;

		public Color zoneRectColor;

		public Mesh graveMesh;

		public static string profilePath;

		public string profileTitle;

		public float elapsedTime => 0f;

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void Start()
		{
		}

		private void OnLevelLoadGetPlayer()
		{
		}

		[ContextMenu("BeginSession")]
		public void BeginSession()
		{
		}

		[ContextMenu("EndSession")]
		public void EndSession()
		{
		}

		public void DoCompleteLevel()
		{
		}

		[IteratorStateMachine(typeof(_003CCoDelayedStart_003Ed__114))]
		private IEnumerator CoDelayedStart()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoTimerUp_003Ed__115))]
		private IEnumerator CoTimerUp()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoTimerUpRealtime_003Ed__116))]
		private IEnumerator CoTimerUpRealtime()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoTimerDown_003Ed__117))]
		private IEnumerator CoTimerDown()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoTimerRealtime_003Ed__118))]
		private IEnumerator CoTimerRealtime()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoDelayedEnd_003Ed__119))]
		private IEnumerator CoDelayedEnd()
		{
			return null;
		}

		private void UpdateTimeDisplay(bool showMilliscond = false)
		{
		}

		private void OnSlowTime(float slowStep)
		{
		}

		protected void ResetFriendlyProxyList()
		{
		}

		protected void CheckForProxyTarget(TriggerRefProxy proxy)
		{
		}

		protected TriggerRefProxy GetFriendlyProxy()
		{
			return null;
		}

		public void RegisterNPCBase(ProfileSpawner profileSpawner, AIBrain brain, EnemyProfile enemyProfile, bool isFriendly)
		{
		}

		public void OnNPC_DeathBase(AIBrain brain)
		{
		}

		protected void DespawnAllNPCs()
		{
		}

		public void KillAll()
		{
		}

		[IteratorStateMachine(typeof(_003CCoDelayedDespawn_003Ed__129))]
		private IEnumerator CoDelayedDespawn(AIBrain brain, float seconds)
		{
			return null;
		}

		private void OnDespawn(GameObject despawnedObject)
		{
		}

		protected void UpdateNPCDisplay()
		{
		}

		public void KillVolumeNPCRemoval(GameObject npcObj)
		{
		}

		protected void CreateZoneSeeker(AIBrain brain)
		{
		}

		public void DevToolSpawn()
		{
		}

		public void SubmitScoreByType()
		{
		}

		private void LoadFXAndLevel(LevelCrateReference level, LevelCrateReference loadLevel)
		{
		}

		public void LOAD_HUB()
		{
		}

		public void WAITANDRELOADCURRENTLEVEL(float delay)
		{
		}

		[IteratorStateMachine(typeof(_003CCoDelayedReload_003Ed__139))]
		private IEnumerator CoDelayedReload(float delay)
		{
			return null;
		}

		public void RELOADCURRENTLEVEL()
		{
		}

		public void LOADNEXTLEVEL()
		{
		}

		public void LOADEXPLICITLEVEL()
		{
		}

		[ContextMenu("GetAllLinkData")]
		public void GetAllLinkData()
		{
		}
	}
}
