using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using RootMotion;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000E7 RID: 231
	[HelpURL("https://www.youtube.com/watch?v=LYusqeqHAUc")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Puppet Master")]
	public class PuppetMaster : MarrowBehaviour, IPoolable
	{
		// Token: 0x060008A3 RID: 2211 RVA: 0x00003F8D File Offset: 0x0000218D
		private void ResetStateSettings()
		{
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00003F8F File Offset: 0x0000218F
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00003F92 File Offset: 0x00002192
		public Animator targetAnimator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00003F94 File Offset: 0x00002194
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00003F97 File Offset: 0x00002197
		public BehaviourBase[] behaviours
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00003F99 File Offset: 0x00002199
		public bool isActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x00003F9C File Offset: 0x0000219C
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00003F9F File Offset: 0x0000219F
		public bool initiated
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00003FA1 File Offset: 0x000021A1
		public bool isBlending
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00003FA4 File Offset: 0x000021A4
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00003FA6 File Offset: 0x000021A6
		private void OnDisable()
		{
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00003FA8 File Offset: 0x000021A8
		private void OnEnable()
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00003FAA File Offset: 0x000021AA
		public static Animator[] FindAllAnimatorsInChildren(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00003FAD File Offset: 0x000021AD
		public void OnPoolInitialize()
		{
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00003FAF File Offset: 0x000021AF
		public void OnPoolSpawn()
		{
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00003FB1 File Offset: 0x000021B1
		public void OnPoolDeInitialize()
		{
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00003FB3 File Offset: 0x000021B3
		private void Awake()
		{
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00003FB5 File Offset: 0x000021B5
		private void InitParameterDicts()
		{
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00003FB7 File Offset: 0x000021B7
		public void SetParameters(bool cull = false)
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00003FB9 File Offset: 0x000021B9
		public void ReadParameters(bool cull = false)
		{
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00003FBB File Offset: 0x000021BB
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00003FBE File Offset: 0x000021BE
		private void Initiate()
		{
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00003FC0 File Offset: 0x000021C0
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00003FC2 File Offset: 0x000021C2
		private void DeactivateBehaviour(BehaviourBase behaviour)
		{
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00003FC4 File Offset: 0x000021C4
		private void OnDestroy()
		{
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00003FC6 File Offset: 0x000021C6
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00003FC8 File Offset: 0x000021C8
		protected virtual void Update()
		{
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00003FCA File Offset: 0x000021CA
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00003FCC File Offset: 0x000021CC
		protected virtual void OnLateUpdate()
		{
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00003FCE File Offset: 0x000021CE
		public void MoveToTarget()
		{
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00003FD0 File Offset: 0x000021D0
		private void Read()
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00003FD2 File Offset: 0x000021D2
		private void VisualizeTargetPose(Color color)
		{
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00003FD4 File Offset: 0x000021D4
		public void VisualizeHierarchy(Transform t, Color color)
		{
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00003FD6 File Offset: 0x000021D6
		public void VisualizeHierarchy(Transform t, Color color, float duration)
		{
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00003FD8 File Offset: 0x000021D8
		private void SetInternalCollisions(bool collide)
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00003FDA File Offset: 0x000021DA
		private void SetAngularLimits(bool limited)
		{
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00003FDC File Offset: 0x000021DC
		private void ProcessTeleport()
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00003FDE File Offset: 0x000021DE
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00003FE0 File Offset: 0x000021E0
		[ContextMenu("Flatten Muscle Hierarchy")]
		public void FlattenHierarchy()
		{
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00003FE2 File Offset: 0x000021E2
		[ContextMenu("Tree Muscle Hierarchy")]
		public void TreeHierarchy()
		{
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00003FE4 File Offset: 0x000021E4
		[ContextMenu("Fix Muscle Positions")]
		public void FixMusclePositions()
		{
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00003FE6 File Offset: 0x000021E6
		private bool HierarchyIsFlat()
		{
			return false;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00003FE9 File Offset: 0x000021E9
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00003FEB File Offset: 0x000021EB
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00003FED File Offset: 0x000021ED
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00003FF0 File Offset: 0x000021F0
		public bool isSwitchingMode
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00003FF2 File Offset: 0x000021F2
		public void DisableImmediately()
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00003FF4 File Offset: 0x000021F4
		protected virtual void SwitchModes()
		{
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00003FF6 File Offset: 0x000021F6
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00003FF9 File Offset: 0x000021F9
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00003FFC File Offset: 0x000021FC
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00003FFF File Offset: 0x000021FF
		private void UpdateInternalCollisions()
		{
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00004001 File Offset: 0x00002201
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00004003 File Offset: 0x00002203
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00004005 File Offset: 0x00002205
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00004007 File Offset: 0x00002207
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00004009 File Offset: 0x00002209
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0000400B File Offset: 0x0000220B
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0000400D File Offset: 0x0000220D
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0000400F File Offset: 0x0000220F
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00004012 File Offset: 0x00002212
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00004015 File Offset: 0x00002215
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00004018 File Offset: 0x00002218
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return false;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0000401B File Offset: 0x0000221B
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return 0;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0000401E File Offset: 0x0000221E
		public int GetMuscleIndex(Transform target)
		{
			return 0;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00004021 File Offset: 0x00002221
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return 0;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00004024 File Offset: 0x00002224
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return 0;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00004027 File Offset: 0x00002227
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0000402A File Offset: 0x0000222A
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0000402D File Offset: 0x0000222D
		private static void ValidateEntity(MarrowEntity entity)
		{
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0000402F File Offset: 0x0000222F
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00004031 File Offset: 0x00002231
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00004033 File Offset: 0x00002233
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000075C4 File Offset: 0x000057C4
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return Muscle.Group.Hips;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00004035 File Offset: 0x00002235
		private void RemoveUnnecessaryBones()
		{
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00004037 File Offset: 0x00002237
		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return false;
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0000403A File Offset: 0x0000223A
		public bool isSwitchingState
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0000403D File Offset: 0x0000223D
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00004040 File Offset: 0x00002240
		public bool isKilling
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00004042 File Offset: 0x00002242
		public bool isAlive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00004045 File Offset: 0x00002245
		public bool isFrozen
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00004048 File Offset: 0x00002248
		public bool isDead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0000404B File Offset: 0x0000224B
		public void Kill()
		{
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0000404D File Offset: 0x0000224D
		public void Kill(PuppetMaster.StateSettings stateSettings)
		{
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0000404F File Offset: 0x0000224F
		public void Freeze()
		{
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00004051 File Offset: 0x00002251
		public void Freeze(PuppetMaster.StateSettings stateSettings)
		{
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00004053 File Offset: 0x00002253
		public void Resurrect()
		{
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060008FA RID: 2298 RVA: 0x00004055 File Offset: 0x00002255
		// (remove) Token: 0x060008FB RID: 2299 RVA: 0x00004057 File Offset: 0x00002257
		public static event Action<PuppetMaster> OnDeathStatsEvent
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

		// Token: 0x060008FC RID: 2300 RVA: 0x00004059 File Offset: 0x00002259
		protected virtual void SwitchStates()
		{
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0000405B File Offset: 0x0000225B
		private IEnumerator PreKill()
		{
			return null;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0000405E File Offset: 0x0000225E
		private void PostKill()
		{
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00004060 File Offset: 0x00002260
		private void AliveToDead()
		{
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00004062 File Offset: 0x00002262
		private void AliveToFrozen()
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00004064 File Offset: 0x00002264
		private void OnFreezeFlag()
		{
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00004066 File Offset: 0x00002266
		public void ForceFreezeOnCull()
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00004068 File Offset: 0x00002268
		private void DeadToAlive()
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0000406A File Offset: 0x0000226A
		private void SetAnimationEnabled(bool to)
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0000406C File Offset: 0x0000226C
		private void DeadToFrozen()
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0000406E File Offset: 0x0000226E
		private void FrozenToAlive()
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00004070 File Offset: 0x00002270
		private void FrozenToDead()
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00004072 File Offset: 0x00002272
		public void SetFrozenMinTime(float t)
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00004074 File Offset: 0x00002274
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00004076 File Offset: 0x00002276
		private bool CanFreeze()
		{
			return false;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00004079 File Offset: 0x00002279
		public Quaternion[] StoreTargetState(out Vector3[] positions)
		{
			positions = null;
			return null;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0000407F File Offset: 0x0000227F
		public void SetTargetState(Vector3[] positions, Quaternion[] rotations)
		{
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00004081 File Offset: 0x00002281
		public void SampleTargetState()
		{
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00004083 File Offset: 0x00002283
		public void BlendToSampledState(float weight)
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00004085 File Offset: 0x00002285
		public void SampleTargetRotations(bool sampleMuscles = false)
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00004087 File Offset: 0x00002287
		public void UpdateSampledRotation(GameObject refObj, int muscleIdx)
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00004089 File Offset: 0x00002289
		public void BlendToSampledRotations(float weight, int muscleCount = -1)
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0000408B File Offset: 0x0000228B
		private void UpdateHierarchies()
		{
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0000408D File Offset: 0x0000228D
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0000408F File Offset: 0x0000228F
		private void AssignParentAndChildIndexes()
		{
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00004091 File Offset: 0x00002291
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00004093 File Offset: 0x00002293
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00004095 File Offset: 0x00002295
		private void AssignKinshipDegrees()
		{
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00004097 File Offset: 0x00002297
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00004099 File Offset: 0x00002299
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0000409B File Offset: 0x0000229B
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return 0;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0000409E File Offset: 0x0000229E
		public bool IsValid(bool log)
		{
			return false;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000040A1 File Offset: 0x000022A1
		private bool CheckMassVariation(float threshold, bool log)
		{
			return false;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000040A4 File Offset: 0x000022A4
		private bool CheckIfInitiated()
		{
			return false;
		}

		// Token: 0x04000571 RID: 1393
		[SerializeField]
		private Poolee _poolee;

		// Token: 0x04000572 RID: 1394
		[Tooltip("Humanoid Config allows you to easily share PuppetMaster properties, including individual muscle props between Humanoid puppets.")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		// Token: 0x04000573 RID: 1395
		public Transform targetRoot;

		// Token: 0x04000574 RID: 1396
		[Tooltip("Sets/sets the state of the puppet (Alive, Dead or Frozen). Frozen means the ragdoll will be deactivated once it comes to stop in dead state.")]
		public PuppetMaster.State state;

		// Token: 0x04000575 RID: 1397
		private PuppetMaster.State _initialState;

		// Token: 0x04000576 RID: 1398
		[ContextMenuItem("Reset To Default", "ResetStateSettings")]
		[Tooltip("Settings for killing and freezing the puppet.")]
		public PuppetMaster.StateSettings stateSettings;

		// Token: 0x04000577 RID: 1399
		[Tooltip("Active mode means all muscles are active and the character is physically simulated. Kinematic mode sets rigidbody.isKinematic to true for all the muscles and simply updates their position/rotation to match the target's. Disabled mode disables the ragdoll. Switching modes is done by simply changing this value, blending in/out will be handled automatically by the PuppetMaster.")]
		public PuppetMaster.Mode mode;

		// Token: 0x04000578 RID: 1400
		private PuppetMaster.Mode _initialMode;

		// Token: 0x04000579 RID: 1401
		[Tooltip("The time of blending when switching from Active to Kinematic/Disabled or from Kinematic/Disabled to Active. Switching from Kinematic to Disabled or vice versa will be done instantly.")]
		public float blendTime;

		// Token: 0x0400057A RID: 1402
		[Tooltip("Rigidbody.solverIterationCount for the muscles of this Puppet.")]
		public int solverIterationCount;

		// Token: 0x0400057B RID: 1403
		[Tooltip("If true, will draw the target's pose as green lines in the Scene view. This runs in the Editor only. If you wish to profile PuppetMaster, switch this off.")]
		public bool visualizeTargetAnimation;

		// Token: 0x0400057C RID: 1404
		[Tooltip("If true, will draw the target's pose as green lines in the Scene view. This runs in the Editor only. If you wish to profile PuppetMaster, switch this off.")]
		public bool visualizeTargetPose;

		// Token: 0x0400057D RID: 1405
		[Range(0f, 1f)]
		[Tooltip("The weight of mapping the animated character to the ragdoll pose.")]
		public float mappingWeight;

		// Token: 0x0400057E RID: 1406
		[Range(0f, 1f)]
		[Tooltip("The normalized strength of the muscles.")]
		public float muscleWeight;

		// Token: 0x0400057F RID: 1407
		[Tooltip("The positionSpring of the ConfigurableJoints' Slerp Drive.")]
		public float muscleSpring;

		// Token: 0x04000580 RID: 1408
		[Tooltip("The positionDamper of the ConfigurableJoints' Slerp Drive.")]
		public float muscleDamper;

		// Token: 0x04000581 RID: 1409
		[Tooltip("When the target has animated bones between the muscle bones, the joint anchors need to be updated in every update cycle because the muscles' targets move relative to each other in position space. This gives much more accurate results, but is computationally expensive so consider leaving it off.")]
		public bool updateJointAnchors;

		// Token: 0x04000582 RID: 1410
		[Tooltip("Should the joints use angular limits? If the PuppetMaster fails to match the target's pose, it might be because the joint limits are too stiff and do not allow for such motion. Uncheck this to see if the limits are clamping the range of your puppet's animation. Since the joints are actuated, most PuppetMaster simulations will not actually require using joint limits at all.")]
		public bool angularLimits;

		// Token: 0x04000583 RID: 1411
		[Tooltip("Should the muscles collide with each other? Consider leaving this off while the puppet is pinned for performance and better accuracy.  Since the joints are actuated, most PuppetMaster simulations will not actually require internal collisions at all.")]
		public bool internalCollisions;

		// Token: 0x04000584 RID: 1412
		[Tooltip("The Muscles managed by this PuppetMaster.")]
		public Muscle[] muscles;

		// Token: 0x04000585 RID: 1413
		public PuppetMaster.UpdateDelegate OnPostInitiate;

		// Token: 0x04000586 RID: 1414
		public PuppetMaster.UpdateDelegate OnRead;

		// Token: 0x04000587 RID: 1415
		public PuppetMaster.UpdateDelegate OnWrite;

		// Token: 0x04000588 RID: 1416
		public PuppetMaster.UpdateDelegate OnPostLateUpdate;

		// Token: 0x04000589 RID: 1417
		public PuppetMaster.UpdateDelegate OnHierarchyChanged;

		// Token: 0x0400058A RID: 1418
		public PuppetMaster.MuscleDelegate OnMuscleRemoved;

		// Token: 0x0400058B RID: 1419
		public bool cullAnimators;

		// Token: 0x0400058C RID: 1420
		public Animator[] cullableAnimators;

		// Token: 0x0400058D RID: 1421
		private Animator _targetAnimator;

		// Token: 0x0400058E RID: 1422
		private Dictionary<int, float> prefabParameters;

		// Token: 0x0400058F RID: 1423
		private Dictionary<int, float> cullParameters;

		// Token: 0x04000590 RID: 1424
		private int cachedClip;

		// Token: 0x04000593 RID: 1427
		// Token: 0x04000594 RID: 1428
		private bool internalCollisionsEnabled;

		// Token: 0x04000595 RID: 1429
		private bool angularLimitsEnabled;

		// Token: 0x04000596 RID: 1430
		private bool _awakeFailed;

		// Token: 0x04000597 RID: 1431
		private bool interpolated;

		// Token: 0x04000598 RID: 1432
		private bool freezeFlag;

		// Token: 0x04000599 RID: 1433
		private bool hasBeenDespawned;

		// Token: 0x0400059A RID: 1434
		private bool hierarchyIsFlat;

		// Token: 0x0400059B RID: 1435
		private bool _teleport;

		// Token: 0x0400059C RID: 1436
		private float _freezeFlagTime;

		// Token: 0x0400059D RID: 1437
		private Vector3 teleportPosition;

		// Token: 0x0400059E RID: 1438
		private Quaternion teleportRotation;

		// Token: 0x0400059F RID: 1439
		private bool teleportMoveToTarget;

		// Token: 0x040005A0 RID: 1440
		private float _previousAnimatorSpeed;

		// Token: 0x040005A1 RID: 1441
		private float _defaultMuscleWeight;

		// Token: 0x040005A2 RID: 1442
		private float _defaultMuscleSpring;

		// Token: 0x040005A3 RID: 1443
		private float _defaultMuscleDamper;

		// Token: 0x040005A4 RID: 1444
		private bool _isFirstInitialize;

		// Token: 0x040005A5 RID: 1445
		private float _time;

		// Token: 0x040005A6 RID: 1446
		private float _deltaTime;

		// Token: 0x040005A7 RID: 1447
		private float _fixedTime;

		// Token: 0x040005A8 RID: 1448
		private float _lastFixedTime;

		// Token: 0x040005AA RID: 1450
		private PuppetMaster.Mode activeMode;

		// Token: 0x040005AB RID: 1451
		private PuppetMaster.Mode lastMode;

		// Token: 0x040005AC RID: 1452
		private float mappingBlend;

		// Token: 0x040005AE RID: 1454
		private bool _hasPreKilled;

		// Token: 0x040005AF RID: 1455
		private bool _hasPostKilled;

		// Token: 0x040005B0 RID: 1456
		public PuppetMaster.UpdateDelegate OnFreeze;

		// Token: 0x040005B1 RID: 1457
		public PuppetMaster.UpdateDelegate OnUnfreeze;

		// Token: 0x040005B2 RID: 1458
		public PuppetMaster.UpdateDelegate OnDeath;

		// Token: 0x040005B3 RID: 1459
		public PuppetMaster.UpdateDelegate OnResurrection;

		// Token: 0x040005B5 RID: 1461
		private PuppetMaster.State activeState;

		// Token: 0x040005B6 RID: 1462
		private PuppetMaster.State lastState;

		// Token: 0x040005B7 RID: 1463
		private bool angularLimitsEnabledOnKill;

		// Token: 0x040005B8 RID: 1464
		private bool internalCollisionsEnabledOnKill;

		// Token: 0x040005B9 RID: 1465
		private bool animationDisabledbyStates;

		// Token: 0x040005BA RID: 1466
		private float aliveToFrozenMinTime;

		// Token: 0x040005BB RID: 1467
		private Transform[] targetChildren;

		// Token: 0x040005BC RID: 1468
		private Vector3[] targetStoredPositions;

		// Token: 0x040005BD RID: 1469
		private Quaternion[] targetStoredRotations;

		// Token: 0x040005BE RID: 1470
		private Vector3[] targetSampledPositions;

		// Token: 0x040005BF RID: 1471
		private Quaternion[] targetSampledRotations;

		// Token: 0x040005C0 RID: 1472
		private Quaternion[] _sampledRotations;

		// Token: 0x040005C1 RID: 1473
		private bool sampleTargetMappedState;

		// Token: 0x040005C2 RID: 1474
		private bool hasProp;

		// Token: 0x02000249 RID: 585
		[Serializable]
		public enum Mode
		{
			// Token: 0x04000EEC RID: 3820
			Active,
			// Token: 0x04000EED RID: 3821
			Disabled
		}

		// Token: 0x0200024A RID: 586
		// (Invoke) Token: 0x0600113B RID: 4411
		public delegate void UpdateDelegate();

		// Token: 0x0200024B RID: 587
		// (Invoke) Token: 0x0600113F RID: 4415
		public delegate void MuscleDelegate(Muscle muscle);

		// Token: 0x0200024C RID: 588
		[Serializable]
		public enum State
		{
			// Token: 0x04000EEF RID: 3823
			Alive,
			// Token: 0x04000EF0 RID: 3824
			Dead,
			// Token: 0x04000EF1 RID: 3825
			Frozen
		}

		// Token: 0x0200024D RID: 589
		[Serializable]
		public struct StateSettings
		{

			// Token: 0x17000324 RID: 804
			// (get) Token: 0x06001143 RID: 4419 RVA: 0x000088B4 File Offset: 0x00006AB4
			public static PuppetMaster.StateSettings Default
			{
				get
				{
					return default(PuppetMaster.StateSettings);
				}
			}

			// Token: 0x04000EF2 RID: 3826
			[Tooltip("How much does it take to weigh out muscle weight to deadMuscleWeight?")]
			public float killDuration;

			// Token: 0x04000EF3 RID: 3827
			[Tooltip("The muscle weight mlp while the puppet is Dead.")]
			public float deadMuscleWeight;

			// Token: 0x04000EF4 RID: 3828
			[Tooltip("The muscle damper add while the puppet is Dead.")]
			public float deadMuscleDamper;

			// Token: 0x04000EF5 RID: 3829
			[Tooltip("The max square velocity of the ragdoll bones for freezing the puppet.")]
			public float maxFreezeSqrVelocity;

			// Token: 0x04000EF6 RID: 3830
			[Tooltip("If true, will enable angular limits when killing the puppet.")]
			public bool enableAngularLimitsOnKill;

			// Token: 0x04000EF7 RID: 3831
			[Tooltip("If true, will enable internal collisions when killing the puppet.")]
			public bool enableInternalCollisionsOnKill;
		}
	}
}
