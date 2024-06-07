using System;
using System.Collections;
using SLZ.Marrow.Pool;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001B9 RID: 441
	public class AIBrain : SpawnEvents
	{
		// Token: 0x06000FA8 RID: 4008 RVA: 0x0000534C File Offset: 0x0000354C
		public void SpawnGroupIgnore(bool val)
		{
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x0000856C File Offset: 0x0000676C
		public BehaviourBaseNav.MentalState MentalState
		{
			get
			{
				return BehaviourBaseNav.MentalState.Rest;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0000534E File Offset: 0x0000354E
		public bool IsSoundAggroWhenInSecondaryZone
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00005351 File Offset: 0x00003551
		protected override void Reset()
		{
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00005353 File Offset: 0x00003553
		protected override void Awake()
		{
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00005355 File Offset: 0x00003555
		public override void OnPoolInitialize()
		{
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00005357 File Offset: 0x00003557
		public override void OnPoolDeInitialize()
		{
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00005359 File Offset: 0x00003559
		public void SetBaseConfig(BaseEnemyConfig config)
		{
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0000535B File Offset: 0x0000355B
		public void SetVelocity(Vector3 velocity)
		{
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x0000535D File Offset: 0x0000355D
		public void SetAngularVelocity(Vector3 angularVelocity)
		{
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0000535F File Offset: 0x0000355F
		public void SetAngularVelocity(float minAngularSpeed, float maxAngularSpeed)
		{
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00005361 File Offset: 0x00003561
		private void OnDeath()
		{
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00005363 File Offset: 0x00003563
		private void OnResurrection()
		{
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00005365 File Offset: 0x00003565
		public void StartArenaEntranceTimer(float time = 120f)
		{
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00005367 File Offset: 0x00003567
		public void StopArenaEntranceTimer()
		{
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00005369 File Offset: 0x00003569
		private IEnumerator CoArenaEntrance()
		{
			return null;
		}

		// Token: 0x04000B4E RID: 2894
		[Header("References")]
		public BehaviourBaseNav behaviour;

		// Token: 0x04000B4F RID: 2895
		public PuppetMaster puppetMaster;

		// Token: 0x04000B50 RID: 2896
		public bool dontClearBaseConfig;

		// Token: 0x04000B51 RID: 2897
		public Action<AIBrain> onDeathDelegate;

		// Token: 0x04000B52 RID: 2898
		public Action<AIBrain> onResurrectDelegate;

		// Token: 0x04000B53 RID: 2899
		public Action<AIBrain> onNPC_DeathDelegate;

		// Token: 0x04000B54 RID: 2900
		public AIBrain.SpawnGroupEvent OnGroupDeregister;

		// Token: 0x04000B55 RID: 2901
		[HideInInspector]
		public bool isDead;

		// Token: 0x04000B56 RID: 2902
		private bool _wasConfigSet;

		// Token: 0x04000B57 RID: 2903
		private Coroutine arenaEntranceRoutine;

		// Token: 0x04000B58 RID: 2904
		private float entranceTimer;

		// Token: 0x020002BF RID: 703
		public class SpawnGroupEvent : UnityEvent<AIBrain, bool>
		{
		}
	}
}
