using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Interaction;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000D7 RID: 215
	public abstract class BehaviourBaseNav : BehaviourBase, IMarrowEntityCullable
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00003C8D File Offset: 0x00001E8D
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00003C94 File Offset: 0x00001E94
		public float targetDistance
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00003C96 File Offset: 0x00001E96
		private void OnEnable()
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00003C98 File Offset: 0x00001E98
		protected override void OnInitiate()
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00003C9A File Offset: 0x00001E9A
		public void BlockCollisions(float time)
		{
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00003C9C File Offset: 0x00001E9C
		private void OnDestroy()
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00003C9E File Offset: 0x00001E9E
		public void ChangeEmissiveColor(Color color)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00003CA0 File Offset: 0x00001EA0
		public void ApplyOverrideConfig(BaseEnemyConfig ovrConfig)
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00003CA2 File Offset: 0x00001EA2
		public override void RestorePrefabState()
		{
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00003CA4 File Offset: 0x00001EA4
		public override void OnReactivate(int phase = 0)
		{
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00003CA6 File Offset: 0x00001EA6
		public override void Resurrect()
		{
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[ContextMenu("PuppetMasterKill")]
		protected virtual void PuppetMasterKill()
		{
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00003CAA File Offset: 0x00001EAA
		public override void KillStart()
		{
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00003CAC File Offset: 0x00001EAC
		public override void KillEnd()
		{
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00003CAE File Offset: 0x00001EAE
		protected override void OnUpdate()
		{
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00003CB0 File Offset: 0x00001EB0
		protected override void OnReadBehaviour()
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00003CB2 File Offset: 0x00001EB2
		public void SetRoam(Vector2 roamXz, float speed = 0.8f, float frequency = 0.2f)
		{
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public void SetRoam(Vector3 roamXyz, float speed = 0.8f, bool wanders = false, float frequency = 0.2f)
		{
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00003CB6 File Offset: 0x00001EB6
		public void Investigate(Vector3 target, bool isPosition = false, float investForSeconds = 2f)
		{
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00003CB8 File Offset: 0x00001EB8
		public void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00003CBA File Offset: 0x00001EBA
		public void SetTeam(int t)
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00003CBC File Offset: 0x00001EBC
		public void SetEngaged(TriggerRefProxy engagedTarget)
		{
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00003CBE File Offset: 0x00001EBE
		public void AddThreat(TriggerRefProxy trp, float threat)
		{
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00003CC0 File Offset: 0x00001EC0
		protected void RoamByMode()
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00003CC2 File Offset: 0x00001EC2
		private int GetNextWaypoint()
		{
			return 0;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00003CC5 File Offset: 0x00001EC5
		public void SetPath(Vector3 target)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00003CC7 File Offset: 0x00001EC7
		protected void ProcessTargetRelativePathing(float idealDistance, float nearBuffer, float farBuffer, float orbitMeters = 0f)
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00003CC9 File Offset: 0x00001EC9
		public void SetHomePosition(Vector3 worldPosition, bool goToHome = true, bool homePost = false)
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00003CCB File Offset: 0x00001ECB
		public void SetHomeIsPost(bool isPost)
		{
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00003CCD File Offset: 0x00001ECD
		public void ClearPath()
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00003CCF File Offset: 0x00001ECF
		protected void SetNavAgentToPhysics(float deltaTime = 0f)
		{
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00003CD1 File Offset: 0x00001ED1
		protected void SetNavAgent(float speed, float angSpeed, float accel = 2f, float stopDistance = 1f)
		{
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00003CD3 File Offset: 0x00001ED3
		private void OnTriggerEnter(Collider c)
		{
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00003CD5 File Offset: 0x00001ED5
		private void OnTriggerExit(Collider c)
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00003CD7 File Offset: 0x00001ED7
		protected bool CheckTarget()
		{
			return false;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00003CDA File Offset: 0x00001EDA
		public virtual void DealMeleeDamage(MuscleCollision m, float impulse)
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00003CDC File Offset: 0x00001EDC
		protected float ProcessImpulse(Collision c, Rigidbody thisRb)
		{
			return 0f;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00003CE3 File Offset: 0x00001EE3
		private static float PredictiveAimWildGuessAtImpactTime()
		{
			return 0f;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00003CEA File Offset: 0x00001EEA
		public static bool PredictiveAim(Vector3 muzzlePosition, float projectileSpeed, Vector3 targetPosition, Vector3 targetVelocity, float gravity, out Vector3 projectileVelocity)
		{
			projectileVelocity = default(Vector3);
			return false;
		}

		// Token: 0x060007BA RID: 1978
		protected abstract void SwitchMentalState(BehaviourBaseNav.MentalState mState);

		// Token: 0x060007BB RID: 1979
		protected abstract void SwitchLocoState(BehaviourBaseNav.LocoState lState, float coolDown = 0f, bool forceSwitch = false);

		// Token: 0x060007BC RID: 1980 RVA: 0x00003CF5 File Offset: 0x00001EF5
		protected virtual void AiUpdate()
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00003CF7 File Offset: 0x00001EF7
		protected virtual void AiTick()
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00003CF9 File Offset: 0x00001EF9
		protected virtual void SetAnimatorVars()
		{
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00003CFB File Offset: 0x00001EFB
		protected virtual void RestoreFromCrumbleDeath()
		{
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00003CFD File Offset: 0x00001EFD
		protected virtual void DoCrumbleDeath()
		{
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00003CFF File Offset: 0x00001EFF
		protected virtual void ResetAnimator()
		{
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00003D01 File Offset: 0x00001F01
		protected virtual void AnimRest()
		{
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00003D03 File Offset: 0x00001F03
		protected virtual void AnimAwake()
		{
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00003D05 File Offset: 0x00001F05
		protected virtual void ReturnToPreAgro()
		{
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00003D07 File Offset: 0x00001F07
		public void ClearState()
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00003D09 File Offset: 0x00001F09
		public new void OnDrawGizmos()
		{
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00003D0B File Offset: 0x00001F0B
		protected virtual void DisableNav()
		{
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00003D0D File Offset: 0x00001F0D
		protected virtual void EnableNav()
		{
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00003D0F File Offset: 0x00001F0F
		public virtual void OnEntityCull()
		{
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00003D11 File Offset: 0x00001F11
		public virtual void OnEntityUncull()
		{
		}

		// Token: 0x04000424 RID: 1060
		[Header("Config Section")]
		[FormerlySerializedAs("baseConfig")]
		public BaseEnemyConfig overrideConfig;

		// Token: 0x04000425 RID: 1061
		[FormerlySerializedAs("defaultConfig")]
		[SerializeField]
		protected BaseEnemyConfig prefabConfig;

		// Token: 0x04000426 RID: 1062
		[Tooltip("The name that will be appended to the config file created from this prefab (ie Behaviour..._[Roam]")]
		public string behaviourConfigSuffix;

		// Token: 0x04000427 RID: 1063
		[Tooltip("Location that the prefab config will be placed if generated from this NPC")]
		public string configSavePath;

		// Token: 0x04000428 RID: 1064
		[Header("Resting State")]
		[Range(0f, 16f)]
		public float restingRange;

		// Token: 0x04000429 RID: 1065
		[HideInInspector]
		public bool freezeWhileResting;

		// Token: 0x0400042A RID: 1066
		public bool homeIsPost;

		// Token: 0x0400042B RID: 1067
		[Header("Roam State")]
		[Range(1f, 16f)]
		public float activeRange;

		// Token: 0x0400042C RID: 1068
		public float roamSpeed;

		// Token: 0x0400042D RID: 1069
		public Vector2 roamRange;

		// Token: 0x0400042E RID: 1070
		public Vector3 roamRange3D;

		// Token: 0x0400042F RID: 1071
		public float roamAngSpeed;

		// Token: 0x04000430 RID: 1072
		[Range(0f, 1f)]
		public float roamFrequency;

		// Token: 0x04000431 RID: 1073
		public bool roamWanders;

		// Token: 0x04000432 RID: 1074
		public Vector3[] waypoints;

		// Token: 0x04000433 RID: 1075
		public GameObject[] waypointObjects;

		// Token: 0x04000434 RID: 1076
		public int currWaypoint;

		// Token: 0x04000435 RID: 1077
		public RoamArea roamArea;

		// Token: 0x04000436 RID: 1078
		public List<Vector3> usedWPList;

		// Token: 0x04000437 RID: 1079
		public List<Vector3> failedWPList;

		// Token: 0x04000438 RID: 1080
		private Vector3 _cachedDestination;

		// Token: 0x04000439 RID: 1081
		private bool _isNavAgentStopped;

		// Token: 0x0400043A RID: 1082
		public Dictionary<int, float> wpTimeLookup;

		// Token: 0x0400043B RID: 1083
		public float wpMinTime;

		// Token: 0x0400043C RID: 1084
		public Vector3 ranRoamTarget;

		// Token: 0x0400043D RID: 1085
		public Vector3 roamOffset;

		// Token: 0x0400043E RID: 1086
		protected float nextRoamTime;

		// Token: 0x0400043F RID: 1087
		public float roamWaitDuration;

		// Token: 0x04000440 RID: 1088
		public BehaviourBaseNav.RoamMode roamMode;

		// Token: 0x04000441 RID: 1089
		public BehaviourBaseNav.WaypointEvalMode waypointEvalMode;

		// Token: 0x04000442 RID: 1090
		[Range(4f, 16f)]
		[Header("Investigate State")]
		public float investigateRange;

		// Token: 0x04000443 RID: 1091
		[EnumFlags]
		[Header("Agro State General")]
		public TriggerRefProxy.NpcType agroOnNpcType;

		// Token: 0x04000444 RID: 1092
		public float breakAgroTargetDistance;

		// Token: 0x04000445 RID: 1093
		public float breakAgroHomeDistance;

		// Token: 0x04000446 RID: 1094
		public float agroedSpeed;

		// Token: 0x04000447 RID: 1095
		public float agroedAngSpeed;

		// Token: 0x04000448 RID: 1096
		public LayerMask meleeAttackMask;

		// Token: 0x04000449 RID: 1097
		public bool enableThrowAttack;

		// Token: 0x0400044A RID: 1098
		public bool throwAttackUsesGravity;

		// Token: 0x0400044B RID: 1099
		public bool forceAgentPath;

		// Token: 0x0400044C RID: 1100
		public float fwdDotThresh;

		// Token: 0x0400044D RID: 1101
		public float throwMaxRange;

		// Token: 0x0400044E RID: 1102
		public float throwMinRange;

		// Token: 0x0400044F RID: 1103
		public float throwCooldown;

		// Token: 0x04000450 RID: 1104
		public float throwVelocity;

		// Token: 0x04000451 RID: 1105
		public float gunRange;

		// Token: 0x04000452 RID: 1106
		public float gunCooldown;

		// Token: 0x04000453 RID: 1107
		[Range(0f, 10f)]
		public float accuracy;

		// Token: 0x04000454 RID: 1108
		public float reloadTime;

		// Token: 0x04000455 RID: 1109
		[Range(1f, 60f)]
		public int clipSize;

		// Token: 0x04000456 RID: 1110
		[Range(1f, 20f)]
		public int burstSize;

		// Token: 0x04000457 RID: 1111
		public float desiredGunDistance;

		// Token: 0x04000458 RID: 1112
		[ColorUsage(true, true)]
		public Color baseColor;

		// Token: 0x04000459 RID: 1113
		[ColorUsage(true, true)]
		public Color agroColor;

		// Token: 0x0400045A RID: 1114
		public Renderer[] emissionRenderers;

		// Token: 0x0400045B RID: 1115
		public bool isSoundAggroWhenInSecondaryZone;

		// Token: 0x0400045C RID: 1116
		public BehaviourBaseNav.MentalState mentalState;

		// Token: 0x0400045D RID: 1117
		public bool applyCachedMental;

		// Token: 0x0400045E RID: 1118
		public BehaviourBaseNav.MentalState cachedMentalState;

		// Token: 0x0400045F RID: 1119
		public BehaviourBaseNav.LocoState locoState;

		// Token: 0x04000460 RID: 1120
		public float aiTickFreq;

		// Token: 0x04000461 RID: 1121
		[SerializeField]
		protected Transform eyeTran;

		// Token: 0x04000462 RID: 1122
		public SubBehaviourSensors sensors;

		// Token: 0x04000463 RID: 1123
		public SubBehaviourSfx sfx;

		// Token: 0x04000464 RID: 1124
		public SubBehaviourHealth health;

		// Token: 0x04000466 RID: 1126
		protected NavMeshAgent _navAgent;

		// Token: 0x04000467 RID: 1127
		private bool _homeBound;

		// Token: 0x04000468 RID: 1128
		public Vector3 homePosition;

		// Token: 0x04000469 RID: 1129
		protected BehaviourBaseNav.MentalState _preAggroState;

		// Token: 0x0400046A RID: 1130
		protected bool investIsPosition;

		// Token: 0x0400046B RID: 1131
		protected Vector3 _investigateTarget;

		// Token: 0x0400046C RID: 1132
		protected Vector3 _targetDirWorld;

		// Token: 0x0400046D RID: 1133
		protected Vector3 _targetDirNormalWorld;

		// Token: 0x0400046E RID: 1134
		protected float _investigationCooldown;

		// Token: 0x0400046F RID: 1135
		protected float _blockCollisionsUntil;

		// Token: 0x04000470 RID: 1136
		protected float _lastAiTickTime;

		// Token: 0x04000471 RID: 1137
		protected float _lastJumpTime;

		// Token: 0x04000472 RID: 1138
		protected float _cooldownLocoSwitch;

		// Token: 0x04000473 RID: 1139
		protected float _currentRotVel;

		// Token: 0x04000474 RID: 1140
		protected float _currentRotDelta;

		// Token: 0x04000475 RID: 1141
		protected float _animatedRotVel;

		// Token: 0x04000476 RID: 1142
		protected Vector3 _animatedRoot;

		// Token: 0x04000477 RID: 1143
		protected Quaternion _localAnimatedRoot;

		// Token: 0x04000478 RID: 1144
		protected bool meleeAttackActive;

		// Token: 0x04000479 RID: 1145
		protected bool _forceAiTick;

		// Token: 0x0400047A RID: 1146
		protected int emissColor;

		// Token: 0x0400047B RID: 1147
		protected int triggerCount;

		// Token: 0x0400047C RID: 1148
		protected MaterialPropertyBlock materialPropertyBlock;

		// Token: 0x0400047D RID: 1149
		protected VisualDamageController visualDamage;

		// Token: 0x0400047E RID: 1150
		protected HashSet<Rigidbody> selfRbs;

		// Token: 0x0400047F RID: 1151
		private Vector3 navTarget;

		// Token: 0x04000480 RID: 1152
		private Vector3 flatNavTarget;

		// Token: 0x04000481 RID: 1153
		public UnityEvent OnDeath;

		// Token: 0x04000482 RID: 1154
		public UnityEvent OnDeathStart;

		// Token: 0x04000483 RID: 1155
		public Action<BehaviourBaseNav> OnPostReactivate;

		// Token: 0x04000484 RID: 1156
		private float _time;

		// Token: 0x04000485 RID: 1157
		private float _fixedTime;

		// Token: 0x04000486 RID: 1158
		private bool displayNavpath;

		// Token: 0x04000487 RID: 1159
		private bool displayCrabCones;

		// Token: 0x02000236 RID: 566
		public enum RoamMode
		{
			// Token: 0x04000E8F RID: 3727
			ZONE,
			// Token: 0x04000E90 RID: 3728
			ZONE3D,
			// Token: 0x04000E91 RID: 3729
			WAYPOINTS,
			// Token: 0x04000E92 RID: 3730
			LEGACY
		}

		// Token: 0x02000237 RID: 567
		public enum WaypointEvalMode
		{
			// Token: 0x04000E94 RID: 3732
			LINEAR,
			// Token: 0x04000E95 RID: 3733
			PING_PONG,
			// Token: 0x04000E96 RID: 3734
			RANDOM,
			// Token: 0x04000E97 RID: 3735
			RANDOM_MIN_TIME
		}

		// Token: 0x02000238 RID: 568
		public enum MentalState
		{
			// Token: 0x04000E99 RID: 3737
			Rest,
			// Token: 0x04000E9A RID: 3738
			Roam,
			// Token: 0x04000E9B RID: 3739
			Investigate,
			// Token: 0x04000E9C RID: 3740
			Agroed,
			// Token: 0x04000E9D RID: 3741
			Engaged,
			// Token: 0x04000E9E RID: 3742
			MindControlled
		}

		// Token: 0x02000239 RID: 569
		public enum LocoState
		{
			// Token: 0x04000EA0 RID: 3744
			Standing,
			// Token: 0x04000EA1 RID: 3745
			Walking,
			// Token: 0x04000EA2 RID: 3746
			Fallen,
			// Token: 0x04000EA3 RID: 3747
			GetUp,
			// Token: 0x04000EA4 RID: 3748
			Jumping,
			// Token: 0x04000EA5 RID: 3749
			InAir,
			// Token: 0x04000EA6 RID: 3750
			Grappling
		}
	}
}
