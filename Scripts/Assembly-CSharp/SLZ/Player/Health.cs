using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Combat;
using SLZ.Rig;
using SLZ.SFX;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Player
{
	public class Health : MonoBehaviour
	{
		public enum HealthMode
		{
			Invincible = 0,
			Mortal = 1,
			InsantDeath = 2
		}

		[Serializable]
		public struct UsageSettings
		{
			public float hips;

			public float spine;

			public float legLf;

			public float legRt;

			public float armLf;

			public float armRt;

			public static UsageSettings Default => default(UsageSettings);

			public UsageSettings(float hips = 1f, float spine = 1f, float legLf = 1f, float legRt = 1f, float armLf = 1f, float armRt = 1f)
			{
				this.hips = 0f;
				this.spine = 0f;
				this.legLf = 0f;
				this.legRt = 0f;
				this.armLf = 0f;
				this.armRt = 0f;
			}
		}

		[CompilerGenerated]
		private sealed class _003CBleedOverTimer_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private float _003Ct_003E5__2;

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
			public _003CBleedOverTimer_003Ed__67(int _003C_003E1__state)
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

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		protected RigManager _rigManager;

		protected HeadSFX _headSfx;

		public HealthMode healthMode;

		protected HealthMode prevHealthMode;

		[Header("HEALTH")]
		[Space(10f)]
		public float max_Health;

		public float cur_arm_lf;

		public float cur_arm_rt;

		public float cur_leg_lf;

		public float cur_leg_rt;

		public float stun_spine;

		public float stun_arm_lf;

		public float stun_arm_rt;

		public float stun_leg_lf;

		public float stun_leg_rt;

		public float usage_hips;

		public float usage_spine;

		public float usage_arm_lf;

		public float usage_arm_rt;

		public float usage_leg_lf;

		public float usage_leg_rt;

		public bool stunActive;

		[SerializeField]
		public float curr_Health;

		[HideInInspector]
		public bool alive;

		[SerializeField]
		protected bool _testRagdollOnDeath;

		[SerializeField]
		protected bool _testVisualDamage;

		public bool deathIsImminent;

		protected Coroutine _deathRoutine;

		[NonSerialized]
		private const int MAX_HITS = 32;

		[NonSerialized]
		private int Count;

		[NonSerialized]
		private List<Matrix4x4> HitPoint;

		[NonSerialized]
		private Matrix4x4[] HitPos;

		[NonSerialized]
		private const int MAX_HITS_CUT = 8;

		[NonSerialized]
		private int Count_CUT;

		[NonSerialized]
		private List<Matrix4x4> CutPoint;

		[NonSerialized]
		private Matrix4x4[] CutPos;

		[Tooltip("Renderers to set hit variables for")]
		public Renderer[] Renderers;

		public float meshScaleFactor;

		public float hitScaleFactor;

		private int NumberOfHits;

		private int NumberOfCuts;

		private int NumberOfHitsID;

		private int EllipsoidPosArrayID;

		private int ElipsoidMatricesID;

		private int NumberOfElipsoidsID;

		protected virtual void Awake()
		{
		}

		public virtual void OnReceivedDamage(Attack attack, PlayerDamageReceiver.BodyPart part)
		{
		}

		public virtual void OnCollision(Collision collision, PlayerDamageReceiver.BodyPart part)
		{
		}

		private void VisualDamage(Attack attack, PlayerDamageReceiver.BodyPart part)
		{
		}

		public virtual void TAKEDAMAGE(float damage)
		{
		}

		public virtual void Dying(float damage)
		{
		}

		public virtual void Death()
		{
		}

		public void TeleportToCheckpoint()
		{
		}

		public virtual void Respawn()
		{
		}

		public virtual void SetFullHealth()
		{
		}

		public virtual void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public void SetHealthMode(int newHealthMode)
		{
		}

		public void SetUsage(float hips, float spine = 1f, float legLf = 1f, float legRt = 1f, float armLf = 1f, float armRt = 1f)
		{
		}

		public void SetUsage(UsageSettings s)
		{
		}

		public void UpdateMuscleStates(float footSupported)
		{
		}

		public bool isLODVisible()
		{
			return false;
		}

		public void AddToHitArray(Matrix4x4 Matrix)
		{
		}

		public void AddToCutArray(Matrix4x4 Matrix)
		{
		}

		public void ResetHits()
		{
		}

		private void InitializeBlock()
		{
		}

		public void UpdateArray()
		{
		}

		[IteratorStateMachine(typeof(_003CBleedOverTimer_003Ed__67))]
		private IEnumerator BleedOverTimer()
		{
			return null;
		}
	}
}
